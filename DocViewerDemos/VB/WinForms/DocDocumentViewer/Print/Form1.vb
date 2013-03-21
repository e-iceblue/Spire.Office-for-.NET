Imports System.ComponentModel
Imports System.Text

Namespace Print
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			Try
				' Load DOC document from file.
				Me.docDocumentViewer1.LoadFromFile("..\..\..\..\..\..\Data\UserForm.docx")
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		End Sub

		Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpen.Click
			'Open a Doc document.
			Dim dialog As New OpenFileDialog()
			dialog.Filter = "Word97-2003 files(*.doc)|*.doc|Word2007-2010 files (*.docx)|*.docx|All files (*.*)|*.*"
			dialog.Title = "Select a DOC file"
			dialog.Multiselect = False
			dialog.InitialDirectory = System.IO.Path.GetFullPath("..\..\..\..\..\..\Data")

			Dim result As DialogResult = dialog.ShowDialog()

			If result = DialogResult.OK Then
				Try
					'Load doc document from file.
					Me.docDocumentViewer1.LoadFromFile(dialog.FileName)
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End Try
			End If
		End Sub

		Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Me.docDocumentViewer1.CloseDocument()
		End Sub

		Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
			'Show a Print Dialog
			Dim dialog As New PrintDialog()
			dialog.AllowCurrentPage = True
			dialog.AllowSomePages = True
			dialog.UseEXDialog = True
			Dim result As DialogResult = dialog.ShowDialog()
			If result = DialogResult.OK Then
				Try
					'Set print parnameters.
					Me.docDocumentViewer1.PrintDialog = dialog
					'Gets the PrintDocument.
					dialog.Document = docDocumentViewer1.PrintDocument
					dialog.Document.Print()
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End Try
			End If
		End Sub
	End Class
End Namespace
