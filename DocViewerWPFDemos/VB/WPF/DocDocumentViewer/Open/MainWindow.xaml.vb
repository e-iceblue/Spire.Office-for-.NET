Imports System.Text

Imports Microsoft.Win32


Namespace PdfDocumentViewer_Open
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Private stream As System.IO.FileStream
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'open a pdf document
			Dim dialog As New OpenFileDialog() With {.Filter = "Word document(*.doc,*.docx)|*.doc;*.docx", .Title = "Open Pdf Document", .Multiselect = False, .InitialDirectory =System.IO.Path.GetFullPath("..\..\..\..\..\..\Data")}
			Dim result? As Boolean = dialog.ShowDialog()
			If result.Value Then
				Try
					'Load pdf document from file.
					Me.docDocumentViewer1.LoadFromFile(dialog.FileName)
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error)
				End Try
			End If
		End Sub

		Private Sub btnOpenSteam_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'open a doc document
			Dim dialog As New OpenFileDialog() With {.Filter = "Word document(*.doc,*.docx)|*.doc;*.docx", .Title = "Open Doc Document", .Multiselect = False, .InitialDirectory =System.IO.Path.GetFullPath("..\..\..\..\..\..\Data")}
			Dim result? As Boolean = dialog.ShowDialog()
			If result.Value Then
				Try
					Dim pdfFile As String = dialog.FileName
					stream = New System.IO.FileStream(pdfFile, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read)
					If stream IsNot Nothing Then
						'Load doc document from stream.
						Me.docDocumentViewer1.LoadFromStream(stream,Spire.Doc.FileFormat.Auto)
					End If
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error)
				End Try
			End If
		End Sub


		Private Sub btnClose_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'Close current doc document.
			docDocumentViewer1.CloseDocument()
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Try
				' Load doc document from file.
				Me.docDocumentViewer1.LoadFromFile("..\..\..\..\..\..\Data\Summary_of_Science.docx")
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error)
			End Try
		End Sub
	End Class
End Namespace
