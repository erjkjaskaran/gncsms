Imports gncvb
Imports System.Data.OleDb

Public Class changesub
    Dim Sql As String
    Dim dr As OleDbDataReader

    Private Sub changesub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Sql = "select distinct(dept) from courses"
            dr = Db.Selectqry(Sql)
            While (dr.Read())
                csdept.Items.Add(dr("dept"))
            End While
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    Private Sub csdept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles csdept.SelectedIndexChanged
        csclass.Items.Clear()
        cssem.Items.Clear()
        Sql = "select distinct(class) from courses where dept='" + csdept.Text + "'"
        dr = Db.Selectqry(Sql)
        While (dr.Read())
            csclass.Items.Add(dr("class"))
        End While
    End Sub

    Private Sub csclass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles csclass.SelectedIndexChanged
        cssem.Items.Clear()

        Sql = "select sem from courses where class='" + csclass.Text + "'"
        dr = Db.Selectqry(Sql)
        dr.Read()
        Dim a As Integer
        a = CInt(dr("sem"))
        For i = 1 To a
            cssem.Items.Add(i)
        Next
    End Sub

    Private Sub cssem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cssem.SelectedIndexChanged
        Try
            csoldsub.Items.Clear()
            Sql = "select a.subject as sub from course_1 as a, courses as b where a.class=b.class and b.dept='" + csdept.Text + "' and a.class='" + csclass.Text + "' and a.sem='" + cssem.Text + "'"
            dr = Db.Selectqry(Sql)
            While (dr.Read)
                csoldsub.Items.Add(dr("sub"))
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub sfbtsubmit_Click(sender As Object, e As EventArgs) Handles sfbtsubmit.Click
        Try
            Sql = "Update course_1 set subject='" + csnewsub.Text + "' where class='" + csclass.Text + "' and sem='" + cssem.Text + "' and subject='" + csoldsub.Text + "'"
            Db.Updateqry(Sql)
            MessageBox.Show("Subject Updated Succesfully")
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
End Class