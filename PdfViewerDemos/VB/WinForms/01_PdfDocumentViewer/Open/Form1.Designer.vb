Namespace PdfViewer_Open
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
            Me.BtnOpen = New System.Windows.Forms.ToolStripButton()
            Me.BtnOpenStream = New System.Windows.Forms.ToolStripButton()
            Me.BtnOpenPass = New System.Windows.Forms.ToolStripButton()
            Me.comBoxPages = New System.Windows.Forms.ToolStripComboBox()
            Me.btnClose = New System.Windows.Forms.ToolStripButton()
            Me.pdfDocumentViewer1 = New Spire.PdfViewer.Forms.PdfDocumentViewer()
            Me.toolStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'toolStrip1
            '
            Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnOpen, Me.BtnOpenStream, Me.BtnOpenPass, Me.comBoxPages, Me.btnClose})
            Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.toolStrip1.Name = "toolStrip1"
            Me.toolStrip1.Size = New System.Drawing.Size(784, 25)
            Me.toolStrip1.TabIndex = 0
            Me.toolStrip1.Text = "toolStrip1"
            '
            'BtnOpen
            '
            Me.BtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.BtnOpen.Image = CType(resources.GetObject("BtnOpen.Image"), System.Drawing.Image)
            Me.BtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.BtnOpen.Name = "BtnOpen"
            Me.BtnOpen.Size = New System.Drawing.Size(23, 22)
            Me.BtnOpen.Text = "Open"
            Me.BtnOpen.ToolTipText = "Open PDF document "
            '
            'BtnOpenStream
            '
            Me.BtnOpenStream.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.BtnOpenStream.Image = CType(resources.GetObject("BtnOpenStream.Image"), System.Drawing.Image)
            Me.BtnOpenStream.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.BtnOpenStream.Name = "BtnOpenStream"
            Me.BtnOpenStream.Size = New System.Drawing.Size(23, 22)
            Me.BtnOpenStream.Text = "Open Stream"
            Me.BtnOpenStream.ToolTipText = "Open PDF document data streaam"
            '
            'BtnOpenPass
            '
            Me.BtnOpenPass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.BtnOpenPass.Image = CType(resources.GetObject("BtnOpenPass.Image"), System.Drawing.Image)
            Me.BtnOpenPass.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.BtnOpenPass.Name = "BtnOpenPass"
            Me.BtnOpenPass.Size = New System.Drawing.Size(23, 22)
            Me.BtnOpenPass.Text = "Open Encryption"
            Me.BtnOpenPass.ToolTipText = "Open encrypted PDF document"
            '
            'comBoxPages
            '
            Me.comBoxPages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comBoxPages.Name = "comBoxPages"
            Me.comBoxPages.Size = New System.Drawing.Size(121, 25)
            '
            'btnClose
            '
            Me.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(23, 22)
            Me.btnClose.Text = "Close"
            Me.btnClose.ToolTipText = "Close PDF document"
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
            Me.Text = "Spire.PdfViewer Demo - Open"
            Me.toolStrip1.ResumeLayout(False)
            Me.toolStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private toolStrip1 As ToolStrip
        Private WithEvents BtnOpen As ToolStripButton
        Private WithEvents BtnOpenStream As ToolStripButton
        Private WithEvents BtnOpenPass As ToolStripButton
        Private WithEvents pdfDocumentViewer1 As Spire.PdfViewer.Forms.PdfDocumentViewer
        Private WithEvents btnClose As ToolStripButton
        Friend WithEvents comBoxPages As System.Windows.Forms.ToolStripComboBox
    End Class
End Namespace

