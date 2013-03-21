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
            Me.btnRun = New System.Windows.Forms.Button()
            Me.btnAbout = New System.Windows.Forms.Button()
            Me.label1 = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'btnRun
            '
            Me.btnRun.Location = New System.Drawing.Point(448, 56)
            Me.btnRun.Name = "btnRun"
            Me.btnRun.Size = New System.Drawing.Size(72, 23)
            Me.btnRun.TabIndex = 2
            Me.btnRun.Text = "Run"
            '
            'btnAbout
            '
            Me.btnAbout.Location = New System.Drawing.Point(528, 56)
            Me.btnAbout.Name = "btnAbout"
            Me.btnAbout.Size = New System.Drawing.Size(75, 23)
            Me.btnAbout.TabIndex = 3
            Me.btnAbout.Text = "Close"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.label1.Location = New System.Drawing.Point(16, 16)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(571, 14)
            Me.label1.TabIndex = 4
            Me.label1.Text = "The sample demonstrates how to define named cell references or ranges in excel wo" & _
                "rkbook."
            '
            'Form1
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
            Me.Text = "Spire.XLS sample"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New Form1())
        End Sub

        Private Sub btnRun_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRun.Click
            Dim workbook As New Workbook()

            workbook.LoadFromFile("..\..\..\..\..\..\Data\MiscDataTable.xls")
            Dim sheet As Worksheet = workbook.Worksheets(0)
            sheet.InsertRow(1, 2)
            sheet.Rows(0).RowHeight = 16

            'Style
            sheet.Range("A1:B1").Style.Font.IsBold = True
            sheet.Range("A3:E3").Style.KnownColor = ExcelColors.LightOrange

            Dim index As Integer = 4
            While sheet.Range([String].Format("A{0}", index)).HasString
				If index Mod 2 = 0 Then
                    sheet.Range([String].Format("A{0}:E{0}", index)).Style.KnownColor = ExcelColors.PaleBlue
                Else
                    sheet.Range([String].Format("A{0}:E{0}", index)).Style.KnownColor = ExcelColors.LightTurquoise
                End If
                index += 1
            End While

            'define named cell ranges
            sheet.Names.Add("Countries", sheet([String].Format("A4:A{0}", index - 1)))
            sheet.Names.Add("Cities", sheet([String].Format("B4:B{0}", index - 1)))
            sheet.Names.Add("Continents", sheet([String].Format("C4:C{0}", index - 1)))
            sheet.Names.Add("Area", sheet([String].Format("D4:D{0}", index - 1)))
            sheet.Names.Add("Population", sheet([String].Format("E4:E{0}", index - 1)))
            sheet.Names.Add("NumberOfCountries", sheet([String].Format("A{0}", index)))

            'references of names
            sheet.Range("A1").Value = "Number of Countries:"
            sheet.Range("B1").Formula = "=NumberOfCountries"
            sheet([String].Format("A{0}", index)).Formula = "=COUNTA(Countries)"
            sheet([String].Format("D{0}", index)).Formula = "=SUM(Area)"
            sheet([String].Format("E{0}", index)).Formula = "=SUM(Population)"

            'style
            sheet.Rows(index - 1).RowHeight = 16
            Dim range As [String] = [String].Format("A{0}:E{0}", index)
            sheet.Range(range).Style.Font.IsBold = True
            sheet.Range(range).Style.KnownColor = ExcelColors.LightOrange
            sheet.Range(range).Style.Borders(BordersLineType.EdgeTop).Color = Color.FromArgb(0, 0, 0)
            sheet.Range(range).Style.Borders(BordersLineType.EdgeTop).LineStyle = LineStyleType.Thick
            sheet.Range(range).Style.Borders(BordersLineType.EdgeBottom).Color = Color.FromArgb(0, 0, 0)
            sheet.Range(range).Style.Borders(BordersLineType.EdgeBottom).LineStyle = LineStyleType.Thin
            sheet.Range(range).Style.Borders(BordersLineType.EdgeLeft).Color = Color.FromArgb(0, 0, 0)
            sheet.Range(range).Style.Borders(BordersLineType.EdgeLeft).LineStyle = LineStyleType.Thin
            sheet.Range(range).Style.Borders(BordersLineType.EdgeRight).Color = Color.FromArgb(0, 0, 0)
            sheet.Range(range).Style.Borders(BordersLineType.EdgeRight).LineStyle = LineStyleType.Thin

            workbook.SaveToFile("Sample.xls")
            ExcelDocViewer(workbook.FileName)
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
