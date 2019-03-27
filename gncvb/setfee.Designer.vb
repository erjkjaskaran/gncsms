<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setfee
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
        Me.sfclass = New System.Windows.Forms.TextBox()
        Me.sfdept = New System.Windows.Forms.TextBox()
        Me.sffee = New System.Windows.Forms.TextBox()
        Me.sfsem = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.sfbtnsetmore = New System.Windows.Forms.Button()
        Me.sfbtcncel = New System.Windows.Forms.Button()
        Me.sfbtsubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(204, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Set Fees"
        '
        'sfclass
        '
        Me.sfclass.Enabled = False
        Me.sfclass.Location = New System.Drawing.Point(231, 137)
        Me.sfclass.Name = "sfclass"
        Me.sfclass.Size = New System.Drawing.Size(237, 20)
        Me.sfclass.TabIndex = 93
        '
        'sfdept
        '
        Me.sfdept.Enabled = False
        Me.sfdept.Location = New System.Drawing.Point(231, 109)
        Me.sfdept.Name = "sfdept"
        Me.sfdept.Size = New System.Drawing.Size(237, 20)
        Me.sfdept.TabIndex = 92
        '
        'sffee
        '
        Me.sffee.Location = New System.Drawing.Point(231, 193)
        Me.sffee.Name = "sffee"
        Me.sffee.Size = New System.Drawing.Size(237, 20)
        Me.sffee.TabIndex = 91
        '
        'sfsem
        '
        Me.sfsem.FormattingEnabled = True
        Me.sfsem.Location = New System.Drawing.Point(231, 165)
        Me.sfsem.Name = "sfsem"
        Me.sfsem.Size = New System.Drawing.Size(237, 21)
        Me.sfsem.TabIndex = 90
        Me.sfsem.Text = "Select"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label26.Location = New System.Drawing.Point(81, 112)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 13)
        Me.Label26.TabIndex = 89
        Me.Label26.Text = "Department"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label25.Location = New System.Drawing.Point(81, 140)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(32, 13)
        Me.Label25.TabIndex = 88
        Me.Label25.Text = "Class"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label24.Location = New System.Drawing.Point(81, 168)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(51, 13)
        Me.Label24.TabIndex = 87
        Me.Label24.Text = "Semester"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label23.Location = New System.Drawing.Point(81, 196)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(57, 13)
        Me.Label23.TabIndex = 86
        Me.Label23.Text = "Total Fees"
        '
        'sfbtnsetmore
        '
        Me.sfbtnsetmore.BackColor = System.Drawing.Color.Teal
        Me.sfbtnsetmore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sfbtnsetmore.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.sfbtnsetmore.FlatAppearance.BorderSize = 0
        Me.sfbtnsetmore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.sfbtnsetmore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.sfbtnsetmore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sfbtnsetmore.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfbtnsetmore.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.sfbtnsetmore.Location = New System.Drawing.Point(186, 246)
        Me.sfbtnsetmore.Margin = New System.Windows.Forms.Padding(0)
        Me.sfbtnsetmore.Name = "sfbtnsetmore"
        Me.sfbtnsetmore.Size = New System.Drawing.Size(205, 39)
        Me.sfbtnsetmore.TabIndex = 96
        Me.sfbtnsetmore.Text = "Set More"
        Me.sfbtnsetmore.UseVisualStyleBackColor = False
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
        Me.sfbtcncel.Location = New System.Drawing.Point(301, 311)
        Me.sfbtcncel.Margin = New System.Windows.Forms.Padding(0)
        Me.sfbtcncel.Name = "sfbtcncel"
        Me.sfbtcncel.Size = New System.Drawing.Size(155, 39)
        Me.sfbtcncel.TabIndex = 95
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
        Me.sfbtsubmit.Location = New System.Drawing.Point(81, 311)
        Me.sfbtsubmit.Margin = New System.Windows.Forms.Padding(0)
        Me.sfbtsubmit.Name = "sfbtsubmit"
        Me.sfbtsubmit.Size = New System.Drawing.Size(155, 39)
        Me.sfbtsubmit.TabIndex = 94
        Me.sfbtsubmit.Text = "Submit"
        Me.sfbtsubmit.UseVisualStyleBackColor = False
        '
        'setfee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(549, 402)
        Me.Controls.Add(Me.sfbtnsetmore)
        Me.Controls.Add(Me.sfbtcncel)
        Me.Controls.Add(Me.sfbtsubmit)
        Me.Controls.Add(Me.sfclass)
        Me.Controls.Add(Me.sfdept)
        Me.Controls.Add(Me.sffee)
        Me.Controls.Add(Me.sfsem)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "setfee"
        Me.Text = "setfee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents sfclass As TextBox
    Friend WithEvents sfdept As TextBox
    Friend WithEvents sffee As TextBox
    Friend WithEvents sfsem As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents sfbtnsetmore As Button
    Friend WithEvents sfbtcncel As Button
    Friend WithEvents sfbtsubmit As Button
End Class
