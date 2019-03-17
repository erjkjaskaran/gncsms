<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Addsubject
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.assem = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.assub = New System.Windows.Forms.TextBox()
        Me.asbtcncel = New System.Windows.Forms.Button()
        Me.asbtsubmit = New System.Windows.Forms.Button()
        Me.asdept = New System.Windows.Forms.TextBox()
        Me.asclass = New System.Windows.Forms.TextBox()
        Me.asbtnaddmore = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(158, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Subject"
        '
        'assem
        '
        Me.assem.FormattingEnabled = True
        Me.assem.Location = New System.Drawing.Point(207, 171)
        Me.assem.Name = "assem"
        Me.assem.Size = New System.Drawing.Size(237, 21)
        Me.assem.TabIndex = 80
        Me.assem.Text = "Select"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label26.Location = New System.Drawing.Point(57, 118)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 13)
        Me.Label26.TabIndex = 77
        Me.Label26.Text = "Department"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label25.Location = New System.Drawing.Point(57, 146)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(32, 13)
        Me.Label25.TabIndex = 76
        Me.Label25.Text = "Class"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label24.Location = New System.Drawing.Point(57, 174)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(51, 13)
        Me.Label24.TabIndex = 75
        Me.Label24.Text = "Semester"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label23.Location = New System.Drawing.Point(57, 202)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 13)
        Me.Label23.TabIndex = 74
        Me.Label23.Text = "Subject"
        '
        'assub
        '
        Me.assub.Location = New System.Drawing.Point(207, 199)
        Me.assub.Name = "assub"
        Me.assub.Size = New System.Drawing.Size(237, 20)
        Me.assub.TabIndex = 81
        '
        'asbtcncel
        '
        Me.asbtcncel.BackColor = System.Drawing.Color.Teal
        Me.asbtcncel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.asbtcncel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.asbtcncel.FlatAppearance.BorderSize = 0
        Me.asbtcncel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.asbtcncel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.asbtcncel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.asbtcncel.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asbtcncel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.asbtcncel.Location = New System.Drawing.Point(280, 313)
        Me.asbtcncel.Margin = New System.Windows.Forms.Padding(0)
        Me.asbtcncel.Name = "asbtcncel"
        Me.asbtcncel.Size = New System.Drawing.Size(155, 39)
        Me.asbtcncel.TabIndex = 83
        Me.asbtcncel.Text = "Cancel"
        Me.asbtcncel.UseVisualStyleBackColor = False
        '
        'asbtsubmit
        '
        Me.asbtsubmit.BackColor = System.Drawing.Color.Teal
        Me.asbtsubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.asbtsubmit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.asbtsubmit.FlatAppearance.BorderSize = 0
        Me.asbtsubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.asbtsubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.asbtsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.asbtsubmit.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asbtsubmit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.asbtsubmit.Location = New System.Drawing.Point(60, 313)
        Me.asbtsubmit.Margin = New System.Windows.Forms.Padding(0)
        Me.asbtsubmit.Name = "asbtsubmit"
        Me.asbtsubmit.Size = New System.Drawing.Size(155, 39)
        Me.asbtsubmit.TabIndex = 82
        Me.asbtsubmit.Text = "Submit"
        Me.asbtsubmit.UseVisualStyleBackColor = False
        '
        'asdept
        '
        Me.asdept.Enabled = False
        Me.asdept.Location = New System.Drawing.Point(207, 115)
        Me.asdept.Name = "asdept"
        Me.asdept.Size = New System.Drawing.Size(237, 20)
        Me.asdept.TabIndex = 84
        '
        'asclass
        '
        Me.asclass.Enabled = False
        Me.asclass.Location = New System.Drawing.Point(207, 143)
        Me.asclass.Name = "asclass"
        Me.asclass.Size = New System.Drawing.Size(237, 20)
        Me.asclass.TabIndex = 85
        '
        'asbtnaddmore
        '
        Me.asbtnaddmore.BackColor = System.Drawing.Color.Teal
        Me.asbtnaddmore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.asbtnaddmore.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.asbtnaddmore.FlatAppearance.BorderSize = 0
        Me.asbtnaddmore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.asbtnaddmore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.asbtnaddmore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.asbtnaddmore.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asbtnaddmore.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.asbtnaddmore.Location = New System.Drawing.Point(165, 248)
        Me.asbtnaddmore.Margin = New System.Windows.Forms.Padding(0)
        Me.asbtnaddmore.Name = "asbtnaddmore"
        Me.asbtnaddmore.Size = New System.Drawing.Size(205, 39)
        Me.asbtnaddmore.TabIndex = 86
        Me.asbtnaddmore.Text = "Add More Subject"
        Me.asbtnaddmore.UseVisualStyleBackColor = False
        '
        'Addsubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(519, 412)
        Me.Controls.Add(Me.asbtnaddmore)
        Me.Controls.Add(Me.asclass)
        Me.Controls.Add(Me.asdept)
        Me.Controls.Add(Me.asbtcncel)
        Me.Controls.Add(Me.asbtsubmit)
        Me.Controls.Add(Me.assub)
        Me.Controls.Add(Me.assem)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Addsubject"
        Me.Text = "Add Subject"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents assem As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents assub As TextBox
    Friend WithEvents asbtcncel As Button
    Friend WithEvents asbtsubmit As Button
    Friend WithEvents asdept As TextBox
    Friend WithEvents asclass As TextBox
    Friend WithEvents asbtnaddmore As Button
End Class
