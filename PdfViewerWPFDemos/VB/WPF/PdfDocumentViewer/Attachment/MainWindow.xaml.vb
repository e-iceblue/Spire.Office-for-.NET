Imports System.Text
Imports System.IO
Imports Microsoft.Win32
Imports Spire.PdfViewer.Wpf

Namespace Attachment
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		'Load default PDF document when Window loaded
		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim pdfFileName As String = "..\..\..\..\..\..\Data\Attachment.pdf"
			If File.Exists(pdfFileName) Then
				Me.pdfDocumentViewer1.LoadFromFile(pdfFileName)
			End If

		End Sub

		'Open PDF document
		Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim dialog As New OpenFileDialog()
			dialog.Filter = "PDF document(*.pdf)|*.pdf"
			Dim dialogResult? As Boolean = dialog.ShowDialog()
			If dialogResult.HasValue AndAlso dialogResult.Value Then
				Dim pdfFileName As String = dialog.FileName
				'load PDF document
				Me.pdfDocumentViewer1.LoadFromFile(pdfFileName)
			End If

		End Sub

		'Get all of attachments from loaded PDF document 
		Private Sub btnAttachment_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			If Me.pdfDocumentViewer1.IsDocumentLoaded Then
				'Get all of attachments from loaded PDF document
				Dim attachments() As PdfDocumentAttachment = Me.pdfDocumentViewer1.GetAttachments()
				If attachments IsNot Nothing AndAlso attachments.Length > 0 Then
					'get attachment properties

					Dim view As New GridView()
					Dim column1 As New GridViewColumn()
					column1.Header = "FileName"
					Dim binding1 As New Binding("FileName")
					column1.DisplayMemberBinding = binding1
					view.Columns.Add(column1)
					Dim column2 As New GridViewColumn()
					column2.Header = "Description"
					Dim binding2 As New Binding("Description")
					column2.DisplayMemberBinding = binding2
					Dim column3 As New GridViewColumn()
					column3.Header = "MimeType"
					column3.DisplayMemberBinding = New Binding("MimeType")
					view.Columns.Add(column3)
					Dim column4 As New GridViewColumn()
					column4.Header = "CreationTime"
					column4.DisplayMemberBinding = New Binding("CreationTime")
					view.Columns.Add(column4)
					Dim column5 As New GridViewColumn()
					column5.Header = "ModifyTime"
					column5.DisplayMemberBinding = New Binding("modifyTime")
					Me.listView1.View = view
					Me.listView1.ItemsSource = attachments
					Me.listView1.Visibility = Visibility.Visible

				End If
			End If
		End Sub

		'get all of attachment annotations from loaded PDF document
		Private Sub btnAnnotation_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			If Me.pdfDocumentViewer1.IsDocumentLoaded Then
				'get all of attachment annotations from loaded PDF document
				Dim annotations() As PdfDocumentAttachmentAnnotation = Me.pdfDocumentViewer1.GetAttachmentAnnotaions()
				If annotations IsNot Nothing Then
					'get attachment annotation properties
					Dim view As New GridView()
					Dim column1 As New GridViewColumn()
					column1.Header = "FileName"
					Dim binding1 As New Binding("FileName")
					column1.DisplayMemberBinding = binding1
					view.Columns.Add(column1)
					Dim column2 As New GridViewColumn()
					column2.Header = "Text"
					Dim binding2 As New Binding("Text")
					column2.DisplayMemberBinding = binding2
					Dim column3 As New GridViewColumn()
					column3.Header = "PageIndex"
					column3.DisplayMemberBinding = New Binding("PageIndex")
					view.Columns.Add(column3)
					Dim column4 As New GridViewColumn()
					column4.Header = "Location"
					column4.DisplayMemberBinding = New Binding("Location")
					view.Columns.Add(column4)
					Dim column5 As New GridViewColumn()
					column5.Header = "Color"
					column5.DisplayMemberBinding = New Binding("Color")
					Me.listView1.View = view
					Me.listView1.ItemsSource = annotations
					Me.listView1.Visibility = Visibility.Visible

				End If
			End If
		End Sub

		'export attachment data to file
		Private Sub listView1_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
			If Me.listView1.SelectedItem IsNot Nothing AndAlso TypeOf Me.listView1.SelectedItem Is PdfDocumentAttachment Then
				Dim attachment As PdfDocumentAttachment = TryCast(Me.listView1.SelectedItem, PdfDocumentAttachment)
				Dim dialog As New SaveFileDialog()
				dialog.Filter = "All files(*.*)|*.*"
				Dim isOk? As Boolean = dialog.ShowDialog()
				If isOk.Value Then
					Dim fileName As String = dialog.FileName
					attachment.SaveAS(fileName)
					Dim info As String="Export attachment data to file: " & vbLf & fileName
					MessageBox.Show(info, "Export", MessageBoxButton.OK, MessageBoxImage.Information)
					Try
						Process.Start(fileName)
					Catch
					End Try
				End If
				Return
			End If
			If Me.listView1.SelectedItem IsNot Nothing AndAlso TypeOf Me.listView1.SelectedItem Is PdfDocumentAttachmentAnnotation Then
				Dim annotation As PdfDocumentAttachmentAnnotation = TryCast(Me.listView1.SelectedItem, PdfDocumentAttachmentAnnotation)
				Dim dialog As New SaveFileDialog()
				dialog.Filter = "All files(*.*)|*.*"
				Dim isOk? As Boolean = dialog.ShowDialog()
				If isOk.Value Then
					Dim fileName As String = dialog.FileName
					annotation.SaveAs(fileName)
					Dim info As String = "Export attachment data to file: " & vbLf & fileName
					MessageBox.Show(info, "Export", MessageBoxButton.OK, MessageBoxImage.Information)
					Try
						Process.Start(fileName)
					Catch
					End Try
				End If
				'can go to specify PdfDocumentAttachmentAnnotation instance  
				Me.pdfDocumentViewer1.GotoAttachmentAnnotation(annotation)

			End If

		End Sub

		Private Sub btnCloseAttachment_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Me.listView1.Visibility = Visibility.Collapsed
		End Sub

	End Class
End Namespace
