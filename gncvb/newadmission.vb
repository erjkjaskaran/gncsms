Imports System.Data.OleDb
Imports gncvb.Db

Public Class newadmission
    Dim dr As OleDbDataReader
    Dim sql As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        main1.Show()

    End Sub

    Private Sub Newadmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select distinct(dept) from courses"
        dr = Db.Selectqry(sql)
        While (dr.Read())
            nmdept.Items.Add(dr("dept"))
        End While
        nmgender.Items.Add("Male")
        nmgender.Items.Add("Female")
        nmgender.Items.Add("Transgender")
        nmscholership.Items.Add("Yes")
        nmscholership.Items.Add("No")


    End Sub

    Private Sub Cbdept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nmdept.SelectedIndexChanged
        nmclass.Items.Clear()
        nmsem.Items.Clear()
        sql = "select distinct(class) from courses where dept='" + nmdept.Text + "'"
        dr = Db.Selectqry(sql)
        While (dr.Read())
            nmclass.Items.Add(dr("class"))
        End While
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbaddress.CheckedChanged

        If (cbaddress.CheckState = 1) Then
            nmca.Text = nmpa.Text
        ElseIf (cbaddress.CheckState = 0) Then
            nmca.Text = ""
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles nmconveyance.TextChanged

    End Sub

    Private Sub cbclass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nmclass.SelectedIndexChanged
        nmsem.Items.Clear()
        nmsub1.Items.Clear()
        nmsub2.Items.Clear()
        nmsub3.Items.Clear()
        nmsub4.Items.Clear()
        nmsub5.Items.Clear()
        nmsub6.Items.Clear()
        sql = "select sem from courses where class='" + nmclass.Text + "'"
        dr = Db.Selectqry(sql)
        dr.Read()
        Dim a As Integer
        a = dr("sem")
        Console.WriteLine(a)
        For i = 1 To a
            cbsem.Items.Add(i)
        Next
        sql = "select subject from course_1 where class='" + cbclass.Text + "'"
        dr = Db.Selectqry(sql)
        While (dr.Read())
            cbsub1.Items.Add(dr("subject"))
            cbsub2.Items.Add(dr("subject"))
            cbsub3.Items.Add(dr("subject"))
            cbsub4.Items.Add(dr("subject"))
            cbsub5.Items.Add(dr("subject"))
            cbsub6.Items.Add(dr("subject"))
        End While


    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsem.SelectedIndexChanged

    End Sub
End Class