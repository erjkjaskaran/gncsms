Imports gncvb.Db
Imports System.Data.OleDb

Public Class readmission
    Dim dr As OleDbDataReader
    Dim sql As String
    Private Sub nmbtcncel_Click(sender As Object, e As EventArgs) Handles nmbtcncel.Click

		Me.Hide()
		main1.Show()

    End Sub



    Private Sub prollno_TabIndexChanged(sender As Object, e As EventArgs) Handles prollno.TabIndexChanged


    End Sub

    Private Sub prollno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles prollno.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub readmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub prollno_Leave(sender As Object, e As EventArgs) Handles prollno.Leave
		If (prollno.Text = "") Then

		Else
			Console.WriteLine("abcasgf")
			sql = "select * from s_info where croll=" + prollno.Text
			dr = Db.Selectqry(sql)
			dr.Read()
			radept.Text = CType(dr("dept"), String)
			raclass.Text = CType(dr("class"), String)
			Dim sem As Integer
			sem = CInt(dr("sem"))
			sem = sem + 1
			rasem.Text = CType(sem, String)
			radept.ReadOnly = True
			raclass.ReadOnly = True
			rasem.ReadOnly = True
			sql = "select subject from course_1 where sem=" + rasem.Text + " and class='" + raclass.Text + "'"
			dr = Db.Selectqry(sql)
			While (dr.Read())
				rasub.Items.Add(dr("subject"))
			End While
		End If
	End Sub
End Class