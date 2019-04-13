Imports gncvb.Db
Imports System.Data.OleDb

Public Class Addsubject
    Dim sql As String
    Dim dr As OleDb.OleDbDataReader
    Dim b As Boolean = False
    Dim c As Boolean = False

    Private Sub Add_new_courses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        asdept.Text = addcourse.adcdept.Text
        asclass.Text = addcourse.adcclass.Text
        Dim i As Integer
        i = CInt(addcourse.adcsem.Text)
        For x = 1 To i
            assem.Items.Add(x)
        Next

    End Sub

    Private Sub Asbtlogin_Click(sender As Object, e As EventArgs) Handles asbtsubmit.Click
        If b = False Then
            MessageBox.Show("Add atleast 1 Subject")
        ElseIf (b) Then
            If (asclass.Text <> "" And assem.Text <> "" And assub.Text <> "") Then
                Try
                    sql = "insert into course_1 values(""" + asclass.Text + """," + assem.Text + ",""" + assub.Text + """)"
                    Db.Updateqry(sql)
                    c = True
                Catch ex As Exception
                    MessageBox.Show(String.Format("Error: {0}", ex.Message))
                    assub.Text = ""
                    c = False
                End Try

                If (c) Then
                    MessageBox.Show("Subject Set Successfully")
                    Me.Close()
                    addcourse.chksub.Checked = True
                End If
            ElseIf (b) Then
                MessageBox.Show("Subject Set Successfully")
                Me.Close()
                addcourse.chksub.Checked = True
            End If
        End If

    End Sub

    Private Sub asbtcncel_Click(sender As Object, e As EventArgs) Handles asbtcncel.Click
        Me.Close()
        If (b) Then
            MessageBox.Show("Subject Set Successfully")
            addcourse.chksub.Checked = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles asbtnaddmore.Click
        Try
            sql = "insert into course_1 values(""" + asclass.Text + """," + assem.Text + ",""" + assub.Text + """)"
            Db.Updateqry(sql)
            b = True
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
            assub.Text = ""
            b = False
        End Try
        If b = True Then
            MessageBox.Show("Data Updated")
            assub.Text = ""
        End If


    End Sub
End Class