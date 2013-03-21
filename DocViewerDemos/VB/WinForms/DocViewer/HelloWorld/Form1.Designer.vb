Namespace HelloWorld
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
			Me.docViewer1 = New Spire.DocViewer.Forms.DocViewer()
			Me.SuspendLayout()
			' 
			' docViewer1
			' 
			Me.docViewer1.Dock = DockStyle.Fill
			Me.docViewer1.IsToolBarVisible = True
			Me.docViewer1.Location = New Point(0, 0)
			Me.docViewer1.Name = "docViewer1"
			Me.docViewer1.Size = New Size(792, 573)
			Me.docViewer1.TabIndex = 0
			Me.docViewer1.Text = "docViewer1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 12F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(792, 573)
			Me.Controls.Add(Me.docViewer1)
			Me.Name = "Form1"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "Spire.DocViewer for .NET – Demo – How to Use DocViewer Component."
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private docViewer1 As Spire.DocViewer.Forms.DocViewer
	End Class
End Namespace

