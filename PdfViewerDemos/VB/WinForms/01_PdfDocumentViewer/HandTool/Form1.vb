Imports System.ComponentModel
Imports System.IO
Imports System.Text

Namespace HandTool
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            If File.Exists("..\..\..\..\..\..\Data\Lslam.pdf") Then
                Me.pdfDocumentViewer1.LoadFromFile("..\..\..\..\..\..\Data\Lslam.pdf")
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
			End If
		End Sub
		''' <summary>
		''' Enable hand tool
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub btnHandTool_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnHandTool.Click
			If Me.pdfDocumentViewer1.IsDocumentLoaded Then
				Me.pdfDocumentViewer1.EnableHandTool()
			End If
		End Sub
		''' <summary>
		''' Escape hand hand tool
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
			If Me.pdfDocumentViewer1.IsDocumentLoaded Then
				Me.pdfDocumentViewer1.EscapeHandTool()
			End If
		End Sub
		''' <summary>
		''' Zoom PDF document
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub btnZoom_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnZoom.Click
			If Me.pdfDocumentViewer1.IsDocumentLoaded Then
				Dim zoomPercent As Integer = 0
				Dim isNumberic As Boolean = Integer.TryParse(Me.txtZoom.Text, zoomPercent)
				If isNumberic Then
					Me.pdfDocumentViewer1.ZoomTo(zoomPercent)
				End If

			End If

		End Sub


	End Class
End Namespace
