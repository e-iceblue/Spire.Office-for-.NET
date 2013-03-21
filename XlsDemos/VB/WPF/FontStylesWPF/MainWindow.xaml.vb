Imports System.Text
Imports Spire.Xls

Namespace FontStylesWPF
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
			Dim sheet As Worksheet = workbook.Worksheets(0)

			sheet.Range("B1").Text = "Font setting"
			sheet.Range("B1").Style.Font.IsBold = True

			sheet.Range("B3").Text = "Arial"
			sheet.Range("B3").Style.Font.FontName = "Arial"

			sheet.Range("B4").Text = "Large size"
			sheet.Range("B4").Style.Font.Size = 20

			sheet.Range("B5").Text = "Bold"
			sheet.Range("B5").Style.Font.IsBold = True

			sheet.Range("B6").Text = "Italic"
			sheet.Range("B6").Style.Font.IsItalic = True

			sheet.Range("B7").Text = "Superscript"
			sheet.Range("B7").Style.Font.IsSuperscript = True

			sheet.Range("B8").Text = "Colored"
            sheet.Range("B8").Style.Font.Color = System.Drawing.Color.FromArgb(255, 125, 125)

			sheet.Range("B9").Text = "Underline"
			sheet.Range("B9").Style.Font.Underline = FontUnderlineType.Single

			sheet.AutoFitColumn(2)

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
				MessageBox.Show(e.Message, "information", MessageBoxButton.OK)
			End Try
		End Sub
	End Class
End Namespace
