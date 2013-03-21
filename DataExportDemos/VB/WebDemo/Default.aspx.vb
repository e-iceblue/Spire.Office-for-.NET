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

Imports Spire.DataExport.TXT

Namespace Spire.WebDemo

	Partial Class DefaultForm
		Inherits System.Web.UI.Page
		Protected oleDbConnection1 As System.Data.OleDb.OleDbConnection
		Protected oleDbCommand1 As System.Data.OleDb.OleDbCommand
		Protected RadioButtonList1 As System.Web.UI.WebControls.RadioButtonList
		Protected RadioButtonList2 As System.Web.UI.WebControls.RadioButtonList
		Protected accessExport1 As Spire.DataExport.Access.AccessExport
		Protected cellExport1 As Spire.DataExport.XLS.CellExport
		Protected dbfExport1 As Spire.DataExport.DBF.DBFExport
		Protected pdfExport1 As Spire.DataExport.PDF.PDFExport
		Protected rtfExport1 As Spire.DataExport.RTF.RTFExport
		Protected sqlExport1 As Spire.DataExport.SQL.SQLExport
		Protected txtExport1 As Spire.DataExport.TXT.TXTExport
		Protected xmlExport1 As Spire.DataExport.XML.XMLExport

		Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Dim path As String = MapPath(".")
			path = path.Substring(0, path.LastIndexOf("\"))
            oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\..\Database\demo.mdb"
			Me.oleDbCommand1.CommandText = "SELECT * FROM PARTS"
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
            Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection
            Me.oleDbCommand1 = New System.Data.OleDb.OleDbCommand
            Me.accessExport1 = New Spire.DataExport.Access.AccessExport
            Me.cellExport1 = New Spire.DataExport.XLS.CellExport
            Me.dbfExport1 = New Spire.DataExport.DBF.DBFExport
            Me.pdfExport1 = New Spire.DataExport.PDF.PDFExport
            Me.rtfExport1 = New Spire.DataExport.RTF.RTFExport
            Me.sqlExport1 = New Spire.DataExport.SQL.SQLExport
            Me.txtExport1 = New Spire.DataExport.TXT.TXTExport
            Me.xmlExport1 = New Spire.DataExport.XML.XMLExport
            '
            'oleDbConnection1
            '
            Me.oleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
            "ocking Mode=1;Jet OLEDB:Database Password=;Data Source=""..\database\demo.mdb"";Je" & _
            "t OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.J" & _
            "et.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties" & _
            "=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System " & _
            "Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Wi" & _
            "thout Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False"
            '
            'oleDbCommand1
            '
            Me.oleDbCommand1.CommandText = "SELECT * FROM country"
            Me.oleDbCommand1.Connection = Me.oleDbConnection1
            '
            'accessExport1
            '
            Me.accessExport1.DataFormats.CultureName = "zh-CN"
            Me.accessExport1.DataFormats.Currency = "c"
            Me.accessExport1.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.accessExport1.DataFormats.Float = "g"
            Me.accessExport1.DataFormats.Integer = "g"
            Me.accessExport1.DataFormats.Time = "H:mm"
            Me.accessExport1.SQLCommand = Me.oleDbCommand1
            '
            'cellExport1
            '
            Me.cellExport1.DataFormats.CultureName = "zh-CN"
            Me.cellExport1.DataFormats.Currency = "гд#,###,##0.00"
            Me.cellExport1.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.cellExport1.DataFormats.Float = "#,###,##0.00"
            Me.cellExport1.DataFormats.Integer = "#,###,##0"
            Me.cellExport1.DataFormats.Time = "H:mm"
            Me.cellExport1.SheetOptions.AggregateFormat.Font.Name = "Arial"
            Me.cellExport1.SheetOptions.CustomDataFormat.Font.Name = "Arial"
            Me.cellExport1.SheetOptions.DefaultFont.Name = "Arial"
            Me.cellExport1.SheetOptions.FooterFormat.Font.Name = "Arial"
            Me.cellExport1.SheetOptions.HeaderFormat.Font.Name = "Arial"
            Me.cellExport1.SheetOptions.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            Me.cellExport1.SheetOptions.HyperlinkFormat.Font.Name = "Arial"
            Me.cellExport1.SheetOptions.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            Me.cellExport1.SheetOptions.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            Me.cellExport1.SheetOptions.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            Me.cellExport1.SheetOptions.NoteFormat.Font.Bold = True
            Me.cellExport1.SheetOptions.NoteFormat.Font.Name = "Tahoma"
            Me.cellExport1.SheetOptions.NoteFormat.Font.Size = 8.0!
            Me.cellExport1.SheetOptions.TitlesFormat.Font.Bold = True
            Me.cellExport1.SheetOptions.TitlesFormat.Font.Name = "Arial"
            Me.cellExport1.SQLCommand = Me.oleDbCommand1
            '
            'dbfExport1
            '
            Me.dbfExport1.SQLCommand = Me.oleDbCommand1
            '
            'pdfExport1
            '
            Me.pdfExport1.DataFormats.CultureName = "zh-CN"
            Me.pdfExport1.DataFormats.Currency = "c"
            Me.pdfExport1.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.pdfExport1.DataFormats.Float = "g"
            Me.pdfExport1.DataFormats.Integer = "g"
            Me.pdfExport1.DataFormats.Time = "H:mm"
            Me.pdfExport1.PDFOptions.PageOptions.Format = Spire.DataExport.PDF.PageFormat.User
            Me.pdfExport1.PDFOptions.PageOptions.Height = 11.67
            Me.pdfExport1.PDFOptions.PageOptions.MarginBottom = 0.78
            Me.pdfExport1.PDFOptions.PageOptions.MarginLeft = 1.17
            Me.pdfExport1.PDFOptions.PageOptions.MarginRight = 0.57
            Me.pdfExport1.PDFOptions.PageOptions.MarginTop = 0.78
            Me.pdfExport1.PDFOptions.PageOptions.Width = 8.25
            Me.pdfExport1.SQLCommand = Me.oleDbCommand1
            '
            'rtfExport1
            '
            Me.rtfExport1.DataFormats.CultureName = "zh-CN"
            Me.rtfExport1.DataFormats.Currency = "c"
            Me.rtfExport1.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.rtfExport1.DataFormats.Float = "g"
            Me.rtfExport1.DataFormats.Integer = "g"
            Me.rtfExport1.DataFormats.Time = "H:mm"
            Me.rtfExport1.RTFOptions.DataStyle.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.rtfExport1.RTFOptions.FooterStyle.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.rtfExport1.RTFOptions.HeaderStyle.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.rtfExport1.RTFOptions.TitleStyle.Alignment = Spire.DataExport.RTF.RtfTextAlignment.Center
            Me.rtfExport1.RTFOptions.TitleStyle.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
            Me.rtfExport1.SQLCommand = Me.oleDbCommand1
            '
            'sqlExport1
            '
            Me.sqlExport1.DataFormats.CultureName = "zh-CN"
            Me.sqlExport1.DataFormats.Currency = "c"
            Me.sqlExport1.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.sqlExport1.DataFormats.Float = "g"
            Me.sqlExport1.DataFormats.Integer = "g"
            Me.sqlExport1.DataFormats.Time = "H:mm"
            Me.sqlExport1.SQLCommand = Me.oleDbCommand1
            '
            'txtExport1
            '
            Me.txtExport1.DataFormats.CultureName = "zh-CN"
            Me.txtExport1.DataFormats.Currency = "c"
            Me.txtExport1.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.txtExport1.DataFormats.Float = "g"
            Me.txtExport1.DataFormats.Integer = "g"
            Me.txtExport1.DataFormats.Time = "H:mm"
            Me.txtExport1.SQLCommand = Me.oleDbCommand1
            '
            'xmlExport1
            '
            Me.xmlExport1.DataFormats.CultureName = "zh-CN"
            Me.xmlExport1.DataFormats.Currency = "c"
            Me.xmlExport1.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.xmlExport1.DataFormats.Float = "g"
            Me.xmlExport1.DataFormats.Integer = "g"
            Me.xmlExport1.DataFormats.Time = "H:mm"
            Me.xmlExport1.SQLCommand = Me.oleDbCommand1

        End Sub
		#End Region

		Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

			oleDbConnection1.Open()
			Try

				Select Case RadioButtonList3.SelectedIndex
					Case 0
						cellExport1.SaveToHttpResponse("sample.xls",Response)
					Case 1
						pdfExport1.SaveToHttpResponse("sample.pdf",Response)
					Case 2
						rtfExport1.SaveToHttpResponse("sample.doc",Response)
					Case 3
						dbfExport1.SaveToHttpResponse("sample.dbf",Response)
					Case 4
						accessExport1.SaveToHttpResponse("sample.mdb",Response)
					Case 5
						xmlExport1.SaveToHttpResponse("sample.xml",Response)
					Case 6
						sqlExport1.SaveToHttpResponse("sample.sql",Response)
					Case 7
						txtExport1.ExportType = TextExportType.SYLK
						txtExport1.SaveToHttpResponse("sample.slk",Response)
					Case 8
						txtExport1.ExportType = TextExportType.CSV
						txtExport1.SaveToHttpResponse("sample.csv",Response)
					Case 9
						txtExport1.ExportType = TextExportType.DIF
						txtExport1.SaveToHttpResponse("sample.dif",Response)
					Case 10
						txtExport1.ExportType = TextExportType.TXT
						txtExport1.SaveToHttpResponse("sample.txt",Response)

				End Select
			Finally
				Me.oleDbConnection1.Close()
			End Try
		End Sub

		Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
			Response.Redirect("CellSample.aspx")
		End Sub
	End Class
End Namespace
