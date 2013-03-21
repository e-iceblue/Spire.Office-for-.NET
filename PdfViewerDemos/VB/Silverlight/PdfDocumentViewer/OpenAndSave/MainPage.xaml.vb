Imports System.Windows
Imports System.Windows.Controls
Imports System.IO
Imports System.Windows.Resources

Namespace OpenAndSave
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim dialog As New OpenFileDialog()

			Dim result? As Boolean = dialog.ShowDialog()
			If result.HasValue AndAlso result.Value Then
				Using stream As Stream = dialog.File.OpenRead()
					Me.pdfDocumentViewer1.LoadFromStream(stream)
				End Using
			End If
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim dialog As New SaveFileDialog()
			dialog.Filter = "PDF documents(*pdf)|*.pdf"

			Dim result? As Boolean = dialog.ShowDialog()
			If result.HasValue AndAlso result.Value Then
				Using stream As Stream = dialog.OpenFile()
					Me.pdfDocumentViewer1.SaveToFile(stream)
				End Using
			End If
		End Sub

		Private Sub UserControl_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim resource As StreamResourceInfo = Application.GetResourceStream(New Uri("OpenAndSave;component/Sample1.pdf", UriKind.Relative))
			Me.pdfDocumentViewer1.LoadFromStream(resource.Stream)
		End Sub
	End Class
End Namespace
