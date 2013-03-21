Imports System.Text

Imports Microsoft.Win32

Namespace Save
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			'Open a doc document          
			Dim dialog As New OpenFileDialog() With {.Filter = "Doc document(*.doc;*.docx)|*.doc;*.docx|All files(*.*)|*.*", .Title = "Open doc Document", .Multiselect = False, .InitialDirectory = System.IO.Path.GetFullPath("..\..\..\..\..\..\Data")}
			Dim result? As Boolean = dialog.ShowDialog()
			If result.Value Then
				Try
					Me.docDocumentViewer1.LoadFromFile(dialog.FileName)
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error)
				End Try
			End If
		End Sub

		Private Sub btnClose_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			docDocumentViewer1.CloseDocument()
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Try
				' Load pdf document from file.
				Me.docDocumentViewer1.LoadFromFile("..\..\..\..\..\..\Data\fax.doc")
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error)
			End Try
		End Sub

		Private Sub btnSaveToPdf_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim savefile As New SaveFileDialog() With {.Filter = "Pdf Document(*.Pdf)|*.Pdf", .Title = "Save"}
			Dim result? As Boolean = savefile.ShowDialog()
			If result.Value Then
				Try
					'Save PDF documetns
					Me.docDocumentViewer1.SaveAs(savefile.FileName)
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error)
				End Try
			End If
		End Sub

		Private Sub btnSaveToDoc97_2k3_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim savefile As New SaveFileDialog() With {.Filter = "Word97-2003 Document(*.doc)|*.doc", .Title = "Save"}
			Dim result? As Boolean = savefile.ShowDialog()
			If result.Value Then
				Try
					'Save as Word97-2003 documetns
					Me.docDocumentViewer1.SaveAs(savefile.FileName)
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error)
				End Try
			End If
		End Sub

		Private Sub btnSaveToDoc2007_2010_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim savefile As New SaveFileDialog() With {.Filter = "Word2007-2010 Document(*.docx)|*.docx", .Title = "Save"}
			Dim result? As Boolean = savefile.ShowDialog()
			If result.Value Then
				Try
					'Save as Word2007-2010 documetns
					Me.docDocumentViewer1.SaveAs(savefile.FileName)
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error)
				End Try
			End If
		End Sub
	End Class
End Namespace
