Imports System.Data.OleDb
Imports gncvb.Db
Public Class list_pending_fees
	Dim dr As OleDbDataReader
	Dim sql As String
	Private Sub list_pending_fees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Sql = "select distinct(dept) from courses"
		dr = Db.Selectqry(Sql)
		While (dr.Read())
			pfdept.Items.Add(dr("dept"))
		End While
	End Sub

	Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
		Me.Hide()
		main1.Show()
	End Sub

	Private Sub pfbtcancel_Click(sender As Object, e As EventArgs) Handles pfbtcancel.Click
		Me.Hide()
		main1.Show()
	End Sub

	Private Sub pfdept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pfdept.SelectedIndexChanged

	End Sub

End Class