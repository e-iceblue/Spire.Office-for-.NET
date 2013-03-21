Imports System.IO
Imports System.Text
Imports Microsoft.Win32
Imports Spire.PdfViewer.Wpf



Namespace ExtendFunction
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub


		'Load default PDF document when window loaded
		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim pdfFileName As String = "..\..\..\..\..\..\Data\PDFViewer.pdf"
			If File.Exists(pdfFileName) Then
				Me.pdfDocumentViewer1.LoadFromFile(pdfFileName)
			End If

		End Sub
		'Open PDF document
		Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim dialog As New OpenFileDialog()
			dialog.Filter = "PDF document(*.pdf)|*.pdf"
			Dim dialogResult? As Boolean = dialog.ShowDialog()
			If dialogResult.HasValue AndAlso dialogResult.Value Then
				Dim pdfFileName As String = dialog.FileName
				'load PDF document
				Me.pdfDocumentViewer1.LoadFromFile(pdfFileName)
			End If

		End Sub

		'Get PDF document basic informations.
		Private Sub btnInfo_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			If Me.pdfDocumentViewer1.IsDocumentLoaded Then
				Dim info As String = ""
				info &= "File name: " & Me.pdfDocumentViewer1.FileName & vbLf
				Dim docInfo As PdfDocumentInfo = Me.pdfDocumentViewer1.GetDocumentInfomation()
				info &= "Author: " & docInfo.Author & vbLf
				info &= "Creator: " & docInfo.Creator & vbLf
				info &= "Producer: " & docInfo.Producer & vbLf
				info &= "Title: " & docInfo.Title & vbLf
				info &= "Subject: " & docInfo.Subject & vbLf
				info &= "Keywords: " & docInfo.Keywords & vbLf
				info &= "Creation date: " & docInfo.CreationDate.ToString() & vbLf
				info &= "Modifaction date: " & docInfo.ModificationDate.ToString() & vbLf
				MessageBox.Show(info, "Document information", MessageBoxButton.OK, MessageBoxImage.Information)
			End If
		End Sub

		Private Sub btnLink_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Me.LoadPDFFromWebPage()

		End Sub

		Private Sub txtUrl_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			Dim key As Key = e.Key
			If key = Key.Enter Then
				Me.LoadPDFFromWebPage()

			End If
		End Sub
		'Convert webpage to PDF document then load with PdfDocumentViewer component.
		Private Sub LoadPDFFromWebPage()
			Dim url As String = Me.txtUrl.Text.Trim()
			Dim convertPdfFileName As String = System.IO.Path.GetFileName(url)
			If String.IsNullOrEmpty(convertPdfFileName) Then
				convertPdfFileName = "default.pdf"
			Else
				convertPdfFileName = convertPdfFileName.Substring(0, convertPdfFileName.LastIndexOf("."))
				convertPdfFileName &= ".pdf"
			End If
			Try
				Me.pdfDocumentViewer1.LoadFromHtml(url, convertPdfFileName)

			Catch exc As Exception
				MessageBox.Show(exc.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error)
			End Try

		End Sub





	End Class
End Namespace
