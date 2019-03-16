<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rough
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
        Me.nmsem = New System.Windows.Forms.ComboBox()
        Me.nmclass = New System.Windows.Forms.ComboBox()
        Me.nmdept = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nmbtlogin = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'nmsem
        '
        Me.nmsem.FormattingEnabled = True
        Me.nmsem.Location = New System.Drawing.Point(430, 103)
        Me.nmsem.Name = "nmsem"
        Me.nmsem.Size = New System.Drawing.Size(237, 21)
        Me.nmsem.TabIndex = 53
        Me.nmsem.Text = "Select"
        '
        'nmclass
        '
        Me.nmclass.FormattingEnabled = True
        Me.nmclass.Location = New System.Drawing.Point(430, 72)
        Me.nmclass.Name = "nmclass"
        Me.nmclass.Size = New System.Drawing.Size(237, 21)
        Me.nmclass.TabIndex = 52
        Me.nmclass.Text = "Select"
        '
        'nmdept
        '
        Me.nmdept.FormattingEnabled = True
        Me.nmdept.Location = New System.Drawing.Point(430, 44)
        Me.nmdept.Name = "nmdept"
        Me.nmdept.Size = New System.Drawing.Size(237, 21)
        Me.nmdept.TabIndex = 51
        Me.nmdept.Text = "Select"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label26.Location = New System.Drawing.Point(144, 47)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 13)
        Me.Label26.TabIndex = 50
        Me.Label26.Text = "Department"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label25.Location = New System.Drawing.Point(144, 78)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(32, 13)
        Me.Label25.TabIndex = 49
        Me.Label25.Text = "Class"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label24.Location = New System.Drawing.Point(144, 108)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(51, 13)
        Me.Label24.TabIndex = 48
        Me.Label24.Text = "Semester"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(144, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Subject"
        '
        'nmbtlogin
        '
        Me.nmbtlogin.BackColor = System.Drawing.Color.Teal
        Me.nmbtlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.nmbtlogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.nmbtlogin.FlatAppearance.BorderSize = 0
        Me.nmbtlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.nmbtlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.nmbtlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nmbtlogin.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmbtlogin.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.nmbtlogin.Location = New System.Drawing.Point(292, 371)
        Me.nmbtlogin.Margin = New System.Windows.Forms.Padding(0)
        Me.nmbtlogin.Name = "nmbtlogin"
        Me.nmbtlogin.Size = New System.Drawing.Size(155, 39)
        Me.nmbtlogin.TabIndex = 66
        Me.nmbtlogin.Text = "Submit"
        Me.nmbtlogin.UseVisualStyleBackColor = False
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(430, 166)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(243, 169)
        Me.CheckedListBox1.TabIndex = 67
        '
        'rough
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.nmbtlogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nmsem)
        Me.Controls.Add(Me.nmclass)
        Me.Controls.Add(Me.nmdept)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "rough"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nmsem As ComboBox
    Friend WithEvents nmclass As ComboBox
    Friend WithEvents nmdept As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nmbtlogin As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
End Class
