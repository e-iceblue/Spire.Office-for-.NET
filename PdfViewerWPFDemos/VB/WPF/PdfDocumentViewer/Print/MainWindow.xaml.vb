Imports System.Text

Imports Microsoft.Win32
Imports Spire.PdfViewer.Wpf
Imports Spire.PdfViewer

Namespace Print
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'Open a pdf document.
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

		Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'Show a Print Dialog
			Dim dialog As New PrintDialog()
			dialog.MaxPage = If(Me.pdfDocumentViewer1.PageCount > 0, CUInt(Me.pdfDocumentViewer1.PageCount), 1)
			dialog.MinPage = 1
			dialog.UserPageRangeEnabled = True
			Dim result? As Boolean = dialog.ShowDialog()
			If result.Value Then
				Try
					'Set print parnameters.
					Me.pdfDocumentViewer1.PrintDialog = dialog
					'Gets the PrintDocument.
					dialog.PrintDocument(pdfDocumentViewer1.PrintDocument.DocumentPaginator, "Print Document")
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error)
				End Try
			End If
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Try
				' Load pdf document from file.
				Me.pdfDocumentViewer1.LoadFromFile("..\..\..\..\..\..\Data\PartList.pdf")
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error)
			End Try
		End Sub
	End Class
End Namespace
