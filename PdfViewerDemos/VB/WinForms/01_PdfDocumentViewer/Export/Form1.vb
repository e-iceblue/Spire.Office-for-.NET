Imports System.IO

Namespace PdfDocumentViewer_Export
	Partial Public Class Form1
		Inherits Form
		Private _formImages As FormImages

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim pdfDoc As String = "..\..\..\..\..\..\Data\PDFViewer.pdf"
			If File.Exists(pdfDoc) Then
				Me.pdfDocumentViewer1.LoadFromFile(pdfDoc)
			End If
		End Sub

		Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpen.Click
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

		Private Sub btnExport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExport.Click
			If Me.pdfDocumentViewer1.PageCount>0 Then
				Dim dialog As New SaveFileDialog()
				dialog.Filter="JPG Format(*.jpg)|*.jpg|BMP Format(*.bmp)|*.bmp|PNG Format(*.png)|*.png|GIF Format(*.gif)|*.gif"
				Dim result As DialogResult=dialog.ShowDialog()
				Dim fileName As String=dialog.FileName
				If result=DialogResult.OK Then

					Dim currentPage As Integer=Me.pdfDocumentViewer1.CurrentPageNumber
					Dim image As Bitmap=Me.pdfDocumentViewer1.SaveAsImage(currentPage-1)
					image.Save(fileName)
					MessageBox.Show("You have exported current page to an image:" & vbLf & fileName,"Spire.PdfViewer Demo",MessageBoxButtons.OK,MessageBoxIcon.Information)


					Dim dictionaryImages As New Dictionary(Of String, Image)()
					dictionaryImages.Add(fileName, image)

					Me._formImages = New FormImages()
					Me._formImages.DictionaryImages = dictionaryImages
					Me._formImages.Show()






				End If
			End If

		End Sub

		Private Sub pdfDocumentViewer1_PdfLoaded(ByVal sender As Object, ByVal args As EventArgs) Handles pdfDocumentViewer1.PdfLoaded
			Me.comBoxFrom.Items.Clear()
			Me.comboxTo.Items.Clear()

			Dim totalPage As Integer = Me.pdfDocumentViewer1.PageCount
			For i As Integer = 1 To totalPage
				Me.comBoxFrom.Items.Add(i.ToString())
				Me.comboxTo.Items.Add(i.ToString())


			Next i
			Me.comBoxFrom.SelectedIndex = 0
			Me.comboxTo.SelectedIndex = 0

		End Sub

		Private Sub btnMultiExport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMultiExport.Click


			If Me.pdfDocumentViewer1.PageCount <= 0 Then
				Return
			End If

			Dim fromPage As Integer = Me.comBoxFrom.SelectedIndex
			Dim toPage As Integer = Me.comboxTo.SelectedIndex
			If fromPage > toPage Then
				MessageBox.Show("End page number must be not less than started page number!", "Spire.PdfViewer Demo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Return
			Else
				Dim dialog As New FolderBrowserDialog()


				Dim result As DialogResult = dialog.ShowDialog()
				If result = DialogResult.OK Then

					Dim path As String = dialog.SelectedPath
					Dim images() As Bitmap = Me.pdfDocumentViewer1.SaveAsImage(fromPage, toPage)
					Dim dictionaryImages As New Dictionary(Of String, Image)()
					For i As Integer = 0 To images.Length - 1
						Dim name As String = "image" & (i + 1 + fromPage).ToString() & ".bmp"
						Dim fileName As String = path & "\" & name
						images(i).Save(fileName)
						dictionaryImages.Add(fileName, images(i))

					Next i
					Dim message As String = "You have exported " & (fromPage+1).ToString() & "-" & (toPage+1).ToString() & " pages as images to:" & vbLf & path
					MessageBox.Show(message,"Spire.PdfViewer Demo",MessageBoxButtons.OK,MessageBoxIcon.Information)

					Me._formImages = New FormImages()
					Me._formImages.DictionaryImages = dictionaryImages
					Me._formImages.Show()




				End If
			End If

		End Sub







	End Class
End Namespace
