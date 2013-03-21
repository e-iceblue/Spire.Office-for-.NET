Namespace ViewerMode
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
			Me.btnContinuous = New ToolStripButton()
			Me.btnSingle = New ToolStripButton()
			Me.btnAuto = New ToolStripButton()
			Me.toolStripLabel1 = New ToolStripLabel()
			Me.txtThreshold = New ToolStripTextBox()
			Me.btnThreshold = New ToolStripButton()
			Me.pdfDocumentViewer1 = New Spire.PdfViewer.Forms.PdfDocumentViewer()
			Me.lblPage = New ToolStripLabel()
			Me.toolStripSeparator1 = New ToolStripSeparator()
			Me.toolStripSeparator2 = New ToolStripSeparator()
			Me.toolStrip1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' toolStrip1
			' 
			Me.toolStrip1.Items.AddRange(New ToolStripItem() { Me.btnOpen, Me.toolStripSeparator1, Me.btnContinuous, Me.btnSingle, Me.btnAuto, Me.toolStripLabel1, Me.txtThreshold, Me.btnThreshold, Me.toolStripSeparator2, Me.lblPage})
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
'			Me.btnOpen.Click += New System.EventHandler(Me.btnOpen_Click)
			' 
			' btnContinuous
			' 
			Me.btnContinuous.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnContinuous.Image = (CType(resources.GetObject("btnContinuous.Image"), Image))
			Me.btnContinuous.ImageTransparentColor = Color.Magenta
			Me.btnContinuous.Name = "btnContinuous"
			Me.btnContinuous.Size = New Size(23, 22)
			Me.btnContinuous.Text = "Continuous"
			Me.btnContinuous.ToolTipText = "Continuous mode"
'			Me.btnContinuous.Click += New System.EventHandler(Me.btnContinuous_Click)
			' 
			' btnSingle
			' 
			Me.btnSingle.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnSingle.Image = (CType(resources.GetObject("btnSingle.Image"), Image))
			Me.btnSingle.ImageTransparentColor = Color.Magenta
			Me.btnSingle.Name = "btnSingle"
			Me.btnSingle.Size = New Size(23, 22)
			Me.btnSingle.Text = "Single"
			Me.btnSingle.ToolTipText = "Single mode"
'			Me.btnSingle.Click += New System.EventHandler(Me.btnSingle_Click)
			' 
			' btnAuto
			' 
			Me.btnAuto.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnAuto.Image = (CType(resources.GetObject("btnAuto.Image"), Image))
			Me.btnAuto.ImageTransparentColor = Color.Magenta
			Me.btnAuto.Name = "btnAuto"
			Me.btnAuto.Size = New Size(23, 22)
			Me.btnAuto.Text = "Auto"
			Me.btnAuto.ToolTipText = "Auto mode"
'			Me.btnAuto.Click += New System.EventHandler(Me.btnAuto_Click)
			' 
			' toolStripLabel1
			' 
			Me.toolStripLabel1.DisplayStyle = ToolStripItemDisplayStyle.Text
			Me.toolStripLabel1.Name = "toolStripLabel1"
			Me.toolStripLabel1.Size = New Size(65, 22)
			Me.toolStripLabel1.Text = "Threshold:"
			' 
			' txtThreshold
			' 
			Me.txtThreshold.Name = "txtThreshold"
			Me.txtThreshold.Size = New Size(100, 25)
			' 
			' btnThreshold
			' 
			Me.btnThreshold.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnThreshold.Image = (CType(resources.GetObject("btnThreshold.Image"), Image))
			Me.btnThreshold.ImageTransparentColor = Color.Magenta
			Me.btnThreshold.Name = "btnThreshold"
			Me.btnThreshold.Size = New Size(23, 22)
			Me.btnThreshold.Text = "Specify Threshold"
'			Me.btnThreshold.Click += New System.EventHandler(Me.btnThreshold_Click)
			' 
			' pdfDocumentViewer1
			' 
			Me.pdfDocumentViewer1.BackColor = Color.FromArgb((CInt((CByte(204)))), (CInt((CByte(204)))), (CInt((CByte(204)))))
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
			' lblPage
			' 
			Me.lblPage.Name = "lblPage"
			Me.lblPage.Size = New Size(11, 22)
			Me.lblPage.Text = "0"
			' 
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New Size(6, 25)
			' 
			' toolStripSeparator2
			' 
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			Me.toolStripSeparator2.Size = New Size(6, 25)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 12F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(742, 516)
			Me.Controls.Add(Me.pdfDocumentViewer1)
			Me.Controls.Add(Me.toolStrip1)
			Me.Name = "Form1"
			Me.Text = "Spire.PdfViewer(for WinForms) Demo - Viewer Mode"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private toolStrip1 As ToolStrip
		Private WithEvents btnOpen As ToolStripButton
		Private WithEvents btnContinuous As ToolStripButton
		Private WithEvents btnSingle As ToolStripButton
		Private WithEvents btnAuto As ToolStripButton
		Private toolStripLabel1 As ToolStripLabel
		Private txtThreshold As ToolStripTextBox
		Private WithEvents btnThreshold As ToolStripButton
		Private WithEvents pdfDocumentViewer1 As Spire.PdfViewer.Forms.PdfDocumentViewer
		Private lblPage As ToolStripLabel
		Private toolStripSeparator1 As ToolStripSeparator
		Private toolStripSeparator2 As ToolStripSeparator
	End Class
End Namespace

