Namespace Export
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
			Me.splitContainer1 = New SplitContainer()
			Me.ckbHandtool = New CheckBox()
			Me.groupBox1 = New GroupBox()
			Me.ckbFrom = New CheckBox()
			Me.btnSaveImage = New Button()
			Me.textBox2 = New TextBox()
			Me.textBox1 = New TextBox()
			Me.ckbTo = New CheckBox()
			Me.btnOpen = New Button()
			Me.docDocumentViewer1 = New Spire.DocViewer.Forms.DocDocumentViewer()
			Me.splitContainer1.Panel1.SuspendLayout()
			Me.splitContainer1.Panel2.SuspendLayout()
			Me.splitContainer1.SuspendLayout()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' splitContainer1
			' 
			Me.splitContainer1.Dock = DockStyle.Fill
			Me.splitContainer1.Location = New Point(0, 0)
			Me.splitContainer1.Name = "splitContainer1"
			Me.splitContainer1.Orientation = Orientation.Horizontal
			' 
			' splitContainer1.Panel1
			' 
			Me.splitContainer1.Panel1.Controls.Add(Me.ckbHandtool)
			Me.splitContainer1.Panel1.Controls.Add(Me.groupBox1)
			Me.splitContainer1.Panel1.Controls.Add(Me.btnOpen)
			Me.splitContainer1.Panel1MinSize = 30
			' 
			' splitContainer1.Panel2
			' 
			Me.splitContainer1.Panel2.Controls.Add(Me.docDocumentViewer1)
			Me.splitContainer1.Size = New Size(792, 573)
			Me.splitContainer1.SplitterDistance = 59
			Me.splitContainer1.TabIndex = 1
			' 
			' ckbHandtool
			' 
			Me.ckbHandtool.AutoSize = True
			Me.ckbHandtool.Location = New Point(446, 19)
			Me.ckbHandtool.Name = "ckbHandtool"
			Me.ckbHandtool.Size = New Size(78, 16)
			Me.ckbHandtool.TabIndex = 2
			Me.ckbHandtool.Text = "Hand Tool"
			Me.ckbHandtool.UseVisualStyleBackColor = True
'			Me.ckbHandtool.CheckedChanged += New System.EventHandler(Me.ckbHandtool_CheckedChanged)
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.ckbFrom)
			Me.groupBox1.Controls.Add(Me.btnSaveImage)
			Me.groupBox1.Controls.Add(Me.textBox2)
			Me.groupBox1.Controls.Add(Me.textBox1)
			Me.groupBox1.Controls.Add(Me.ckbTo)
			Me.groupBox1.Location = New Point(117, 0)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New Size(320, 55)
			Me.groupBox1.TabIndex = 1
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Export Image"
			' 
			' ckbFrom
			' 
			Me.ckbFrom.AutoSize = True
			Me.ckbFrom.Checked = True
			Me.ckbFrom.CheckState = CheckState.Checked
			Me.ckbFrom.Location = New Point(6, 24)
			Me.ckbFrom.Name = "ckbFrom"
			Me.ckbFrom.Size = New Size(54, 16)
			Me.ckbFrom.TabIndex = 6
			Me.ckbFrom.Text = "From:"
			Me.ckbFrom.UseVisualStyleBackColor = True
			' 
			' btnSaveImage
			' 
			Me.btnSaveImage.Location = New Point(212, 21)
			Me.btnSaveImage.Name = "btnSaveImage"
			Me.btnSaveImage.Size = New Size(101, 23)
			Me.btnSaveImage.TabIndex = 5
			Me.btnSaveImage.Text = "Save to Image"
			Me.btnSaveImage.UseVisualStyleBackColor = True
'			Me.btnSaveImage.Click += New System.EventHandler(Me.btnSaveImage_Click)
			' 
			' textBox2
			' 
			Me.textBox2.Location = New Point(160, 22)
			Me.textBox2.Name = "textBox2"
			Me.textBox2.Size = New Size(46, 21)
			Me.textBox2.TabIndex = 4
			' 
			' textBox1
			' 
			Me.textBox1.Location = New Point(64, 22)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New Size(46, 21)
			Me.textBox1.TabIndex = 3
			' 
			' ckbTo
			' 
			Me.ckbTo.AutoSize = True
			Me.ckbTo.Location = New Point(114, 24)
			Me.ckbTo.Name = "ckbTo"
			Me.ckbTo.Size = New Size(42, 16)
			Me.ckbTo.TabIndex = 1
			Me.ckbTo.Text = "To:"
			Me.ckbTo.UseVisualStyleBackColor = True
'			Me.ckbTo.CheckedChanged += New System.EventHandler(Me.ckbTo_CheckedChanged)
			' 
			' btnOpen
			' 
			Me.btnOpen.Location = New Point(12, 16)
			Me.btnOpen.Name = "btnOpen"
			Me.btnOpen.Size = New Size(99, 23)
			Me.btnOpen.TabIndex = 0
			Me.btnOpen.Text = "Open Document"
			Me.btnOpen.UseVisualStyleBackColor = True
'			Me.btnOpen.Click += New System.EventHandler(Me.btnOpen_Click)
			' 
			' docDocumentViewer1
			' 
			Me.docDocumentViewer1.BackColor = Color.FromArgb((CInt((CByte(64)))), (CInt((CByte(64)))), (CInt((CByte(64)))))
			Me.docDocumentViewer1.Cursor = Cursors.Arrow
			Me.docDocumentViewer1.Dock = DockStyle.Fill
			Me.docDocumentViewer1.EnableHandTools = False
			Me.docDocumentViewer1.Location = New Point(0, 0)
			Me.docDocumentViewer1.Name = "docDocumentViewer1"
			Me.docDocumentViewer1.Size = New Size(792, 510)
			Me.docDocumentViewer1.TabIndex = 1
			Me.docDocumentViewer1.Text = "docDocumentViewer1"
			Me.docDocumentViewer1.ZoomMode = Spire.DocViewer.Forms.ZoomMode.Default
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 12F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(792, 573)
			Me.Controls.Add(Me.splitContainer1)
			Me.Name = "Form1"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "Spire.DocViewer.Forms - Demo - Export Image via DocDocumentViewer Component."
			Me.splitContainer1.Panel1.ResumeLayout(False)
			Me.splitContainer1.Panel1.PerformLayout()
			Me.splitContainer1.Panel2.ResumeLayout(False)
			Me.splitContainer1.ResumeLayout(False)
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private splitContainer1 As SplitContainer
		Private docDocumentViewer1 As Spire.DocViewer.Forms.DocDocumentViewer
		Private WithEvents ckbHandtool As CheckBox
		Private groupBox1 As GroupBox
		Private WithEvents btnSaveImage As Button
		Private textBox2 As TextBox
		Private textBox1 As TextBox
		Private WithEvents ckbTo As CheckBox
		Private WithEvents btnOpen As Button
		Private ckbFrom As CheckBox

	End Class
End Namespace

