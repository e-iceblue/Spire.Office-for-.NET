Imports System
Imports System.IO
Imports System.Net
Imports System.Reflection
Imports System.Windows
Imports System.Windows.Controls

Imports Spire.Doc

Partial Public Class MainPage
    Inherits UserControl

    Private saveFileDialog As SaveFileDialog
    Private documentTemplate As Document

    Private WithEvents webClient As WebClient

    Public Sub New()
        InitializeComponent()
        Me.saveFileDialog = New SaveFileDialog()
        Me.saveFileDialog.Filter = "Word Document (*.doc)|*.doc"
    End Sub

    Private Sub LayoutRoot_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        Dim baseUri As Uri = App.Current.Host.Source
        If "file" = baseUri.Scheme Then
            Dim assembly As Assembly = Me.[GetType]().Assembly
            For Each name As [String] In assembly.GetManifestResourceNames()
                If name.EndsWith(".Fax.doc") Then
                    Using docStream As Stream = assembly.GetManifestResourceStream(name)
                        Me.documentTemplate = New Document(docStream, FileFormat.Doc)
                    End Using
                    Me.buttonMerge.IsEnabled = True
                End If
            Next
        Else
            Dim docUri As New Uri(baseUri, "../Fax.doc")

            webClient = New WebClient()
            webClient.AllowReadStreamBuffering = True
            webClient.OpenReadAsync(docUri)
        End If
    End Sub

    Private Sub DownloadFileCompleted(ByVal sender As Object, ByVal e As OpenReadCompletedEventArgs) Handles webClient.OpenReadCompleted
        Using docStream As Stream = e.Result
            Me.documentTemplate = New Document(docStream, FileFormat.Doc)
        End Using
        Me.buttonMerge.IsEnabled = True
    End Sub

    Private Sub buttonMerge_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        Dim fieldNames As [String]() = _
            New [String]() {"Contact Name", "Fax", "From", "Date", "Subject", "Content"}
        Dim faxDate As DateTime = DateTime.Now
        If Me.datePickerFaxDate.SelectedDate.HasValue Then
            faxDate = Me.datePickerFaxDate.SelectedDate.Value
        End If

        Dim fieldValues As [String]() = _
            New [String]() {Me.textBoxTo.Text, Me.textBoxFax.Text, Me.textBoxFrom.Text, _
                            faxDate.ToShortDateString(), Me.textBoxSubject.Text, Me.textBoxContent.Text}
        Me.documentTemplate.MailMerge.Execute(fieldNames, fieldValues)

        Dim result As System.Nullable(Of Boolean) = Me.saveFileDialog.ShowDialog()
        If result.HasValue AndAlso result.Value Then
            Using stream As Stream = Me.saveFileDialog.OpenFile()
                Me.documentTemplate.SaveToStream(stream, FileFormat.Doc)
            End Using
        End If
    End Sub
End Class