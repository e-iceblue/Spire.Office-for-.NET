Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Input
Imports System.IO
Imports System.Windows.Media.Imaging
Imports System.Windows.Resources

Namespace Paging
	Partial Public Class MainPage
		Inherits UserControl
		Private m_canFirstPage As Boolean = False
		Private m_canNextPage As Boolean = False
		Private m_canPreviousPage As Boolean = False
		Private m_canLastPage As Boolean = False

		Public Sub New()
			InitializeComponent()

			AddHandler pdfDocumentViewer1.PageNumberChanged, AddressOf pdfDocumentViewer1_PageNumberChanged
			Me.btnGotoFirst.IsEnabled = Me.m_canFirstPage
			Me.btnGotoLast.IsEnabled = Me.m_canLastPage
			Me.btnGotoNext.IsEnabled = Me.m_canNextPage
			Me.btnGotoPre.IsEnabled = Me.m_canPreviousPage
		End Sub

		Private Sub pdfDocumentViewer1_PageNumberChanged(ByVal sender As Object, ByVal args As EventArgs)
			Dim currentNum As Integer = Me.pdfDocumentViewer1.CurrentPageNumber
			Dim result As Integer = 0
			Integer.TryParse(txtCurrentPageIndex.Text, result)
			If currentNum <> result AndAlso result > 0 Then
				SetButtonState()
			End If
			Me.txtCurrentPageIndex.Text = currentNum.ToString()
		End Sub

		Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim dialog As New OpenFileDialog()

			Dim result? As Boolean = dialog.ShowDialog()
			If result.HasValue AndAlso result.Value Then
				Try
					Using stream As Stream = dialog.File.OpenRead()
						Me.pdfDocumentViewer1.LoadFromStream(stream)
					End Using
					Me.txtPageCount.Text = Me.pdfDocumentViewer1.PageCount.ToString()
					SetButtonState()
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK)
				End Try
			End If
		End Sub

		Private Sub btnGotoFirst_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'go to first page
			Me.pdfDocumentViewer1.GoToFirstPage()
		End Sub

		Private Sub btnGotoPre_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'go to previous page
			Me.pdfDocumentViewer1.GoToPreviousPage()
		End Sub

		Private Sub btnGotoNext_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'go to next page
			Me.pdfDocumentViewer1.GoToNextPage()
		End Sub

		Private Sub btnGotoLast_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'go to last page
			Me.pdfDocumentViewer1.GoToLastPage()
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
			m_canPreviousPage = False
			m_canNextPage = False
			m_canLastPage = False
		End Sub

		Private Sub SetButtonState()
			buttonStatesChanged()
			Me.btnGotoFirst.IsEnabled = Me.m_canFirstPage
			Me.btnGotoLast.IsEnabled = Me.m_canLastPage
			Me.btnGotoNext.IsEnabled = Me.m_canNextPage
			Me.btnGotoPre.IsEnabled = Me.m_canPreviousPage
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

		Private Sub btnFirst_IsEnabledChanged(ByVal sender As Object, ByVal e As DependencyPropertyChangedEventArgs)
			Dim content As Image = TryCast((CType(sender, Button)).Content, Image)
			content.Source = If(Me.btnGotoFirst.IsEnabled, (New BitmapImage(New Uri("Resource/GotoFirstPage_Enabled.png", UriKind.Relative))), (New BitmapImage(New Uri("Resource/GotoFirstPage_Disabled.png", UriKind.Relative))))
		End Sub

		Private Sub btnPre_IsEnabledChanged(ByVal sender As Object, ByVal e As DependencyPropertyChangedEventArgs)
			Dim content As Image = TryCast((CType(sender, Button)).Content, Image)
			content.Source = If(Me.btnGotoPre.IsEnabled, (New BitmapImage(New Uri("Resource/GotoPreviousPage_Enabled.png", UriKind.Relative))), (New BitmapImage(New Uri("Resource/GotoPreviousPage_Disabled.png", UriKind.Relative))))
		End Sub

		Private Sub btnNext_IsEnabledChanged(ByVal sender As Object, ByVal e As DependencyPropertyChangedEventArgs)
			Dim content As Image = TryCast((CType(sender, Button)).Content, Image)
			content.Source = If(Me.btnGotoNext.IsEnabled, (New BitmapImage(New Uri("Resource/GotoNextPage_Enabled.png", UriKind.Relative))), (New BitmapImage(New Uri("Resource/GotoNextPage_Disabled.png", UriKind.Relative))))
		End Sub

		Private Sub btnLast_IsEnabledChanged(ByVal sender As Object, ByVal e As DependencyPropertyChangedEventArgs)
			Dim content As Image = TryCast((CType(sender, Button)).Content, Image)
			content.Source = If(Me.btnGotoLast.IsEnabled, (New BitmapImage(New Uri("Resource/GotoLastPage_Enabled.png", UriKind.Relative))), (New BitmapImage(New Uri("Resource/GotoLastPage_Disabled.png", UriKind.Relative))))
		End Sub

		Private Sub chkHandTool_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Me.pdfDocumentViewer1.EnableHandTools = Me.chkHandTool.IsChecked.Value
		End Sub

		Private Sub txtCurrentPageIndex_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			If e.Key >= Key.D0 AndAlso e.Key <= Key.D9 OrElse e.Key = Key.Enter OrElse e.Key >= Key.NumPad0 AndAlso e.Key <= Key.NumPad9 Then
				If e.Key = Key.Enter Then
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

		Private Sub UserControl_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim resource As StreamResourceInfo = Application.GetResourceStream(New Uri("Paging;component/Sample.pdf", UriKind.Relative))
			Me.pdfDocumentViewer1.LoadFromStream(resource.Stream)
			Me.txtPageCount.Text = Me.pdfDocumentViewer1.PageCount.ToString()
			SetButtonState()
		End Sub
	End Class
End Namespace
