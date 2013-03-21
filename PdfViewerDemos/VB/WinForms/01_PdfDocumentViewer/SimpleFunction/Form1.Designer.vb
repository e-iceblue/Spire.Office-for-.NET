Namespace SimpleFunction
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.toolStrip1 = New ToolStrip()
			Me.btnOpen = New ToolStripButton()
			Me.btnInfo = New ToolStripButton()
			Me.btnVerifyEncrypt = New ToolStripButton()
			Me.btnFromHtml = New ToolStripButton()
			Me.pdfDocumentViewer1 = New Spire.PdfViewer.Forms.PdfDocumentViewer()
			Me.toolStrip1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' toolStrip1
			' 
			Me.toolStrip1.Items.AddRange(New ToolStripItem() { Me.btnOpen, Me.btnInfo, Me.btnVerifyEncrypt, Me.btnFromHtml})
			Me.toolStrip1.Location = New Point(0, 0)
			Me.toolStrip1.Name = "toolStrip1"
			Me.toolStrip1.Size = New Size(742, 25)
			Me.toolStrip1.TabIndex = 0
			Me.toolStrip1.Text = "toolStrip1"
			' 
			' btnOpen
			' 
			Me.btnOpen.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnOpen.Image = (CType(resources.GetObject("btnOpen.Image"), Image))
			Me.btnOpen.ImageTransparentColor = Color.Magenta
			Me.btnOpen.Name = "btnOpen"
			Me.btnOpen.Size = New Size(23, 22)
			Me.btnOpen.Text = "Open"
			Me.btnOpen.ToolTipText = "Open PDF document"
'			Me.btnOpen.Click += New System.EventHandler(Me.btnOpen_Click)
			' 
			' btnInfo
			' 
			Me.btnInfo.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnInfo.Image = (CType(resources.GetObject("btnInfo.Image"), Image))
			Me.btnInfo.ImageTransparentColor = Color.Magenta
			Me.btnInfo.Name = "btnInfo"
			Me.btnInfo.Size = New Size(23, 22)
			Me.btnInfo.Text = "Info"
			Me.btnInfo.ToolTipText = "Document information"
'			Me.btnInfo.Click += New System.EventHandler(Me.btnInfo_Click)
			' 
			' btnVerifyEncrypt
			' 
			Me.btnVerifyEncrypt.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnVerifyEncrypt.Image = (CType(resources.GetObject("btnVerifyEncrypt.Image"), Image))
			Me.btnVerifyEncrypt.ImageTransparentColor = Color.Magenta
			Me.btnVerifyEncrypt.Name = "btnVerifyEncrypt"
			Me.btnVerifyEncrypt.Size = New Size(23, 22)
			Me.btnVerifyEncrypt.Text = "VeryfyEncrypt"
			Me.btnVerifyEncrypt.ToolTipText = "PDF document whether to encrypt"
'			Me.btnVerifyEncrypt.Click += New System.EventHandler(Me.btnVerifyEncrypt_Click)
			' 
			' btnFromHtml
			' 
			Me.btnFromHtml.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnFromHtml.Image = (CType(resources.GetObject("btnFromHtml.Image"), Image))
			Me.btnFromHtml.ImageTransparentColor = Color.Magenta
			Me.btnFromHtml.Name = "btnFromHtml"
			Me.btnFromHtml.Size = New Size(23, 22)
			Me.btnFromHtml.Text = "FromHtml"
			Me.btnFromHtml.ToolTipText = "Load PDF From Html"
'			Me.btnFromHtml.Click += New System.EventHandler(Me.btnFromHtml_Click)
			' 
			' pdfDocumentViewer1
			' 
			Me.pdfDocumentViewer1.BackColor = Color.FromArgb((CInt((CByte(204)))), (CInt((CByte(204)))), (CInt((CByte(204)))))
			Me.pdfDocumentViewer1.Cursor = Cursors.Default
			Me.pdfDocumentViewer1.Dock = DockStyle.Fill
			Me.pdfDocumentViewer1.Location = New Point(0, 25)
			Me.pdfDocumentViewer1.Name = "pdfDocumentViewer1"
			Me.pdfDocumentViewer1.Size = New Size(742, 591)
			Me.pdfDocumentViewer1.TabIndex = 1
			Me.pdfDocumentViewer1.Text = "pdfDocumentViewer1"
			Me.pdfDocumentViewer1.Threshold = 60
			Me.pdfDocumentViewer1.ZoomMode = Spire.PdfViewer.Forms.ZoomMode.Default
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 12F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(742, 616)
			Me.Controls.Add(Me.pdfDocumentViewer1)
			Me.Controls.Add(Me.toolStrip1)
			Me.Name = "Form1"
			Me.Text = "Spire.PdfViewer(for WinfForms) Demo - Simple Function"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private toolStrip1 As ToolStrip
		Private WithEvents btnOpen As ToolStripButton
		Private WithEvents btnInfo As ToolStripButton
		Private WithEvents btnVerifyEncrypt As ToolStripButton
		Private WithEvents btnFromHtml As ToolStripButton
		Private pdfDocumentViewer1 As Spire.PdfViewer.Forms.PdfDocumentViewer
	End Class
End Namespace

