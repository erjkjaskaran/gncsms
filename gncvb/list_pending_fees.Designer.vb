<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class list_pending_fees
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pfdept = New System.Windows.Forms.ComboBox()
        Me.pfclass = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pfbtcancel = New System.Windows.Forms.Button()
        Me.pfbtsubmit = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pfsem = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(128, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(581, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "List Of Students With Pending Fees"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(34, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Department"
        '
        'pfdept
        '
        Me.pfdept.FormattingEnabled = True
        Me.pfdept.Location = New System.Drawing.Point(110, 85)
        Me.pfdept.Margin = New System.Windows.Forms.Padding(2)
        Me.pfdept.Name = "pfdept"
        Me.pfdept.Size = New System.Drawing.Size(92, 21)
        Me.pfdept.TabIndex = 2
        '
        'pfclass
        '
        Me.pfclass.FormattingEnabled = True
        Me.pfclass.Location = New System.Drawing.Point(269, 85)
        Me.pfclass.Margin = New System.Windows.Forms.Padding(2)
        Me.pfclass.Name = "pfclass"
        Me.pfclass.Size = New System.Drawing.Size(92, 21)
        Me.pfclass.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(224, 88)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Class"
        '
        'pfbtcancel
        '
        Me.pfbtcancel.BackColor = System.Drawing.Color.Teal
        Me.pfbtcancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pfbtcancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.pfbtcancel.FlatAppearance.BorderSize = 0
        Me.pfbtcancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.pfbtcancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.pfbtcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pfbtcancel.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pfbtcancel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.pfbtcancel.Location = New System.Drawing.Point(674, 78)
        Me.pfbtcancel.Margin = New System.Windows.Forms.Padding(0)
        Me.pfbtcancel.Name = "pfbtcancel"
        Me.pfbtcancel.Size = New System.Drawing.Size(114, 30)
        Me.pfbtcancel.TabIndex = 70
        Me.pfbtcancel.Text = "Cancel"
        Me.pfbtcancel.UseVisualStyleBackColor = False
        '
        'pfbtsubmit
        '
        Me.pfbtsubmit.BackColor = System.Drawing.Color.Teal
        Me.pfbtsubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pfbtsubmit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.pfbtsubmit.FlatAppearance.BorderSize = 0
        Me.pfbtsubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.pfbtsubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.pfbtsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pfbtsubmit.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pfbtsubmit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.pfbtsubmit.Location = New System.Drawing.Point(539, 78)
        Me.pfbtsubmit.Margin = New System.Windows.Forms.Padding(0)
        Me.pfbtsubmit.Name = "pfbtsubmit"
        Me.pfbtsubmit.Size = New System.Drawing.Size(114, 30)
        Me.pfbtsubmit.TabIndex = 69
        Me.pfbtsubmit.Text = "Submit"
        Me.pfbtsubmit.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(37, 140)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(754, 301)
        Me.DataGridView1.TabIndex = 72
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(376, 88)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Semester"
        '
        'pfsem
        '
        Me.pfsem.FormattingEnabled = True
        Me.pfsem.Location = New System.Drawing.Point(431, 85)
        Me.pfsem.Margin = New System.Windows.Forms.Padding(2)
        Me.pfsem.Name = "pfsem"
        Me.pfsem.Size = New System.Drawing.Size(92, 21)
        Me.pfsem.TabIndex = 73
        '
        'list_pending_fees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(843, 489)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pfsem)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.pfbtcancel)
        Me.Controls.Add(Me.pfbtsubmit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pfclass)
        Me.Controls.Add(Me.pfdept)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "list_pending_fees"
        Me.Text = "list_pending_fees"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents pfdept As ComboBox
	Friend WithEvents pfclass As ComboBox
	Friend WithEvents Label3 As Label
    Friend WithEvents pfbtcancel As Button
    Friend WithEvents pfbtsubmit As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents pfsem As ComboBox
End Class
