Imports System.Text
Imports System.Windows.Media
Imports System.Windows.Controls


Namespace PdfViewer_Export
	''' <summary>
	''' Interaction logic for ImageViewer.xaml
	''' </summary>
	Partial Public Class ImageViewer
		Inherits Window
		Public Sub New()
			InitializeComponent()
			Dim bitMapCount As Integer = MainWindow.bitMap.Count
			Dim pageNum As Integer =MainWindow.m_CurrentPageNum
			If bitMapCount > 0 Then
				For Each dic As KeyValuePair(Of String, BitmapSource) In MainWindow.bitMap
					Dim filename As String = dic.Key
					Dim bmap As BitmapSource = dic.Value
					Dim width As Integer = bmap.PixelWidth
					Dim height As Integer = bmap.PixelHeight
					Dim stackpanel As New StackPanel()
					stackpanel.Width = width * 0.2
					stackpanel.Height = height * 0.2 + 30

					Dim image As New Image()
					image.VerticalAlignment = VerticalAlignment.Top
					image.Source = bmap
					Dim label As New Label()
					label.VerticalAlignment = VerticalAlignment.Bottom
					label.HorizontalAlignment = HorizontalAlignment.Center
					label.Foreground = Brushes.Blue
					label.Content = pageNum.ToString()
					label.FontSize = 15
					stackpanel.Children.Add(image)
					stackpanel.Children.Add(label)
					stackpanel.ToolTip = filename
					AddHandler stackpanel.MouseDown, AddressOf stackpanel_MouseDown
					stackpanel.Cursor = Cursors.Hand
					Me.StackPanel1.Children.Add(stackpanel)
					pageNum += 1
				Next dic
			End If
		End Sub

		Private Sub stackpanel_MouseDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
			Dim filename As String = CStr((CType(sender, StackPanel)).ToolTip)
			Dim process As New Process()
			process.StartInfo = New ProcessStartInfo(filename)
			process.Start()
		End Sub
	End Class
End Namespace
