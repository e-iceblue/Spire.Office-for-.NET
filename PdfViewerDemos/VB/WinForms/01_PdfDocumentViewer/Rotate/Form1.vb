Imports System.ComponentModel
Imports System.IO
Imports System.Text
Imports Spire.PdfViewer.Forms

Namespace Rotate
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			If File.Exists("..\..\..\..\..\..\Data\PDFViewer.pdf") Then
				Me.pdfDocumentViewer1.LoadFromFile("..\..\..\..\..\..\Data\PDFViewer.pdf")
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
		''' Rotate PDF document
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub btnRotate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRotate.Click
			If Me.pdfDocumentViewer1.IsDocumentLoaded Then
				If Me.comBoxAngle.SelectedIndex <> -1 Then
					Dim angle As RotateAngle = CType(Me.comBoxAngle.SelectedIndex, RotateAngle)
					Me.pdfDocumentViewer1.Rotate(angle)

				End If
			End If
		End Sub


	End Class
End Namespace
