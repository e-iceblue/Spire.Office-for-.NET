Namespace Rotate
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
            Me.toolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
            Me.comBoxAngle = New System.Windows.Forms.ToolStripComboBox()
            Me.btnRotate = New System.Windows.Forms.ToolStripButton()
            Me.pdfDocumentViewer1 = New Spire.PdfViewer.Forms.PdfDocumentViewer()
            Me.toolStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'toolStrip1
            '
            Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOpen, Me.toolStripSeparator1, Me.toolStripLabel1, Me.comBoxAngle, Me.btnRotate})
            Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.toolStrip1.Name = "toolStrip1"
            Me.toolStrip1.Size = New System.Drawing.Size(742, 25)
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
            '
            'toolStripSeparator1
            '
            Me.toolStripSeparator1.Name = "toolStripSeparator1"
            Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
            '
            'toolStripLabel1
            '
            Me.toolStripLabel1.Name = "toolStripLabel1"
            Me.toolStripLabel1.Size = New System.Drawing.Size(83, 22)
            Me.toolStripLabel1.Text = "Rotate Angle:"
            '
            'comBoxAngle
            '
            Me.comBoxAngle.Items.AddRange(New Object() {"0", "90", "180", "270"})
            Me.comBoxAngle.Name = "comBoxAngle"
            Me.comBoxAngle.Size = New System.Drawing.Size(121, 25)
            '
            'btnRotate
            '
            Me.btnRotate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnRotate.Image = CType(resources.GetObject("btnRotate.Image"), System.Drawing.Image)
            Me.btnRotate.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnRotate.Name = "btnRotate"
            Me.btnRotate.Size = New System.Drawing.Size(23, 22)
            Me.btnRotate.Text = "Rotate"
            Me.btnRotate.ToolTipText = "Rotate PDF document"
            '
            'pdfDocumentViewer1
            '
            Me.pdfDocumentViewer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.pdfDocumentViewer1.Cursor = System.Windows.Forms.Cursors.Default
            Me.pdfDocumentViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pdfDocumentViewer1.Location = New System.Drawing.Point(0, 25)
            Me.pdfDocumentViewer1.Name = "pdfDocumentViewer1"
            Me.pdfDocumentViewer1.Size = New System.Drawing.Size(742, 491)
            Me.pdfDocumentViewer1.TabIndex = 1
            Me.pdfDocumentViewer1.Text = "pdfDocumentViewer1"
            Me.pdfDocumentViewer1.Threshold = 60
            Me.pdfDocumentViewer1.ZoomMode = Spire.PdfViewer.Forms.ZoomMode.[Default]
            '
            'Form1
            '
            Me.ClientSize = New System.Drawing.Size(742, 516)
            Me.Controls.Add(Me.pdfDocumentViewer1)
            Me.Controls.Add(Me.toolStrip1)
            Me.Name = "Form1"
            Me.Text = "Spire.PdfViewer(for WinForms) Demo - Rotate"
            Me.toolStrip1.ResumeLayout(False)
            Me.toolStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private toolStrip1 As ToolStrip
		Private WithEvents btnOpen As ToolStripButton
		Private toolStripSeparator1 As ToolStripSeparator
		Private toolStripLabel1 As ToolStripLabel
		Private comBoxAngle As ToolStripComboBox
		Private WithEvents btnRotate As ToolStripButton
		Private pdfDocumentViewer1 As Spire.PdfViewer.Forms.PdfDocumentViewer
	End Class
End Namespace

