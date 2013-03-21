Imports System.Text

Imports Microsoft.Win32
Imports Spire.PdfViewer.Wpf
Imports Spire.PdfViewer

Namespace Zoom
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Private zoomValues() As Integer = { 10, 50, 100, 150, 200, 400, 800, 1600 }
		Public Sub New()
			InitializeComponent()
			AddHandler cmbCurrentZoomLevel.KeyDown, AddressOf cmbCurrentZoomLevel_KeyDown
			AddHandler pdfDocumentViewer1.ZoomChanged, AddressOf pdfDocumentViewer1_ZoomChanged
		End Sub

		Private Sub pdfDocumentViewer1_ZoomChanged(ByVal sender As Object, ByVal zoomFactor As Integer)
			Dim text As String = String.Format("{0}%", zoomFactor)
			Me.cmbCurrentZoomLevel.Text = text
		End Sub

		Private Function GetCurrentZoomLevel() As Integer
			Dim s As String = ""
			If Me.cmbCurrentZoomLevel.SelectedValue Is Nothing Then
				s = Me.cmbCurrentZoomLevel.Text
			Else
				s = (TryCast(Me.cmbCurrentZoomLevel.SelectedValue, ComboBoxItem)).Content.ToString()
			End If
			s = s.TrimEnd(New Char() { "%"c })
			Dim result As Integer = 100
			If Integer.TryParse(s, result) Then
				Return result
			End If
			Return 100
		End Function

		Private Function GetComboBoxItemIndex(ByVal text As String) As Integer
			For i As Integer = 0 To Me.cmbCurrentZoomLevel.Items.Count - 1
				If Object.Equals((TryCast(Me.cmbCurrentZoomLevel.Items(i), ComboBoxItem)).Content, text) Then
					Return i
				End If
			Next i
			Return -1
		End Function

		Private Sub cmbCurrentZoomLevel_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			If e.Key >= Key.D0 AndAlso e.Key <= Key.D9 OrElse e.Key >= Key.NumPad0 AndAlso e.Key <= Key.NumPad9 OrElse e.Key = Key.Return OrElse e.Key = Key.Back Then
				Dim text As String = cmbCurrentZoomLevel.Text.Replace("%", "")
				Dim currentZoomLevel As Integer = 0
				Integer.TryParse(text, currentZoomLevel)
				If e.Key = Key.Return AndAlso currentZoomLevel > 0 Then
					text = String.Format("{0}%", text)
					cmbCurrentZoomLevel.SelectedValue = text
					cmbCurrentZoomLevel.Text = text
					Me.pdfDocumentViewer1.ZoomTo(currentZoomLevel)
				End If
			Else
				e.Handled = True
			End If
		End Sub

		Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'open a pdf Document
			Dim dialog As New OpenFileDialog() With {.Filter = "Pdf document(*.Pdf)|*.pdf", .Title = "Open Pdf Document", .Multiselect = False, .InitialDirectory =System.IO.Path.GetFullPath("..\..\..\..\..\..\Data")}
			Dim result? As Boolean = dialog.ShowDialog()
			If result.Value Then
				Try
					'Load pdf document from file.
					Me.pdfDocumentViewer1.LoadFromFile(dialog.FileName)
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error)
				End Try
			End If
		End Sub

		Private Sub btnClose_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'Close current pdf document.
			pdfDocumentViewer1.CloseDocument()
		End Sub

		Private Sub btnZooIn_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim currentZoomLevel As Integer = Me.GetCurrentZoomLevel()
			Dim comboBoxItemIndex As Integer = Me.GetComboBoxItemIndex(String.Format("{0}%", currentZoomLevel))
			If ((comboBoxItemIndex + 1) < Me.cmbCurrentZoomLevel.Items.Count) AndAlso comboBoxItemIndex >= 0 Then
				Me.cmbCurrentZoomLevel.SelectedIndex = comboBoxItemIndex + 1
				Return
			Else
				For i As Integer = 0 To Me.zoomValues.Length - 1
					If ((i - 1) >= 0) AndAlso (Me.zoomValues(i) > currentZoomLevel) Then
						Me.cmbCurrentZoomLevel.SelectedIndex = i
						Return

					End If
				Next i
			End If
		End Sub

		Private Sub btnZoomOut_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim currentZoomLevel As Integer = Me.GetCurrentZoomLevel()
			Dim comboBoxItemIndex As Integer = Me.GetComboBoxItemIndex(String.Format("{0}%", currentZoomLevel))
			If (comboBoxItemIndex - 1) >= 0 Then
				Me.cmbCurrentZoomLevel.SelectedIndex = comboBoxItemIndex - 1
				Return
			Else
				For i As Integer = 0 To Me.zoomValues.Length - 1
					If (((i + 1) < Me.zoomValues.Length) AndAlso (currentZoomLevel >= Me.zoomValues(i))) AndAlso (currentZoomLevel < Me.zoomValues(i + 1)) Then
						Me.cmbCurrentZoomLevel.SelectedIndex = i
						Return
					End If
				Next i
			End If
		End Sub

		Private Sub btnFitPage_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Me.pdfDocumentViewer1.ZoomMode = ZoomMode.FitPage
		End Sub

		Private Sub btnFitWidth_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Me.pdfDocumentViewer1.ZoomMode = ZoomMode.FitWidth
		End Sub

		Private Sub cmbCurrentZoomLevel_SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
			Dim currentZoomLevel As Integer = Me.GetCurrentZoomLevel()
			Me.pdfDocumentViewer1.ZoomTo(currentZoomLevel)
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Try
				' Load pdf document from file.
				Me.pdfDocumentViewer1.LoadFromFile("..\..\..\..\..\..\Data\Spire.Office.pdf")
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error)
			End Try
		End Sub
	End Class
End Namespace
