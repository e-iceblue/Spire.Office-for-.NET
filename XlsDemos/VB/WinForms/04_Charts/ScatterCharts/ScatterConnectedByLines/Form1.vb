Imports Microsoft.VisualBasic
Imports System
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Spire.Xls
Imports Spire.Xls.Charts

Namespace Spire.Xls.Sample
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private WithEvents btnRun As System.Windows.Forms.Button
		Private WithEvents btnAbout As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
		Private checkBox1 As System.Windows.Forms.CheckBox
		''' <summary>
		''' Required designer variable.
		''' </summary
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.btnRun = New System.Windows.Forms.Button()
			Me.btnAbout = New System.Windows.Forms.Button()
			Me.label1 = New System.Windows.Forms.Label()
			Me.checkBox1 = New System.Windows.Forms.CheckBox()
			Me.SuspendLayout()
			' 
			' btnRun
			' 
			Me.btnRun.Location = New System.Drawing.Point(448, 56)
			Me.btnRun.Name = "btnRun"
			Me.btnRun.Size = New System.Drawing.Size(72, 23)
			Me.btnRun.TabIndex = 2
			Me.btnRun.Text = "Run"
'			Me.btnRun.Click += New System.EventHandler(Me.btnRun_Click);
			' 
			' btnAbout
			' 
			Me.btnAbout.Location = New System.Drawing.Point(528, 56)
			Me.btnAbout.Name = "btnAbout"
			Me.btnAbout.TabIndex = 3
			Me.btnAbout.Text = "Close"
'			Me.btnAbout.Click += New System.EventHandler(Me.btnAbout_Click);
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(134)))
			Me.label1.Location = New System.Drawing.Point(16, 16)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(434, 18)
			Me.label1.TabIndex = 4
			Me.label1.Text = "The sample demonstrates how to scatter chart in an excel workbook."
			' 
			' checkBox1
			' 
			Me.checkBox1.Location = New System.Drawing.Point(16, 56)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(144, 24)
			Me.checkBox1.TabIndex = 5
			Me.checkBox1.Text = "Smoothed line chart"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
			Me.ClientSize = New System.Drawing.Size(616, 94)
			Me.Controls.Add(Me.checkBox1)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.btnAbout)
			Me.Controls.Add(Me.btnRun)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Chart sample"
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub btnRun_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRun.Click
			Dim workbook As Workbook = New Workbook()

			'Initailize worksheet
			workbook.CreateEmptySheets(1)
			Dim sheet As Worksheet = workbook.Worksheets(0)
			sheet.Name = "Chart data"
			sheet.GridLinesVisible = False

			'Add a new  chart worsheet to workbook
			Dim chart As Chart = sheet.Charts.Add()

			CreateChartData(sheet)
			CreateChart(sheet, chart)

			If checkBox1.Checked Then
				chart.ChartType = ExcelChartType.ScatterSmoothedLineMarkers
			Else
				chart.ChartType = ExcelChartType.ScatterLineMarkers
			End If


			chart.Legend.Position = LegendPositionType.Top
			workbook.SaveToFile("Sample.xls")
			ExcelDocViewer(workbook.FileName)
		End Sub

		Private Sub CreateChart(ByVal sheet As Worksheet, ByVal chart As Chart)
			'Set region of chart data
			chart.DataRange = sheet.Range("B1:B12")
			chart.SeriesDataFromRange = False

			'Set position of chart
			chart.LeftColumn = 3
			chart.TopRow = 6
			chart.RightColumn = 11
			chart.BottomRow = 29


			'Chart title
			chart.ChartTitle = "Reflex Time Analysis"
			chart.ChartTitleArea.IsBold = True
			chart.ChartTitleArea.Size = 12

			chart.PrimaryCategoryAxis.Title = "Age"
			chart.PrimaryCategoryAxis.Font.IsBold = True
			chart.PrimaryCategoryAxis.TitleArea.IsBold = True

			chart.PrimaryValueAxis.Title = "Reflex Time"
			chart.PrimaryValueAxis.HasMajorGridLines = False
			chart.PrimaryValueAxis.TitleArea.IsBold = True
			chart.PrimaryValueAxis.TitleArea.TextRotationAngle = 90



			Dim cs As Charts.ChartSerie = chart.Series(0)
			cs.CategoryLabels = sheet.Range("A2:A12")
		End Sub


		Private Sub CreateChartData(ByVal sheet As Worksheet)
			Dim RCAddress As String = "A{0}:B{0}"
			'Age
			sheet.Range("A1").Value = "Age"
			sheet.Range("A2").NumberValue = 29
			sheet.Range("A3").NumberValue = 32
			sheet.Range("A4").NumberValue = 33
			sheet.Range("A5").NumberValue = 33
			sheet.Range("A6").NumberValue = 34
			sheet.Range("A7").NumberValue = 34
			sheet.Range("A8").NumberValue = 40
			sheet.Range("A9").NumberValue = 61
			sheet.Range("A10").NumberValue = 62
			sheet.Range("A11").NumberValue = 70
			sheet.Range("A12").NumberValue = 78

			'Reflex Time
			sheet.Range("B1").Value = "Reflex Time"
			sheet.Range("B2").NumberValue = 0.46
			sheet.Range("B3").NumberValue = 0.45
			sheet.Range("B4").NumberValue = 0.43
			sheet.Range("B5").NumberValue = 0.41
			sheet.Range("B6").NumberValue = 0.38
			sheet.Range("B7").NumberValue = 0.37
			sheet.Range("B8").NumberValue = 0.19
			sheet.Range("B9").NumberValue = 0.19
			sheet.Range("B10").NumberValue =0.17
			sheet.Range("B11").NumberValue =0.13
			sheet.Range("B12").NumberValue =0.076


			'Style
			sheet.Range("A1:C1").Style.Font.IsBold = True
			For i As Integer = 2 To 12
				If i Mod 2 = 0 Then
				  sheet.Range(String.Format(RCAddress,i)).Style.KnownColor = ExcelColors.LightYellow
				Else
				  sheet.Range(String.Format(RCAddress,i)).Style.KnownColor = ExcelColors.LightGreen1
				End If
			Next i

			'Border
			Dim style As CellStyle = sheet.Range("A1:B12").Style
			style.Borders(BordersLineType.EdgeTop).Color = Color.FromArgb(0, 0, 128)
			style.Borders(BordersLineType.EdgeTop).LineStyle = LineStyleType.Thin
			style.Borders(BordersLineType.EdgeBottom).Color = Color.FromArgb(0, 0, 128)
			style.Borders(BordersLineType.EdgeBottom).LineStyle = LineStyleType.Thin
			style.Borders(BordersLineType.EdgeLeft).Color = Color.FromArgb(0, 0, 128)
			style.Borders(BordersLineType.EdgeLeft).LineStyle = LineStyleType.Thin
			style.Borders(BordersLineType.EdgeRight).Color = Color.FromArgb(0, 0, 128)
			style.Borders(BordersLineType.EdgeRight).LineStyle = LineStyleType.Thin
		End Sub

		Private Sub ExcelDocViewer(ByVal fileName As String)
			Try
				System.Diagnostics.Process.Start(fileName)
			Catch
			End Try
		End Sub

		Private Sub btnAbout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAbout.Click
			Close()
		End Sub


	End Class
End Namespace
