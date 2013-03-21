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
        Private btnRun As System.Windows.Forms.Button
        Private btnAbout As System.Windows.Forms.Button
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
                '
                ' TODO: Add any constructor code after InitializeComponent call
                '
            InitializeComponent()
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
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
            DirectCast(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            ' btnRun
            '
            Me.btnRun.Location = New System.Drawing.Point(368, 269)
            Me.btnRun.Name = "btnRun"
            Me.btnRun.Size = New System.Drawing.Size(72, 23)
            Me.btnRun.TabIndex = 2
            Me.btnRun.Text = "Run"
            AddHandler Me.btnRun.Click, New System.EventHandler(AddressOf Me.btnRun_Click)
            '
            ' btnAbout
            '
            Me.btnAbout.Location = New System.Drawing.Point(456, 269)
            Me.btnAbout.Name = "btnAbout"
            Me.btnAbout.Size = New System.Drawing.Size(75, 23)
            Me.btnAbout.TabIndex = 3
            Me.btnAbout.Text = "Close"
            AddHandler Me.btnAbout.Click, New System.EventHandler(AddressOf Me.btnAbout_Click)
            '
            ' label1
            '
            Me.label1.Font = New System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(134))
            Me.label1.Location = New System.Drawing.Point(16, 11)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(528, 32)
            Me.label1.TabIndex = 4
            Me.label1.Text = "The sample demonstrates how to save a work sheet to image. "
            '
            ' dataGrid1
            '
            Me.dataGrid1.DataMember = ""
            Me.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dataGrid1.Location = New System.Drawing.Point(19, 36)
            Me.dataGrid1.Name = "dataGrid1"
            Me.dataGrid1.[ReadOnly] = True
            Me.dataGrid1.Size = New System.Drawing.Size(512, 216)
            Me.dataGrid1.TabIndex = 5
            '
            ' Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
            Me.ClientSize = New System.Drawing.Size(544, 305)
            Me.Controls.Add(Me.dataGrid1)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.btnAbout)
            Me.Controls.Add(Me.btnRun)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Spire.XLS sample"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            DirectCast(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
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

        Private Sub btnRun_Click(sender As Object, e As System.EventArgs)
            Dim workbook As New Workbook()

            workbook.LoadFromFile("..\..\..\..\..\..\Data\DataTableSample.xls")
            'Initailize worksheet
            Dim sheet As Worksheet = workbook.Worksheets(0)
            sheet.SaveToImage("sample.bmp")
            ExcelDocViewer("sample.bmp")
        End Sub

        Private Sub ExcelDocViewer(fileName As String)
            Try
                System.Diagnostics.Process.Start(fileName)
            Catch
            End Try
        End Sub


        Private Sub btnAbout_Click(sender As Object, e As System.EventArgs)
            Close()
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs)
            Dim workbook As New Workbook()

            workbook.LoadFromFile("..\..\..\..\..\..\Data\DataTableSample.xls")
            'Initailize worksheet
            Dim sheet As Worksheet = workbook.Worksheets(0)

            Me.dataGrid1.DataSource = sheet.ExportDataTable()
        End Sub


    End Class
End Namespace
