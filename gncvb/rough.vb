Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports gncvb.Db

Public Class rough
    Dim dr As OleDbDataReader
    Dim sql As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        Dim dt As New DataTable
        dt.Load(dr)

        DataGridView1.DataSource = dt
        DataGridView1.Columns(0).Name = "Subject"


    End Sub


End Class