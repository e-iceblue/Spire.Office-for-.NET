Namespace Export
	Partial Public Class ImageViewer
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.flowLayoutPanel1 = New FlowLayoutPanel()
			Me.toolTip1 = New ToolTip(Me.components)
			Me.SuspendLayout()
			' 
			' flowLayoutPanel1
			' 
			Me.flowLayoutPanel1.AutoScroll = True
			Me.flowLayoutPanel1.BackColor = SystemColors.ControlDarkDark
			Me.flowLayoutPanel1.Dock = DockStyle.Fill
			Me.flowLayoutPanel1.Location = New Point(0, 0)
			Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
			Me.flowLayoutPanel1.Size = New Size(444, 275)
			Me.flowLayoutPanel1.TabIndex = 0
			' 
			' ImageViewer
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 12F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(444, 275)
			Me.Controls.Add(Me.flowLayoutPanel1)
			Me.FormBorderStyle = FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.Name = "ImageViewer"
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "ImageView"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private flowLayoutPanel1 As FlowLayoutPanel
		Private toolTip1 As ToolTip

	End Class
End Namespace