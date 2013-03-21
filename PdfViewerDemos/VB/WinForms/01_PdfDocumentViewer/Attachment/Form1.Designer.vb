Namespace Attachment
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
			Me.btnAttachment = New ToolStripButton()
			Me.btnAttachmentAnnotation = New ToolStripButton()
			Me.BtnCloseAttachment = New ToolStripButton()
			Me.tableLayoutPanel1 = New TableLayoutPanel()
			Me.pdfDocumentViewer1 = New Spire.PdfViewer.Forms.PdfDocumentViewer()
			Me.listView1 = New ListView()
			Me.toolStrip1.SuspendLayout()
			Me.tableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' toolStrip1
			' 
			Me.toolStrip1.Items.AddRange(New ToolStripItem() { Me.btnOpen, Me.btnAttachment, Me.btnAttachmentAnnotation, Me.BtnCloseAttachment})
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
			' btnAttachment
			' 
			Me.btnAttachment.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnAttachment.Image = (CType(resources.GetObject("btnAttachment.Image"), Image))
			Me.btnAttachment.ImageTransparentColor = Color.Magenta
			Me.btnAttachment.Name = "btnAttachment"
			Me.btnAttachment.Size = New Size(23, 22)
			Me.btnAttachment.Text = "CommonAttachment"
			Me.btnAttachment.ToolTipText = "Common attachment"
'			Me.btnAttachment.Click += New System.EventHandler(Me.btnAttachment_Click)
			' 
			' btnAttachmentAnnotation
			' 
			Me.btnAttachmentAnnotation.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnAttachmentAnnotation.Image = (CType(resources.GetObject("btnAttachmentAnnotation.Image"), Image))
			Me.btnAttachmentAnnotation.ImageTransparentColor = Color.Magenta
			Me.btnAttachmentAnnotation.Name = "btnAttachmentAnnotation"
			Me.btnAttachmentAnnotation.Size = New Size(23, 22)
			Me.btnAttachmentAnnotation.Text = "AttachmentAnnotation"
			Me.btnAttachmentAnnotation.ToolTipText = "Attachment annotation"
'			Me.btnAttachmentAnnotation.Click += New System.EventHandler(Me.btnAttachmentAnnotation_Click)
			' 
			' BtnCloseAttachment
			' 
			Me.BtnCloseAttachment.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.BtnCloseAttachment.Image = (CType(resources.GetObject("BtnCloseAttachment.Image"), Image))
			Me.BtnCloseAttachment.ImageTransparentColor = Color.Magenta
			Me.BtnCloseAttachment.Name = "BtnCloseAttachment"
			Me.BtnCloseAttachment.Size = New Size(23, 22)
			Me.BtnCloseAttachment.Text = "Closeattachment"
			Me.BtnCloseAttachment.ToolTipText = "Close attachment"
'			Me.BtnCloseAttachment.Click += New System.EventHandler(Me.BtnCloseAttachment_Click)
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.ColumnCount = 1
			Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
			Me.tableLayoutPanel1.Controls.Add(Me.pdfDocumentViewer1, 0, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.listView1, 0, 1)
			Me.tableLayoutPanel1.Dock = DockStyle.Fill
			Me.tableLayoutPanel1.Location = New Point(0, 25)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 2
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
			Me.tableLayoutPanel1.Size = New Size(742, 491)
			Me.tableLayoutPanel1.TabIndex = 1
			' 
			' pdfDocumentViewer1
			' 
			Me.pdfDocumentViewer1.BackColor = Color.FromArgb((CInt((CByte(204)))), (CInt((CByte(204)))), (CInt((CByte(204)))))
			Me.pdfDocumentViewer1.Cursor = Cursors.Default
			Me.pdfDocumentViewer1.Dock = DockStyle.Fill
			Me.pdfDocumentViewer1.Location = New Point(3, 3)
			Me.pdfDocumentViewer1.Name = "pdfDocumentViewer1"
			Me.pdfDocumentViewer1.Size = New Size(736, 386)
			Me.pdfDocumentViewer1.TabIndex = 0
			Me.pdfDocumentViewer1.Text = "pdfDocumentViewer1"
			Me.pdfDocumentViewer1.Threshold = 60
			Me.pdfDocumentViewer1.ZoomMode = Spire.PdfViewer.Forms.ZoomMode.Default
			' 
			' listView1
			' 
			Me.listView1.Dock = DockStyle.Fill
			Me.listView1.Location = New Point(3, 395)
			Me.listView1.Name = "listView1"
			Me.listView1.Size = New Size(736, 93)
			Me.listView1.TabIndex = 1
			Me.listView1.UseCompatibleStateImageBehavior = False
'			Me.listView1.Click += New System.EventHandler(Me.listView1_Click)
'			Me.listView1.DoubleClick += New System.EventHandler(Me.listView1_DoubleClick)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 12F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(742, 516)
			Me.Controls.Add(Me.tableLayoutPanel1)
			Me.Controls.Add(Me.toolStrip1)
			Me.Name = "Form1"
			Me.Text = "Spire.PdfViewer(for WinForms) Demo - Attachment"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.tableLayoutPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private toolStrip1 As ToolStrip
		Private WithEvents btnOpen As ToolStripButton
		Private WithEvents btnAttachment As ToolStripButton
		Private WithEvents btnAttachmentAnnotation As ToolStripButton
		Private tableLayoutPanel1 As TableLayoutPanel
		Private pdfDocumentViewer1 As Spire.PdfViewer.Forms.PdfDocumentViewer
		Private WithEvents listView1 As ListView
		Private WithEvents BtnCloseAttachment As ToolStripButton
	End Class
End Namespace

