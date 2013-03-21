Namespace PdfDocumentViewer_Export
	Partial Public Class FormImages
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
			Me.panelImages1 = New FlowLayoutPanel()
			Me.SuspendLayout()
			' 
			' panelImages1
			' 
			Me.panelImages1.AutoScroll = True
			Me.panelImages1.Dock = DockStyle.Fill
			Me.panelImages1.Location = New Point(0, 0)
			Me.panelImages1.Name = "panelImages1"
			Me.panelImages1.Size = New Size(484, 362)
			Me.panelImages1.TabIndex = 1
			' 
			' FormImages
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 12F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoSize = True
			Me.ClientSize = New Size(484, 362)
			Me.Controls.Add(Me.panelImages1)
			Me.Name = "FormImages"
			Me.Text = "Spire.PdfViewer Demo - View Exported Images"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panelImages1 As FlowLayoutPanel
	End Class
End Namespace