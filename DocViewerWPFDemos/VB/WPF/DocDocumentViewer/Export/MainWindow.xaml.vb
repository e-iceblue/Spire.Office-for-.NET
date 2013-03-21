Imports System.Text
Imports Microsoft.Win32

Namespace DocDocumentViewer_Export
	''' <summary>
	''' 
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Shared bitMap As New Dictionary(Of String, BitmapSource)()
		Public Shared m_CurrentPageNum As Integer = 0
		Public Sub New()
			InitializeComponent()
			AddHandler docDocumentViewer1.PageNumberChanged, AddressOf docDocumentViewer1_PageNumberChanged
			AddHandler docDocumentViewer1.DocLoaded, AddressOf docDocumentViewer1_DocLoaded
			Me.textBox1.IsEnabled = ckbFrom.IsChecked.Value
			Me.textBox2.IsEnabled = ckbTo.IsChecked.Value
		End Sub

		Private Sub docDocumentViewer1_DocLoaded(ByVal sender As Object, ByVal args As EventArgs)
			Me.textBox2.Text = Me.docDocumentViewer1.PageCount.ToString()
		End Sub

		Private Sub docDocumentViewer1_PageNumberChanged(ByVal sender As Object, ByVal args As EventArgs)
			textBox1.Text = Me.docDocumentViewer1.CurrentPageNumber.ToString()
		End Sub

		Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'Open a Doc Document
			Dim dialog As OpenFileDialog = New OpenFileDialog With {.Filter = "Word97-2003 files(*.doc)|*.doc|Word2007-2010 files (*.docx)|*.docx|All files (*.doc;*.docx)|*.doc;*.docx", .Title = "Select a DOC file", .Multiselect = False, .InitialDirectory = System.IO.Path.GetFullPath("..\..\..\..\..\..\Data")}
			Dim boolVar? As Boolean = dialog.ShowDialog().Value
			If boolVar.Value Then
				Try
					' Load doc document from file.
					Me.docDocumentViewer1.LoadFromFile(dialog.FileName)
					Me.textBox2.Text = Me.docDocumentViewer1.PageCount.ToString()
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error)
				End Try
			End If
		End Sub

		Private Sub ckbHandTool_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			docDocumentViewer1.EnableHandTools = ckbHandTool.IsChecked.Value
		End Sub

		Private Sub btnSaveImage_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Me.IsEnabled = False
			bitMap.Clear()
			Try
				If ckbFrom.IsChecked.Value AndAlso ckbTo.IsChecked.Value Then
					Try
						Dim startIndex As Integer = 0
						Integer.TryParse(textBox1.Text, startIndex)
						m_CurrentPageNum = startIndex
						Dim endIndex As Integer = 0
						Integer.TryParse(textBox2.Text, endIndex)

						' Exports the specified pages as Images
						Dim bitmapsource() As BitmapSource = Me.docDocumentViewer1.SaveImage(CUShort(startIndex), CUShort(endIndex))
						SaveImageToFile(bitmapsource)
					Catch ex As Exception
						MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error)
					End Try
				ElseIf ckbFrom.IsChecked.Value AndAlso (Not ckbTo.IsChecked.Value) Then
					Try
						Dim currepageIndex As Integer = 0
						Integer.TryParse(textBox1.Text, currepageIndex)
						m_CurrentPageNum = currepageIndex
						'Saves the specified page as Image
						Dim bitmapsource As BitmapSource = Me.docDocumentViewer1.SaveImage(CUShort(currepageIndex))
						SaveImageToFile(New BitmapSource() { bitmapsource })
					Catch ex As Exception
						MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error)
					End Try
				End If
			Catch
			End Try
			ShowImage()
			Me.IsEnabled = True
		End Sub

		Private Sub ckbTo_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			textBox2.IsEnabled = ckbTo.IsChecked.Value
		End Sub

		Private Sub SaveImageToFile(ByVal bitmpaSource() As BitmapSource)
			Dim startIndex As Integer = 1
			Integer.TryParse(textBox1.Text, startIndex)
			For Each bitmap As BitmapSource In bitmpaSource
				WriteBitmapSourecToFile(bitmap, startIndex)
				startIndex += 1
			Next bitmap
		End Sub

		' <summary>
		' BitmapSource Write to File
		' </summary>
		' <param name="bitMapImg">bitmapSource </param>
		Private Sub WriteBitmapSourecToFile(ByVal bitMapImg As BitmapSource, ByVal currentPageIndex As Integer)
			Try
				If bitMapImg IsNot Nothing Then
					Dim [date] As String = Date.Now.ToShortDateString().Replace("-", "").Replace("/", "").Replace(".", "")
					Dim path As String = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName)
					Dim dirPathFullname As String = path & "\" & [date] & "\"
					Dim filename As String = System.IO.Path.GetFileNameWithoutExtension(Me.docDocumentViewer1.FileName)
					Dim FullfileName As String = dirPathFullname & filename & "_" & currentPageIndex.ToString() & ".png"

					If Not System.IO.Directory.Exists(dirPathFullname) Then
						System.IO.Directory.CreateDirectory(dirPathFullname)
					End If

					Dim fs As New System.IO.FileStream(FullfileName, System.IO.FileMode.Create)
					Dim encoder As BitmapEncoder = New PngBitmapEncoder()
					encoder.Frames.Add(BitmapFrame.Create(bitMapImg))
					encoder.Save(fs)
					fs.Close()

					bitMap.Add(FullfileName, bitMapImg)
				End If
			Catch ex As Exception
#If DEBUG Then
				Debug.WriteLine(ex.Message + ex.Source)
#End If
			End Try
		End Sub

		' <summary>
		' Show ImageViewer Window
		' </summary>
		Private Sub ShowImage()
			Dim count As Integer = bitMap.Count
			If count > 0 Then
				Dim iv As New ImageViewer()
				iv.ShowDialog()
			End If
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Try
				' Load doc document from file.
				Me.docDocumentViewer1.LoadFromFile("..\..\..\..\..\..\Data\PartList.docx")
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error)
			End Try
		End Sub
	End Class
End Namespace
