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
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewAdmissionToolStripMenuItem, Me.ReAdmissionToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.XToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(676, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewAdmissionToolStripMenuItem
        '
        Me.NewAdmissionToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray
        Me.NewAdmissionToolStripMenuItem.Name = "NewAdmissionToolStripMenuItem"
        Me.NewAdmissionToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.NewAdmissionToolStripMenuItem.Text = "New Admission"
        '
        'ReAdmissionToolStripMenuItem
        '
        Me.ReAdmissionToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray
        Me.ReAdmissionToolStripMenuItem.Name = "ReAdmissionToolStripMenuItem"
        Me.ReAdmissionToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.ReAdmissionToolStripMenuItem.Text = "Re- Admission"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Gray
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(87, 20)
        Me.ToolStripMenuItem1.Text = "Pending fees"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(151, 20)
        Me.ToolStripMenuItem2.Text = "                                            "
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(138, 20)
        Me.ToolStripMenuItem3.Text = "rough                             "
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(109, 20)
        Me.ToolStripMenuItem4.Text = "                              "
        '
        'XToolStripMenuItem
        '
        Me.XToolStripMenuItem.Name = "XToolStripMenuItem"
        Me.XToolStripMenuItem.Size = New System.Drawing.Size(26, 20)
        Me.XToolStripMenuItem.Text = "X"
        '
        'main1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(676, 446)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "main1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents NewAdmissionToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ReAdmissionToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
	Friend WithEvents XToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
End Class
