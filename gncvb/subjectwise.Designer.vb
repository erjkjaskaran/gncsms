<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.subwisedept = New System.Windows.Forms.ComboBox()
		Me.subwisesub = New System.Windows.Forms.ComboBox()
		Me.subwisesem = New System.Windows.Forms.ComboBox()
		Me.subwiseclass = New System.Windows.Forms.ComboBox()
		Me.rabtcancel = New System.Windows.Forms.Button()
		Me.rabtlogin = New System.Windows.Forms.Button()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Label6 = New System.Windows.Forms.Label()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Teal
		Me.Label1.Location = New System.Drawing.Point(177, 38)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(592, 48)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "List of Student Subject Wise"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.Label2.Location = New System.Drawing.Point(51, 133)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(82, 17)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Department"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.Label3.Location = New System.Drawing.Point(331, 195)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(55, 17)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Subject"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.Label4.Location = New System.Drawing.Point(51, 195)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(68, 17)
		Me.Label4.TabIndex = 3
		Me.Label4.Text = "Semester"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.Label5.Location = New System.Drawing.Point(331, 133)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(42, 17)
		Me.Label5.TabIndex = 4
		Me.Label5.Text = "Class"
		'
		'subwisedept
		'
		Me.subwisedept.FormattingEnabled = True
		Me.subwisedept.Location = New System.Drawing.Point(167, 133)
		Me.subwisedept.Name = "subwisedept"
		Me.subwisedept.Size = New System.Drawing.Size(121, 24)
		Me.subwisedept.TabIndex = 1
		'
		'subwisesub
		'
		Me.subwisesub.FormattingEnabled = True
		Me.subwisesub.Location = New System.Drawing.Point(405, 192)
		Me.subwisesub.Name = "subwisesub"
		Me.subwisesub.Size = New System.Drawing.Size(121, 24)
		Me.subwisesub.TabIndex = 4
		'
		'subwisesem
		'
		Me.subwisesem.FormattingEnabled = True
		Me.subwisesem.Location = New System.Drawing.Point(167, 192)
		Me.subwisesem.Name = "subwisesem"
		Me.subwisesem.Size = New System.Drawing.Size(121, 24)
		Me.subwisesem.TabIndex = 3
		'
		'subwiseclass
		'
		Me.subwiseclass.FormattingEnabled = True
		Me.subwiseclass.Location = New System.Drawing.Point(405, 133)
		Me.subwiseclass.Name = "subwiseclass"
		Me.subwiseclass.Size = New System.Drawing.Size(121, 24)
		Me.subwiseclass.TabIndex = 2
		'
		'rabtcancel
		'
		Me.rabtcancel.BackColor = System.Drawing.Color.Teal
		Me.rabtcancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.rabtcancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
		Me.rabtcancel.FlatAppearance.BorderSize = 0
		Me.rabtcancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.rabtcancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
		Me.rabtcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.rabtcancel.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rabtcancel.ForeColor = System.Drawing.SystemColors.ButtonFace
		Me.rabtcancel.Location = New System.Drawing.Point(816, 156)
		Me.rabtcancel.Margin = New System.Windows.Forms.Padding(0)
		Me.rabtcancel.Name = "rabtcancel"
		Me.rabtcancel.Size = New System.Drawing.Size(137, 34)
		Me.rabtcancel.TabIndex = 6
		Me.rabtcancel.Text = "Cancel"
		Me.rabtcancel.UseVisualStyleBackColor = False
		'
		'rabtlogin
		'
		Me.rabtlogin.BackColor = System.Drawing.Color.Teal
		Me.rabtlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.rabtlogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
		Me.rabtlogin.FlatAppearance.BorderSize = 0
		Me.rabtlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.rabtlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
		Me.rabtlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.rabtlogin.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rabtlogin.ForeColor = System.Drawing.SystemColors.ButtonFace
		Me.rabtlogin.Location = New System.Drawing.Point(596, 157)
		Me.rabtlogin.Margin = New System.Windows.Forms.Padding(0)
		Me.rabtlogin.Name = "rabtlogin"
		Me.rabtlogin.Size = New System.Drawing.Size(137, 34)
		Me.rabtlogin.TabIndex = 5
		Me.rabtlogin.Text = "Submit"
		Me.rabtlogin.UseVisualStyleBackColor = False
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(54, 270)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.RowTemplate.Height = 24
		Me.DataGridView1.Size = New System.Drawing.Size(887, 360)
		Me.DataGridView1.TabIndex = 71
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.Label6.Location = New System.Drawing.Point(965, 9)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(17, 17)
		Me.Label6.TabIndex = 72
		Me.Label6.Text = "X"
		'
		'Form2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(994, 662)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.rabtcancel)
		Me.Controls.Add(Me.rabtlogin)
		Me.Controls.Add(Me.subwiseclass)
		Me.Controls.Add(Me.subwisesem)
		Me.Controls.Add(Me.subwisesub)
		Me.Controls.Add(Me.subwisedept)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "Form2"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents subwisedept As ComboBox
	Friend WithEvents subwisesub As ComboBox
	Friend WithEvents subwisesem As ComboBox
	Friend WithEvents subwiseclass As ComboBox
	Friend WithEvents rabtcancel As Button
	Friend WithEvents rabtlogin As Button
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Label6 As Label
End Class
