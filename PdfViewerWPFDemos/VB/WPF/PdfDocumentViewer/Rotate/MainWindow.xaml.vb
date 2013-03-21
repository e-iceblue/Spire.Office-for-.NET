Imports System.IO
Imports System.Text
Imports Microsoft.Win32
Imports Spire.PdfViewer.Wpf

Namespace Rotate
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub


		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim pdfFileName As String = "..\..\..\..\..\..\Data\PDFViewer.pdf"
			If File.Exists(pdfFileName) Then
				Me.pdfDocumentViewer1.LoadFromFile(pdfFileName)
			End If

		End Sub


		Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim dialog As New OpenFileDialog()
			dialog.Filter = "PDF document(*.pdf)|*.pdf"
			Dim dialogResult? As Boolean = dialog.ShowDialog()
			If dialogResult.HasValue AndAlso dialogResult.Value Then
				Dim pdfFileName As String = dialog.FileName
				Me.pdfDocumentViewer1.LoadFromFile(pdfFileName)
			End If
		End Sub

		Private Sub btnRotate_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			If Me.pdfDocumentViewer1.IsDocumentLoaded AndAlso Me.CboRotate.SelectedIndex <> -1 Then
				Dim rotateAngle As RotateAngle = CType(Me.CboRotate.SelectedIndex, RotateAngle)
				'Rotate PDF document
				Me.pdfDocumentViewer1.Rotate(rotateAngle)

			End If

		End Sub



	End Class
End Namespace
