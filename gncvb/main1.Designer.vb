<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.NewAdmissionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ReAdmissionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewAdmissionToolStripMenuItem, Me.ReAdmissionToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
		Me.MenuStrip1.Size = New System.Drawing.Size(1067, 28)
		Me.MenuStrip1.TabIndex = 0
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'NewAdmissionToolStripMenuItem
		'
		Me.NewAdmissionToolStripMenuItem.Name = "NewAdmissionToolStripMenuItem"
		Me.NewAdmissionToolStripMenuItem.Size = New System.Drawing.Size(124, 24)
		Me.NewAdmissionToolStripMenuItem.Text = "New Admission"
		'
		'ReAdmissionToolStripMenuItem
		'
		Me.ReAdmissionToolStripMenuItem.Name = "ReAdmissionToolStripMenuItem"
		Me.ReAdmissionToolStripMenuItem.Size = New System.Drawing.Size(117, 24)
		Me.ReAdmissionToolStripMenuItem.Text = "Re- Admission"
		'
		'main1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1067, 554)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Name = "main1"
		Me.Text = "Main Menu"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NewAdmissionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReAdmissionToolStripMenuItem As ToolStripMenuItem
End Class
