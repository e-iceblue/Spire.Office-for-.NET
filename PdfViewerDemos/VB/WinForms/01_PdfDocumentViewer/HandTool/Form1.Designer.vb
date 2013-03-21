Namespace HandTool
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
			Me.txtZoom = New ToolStripTextBox()
			Me.btnZoom = New ToolStripButton()
			Me.toolStripSeparator2 = New ToolStripSeparator()
			Me.btnHandTool = New ToolStripButton()
			Me.btnCancel = New ToolStripButton()
			Me.pdfDocumentViewer1 = New Spire.PdfViewer.Forms.PdfDocumentViewer()
			Me.toolStrip1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' toolStrip1
			' 
			Me.toolStrip1.Items.AddRange(New ToolStripItem() { Me.btnOpen, Me.toolStripSeparator1, Me.toolStripLabel1, Me.txtZoom, Me.btnZoom, Me.toolStripSeparator2, Me.btnHandTool, Me.btnCancel})
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
			' txtZoom
			' 
			Me.txtZoom.Name = "txtZoom"
			Me.txtZoom.Size = New Size(100, 25)
			Me.txtZoom.Text = "100"
			' 
			' btnZoom
			' 
			Me.btnZoom.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnZoom.Image = (CType(resources.GetObject("btnZoom.Image"), Image))
			Me.btnZoom.ImageTransparentColor = Color.Magenta
			Me.btnZoom.Name = "btnZoom"
			Me.btnZoom.Size = New Size(23, 22)
			Me.btnZoom.Text = "Zoom"
			Me.btnZoom.ToolTipText = "Zoom PDF document"
'			Me.btnZoom.Click += New System.EventHandler(Me.btnZoom_Click)
			' 
			' toolStripSeparator2
			' 
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			Me.toolStripSeparator2.Size = New Size(6, 25)
			' 
			' btnHandTool
			' 
			Me.btnHandTool.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnHandTool.Image = (CType(resources.GetObject("btnHandTool.Image"), Image))
			Me.btnHandTool.ImageTransparentColor = Color.Magenta
			Me.btnHandTool.Name = "btnHandTool"
			Me.btnHandTool.Size = New Size(23, 22)
			Me.btnHandTool.Text = "HandTool"
			Me.btnHandTool.ToolTipText = "Hand tool"
'			Me.btnHandTool.Click += New System.EventHandler(Me.btnHandTool_Click)
			' 
			' btnCancel
			' 
			Me.btnCancel.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnCancel.Image = (CType(resources.GetObject("btnCancel.Image"), Image))
			Me.btnCancel.ImageTransparentColor = Color.Magenta
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New Size(23, 22)
			Me.btnCancel.Text = "Cancel hand tool "
'			Me.btnCancel.Click += New System.EventHandler(Me.btnCancel_Click)
			' 
			' pdfDocumentViewer1
			' 
			Me.pdfDocumentViewer1.BackColor = Color.FromArgb((CInt((CByte(204)))), (CInt((CByte(204)))), (CInt((CByte(204)))))
			Me.pdfDocumentViewer1.Cursor = Cursors.Default
			Me.pdfDocumentViewer1.Dock = DockStyle.Fill
			Me.pdfDocumentViewer1.Location = New Point(0, 25)
			Me.pdfDocumentViewer1.Name = "pdfDocumentViewer1"
			Me.pdfDocumentViewer1.Size = New Size(742, 491)
			Me.pdfDocumentViewer1.TabIndex = 1
			Me.pdfDocumentViewer1.Text = "pdfDocumentViewer1"
			Me.pdfDocumentViewer1.Threshold = 60
			Me.pdfDocumentViewer1.ZoomMode = Spire.PdfViewer.Forms.ZoomMode.Default
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 12F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(742, 516)
			Me.Controls.Add(Me.pdfDocumentViewer1)
			Me.Controls.Add(Me.toolStrip1)
			Me.Name = "Form1"
			Me.Text = "Spire.PdfViewer(for WindForms) Demo - Hand Tool"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private toolStrip1 As ToolStrip
		Private WithEvents btnOpen As ToolStripButton
		Private WithEvents btnHandTool As ToolStripButton
		Private WithEvents btnCancel As ToolStripButton
		Private toolStripSeparator1 As ToolStripSeparator
		Private toolStripLabel1 As ToolStripLabel
		Private txtZoom As ToolStripTextBox
		Private WithEvents btnZoom As ToolStripButton
		Private pdfDocumentViewer1 As Spire.PdfViewer.Forms.PdfDocumentViewer
		Private toolStripSeparator2 As ToolStripSeparator
	End Class
End Namespace

