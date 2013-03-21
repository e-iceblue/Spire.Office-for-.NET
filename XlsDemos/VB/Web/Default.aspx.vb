Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Imports System.Web
Imports System.Web.SessionState
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls

Imports Spire.Xls

Namespace Spire.WebDemo

	Partial Class DefaultForm
		Inherits System.Web.UI.Page
		Protected oleDbConnection1 As System.Data.OleDb.OleDbConnection
		Protected oleDbCommand1 As System.Data.OleDb.OleDbCommand
		Protected RadioButtonList1 As System.Web.UI.WebControls.RadioButtonList
		Protected RadioButtonList2 As System.Web.UI.WebControls.RadioButtonList

		Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
		End Sub

		#Region "Web Form Designer generated code"
		Overrides Protected Sub OnInit(ByVal e As EventArgs)
			'
			' CODEGEN: This call is required by the ASP.NET Web Form Designer.
			'
			InitializeComponent()
			MyBase.OnInit(e)
		End Sub

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
'			Me.Button1.Click += New System.EventHandler(Me.Button1_Click);

		End Sub
		#End Region

		Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
			Dim workbook As Workbook = New Workbook()

			'Initailize worksheet
			workbook.LoadFromFile(Page.MapPath("./Data/EditChartSample.xls"),True)
			Dim sheet As Worksheet = workbook.Worksheets(0)

			'Writes chart data
			CreateChartData(sheet)

			workbook.SaveToHttpResponse("Sample.xls", Response)
		End Sub

		Private Sub CreateChartData(ByVal sheet As Worksheet)
			'Jun
			sheet.Range("F6").NumberValue = 6000
			sheet.Range("F7").NumberValue = 8000
			sheet.Range("F8").NumberValue = 9000
			sheet.Range("F9").NumberValue = 8500

			'Aug
			sheet.Range("G6").NumberValue = 4000
			sheet.Range("G7").NumberValue = 7000
			sheet.Range("G8").NumberValue = 2000
			sheet.Range("G9").NumberValue = 5000

			sheet.Range("F6:F9").Style.NumberFormat = """$""#,##0"
			sheet.Range("G6:G9").Style.NumberFormat = """$""#,##0"
		End Sub

		Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
		End Sub
	End Class
End Namespace
