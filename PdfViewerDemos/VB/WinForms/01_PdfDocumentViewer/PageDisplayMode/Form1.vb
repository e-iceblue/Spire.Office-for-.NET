Imports System.ComponentModel
Imports System.IO
Imports System.Text

Namespace PageDisplayMode
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            If File.Exists("..\..\..\..\..\..\Data\Lslam.pdf") Then
                Me.pdfDocumentViewer1.LoadFromFile("..\..\..\..\..\..\Data\Lslam.pdf")
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
				Dim pdfDocument As String = dialog.FileName
				Me.pdfDocumentViewer1.LoadFromFile(pdfDocument)
			End If
		End Sub
		''' <summary>
		''' 
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub btnSingleContinuous_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSingleContinuous.Click
            Me.pdfDocumentViewer1.SetPageLayoutMode(Spire.PdfViewer.Forms.PageLayoutMode.SinglePageContinuous)
		End Sub

		Private Sub btnSingleDiscontinuous_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSingleDiscontinuous.Click
            Me.pdfDocumentViewer1.SetPageLayoutMode(Spire.PdfViewer.Forms.PageLayoutMode.SinglePageDiscontinuous)
		End Sub

		Private Sub btnDoubleContinuous_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDoubleContinuous.Click
            Me.pdfDocumentViewer1.SetPageLayoutMode(Spire.PdfViewer.Forms.PageLayoutMode.TwoPageContinuous)
		End Sub

		Private Sub btnDoubleDiscontinuous_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDoubleDiscontinuous.Click
            Me.pdfDocumentViewer1.SetPageLayoutMode(Spire.PdfViewer.Forms.PageLayoutMode.TwoPageDiscontinuous)
		End Sub

		Private Sub pdfDocumentViewer1_PageNumberChanged(ByVal sender As Object, ByVal args As EventArgs) Handles pdfDocumentViewer1.PageNumberChanged
			Me.lblPage.Text = Me.pdfDocumentViewer1.CurrentPageNumber.ToString()
		End Sub




	End Class
End Namespace
