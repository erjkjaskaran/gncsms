Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports gncvb.Db

Public Class newadmission
    Dim dr As OleDbDataReader
    Dim sql As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles nmbtcncel.Click
        Me.Hide()
        main1.Show()

    End Sub

    Private Sub Newadmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            sql = "select distinct(dept) from courses"
            dr = Db.Selectqry(sql)
            While (dr.Read())
                nmdept.Items.Add(dr("dept"))
            End While
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try

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
        a = CInt(dr("sem"))
        For i = 1 To a
            nmsem.Items.Add(i)
        Next
    End Sub

    Private Sub Nmsem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nmsem.SelectedIndexChanged
        nmsub.Items.Clear()
        sql = "select subject from course_1 where sem=" + nmsem.Text + " and class='" + nmclass.Text + "'"
        dr = Db.Selectqry(sql)
        While (dr.Read())
            nmsub.Items.Add(dr("subject"))
        End While
        sql = "select fess from total_fees where dept='" + nmdept.Text + "' and sem='" + nmsem.Text + "' and class='" + nmclass.Text + "'"
        dr = Db.Selectqry(sql)
        If (dr.HasRows) Then
            Console.WriteLine("abcbbcbcbcbc")
        End If
        nmtotalfees.Text = CType(dr("fess"), String)
        nmtotalfees.ReadOnly = True
    End Sub

    Private Sub Nmbtlogin_Click(sender As Object, e As EventArgs) Handles Nmbtlogin.Click
        Dim dt As String = nmdob.ToString

        Dim dts As String = dt.Substring(44, 10)
        If (nmcroll.Text = "") Then
            MessageBox.Show("Enter College Roll No.")
        ElseIf (nmfirstname.Text = "") Then
            MessageBox.Show("Enter First Name")
        ElseIf (nmlastname.Text = "") Then
            MessageBox.Show("Enter Last Name")


        Else
            sql = "insert into s_info values (" + nmcroll.Text + ",""" + nmfirstname.Text + """,""" + nmlastname.Text + """,""" + nmfathername.Text + """,""" + nmmothername.Text + """,""" + dts + """,""" + nmgender.Text + """,""" + nmpa.Text + """,""" + nmca.Text + """," + nmsmnumber.Text + "," + nmpmnumber.Text + ",""" + nmemail.Text + """,""" + nmcbcaste.Text + """,""" + nmreligion.Text + """,""" + nmnational.Text + """," + nmadnumber.Text + "," + nmaincome.Text + ",""" + nmconveyance.Text + """,""" + nmdept.Text + """,""" + nmclass.Text + """,""" + nmsem.Text + """)"
            Db.Updateqry(sql)
            For Each item1 As String In nmsub.CheckedItems
                sql = "insert into stu_subject values (" + nmcroll.Text + ",""" + nmsem.Text + """,""" + item1 + """)"
                Db.Updateqry(sql)
            Next
            MessageBox.Show("Data Inserted Succesfully")
        End If




    End Sub

    Private Sub nmsmnumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nmsmnumber.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub nmsmnumber_TextChanged(sender As Object, e As EventArgs) Handles nmsmnumber.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        nmsmnumber.Text = digitsOnly.Replace(nmsmnumber.Text, "")
    End Sub

    Private Sub nmpmnumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nmpmnumber.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub nmpmnumber_TextChanged(sender As Object, e As EventArgs) Handles nmpmnumber.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        nmpmnumber.Text = digitsOnly.Replace(nmpmnumber.Text, "")
    End Sub

    Private Sub nmemail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles nmemail.Validating
        Dim pattern As String = "^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"
        Dim match As System.Text.RegularExpressions.Match = Regex.Match(nmemail.Text.Trim(), pattern, RegexOptions.IgnoreCase)
        If (match.Success) Then

        Else
            MessageBox.Show("Please enter a valid email id", "Checking")
            nmemail.Clear()
        End If
    End Sub

    Private Sub nmadnumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nmadnumber.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub nmadnumber_TextChanged(sender As Object, e As EventArgs) Handles nmadnumber.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        nmadnumber.Text = digitsOnly.Replace(nmadnumber.Text, "")
    End Sub

    Private Sub nmaincome_TextChanged(sender As Object, e As EventArgs) Handles nmaincome.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        nmaincome.Text = digitsOnly.Replace(nmaincome.Text, "")
    End Sub

    Private Sub nmbankac_TextChanged(sender As Object, e As EventArgs) Handles nmbankac.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        nmbankac.Text = digitsOnly.Replace(nmbankac.Text, "")
    End Sub

    Private Sub nmammountpaid_TextChanged(sender As Object, e As EventArgs) Handles nmammountpaid.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        nmammountpaid.Text = digitsOnly.Replace(nmammountpaid.Text, "")
    End Sub

    Private Sub nmammountpaid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nmammountpaid.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub nmbankac_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nmbankac.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub nmaincome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nmaincome.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub nmammountpaid_Leave(sender As Object, e As EventArgs) Handles nmammountpaid.Leave
        Dim i As Integer
        i = CInt(nmtotalfees.Text) - CInt(nmammountpaid.Text)
        nmamountleft.Text = CType(i, String)
    End Sub
End Class