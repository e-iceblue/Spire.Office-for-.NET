Imports System.ComponentModel
Imports System.Text

Namespace Export
	Partial Public Class ImageViewer
		Inherits Form
		Public Sub New()
			InitializeComponent()

			Dim bitMapCount As Integer = Form1.bitMap.Count
			Dim pageNum As Integer = Form1.m_CurrentPageNum

			If bitMapCount > 0 Then
				For Each dic As KeyValuePair(Of String, Image) In Form1.bitMap
					Dim filename As String = dic.Key
					Dim bmap As Image = dic.Value
					Dim iv As New ImageViewerControl()
					iv.Image = bmap
					iv.FileName = filename
					iv.Text = pageNum.ToString()
					iv.Cursor = Cursors.Hand
					AddHandler iv.MouseClick, AddressOf iv_MouseClick
					Me.flowLayoutPanel1.Controls.Add(iv)
					iv.Left = CInt(Me.flowLayoutPanel1.Width - iv.Width) / 2
					pageNum += 1
				Next dic
			End If
		End Sub

		Private Sub iv_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
			Dim filename As String = (CType(sender, ImageViewerControl)).FileName
			Dim process As New Process()
			process.StartInfo = New ProcessStartInfo(filename)
			process.Start()
		End Sub
	End Class
End Namespace
