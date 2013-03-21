Imports System.IO
Imports System.Text
Imports Microsoft.Win32
Imports Spire.PdfViewer.Wpf
Imports Spire.PdfViewer.Wpf.PdfViewerMode

Namespace ViewerMode
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			Me.txtMaxPages.Text = Me.pdfDocumentViewer1.MultiPagesThreshold.ToString()
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim pdfFileName As String = "..\..\..\..\..\..\Data\Lslam.pdf"
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

		Private Sub CboViewerMode_SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
			If Me.pdfDocumentViewer1 IsNot Nothing AndAlso Me.pdfDocumentViewer1.IsDocumentLoaded AndAlso Me.CboViewerMode.SelectedIndex <> -1 Then
				Dim viewerMode As PdfViewerMode = CType(Me.CboViewerMode.SelectedIndex, PdfViewerMode)
                If viewerMode = PdfViewerMode.DynamicSet Then
                    Try
                        Dim maxPageThreshold As Integer = Int32.Parse(Me.txtMaxPages.Text)
                        Me.pdfDocumentViewer1.MultiPagesThreshold = maxPageThreshold
                    Catch
                    End Try

                End If
				'set PDF document Viewer mode
				Me.pdfDocumentViewer1.SetViewerMode(viewerMode)
			End If

		End Sub

		Private Sub pdfDocumentViewer1_PageNumberChanged(ByVal sender As Object, ByVal args As EventArgs)
			Me.lblPageNo.Content = Me.pdfDocumentViewer1.CurrentPageNumber.ToString()
		End Sub



	End Class
End Namespace
