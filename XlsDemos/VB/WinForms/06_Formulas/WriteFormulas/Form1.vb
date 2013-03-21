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
			Me.label1.Size = New System.Drawing.Size(417, 18)
			Me.label1.TabIndex = 4
			Me.label1.Text = "The sample demonstrates how to write formulas into spreadsheet."
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
			Me.ClientSize = New System.Drawing.Size(616, 94)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.btnAbout)
			Me.Controls.Add(Me.btnRun)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Formulas sample"
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

		Private Sub ExcelDocViewer(ByVal fileName As String)
			Try
				System.Diagnostics.Process.Start(fileName)
			Catch
			End Try
		End Sub

		Private Sub btnRun_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRun.Click
			Dim workbook As Workbook = New Workbook()
            Dim sheet As Worksheet = workbook.Worksheets(0)

            Dim currentRow As Integer = 1
            Dim currentFormula As String = String.Empty

            sheet.SetColumnWidth(1, 32)
            sheet.SetColumnWidth(2, 16)
            sheet.SetColumnWidth(3, 16)

            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Value = "Examples of formulas :"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Value = "Test data:"

            Dim range As CellRange = sheet.Range("A1")
            range.Style.Font.IsBold = True
            range.Style.FillPattern = ExcelPatternType.Solid
            range.Style.KnownColor = ExcelColors.LightGreen1
            range.Style.Borders(BordersLineType.EdgeBottom).LineStyle = LineStyleType.Medium

            'test data
            sheet.Range(currentRow, 2).NumberValue = 7.3
            sheet.Range(currentRow, 3).NumberValue = 5

            sheet.Range(currentRow, 4).NumberValue = 8.2
            sheet.Range(currentRow, 5).NumberValue = 4
            sheet.Range(currentRow, 6).NumberValue = 3
            sheet.Range(currentRow, 7).NumberValue = 11.3

            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Value = "Formulas"

            sheet.Range(currentRow, 2).Value = "Results"
            range = sheet.Range(currentRow, 1, currentRow, 2)
            range.Style.Font.IsBold = True
            range.Style.KnownColor = ExcelColors.LightGreen1
            range.Style.FillPattern = ExcelPatternType.Solid
            range.Style.Borders(BordersLineType.EdgeBottom).LineStyle = LineStyleType.Medium
            'str.
            currentFormula = "=""hello"""
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = "=""hello"""
            sheet.Range(currentRow, 2).Formula = currentFormula
            sheet.Range(currentRow, 3).Formula = "=""" & ChrW(20320) & ChrW(22909) + """"

            'int.
            currentFormula = "=300"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            ' float
            currentFormula = "=3389.639421"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            'bool.
            currentFormula = "=false"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=1+2+3+4+5-6-7+8-9"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=33*3/4-2+10"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula


            ' sheet reference
            currentFormula = "=Sheet1!$B$3"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            ' sheet area reference
            currentFormula = "=AVERAGE(Sheet1!$D$3:G$3)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            ' Functions
            currentFormula = "=Count(3,5,8,10,2,34)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula


            currentFormula = "=NOW()"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula
            sheet.Range(currentRow, 2).Style.NumberFormat = "yyyy-MM-DD"


            currentFormula = "=SECOND(11)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=MINUTE(12)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=MONTH(9)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=DAY(10)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=TIME(4,5,7)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=DATE(6,4,2)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=RAND()"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=HOUR(12)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=MOD(5,3)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=WEEKDAY(3)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=YEAR(23)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=NOT(true)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=OR(true)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=AND(TRUE)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=VALUE(30)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=LEN(""world"")"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=MID(""world"",4,2)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=ROUND(7,3)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=SIGN(4)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=INT(200)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=ABS(-1.21)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=LN(15)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=EXP(20)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=SQRT(40)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=PI()"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=COS(9)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=SIN(45)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=MAX(10,30)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=MIN(5,7)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=AVERAGE(12,45)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=SUM(18,29)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

            currentFormula = "=IF(4,2,2)"
            currentRow = currentRow + 1
            sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

			currentFormula = "=SUBTOTAL(3,Sheet1!B2:E3)"
            currentRow = currentRow + 1
			sheet.Range(currentRow, 1).Text = currentFormula
            sheet.Range(currentRow, 2).Formula = currentFormula

			workbook.SaveToFile("Sample.xls")
			ExcelDocViewer(workbook.FileName)
		End Sub

		Private Sub btnAbout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAbout.Click
			Close()
		End Sub


	End Class
End Namespace
