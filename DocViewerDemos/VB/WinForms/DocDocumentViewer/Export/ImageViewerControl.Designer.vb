Namespace Export
	Partial Public Class ImageViewerControl
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

		#Region "组件设计器生成的代码"

		''' <summary> 
		''' 设计器支持所需的方法 - 不要
		''' 使用代码编辑器修改此方法的内容。
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.pictureBox1 = New PictureBox()
			Me.toolTipMsg = New ToolTip(Me.components)
			Me.label1 = New Label()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Location = New Point(0, 0)
			Me.pictureBox1.Margin = New Padding(0)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New Size(160, 180)
			Me.pictureBox1.TabIndex = 0
			Me.pictureBox1.TabStop = False
			' 
			' label1
			' 
			Me.label1.Font = New Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.label1.ForeColor = Color.Navy
			Me.label1.Location = New Point(0, 180)
			Me.label1.Margin = New Padding(0)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(160, 30)
			Me.label1.TabIndex = 1
			Me.label1.TextAlign = ContentAlignment.MiddleCenter
			' 
			' ImageViewerControl
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 12F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.pictureBox1)
			Me.Margin = New Padding(0)
			Me.Name = "ImageViewerControl"
			Me.Size = New Size(160, 210)
'			Me.BackColorChanged += New System.EventHandler(Me.ImageViewerControl_BackColorChanged)
'			Me.SizeChanged += New System.EventHandler(Me.ImageViewerControl_SizeChanged)
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pictureBox1 As PictureBox
		Private toolTipMsg As ToolTip
		Private label1 As Label
	End Class
End Namespace
