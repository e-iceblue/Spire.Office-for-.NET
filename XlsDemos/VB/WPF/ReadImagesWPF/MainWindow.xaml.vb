Imports System.Text
Imports Spire.Xls
Imports System.IO
Namespace ReadImagesWPF
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnRun_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim workbook As New Workbook()
			workbook.LoadFromFile("..\..\..\..\..\Data\ImageSample.xls")
			Dim sheet As Worksheet = workbook.Worksheets(0)
			'get picture
			Dim pic As ExcelPicture = sheet.Pictures(0)

			'save memoryStream
            Dim img As New System.Windows.Controls.Image()
			Dim mem As New System.IO.MemoryStream()
			pic.Picture.Save(mem, System.Drawing.Imaging.ImageFormat.Png)
			img.Source = GetBitmapSourceFromStream(mem)
			'create window
			Dim imgWindow As New Window()
			imgWindow.Title = "ImageSample"
            imgWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen
			imgWindow.Width = pic.Picture.Width
			imgWindow.Height = pic.Picture.Height
			imgWindow.ResizeMode = ResizeMode.NoResize
			'set margin
			Dim thick As New Thickness(0,0,0,0)
			img.Margin = thick
			imgWindow.Content = img
			imgWindow.ShowDialog()
		End Sub

		Private Sub btnClose_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Me.Close()
		End Sub
		Private Function GetBitmapSourceFromStream(ByVal imgStream As Stream) As BitmapImage
			Dim bitMapImg As New BitmapImage()
			bitMapImg.BeginInit()
			bitMapImg.StreamSource = imgStream
			bitMapImg.EndInit()
			bitMapImg.Freeze()
			Return bitMapImg
		End Function

		Private Sub ExcelDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch e As Exception
				MessageBox.Show(e.Message, "information", MessageBoxButton.OK)
			End Try
		End Sub
	End Class
End Namespace
