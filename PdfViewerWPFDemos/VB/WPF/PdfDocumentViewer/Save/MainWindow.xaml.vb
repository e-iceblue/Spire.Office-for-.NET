Imports System.Text

Imports Microsoft.Win32
Imports Spire.PdfViewer.Wpf
Imports Spire.PdfViewer

Namespace Save
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'Open a pdf document          
			Dim dialog As New OpenFileDialog() With {.Filter = "Pdf document(*.Pdf)|*.pdf", .Title = "Open Pdf Document", .Multiselect = False, .InitialDirectory =System.IO.Path.GetFullPath("..\..\..\..\..\..\Data")}
			Dim result? As Boolean = dialog.ShowDialog()
			If result.Value Then
				Try
					Me.pdfDocumentViewer1.LoadFromFile(dialog.FileName)
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error)
				End Try
			End If
		End Sub

		Private Sub btnClose_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			pdfDocumentViewer1.CloseDocument()
		End Sub

		Private Sub btnSave_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim savefile As New SaveFileDialog() With {.Filter = "Pdf Document(*.Pdf)|*.Pdf", .Title = "Save"}
			Dim result? As Boolean = savefile.ShowDialog()
			If result.Value Then
				Try
					'Save PDF documetns
					pdfDocumentViewer1.SaveToFile(savefile.FileName)
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error)
				End Try
			End If

		End Sub

		Private Sub btnSaveStream_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim savefile As New SaveFileDialog() With {.Filter = "Pdf Document(*.Pdf)|*.Pdf", .Title = "Save"}
			Dim result? As Boolean = savefile.ShowDialog()
			If result.Value Then
				Try
					Dim stream As New System.IO.MemoryStream()
					'Pdf document to save the file stream.
					pdfDocumentViewer1.SaveToFile(stream)
					stream.Position = 0
					Dim fileBytes() As Byte = stream.ToArray()
					stream.Close()
					Dim fileStream As New System.IO.FileStream(savefile.FileName, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite)
					fileStream.Write(fileBytes, 0, fileBytes.Length)
					fileStream.Flush()
					fileStream.Close()

				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error)
				End Try
			End If
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
