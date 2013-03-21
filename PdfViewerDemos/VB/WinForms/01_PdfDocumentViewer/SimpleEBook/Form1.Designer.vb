Namespace SimpleEBook_VS2010
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
            Me.tableLayoutPanel1 = New TableLayoutPanel()
            Me.toolStrip1 = New ToolStrip()
            Me.btnOpen = New ToolStripButton()
            Me.tableLayoutPanel2 = New TableLayoutPanel()
            Me.linkLabelFirst = New LinkLabel()
            Me.linkLabelPrevious = New LinkLabel()
            Me.txtPage = New TextBox()
            Me.linkLableNext = New LinkLabel()
            Me.linkLabelLast = New LinkLabel()
            Me.pdfDocumentViewer1 = New Spire.PdfViewer.Forms.PdfDocumentViewer()
            Me.tableLayoutPanel1.SuspendLayout()
            Me.toolStrip1.SuspendLayout()
            Me.tableLayoutPanel2.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' tableLayoutPanel1
            ' 
            Me.tableLayoutPanel1.ColumnCount = 1
            Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
            Me.tableLayoutPanel1.Controls.Add(Me.toolStrip1, 0, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel2, 0, 2)
            Me.tableLayoutPanel1.Controls.Add(Me.pdfDocumentViewer1, 0, 1)
            Me.tableLayoutPanel1.Dock = DockStyle.Fill
            Me.tableLayoutPanel1.Location = New Point(0, 0)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 3
            Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 40.0F))
            Me.tableLayoutPanel1.Size = New Size(742, 516)
            Me.tableLayoutPanel1.TabIndex = 0
            ' 
            ' toolStrip1
            ' 
            Me.toolStrip1.Dock = DockStyle.Fill
            Me.toolStrip1.Items.AddRange(New ToolStripItem() {Me.btnOpen})
            Me.toolStrip1.Location = New Point(0, 0)
            Me.toolStrip1.Name = "toolStrip1"
            Me.toolStrip1.Size = New Size(742, 30)
            Me.toolStrip1.TabIndex = 0
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
            '			Me.btnOpen.Click += New System.EventHandler(Me.btnOpen_Click)
            ' 
            ' tableLayoutPanel2
            ' 
            Me.tableLayoutPanel2.ColumnCount = 5
            Me.tableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.4918F))
            Me.tableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.4918F))
            Me.tableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 18.03279F))
            Me.tableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.4918F))
            Me.tableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.4918F))
            Me.tableLayoutPanel2.Controls.Add(Me.linkLabelFirst, 0, 0)
            Me.tableLayoutPanel2.Controls.Add(Me.linkLabelPrevious, 1, 0)
            Me.tableLayoutPanel2.Controls.Add(Me.txtPage, 2, 0)
            Me.tableLayoutPanel2.Controls.Add(Me.linkLableNext, 3, 0)
            Me.tableLayoutPanel2.Controls.Add(Me.linkLabelLast, 4, 0)
            Me.tableLayoutPanel2.Dock = DockStyle.Fill
            Me.tableLayoutPanel2.Location = New Point(3, 479)
            Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
            Me.tableLayoutPanel2.RowCount = 1
            Me.tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
            Me.tableLayoutPanel2.Size = New Size(736, 34)
            Me.tableLayoutPanel2.TabIndex = 2
            ' 
            ' linkLabelFirst
            ' 
            Me.linkLabelFirst.AutoSize = True
            Me.linkLabelFirst.Font = New Font("Microsoft YaHei", 10.5F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
            Me.linkLabelFirst.Location = New Point(3, 0)
            Me.linkLabelFirst.Name = "linkLabelFirst"
            Me.linkLabelFirst.Size = New Size(40, 19)
            Me.linkLabelFirst.TabIndex = 0
            Me.linkLabelFirst.TabStop = True
            Me.linkLabelFirst.Text = "First"
            '			Me.linkLabelFirst.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.linkLabelFirst_LinkClicked)
            ' 
            ' linkLabelPrevious
            ' 
            Me.linkLabelPrevious.AutoSize = True
            Me.linkLabelPrevious.Font = New Font("Microsoft YaHei", 10.5F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
            Me.linkLabelPrevious.Location = New Point(153, 0)
            Me.linkLabelPrevious.Name = "linkLabelPrevious"
            Me.linkLabelPrevious.Size = New Size(69, 19)
            Me.linkLabelPrevious.TabIndex = 1
            Me.linkLabelPrevious.TabStop = True
            Me.linkLabelPrevious.Text = "Previous"
            '			Me.linkLabelPrevious.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.linkLabelPrevious_LinkClicked)
            ' 
            ' txtPage
            ' 
            Me.txtPage.Location = New Point(303, 3)
            Me.txtPage.Name = "txtPage"
            Me.txtPage.Size = New Size(100, 21)
            Me.txtPage.TabIndex = 2
            '			Me.txtPage.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.txtPage_KeyDown)
            ' 
            ' linkLableNext
            ' 
            Me.linkLableNext.AutoSize = True
            Me.linkLableNext.Font = New Font("Microsoft YaHei", 10.5F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
            Me.linkLableNext.Location = New Point(435, 0)
            Me.linkLableNext.Name = "linkLableNext"
            Me.linkLableNext.Size = New Size(43, 19)
            Me.linkLableNext.TabIndex = 3
            Me.linkLableNext.TabStop = True
            Me.linkLableNext.Text = "Next"
            '			Me.linkLableNext.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.linkLableNext_LinkClicked)
            ' 
            ' linkLabelLast
            ' 
            Me.linkLabelLast.AutoSize = True
            Me.linkLabelLast.Font = New Font("Microsoft YaHei", 10.5F, FontStyle.Bold, GraphicsUnit.Point, (CByte(134)))
            Me.linkLabelLast.Location = New Point(585, 0)
            Me.linkLabelLast.Name = "linkLabelLast"
            Me.linkLabelLast.Size = New Size(38, 19)
            Me.linkLabelLast.TabIndex = 4
            Me.linkLabelLast.TabStop = True
            Me.linkLabelLast.Text = "Last"
            '			Me.linkLabelLast.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.linkLabelLast_LinkClicked)
            ' 
            ' pdfDocumentViewer1
            ' 
            Me.pdfDocumentViewer1.BackColor = Color.FromArgb((CInt((CByte(204)))), (CInt((CByte(204)))), (CInt((CByte(204)))))
            Me.pdfDocumentViewer1.Cursor = Cursors.Default
            Me.pdfDocumentViewer1.Dock = DockStyle.Fill
            Me.pdfDocumentViewer1.Location = New Point(3, 33)
            Me.pdfDocumentViewer1.Name = "pdfDocumentViewer1"
            Me.pdfDocumentViewer1.Size = New Size(736, 440)
            Me.pdfDocumentViewer1.TabIndex = 1
            Me.pdfDocumentViewer1.Text = "pdfDocumentViewer1"
            Me.pdfDocumentViewer1.Threshold = 60
            Me.pdfDocumentViewer1.ZoomMode = Spire.PdfViewer.Forms.ZoomMode.Default
            '			Me.pdfDocumentViewer1.PageNumberChanged += New Spire.PdfViewer.PageNumberChangedEventHandler(Me.pdfDocumentViewer1_PageNumberChanged)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New SizeF(6.0F, 12.0F)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.ClientSize = New Size(742, 516)
            Me.Controls.Add(Me.tableLayoutPanel1)
            Me.Name = "Form1"
            Me.Text = "Spire.PdfViewer(for WinForms) Demo - Simple E-Book"
            '			Me.Load += New System.EventHandler(Me.Form1_Load)
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.tableLayoutPanel1.PerformLayout()
            Me.toolStrip1.ResumeLayout(False)
            Me.toolStrip1.PerformLayout()
            Me.tableLayoutPanel2.ResumeLayout(False)
            Me.tableLayoutPanel2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private tableLayoutPanel1 As TableLayoutPanel
        Private toolStrip1 As ToolStrip
        Private WithEvents pdfDocumentViewer1 As Spire.PdfViewer.Forms.PdfDocumentViewer
        Private WithEvents btnOpen As ToolStripButton
        Private tableLayoutPanel2 As TableLayoutPanel
        Private WithEvents linkLabelFirst As LinkLabel
        Private WithEvents linkLabelPrevious As LinkLabel
        Private WithEvents txtPage As TextBox
        Private WithEvents linkLableNext As LinkLabel
        Private WithEvents linkLabelLast As LinkLabel
    End Class
End Namespace

