Imports System.Data.OleDb
Imports gncvb.Db

Public Class rough
    Dim dr As OleDbDataReader
    Dim sql As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckedListBox1.Items.Clear()
        sql = "select distinct(dept) from courses"
        dr = Db.Selectqry(Sql)
        While (dr.Read())
            nmdept.Items.Add(dr("dept"))
        End While
    End Sub

    Private Sub nmdept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nmdept.SelectedIndexChanged
        nmclass.Items.Clear()
        nmsem.Items.Clear()
        sql = "select distinct(class) from courses where dept='" + nmdept.Text + "'"
        dr = Db.Selectqry(Sql)
        While (dr.Read())
            nmclass.Items.Add(dr("class"))
        End While
    End Sub

    Private Sub nmclass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nmclass.SelectedIndexChanged
        nmsem.Items.Clear()

        sql = "select sem from courses where class='" + nmclass.Text + "'"
        dr = Db.Selectqry(Sql)
        dr.Read()
        Dim a As Integer
        a = dr("sem")
        For i = 1 To a
            nmsem.Items.Add(i)
        Next
    End Sub

    Private Sub nmsem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nmsem.SelectedIndexChanged
        sql = "select subject from course_1 where sem=" + nmsem.Text + " and class='" + nmclass.Text + "'"
        dr = Db.Selectqry(sql)
        While (dr.Read())
            CheckedListBox1.Items.Add(dr("subject"))
        End While
        
    End Sub

    Private Sub nmbtlogin_Click(sender As Object, e As EventArgs) Handles nmbtlogin.Click
        For Each item1 As String In CheckedListBox1.CheckedItems
            Dim a As String
            a = item1
            sql = "insert into abc values(""" & nmdept.Text & """,""" + nmclass.Text + """," + nmsem.Text + ",""" + a + """)"
            Console.WriteLine(sql)
            Db.Updateqry(sql)
        Next

        MessageBox.Show("Data Inserted Succesfully")
    End Sub
End Class