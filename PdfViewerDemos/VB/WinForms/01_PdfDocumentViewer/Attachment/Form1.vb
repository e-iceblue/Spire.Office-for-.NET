Imports System.ComponentModel
Imports System.Text
Imports System.IO
Imports Spire.PdfViewer.Forms


Namespace Attachment
	Partial Public Class Form1
		Inherits Form
		Private m_isAttachmentAnnotation As Boolean
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.listView1.Visible = False
			Me.tableLayoutPanel1.SetRowSpan(Me.pdfDocumentViewer1, 2)
			If File.Exists("..\..\..\..\..\..\Data\Attachment.pdf") Then
				Me.pdfDocumentViewer1.LoadFromFile("..\..\..\..\..\..\Data\Attachment.pdf")
			End If
		End Sub
		''' <summary>
		''' Open PDF document
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpen.Click
			Dim dialog As New OpenFileDialog()
			dialog.Filter = "PDF document(*.pdf)|*.pdf"
			Dim result As DialogResult = dialog.ShowDialog()
			If result = DialogResult.OK Then
				Dim pdfFile As String = dialog.FileName
				Me.pdfDocumentViewer1.LoadFromFile(pdfFile)
			End If
		End Sub
		''' <summary>
		''' Read PDF document common attachments
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub btnAttachment_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAttachment.Click
			Me.tableLayoutPanel1.SetRowSpan(Me.pdfDocumentViewer1, 1)
			Me.m_isAttachmentAnnotation = False
			Me.listView1.Visible = True
			Me.listView1.Columns.Clear()
			Me.listView1.Items.Clear()
			If Me.pdfDocumentViewer1.IsDocumentLoaded Then
				'Get common attachment in PDF document
				Dim attchments() As PdfDocumentAttachment = Me.pdfDocumentViewer1.GetAttachments()
				Me.listView1.View = View.Details
				Me.listView1.Columns.Add("FileName",80)
				Me.listView1.Columns.Add("MimeType",80)
				Me.listView1.Columns.Add("Description",120)
				Me.listView1.Columns.Add("CreationTime",100)
				Me.listView1.Columns.Add("ModifyTime",100)
				If attchments IsNot Nothing AndAlso attchments.Length > 0 Then
					'get common attachment property
					For i As Integer = 0 To attchments.Length - 1
						Dim attachment As PdfDocumentAttachment = attchments(i)
						Dim fileName As String = attachment.FileName
						Dim mimeType As String = attachment.MimeType
                        Dim desc As String = attachment.Description
						Dim createDate As Date = attachment.CreationTime
						Dim modifyDate As Date = attachment.ModifyTime
						Dim data As Object = attachment.Data
						Dim item As New ListViewItem()
						item.Text = Path.GetFileName(fileName)
						item.SubItems.Add(mimeType)
						item.SubItems.Add(desc)
						item.SubItems.Add(createDate.ToShortDateString())
						item.SubItems.Add(modifyDate.ToShortDateString())
						item.Tag = attachment
						Me.listView1.Items.Add(item)
					Next i
				End If
			End If
		End Sub
		''' <summary>
		''' Read PDF document attachment annotation 
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub btnAttachmentAnnotation_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAttachmentAnnotation.Click
			Me.tableLayoutPanel1.SetRowSpan(Me.pdfDocumentViewer1, 1)
			Me.m_isAttachmentAnnotation = True
			Me.listView1.Visible = True
			Me.listView1.Items.Clear()
			Me.listView1.Columns.Clear()
			If Me.pdfDocumentViewer1.IsDocumentLoaded AndAlso Me.pdfDocumentViewer1.PageCount > 0 Then
				Me.listView1.View = View.Details
				Me.listView1.Columns.Add("FileName",200)
				Me.listView1.Columns.Add("Text",180)
				Me.listView1.Columns.Add("PageIndex",80)
				Me.listView1.Columns.Add("Location",160)
				'Get attachment annotations in PDF document
				Dim annotations() As PdfDocumentAttachmentAnnotation = Me.pdfDocumentViewer1.GetAttachmentAnnotaions()
				If annotations IsNot Nothing AndAlso annotations.Length > 0 Then
					'read attachment annotation property
					For i As Integer = 0 To annotations.Length - 1
						Dim annotation As PdfDocumentAttachmentAnnotation = annotations(i)
						Dim item As New ListViewItem(annotation.FileName)
						item.SubItems.Add(annotation.Text)
						item.SubItems.Add(annotation.PageIndex.ToString())
						item.SubItems.Add(annotation.Location.ToString())
						item.Tag = annotation
						Me.listView1.Items.Add(item)
					Next i
				End If

			End If
		End Sub
		''' <summary>
		''' Go to Specified attachment annotation
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub listView1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles listView1.Click
			If Me.m_isAttachmentAnnotation Then
				Dim annotation As PdfDocumentAttachmentAnnotation = CType(Me.listView1.SelectedItems(0).Tag, PdfDocumentAttachmentAnnotation)
				Me.pdfDocumentViewer1.GotoAttachmentAnnotation(annotation)
			End If
		End Sub
		''' <summary>
		''' Export PDF document attachment
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub listView1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles listView1.DoubleClick
			Dim item As ListViewItem = Me.listView1.SelectedItems(0)
			Dim dialog As New SaveFileDialog()
			Dim result As DialogResult = dialog.ShowDialog()
			If result = DialogResult.OK Then
				Dim fileName As String = dialog.FileName
				Dim stream As New FileStream(fileName, FileMode.Create)
				Dim writer As New BinaryWriter(stream)
				If Me.m_isAttachmentAnnotation Then
					Dim annotation As PdfDocumentAttachmentAnnotation = CType(item.Tag, PdfDocumentAttachmentAnnotation)
					Dim data() As Byte = annotation.Data
					writer.Write(data)
				Else
					Dim annotation As PdfDocumentAttachment = CType(item.Tag, PdfDocumentAttachment)
					Dim data() As Byte = annotation.Data
					writer.Write(data)
				End If

				writer.Close()
				stream.Close()
				Process.Start(fileName)

			End If
		End Sub

		Private Sub BtnCloseAttachment_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCloseAttachment.Click
			Me.listView1.Visible = False
			Me.tableLayoutPanel1.SetRowSpan(Me.pdfDocumentViewer1, 2)
		End Sub


	End Class
End Namespace
