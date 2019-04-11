Imports System.Data.OleDb
Imports gncvb.Db
Public Class classwise
    Dim dr As OleDbDataReader
    Dim sql As String
    Private Sub pfbtcancel_Click(sender As Object, e As EventArgs) Handles pfbtcancel.Click
        Me.Hide()
        main1.Show()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cwdept.SelectedIndexChanged

    End Sub

    Private Sub classwise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Sql = "select distinct(dept) from courses"
            dr = Db.Selectqry(Sql)
            While (dr.Read())
                cwdept.Items.Add(dr("dept"))
            End While
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
End Class