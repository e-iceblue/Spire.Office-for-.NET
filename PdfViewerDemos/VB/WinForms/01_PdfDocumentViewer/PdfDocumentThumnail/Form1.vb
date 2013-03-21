Imports System.ComponentModel
Imports System.IO
Imports System.Text
Imports Spire.PdfViewer.Forms
Imports Spire.PdfViewer.Forms.PdfThumbnails


Namespace PdfDocumentThumnail
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.txtThumbnailRatio.Text = Me.pdfDocumentThumbnail1.ZoomPercent.ToString()
            If File.Exists("..\..\..\..\..\..\Data\Italin.pdf") Then
                Me.pdfDocumentViewer1.LoadFromFile("..\..\..\..\..\..\Data\Italin.pdf")
            End If

		End Sub


		''' <summary>
		''' Load PDF document
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpen.Click
			Dim dialog As New OpenFileDialog()
			dialog.Filter = "PDF document(*.pdf)|*.pdf"
			Dim result As DialogResult = dialog.ShowDialog()
			If result = DialogResult.OK Then
				Dim pdfDocument As String = dialog.FileName
				Me.pdfDocumentViewer1.LoadFromFile(pdfDocument)
			End If

		End Sub
		''' <summary>
		''' Set PdfDocumentThumbnail ratio
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub btnThumbnailRatio_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnThumbnailRatio.Click
			If Me.pdfDocumentViewer1.IsDocumentLoaded Then
				Dim percent As Integer = 0
				Dim isNumeric As Boolean = Integer.TryParse(Me.txtThumbnailRatio.Text, percent)
				If isNumeric Then
					Me.pdfDocumentThumbnail1.ZoomPercent =Math.Abs(percent)
				End If
			End If
		End Sub


	End Class
End Namespace
