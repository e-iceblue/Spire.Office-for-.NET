Imports System.IO
Imports System.Text
Imports Microsoft.Win32
Imports Spire.PdfViewer.Wpf



Namespace PageLayoutMode
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
			Dim pdfFileName As String = "..\..\..\..\..\..\Data\Le_Petit_Prince_French.pdf"
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
				Me.pdfDocumentViewer1.LoadFromFile(pdfFileName)
			End If
		End Sub

		'Swith PDF document page layout mode
		Private Sub CboLayoutMode_SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
			If Me.pdfDocumentViewer1 IsNot Nothing AndAlso Me.pdfDocumentViewer1.IsDocumentLoaded AndAlso Me.CboLayoutMode.SelectedIndex <> -1 Then
				Dim layoutMode As Spire.PdfViewer.Wpf.PageLayoutMode = CType(Me.CboLayoutMode.SelectedIndex, Spire.PdfViewer.Wpf.PageLayoutMode)
				Me.pdfDocumentViewer1.SetPageLayoutMode(layoutMode)
			End If

		End Sub

	End Class
End Namespace
