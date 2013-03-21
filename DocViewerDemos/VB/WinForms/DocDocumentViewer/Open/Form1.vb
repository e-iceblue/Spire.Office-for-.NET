Imports System.ComponentModel
Imports System.Text

Namespace Open
	Partial Public Class Form1
		Inherits Form
		Private stream As System.IO.FileStream
		Public Sub New()
			InitializeComponent()
			Try
				' Load doc document from file.
				Me.docDocumentViewer1.LoadFromFile("..\..\..\..\..\..\Data\Summary_of_Science.docx")
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		End Sub

		Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpen.Click
			'open a DOC document
			Dim dialog As New OpenFileDialog()
			dialog.Filter = "Word97-2003 files(*.doc)|*.doc|Word2007-2010 files (*.docx)|*.docx|All files (*.*)|*.*"
			dialog.Title = "Select a DOC file"
			dialog.Multiselect = False
			dialog.InitialDirectory = System.IO.Path.GetFullPath("..\..\..\..\..\..\Data")

			Dim result As DialogResult = dialog.ShowDialog()

			If result = DialogResult.OK Then
				Try
					'Load DOC document from file.
					Me.docDocumentViewer1.LoadFromFile(dialog.FileName)
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End Try
			End If
		End Sub

		Private Sub btnOpenStream_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpenStream.Click
			'open a doc document
			Dim dialog As New OpenFileDialog()
			dialog.Filter = "Word97-2003 files(*.doc)|*.doc|Word2007-2010 files (*.docx)|*.docx|All files (*.*)|*.*"
			dialog.Title = "Select a DOC file"
			dialog.Multiselect = False
			dialog.InitialDirectory = System.IO.Path.GetFullPath("..\..\..\..\..\..\Data")

			Dim result As DialogResult = dialog.ShowDialog()

			If result = DialogResult.OK Then
				Try
					Dim docFile As String = dialog.FileName
					stream = New System.IO.FileStream(docFile, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read)
					If stream IsNot Nothing Then
						'Load doc document from stream.
						Me.docDocumentViewer1.LoadFromStream(stream, Spire.Doc.FileFormat.Auto)
					End If
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End Try
			End If
		End Sub

		Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			'Close current doc document.
			Me.docDocumentViewer1.CloseDocument()
		End Sub
	End Class
End Namespace
