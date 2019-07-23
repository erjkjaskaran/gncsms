Public Class main1
	Private Sub NewAdmissionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewAdmissionToolStripMenuItem.Click
		newadmission.Show()
		Me.Hide()

	End Sub

	Private Sub ReAdmissionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReAdmissionToolStripMenuItem.Click
        readmission.Show()
        Me.Hide()
    End Sub



    Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XToolStripMenuItem.Click
        Application.Exit()
    End Sub

	Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
		list_pending_fees.Show()
		Me.Hide()
	End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        rough.Show()
    End Sub

    Private Sub AddNewCourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewCourseToolStripMenuItem.Click
        addcourse.Show()
        Me.Hide()
    End Sub

    Private Sub SubjectWiseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubjectWiseToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub ClassWiseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassWiseToolStripMenuItem.Click
        Me.Hide()
        classwise.Show()

    End Sub

    Private Sub ChangeFeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeFeesToolStripMenuItem.Click
        Me.Hide()
        changefee.Show()

    End Sub

    Private Sub ChangeSubjectToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ChangeSubjectToolStripMenuItem.Click
        Me.Hide()
        changesub.Show()
    End Sub
End Class