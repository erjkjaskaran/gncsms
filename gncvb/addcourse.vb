Imports gncvb.Db
Imports System.Data.OleDb
Public Class addcourse
    Dim sql As String
    Dim dr As OleDb.OleDbDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles adcbtcncl.Click
        main1.Show()
        Me.Hide()
    End Sub

    Private Sub Addcourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            sql = "select distinct(dept) from courses"
            dr = Db.Selectqry(sql)
            While (dr.Read())
                adcdept.Items.Add(dr("dept"))
            End While
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    Private Sub Nmbtlogin_Click(sender As Object, e As EventArgs) Handles adcbtlogin.Click
        If chkfee.Checked And chksub.Checked Then
            Try
                sql = "insert into courses values(""" + adcdept.Text + """,""" + adcclass.Text + """," + adcsem.Text + ")"
                Db.Updateqry(sql)
            Catch ex As Exception
                MessageBox.Show(String.Format("Error: {0}", ex.Message))
            End Try
            MessageBox.Show("Data Inserted Successfully!!")
            adcdept.Text = ""
            adcclass.Text = ""
            adcsem.Text = ""
        ElseIf chkfee.Checked Then
            MessageBox.Show("Add Atleast one Subject")
        ElseIf chksub.Checked Then
            MessageBox.Show("Set Fees")
        Else
            MessageBox.Show("Set Fees and Add Subject")
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnfee.Click
        setfee.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsub.Click
        Addsubject.Show()

    End Sub
End Class