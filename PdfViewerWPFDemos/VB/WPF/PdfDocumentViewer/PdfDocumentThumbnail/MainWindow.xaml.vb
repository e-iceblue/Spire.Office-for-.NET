Imports System.IO
Imports System.Text
Imports Microsoft.Win32
Imports Spire.PdfViewer.Wpf
Imports Spire.PdfViewer.Wpf.PdfThumbnails

Namespace PdfDocumentThumbnail
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub


		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim pdfFileName As String = "..\..\..\..\..\..\Data\Italin.pdf"
			If File.Exists(pdfFileName) Then
				Me.pdfDocumentViewer1.LoadFromFile(pdfFileName)
			End If

		End Sub

		Private Sub btnThumnail_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			' PdfDocumentThumnail control Asscoiate with PdfDocumentViewer control
			Me.pdfDocumentThumbnail1.Viewer = Me.pdfDocumentViewer1

		End Sub


		Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim dlg As New OpenFileDialog()
			dlg.Filter = "PDF document(*.pdf)|*.pdf"
			Dim result? As Boolean = dlg.ShowDialog()
			If result.HasValue AndAlso result.Value Then
				Dim pdfFileName As String = dlg.FileName
				Me.pdfDocumentViewer1.LoadFromFile(pdfFileName)
			End If
		End Sub



	End Class
End Namespace
