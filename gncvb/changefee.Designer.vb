<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changefee
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
		Me.sfbtcncel = New System.Windows.Forms.Button()
		Me.sfbtsubmit = New System.Windows.Forms.Button()
		Me.cffee = New System.Windows.Forms.TextBox()
		Me.cfsem = New System.Windows.Forms.ComboBox()
		Me.Label26 = New System.Windows.Forms.Label()
		Me.Label25 = New System.Windows.Forms.Label()
		Me.Label24 = New System.Windows.Forms.Label()
		Me.Label23 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.cfdept = New System.Windows.Forms.ComboBox()
		Me.cfclass = New System.Windows.Forms.ComboBox()
		Me.SuspendLayout()
		'
		'sfbtcncel
		'
		Me.sfbtcncel.BackColor = System.Drawing.Color.Teal
		Me.sfbtcncel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.sfbtcncel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
		Me.sfbtcncel.FlatAppearance.BorderSize = 0
		Me.sfbtcncel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.sfbtcncel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
		Me.sfbtcncel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.sfbtcncel.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.sfbtcncel.ForeColor = System.Drawing.SystemColors.ButtonFace
		Me.sfbtcncel.Location = New System.Drawing.Point(372, 320)
		Me.sfbtcncel.Margin = New System.Windows.Forms.Padding(0)
		Me.sfbtcncel.Name = "sfbtcncel"
		Me.sfbtcncel.Size = New System.Drawing.Size(207, 48)
		Me.sfbtcncel.TabIndex = 6
		Me.sfbtcncel.Text = "Cancel"
		Me.sfbtcncel.UseVisualStyleBackColor = False
		'
		'sfbtsubmit
		'
		Me.sfbtsubmit.BackColor = System.Drawing.Color.Teal
		Me.sfbtsubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.sfbtsubmit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
		Me.sfbtsubmit.FlatAppearance.BorderSize = 0
		Me.sfbtsubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.sfbtsubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
		Me.sfbtsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.sfbtsubmit.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.sfbtsubmit.ForeColor = System.Drawing.SystemColors.ButtonFace
		Me.sfbtsubmit.Location = New System.Drawing.Point(79, 320)
		Me.sfbtsubmit.Margin = New System.Windows.Forms.Padding(0)
		Me.sfbtsubmit.Name = "sfbtsubmit"
		Me.sfbtsubmit.Size = New System.Drawing.Size(207, 48)
		Me.sfbtsubmit.TabIndex = 5
		Me.sfbtsubmit.Text = "Submit"
		Me.sfbtsubmit.UseVisualStyleBackColor = False
		'
		'cffee
		'
		Me.cffee.Location = New System.Drawing.Point(275, 235)
		Me.cffee.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.cffee.Name = "cffee"
		Me.cffee.Size = New System.Drawing.Size(315, 22)
		Me.cffee.TabIndex = 4
		'
		'cfsem
		'
		Me.cfsem.FormattingEnabled = True
		Me.cfsem.Location = New System.Drawing.Point(275, 201)
		Me.cfsem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.cfsem.Name = "cfsem"
		Me.cfsem.Size = New System.Drawing.Size(315, 24)
		Me.cfsem.TabIndex = 3
		Me.cfsem.Text = "Select"
		'
		'Label26
		'
		Me.Label26.AutoSize = True
		Me.Label26.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.Label26.Location = New System.Drawing.Point(75, 135)
		Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label26.Name = "Label26"
		Me.Label26.Size = New System.Drawing.Size(82, 17)
		Me.Label26.TabIndex = 101
		Me.Label26.Text = "Department"
		'
		'Label25
		'
		Me.Label25.AutoSize = True
		Me.Label25.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.Label25.Location = New System.Drawing.Point(75, 170)
		Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label25.Name = "Label25"
		Me.Label25.Size = New System.Drawing.Size(42, 17)
		Me.Label25.TabIndex = 100
		Me.Label25.Text = "Class"
		'
		'Label24
		'
		Me.Label24.AutoSize = True
		Me.Label24.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.Label24.Location = New System.Drawing.Point(75, 204)
		Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(68, 17)
		Me.Label24.TabIndex = 99
		Me.Label24.Text = "Semester"
		'
		'Label23
		'
		Me.Label23.AutoSize = True
		Me.Label23.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.Label23.Location = New System.Drawing.Point(75, 239)
		Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label23.Name = "Label23"
		Me.Label23.Size = New System.Drawing.Size(75, 17)
		Me.Label23.TabIndex = 98
		Me.Label23.Text = "Total Fees"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Teal
		Me.Label1.Location = New System.Drawing.Point(192, 38)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(276, 48)
		Me.Label1.TabIndex = 97
		Me.Label1.Text = "Change Fees"
		'
		'cfdept
		'
		Me.cfdept.FormattingEnabled = True
		Me.cfdept.Location = New System.Drawing.Point(275, 132)
		Me.cfdept.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.cfdept.Name = "cfdept"
		Me.cfdept.Size = New System.Drawing.Size(315, 24)
		Me.cfdept.TabIndex = 1
		Me.cfdept.Text = "Select"
		'
		'cfclass
		'
		Me.cfclass.FormattingEnabled = True
		Me.cfclass.Location = New System.Drawing.Point(275, 166)
		Me.cfclass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.cfclass.Name = "cfclass"
		Me.cfclass.Size = New System.Drawing.Size(315, 24)
		Me.cfclass.TabIndex = 2
		Me.cfclass.Text = "Select"
		'
		'changefee
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(677, 441)
		Me.Controls.Add(Me.cfclass)
		Me.Controls.Add(Me.cfdept)
		Me.Controls.Add(Me.sfbtcncel)
		Me.Controls.Add(Me.sfbtsubmit)
		Me.Controls.Add(Me.cffee)
		Me.Controls.Add(Me.cfsem)
		Me.Controls.Add(Me.Label26)
		Me.Controls.Add(Me.Label25)
		Me.Controls.Add(Me.Label24)
		Me.Controls.Add(Me.Label23)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Name = "changefee"
		Me.Text = "changefee"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents sfbtcncel As Button
    Friend WithEvents sfbtsubmit As Button
    Friend WithEvents cffee As TextBox
    Friend WithEvents cfsem As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cfdept As ComboBox
    Friend WithEvents cfclass As ComboBox
End Class
