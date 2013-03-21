Imports System.IO
Imports Microsoft.Win32
Imports Spire.Doc



Namespace MailMergeWPF
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Private saveFileDialog As SaveFileDialog = Nothing
		Public Sub New()
			InitializeComponent()
			Me.saveFileDialog = New SaveFileDialog()
			Me.saveFileDialog.Filter = "Word Document (*.doc)|*.doc"
		End Sub
		Private Sub buttonMerge_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'new Document
			Dim doc As New Document()
			doc.LoadFromFile("..\..\..\..\..\Data\Fax.doc")

			Dim fieldNames() As String = { "Contact Name", "Fax", "From", "Date", "Subject", "Content" }
			Dim faxDate As Date = If(Me.datePickerFaxDate.SelectedDate.HasValue, Me.datePickerFaxDate.SelectedDate.Value, Date.Now)
			Dim fieldValues() As String = { Me.textBoxTo.Text, Me.textBoxFax.Text, Me.textBoxFrom.Text, faxDate.ToShortDateString(), Me.textBoxSubject.Text, Me.textBoxContent.Text }
			doc.MailMerge.Execute(fieldNames, fieldValues)

			Dim result? As Boolean = Me.saveFileDialog.ShowDialog()
			If result.HasValue AndAlso result.Value Then
				Using stream As Stream = Me.saveFileDialog.OpenFile()
					doc.SaveToStream(stream, FileFormat.Doc)
					doc.Close()
				End Using
			End If
		End Sub
	End Class
End Namespace
