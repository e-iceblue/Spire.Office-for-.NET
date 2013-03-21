Namespace Bookmark
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
			Me.toolStripSeparator1 = New ToolStripSeparator()
			Me.toolStripLabel1 = New ToolStripLabel()
			Me.txtZoomPercent = New ToolStripTextBox()
			Me.btnZoom = New ToolStripButton()
			Me.splitContainer1 = New SplitContainer()
			Me.treeViewBookmark = New TreeView()
			Me.pdfDocumentViewer1 = New Spire.PdfViewer.Forms.PdfDocumentViewer()
			Me.toolStrip1.SuspendLayout()
			Me.splitContainer1.Panel1.SuspendLayout()
			Me.splitContainer1.Panel2.SuspendLayout()
			Me.splitContainer1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' toolStrip1
			' 
			Me.toolStrip1.Items.AddRange(New ToolStripItem() { Me.btnOpen, Me.toolStripSeparator1, Me.toolStripLabel1, Me.txtZoomPercent, Me.btnZoom})
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
			Me.btnOpen.Text = "Open PDF document"
'			Me.btnOpen.Click += New System.EventHandler(Me.btnOpen_Click)
			' 
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New Size(6, 25)
			' 
			' toolStripLabel1
			' 
			Me.toolStripLabel1.Name = "toolStripLabel1"
			Me.toolStripLabel1.Size = New Size(77, 22)
			Me.toolStripLabel1.Text = "ZoomPercent:"
			' 
			' txtZoomPercent
			' 
			Me.txtZoomPercent.Name = "txtZoomPercent"
			Me.txtZoomPercent.Size = New Size(100, 25)
			Me.txtZoomPercent.Text = "100"
			' 
			' btnZoom
			' 
			Me.btnZoom.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnZoom.Image = (CType(resources.GetObject("btnZoom.Image"), Image))
			Me.btnZoom.ImageTransparentColor = Color.Magenta
			Me.btnZoom.Name = "btnZoom"
			Me.btnZoom.Size = New Size(23, 22)
			Me.btnZoom.Text = "Zoom PDF document"
'			Me.btnZoom.Click += New System.EventHandler(Me.btnZoom_Click)
			' 
			' splitContainer1
			' 
			Me.splitContainer1.Dock = DockStyle.Fill
			Me.splitContainer1.Location = New Point(0, 25)
			Me.splitContainer1.Name = "splitContainer1"
			' 
			' splitContainer1.Panel1
			' 
			Me.splitContainer1.Panel1.Controls.Add(Me.treeViewBookmark)
			' 
			' splitContainer1.Panel2
			' 
			Me.splitContainer1.Panel2.Controls.Add(Me.pdfDocumentViewer1)
			Me.splitContainer1.Size = New Size(742, 491)
			Me.splitContainer1.SplitterDistance = 217
			Me.splitContainer1.TabIndex = 1
			' 
			' treeViewBookmark
			' 
			Me.treeViewBookmark.Dock = DockStyle.Fill
			Me.treeViewBookmark.Location = New Point(0, 0)
			Me.treeViewBookmark.Name = "treeViewBookmark"
			Me.treeViewBookmark.Size = New Size(217, 491)
			Me.treeViewBookmark.TabIndex = 0
'			Me.treeViewBookmark.AfterSelect += New System.Windows.Forms.TreeViewEventHandler(Me.treeViewBookmark_AfterSelect)
			' 
			' pdfDocumentViewer1
			' 
			Me.pdfDocumentViewer1.BackColor = Color.FromArgb((CInt((CByte(204)))), (CInt((CByte(204)))), (CInt((CByte(204)))))
			Me.pdfDocumentViewer1.Cursor = Cursors.Default
			Me.pdfDocumentViewer1.Dock = DockStyle.Fill
			Me.pdfDocumentViewer1.Location = New Point(0, 0)
			Me.pdfDocumentViewer1.Name = "pdfDocumentViewer1"
			Me.pdfDocumentViewer1.Size = New Size(521, 491)
			Me.pdfDocumentViewer1.TabIndex = 0
			Me.pdfDocumentViewer1.Text = "pdfDocumentViewer1"
			Me.pdfDocumentViewer1.Threshold = 60
			Me.pdfDocumentViewer1.ZoomMode = Spire.PdfViewer.Forms.ZoomMode.Default
'			Me.pdfDocumentViewer1.PdfLoaded += New Spire.PdfViewer.DocumentOpenedEventHandler(Me.pdfDocumentViewer1_PdfLoaded)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 12F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(742, 516)
			Me.Controls.Add(Me.splitContainer1)
			Me.Controls.Add(Me.toolStrip1)
			Me.Name = "Form1"
			Me.Text = "Spire.PdfViewer(for WinForms) Demo - Bookmark"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.splitContainer1.Panel1.ResumeLayout(False)
			Me.splitContainer1.Panel2.ResumeLayout(False)
			Me.splitContainer1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private toolStrip1 As ToolStrip
		Private WithEvents btnOpen As ToolStripButton
		Private splitContainer1 As SplitContainer
		Private WithEvents treeViewBookmark As TreeView
		Private toolStripSeparator1 As ToolStripSeparator
		Private toolStripLabel1 As ToolStripLabel
		Private txtZoomPercent As ToolStripTextBox
		Private WithEvents btnZoom As ToolStripButton
		Private WithEvents pdfDocumentViewer1 As Spire.PdfViewer.Forms.PdfDocumentViewer
	End Class
End Namespace

