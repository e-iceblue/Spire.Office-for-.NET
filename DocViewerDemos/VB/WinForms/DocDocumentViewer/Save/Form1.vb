Imports System.ComponentModel
Imports System.Text

Namespace Save
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			Try
				' Load DOC document from file.
				Me.docDocumentViewer1.LoadFromFile("..\..\..\..\..\..\Data\fax.doc")
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try

		End Sub

		Private Sub bntOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bntOpen.Click
			'Open a doc document          
			Dim dialog As New OpenFileDialog()
			dialog.Filter = "Word97-2003 files(*.doc)|*.doc|Word2007-2010 files (*.docx)|*.docx|All files (*.*)|*.*"
			dialog.Title = "Select a DOC file"
			dialog.Multiselect = False
			dialog.InitialDirectory = System.IO.Path.GetFullPath("..\..\..\..\..\..\Data")

			Dim result As DialogResult = dialog.ShowDialog()

			If result = DialogResult.OK Then
				Try
					Me.docDocumentViewer1.LoadFromFile(dialog.FileName)
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End Try
			End If
		End Sub

		Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Me.docDocumentViewer1.CloseDocument()
		End Sub

		Private Sub btnSaveToPdf_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaveToPdf.Click
			Dim savefile As New SaveFileDialog()
			savefile.Filter = "Pdf Document(*.pdf)|*.pdf"
			savefile.Title = "Save"

			Dim result As DialogResult = savefile.ShowDialog()
			If result = DialogResult.OK Then
				Try
					'Save PDF documetns
					Me.docDocumentViewer1.SaveAs(savefile.FileName)
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End Try
			End If
		End Sub

		Private Sub btnSaveasToDoc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaveasToDoc.Click
			Dim savefile As New SaveFileDialog()
			savefile.Filter = "Word97-2003 Document(*.doc)|*.doc"
			savefile.Title = "Save to Word97-2003"

			Dim result As DialogResult = savefile.ShowDialog()

			If result = DialogResult.OK Then
				Try
					'Save as Word97-2003 documetns
					Me.docDocumentViewer1.SaveAs(savefile.FileName)
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End Try
			End If
		End Sub

		Private Sub btnSaveasToDocx_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaveasToDocx.Click
			Dim savefile As New SaveFileDialog()
			savefile.Filter = "Word2007-2010 Document(*.docx)|*.docx"
			savefile.Title = "Save to Word2007-2010"

			Dim result As DialogResult = savefile.ShowDialog()

			If result = DialogResult.OK Then
				Try
					'Save as Word2007-2010 documetns
					Me.docDocumentViewer1.SaveAs(savefile.FileName)
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End Try
			End If
		End Sub
	End Class
End Namespace
