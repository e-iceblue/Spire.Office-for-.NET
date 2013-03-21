Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace Bookmark
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            'Open a blank word document as template
            Dim document_Renamed As New Document("..\..\..\..\..\..\Data\Blank.doc")

            Bookmark(document_Renamed.Sections(0))

            'Save doc file.
            document_Renamed.SaveToFile("Sample.doc", FileFormat.Doc)

            'Launching the MS Word file.
            WordDocViewer("Sample.doc")


        End Sub

        Private Sub Bookmark(ByVal section_Renamed As Section)
            Dim paragraph_Renamed As Paragraph = Nothing
            If section_Renamed.Paragraphs.Count > 0 Then
                paragraph_Renamed = section_Renamed.Paragraphs(0)
            Else
                paragraph_Renamed = section_Renamed.AddParagraph()
            End If
            paragraph_Renamed.AppendText("The sample demonstrates how to using bookmark.")
            paragraph_Renamed.ApplyStyle(BuiltinStyle.Heading2)

            section_Renamed.AddParagraph()
            paragraph_Renamed = section_Renamed.AddParagraph()
            paragraph_Renamed.AppendText("Simple bookmark.")
            paragraph_Renamed.ApplyStyle(BuiltinStyle.Heading4)

            ' Writing simple bookmarks
            section_Renamed.AddParagraph()
            paragraph_Renamed = section_Renamed.AddParagraph()
            paragraph_Renamed.AppendBookmarkStart("SimpleBookMark")
            paragraph_Renamed.AppendText("This is a simple book mark.")
            paragraph_Renamed.AppendBookmarkEnd("SimpleBookMark")

            section_Renamed.AddParagraph()
            paragraph_Renamed = section_Renamed.AddParagraph()
            paragraph_Renamed.AppendText("Nested bookmark.")
            paragraph_Renamed.ApplyStyle(BuiltinStyle.Heading4)

            ' Writing nested bookmarks
            section_Renamed.AddParagraph()
            paragraph_Renamed = section_Renamed.AddParagraph()
            paragraph_Renamed.AppendBookmarkStart("Root")
            paragraph_Renamed.AppendText(" Root data ")
            paragraph_Renamed.AppendBookmarkStart("NestedLevel1")
            paragraph_Renamed.AppendText(" Nested Level1 ")
            paragraph_Renamed.AppendBookmarkStart("NestedLevel2")
            paragraph_Renamed.AppendText(" Nested Level2 ")
            paragraph_Renamed.AppendBookmarkEnd("NestedLevel2")
            paragraph_Renamed.AppendText(" Data Level1 ")
            paragraph_Renamed.AppendBookmarkEnd("NestedLevel1")
            paragraph_Renamed.AppendText(" Data Root ")
            paragraph_Renamed.AppendBookmarkEnd("Root")

        End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
