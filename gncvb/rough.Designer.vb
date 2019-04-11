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
        Me.GncDataSet1 = New gncvb.GNCDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.GncDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GncDataSet1
        '
        Me.GncDataSet1.DataSetName = "GNCDataSet"
        Me.GncDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(123, 174)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(528, 192)
        Me.DataGridView1.TabIndex = 54
        '
        'rough
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.nmsem)
        Me.Controls.Add(Me.nmclass)
        Me.Controls.Add(Me.nmdept)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "rough"
        Me.Text = "Form2"
        CType(Me.GncDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nmsem As ComboBox
    Friend WithEvents nmclass As ComboBox
    Friend WithEvents nmdept As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents GncDataSet1 As GNCDataSet
    Friend WithEvents DataGridView1 As DataGridView
End Class
