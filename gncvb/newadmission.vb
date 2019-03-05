Public Class newadmission
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        main1.Show()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub newadmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

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