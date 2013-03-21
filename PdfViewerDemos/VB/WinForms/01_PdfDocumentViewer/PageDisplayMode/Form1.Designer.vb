Namespace PageDisplayMode
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
			Me.btnSingleContinuous = New ToolStripButton()
			Me.btnSingleDiscontinuous = New ToolStripButton()
			Me.btnDoubleContinuous = New ToolStripButton()
			Me.btnDoubleDiscontinuous = New ToolStripButton()
			Me.toolStripSeparator2 = New ToolStripSeparator()
			Me.lblPage = New ToolStripLabel()
			Me.pdfDocumentViewer1 = New Spire.PdfViewer.Forms.PdfDocumentViewer()
			Me.toolStrip1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' toolStrip1
			' 
			Me.toolStrip1.Items.AddRange(New ToolStripItem() { Me.btnOpen, Me.toolStripSeparator1, Me.btnSingleContinuous, Me.btnSingleDiscontinuous, Me.btnDoubleContinuous, Me.btnDoubleDiscontinuous, Me.toolStripSeparator2, Me.lblPage})
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
			' btnSingleContinuous
			' 
			Me.btnSingleContinuous.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnSingleContinuous.Image = (CType(resources.GetObject("btnSingleContinuous.Image"), Image))
			Me.btnSingleContinuous.ImageTransparentColor = Color.Magenta
			Me.btnSingleContinuous.Name = "btnSingleContinuous"
			Me.btnSingleContinuous.Size = New Size(23, 22)
			Me.btnSingleContinuous.Text = "SingleContinuous"
			Me.btnSingleContinuous.ToolTipText = "Single continuous page mode"
'			Me.btnSingleContinuous.Click += New System.EventHandler(Me.btnSingleContinuous_Click)
			' 
			' btnSingleDiscontinuous
			' 
			Me.btnSingleDiscontinuous.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnSingleDiscontinuous.Image = (CType(resources.GetObject("btnSingleDiscontinuous.Image"), Image))
			Me.btnSingleDiscontinuous.ImageTransparentColor = Color.Magenta
			Me.btnSingleDiscontinuous.Name = "btnSingleDiscontinuous"
			Me.btnSingleDiscontinuous.Size = New Size(23, 22)
			Me.btnSingleDiscontinuous.Text = "SingleDiscontinuous"
			Me.btnSingleDiscontinuous.ToolTipText = "Single discontinuous page mode"
'			Me.btnSingleDiscontinuous.Click += New System.EventHandler(Me.btnSingleDiscontinuous_Click)
			' 
			' btnDoubleContinuous
			' 
			Me.btnDoubleContinuous.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnDoubleContinuous.Image = (CType(resources.GetObject("btnDoubleContinuous.Image"), Image))
			Me.btnDoubleContinuous.ImageTransparentColor = Color.Magenta
			Me.btnDoubleContinuous.Name = "btnDoubleContinuous"
			Me.btnDoubleContinuous.Size = New Size(23, 22)
			Me.btnDoubleContinuous.Text = "DoubleContinuous"
			Me.btnDoubleContinuous.ToolTipText = "Double continuous  page mode"
'			Me.btnDoubleContinuous.Click += New System.EventHandler(Me.btnDoubleContinuous_Click)
			' 
			' btnDoubleDiscontinuous
			' 
			Me.btnDoubleDiscontinuous.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnDoubleDiscontinuous.Image = (CType(resources.GetObject("btnDoubleDiscontinuous.Image"), Image))
			Me.btnDoubleDiscontinuous.ImageTransparentColor = Color.Magenta
			Me.btnDoubleDiscontinuous.Name = "btnDoubleDiscontinuous"
			Me.btnDoubleDiscontinuous.Size = New Size(23, 22)
			Me.btnDoubleDiscontinuous.Text = "DoubleDiscontinuous"
'			Me.btnDoubleDiscontinuous.Click += New System.EventHandler(Me.btnDoubleDiscontinuous_Click)
			' 
			' toolStripSeparator2
			' 
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			Me.toolStripSeparator2.Size = New Size(6, 25)
			' 
			' lblPage
			' 
			Me.lblPage.Name = "lblPage"
			Me.lblPage.Size = New Size(11, 22)
			Me.lblPage.Text = "0"
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
'			Me.pdfDocumentViewer1.PageNumberChanged += New Spire.PdfViewer.PageNumberChangedEventHandler(Me.pdfDocumentViewer1_PageNumberChanged)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 12F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(742, 516)
			Me.Controls.Add(Me.pdfDocumentViewer1)
			Me.Controls.Add(Me.toolStrip1)
			Me.Name = "Form1"
			Me.Text = "Spire.PdfViewer(for WinForms) Demo _ Page Display Mode"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private toolStrip1 As ToolStrip
		Private WithEvents btnOpen As ToolStripButton
		Private toolStripSeparator1 As ToolStripSeparator
		Private WithEvents btnSingleContinuous As ToolStripButton
		Private WithEvents btnSingleDiscontinuous As ToolStripButton
		Private WithEvents btnDoubleContinuous As ToolStripButton
		Private WithEvents btnDoubleDiscontinuous As ToolStripButton
		Private WithEvents pdfDocumentViewer1 As Spire.PdfViewer.Forms.PdfDocumentViewer
		Private toolStripSeparator2 As ToolStripSeparator
		Private lblPage As ToolStripLabel
	End Class
End Namespace

