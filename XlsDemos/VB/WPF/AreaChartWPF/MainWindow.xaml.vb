Imports System.Text
Imports Spire.Xls
Imports Spire.Xls.Charts
Imports System.Collections.ObjectModel
Namespace AreaChartWPF
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnRead_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim workbook As New Workbook()

			'Initailize worksheet
			workbook.CreateEmptySheets(1)
			Dim sheet As Worksheet = workbook.Worksheets(0)
			sheet.Name = "Chart data"
			sheet.GridLinesVisible = False

			'Writes chart data
			CreateChartData(sheet)
			'Add a new  chart worsheet to workbook
			Dim chart As Chart = sheet.Charts.Add()

			'Set region of chart data
			chart.DataRange = sheet.Range("A1:C5")
			chart.SeriesDataFromRange = False

			'Set position of chart
			chart.LeftColumn = 1
			chart.TopRow = 7
			chart.RightColumn = 11
			chart.BottomRow = 30

			If chk3D.IsChecked=True Then
				chart.ChartType = ExcelChartType.Area3D
			Else
				chart.ChartType = ExcelChartType.Area
			End If

			'Chart title area
			chart.ChartTitle = "Sales market by country"
			chart.ChartTitleArea.IsBold = True
			chart.ChartTitleArea.Size = 12

			chart.PrimaryCategoryAxis.Title = "Country"
			chart.PrimaryCategoryAxis.Font.IsBold = True
			chart.PrimaryCategoryAxis.TitleArea.IsBold = True

			chart.PrimaryValueAxis.Title = "Sales(in Dollars)"
			chart.PrimaryValueAxis.HasMajorGridLines = True
			chart.PrimaryValueAxis.TitleArea.TextRotationAngle = 90
			chart.PrimaryValueAxis.MinValue = 1000
			chart.PrimaryValueAxis.TitleArea.IsBold = True

			For Each cs As Spire.Xls.Charts.ChartSerie In chart.Series
				cs.Format.Options.IsVaryColor = True
				cs.DataPoints.DefaultDataPoint.DataLabels.HasValue = True
			Next cs

			chart.Legend.Position = LegendPositionType.Top
			workbook.SaveToFile("Sample.xls")
			ExcelDocViewer(workbook.FileName)
		End Sub
		Private Sub CreateChartData(ByVal sheet As Worksheet)
			'Country
			sheet.Range("A1").Value = "Country"
			sheet.Range("A2").Value = "Cuba"
			sheet.Range("A3").Value = "Mexico"
			sheet.Range("A4").Value = "France"
			sheet.Range("A5").Value = "German"
			'Jun
			sheet.Range("B1").Value = "Jun"
			sheet.Range("B2").NumberValue = 6000
			sheet.Range("B3").NumberValue = 8000
			sheet.Range("B4").NumberValue = 9000
			sheet.Range("B5").NumberValue = 8500

			'Jun
			sheet.Range("C1").Value = "Aug"
			sheet.Range("C2").NumberValue = 3000
			sheet.Range("C3").NumberValue = 10000
			sheet.Range("C4").NumberValue = 2300
			sheet.Range("C5").NumberValue = 4200

			'Style
			sheet.Range("A1:C1").Style.Font.IsBold = True
			sheet.Range("A2:C2").Style.KnownColor = ExcelColors.LightYellow
			sheet.Range("A3:C3").Style.KnownColor = ExcelColors.LightGreen1
			sheet.Range("A4:C4").Style.KnownColor = ExcelColors.LightOrange
			sheet.Range("A5:C5").Style.KnownColor = ExcelColors.LightTurquoise

			'Border
            sheet.Range("A1:C5").Style.Borders(BordersLineType.EdgeTop).Color = System.Drawing.Color.FromArgb(0, 0, 128)
			sheet.Range("A1:C5").Style.Borders(BordersLineType.EdgeTop).LineStyle = LineStyleType.Thin
            sheet.Range("A1:C5").Style.Borders(BordersLineType.EdgeBottom).Color = System.Drawing.Color.FromArgb(0, 0, 128)
			sheet.Range("A1:C5").Style.Borders(BordersLineType.EdgeBottom).LineStyle = LineStyleType.Thin
            sheet.Range("A1:C5").Style.Borders(BordersLineType.EdgeLeft).Color = System.Drawing.Color.FromArgb(0, 0, 128)
			sheet.Range("A1:C5").Style.Borders(BordersLineType.EdgeLeft).LineStyle = LineStyleType.Thin
            sheet.Range("A1:C5").Style.Borders(BordersLineType.EdgeRight).Color = System.Drawing.Color.FromArgb(0, 0, 128)
			sheet.Range("A1:C5").Style.Borders(BordersLineType.EdgeRight).LineStyle = LineStyleType.Thin

			sheet.Range("B2:C5").Style.NumberFormat = """$""#,##0"
		End Sub
		Private Sub ExcelDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch ex As Exception
				MessageBox.Show(ex.Message, "information", MessageBoxButton.OK)
			End Try
		End Sub
		Private Sub btnClose_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Me.Close()
		End Sub
	End Class
End Namespace
