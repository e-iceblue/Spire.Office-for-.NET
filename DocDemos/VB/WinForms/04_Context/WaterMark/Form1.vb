Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace InsertingWatermark
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            'Open a blank word document as template
            Dim document_Renamed As New Document("..\..\..\..\..\..\Data\Blank.doc")

            InsertWatermark(document_Renamed.Sections(0))

            'Save doc file.
            document_Renamed.SaveToFile("Sample.doc", FileFormat.Doc)

            'Launching the MS Word file.
            WordDocViewer("Sample.doc")


        End Sub

        Private Sub InsertWatermark(ByVal section_Renamed As Section)
            Dim paragraph_Renamed As Paragraph = Nothing
            If section_Renamed.Paragraphs.Count > 0 Then
                paragraph_Renamed = section_Renamed.Paragraphs(0)
            Else
                paragraph_Renamed = section_Renamed.AddParagraph()
            End If
            paragraph_Renamed.AppendText("The sample demonstrates how to insert a watermark into a document.")
            paragraph_Renamed.ApplyStyle(BuiltinStyle.Heading2)


            Dim txtWatermark As New TextWatermark()
            txtWatermark.Text = "Watermark Demo"
            txtWatermark.FontSize = 90
            txtWatermark.Layout = WatermarkLayout.Diagonal
            section_Renamed.Document.Watermark = txtWatermark

        End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
