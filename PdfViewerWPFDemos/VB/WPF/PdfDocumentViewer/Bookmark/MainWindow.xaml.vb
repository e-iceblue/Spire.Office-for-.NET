Imports System.Text
Imports System.IO
Imports Microsoft.Win32
Imports Spire.PdfViewer.Wpf

Namespace Bookmark
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim pdfFileName As String = "..\..\..\..\..\..\Data\bookmark.pdf"
			If File.Exists(pdfFileName) Then
				Me.pdfDocumentViewer1.LoadFromFile(pdfFileName)
			End If

		End Sub

		Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim dialog As New OpenFileDialog()
			dialog.Filter = "PDF document(*.pdf)|*.pdf"
			Dim dlgResult? As Boolean = dialog.ShowDialog()
			If dlgResult.HasValue AndAlso dlgResult.Value Then
				Dim pdfFileName As String = dialog.FileName
				Me.pdfDocumentViewer1.LoadFromFile(pdfFileName)
			End If


		End Sub

		Private Sub TreeView_SelectedItemChanged(ByVal sender As Object, ByVal e As RoutedPropertyChangedEventArgs(Of Object))
			Dim node As TreeViewItem = CType(e.NewValue, TreeViewItem)
			If node Is Nothing Then
				Return
			End If
			Dim bookmark As PdfDocumentBookmark = TryCast(node.Tag, PdfDocumentBookmark)
			If Me.pdfDocumentViewer1.IsDocumentLoaded Then
				Me.pdfDocumentViewer1.GoToBookmark(bookmark)
			End If
		End Sub

		Private Sub pdfDocumentViewer1_PdfLoaded(ByVal sender As Object, ByVal args As EventArgs)
			If Me.pdfDocumentViewer1.IsDocumentLoaded Then
				Dim container As PdfDocumentBookmarkContainer = Me.pdfDocumentViewer1.GetBookmarkContainer()
				If container Is Nothing Then
					MessageBox.Show("Current PDF document has not bookmarks")
					Return
				End If
				Me.treeView1.Items.Clear()
				Dim bookmarks() As PdfDocumentBookmark = container.Childs
				If bookmarks.Length > 0 Then
					For i As Integer = 0 To bookmarks.Length - 1
						Dim bookmark As PdfDocumentBookmark = bookmarks(i)
						Dim node As New TreeViewItem()
						node.Header = bookmark.Title
                        Dim fontColor As System.Windows.Media.Color = bookmark.Color
						node.Foreground = New SolidColorBrush(fontColor)
						node.Tag = bookmark
						Me.LoadChidNode(node)
						Me.treeView1.Items.Add(node)


					Next i
				End If

			End If
		End Sub

		Private Sub LoadChidNode(ByVal node As TreeViewItem)
			Dim bookmark As PdfDocumentBookmark = TryCast(node.Tag, PdfDocumentBookmark)
			Dim childCount As Integer = bookmark.Children.Count
			If childCount > 0 Then
				For i As Integer = 0 To childCount - 1
					Dim childBookmark As PdfDocumentBookmark = bookmark.Children(i)
					Dim childNode As New TreeViewItem()
					childNode.Header = childBookmark.Title
					childNode.Foreground = New SolidColorBrush(childBookmark.Color)
					childNode.Tag = childBookmark
					node.Items.Add(childNode)
					Me.LoadChidNode(childNode)
				Next i

			End If


		End Sub


	End Class
End Namespace
