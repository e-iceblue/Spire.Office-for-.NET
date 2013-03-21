Imports System.Text
Imports Spire.Xls
Imports Spire.Xls.Charts
Imports Microsoft.Win32
Namespace EditSheetWPF
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnRun_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim workbook As New Workbook()

			'Load workbook from disk.
			workbook.LoadFromFile("..\..\..\..\..\Data\EditSheetSample.xls")
			'Initailize worksheet
			Dim sheet As Worksheet = workbook.Worksheets(0)

			'Writes string
			sheet.Range("B1").Text = "Hello,World!"
			'Writes number
			sheet.Range("B2").NumberValue = 1234.5678
			'Writes date
			sheet.Range("B3").DateTimeValue = Date.Now
			'Writes formula
			sheet.Range("B4").Formula = "=1111*11111"
			sheet.Range("B5").Value = "ABCDEFG"
			workbook.SaveToFile("Sample.xls")
			ExcelDocViewer(workbook.FileName)
		End Sub

		Private Sub btnClose_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Me.Close()
		End Sub

		Private Sub ExcelDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch e As Exception
			   MessageBox.Show(e.Message,"information",MessageBoxButton.OK)
			End Try
		End Sub
	End Class
End Namespace
