Imports System.IO

Namespace PdfDocumentViewer_Save
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim pdfDoc As String = "..\..\..\..\..\..\Data\PartList.pdf"
			If File.Exists(pdfDoc) Then
				Me.pdfDocumentViewer1.LoadFromFile(pdfDoc)
			End If
		End Sub

		Private Sub BtnOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnOpen.Click
			Dim dialog As New OpenFileDialog()
			dialog.Filter = "PDF document (*.pdf)|*.pdf"
			Dim result As DialogResult = dialog.ShowDialog()
			If result = DialogResult.OK Then
				Try
					Dim pdfFile As String = dialog.FileName
					Me.pdfDocumentViewer1.LoadFromFile(pdfFile)
				Catch exe As Exception
					MessageBox.Show(exe.Message, "Spire.PdfViewer Demo", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End Try

			End If
		End Sub

		Private Sub BtnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSave.Click
			If Me.pdfDocumentViewer1.PageCount > 0 Then
				Dim dialog As New SaveFileDialog()
				dialog.Filter = "PDF document (*.pdf)|*.pdf"
				Dim result As DialogResult = dialog.ShowDialog()
				Dim fileName As String = dialog.FileName
				If result = DialogResult.OK Then
					pdfDocumentViewer1.SaveToFile(fileName)
					MessageBox.Show("You have saved this PdfDocuemnt as:" & vbLf & fileName,"Spire.PdfViewer Demo",MessageBoxButtons.OK,MessageBoxIcon.Information)
				End If


			End If
		End Sub

		Private Sub btnSaveStream_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaveStream.Click
			If Me.pdfDocumentViewer1.PageCount > 0 Then
				Dim dialog As New SaveFileDialog()
				dialog.Filter = "PDF document (*.pdf)|*.pdf"
				Dim result As DialogResult = dialog.ShowDialog()
				Dim fileName As String = dialog.FileName
				If result = DialogResult.OK Then

				   Dim stream As New MemoryStream()
				   pdfDocumentViewer1.SaveToFile(stream)
				   Dim fileBytes() As Byte = stream.ToArray()
				   Dim fileStream As New FileStream(fileName, FileMode.Create, FileAccess.ReadWrite)
				   fileStream.Write(fileBytes, 0, fileBytes.Length)
				   fileStream.Flush()
				   fileStream.Close()
				   stream.Close()
				   MessageBox.Show("You have first saved this PDF docuemnt as memory stream," & vbLf & "then write the memory stream in a file :" & vbLf & fileName,"Spire.PdfViewer Demo",MessageBoxButtons.OK,MessageBoxIcon.Information)

				End If


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
