Imports System.Data.OleDb
Imports gncvb.Db

Public Class newadmission
    Dim dr As OleDbDataReader
    Dim sql As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles nmbtcncel.Click
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
        nmscholarship.Items.Add("Yes")
        nmscholarship.Items.Add("No")
        nmcbcaste.Items.Add("General")
        nmcbcaste.Items.Add("SC/ST")
        nmcbcaste.Items.Add("BC")
        nmcbcaste.Items.Add("OBC")


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

        sql = "select sem from courses where class='" + nmclass.Text + "'"
        dr = Db.Selectqry(sql)
        dr.Read()
        Dim a As Integer
        a = dr("sem")
        For i = 1 To a
            nmsem.Items.Add(i)
        Next
    End Sub

    Private Sub nmsem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nmsem.SelectedIndexChanged
        nmsub.Items.Clear()
        sql = "select subject from course_1 where sem=" + nmsem.Text + " and class='" + nmclass.Text + "'"
        dr = Db.Selectqry(sql)
        While (dr.Read())
            nmsub.Items.Add(dr("subject"))
        End While
    End Sub

    Private Sub nmbtlogin_Click(sender As Object, e As EventArgs) Handles nmbtlogin.Click
        Dim dt As String = nmdob.ToString
        Dim a As Int32
        a = dt.Length
        Console.WriteLine(a)
        Dim dts As String = dt.Substring(44, 10)

        Console.WriteLine(dts)

        sql = "insert into s_info values (" + nmcroll.Text + ",""" + nmfirstname.Text + """,""" + nmlastname.Text + """,""" + nmfathername.Text + """,""" + nmmothername.Text + """,""" + nmdob.ToString() + """,""" + nmgender.Text + """,""" + nmpa.Text + """,""" + nmca.Text + """," + nmsmnumber.Text + "," + nmpmnumber.Text + ",""" + nmemail.Text + """,""" + nmcbcaste.Text + """,""" + nmreligion.Text + """,""" + nmnational.Text + """," + nmadnumber.Text + "," + nmaincome.Text + ",""" + nmconveyance.Text + """,""" + nmdept.Text + """,""" + nmclass.Text + """,""" + nmsem.Text + """)"
        Db.Updateqry(sql)
        For Each item1 As String In nmsub.CheckedItems
            sql = "insert into stu_subject values (" + nmcroll.Text + ",""" + nmsem.Text + """," + item1 + ")"
        Next

    End Sub
End Class