Imports gncvb.Db
Imports System.Data.OleDb

Public Class setfee
    Dim sql As String
    Dim dr As OleDb.OleDbDataReader
    Dim b As Boolean
    Dim c As Boolean

    Private Sub Setfee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sfdept.Text = addcourse.adcdept.Text
        sfclass.Text = addcourse.adcclass.Text
        Dim i As Integer = addcourse.adcsem.Text
        For x = 1 To i
            sfsem.Items.Add(x)
        Next
    End Sub

    Private Sub sfbtnaddmore_Click(sender As Object, e As EventArgs) Handles sfbtnsetmore.Click
        Try
            sql = "insert into total_fees values(""" + sfdept.Text + """,""" + sfclass.Text + """," + sfsem.Text + "," + sffee.Text + ")"
            Db.Updateqry(sql)
            b = True
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
            sffee.Text = ""
            b = False
        End Try
        If b = True Then
            MessageBox.Show("Data Updated")
            sffee.Text = ""
        End If
    End Sub

    Private Sub sfbtcncel_Click(sender As Object, e As EventArgs) Handles sfbtcncel.Click
        Me.Close()
        If (b) Then
            MessageBox.Show("Fee Set Successfully")
            addcourse.chkfee.Checked = True
        End If
    End Sub

    Private Sub sfbtsubmit_Click(sender As Object, e As EventArgs) Handles sfbtsubmit.Click
        If b = False Then
            MessageBox.Show("Add atleast 1 Subject")
        ElseIf (b) Then
            If (sfclass.Text <> "" And sfsem.Text <> "" And sffee.Text <> "") Then
                Try
                    sql = "insert into total_fees values(""" + sfdept.Text + """,""" + sfclass.Text + """," + sfsem.Text + "," + sffee.Text + ")"
                    Db.Updateqry(sql)
                    c = True
                Catch ex As Exception
                    MessageBox.Show(String.Format("Error: {0}", ex.Message))
                    sffee.Text = ""
                    c = False
                End Try

                If (c) Then
                    MessageBox.Show("Subject Set Successfully")
                    Me.Close()
                    addcourse.chkfee.Checked = True
                End If
            ElseIf (b) Then
                MessageBox.Show("Subject Set Successfully")
                Me.Close()
                addcourse.chkfee.Checked = True
            End If
        End If
    End Sub
End Class