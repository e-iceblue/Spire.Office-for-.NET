Namespace PdfDocumentViewer_Paging
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
            Me.binFirst = New System.Windows.Forms.ToolStripButton()
            Me.btnPrevious = New System.Windows.Forms.ToolStripButton()
            Me.btnNext = New System.Windows.Forms.ToolStripButton()
            Me.btnLast = New System.Windows.Forms.ToolStripButton()
            Me.comBoxPages = New System.Windows.Forms.ToolStripComboBox()
            Me.pdfDocumentViewer1 = New Spire.PdfViewer.Forms.PdfDocumentViewer()
            Me.toolStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'toolStrip1
            '
            Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOpen, Me.toolStripSeparator1, Me.binFirst, Me.btnPrevious, Me.btnNext, Me.btnLast, Me.comBoxPages})
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
            Me.btnOpen.Text = "Open PDF "
            Me.btnOpen.ToolTipText = "Open PDF document"
            '
            'toolStripSeparator1
            '
            Me.toolStripSeparator1.Name = "toolStripSeparator1"
            Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
            '
            'binFirst
            '
            Me.binFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.binFirst.Image = CType(resources.GetObject("binFirst.Image"), System.Drawing.Image)
            Me.binFirst.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.binFirst.Name = "binFirst"
            Me.binFirst.Size = New System.Drawing.Size(23, 22)
            Me.binFirst.Text = "First"
            '
            'btnPrevious
            '
            Me.btnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnPrevious.Image = CType(resources.GetObject("btnPrevious.Image"), System.Drawing.Image)
            Me.btnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnPrevious.Name = "btnPrevious"
            Me.btnPrevious.Size = New System.Drawing.Size(23, 22)
            Me.btnPrevious.Text = "Previous"
            '
            'btnNext
            '
            Me.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
            Me.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnNext.Name = "btnNext"
            Me.btnNext.Size = New System.Drawing.Size(23, 22)
            Me.btnNext.Text = "Next"
            '
            'btnLast
            '
            Me.btnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnLast.Image = CType(resources.GetObject("btnLast.Image"), System.Drawing.Image)
            Me.btnLast.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnLast.Name = "btnLast"
            Me.btnLast.Size = New System.Drawing.Size(23, 22)
            Me.btnLast.Text = "Last"
            '
            'comBoxPages
            '
            Me.comBoxPages.Name = "comBoxPages"
            Me.comBoxPages.Size = New System.Drawing.Size(121, 25)
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
            Me.Text = "Spire.PdfViewer Demo - Paging"
            Me.toolStrip1.ResumeLayout(False)
            Me.toolStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private toolStrip1 As ToolStrip
		Private WithEvents btnOpen As ToolStripButton
		Private toolStripSeparator1 As ToolStripSeparator
		Private WithEvents binFirst As ToolStripButton
		Private WithEvents btnPrevious As ToolStripButton
		Private WithEvents btnNext As ToolStripButton
		Private WithEvents btnLast As ToolStripButton
		Private WithEvents comBoxPages As ToolStripComboBox
		Private WithEvents pdfDocumentViewer1 As Spire.PdfViewer.Forms.PdfDocumentViewer
	End Class
End Namespace

