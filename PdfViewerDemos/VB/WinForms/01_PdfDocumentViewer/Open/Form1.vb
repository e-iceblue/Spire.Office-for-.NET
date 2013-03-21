Imports System.IO
Imports Spire.PdfViewer.Forms

Namespace PdfViewer_Open
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim pdfDoc As String = "..\..\..\..\..\..\Data\Spire.Office.pdf"
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

		Private Sub BtnOpenStream_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnOpenStream.Click
			Dim dialog As New OpenFileDialog()
			dialog.Filter = "PDF document (*.pdf)|*.pdf"
			Dim result As DialogResult = dialog.ShowDialog()
			If result = DialogResult.OK Then
				
                Try
                    Dim pdfFile As String = dialog.FileName
                    Dim thestream As New FileStream(pdfFile, FileMode.Open, FileAccess.Read, FileShare.Read)
                    thestream.Position = 0
                    pdfDocumentViewer1.LoadFromStream(thestream)
                    MessageBox.Show("Open PDF document from data stream success!", "Spire.PdfViewer Demo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch exe As IOException
                    MessageBox.Show("Error occurrs!" & vbLf & exe.Message, "Spire.PdfViewer Demo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try


            End If
		End Sub

		Private Sub BtnOpenPass_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnOpenPass.Click
			Dim dialog As New OpenFileDialog()
			dialog.Filter = "PDF document (*.pdf)|*.pdf"

			Dim result As DialogResult = dialog.ShowDialog()
			 Dim pdfFile As String = dialog.FileName
			If result = DialogResult.OK Then

				Try

					Me.pdfDocumentViewer1.LoadFromFile(pdfFile)
				Catch exe As Exception
					Do
						Dim passError As String = " password is invalid"
						Dim message As String = exe.Message
						If message.IndexOf(passError) > -1 Then
							Dim info As String = pdfFile & " has password !" & vbLf & " You  need input its password!"
							Dim dlg As New passwordDlg()

						   Dim dlgResult As DialogResult= dlg.ShowDialog()
						   If dlgResult = DialogResult.Cancel Then
							   Exit Do
						   End If
							Dim pass As String = dlg.getPass()
							If Not String.IsNullOrEmpty(pass) Then
								Try
									Me.pdfDocumentViewer1.LoadFromFile(pdfFile, pass)
									dlg.Dispose()
									Exit Do
								Catch exc As Exception
									dlg.Dispose()
								End Try
							End If
						End If
					Loop
				End Try


			End If

		End Sub



		Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Me.pdfDocumentViewer1.PageCount > 0 Then
				Me.pdfDocumentViewer1.CloseDocument()
			End If
		End Sub

		Private Sub btnClose_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Me.pdfDocumentViewer1.CloseDocument()

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
