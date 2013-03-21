Imports System.Text

Imports Microsoft.Win32
Imports Spire.PdfViewer.Wpf
Imports Spire.PdfViewer

Namespace PdfDocumentViewer_Open
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Private stream As System.IO.FileStream
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'open a pdf document
			Dim dialog As New OpenFileDialog() With {.Filter = "Pdf document(*.Pdf)|*.pdf", .Title = "Open Pdf Document", .Multiselect = False, .InitialDirectory =System.IO.Path.GetFullPath("..\..\..\..\..\..\Data")}
			Dim result? As Boolean = dialog.ShowDialog()
			If result.Value Then
				Try
					'Load pdf document from file.
					Me.pdfDocumentViewer1.LoadFromFile(dialog.FileName)
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error)
				End Try
			End If
		End Sub

		Private Sub btnOpenSteam_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'open a pdf document
			Dim dialog As New OpenFileDialog() With {.Filter = "Pdf document(*.Pdf)|*.pdf", .Title = "Open Pdf Document", .Multiselect = False, .InitialDirectory =System.IO.Path.GetFullPath("..\..\..\..\..\..\Data")}
			Dim result? As Boolean = dialog.ShowDialog()
			If result.Value Then
				Try
					Dim pdfFile As String = dialog.FileName
					stream = New System.IO.FileStream(pdfFile, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read)
					If stream IsNot Nothing Then
						'Load pdf document from stream.
						Me.pdfDocumentViewer1.LoadFromStream(stream)
					End If
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error)
				End Try
			End If
		End Sub

		Private Sub btnEncrypte_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'open a pdf document
			Dim dialog As New OpenFileDialog() With {.Filter = "Pdf document(*.Pdf)|*.pdf", .Title = "Open Pdf Document", .Multiselect = False, .InitialDirectory =System.IO.Path.GetFullPath("..\..\..\..\..\..\Data")}
			Dim result? As Boolean = dialog.ShowDialog()
			Dim pdfFile As String = dialog.FileName
			If result.Value Then
				Try
					'Load pdf document from file.
					Me.pdfDocumentViewer1.LoadFromFile(pdfFile)
				Catch ex As Exception
					Do
						Dim passError As String = " password is invalid"
						Dim message As String = ex.Message
						If message.IndexOf(passError) > -1 Then
							Dim info As String = pdfFile & " has password! " & vbLf & vbCr & " You need input it's password!"

							Dim passwordDialog As New PasswordDlg()

							Dim dlgResult? As Boolean = passwordDialog.ShowDialog()
							If Not dlgResult.Value Then
								Exit Do
							End If
							Dim password As String = passwordDialog.getPass()
							If Not String.IsNullOrEmpty(password) Then
								passwordDialog.Close()
								Try
									'Open encryption pdf document from file.
									Me.pdfDocumentViewer1.LoadFromFile(pdfFile, password)
									Exit Do
								Catch ex1 As Exception
									MessageBox.Show(ex1.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error)
								End Try
							End If
						End If
					Loop
				End Try
			End If
		End Sub

		Private Sub btnClose_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'Close current pdf document.
			pdfDocumentViewer1.CloseDocument()
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Try
				' Load pdf document from file.
				Me.pdfDocumentViewer1.LoadFromFile("..\..\..\..\..\..\Data\Sample1.pdf")
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error)
			End Try
		End Sub
	End Class
End Namespace
