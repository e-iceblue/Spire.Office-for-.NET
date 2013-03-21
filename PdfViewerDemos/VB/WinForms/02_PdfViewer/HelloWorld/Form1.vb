Imports System.IO
Imports Spire.PdfViewer.Forms


Namespace PdfViewer_HelloWorld
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim pdfDoc As String = "..\..\..\..\..\..\Data\Le_Petit_Prince_French.pdf"
			If File.Exists(pdfDoc) Then
				Me.pdfViewer1.LoadFromFile(pdfDoc)
			End If

		End Sub


	End Class
End Namespace
