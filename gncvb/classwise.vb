Imports System.Data.OleDb
Imports gncvb.Db
Public Class classwise
	Dim dr As OleDbDataReader
	Dim sql As String
	Private Sub pfbtcancel_Click(sender As Object, e As EventArgs) Handles pfbtcancel.Click
		Me.Hide()
		main1.Show()

	End Sub

	Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles classwisedept.SelectedIndexChanged
		classwisedept.Items.Clear()
		classwisesem.Items.Clear()
		Sql = "select distinct(class) from courses where dept='" + classwisedept.Text + "'"
		dr = Db.Selectqry(Sql)
		While (dr.Read())
			classwiseclass.Items.Add(dr("class"))
		End While
	End Sub

	Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles classwiseclass.SelectedIndexChanged

	End Sub

	Private Sub classwise_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class