Imports Microsoft.VisualBasic
Imports System
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Spire.Xls

Namespace Spire.Xls.Sample
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private WithEvents btnRun As System.Windows.Forms.Button
		Private WithEvents btnAbout As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
		Private dataGrid1 As System.Windows.Forms.DataGrid
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
			Me.dataGrid1 = New System.Windows.Forms.DataGrid()
			CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btnRun
			' 
			Me.btnRun.Location = New System.Drawing.Point(360, 288)
			Me.btnRun.Name = "btnRun"
			Me.btnRun.Size = New System.Drawing.Size(72, 23)
			Me.btnRun.TabIndex = 2
			Me.btnRun.Text = "Run"
'			Me.btnRun.Click += New System.EventHandler(Me.btnRun_Click);
			' 
			' btnAbout
			' 
			Me.btnAbout.Location = New System.Drawing.Point(448, 288)
			Me.btnAbout.Name = "btnAbout"
			Me.btnAbout.TabIndex = 3
			Me.btnAbout.Text = "Close"
'			Me.btnAbout.Click += New System.EventHandler(Me.btnAbout_Click);
			' 
			' label1
			' 
			Me.label1.Font = New System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(134)))
			Me.label1.Location = New System.Drawing.Point(16, 11)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(528, 32)
			Me.label1.TabIndex = 4
			Me.label1.Text = "The sample demonstrates how to  import the data from datatable the  to spreadshee" & "t."
			' 
			' dataGrid1
			' 
			Me.dataGrid1.DataMember = ""
			Me.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
			Me.dataGrid1.Location = New System.Drawing.Point(16, 56)
			Me.dataGrid1.Name = "dataGrid1"
			Me.dataGrid1.ReadOnly = True
			Me.dataGrid1.Size = New System.Drawing.Size(512, 216)
			Me.dataGrid1.TabIndex = 5
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
			Me.ClientSize = New System.Drawing.Size(544, 325)
			Me.Controls.Add(Me.dataGrid1)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.btnAbout)
			Me.Controls.Add(Me.btnRun)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Spire.XLS sample"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
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
			Dim sheet As Worksheet = workbook.Worksheets(0)

			sheet.InsertDataTable(CType(Me.dataGrid1.DataSource, DataTable),True,2,1,-1,-1)

			'Sets body style
			Dim oddStyle As CellStyle = workbook.Styles.Add("oddStyle")
			oddStyle.Borders(BordersLineType.EdgeLeft).LineStyle = LineStyleType.Thin
			oddStyle.Borders(BordersLineType.EdgeRight).LineStyle = LineStyleType.Thin
			oddStyle.Borders(BordersLineType.EdgeTop).LineStyle = LineStyleType.Thin
			oddStyle.Borders(BordersLineType.EdgeBottom).LineStyle = LineStyleType.Thin
			oddStyle.KnownColor = ExcelColors.LightGreen1

			Dim evenStyle As CellStyle = workbook.Styles.Add("evenStyle")
			evenStyle.Borders(BordersLineType.EdgeLeft).LineStyle = LineStyleType.Thin
			evenStyle.Borders(BordersLineType.EdgeRight).LineStyle = LineStyleType.Thin
			evenStyle.Borders(BordersLineType.EdgeTop).LineStyle = LineStyleType.Thin
			evenStyle.Borders(BordersLineType.EdgeBottom).LineStyle = LineStyleType.Thin
			evenStyle.KnownColor = ExcelColors.LightTurquoise

			For Each range As CellRange In sheet.AllocatedRange.Rows
				If range.Row Mod 2 = 0 Then
					range.CellStyleName = evenStyle.Name
				Else
					range.CellStyleName = oddStyle.Name
				End If
			Next range

			'Sets header style
			Dim styleHeader As CellStyle = sheet.Rows(0).Style
			styleHeader.Borders(BordersLineType.EdgeLeft).LineStyle = LineStyleType.Thin
			styleHeader.Borders(BordersLineType.EdgeRight).LineStyle = LineStyleType.Thin
			styleHeader.Borders(BordersLineType.EdgeTop).LineStyle = LineStyleType.Thin
			styleHeader.Borders(BordersLineType.EdgeBottom).LineStyle = LineStyleType.Thin
			styleHeader.VerticalAlignment = VerticalAlignType.Center
			styleHeader.KnownColor = ExcelColors.Green
			styleHeader.Font.KnownColor = ExcelColors.White
			styleHeader.Font.IsBold = True

			sheet.Columns(sheet.AllocatedRange.LastColumn - 1).Style.NumberFormat = """$""#,##0"
			sheet.Columns(sheet.AllocatedRange.LastColumn - 2).Style.NumberFormat = """$""#,##0"

			sheet.AllocatedRange.AutoFitColumns()
			sheet.AllocatedRange.AutoFitRows()

			sheet.Rows(0).RowHeight = 20

			workbook.SaveToFile("sample.xls")
			ExcelDocViewer(workbook.FileName)
		End Sub


		Private Sub btnAbout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAbout.Click
			Close()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Dim workbook As Workbook = New Workbook()

			workbook.LoadFromFile("..\..\..\..\..\..\Data\DataTableSample.xls")
			'Initailize worksheet
			Dim sheet As Worksheet = workbook.Worksheets(0)

			Me.dataGrid1.DataSource = sheet.ExportDataTable()
		End Sub


		Private Sub ExcelDocViewer(ByVal fileName As String)
			Try
				System.Diagnostics.Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
