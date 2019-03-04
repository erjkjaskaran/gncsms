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
        Me.Hide()
    End Sub
End Class