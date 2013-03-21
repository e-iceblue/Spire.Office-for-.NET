Namespace Open
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
			Me.btnOpen = New ToolStripButton()
			Me.btnOpenStream = New ToolStripButton()
			Me.btnClose = New ToolStripButton()
			Me.docDocumentViewer1 = New Spire.DocViewer.Forms.DocDocumentViewer()
			Me.toolStripSeparator1 = New ToolStripSeparator()
			Me.toolStrip1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' toolStrip1
			' 
			Me.toolStrip1.ImageScalingSize = New Size(32, 32)
			Me.toolStrip1.Items.AddRange(New ToolStripItem() { Me.btnOpen, Me.btnOpenStream, Me.btnClose, Me.toolStripSeparator1})
			Me.toolStrip1.Location = New Point(0, 0)
			Me.toolStrip1.Name = "toolStrip1"
			Me.toolStrip1.Size = New Size(792, 39)
			Me.toolStrip1.TabIndex = 0
			Me.toolStrip1.Text = "toolStrip1"
			' 
			' btnOpen
			' 
			Me.btnOpen.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnOpen.Image = My.Resources.Open
			Me.btnOpen.ImageTransparentColor = Color.Magenta
			Me.btnOpen.Name = "btnOpen"
			Me.btnOpen.Size = New Size(36, 36)
			Me.btnOpen.Text = "toolStripButton1"
			Me.btnOpen.ToolTipText = "Open a document"
'			Me.btnOpen.Click += New System.EventHandler(Me.btnOpen_Click)
			' 
			' btnOpenStream
			' 
			Me.btnOpenStream.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnOpenStream.Image = My.Resources.Stream
			Me.btnOpenStream.ImageTransparentColor = Color.Magenta
			Me.btnOpenStream.Name = "btnOpenStream"
			Me.btnOpenStream.Size = New Size(36, 36)
			Me.btnOpenStream.Text = "toolStripButton1"
			Me.btnOpenStream.ToolTipText = "Open from Stream"
'			Me.btnOpenStream.Click += New System.EventHandler(Me.btnOpenStream_Click)
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
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New Size(6, 39)
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
			Me.Text = "Spire.DocViewer for .NET - Demo – Open PDF via docDocumentfViewer Component."
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private toolStrip1 As ToolStrip
		Private docDocumentViewer1 As Spire.DocViewer.Forms.DocDocumentViewer
		Private WithEvents btnOpen As ToolStripButton
		Private WithEvents btnClose As ToolStripButton
		Private WithEvents btnOpenStream As ToolStripButton
		Private toolStripSeparator1 As ToolStripSeparator
	End Class
End Namespace

