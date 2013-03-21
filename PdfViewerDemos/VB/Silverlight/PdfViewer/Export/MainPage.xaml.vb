Imports System.Windows
Imports System.Windows.Controls
Imports System.IO
Imports System.Windows.Media.Imaging
Imports System.Windows.Resources

Namespace Export
	Partial Public Class MainPage
		Inherits UserControl
		Public Shared m_CurrentPageNum As Integer = 0
		Public Sub New()
			InitializeComponent()
			AddHandler pdfViewer1.CurrentPageChange, AddressOf pdfViewer1_CurrentPageChange
			AddHandler pdfViewer1.DocumentLoaded, AddressOf pdfViewer1_DocumentLoaded
			Me.txtFrom.IsEnabled = Me.ckbFrom.IsChecked.Value
			Me.txtTo.IsEnabled = Me.ckbTo.IsChecked.Value

			Me.scrollViewer1.Content = Me.canvasImg
		End Sub

		Private Sub pdfViewer1_DocumentLoaded(ByVal sender As Object, ByVal args As EventArgs)
			Me.txtTo.Text = Me.pdfViewer1.PageCount.ToString()
		End Sub

		Private Sub pdfViewer1_CurrentPageChange(ByVal sender As Object, ByVal args As EventArgs)
			txtFrom.Text = Me.pdfViewer1.CurrentPageNumber.ToString()
		End Sub

		Private Sub LayoutRoot_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Me.txtTo.Text = Me.pdfViewer1.PageCount.ToString()
		End Sub

		Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim dialog As New OpenFileDialog()

			Dim result? As Boolean = dialog.ShowDialog()
			If result.HasValue AndAlso result.Value Then
				Using stream As Stream = dialog.File.OpenRead()
					Me.pdfViewer1.LoadFromStream(stream)
				End Using
				Me.txtTo.Text = Me.pdfViewer1.PageCount.ToString()
			End If

			Me.tabItem3.IsSelected = True
		End Sub

		Private Sub ckbTo_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			txtTo.IsEnabled = ckbTo.IsChecked.Value
		End Sub

		Private Sub btnSaveAsImg_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Me.tabImg.IsSelected = True
			Try
				If ckbFrom.IsChecked.Value AndAlso ckbTo.IsChecked.Value Then
					Dim startIndex As Integer = 0
					Integer.TryParse(txtFrom.Text, startIndex)
					m_CurrentPageNum = startIndex
					Dim endIndex As Integer = 0
					Integer.TryParse(txtTo.Text, endIndex)

					'exports the specified pages as images
					Dim bitmapSource() As BitmapSource = Me.pdfViewer1.SaveAsImage(startIndex, endIndex)

					Dim topLocation As Double = 0
					Dim leftLocation As Double = 0
					For Each imgSource As BitmapSource In bitmapSource
						Dim image As New Image()
						image.Source = imgSource
						leftLocation = (Me.canvasImg.Width - imgSource.PixelWidth) / 2
						image.Margin = New Thickness(leftLocation, topLocation, 0, 0)
						Me.canvasImg.Children.Add(image)
						topLocation += imgSource.PixelHeight + 10
						Me.canvasImg.Height += imgSource.PixelHeight
					Next imgSource
				ElseIf ckbFrom.IsChecked.Value AndAlso (Not ckbTo.IsChecked.Value) Then
					Dim currentPageIndex As Integer = 0
					Integer.TryParse(txtFrom.Text, currentPageIndex)
					m_CurrentPageNum = currentPageIndex
					Dim bitmapSource As BitmapSource = Me.pdfViewer1.SaveAsImage(currentPageIndex)
					Dim topLocation As Double = 0
					Dim leftLocation As Double = 0
					Dim image As New Image()
					image.Source = bitmapSource
					leftLocation = (Me.canvasImg.Width - bitmapSource.PixelWidth) / 2
					image.Margin = New Thickness(leftLocation, topLocation, 0, 0)
					Me.canvasImg.Children.Add(image)
					topLocation += bitmapSource.PixelHeight + 10
					Me.canvasImg.Height += bitmapSource.PixelHeight
				End If

			Catch ex As Exception
				MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK)
			End Try
		End Sub

		Private Sub UserControl_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim resource As StreamResourceInfo=Application.GetResourceStream(New Uri("Export;component/PartList.pdf",UriKind.Relative))
			Me.pdfViewer1.LoadFromStream(resource.Stream)
		End Sub
	End Class
End Namespace
