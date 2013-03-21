Namespace PdfViewer_HelloWorld
	Partial Public Class Form1
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
			Me.pdfViewer1 = New Spire.PdfViewer.Forms.PdfViewer()
			Me.SuspendLayout()
			' 
			' pdfViewer1
			' 
			Me.pdfViewer1.Dock = DockStyle.Fill
			Me.pdfViewer1.IsToolBarVisible = True
			Me.pdfViewer1.Location = New Point(0, 0)
			Me.pdfViewer1.Name = "pdfViewer1"
			Me.pdfViewer1.Size = New Size(792, 566)
			Me.pdfViewer1.TabIndex = 1
			Me.pdfViewer1.Text = "pdfViewer1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 12F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(792, 566)
			Me.Controls.Add(Me.pdfViewer1)
			Me.Name = "Form1"
			Me.Text = "Spire.PdfViewer Demo - Hello World!"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pdfViewer1 As Spire.PdfViewer.Forms.PdfViewer
	End Class
End Namespace

