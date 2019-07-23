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

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        Me.Hide()
        main1.Show()
    End Sub

    Private Sub pfbtcancel_Click(sender As Object, e As EventArgs) Handles pfbtcancel.Click
        Me.Close()
        main1.Show()
	End Sub

	Private Sub pfdept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pfdept.SelectedIndexChanged
        pfclass.Items.Clear()
        pfsem.Items.Clear()
        sql = "select distinct(class) from courses where dept='" + pfdept.Text + "'"
        dr = Db.Selectqry(sql)
        While (dr.Read())
            pfclass.Items.Add(dr("class"))
        End While
    End Sub

    Private Sub pfbtsubmit_Click(sender As Object, e As EventArgs) Handles pfbtsubmit.Click
        sql = "select s2.croll, s1.class, s1.sem from student_fees as s2, s_info as s1 where s1.croll=s2.croll and s2.remaining_fee>0"
        dr = Db.Selectqry(sql)
        dr.Read()
        Dim dt As New DataTable
        dt.Load(dr)
        DataGridView1.DataSource = dt
        DataGridView1.Columns(0).Name = "Roll No."
    End Sub

    Private Sub pfclass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pfclass.SelectedIndexChanged
        pfsem.Items.Clear()

        sql = "select sem from courses where class='" + pfclass.Text + "'"
        dr = Db.Selectqry(sql)
        dr.Read()
        Dim a As Integer
        a = CInt(dr("sem"))
        For i = 1 To a
            pfsem.Items.Add(i)
        Next
    End Sub
End Class