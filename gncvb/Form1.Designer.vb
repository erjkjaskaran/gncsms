<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Me.components = New System.ComponentModel.Container()
		Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.Label2 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'ProgressBar1
		'
		Me.ProgressBar1.Location = New System.Drawing.Point(16, 494)
		Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(1035, 28)
		Me.ProgressBar1.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(336, 226)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(277, 97)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Loading"
		'
		'Timer1
		'
		Me.Timer1.Interval = 65
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(642, 270)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(0, 17)
		Me.Label2.TabIndex = 2
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1067, 554)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.ProgressBar1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
	Friend WithEvents Timer1 As Timer
	Friend WithEvents Label2 As Label
End Class
