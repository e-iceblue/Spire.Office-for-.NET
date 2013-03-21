Namespace PdfDocumentViewer_Zoom
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.btnOPen = New System.Windows.Forms.ToolStripButton()
            Me.comBoxPages = New System.Windows.Forms.ToolStripComboBox()
            Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.toolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
            Me.comBoxZoom = New System.Windows.Forms.ToolStripComboBox()
            Me.btnZoomOut = New System.Windows.Forms.ToolStripButton()
            Me.btnZoonIn = New System.Windows.Forms.ToolStripButton()
            Me.btnDynamic = New System.Windows.Forms.ToolStripButton()
            Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.btnActural = New System.Windows.Forms.ToolStripButton()
            Me.btnFitPage = New System.Windows.Forms.ToolStripButton()
            Me.btnFitWidth = New System.Windows.Forms.ToolStripButton()
            Me.pdfDocumentViewer1 = New Spire.PdfViewer.Forms.PdfDocumentViewer()
            Me.toolStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'toolStrip1
            '
            Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOPen, Me.comBoxPages, Me.toolStripSeparator1, Me.toolStripLabel1, Me.comBoxZoom, Me.btnZoomOut, Me.btnZoonIn, Me.btnDynamic, Me.toolStripSeparator2, Me.btnActural, Me.btnFitPage, Me.btnFitWidth})
            Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.toolStrip1.Name = "toolStrip1"
            Me.toolStrip1.Size = New System.Drawing.Size(784, 25)
            Me.toolStrip1.TabIndex = 0
            Me.toolStrip1.Text = "toolStrip1"
            '
            'btnOPen
            '
            Me.btnOPen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnOPen.Image = CType(resources.GetObject("btnOPen.Image"), System.Drawing.Image)
            Me.btnOPen.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnOPen.Name = "btnOPen"
            Me.btnOPen.Size = New System.Drawing.Size(23, 22)
            Me.btnOPen.Text = "Open"
            Me.btnOPen.ToolTipText = "Open PDF Document"
            '
            'comBoxPages
            '
            Me.comBoxPages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comBoxPages.Name = "comBoxPages"
            Me.comBoxPages.Size = New System.Drawing.Size(121, 25)
            '
            'toolStripSeparator1
            '
            Me.toolStripSeparator1.Name = "toolStripSeparator1"
            Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
            '
            'toolStripLabel1
            '
            Me.toolStripLabel1.Name = "toolStripLabel1"
            Me.toolStripLabel1.Size = New System.Drawing.Size(35, 22)
            Me.toolStripLabel1.Text = "Zoom:"
            '
            'comBoxZoom
            '
            Me.comBoxZoom.Name = "comBoxZoom"
            Me.comBoxZoom.Size = New System.Drawing.Size(121, 25)
            '
            'btnZoomOut
            '
            Me.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnZoomOut.Image = CType(resources.GetObject("btnZoomOut.Image"), System.Drawing.Image)
            Me.btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnZoomOut.Name = "btnZoomOut"
            Me.btnZoomOut.Size = New System.Drawing.Size(23, 22)
            Me.btnZoomOut.Text = "Zoom Out"
            Me.btnZoomOut.ToolTipText = "Zoom Out "
            '
            'btnZoonIn
            '
            Me.btnZoonIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnZoonIn.Image = CType(resources.GetObject("btnZoonIn.Image"), System.Drawing.Image)
            Me.btnZoonIn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnZoonIn.Name = "btnZoonIn"
            Me.btnZoonIn.Size = New System.Drawing.Size(23, 22)
            Me.btnZoonIn.Text = "ZoonIn"
            Me.btnZoonIn.ToolTipText = "Zoon In "
            '
            'btnDynamic
            '
            Me.btnDynamic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnDynamic.Enabled = False
            Me.btnDynamic.Image = CType(resources.GetObject("btnDynamic.Image"), System.Drawing.Image)
            Me.btnDynamic.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnDynamic.Name = "btnDynamic"
            Me.btnDynamic.Size = New System.Drawing.Size(23, 22)
            Me.btnDynamic.Text = "Zoom Dynamic"
            Me.btnDynamic.ToolTipText = "Zoom Dynamic"
            '
            'toolStripSeparator2
            '
            Me.toolStripSeparator2.Name = "toolStripSeparator2"
            Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
            '
            'btnActural
            '
            Me.btnActural.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnActural.Image = CType(resources.GetObject("btnActural.Image"), System.Drawing.Image)
            Me.btnActural.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnActural.Name = "btnActural"
            Me.btnActural.Size = New System.Drawing.Size(23, 22)
            Me.btnActural.Text = "Actual"
            Me.btnActural.ToolTipText = "Actual Size "
            '
            'btnFitPage
            '
            Me.btnFitPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnFitPage.Image = CType(resources.GetObject("btnFitPage.Image"), System.Drawing.Image)
            Me.btnFitPage.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnFitPage.Name = "btnFitPage"
            Me.btnFitPage.Size = New System.Drawing.Size(23, 22)
            Me.btnFitPage.Text = "FitPage"
            Me.btnFitPage.ToolTipText = "Fit Page"
            '
            'btnFitWidth
            '
            Me.btnFitWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnFitWidth.Image = CType(resources.GetObject("btnFitWidth.Image"), System.Drawing.Image)
            Me.btnFitWidth.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnFitWidth.Name = "btnFitWidth"
            Me.btnFitWidth.Size = New System.Drawing.Size(23, 22)
            Me.btnFitWidth.Text = "FitWidth"
            Me.btnFitWidth.ToolTipText = "Fit Width"
            '
            'pdfDocumentViewer1
            '
            Me.pdfDocumentViewer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.pdfDocumentViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pdfDocumentViewer1.Location = New System.Drawing.Point(0, 25)
            Me.pdfDocumentViewer1.Name = "pdfDocumentViewer1"
            Me.pdfDocumentViewer1.Size = New System.Drawing.Size(784, 537)
            Me.pdfDocumentViewer1.TabIndex = 1
            Me.pdfDocumentViewer1.Text = "pdfDocumentViewer1"
            Me.pdfDocumentViewer1.ZoomMode = Spire.PdfViewer.Forms.ZoomMode.[Default]
            '
            'Form1
            '
            Me.ClientSize = New System.Drawing.Size(784, 562)
            Me.Controls.Add(Me.pdfDocumentViewer1)
            Me.Controls.Add(Me.toolStrip1)
            Me.Name = "Form1"
            Me.Text = "Spire.PdfViewer Demo - Zoom and Page layout"
            Me.toolStrip1.ResumeLayout(False)
            Me.toolStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private toolStrip1 As ToolStrip
        Private WithEvents btnOPen As ToolStripButton
        Private toolStripSeparator1 As ToolStripSeparator
        Private toolStripLabel1 As ToolStripLabel
        Private WithEvents comBoxZoom As ToolStripComboBox
        Private WithEvents btnZoomOut As ToolStripButton
        Private WithEvents btnZoonIn As ToolStripButton
        Private toolStripSeparator2 As ToolStripSeparator
        Private WithEvents btnActural As ToolStripButton
        Private WithEvents btnFitPage As ToolStripButton
        Private WithEvents btnFitWidth As ToolStripButton
        Private WithEvents btnDynamic As ToolStripButton
        Private WithEvents pdfDocumentViewer1 As Spire.PdfViewer.Forms.PdfDocumentViewer
        Friend WithEvents comBoxPages As System.Windows.Forms.ToolStripComboBox
	End Class
End Namespace

