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
		Me.ClassWiseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SubjectWiseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
		Me.AddNewCourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AddNewSubjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ChangeFeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ChangeSubjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
		Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewAdmissionToolStripMenuItem, Me.ReAdmissionToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem4, Me.XToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
		Me.MenuStrip1.Size = New System.Drawing.Size(701, 28)
		Me.MenuStrip1.TabIndex = 0
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'NewAdmissionToolStripMenuItem
		'
		Me.NewAdmissionToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
		Me.NewAdmissionToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray
		Me.NewAdmissionToolStripMenuItem.Name = "NewAdmissionToolStripMenuItem"
		Me.NewAdmissionToolStripMenuItem.Size = New System.Drawing.Size(124, 24)
		Me.NewAdmissionToolStripMenuItem.Text = "New Admission"
		'
		'ReAdmissionToolStripMenuItem
		'
		Me.ReAdmissionToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
		Me.ReAdmissionToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray
		Me.ReAdmissionToolStripMenuItem.Name = "ReAdmissionToolStripMenuItem"
		Me.ReAdmissionToolStripMenuItem.Size = New System.Drawing.Size(117, 24)
		Me.ReAdmissionToolStripMenuItem.Text = "Re- Admission"
		'
		'ToolStripMenuItem1
		'
		Me.ToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control
		Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Gray
		Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
		Me.ToolStripMenuItem1.Size = New System.Drawing.Size(105, 24)
		Me.ToolStripMenuItem1.Text = "Pending fees"
		'
		'ToolStripMenuItem2
		'
		Me.ToolStripMenuItem2.BackColor = System.Drawing.SystemColors.Control
		Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClassWiseToolStripMenuItem, Me.SubjectWiseToolStripMenuItem})
		Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.Gray
		Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
		Me.ToolStripMenuItem2.Size = New System.Drawing.Size(120, 24)
		Me.ToolStripMenuItem2.Text = "Search Student"
		'
		'ClassWiseToolStripMenuItem
		'
		Me.ClassWiseToolStripMenuItem.ForeColor = System.Drawing.Color.Gray
		Me.ClassWiseToolStripMenuItem.Name = "ClassWiseToolStripMenuItem"
		Me.ClassWiseToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
		Me.ClassWiseToolStripMenuItem.Text = "Class Wise"
		'
		'SubjectWiseToolStripMenuItem
		'
		Me.SubjectWiseToolStripMenuItem.ForeColor = System.Drawing.Color.Gray
		Me.SubjectWiseToolStripMenuItem.Name = "SubjectWiseToolStripMenuItem"
		Me.SubjectWiseToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
		Me.SubjectWiseToolStripMenuItem.Text = "Subject Wise"
		'
		'ToolStripMenuItem4
		'
		Me.ToolStripMenuItem4.BackColor = System.Drawing.SystemColors.Control
		Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewCourseToolStripMenuItem, Me.AddNewSubjectToolStripMenuItem, Me.ChangeFeesToolStripMenuItem, Me.ChangeSubjectToolStripMenuItem})
		Me.ToolStripMenuItem4.ForeColor = System.Drawing.Color.DimGray
		Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
		Me.ToolStripMenuItem4.Size = New System.Drawing.Size(69, 24)
		Me.ToolStripMenuItem4.Text = " Admin"
		'
		'AddNewCourseToolStripMenuItem
		'
		Me.AddNewCourseToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray
		Me.AddNewCourseToolStripMenuItem.Name = "AddNewCourseToolStripMenuItem"
		Me.AddNewCourseToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
		Me.AddNewCourseToolStripMenuItem.Text = "Add New Course"
		'
		'AddNewSubjectToolStripMenuItem
		'
		Me.AddNewSubjectToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray
		Me.AddNewSubjectToolStripMenuItem.Name = "AddNewSubjectToolStripMenuItem"
		Me.AddNewSubjectToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
		Me.AddNewSubjectToolStripMenuItem.Text = "Add New Subject"
		'
		'ChangeFeesToolStripMenuItem
		'
		Me.ChangeFeesToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray
		Me.ChangeFeesToolStripMenuItem.Name = "ChangeFeesToolStripMenuItem"
		Me.ChangeFeesToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
		Me.ChangeFeesToolStripMenuItem.Text = "Change Fees"
		'
		'ChangeSubjectToolStripMenuItem
		'
		Me.ChangeSubjectToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray
		Me.ChangeSubjectToolStripMenuItem.Name = "ChangeSubjectToolStripMenuItem"
		Me.ChangeSubjectToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
		Me.ChangeSubjectToolStripMenuItem.Text = "Change Subject"
		'
		'XToolStripMenuItem
		'
		Me.XToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
		Me.XToolStripMenuItem.Name = "XToolStripMenuItem"
		Me.XToolStripMenuItem.Size = New System.Drawing.Size(30, 24)
		Me.XToolStripMenuItem.Text = "X"
		'
		'main1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.GhostWhite
		Me.BackgroundImage = Global.gncvb.My.Resources.Resources.IMG_20190424_113736ed
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ClientSize = New System.Drawing.Size(701, 450)
		Me.Controls.Add(Me.MenuStrip1)
		Me.ForeColor = System.Drawing.Color.DimGray
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Margin = New System.Windows.Forms.Padding(4)
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
	Friend WithEvents XToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
	Friend WithEvents AddNewCourseToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AddNewSubjectToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ClassWiseToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SubjectWiseToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ChangeFeesToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ChangeSubjectToolStripMenuItem As ToolStripMenuItem
End Class
