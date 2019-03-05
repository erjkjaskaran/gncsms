Imports gncvb.db
Imports System.Data.OleDb

Public Class Login
    Dim dr As OleDbDataReader
    Dim sql As String


    Private Sub btlogin_Click(sender As Object, e As EventArgs) Handles btlogin.Click

        sql = "select * from login where un='" & un.Text & "' and up='" & up.Text & "'"
        dr = Db.Selectqry(sql)
        dr.Read()
        If (dr.HasRows) Then
            main1.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid User")
        End If

    End Sub





    Private Sub un_Leave(sender As Object, e As EventArgs) Handles un.Leave
        If (un.Text = "") Then
            un.Text = "USERNAME"
        End If
    End Sub

    Private Sub up_Leave(sender As Object, e As EventArgs) Handles up.Leave
        If (up.Text = "") Then
            up.UseSystemPasswordChar = False
            up.Text = "Password"
        End If
    End Sub

    Private Sub up_Enter(sender As Object, e As EventArgs) Handles up.Enter
        up.Text = ""
        up.UseSystemPasswordChar = True
    End Sub

    Private Sub un_Enter(sender As Object, e As EventArgs) Handles un.Enter

        un.Text = ""

    End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Me.Hide()
	End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
    End Sub

	Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class
