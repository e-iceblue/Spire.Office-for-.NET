Imports System.ComponentModel
Imports System.IO
Imports System.Text

Namespace ViewerMode
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            If File.Exists("..\..\..\..\..\..\Data\Italin.pdf") Then
                Me.pdfDocumentViewer1.LoadFromFile("..\..\..\..\..\..\Data\Italin.pdf")
            End If
		End Sub

		''' <summary>
		''' Open PDF document
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpen.Click
			Dim dialog As New OpenFileDialog()
			dialog.Filter = "PDF document(*.pdf)|*.pdf"
			Dim result As DialogResult = dialog.ShowDialog()
			If result = DialogResult.OK Then
				Dim pdfFile As String = dialog.FileName
				Me.pdfDocumentViewer1.LoadFromFile(pdfFile)
			End If
		End Sub
		''' <summary>
		''' Continuous page mode
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub btnContinuous_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnContinuous.Click
			If Me.pdfDocumentViewer1.IsDocumentLoaded Then
                Me.pdfDocumentViewer1.SetViewerMode(Spire.PdfViewer.Forms.PdfViewerMode.PdfViewerMode.MultiPage)
			End If

		End Sub
		''' <summary>
		''' Single page mode
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub btnSingle_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSingle.Click
			If Me.pdfDocumentViewer1.IsDocumentLoaded Then
                Me.pdfDocumentViewer1.SetViewerMode(Spire.PdfViewer.Forms.PdfViewerMode.PdfViewerMode.SinglePage)
			End If
		End Sub
		''' <summary>
		''' Auto mode,if PDF document height greater than 32767,display with single page mode,otherwise display with continuous page mode
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub btnAuto_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAuto.Click
			If Me.pdfDocumentViewer1.IsDocumentLoaded Then
				Me.pdfDocumentViewer1.SetViewerMode(Spire.PdfViewer.Forms.PdfViewerMode.PdfViewerMode.Auto)
			End If
		End Sub
		''' <summary>
		''' Threshold mode,if PDF document page count less than Threshold value,display with continuous page mode ,otherwize display with single page mode
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub btnThreshold_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnThreshold.Click
			If Me.pdfDocumentViewer1.IsDocumentLoaded Then
				Dim threshold As Integer = 0
				Dim isNumeric As Boolean = Integer.TryParse(Me.txtThreshold.Text, threshold)
				If isNumeric Then
					Me.pdfDocumentViewer1.Threshold = Math.Abs(threshold)
					Me.pdfDocumentViewer1.SetViewerMode(Spire.PdfViewer.Forms.PdfViewerMode.PdfViewerMode.DynamicSet)
				End If
			End If
		End Sub

		Private Sub pdfDocumentViewer1_PageNumberChanged(ByVal sender As Object, ByVal args As EventArgs) Handles pdfDocumentViewer1.PageNumberChanged
			Me.lblPage.Text = Me.pdfDocumentViewer1.CurrentPageNumber.ToString()
		End Sub


	End Class
End Namespace
