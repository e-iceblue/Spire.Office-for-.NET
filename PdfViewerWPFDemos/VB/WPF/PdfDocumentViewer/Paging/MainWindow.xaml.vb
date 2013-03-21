Imports System.Text

Imports Microsoft.Win32
Imports Spire.PdfViewer.Wpf
Imports Spire.PdfViewer


Namespace Paging
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Private m_canFirstPage As Boolean = False
		Private m_canNextPage As Boolean = False
		Private m_canPreviousPage As Boolean = False
		Private m_canLastPage As Boolean = False


		Public Sub New()
			InitializeComponent()
			AddHandler pdfDocumentViewer1.PageNumberChanged, AddressOf pdfDocumentViewer1_PageNumberChanged
			Me.btnFirstPage.IsEnabled = Me.m_canFirstPage
			Me.btnLastPage.IsEnabled = Me.m_canLastPage
			Me.btnNextPage.IsEnabled = Me.m_canNextPage
			Me.btnPreviousPage.IsEnabled = Me.m_canPreviousPage
		End Sub

		Private Sub pdfDocumentViewer1_PageNumberChanged(ByVal sender As Object, ByVal args As EventArgs)
			Dim currentNum As Integer = Me.pdfDocumentViewer1.CurrentPageNumber
			Dim result As Integer = 0
			Integer.TryParse(txtCurrentPageIndex.Text, result)
			If currentNum <> result AndAlso result > 0 Then
				SetbuttonState()
			End If
			Me.txtCurrentPageIndex.Text = currentNum.ToString()
		End Sub

		Private Sub buttonStatesChanged()
			Dim currentPageIndex As Integer = Me.pdfDocumentViewer1.CurrentPageNumber
			Dim pageCount As Integer = Me.pdfDocumentViewer1.PageCount
			If pageCount > 0 Then
				If pageCount > 1 Then
					If currentPageIndex = 1 Then
						m_canFirstPage = False
						m_canPreviousPage = False
						m_canNextPage = True
						m_canLastPage = True
						Return
					End If

					If currentPageIndex = pageCount Then
						m_canFirstPage = True
						m_canPreviousPage = True
						m_canNextPage = False
						m_canLastPage = False
						Return
					End If

					m_canFirstPage = True
					m_canPreviousPage = True
					m_canNextPage = True
					m_canLastPage = True
					Return
				End If
			End If

			m_canFirstPage = False
			m_canNextPage = False
			m_canPreviousPage = False
			m_canLastPage = False
		End Sub

		Private Sub SetbuttonState()
			buttonStatesChanged()
			Me.btnFirstPage.IsEnabled = Me.m_canFirstPage
			Me.btnLastPage.IsEnabled = Me.m_canLastPage
			Me.btnNextPage.IsEnabled = Me.m_canNextPage
			Me.btnPreviousPage.IsEnabled = Me.m_canPreviousPage
		End Sub

		Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'Open a pdf document
			Dim dialog As New OpenFileDialog() With {.Filter = "Pdf document(*.Pdf)|*.pdf", .Title = "Open Pdf Document", .Multiselect = False, .InitialDirectory =System.IO.Path.GetFullPath("..\..\..\..\..\..\Data")}
			Dim result? As Boolean = dialog.ShowDialog()
			If result.Value Then
				Try
					'Load pdf document from file.
					Me.pdfDocumentViewer1.LoadFromFile(dialog.FileName)
					Me.txtPageCount.Text = Me.pdfDocumentViewer1.PageCount.ToString()
					SetbuttonState()
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error)
				End Try
			End If
		End Sub

		Private Sub btnClose_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'Close current pdf document.
			pdfDocumentViewer1.CloseDocument()
			Me.txtPageCount.Text = Me.pdfDocumentViewer1.PageCount.ToString()
		End Sub

		Private Sub txtCurrentPageIndex_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			If e.Key >= Key.D0 AndAlso e.Key <= Key.D9 OrElse e.Key >= Key.NumPad0 AndAlso e.Key <= Key.NumPad9 OrElse e.Key = Key.Return OrElse e.Key = Key.Back Then
				If e.Key = Key.Return Then
					Dim pageNumber As Integer = 0
					Integer.TryParse(txtCurrentPageIndex.Text, pageNumber)
					If pageNumber >= 1 AndAlso pageNumber <= Me.pdfDocumentViewer1.PageCount Then
						Me.pdfDocumentViewer1.GoToPage(Me.GetCurrentPageNumber())
					End If
				End If
			Else
				e.Handled = True
			End If
		End Sub

		Private Function GetCurrentPageNumber() As Integer
			If String.IsNullOrEmpty(Me.txtCurrentPageIndex.Text) Then
				Return 1
			End If
			Dim result As Integer = 1
			If Integer.TryParse(Me.txtCurrentPageIndex.Text, result) Then
				Return result
			End If
			Return -1
		End Function

		Private Sub btnFirstPage_IsEnabledChanged(ByVal sender As Object, ByVal e As DependencyPropertyChangedEventArgs)
			Dim content As Image = TryCast((CType(sender, Button)).Content, Image)
			content.Source = If(Me.btnFirstPage.IsEnabled, (New BitmapImage(New Uri("Resources/GoToFirstPage_Enabled.png", UriKind.Relative))), (New BitmapImage(New Uri("Resources/GoToFirstPage_Disabled.png", UriKind.Relative))))
		End Sub

		Private Sub btnPreviousPage_IsEnabledChanged(ByVal sender As Object, ByVal e As DependencyPropertyChangedEventArgs)
			Dim content As Image = TryCast((CType(sender, Button)).Content, Image)
			content.Source = If(Me.btnPreviousPage.IsEnabled, (New BitmapImage(New Uri("Resources/GoToPreviousPage_Enabled.png", UriKind.Relative))), (New BitmapImage(New Uri("Resources/GoToPreviousPage_Disabled.png", UriKind.Relative))))
		End Sub

		Private Sub btnNextPage_IsEnabledChanged(ByVal sender As Object, ByVal e As DependencyPropertyChangedEventArgs)
			Dim content As Image = TryCast((CType(sender, Button)).Content, Image)
			content.Source = If(Me.btnNextPage.IsEnabled, (New BitmapImage(New Uri("Resources/GoToNextPage_Enabled.png", UriKind.Relative))), (New BitmapImage(New Uri("Resources/GoToNextPage_Disabled.png", UriKind.Relative))))
		End Sub

		Private Sub btnLastPage_IsEnabledChanged(ByVal sender As Object, ByVal e As DependencyPropertyChangedEventArgs)
			Dim content As Image = TryCast((CType(sender, Button)).Content, Image)
			content.Source = If(Me.btnLastPage.IsEnabled, (New BitmapImage(New Uri("Resources/GoToLastPage_Enabled.png", UriKind.Relative))), (New BitmapImage(New Uri("Resources/GoToLastPage_Disabled.png", UriKind.Relative))))
		End Sub

		Private Sub btnFirstPage_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'Go to first page.
			Me.pdfDocumentViewer1.GoToFirstPage()
		End Sub

		Private Sub btnPreviousPage_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'Go To Previous Page
			Me.pdfDocumentViewer1.GoToPreviousPage()
		End Sub

		Private Sub btnNextPage_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'Go to next page.
			Me.pdfDocumentViewer1.GoToNextPage()
		End Sub

		Private Sub btnLastPage_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'Go to last page.
			Me.pdfDocumentViewer1.GoToLastPage()
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Try
				' Load pdf document from file.
				Me.pdfDocumentViewer1.LoadFromFile("..\..\..\..\..\..\Data\Sample3.pdf")
				Me.txtPageCount.Text = Me.pdfDocumentViewer1.PageCount.ToString()
				SetbuttonState()
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error)
			End Try
		End Sub
	End Class
End Namespace
