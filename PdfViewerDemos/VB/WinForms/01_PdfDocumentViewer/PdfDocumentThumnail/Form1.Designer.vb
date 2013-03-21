Namespace PdfDocumentThumnail
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
			Me.pdfDocumentThumbnail1 = New Spire.PdfViewer.Forms.PdfThumbnails.PdfDocumentThumbnail()
			Me.pdfDocumentViewer1 = New Spire.PdfViewer.Forms.PdfDocumentViewer()
			Me.splitContainer1 = New SplitContainer()
			Me.toolStrip1 = New ToolStrip()
			Me.btnOpen = New ToolStripButton()
			Me.toolStripSeparator1 = New ToolStripSeparator()
			Me.toolStripLabel1 = New ToolStripLabel()
			Me.txtThumbnailRatio = New ToolStripTextBox()
			Me.btnThumbnailRatio = New ToolStripButton()
			Me.tableLayoutPanel1 = New TableLayoutPanel()
			Me.splitContainer1.Panel1.SuspendLayout()
			Me.splitContainer1.Panel2.SuspendLayout()
			Me.splitContainer1.SuspendLayout()
			Me.toolStrip1.SuspendLayout()
			Me.tableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' pdfDocumentThumbnail1
			' 
			Me.pdfDocumentThumbnail1.BackColor = Color.Silver
			Me.pdfDocumentThumbnail1.Dock = DockStyle.Fill
			Me.pdfDocumentThumbnail1.Location = New Point(0, 0)
			Me.pdfDocumentThumbnail1.Name = "pdfDocumentThumbnail1"
			Me.pdfDocumentThumbnail1.Size = New Size(130, 480)
			Me.pdfDocumentThumbnail1.TabIndex = 1
			Me.pdfDocumentThumbnail1.Viewer = Me.pdfDocumentViewer1
			Me.pdfDocumentThumbnail1.ZoomPercent = 8
			' 
			' pdfDocumentViewer1
			' 
			Me.pdfDocumentViewer1.BackColor = Color.FromArgb((CInt((CByte(204)))), (CInt((CByte(204)))), (CInt((CByte(204)))))
			Me.pdfDocumentViewer1.Dock = DockStyle.Fill
			Me.pdfDocumentViewer1.Location = New Point(0, 0)
			Me.pdfDocumentViewer1.Name = "pdfDocumentViewer1"
			Me.pdfDocumentViewer1.Size = New Size(602, 480)
			Me.pdfDocumentViewer1.TabIndex = 2
			Me.pdfDocumentViewer1.Text = "pdfDocumentViewer1"
			Me.pdfDocumentViewer1.Threshold = 60
			Me.pdfDocumentViewer1.ZoomMode = Spire.PdfViewer.Forms.ZoomMode.Default
			' 
			' splitContainer1
			' 
			Me.splitContainer1.Dock = DockStyle.Fill
			Me.splitContainer1.Location = New Point(3, 33)
			Me.splitContainer1.Name = "splitContainer1"
			' 
			' splitContainer1.Panel1
			' 
			Me.splitContainer1.Panel1.Controls.Add(Me.pdfDocumentThumbnail1)
			' 
			' splitContainer1.Panel2
			' 
			Me.splitContainer1.Panel2.Controls.Add(Me.pdfDocumentViewer1)
			Me.splitContainer1.Size = New Size(736, 480)
			Me.splitContainer1.SplitterDistance = 130
			Me.splitContainer1.TabIndex = 3
			' 
			' toolStrip1
			' 
			Me.toolStrip1.Dock = DockStyle.Fill
			Me.toolStrip1.Items.AddRange(New ToolStripItem() { Me.btnOpen, Me.toolStripSeparator1, Me.toolStripLabel1, Me.txtThumbnailRatio, Me.btnThumbnailRatio})
			Me.toolStrip1.Location = New Point(0, 0)
			Me.toolStrip1.Name = "toolStrip1"
			Me.toolStrip1.Size = New Size(742, 30)
			Me.toolStrip1.TabIndex = 4
			Me.toolStrip1.Text = "toolStrip1"
			' 
			' btnOpen
			' 
			Me.btnOpen.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnOpen.Image = (CType(resources.GetObject("btnOpen.Image"), Image))
			Me.btnOpen.ImageTransparentColor = Color.Magenta
			Me.btnOpen.Name = "btnOpen"
			Me.btnOpen.Size = New Size(23, 27)
			Me.btnOpen.Text = "Open"
			Me.btnOpen.ToolTipText = "Open PDF document"
'			Me.btnOpen.Click += New System.EventHandler(Me.btnOpen_Click)
			' 
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New Size(6, 30)
			' 
			' toolStripLabel1
			' 
			Me.toolStripLabel1.Name = "toolStripLabel1"
			Me.toolStripLabel1.Size = New Size(41, 27)
			Me.toolStripLabel1.Text = "Ratio:"
			' 
			' txtThumbnailRatio
			' 
			Me.txtThumbnailRatio.Name = "txtThumbnailRatio"
			Me.txtThumbnailRatio.Size = New Size(100, 30)
			' 
			' btnThumbnailRatio
			' 
			Me.btnThumbnailRatio.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnThumbnailRatio.Image = (CType(resources.GetObject("btnThumbnailRatio.Image"), Image))
			Me.btnThumbnailRatio.ImageTransparentColor = Color.Magenta
			Me.btnThumbnailRatio.Name = "btnThumbnailRatio"
			Me.btnThumbnailRatio.Size = New Size(23, 27)
			Me.btnThumbnailRatio.Text = "Set thumbnail ratio"
			Me.btnThumbnailRatio.ToolTipText = "Set thumbnail ratio"
'			Me.btnThumbnailRatio.Click += New System.EventHandler(Me.btnThumbnailRatio_Click)
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.ColumnCount = 1
			Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
			Me.tableLayoutPanel1.Controls.Add(Me.toolStrip1, 0, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.splitContainer1, 0, 1)
			Me.tableLayoutPanel1.Dock = DockStyle.Fill
			Me.tableLayoutPanel1.Location = New Point(0, 0)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 2
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle())
			Me.tableLayoutPanel1.Size = New Size(742, 516)
			Me.tableLayoutPanel1.TabIndex = 5
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 12F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(742, 516)
			Me.Controls.Add(Me.tableLayoutPanel1)
			Me.Name = "Form1"
			Me.Text = "Spire.PdfViewer(for WinForms) Demo - PdfDocumentThumnail"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.splitContainer1.Panel1.ResumeLayout(False)
			Me.splitContainer1.Panel2.ResumeLayout(False)
			Me.splitContainer1.ResumeLayout(False)
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.tableLayoutPanel1.ResumeLayout(False)
			Me.tableLayoutPanel1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pdfDocumentThumbnail1 As Spire.PdfViewer.Forms.PdfThumbnails.PdfDocumentThumbnail
		Private pdfDocumentViewer1 As Spire.PdfViewer.Forms.PdfDocumentViewer
		Private splitContainer1 As SplitContainer
		Private toolStrip1 As ToolStrip
		Private WithEvents btnOpen As ToolStripButton
		Private toolStripSeparator1 As ToolStripSeparator
		Private toolStripLabel1 As ToolStripLabel
		Private txtThumbnailRatio As ToolStripTextBox
		Private WithEvents btnThumbnailRatio As ToolStripButton
		Private tableLayoutPanel1 As TableLayoutPanel
	End Class
End Namespace

