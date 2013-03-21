Imports System.Text

Namespace DocViewer_HelloWorld
	''' <summary>
	''' MainWindow.xaml 的交互逻辑
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			Try
				' Load doc document from file.
				Me.docViewer1.LoadFromFile("..\..\..\..\..\..\Data\Spire.Office.doc")
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error)
			End Try
		End Sub
	End Class
End Namespace
