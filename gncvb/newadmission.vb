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
    End Sub

    Private Sub Cbdept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbdept.SelectedIndexChanged
        cbclass.Items.Clear()

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

	Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox3.SelectedIndexChanged
		cnn.open()
		cmd.connection = cnn
		ProcessCmdKey.commandText = "select * from dept"
		Dim dr As
			oleDbDataReader = ProcessCmdKey.ExecuteReader


		While dr.Read
			cmbempname.items.add(dr.item(0))

		End While
		dr.close



	End Sub
End Class