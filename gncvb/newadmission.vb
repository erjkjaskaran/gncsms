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
			cbdept.Items.Add(dr("dept"))
		End While
		cbgender.Items.Add("Male")
		cbgender.Items.Add("Female")
		cbgender.Items.Add("Transgender")
	End Sub

	Private Sub Cbdept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbdept.SelectedIndexChanged
		cbclass.Items.Clear()
		cbsem.Items.Clear()
		sql = "select distinct(class) from courses where dept='" + cbdept.Text + "'"
		dr = Db.Selectqry(sql)
		While (dr.Read())
			cbclass.Items.Add(dr("class"))
		End While
	End Sub

	Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbaddress.CheckedChanged

		If (cbaddress.CheckState = 1) Then
			txtbca.Text = txtbpa.Text
		ElseIf (cbaddress.CheckState = 0) Then
			txtbca.Text = ""
		End If
	End Sub

	Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

	End Sub

	Private Sub cbclass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbclass.SelectedIndexChanged
        cbsem.Items.Clear()
        cbsub1.Items.Clear()
        cbsub2.Items.Clear()
        cbsub3.Items.Clear()
        cbsub4.Items.Clear()
        cbsub5.Items.Clear()
        cbsub6.Items.Clear()
        sql = "select sem from courses where class='" + cbclass.Text + "'"
        dr = Db.Selectqry(sql)
		dr.Read()
		Dim a As Integer
		a = dr("sem")

        For i = 1 To a
			cbsem.Items.Add(i)
		Next



    End Sub

	Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsem.SelectedIndexChanged
        sql = "select subject from course_1 where class='" + cbclass.Text + "' and sem=" + cbsem.Text
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

    Private Sub cbsub1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsub1.SelectedIndexChanged
        cbsub2.Items.Remove(cbsub1.Text)
        cbsub3.Items.Remove(cbsub1.Text)
        cbsub4.Items.Remove(cbsub1.Text)
        cbsub5.Items.Remove(cbsub1.Text)
        cbsub6.Items.Remove(cbsub1.Text)
    End Sub

    Private Sub cbsub2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsub2.SelectedIndexChanged
        cbsub1.Items.Remove(cbsub1.Text)
        cbsub3.Items.Remove(cbsub1.Text)
        cbsub4.Items.Remove(cbsub1.Text)
        cbsub5.Items.Remove(cbsub1.Text)
        cbsub6.Items.Remove(cbsub1.Text)
    End Sub

    Private Sub cbsub3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsub3.SelectedIndexChanged
        cbsub1.Items.Remove(cbsub1.Text)
        cbsub2.Items.Remove(cbsub1.Text)
        cbsub4.Items.Remove(cbsub1.Text)
        cbsub5.Items.Remove(cbsub1.Text)
        cbsub6.Items.Remove(cbsub1.Text)
    End Sub

    Private Sub cbsub4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsub4.SelectedIndexChanged
        cbsub1.Items.Remove(cbsub1.Text)
        cbsub2.Items.Remove(cbsub1.Text)
        cbsub3.Items.Remove(cbsub1.Text)
        cbsub5.Items.Remove(cbsub1.Text)
        cbsub6.Items.Remove(cbsub1.Text)
    End Sub

    Private Sub cbsub5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsub5.SelectedIndexChanged
        cbsub1.Items.Remove(cbsub1.Text)
        cbsub2.Items.Remove(cbsub1.Text)
        cbsub3.Items.Remove(cbsub1.Text)
        cbsub4.Items.Remove(cbsub1.Text)
        cbsub6.Items.Remove(cbsub1.Text)
    End Sub

    Private Sub cbsub6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsub6.SelectedIndexChanged
        cbsub1.Items.Remove(cbsub1.Text)
        cbsub2.Items.Remove(cbsub1.Text)
        cbsub3.Items.Remove(cbsub1.Text)
        cbsub4.Items.Remove(cbsub1.Text)
        cbsub5.Items.Remove(cbsub1.Text)

    End Sub
End Class