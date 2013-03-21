Imports System.ComponentModel
Imports System.IO
Imports System.Text

Namespace SimpleFunction
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
				Dim pdfDocument As String = dialog.FileName
				Me.pdfDocumentViewer1.LoadFromFile(pdfDocument)
			End If
		End Sub
		''' <summary>
		''' Get PDF document information
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub btnInfo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnInfo.Click
			If Me.pdfDocumentViewer1.IsDocumentLoaded Then
				Dim info As String = ""
				info &= "File name: " & Me.pdfDocumentViewer1.FileName & vbLf
				Dim docInfo As Spire.PdfViewer.Forms.PdfDocumentInfo = Me.pdfDocumentViewer1.GetDocumentInfomation()
				info &= "Author: " & docInfo.Author & vbLf
				info &= "Creator: " & docInfo.Creator & vbLf
				info &= "Producer: " & docInfo.Producer & vbLf
				info &= "Title: " & docInfo.Title & vbLf
				info &= "Subject: " & docInfo.Subject & vbLf
				info &= "Keywords: " & docInfo.Keywords & vbLf
				info &= "Creation date: " & docInfo.CreationDate.ToString() & vbLf
				info &= "Modifaction date: " & docInfo.ModificationDate.ToString() & vbLf
				MessageBox.Show(info, "Document information", MessageBoxButtons.OK,MessageBoxIcon.Information)
			End If
		End Sub
		''' <summary>
		''' Verify PDF document whether to encrypt
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub btnVerifyEncrypt_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnVerifyEncrypt.Click
			Dim dialog As New OpenFileDialog()
			dialog.Filter = "PDF document(*.pdf)|*.pdf"
			Dim result As DialogResult = dialog.ShowDialog()
			If result = DialogResult.OK Then
				Dim pdfDocument As String = dialog.FileName
				Dim isEncrypted As Boolean = Spire.PdfViewer.Forms.PdfDocumentViewer.VeryfyDocumentEncrypted(pdfDocument)
				Dim info As String = "The PDF document file  " & dialog.FileName & vbLf & "Encrypted: " & isEncrypted.ToString()
				MessageBox.Show(info, "Verify Encrypt", MessageBoxButtons.OK,MessageBoxIcon.Information)

			End If

		End Sub
		''' <summary>
		''' Open html document as PDF document
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub btnFromHtml_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFromHtml.Click
			Dim dialog As New OpenFileDialog()
			dialog.Filter = "html files(*.html)|*.html"
			Dim result As DialogResult = dialog.ShowDialog()
			If result = DialogResult.OK Then
				Dim htmlDocument As String = dialog.FileName
				Dim pdfDocument As String=htmlDocument.Substring(0,htmlDocument.Length-4) & "pdf"
				Me.pdfDocumentViewer1.LoadFromHtml(htmlDocument,pdfDocument)
			End If
		End Sub


	End Class
End Namespace
