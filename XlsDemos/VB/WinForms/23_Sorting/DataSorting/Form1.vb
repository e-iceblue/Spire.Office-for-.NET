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
            Me.label1.Size = New System.Drawing.Size(553, 28)
            Me.label1.TabIndex = 4
            Me.label1.Text = "The sample demonstrates how to sort the data of Excel."
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
            Dim workbook As New Workbook()
            workbook.LoadFromFile("..\..\..\..\..\..\Data\MiscDataTable.xls")

			Dim sheet As Worksheet = workbook.Worksheets(0)

            'append the sort column index and order by attributes 
            workbook.DataSorter.SortColumns.Add(2, OrderBy.Ascending)
            workbook.DataSorter.SortColumns.Add(3, OrderBy.Ascending)
            
            'set the range to sort.
            workbook.DataSorter.Sort(sheet("A1:E19"))
			
            workbook.SaveToFile("Sample.xls")		

			ExcelDocViewer(workbook.FileName)
		End Sub

		Private Sub btnAbout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAbout.Click
			Close()
		End Sub


	End Class
End Namespace
