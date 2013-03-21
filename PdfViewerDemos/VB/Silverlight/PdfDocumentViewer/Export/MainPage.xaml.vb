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
			AddHandler pdfDocumentViewer1.PageNumberChanged, AddressOf pdfDocumentViewer1_PageNumberChanged
			Me.txtFrom.IsEnabled = Me.ckbFrom.IsChecked.Value
			Me.txtTo.IsEnabled = Me.ckbTo.IsChecked.Value
			Me.scrollViewer1.Content = Me.canvasImg
		End Sub

		Private Sub pdfDocumentViewer1_PageNumberChanged(ByVal sender As Object, ByVal args As EventArgs)
			txtFrom.Text = Me.pdfDocumentViewer1.CurrentPageNumber.ToString()
		End Sub

		Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim dialog As New OpenFileDialog()

			Dim result? As Boolean = dialog.ShowDialog()
			If result.HasValue AndAlso result.Value Then
				Using stream As Stream = dialog.File.OpenRead()
					Me.pdfDocumentViewer1.LoadFromStream(stream)
				End Using
				Me.txtTo.Text = Me.pdfDocumentViewer1.PageCount.ToString()
			End If

			Me.tabItem3.IsSelected = True
		End Sub

		Private Sub LayoutRoot_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Me.txtTo.Text = Me.pdfDocumentViewer1.PageCount.ToString()
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
					Dim bitmapSource() As BitmapSource = Me.pdfDocumentViewer1.SaveAsImage(startIndex, endIndex)

					Dim topLocation As Double=0
					Dim leftLocation As Double = 0
					For Each imgSource As BitmapSource In bitmapSource
						Dim image As New Image()
						image.Source = imgSource
						leftLocation = (Me.canvasImg.Width - imgSource.PixelWidth) / 2
						image.Margin = New Thickness(leftLocation, topLocation, 0, 0)
						Me.canvasImg.Children.Add(image)
						topLocation += imgSource.PixelHeight+10
						Me.canvasImg.Height += imgSource.PixelHeight
					Next imgSource
				End If

			Catch ex As Exception
				MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK)
			End Try
		End Sub

		Private Sub UserControl_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim resource As StreamResourceInfo=Application.GetResourceStream(New Uri("Export;component/Spire.Office.pdf", UriKind.Relative))
			Me.pdfDocumentViewer1.LoadFromStream(resource.Stream)
		End Sub
	End Class
End Namespace
