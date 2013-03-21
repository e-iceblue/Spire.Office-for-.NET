Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Input
Imports System.IO
Imports Spire.PdfViewer.SL
Imports System.Windows.Resources

Namespace Zoom
	Partial Public Class MainPage
		Inherits UserControl
		Private zoomValues() As Integer = { 25, 50, 100, 150, 200 }
		Public Sub New()
			InitializeComponent()
			AddHandler cmbCurrentZoomLevel.KeyDown, AddressOf cmbCurrentZoomLevel_KeyDown
			AddHandler pdfDocumentViewer1.ZoomChanged, AddressOf pdfDocumentViewer1_ZoomChanged
		End Sub

		Private Sub pdfDocumentViewer1_ZoomChanged(ByVal sender As Object, ByVal zoomFactor As Integer)
			Dim text As String = String.Format("{0}%", zoomFactor)
			TryCast((Me.cmbCurrentZoomLevel.SelectedItem), ComboBoxItem).Content = text
		End Sub

		Private Sub cmbCurrentZoomLevel_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			If e.Key >= Key.D0 AndAlso e.Key <= Key.D9 OrElse e.Key >= Key.NumPad0 AndAlso e.Key <= Key.NumPad9 OrElse e.Key = Key.Enter OrElse e.Key = Key.Back Then
				Dim text As String = (TryCast(cmbCurrentZoomLevel.SelectedItem, ComboBoxItem)).Content.ToString().Replace("%", "")
				Dim currentZoomLevel As Integer = 0
				Integer.TryParse(text, currentZoomLevel)
				If e.Key = Key.Enter AndAlso currentZoomLevel > 0 Then
					text = String.Format("{0}%", text)
					cmbCurrentZoomLevel.SelectedValue = text
					Me.pdfDocumentViewer1.ZoomTo(currentZoomLevel)
				End If
			Else
				e.Handled = True
			End If
		End Sub

		Private Function GetCurrentZoomLevel() As Integer
			Dim s As String = ""

			s = (TryCast((Me.cmbCurrentZoomLevel.SelectedItem), ComboBoxItem)).Content.ToString()

			s = s.TrimEnd(New Char() { "%"c })
			Dim result As Integer = 100
			If Integer.TryParse(s, result) Then
				Return result
			End If

			Return 100
		End Function

		Private Function GetComboboxItemIndex(ByVal text As String) As Integer
			For i As Integer = 0 To Me.cmbCurrentZoomLevel.Items.Count - 1
				If Object.Equals((TryCast(Me.cmbCurrentZoomLevel.Items(i), ComboBoxItem)).Content, text) Then
					Return i
				End If
			Next i
			Return -1
		End Function


		Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim dialog As New OpenFileDialog()

			Dim result? As Boolean = dialog.ShowDialog()
			If result.HasValue AndAlso result.Value Then
				Try
					Using stream As Stream = dialog.File.OpenRead()
						Me.pdfDocumentViewer1.LoadFromStream(stream)
					End Using
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK)
				End Try
			End If
		End Sub

		Private Sub btnZoomOut_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim currentZoomLevel As Integer = Me.GetCurrentZoomLevel()
			Dim comboxItemIndex As Integer = Me.GetComboboxItemIndex(String.Format("{0}%", currentZoomLevel))
			If (comboxItemIndex - 1) >= 0 Then
				Me.cmbCurrentZoomLevel.SelectedIndex = comboxItemIndex - 1
				Return
			Else
				For i As Integer = 0 To Me.zoomValues.Length - 1
					If (((i + 1 < Me.zoomValues.Length) AndAlso (currentZoomLevel >= Me.zoomValues(i))) AndAlso (currentZoomLevel < Me.zoomValues(i + 1))) Then
						Me.cmbCurrentZoomLevel.SelectedIndex = i
						Return
					End If
				Next i
			End If
		End Sub

		Private Sub btnFitWidth_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Me.pdfDocumentViewer1.ZoomMode = ZoomMode.FitWidth
		End Sub

		Private Sub btnFitPage_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Me.pdfDocumentViewer1.ZoomMode = ZoomMode.FitPage
		End Sub

		Private Sub btnZoomIn_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim currentZoomLevel As Integer = Me.GetCurrentZoomLevel()
			Dim comboxItemIndex As Integer = Me.GetComboboxItemIndex(String.Format("{0}%", currentZoomLevel))
			If ((comboxItemIndex + 1 < Me.cmbCurrentZoomLevel.Items.Count) AndAlso comboxItemIndex >= 0) Then
				Me.cmbCurrentZoomLevel.SelectedIndex = comboxItemIndex + 1
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

		Private Sub cmbCurrentZoomLevel_SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
			Dim currentZoomLevel As Integer = Me.GetCurrentZoomLevel()
			Me.pdfDocumentViewer1.ZoomTo(currentZoomLevel)
		End Sub

		Private Sub LayoutRoot_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Me.cmbCurrentZoomLevel.SelectedIndex = 2
		End Sub

		Private Sub UserControl_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim resource As StreamResourceInfo = Application.GetResourceStream(New Uri("Zoom;component/Sample2.pdf", UriKind.Relative))
			Me.pdfDocumentViewer1.LoadFromStream(resource.Stream)
		End Sub

	End Class
End Namespace
