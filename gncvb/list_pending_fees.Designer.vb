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
		Me.Label4 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Teal
		Me.Label1.Location = New System.Drawing.Point(65, 21)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(728, 48)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "List Of Students With Pending Fees"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.ForeColor = System.Drawing.Color.Navy
		Me.Label2.Location = New System.Drawing.Point(45, 100)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(82, 17)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Department"
		'
		'pfdept
		'
		Me.pfdept.FormattingEnabled = True
		Me.pfdept.Location = New System.Drawing.Point(147, 96)
		Me.pfdept.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.pfdept.Name = "pfdept"
		Me.pfdept.Size = New System.Drawing.Size(121, 24)
		Me.pfdept.TabIndex = 2
		'
		'pfclass
		'
		Me.pfclass.FormattingEnabled = True
		Me.pfclass.Location = New System.Drawing.Point(369, 96)
		Me.pfclass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.pfclass.Name = "pfclass"
		Me.pfclass.Size = New System.Drawing.Size(121, 24)
		Me.pfclass.TabIndex = 4
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.ForeColor = System.Drawing.Color.Navy
		Me.Label3.Location = New System.Drawing.Point(309, 100)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(42, 17)
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
		Me.pfbtcancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
		Me.pfbtcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.pfbtcancel.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pfbtcancel.ForeColor = System.Drawing.SystemColors.ButtonFace
		Me.pfbtcancel.Location = New System.Drawing.Point(712, 87)
		Me.pfbtcancel.Margin = New System.Windows.Forms.Padding(0)
		Me.pfbtcancel.Name = "pfbtcancel"
		Me.pfbtcancel.Size = New System.Drawing.Size(152, 37)
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
		Me.pfbtsubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
		Me.pfbtsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.pfbtsubmit.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pfbtsubmit.ForeColor = System.Drawing.SystemColors.ButtonFace
		Me.pfbtsubmit.Location = New System.Drawing.Point(532, 87)
		Me.pfbtsubmit.Margin = New System.Windows.Forms.Padding(0)
		Me.pfbtsubmit.Name = "pfbtsubmit"
		Me.pfbtsubmit.Size = New System.Drawing.Size(152, 37)
		Me.pfbtsubmit.TabIndex = 69
		Me.pfbtsubmit.Text = "Submit"
		Me.pfbtsubmit.UseVisualStyleBackColor = False
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.GrayText
		Me.Label4.Location = New System.Drawing.Point(865, 9)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(17, 17)
		Me.Label4.TabIndex = 71
		Me.Label4.Text = "X"
		'
		'list_pending_fees
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.GhostWhite
		Me.ClientSize = New System.Drawing.Size(916, 512)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.pfbtcancel)
		Me.Controls.Add(Me.pfbtsubmit)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.pfclass)
		Me.Controls.Add(Me.pfdept)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.Name = "list_pending_fees"
		Me.Text = "list_pending_fees"
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
	Friend WithEvents Label4 As Label
End Class
