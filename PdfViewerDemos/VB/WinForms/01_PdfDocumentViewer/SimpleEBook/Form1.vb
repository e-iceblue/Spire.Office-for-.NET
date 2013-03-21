Imports System.ComponentModel
Imports System.IO
Imports System.Text

Namespace SimpleEBook_VS2010
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            If File.Exists("..\..\..\..\..\..\Data\Le_Petit_Prince_French.pdf") Then
                Me.pdfDocumentViewer1.LoadFromFile("..\..\..\..\..\..\Data\Le_Petit_Prince_French.pdf")
                'Set viewer mode as single page mode
                Me.pdfDocumentViewer1.SetViewerMode(Spire.PdfViewer.Forms.PdfViewerMode.PdfViewerMode.SinglePage)

            End If

        End Sub
        ''' <summary>
        ''' Open PDF document
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpen.Click
            Dim dialog As New OpenFileDialog()
            Dim result As DialogResult = dialog.ShowDialog()
            If result = DialogResult.OK Then
                Dim pdfDocument As String = dialog.FileName
                Me.pdfDocumentViewer1.LoadFromFile(pdfDocument)
                'Set viewer mode as single page mode
                Me.pdfDocumentViewer1.SetViewerMode(Spire.PdfViewer.Forms.PdfViewerMode.PdfViewerMode.SinglePage)
            End If
        End Sub
        ''' <summary>
        ''' Go to first page
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub linkLabelFirst_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles linkLabelFirst.LinkClicked
            If Me.pdfDocumentViewer1.IsDocumentLoaded Then
                Me.pdfDocumentViewer1.GoToFirstPage()
            End If
        End Sub
        ''' <summary>
        ''' Go to previous page
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub linkLabelPrevious_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles linkLabelPrevious.LinkClicked
            If Me.pdfDocumentViewer1.IsDocumentLoaded Then
                Me.pdfDocumentViewer1.GoToPreviousPage()
            End If
        End Sub


        ''' <summary>
        ''' Go to next page
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub linkLableNext_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles linkLableNext.LinkClicked
            If Me.pdfDocumentViewer1.IsDocumentLoaded Then
                Me.pdfDocumentViewer1.GoToNextPage()
            End If
        End Sub

        Private Sub linkLabelLast_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles linkLabelLast.LinkClicked
            If Me.pdfDocumentViewer1.IsDocumentLoaded Then
                Me.pdfDocumentViewer1.GoToLastPage()
            End If
        End Sub

        Private Sub pdfDocumentViewer1_PageNumberChanged(ByVal sender As Object, ByVal args As EventArgs) Handles pdfDocumentViewer1.PageNumberChanged
            Me.txtPage.Text = Me.pdfDocumentViewer1.CurrentPageNumber.ToString()
        End Sub
        ''' <summary>
        ''' Go to specified page
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub txtPage_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtPage.KeyDown
            If e.KeyCode = Keys.Enter Then
                Dim pageNumber As Integer = 0
                Dim isNumeric As Boolean = Integer.TryParse(txtPage.Text.Trim(), pageNumber)
                If isNumeric Then
                    Me.pdfDocumentViewer1.GoToPage(Math.Abs(pageNumber))
                End If
            End If
        End Sub



    End Class
End Namespace
