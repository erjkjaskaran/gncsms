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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(96, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Add New Courses"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label26.Location = New System.Drawing.Point(64, 111)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 13)
        Me.Label26.TabIndex = 56
        Me.Label26.Text = "Department"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label25.Location = New System.Drawing.Point(64, 138)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(32, 13)
        Me.Label25.TabIndex = 55
        Me.Label25.Text = "Class"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label24.Location = New System.Drawing.Point(64, 164)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(83, 13)
        Me.Label24.TabIndex = 54
        Me.Label24.Text = "No. of Semester"
        '
        'adcclass
        '
        Me.adcclass.Location = New System.Drawing.Point(164, 135)
        Me.adcclass.Name = "adcclass"
        Me.adcclass.Size = New System.Drawing.Size(245, 20)
        Me.adcclass.TabIndex = 2
        '
        'adcsem
        '
        Me.adcsem.Location = New System.Drawing.Point(164, 161)
        Me.adcsem.Name = "adcsem"
        Me.adcsem.Size = New System.Drawing.Size(245, 20)
        Me.adcsem.TabIndex = 3
        '
        'adcdept
        '
        Me.adcdept.FormattingEnabled = True
        Me.adcdept.Location = New System.Drawing.Point(164, 108)
        Me.adcdept.Name = "adcdept"
        Me.adcdept.Size = New System.Drawing.Size(245, 21)
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
        Me.adcbtlogin.Location = New System.Drawing.Point(67, 302)
        Me.adcbtlogin.Margin = New System.Windows.Forms.Padding(0)
        Me.adcbtlogin.Name = "adcbtlogin"
        Me.adcbtlogin.Size = New System.Drawing.Size(155, 39)
        Me.adcbtlogin.TabIndex = 4
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
        Me.adcbtcncl.Location = New System.Drawing.Point(254, 302)
        Me.adcbtcncl.Margin = New System.Windows.Forms.Padding(0)
        Me.adcbtcncl.Name = "adcbtcncl"
        Me.adcbtcncl.Size = New System.Drawing.Size(155, 39)
        Me.adcbtcncl.TabIndex = 5
        Me.adcbtcncl.Text = "Cancel"
        Me.adcbtcncl.UseVisualStyleBackColor = False
        '
        'chkfee
        '
        Me.chkfee.AutoSize = True
        Me.chkfee.Enabled = False
        Me.chkfee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkfee.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.chkfee.Location = New System.Drawing.Point(137, 207)
        Me.chkfee.Name = "chkfee"
        Me.chkfee.Size = New System.Drawing.Size(65, 17)
        Me.chkfee.TabIndex = 57
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
        Me.chksub.Location = New System.Drawing.Point(137, 242)
        Me.chksub.Name = "chksub"
        Me.chksub.Size = New System.Drawing.Size(93, 17)
        Me.chksub.TabIndex = 58
        Me.chksub.TabStop = False
        Me.chksub.Text = "Subject Added"
        Me.chksub.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(253, 201)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 27)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "Set Fees"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Teal
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(253, 236)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 27)
        Me.Button2.TabIndex = 60
        Me.Button2.Text = "Add Subject"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'addcourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(479, 412)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
