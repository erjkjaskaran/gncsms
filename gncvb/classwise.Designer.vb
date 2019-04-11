<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class classwise
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
        Me.cwdept = New System.Windows.Forms.ComboBox()
        Me.cwsem = New System.Windows.Forms.ComboBox()
        Me.cwclass = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pfbtcancel = New System.Windows.Forms.Button()
        Me.pfbtsubmit = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(183, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(453, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "List of Students Class Wise"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Department"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(234, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Class"
        '
        'cwdept
        '
        Me.cwdept.FormattingEnabled = True
        Me.cwdept.Location = New System.Drawing.Point(94, 79)
        Me.cwdept.Name = "cwdept"
        Me.cwdept.Size = New System.Drawing.Size(121, 21)
        Me.cwdept.TabIndex = 3
        '
        'cwsem
        '
        Me.cwsem.FormattingEnabled = True
        Me.cwsem.Location = New System.Drawing.Point(469, 79)
        Me.cwsem.Name = "cwsem"
        Me.cwsem.Size = New System.Drawing.Size(121, 21)
        Me.cwsem.TabIndex = 7
        '
        'cwclass
        '
        Me.cwclass.FormattingEnabled = True
        Me.cwclass.Location = New System.Drawing.Point(272, 79)
        Me.cwclass.Name = "cwclass"
        Me.cwclass.Size = New System.Drawing.Size(121, 21)
        Me.cwclass.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(412, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Semester"
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
        Me.pfbtcancel.Location = New System.Drawing.Point(749, 72)
        Me.pfbtcancel.Margin = New System.Windows.Forms.Padding(0)
        Me.pfbtcancel.Name = "pfbtcancel"
        Me.pfbtcancel.Size = New System.Drawing.Size(114, 30)
        Me.pfbtcancel.TabIndex = 72
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
        Me.pfbtsubmit.Location = New System.Drawing.Point(619, 72)
        Me.pfbtsubmit.Margin = New System.Windows.Forms.Padding(0)
        Me.pfbtsubmit.Name = "pfbtsubmit"
        Me.pfbtsubmit.Size = New System.Drawing.Size(114, 30)
        Me.pfbtsubmit.TabIndex = 71
        Me.pfbtsubmit.Text = "Submit"
        Me.pfbtsubmit.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(42, 140)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(807, 276)
        Me.DataGridView1.TabIndex = 73
        '
        'classwise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.pfbtcancel)
        Me.Controls.Add(Me.pfbtsubmit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cwclass)
        Me.Controls.Add(Me.cwsem)
        Me.Controls.Add(Me.cwdept)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "classwise"
        Me.Text = "classwise"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cwdept As ComboBox
    Friend WithEvents cwsem As ComboBox
    Friend WithEvents cwclass As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents pfbtcancel As Button
    Friend WithEvents pfbtsubmit As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
