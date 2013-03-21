Imports System.IO
Imports Spire.PdfViewer.Forms


Namespace PdfDocumentViewer_Zoom

	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		'private bool _isZoomout = true;

		Private _zoom As Integer=100
		Private _isZoomDynamic As Boolean = False



		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim pdfDoc As String = "..\..\..\..\..\..\Data\PDFViewer.pdf"
			If File.Exists(pdfDoc) Then
				Me.pdfDocumentViewer1.LoadFromFile(pdfDoc)
			End If

			'add zoom values to combox
			Dim intZooms() As Integer = New Int32() { 25, 50, 75, 100, 125, 150, 200, 300, 400, 500, 600, 700, 800, 900, 1000 }
			For Each zoom As Integer In intZooms
				Me.comBoxZoom.Items.Add(zoom.ToString())
			Next zoom
			Me.comBoxZoom.SelectedIndex = 3

			'pdfDocumentViewer mouseWheel event

			AddHandler pdfDocumentViewer1.MouseWheel, AddressOf pdfDocumentViewer1_MouseWheel
			AddHandler pdfDocumentViewer1.LostFocus, AddressOf pdfDocumentViewer_LostFocus




		End Sub
		Private Sub pdfDocumentViewer_LostFocus(ByVal sender As Object, ByVal args As EventArgs)
			Me._isZoomDynamic = False
			Me._zoom = 100
		End Sub

		Private Sub pdfDocumentViewer1_MouseWheel(ByVal sender As Object, ByVal args As MouseEventArgs)
			If Me._isZoomDynamic Then
				Dim wheelValue As Integer= CInt(args.Delta) / 24


				Me._zoom += wheelValue

				If Me._zoom < 0 Then
					Me._zoom = 0
				End If
				Me.pdfDocumentViewer1.ZoomTo(Me._zoom)
			End If
			'else
			'{
			'    int wheelValue = -(Int32)args.Delta / 12;
			'    this._zoom += wheelValue;
			'    if (this._zoom < 0)
			'        this._zoom = 0;
			'   // MessageBox.Show(this._zoom.ToString());
			'    this.pdfDocumentViewer1.ZoomTo(this._zoom);
			'}



		End Sub

		Private Sub btnOPen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOPen.Click
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





		Private Sub comBoxZoom_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comBoxZoom.SelectedIndexChanged
			If Me.pdfDocumentViewer1.PageCount > 0 Then
				Dim zoomValue As Integer = Int32.Parse(Me.comBoxZoom.SelectedItem.ToString())
				Me.pdfDocumentViewer1.ZoomTo(zoomValue)
			End If
		End Sub

		Private Sub btnZoomOut_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnZoomOut.Click
			If Me.pdfDocumentViewer1.PageCount > 0 Then
				Dim delta As Integer = 10
				Me._zoom += delta
				Me.pdfDocumentViewer1.ZoomTo(Me._zoom)
			End If
		End Sub

		Private Sub btnZoonIn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnZoonIn.Click
			If Me.pdfDocumentViewer1.PageCount > 0 Then
				Dim delta As Integer = 5
				Me._zoom -= delta
				If Me._zoom < 0 Then
					Me._zoom = 0
				End If
				Me.pdfDocumentViewer1.ZoomTo(Me._zoom)
			End If
		End Sub

		Private Sub btnActural_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnActural.Click
			Me._zoom = 100
			Me._isZoomDynamic = False
			Me.btnDynamic.Text = "Zoom Dynamic"
			If Me.pdfDocumentViewer1.PageCount > 0 Then
				Me.pdfDocumentViewer1.ZoomTo(100)
				Me.comBoxZoom.SelectedIndex = 3
			End If
		End Sub



		Private Sub btnFitPage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFitPage.Click
			If Me.pdfDocumentViewer1.PageCount > 0 Then
				Me.pdfDocumentViewer1.ZoomTo(ZoomMode.FitPage)
			End If
		End Sub

		Private Sub btnFitWidth_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFitWidth.Click
			If Me.pdfDocumentViewer1.PageCount > 0 Then
				Me.pdfDocumentViewer1.ZoomTo(ZoomMode.FitWidth)
			End If
		End Sub

		Private Sub btnDynamic_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDynamic.Click
			Me._isZoomDynamic = Not Me._isZoomDynamic
			If Me._isZoomDynamic Then

				Me.btnDynamic.Text = "Cancel dynamic zoom"
				Me.btnDynamic.ToolTipText = "Cancel dynamic zoom"

			Else
				Me.btnDynamic.Text = "Zoom dynamic"
				Me.btnDynamic.ToolTipText = "Zoom dynamic"
			End If

		End Sub

		Private Sub pdfDocumentViewer1_PdfLoaded(ByVal sender As Object, ByVal args As EventArgs) Handles pdfDocumentViewer1.PdfLoaded
            Me.btnDynamic.Enabled = True
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
