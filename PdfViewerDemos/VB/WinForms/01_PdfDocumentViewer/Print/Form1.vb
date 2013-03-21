Imports System.Drawing.Printing
Imports System.IO
Imports Spire.PdfViewer.Forms

Namespace PdfDocumentViewer_Print
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpen.Click, pdfDocumentViewer1.Click
			Dim dialog As New OpenFileDialog()
			dialog.Filter = "PDF document (*.pdf)|*.pdf"
			Dim result As DialogResult = dialog.ShowDialog()
			If result = DialogResult.OK Then

					Dim pdfFile As String = dialog.FileName
					Me.pdfDocumentViewer1.LoadFromFile(pdfFile)
			End If
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim pdfDoc As String = "..\..\..\..\..\..\Data\Spire.Office.pdf"
			If File.Exists(pdfDoc) Then
				Me.pdfDocumentViewer1.LoadFromFile(pdfDoc)
			End If

		End Sub

		Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
			If Me.pdfDocumentViewer1.PageCount > 0 Then
				Me.pdfDocumentViewer1.Print()
			End If
		End Sub


        Private Sub pdfDocumentViewer1_PdfLoaded(ByVal sender As System.Object, ByVal args As System.EventArgs) Handles pdfDocumentViewer1.PdfLoaded
            Me.comBoxPages.Items.Clear()
            Dim totalPage As Integer = Me.pdfDocumentViewer1.PageCount

            For i As Integer = 1 To totalPage
                Me.comBoxPages.Items.Add(i.ToString())
            Next i

            Me.comBoxPages.SelectedIndex = 0
        End Sub

        Private Sub pdfDocumentViewer1_PageNumberChanged(ByVal sender As System.Object, ByVal args As System.EventArgs) Handles pdfDocumentViewer1.PageNumberChanged
            If Me.comBoxPages.Items.Count <= 0 Then
                Return
            End If
            If Me.pdfDocumentViewer1.CurrentPageNumber <> Me.comBoxPages.SelectedIndex + 1 Then
                Me.comBoxPages.SelectedIndex = Me.pdfDocumentViewer1.CurrentPageNumber - 1
            End If
        End Sub

        Private Sub comBoxPages_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comBoxPages.SelectedIndexChanged
            Dim soucePage As Integer = Me.pdfDocumentViewer1.CurrentPageNumber
            Dim targetPage As Integer = Me.comBoxPages.SelectedIndex + 1
            If soucePage <> targetPage Then
                Me.pdfDocumentViewer1.GoToPage(targetPage)
            End If
        End Sub
    End Class
End Namespace
