Imports System.Data.OleDb
Imports gncvb.Db
Public Class Form2
	Dim dr As OleDbDataReader
	Dim sql As String
	Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

	End Sub

	Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles subwiseclass.SelectedIndexChanged
		subwisesem.Items.Clear()

		sql = "select sem from courses where class='" + subwiseclass.Text + "'"
		dr = Db.Selectqry(sql)
		dr.Read()
		Dim a As Integer
		a = dr("sem")
		For i = 1 To a
			subwisesem.Items.Add(i)
		Next
	End Sub

	Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles subwisesem.SelectedIndexChanged
		subwisesub.Items.Clear()
		sql = "select subject from course_1 where sem=" + subwisesem.Text + " and class='" + subwiseclass.Text + "'"
		dr = Db.Selectqry(sql)
		While (dr.Read())
			subwisesub.Items.Add(dr("subject"))
		End While
	End Sub

	Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles subwisesub.SelectedIndexChanged

	End Sub

	Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

	End Sub

	Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

	End Sub

	Private Sub rabtcancel_Click(sender As Object, e As EventArgs) Handles rabtcancel.Click
		Me.Hide()
		main1.Show()
	End Sub

	Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
		Me.Hide()
		main1.Show()

	End Sub

	Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Try
			sql = "select distinct(dept) from courses"
			dr = Db.Selectqry(sql)
			While (dr.Read())
				subwisedept.Items.Add(dr("dept"))
			End While
		Catch ex As Exception
			MessageBox.Show(String.Format("Error: {0}", ex.Message))
		End Try
	End Sub

	Private Sub subwisedept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles subwisedept.SelectedIndexChanged
		subwiseclass.Items.Clear()
		subwisesem.Items.Clear()
		sql = "select distinct(class) from courses where dept='" + subwisedept.Text + "'"
		dr = Db.Selectqry(sql)
		While (dr.Read())
			subwiseclass.Items.Add(dr("class"))
		End While
	End Sub
End Class