Imports gncvb
Imports System.Data.OleDb

Public Class changefee
    Dim Sql As String
    Dim dr As OleDbDataReader

    Private Sub changefee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Sql = "select distinct(dept) from courses"
            dr = Db.Selectqry(Sql)
            While (dr.Read())
                cfdept.Items.Add(dr("dept"))
            End While
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    Private Sub cfdept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cfdept.SelectedIndexChanged
        cfclass.Items.Clear()
        cfsem.Items.Clear()
        Sql = "select distinct(class) from courses where dept='" + cfdept.Text + "'"
        dr = Db.Selectqry(Sql)
        While (dr.Read())
            cfclass.Items.Add(dr("class"))
        End While
    End Sub



    Private Sub sfbtsubmit_Click(sender As Object, e As EventArgs) Handles sfbtsubmit.Click
        Try
            Sql = "update total_fees set fess='" + cffee.Text + "'where dept='" + cfdept.Text + "' and class='" + cfsem.Text + "' and sem='" + cfsem.Text + "'"
            Db.Updateqry(Sql)
            MessageBox.Show("Fees Updated Successfully")
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try

    End Sub

    Private Sub sfbtcncel_Click(sender As Object, e As EventArgs) Handles sfbtcncel.Click
        Me.Hide()
        main1.Show()

    End Sub

    Private Sub cfclass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cfclass.SelectedIndexChanged
        cfsem.Items.Clear()

        Sql = "select sem from courses where class='" + cfclass.Text + "'"
        dr = Db.Selectqry(Sql)
        dr.Read()
        Dim a As Integer
        a = CInt(dr("sem"))
        For i = 1 To a
            cfsem.Items.Add(i)
        Next
    End Sub
End Class