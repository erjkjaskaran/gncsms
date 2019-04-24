<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addcourse
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
		Me.Label26 = New System.Windows.Forms.Label()
		Me.Label25 = New System.Windows.Forms.Label()
		Me.Label24 = New System.Windows.Forms.Label()
		Me.adcclass = New System.Windows.Forms.TextBox()
		Me.adcsem = New System.Windows.Forms.TextBox()
		Me.adcdept = New System.Windows.Forms.ComboBox()
		Me.adcbtlogin = New System.Windows.Forms.Button()
		Me.adcbtcncl = New System.Windows.Forms.Button()
		Me.chkfee = New System.Windows.Forms.CheckBox()
		Me.chksub = New System.Windows.Forms.CheckBox()
		Me.btnfee = New System.Windows.Forms.Button()
		Me.btnsub = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Teal
		Me.Label1.Location = New System.Drawing.Point(128, 42)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(351, 48)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Add New Course"
		'
		'Label26
		'
		Me.Label26.AutoSize = True
		Me.Label26.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.Label26.Location = New System.Drawing.Point(85, 137)
		Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label26.Name = "Label26"
		Me.Label26.Size = New System.Drawing.Size(82, 17)
		Me.Label26.TabIndex = 56
		Me.Label26.Text = "Department"
		'
		'Label25
		'
		Me.Label25.AutoSize = True
		Me.Label25.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.Label25.Location = New System.Drawing.Point(85, 170)
		Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label25.Name = "Label25"
		Me.Label25.Size = New System.Drawing.Size(42, 17)
		Me.Label25.TabIndex = 55
		Me.Label25.Text = "Class"
		'
		'Label24
		'
		Me.Label24.AutoSize = True
		Me.Label24.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.Label24.Location = New System.Drawing.Point(85, 202)
		Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(110, 17)
		Me.Label24.TabIndex = 54
		Me.Label24.Text = "No. of Semester"
		'
		'adcclass
		'
		Me.adcclass.Location = New System.Drawing.Point(219, 166)
		Me.adcclass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.adcclass.Name = "adcclass"
		Me.adcclass.Size = New System.Drawing.Size(325, 22)
		Me.adcclass.TabIndex = 2
		'
		'adcsem
		'
		Me.adcsem.Location = New System.Drawing.Point(219, 198)
		Me.adcsem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.adcsem.Name = "adcsem"
		Me.adcsem.Size = New System.Drawing.Size(325, 22)
		Me.adcsem.TabIndex = 3
		'
		'adcdept
		'
		Me.adcdept.FormattingEnabled = True
		Me.adcdept.Location = New System.Drawing.Point(219, 133)
		Me.adcdept.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.adcdept.Name = "adcdept"
		Me.adcdept.Size = New System.Drawing.Size(325, 24)
		Me.adcdept.TabIndex = 1
		'
		'adcbtlogin
		'
		Me.adcbtlogin.BackColor = System.Drawing.Color.Teal
		Me.adcbtlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.adcbtlogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
		Me.adcbtlogin.FlatAppearance.BorderSize = 0
		Me.adcbtlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.adcbtlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
		Me.adcbtlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.adcbtlogin.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.adcbtlogin.ForeColor = System.Drawing.SystemColors.ButtonFace
		Me.adcbtlogin.Location = New System.Drawing.Point(89, 372)
		Me.adcbtlogin.Margin = New System.Windows.Forms.Padding(0)
		Me.adcbtlogin.Name = "adcbtlogin"
		Me.adcbtlogin.Size = New System.Drawing.Size(207, 48)
		Me.adcbtlogin.TabIndex = 8
		Me.adcbtlogin.Text = "Submit"
		Me.adcbtlogin.UseVisualStyleBackColor = False
		'
		'adcbtcncl
		'
		Me.adcbtcncl.BackColor = System.Drawing.Color.Teal
		Me.adcbtcncl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.adcbtcncl.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
		Me.adcbtcncl.FlatAppearance.BorderSize = 0
		Me.adcbtcncl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.adcbtcncl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
		Me.adcbtcncl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.adcbtcncl.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.adcbtcncl.ForeColor = System.Drawing.SystemColors.ButtonFace
		Me.adcbtcncl.Location = New System.Drawing.Point(339, 372)
		Me.adcbtcncl.Margin = New System.Windows.Forms.Padding(0)
		Me.adcbtcncl.Name = "adcbtcncl"
		Me.adcbtcncl.Size = New System.Drawing.Size(207, 48)
		Me.adcbtcncl.TabIndex = 9
		Me.adcbtcncl.Text = "Cancel"
		Me.adcbtcncl.UseVisualStyleBackColor = False
		'
		'chkfee
		'
		Me.chkfee.AutoSize = True
		Me.chkfee.Enabled = False
		Me.chkfee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.chkfee.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.chkfee.Location = New System.Drawing.Point(183, 255)
		Me.chkfee.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.chkfee.Name = "chkfee"
		Me.chkfee.Size = New System.Drawing.Size(82, 21)
		Me.chkfee.TabIndex = 4
		Me.chkfee.TabStop = False
		Me.chkfee.Text = "Fees Set"
		Me.chkfee.UseVisualStyleBackColor = True
		'
		'chksub
		'
		Me.chksub.AutoCheck = False
		Me.chksub.AutoSize = True
		Me.chksub.Enabled = False
		Me.chksub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.chksub.Location = New System.Drawing.Point(183, 298)
		Me.chksub.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.chksub.Name = "chksub"
		Me.chksub.Size = New System.Drawing.Size(118, 21)
		Me.chksub.TabIndex = 6
		Me.chksub.TabStop = False
		Me.chksub.Text = "Subject Added"
		Me.chksub.UseVisualStyleBackColor = True
		'
		'btnfee
		'
		Me.btnfee.BackColor = System.Drawing.Color.Teal
		Me.btnfee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnfee.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
		Me.btnfee.FlatAppearance.BorderSize = 0
		Me.btnfee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.btnfee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
		Me.btnfee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnfee.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnfee.ForeColor = System.Drawing.SystemColors.ButtonFace
		Me.btnfee.Location = New System.Drawing.Point(337, 247)
		Me.btnfee.Margin = New System.Windows.Forms.Padding(0)
		Me.btnfee.Name = "btnfee"
		Me.btnfee.Size = New System.Drawing.Size(151, 33)
		Me.btnfee.TabIndex = 5
		Me.btnfee.Text = "Set Fees"
		Me.btnfee.UseVisualStyleBackColor = False
		'
		'btnsub
		'
		Me.btnsub.BackColor = System.Drawing.Color.Teal
		Me.btnsub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnsub.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
		Me.btnsub.FlatAppearance.BorderSize = 0
		Me.btnsub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.btnsub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
		Me.btnsub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnsub.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnsub.ForeColor = System.Drawing.SystemColors.ButtonFace
		Me.btnsub.Location = New System.Drawing.Point(337, 290)
		Me.btnsub.Margin = New System.Windows.Forms.Padding(0)
		Me.btnsub.Name = "btnsub"
		Me.btnsub.Size = New System.Drawing.Size(151, 33)
		Me.btnsub.TabIndex = 7
		Me.btnsub.Text = "Add Subject"
		Me.btnsub.UseVisualStyleBackColor = False
		'
		'addcourse
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.GhostWhite
		Me.ClientSize = New System.Drawing.Size(639, 507)
		Me.Controls.Add(Me.btnsub)
		Me.Controls.Add(Me.btnfee)
		Me.Controls.Add(Me.chksub)
		Me.Controls.Add(Me.chkfee)
		Me.Controls.Add(Me.adcbtcncl)
		Me.Controls.Add(Me.adcbtlogin)
		Me.Controls.Add(Me.adcdept)
		Me.Controls.Add(Me.adcsem)
		Me.Controls.Add(Me.adcclass)
		Me.Controls.Add(Me.Label26)
		Me.Controls.Add(Me.Label25)
		Me.Controls.Add(Me.Label24)
		Me.Controls.Add(Me.Label1)
		Me.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Name = "addcourse"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Add New Course"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents adcclass As TextBox
    Friend WithEvents adcsem As TextBox
    Friend WithEvents adcdept As ComboBox
    Friend WithEvents adcbtlogin As Button
    Friend WithEvents adcbtcncl As Button
    Friend WithEvents chkfee As CheckBox
    Friend WithEvents chksub As CheckBox
    Friend WithEvents btnfee As Button
    Friend WithEvents btnsub As Button
End Class
