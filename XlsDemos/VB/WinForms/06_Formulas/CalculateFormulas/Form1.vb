Imports Microsoft.VisualBasic
Imports System
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Forms
Imports System.Data

Imports Spire.Xls

Namespace Spire.Xls.Sample
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
        Private WithEvents btnExport As System.Windows.Forms.Button
        Private WithEvents btnAbout As System.Windows.Forms.Button
        Private label1 As System.Windows.Forms.Label
        Private dataGrid1 As System.Windows.Forms.DataGrid
        Friend WithEvents toolTip As System.Windows.Forms.ToolTip
        Private WithEvents btnRead As System.Windows.Forms.Button
        Private WithEvents btnCalculate As System.Windows.Forms.Button
        Private components As System.ComponentModel.IContainer
        ''' <summary>
        ''' Required designer variable.
        ''' </summary

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
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
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
            Me.components = New System.ComponentModel.Container()
            Me.btnExport = New System.Windows.Forms.Button()
            Me.btnAbout = New System.Windows.Forms.Button()
            Me.label1 = New System.Windows.Forms.Label()
            Me.dataGrid1 = New System.Windows.Forms.DataGrid()
            Me.btnRead = New System.Windows.Forms.Button()
            Me.btnCalculate = New System.Windows.Forms.Button()
            Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnExport
            '
            Me.btnExport.Location = New System.Drawing.Point(360, 288)
            Me.btnExport.Name = "btnExport"
            Me.btnExport.Size = New System.Drawing.Size(72, 23)
            Me.btnExport.TabIndex = 2
            Me.btnExport.Text = "Export"
            Me.toolTip.SetToolTip(Me.btnExport, "Exports cells to datatable with calculating formulas")
            '
            'btnAbout
            '
            Me.btnAbout.Location = New System.Drawing.Point(448, 288)
            Me.btnAbout.Name = "btnAbout"
            Me.btnAbout.Size = New System.Drawing.Size(75, 23)
            Me.btnAbout.TabIndex = 3
            Me.btnAbout.Text = "Close"
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.label1.Location = New System.Drawing.Point(16, 11)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(528, 32)
            Me.label1.TabIndex = 4
            Me.label1.Text = "The sample demonstrates how to calculate formulas and export data to datatable wi" & _
                "th calculating formulas."
            '
            'dataGrid1
            '
            Me.dataGrid1.DataMember = ""
            Me.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dataGrid1.Location = New System.Drawing.Point(16, 56)
            Me.dataGrid1.Name = "dataGrid1"
            Me.dataGrid1.ReadOnly = True
            Me.dataGrid1.Size = New System.Drawing.Size(512, 216)
            Me.dataGrid1.TabIndex = 5
            '
            'btnRead
            '
            Me.btnRead.Location = New System.Drawing.Point(272, 288)
            Me.btnRead.Name = "btnRead"
            Me.btnRead.Size = New System.Drawing.Size(72, 23)
            Me.btnRead.TabIndex = 2
            Me.btnRead.Text = "Read"
            Me.toolTip.SetToolTip(Me.btnRead, "Calculates cells' formulas and reads results")
            '
            'btnCalculate
            '
            Me.btnCalculate.Location = New System.Drawing.Point(184, 288)
            Me.btnCalculate.Name = "btnCalculate"
            Me.btnCalculate.Size = New System.Drawing.Size(72, 23)
            Me.btnCalculate.TabIndex = 2
            Me.btnCalculate.Text = "Calculate"
            Me.toolTip.SetToolTip(Me.btnCalculate, "Calculates one special formula")
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
            Me.ClientSize = New System.Drawing.Size(544, 325)
            Me.Controls.Add(Me.dataGrid1)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.btnAbout)
            Me.Controls.Add(Me.btnCalculate)
            Me.Controls.Add(Me.btnRead)
            Me.Controls.Add(Me.btnExport)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Spire.XLS sample"
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New Form1())
        End Sub

        Private Function WriteFormulas() As Stream
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

            Dim buffer As New MemoryStream()
            workbook.SaveToStream(buffer)
            buffer.Position = 0

            Return buffer
        End Function


        Private Sub btnAbout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAbout.Click
            Close()
        End Sub


        Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
            Using buffer As Stream = Me.WriteFormulas()
                'load
                Dim workbook As New Workbook()
                workbook.LoadFromStream(buffer)

                'calculate all cells
                workbook.CalculateAllValue()

                'export
                Dim sheet As Worksheet = workbook.Worksheets(0)
                Me.dataGrid1.DataSource = sheet.ExportDataTable(sheet("A4:B46"), True, True)
            End Using
        End Sub

        Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
            Using buffer As Stream = Me.WriteFormulas()
                'load
                Dim workbook As New Workbook()
                workbook.LoadFromStream(buffer)

                'calculate formula
                Dim b3 As [Object] = workbook.CaculateFormulaValue("Sheet1!$B$3")
                Dim c3 As [Object] = workbook.CaculateFormulaValue("Sheet1!$C$3")
                Dim formula As [String] = "Sheet1!$B$3 + Sheet1!$C$3"
                Dim value As [Object] = workbook.CaculateFormulaValue(formula)
                Dim message As [String] = [String].Format("Sheet1!$B$3 = {0}, Sheet1!$C$3 = {1}, {2} = {3}", b3, c3, formula, value)
                MessageBox.Show(message)
            End Using
        End Sub

        Private Sub btnRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRead.Click
            Using buffer As Stream = Me.WriteFormulas()
                'load
                Dim workbook As New Workbook()
                workbook.LoadFromStream(buffer)

                'calculate all cells' formula
                workbook.CalculateAllValue()

                'read cells' value to data table
                Dim sheet As Worksheet = workbook.Worksheets(0)
                Dim dataTable As New DataTable()
                dataTable.Columns.Add("Formulas", GetType([String]))
                dataTable.Columns.Add("Results", GetType([Object]))
                For Each row As CellRange In sheet("A5:B46").Rows
                    Dim formula As [String] = row.Columns(1).Formula
                    Dim value As [Object] = row.Columns(1).FormulaValue
                    dataTable.Rows.Add(formula, value)
                Next
                Me.dataGrid1.DataSource = dataTable
            End Using

        End Sub
    End Class
End Namespace
