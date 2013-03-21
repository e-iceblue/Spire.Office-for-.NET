Namespace Save
	Partial Public Class Form1
		''' <summary>
		''' 必需的设计器变量。
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' 清理所有正在使用的资源。
		''' </summary>
		''' <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows 窗体设计器生成的代码"

		''' <summary>
		''' 设计器支持所需的方法 - 不要
		''' 使用代码编辑器修改此方法的内容。
		''' </summary>
		Private Sub InitializeComponent()
			Me.toolStrip1 = New ToolStrip()
			Me.bntOpen = New ToolStripButton()
			Me.btnClose = New ToolStripButton()
			Me.toolStripSeparator1 = New ToolStripSeparator()
			Me.btnSaveToPdf = New ToolStripButton()
			Me.btnSaveasToDoc = New ToolStripButton()
			Me.btnSaveasToDocx = New ToolStripButton()
			Me.toolStripSeparator2 = New ToolStripSeparator()
			Me.docDocumentViewer1 = New Spire.DocViewer.Forms.DocDocumentViewer()
			Me.toolStrip1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' toolStrip1
			' 
			Me.toolStrip1.ImageScalingSize = New Size(32, 32)
			Me.toolStrip1.Items.AddRange(New ToolStripItem() { Me.bntOpen, Me.btnClose, Me.toolStripSeparator1, Me.btnSaveToPdf, Me.btnSaveasToDoc, Me.btnSaveasToDocx, Me.toolStripSeparator2})
			Me.toolStrip1.Location = New Point(0, 0)
			Me.toolStrip1.Name = "toolStrip1"
			Me.toolStrip1.Size = New Size(792, 39)
			Me.toolStrip1.Stretch = True
			Me.toolStrip1.TabIndex = 0
			Me.toolStrip1.Text = "toolStrip1"
			' 
			' bntOpen
			' 
			Me.bntOpen.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.bntOpen.Image = My.Resources.Open
			Me.bntOpen.ImageTransparentColor = Color.Magenta
			Me.bntOpen.Name = "bntOpen"
			Me.bntOpen.Size = New Size(36, 36)
			Me.bntOpen.Text = "toolStripButton1"
			Me.bntOpen.ToolTipText = "Open from File"
'			Me.bntOpen.Click += New System.EventHandler(Me.bntOpen_Click)
			' 
			' btnClose
			' 
			Me.btnClose.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnClose.Image = My.Resources.Close
			Me.btnClose.ImageTransparentColor = Color.Magenta
			Me.btnClose.Name = "btnClose"
			Me.btnClose.Size = New Size(36, 36)
			Me.btnClose.Text = "toolStripButton2"
			Me.btnClose.ToolTipText = "Close"
'			Me.btnClose.Click += New System.EventHandler(Me.btnClose_Click)
			' 
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New Size(6, 39)
			' 
			' btnSaveToPdf
			' 
			Me.btnSaveToPdf.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnSaveToPdf.Image = My.Resources.ToPdf
			Me.btnSaveToPdf.ImageTransparentColor = Color.Magenta
			Me.btnSaveToPdf.Name = "btnSaveToPdf"
			Me.btnSaveToPdf.Size = New Size(36, 36)
			Me.btnSaveToPdf.Text = "toolStripButton3"
			Me.btnSaveToPdf.ToolTipText = "Convert Doc document to Pdf document"
'			Me.btnSaveToPdf.Click += New System.EventHandler(Me.btnSaveToPdf_Click)
			' 
			' btnSaveasToDoc
			' 
			Me.btnSaveasToDoc.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnSaveasToDoc.Image = My.Resources.ToDoc
			Me.btnSaveasToDoc.ImageTransparentColor = Color.Magenta
			Me.btnSaveasToDoc.Name = "btnSaveasToDoc"
			Me.btnSaveasToDoc.Size = New Size(36, 36)
			Me.btnSaveasToDoc.Text = "toolStripButton4"
			Me.btnSaveasToDoc.ToolTipText = "Save as Word97-2003 format document"
'			Me.btnSaveasToDoc.Click += New System.EventHandler(Me.btnSaveasToDoc_Click)
			' 
			' btnSaveasToDocx
			' 
			Me.btnSaveasToDocx.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnSaveasToDocx.Image = My.Resources.ToDocx
			Me.btnSaveasToDocx.ImageTransparentColor = Color.Magenta
			Me.btnSaveasToDocx.Name = "btnSaveasToDocx"
			Me.btnSaveasToDocx.Size = New Size(36, 36)
			Me.btnSaveasToDocx.Text = "toolStripButton5"
			Me.btnSaveasToDocx.ToolTipText = "Save as Word2007-2010 format document"
'			Me.btnSaveasToDocx.Click += New System.EventHandler(Me.btnSaveasToDocx_Click)
			' 
			' toolStripSeparator2
			' 
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			Me.toolStripSeparator2.Size = New Size(6, 39)
			' 
			' docDocumentViewer1
			' 
			Me.docDocumentViewer1.BackColor = Color.FromArgb((CInt((CByte(64)))), (CInt((CByte(64)))), (CInt((CByte(64)))))
			Me.docDocumentViewer1.Cursor = Cursors.Arrow
			Me.docDocumentViewer1.Dock = DockStyle.Fill
			Me.docDocumentViewer1.EnableHandTools = False
			Me.docDocumentViewer1.Location = New Point(0, 39)
			Me.docDocumentViewer1.Name = "docDocumentViewer1"
			Me.docDocumentViewer1.Size = New Size(792, 534)
			Me.docDocumentViewer1.TabIndex = 1
			Me.docDocumentViewer1.Text = "docDocumentViewer1"
			Me.docDocumentViewer1.ZoomMode = Spire.DocViewer.Forms.ZoomMode.Default
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 12F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(792, 573)
			Me.Controls.Add(Me.docDocumentViewer1)
			Me.Controls.Add(Me.toolStrip1)
			Me.Name = "Form1"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "Spire.DocViewer for .NET - Demo – Save PDF via DocDocumentViewer Component."
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private toolStrip1 As ToolStrip
		Private WithEvents bntOpen As ToolStripButton
		Private WithEvents btnClose As ToolStripButton
		Private toolStripSeparator1 As ToolStripSeparator
		Private WithEvents btnSaveToPdf As ToolStripButton
		Private WithEvents btnSaveasToDoc As ToolStripButton
		Private WithEvents btnSaveasToDocx As ToolStripButton
		Private toolStripSeparator2 As ToolStripSeparator
		Private docDocumentViewer1 As Spire.DocViewer.Forms.DocDocumentViewer
	End Class
End Namespace

