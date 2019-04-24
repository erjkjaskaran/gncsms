<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changesub
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
		Me.csclass = New System.Windows.Forms.ComboBox()
		Me.csdept = New System.Windows.Forms.ComboBox()
		Me.sfbtcncel = New System.Windows.Forms.Button()
		Me.sfbtsubmit = New System.Windows.Forms.Button()
		Me.cssem = New System.Windows.Forms.ComboBox()
		Me.Label26 = New System.Windows.Forms.Label()
		Me.Label25 = New System.Windows.Forms.Label()
		Me.Label24 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.csoldsub = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.csnewsub = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'csclass
		'
		Me.csclass.FormattingEnabled = True
		Me.csclass.Location = New System.Drawing.Point(277, 182)
		Me.csclass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.csclass.Name = "csclass"
		Me.csclass.Size = New System.Drawing.Size(315, 24)
		Me.csclass.TabIndex = 2
		Me.csclass.Text = "Select"
		'
		'csdept
		'
		Me.csdept.FormattingEnabled = True
		Me.csdept.Location = New System.Drawing.Point(277, 148)
		Me.csdept.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.csdept.Name = "csdept"
		Me.csdept.Size = New System.Drawing.Size(315, 24)
		Me.csdept.TabIndex = 1
		Me.csdept.Text = "Select"
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
		Me.sfbtcncel.Location = New System.Drawing.Point(375, 372)
		Me.sfbtcncel.Margin = New System.Windows.Forms.Padding(0)
		Me.sfbtcncel.Name = "sfbtcncel"
		Me.sfbtcncel.Size = New System.Drawing.Size(207, 48)
		Me.sfbtcncel.TabIndex = 7
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
		Me.sfbtsubmit.Location = New System.Drawing.Point(81, 372)
		Me.sfbtsubmit.Margin = New System.Windows.Forms.Padding(0)
		Me.sfbtsubmit.Name = "sfbtsubmit"
		Me.sfbtsubmit.Size = New System.Drawing.Size(207, 48)
		Me.sfbtsubmit.TabIndex = 6
		Me.sfbtsubmit.Text = "Submit"
		Me.sfbtsubmit.UseVisualStyleBackColor = False
		'
		'cssem
		'
		Me.cssem.FormattingEnabled = True
		Me.cssem.Location = New System.Drawing.Point(277, 217)
		Me.cssem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.cssem.Name = "cssem"
		Me.cssem.Size = New System.Drawing.Size(315, 24)
		Me.cssem.TabIndex = 3
		Me.cssem.Text = "Select"
		'
		'Label26
		'
		Me.Label26.AutoSize = True
		Me.Label26.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.Label26.Location = New System.Drawing.Point(77, 151)
		Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label26.Name = "Label26"
		Me.Label26.Size = New System.Drawing.Size(82, 17)
		Me.Label26.TabIndex = 115
		Me.Label26.Text = "Department"
		'
		'Label25
		'
		Me.Label25.AutoSize = True
		Me.Label25.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.Label25.Location = New System.Drawing.Point(77, 186)
		Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label25.Name = "Label25"
		Me.Label25.Size = New System.Drawing.Size(42, 17)
		Me.Label25.TabIndex = 114
		Me.Label25.Text = "Class"
		'
		'Label24
		'
		Me.Label24.AutoSize = True
		Me.Label24.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.Label24.Location = New System.Drawing.Point(77, 220)
		Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(68, 17)
		Me.Label24.TabIndex = 113
		Me.Label24.Text = "Semester"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Teal
		Me.Label1.Location = New System.Drawing.Point(169, 54)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(337, 48)
		Me.Label1.TabIndex = 111
		Me.Label1.Text = "Change Subject"
		'
		'csoldsub
		'
		Me.csoldsub.FormattingEnabled = True
		Me.csoldsub.Location = New System.Drawing.Point(277, 250)
		Me.csoldsub.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.csoldsub.Name = "csoldsub"
		Me.csoldsub.Size = New System.Drawing.Size(315, 24)
		Me.csoldsub.TabIndex = 4
		Me.csoldsub.Text = "Select"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.Label2.Location = New System.Drawing.Point(77, 254)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(122, 17)
		Me.Label2.TabIndex = 122
		Me.Label2.Text = "Subject to change"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.Label3.Location = New System.Drawing.Point(77, 287)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(86, 17)
		Me.Label3.TabIndex = 124
		Me.Label3.Text = "New Subject"
		'
		'csnewsub
		'
		Me.csnewsub.Location = New System.Drawing.Point(277, 283)
		Me.csnewsub.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.csnewsub.Name = "csnewsub"
		Me.csnewsub.Size = New System.Drawing.Size(315, 22)
		Me.csnewsub.TabIndex = 5
		'
		'changesub
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(691, 496)
		Me.Controls.Add(Me.csnewsub)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.csoldsub)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.csclass)
		Me.Controls.Add(Me.csdept)
		Me.Controls.Add(Me.sfbtcncel)
		Me.Controls.Add(Me.sfbtsubmit)
		Me.Controls.Add(Me.cssem)
		Me.Controls.Add(Me.Label26)
		Me.Controls.Add(Me.Label25)
		Me.Controls.Add(Me.Label24)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Name = "changesub"
		Me.Text = "changesub"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents csclass As ComboBox
    Friend WithEvents csdept As ComboBox
    Friend WithEvents sfbtcncel As Button
    Friend WithEvents sfbtsubmit As Button
    Friend WithEvents cssem As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents csoldsub As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents csnewsub As TextBox
End Class
