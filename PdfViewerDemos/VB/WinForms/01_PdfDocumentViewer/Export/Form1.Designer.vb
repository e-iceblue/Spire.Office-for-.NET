Namespace PdfDocumentViewer_Export
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
            Me.btnOpen = New System.Windows.Forms.ToolStripButton()
            Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.btnExport = New System.Windows.Forms.ToolStripButton()
            Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.toolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
            Me.comBoxFrom = New System.Windows.Forms.ToolStripComboBox()
            Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
            Me.toolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
            Me.comboxTo = New System.Windows.Forms.ToolStripComboBox()
            Me.btnMultiExport = New System.Windows.Forms.ToolStripButton()
            Me.pdfDocumentViewer1 = New Spire.PdfViewer.Forms.PdfDocumentViewer()
            Me.toolStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'toolStrip1
            '
            Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOpen, Me.toolStripSeparator1, Me.btnExport, Me.toolStripSeparator2, Me.toolStripLabel1, Me.comBoxFrom, Me.toolStripSeparator3, Me.toolStripLabel2, Me.comboxTo, Me.btnMultiExport})
            Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.toolStrip1.Name = "toolStrip1"
            Me.toolStrip1.Size = New System.Drawing.Size(784, 25)
            Me.toolStrip1.TabIndex = 0
            Me.toolStrip1.Text = "toolStrip1"
            '
            'btnOpen
            '
            Me.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Image)
            Me.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnOpen.Name = "btnOpen"
            Me.btnOpen.Size = New System.Drawing.Size(23, 22)
            Me.btnOpen.Text = "Open"
            Me.btnOpen.ToolTipText = "Open PDF Document"
            '
            'toolStripSeparator1
            '
            Me.toolStripSeparator1.Name = "toolStripSeparator1"
            Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
            '
            'btnExport
            '
            Me.btnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
            Me.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnExport.Name = "btnExport"
            Me.btnExport.Size = New System.Drawing.Size(23, 22)
            Me.btnExport.Text = "Export"
            Me.btnExport.ToolTipText = "Export an image from the current page"
            '
            'toolStripSeparator2
            '
            Me.toolStripSeparator2.Name = "toolStripSeparator2"
            Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
            '
            'toolStripLabel1
            '
            Me.toolStripLabel1.Name = "toolStripLabel1"
            Me.toolStripLabel1.Size = New System.Drawing.Size(35, 22)
            Me.toolStripLabel1.Text = "From:"
            '
            'comBoxFrom
            '
            Me.comBoxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comBoxFrom.Name = "comBoxFrom"
            Me.comBoxFrom.Size = New System.Drawing.Size(121, 25)
            Me.comBoxFrom.ToolTipText = "Select started page"
            '
            'toolStripSeparator3
            '
            Me.toolStripSeparator3.Name = "toolStripSeparator3"
            Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 25)
            '
            'toolStripLabel2
            '
            Me.toolStripLabel2.Name = "toolStripLabel2"
            Me.toolStripLabel2.Size = New System.Drawing.Size(23, 22)
            Me.toolStripLabel2.Text = "To:"
            '
            'comboxTo
            '
            Me.comboxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboxTo.Name = "comboxTo"
            Me.comboxTo.Size = New System.Drawing.Size(121, 25)
            Me.comboxTo.ToolTipText = "Select end page"
            '
            'btnMultiExport
            '
            Me.btnMultiExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnMultiExport.Image = CType(resources.GetObject("btnMultiExport.Image"), System.Drawing.Image)
            Me.btnMultiExport.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnMultiExport.Name = "btnMultiExport"
            Me.btnMultiExport.Size = New System.Drawing.Size(23, 22)
            Me.btnMultiExport.Text = "ExportRange"
            Me.btnMultiExport.ToolTipText = "Export multiple images from the page range"
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
            Me.Text = "Spire.PdfViewer Demo - Export images"
            Me.toolStrip1.ResumeLayout(False)
            Me.toolStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private toolStrip1 As ToolStrip
		Private WithEvents btnOpen As ToolStripButton
		Private toolStripSeparator1 As ToolStripSeparator
		Private WithEvents btnExport As ToolStripButton
		Private toolStripSeparator2 As ToolStripSeparator
		Private toolStripLabel1 As ToolStripLabel
		Private comBoxFrom As ToolStripComboBox
		Private toolStripLabel2 As ToolStripLabel
		Private comboxTo As ToolStripComboBox
		Private WithEvents btnMultiExport As ToolStripButton
		Private toolStripSeparator3 As ToolStripSeparator
		Private WithEvents pdfDocumentViewer1 As Spire.PdfViewer.Forms.PdfDocumentViewer
	End Class
End Namespace

