Imports System.ComponentModel
Imports System.IO
Imports System.Text
Imports Spire.PdfViewer.Forms

Namespace Bookmark
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			If File.Exists("..\..\..\..\..\..\Data\BigBookmark.pdf") Then
				Me.pdfDocumentViewer1.LoadFromFile("..\..\..\..\..\..\Data\BigBookmark.pdf")
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

		Private Sub pdfDocumentViewer1_PdfLoaded(ByVal sender As Object, ByVal args As EventArgs) Handles pdfDocumentViewer1.PdfLoaded
			Me.LoadBookmarks()

		End Sub

		''' <summary>
		''' Load PDF document bookmark
		''' </summary>
		Private Sub LoadBookmarks()
			If Me.pdfDocumentViewer1.IsDocumentLoaded Then
				Dim container As PdfDocumentBookmarkContainer = Me.pdfDocumentViewer1.GetBookmarkContainer()
				If container Is Nothing Then
					MessageBox.Show("Current PDF document has not bookmarks")
					Return
				End If
				Me.treeViewBookmark.Nodes.Clear()
				Dim bookmarks() As PdfDocumentBookmark = container.Childs
				For i As Integer = 0 To bookmarks.Length - 1
					Dim bookmark As PdfDocumentBookmark = bookmarks(i)

					Dim node As New TreeNode()
					Dim title As String = bookmark.Title
					node.Text = title
					node.ForeColor = bookmark.Color
					Dim style As FontStyle = CType(bookmark.Style, FontStyle)
					Dim font As Font = Me.treeViewBookmark.Font
					node.NodeFont = New Font(font, style)
					node.Tag = bookmark
					Me.treeViewBookmark.Nodes.Add(node)
					Me.LoadChidNode(node)

				Next i

			End If
		End Sub
		''' <summary>
		''' Load specified bookmark children bookmark
		''' </summary>
		''' <param name="node"></param>
		Private Sub LoadChidNode(ByVal node As TreeNode)
			Dim bookmark As PdfDocumentBookmark = TryCast(node.Tag, PdfDocumentBookmark)
			Dim childCount As Integer = bookmark.Children.Count
			If childCount > 0 Then
				For i As Integer = 0 To childCount - 1
					Dim childBookmark As PdfDocumentBookmark = bookmark.Children(i)
					Dim childNode As New TreeNode()
					childNode.Text = childBookmark.Title
					childNode.ForeColor = childBookmark.Color
					Dim style As FontStyle = CType(bookmark.Style, FontStyle)
					Dim font As Font = Me.treeViewBookmark.Font
					childNode.NodeFont = New Font(font, style)
					childNode.Tag = childBookmark
					node.Nodes.Add(childNode)
					LoadChidNode(childNode)
				Next i

			End If
		End Sub
		''' <summary>
		''' Go to PDF document bookmark
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub treeViewBookmark_AfterSelect(ByVal sender As Object, ByVal e As TreeViewEventArgs) Handles treeViewBookmark.AfterSelect
			Dim node As TreeNode = e.Node
			Dim bookmark As PdfDocumentBookmark = CType(node.Tag, PdfDocumentBookmark)
			Me.pdfDocumentViewer1.GoToBookmark(bookmark)

		End Sub
		''' <summary>
		''' Zoom PDF document
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub btnZoom_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnZoom.Click
			If Me.pdfDocumentViewer1.IsDocumentLoaded Then
				Dim zoomPercent As Integer=0
				Dim isNummeric As Boolean = Integer.TryParse(Me.txtZoomPercent.Text, zoomPercent)
				If isNummeric Then
					Me.pdfDocumentViewer1.ZoomTo(Math.Abs(zoomPercent))
				End If

			End If

		End Sub


	End Class
End Namespace
