Imports System
Imports System.IO
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Web
Imports System.Web.HttpResponse
Imports System.Web.SessionState
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls
Imports Microsoft.VisualBasic


Imports Spire.DataExport.XLS



Namespace Spire.WebDemo

	Partial Class CellSample
		Inherits System.Web.UI.Page
		Protected Button1 As System.Web.UI.WebControls.Button
		Protected Button2 As System.Web.UI.WebControls.Button
		Protected Button3 As System.Web.UI.WebControls.Button
		Protected Button4 As System.Web.UI.WebControls.Button
		Protected Button5 As System.Web.UI.WebControls.Button
		Protected Button6 As System.Web.UI.WebControls.Button
		Protected Button7 As System.Web.UI.WebControls.Button
		Protected WithEvents cellExport1 As Spire.DataExport.XLS.CellExport
		Protected oleDbConnection1 As System.Data.OleDb.OleDbConnection
		Protected oleDbCommand1 As System.Data.OleDb.OleDbCommand
		Protected oleDbCommand2 As System.Data.OleDb.OleDbCommand
		Protected cellExport2 As Spire.DataExport.XLS.CellExport
		Protected cellExport3 As Spire.DataExport.XLS.CellExport
		Protected cellExport4 As Spire.DataExport.XLS.CellExport
		Protected cellExport5 As Spire.DataExport.XLS.CellExport
		Protected cellExport6 As Spire.DataExport.XLS.CellExport
		Protected WithEvents cellExport7 As Spire.DataExport.XLS.CellExport
		Protected cellExport8 As Spire.DataExport.XLS.CellExport


		Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Dim path As String = MapPath(".")
			path = path.Substring(0, path.LastIndexOf("\"))
            oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\..\Database\demo.mdb"
			Me.oleDbCommand1.CommandText = "SELECT * FROM PARTS"
			Me.oleDbCommand2.CommandText = "SELECT * FROM Employee"
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
            Dim WorkSheet1 As Spire.DataExport.XLS.WorkSheet = New Spire.DataExport.XLS.WorkSheet
            Dim ColumnFormat1 As Spire.DataExport.XLS.ColumnFormat = New Spire.DataExport.XLS.ColumnFormat
            Dim StripStyle1 As Spire.DataExport.XLS.StripStyle = New Spire.DataExport.XLS.StripStyle
            Dim StripStyle2 As Spire.DataExport.XLS.StripStyle = New Spire.DataExport.XLS.StripStyle
            Dim WorkSheet2 As Spire.DataExport.XLS.WorkSheet = New Spire.DataExport.XLS.WorkSheet
            Dim StripStyle3 As Spire.DataExport.XLS.StripStyle = New Spire.DataExport.XLS.StripStyle
            Dim StripStyle4 As Spire.DataExport.XLS.StripStyle = New Spire.DataExport.XLS.StripStyle
            Dim WorkSheet3 As Spire.DataExport.XLS.WorkSheet = New Spire.DataExport.XLS.WorkSheet
            Dim ColumnFormat2 As Spire.DataExport.XLS.ColumnFormat = New Spire.DataExport.XLS.ColumnFormat
            Dim ColumnFormat3 As Spire.DataExport.XLS.ColumnFormat = New Spire.DataExport.XLS.ColumnFormat
            Dim ColumnFormat4 As Spire.DataExport.XLS.ColumnFormat = New Spire.DataExport.XLS.ColumnFormat
            Dim ColumnFormat5 As Spire.DataExport.XLS.ColumnFormat = New Spire.DataExport.XLS.ColumnFormat
            Dim ColumnFormat6 As Spire.DataExport.XLS.ColumnFormat = New Spire.DataExport.XLS.ColumnFormat
            Dim CellPicture1 As Spire.DataExport.XLS.CellPicture = New Spire.DataExport.XLS.CellPicture
            Dim WorkSheet4 As Spire.DataExport.XLS.WorkSheet = New Spire.DataExport.XLS.WorkSheet
            Dim CellImage1 As Spire.DataExport.XLS.CellImage = New Spire.DataExport.XLS.CellImage
            Dim CellImage2 As Spire.DataExport.XLS.CellImage = New Spire.DataExport.XLS.CellImage
            Dim WorkSheet5 As Spire.DataExport.XLS.WorkSheet = New Spire.DataExport.XLS.WorkSheet
            Dim Chart1 As Spire.DataExport.XLS.Chart = New Spire.DataExport.XLS.Chart
            Dim ChartSeries1 As Spire.DataExport.XLS.ChartSeries = New Spire.DataExport.XLS.ChartSeries
            Dim StripStyle5 As Spire.DataExport.XLS.StripStyle = New Spire.DataExport.XLS.StripStyle
            Dim StripStyle6 As Spire.DataExport.XLS.StripStyle = New Spire.DataExport.XLS.StripStyle
            Dim WorkSheet6 As Spire.DataExport.XLS.WorkSheet = New Spire.DataExport.XLS.WorkSheet
            Dim Chart2 As Spire.DataExport.XLS.Chart = New Spire.DataExport.XLS.Chart
            Dim ChartSeries2 As Spire.DataExport.XLS.ChartSeries = New Spire.DataExport.XLS.ChartSeries
            Dim WorkSheet7 As Spire.DataExport.XLS.WorkSheet = New Spire.DataExport.XLS.WorkSheet
            Dim StripStyle7 As Spire.DataExport.XLS.StripStyle = New Spire.DataExport.XLS.StripStyle
            Dim StripStyle8 As Spire.DataExport.XLS.StripStyle = New Spire.DataExport.XLS.StripStyle
            Me.oleDbCommand1 = New System.Data.OleDb.OleDbCommand
            Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection
            Me.oleDbCommand2 = New System.Data.OleDb.OleDbCommand
            Me.cellExport1 = New Spire.DataExport.XLS.CellExport
            Me.cellExport2 = New Spire.DataExport.XLS.CellExport
            Me.cellExport3 = New Spire.DataExport.XLS.CellExport
            Me.cellExport5 = New Spire.DataExport.XLS.CellExport
            Me.cellExport6 = New Spire.DataExport.XLS.CellExport
            Me.cellExport7 = New Spire.DataExport.XLS.CellExport
            Me.cellExport8 = New Spire.DataExport.XLS.CellExport
            '
            'oleDbCommand1
            '
            Me.oleDbCommand1.CommandText = "SELECT * FROM PARTS"
            Me.oleDbCommand1.Connection = Me.oleDbConnection1
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
            'oleDbCommand2
            '
            Me.oleDbCommand2.CommandText = "SELECT * FROM Employee"
            Me.oleDbCommand2.Connection = Me.oleDbConnection1
            '
            'cellExport1
            '
            Me.cellExport1.DataFormats.CultureName = "zh-CN"
            Me.cellExport1.DataFormats.Currency = "$#,###,##0.00"
            Me.cellExport1.DataFormats.DateTime = "yyyy-M-d"
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
            Me.cellExport1.SheetOptions.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.Gray40Percent
            Me.cellExport1.SheetOptions.TitlesFormat.Font.Bold = True
            Me.cellExport1.SheetOptions.TitlesFormat.Font.Name = "Arial"
            WorkSheet1.AutoFitColWidth = True
            ColumnFormat1.FieldName = "ListPrice"
            ColumnFormat1.Font.Name = "Arial"
            ColumnFormat1.Width = 8
            WorkSheet1.ColumnFormats.Add(ColumnFormat1)
            WorkSheet1.FormatsExport.CultureName = "zh-CN"
            WorkSheet1.FormatsExport.Currency = "гд#,###,##0.00"
            WorkSheet1.FormatsExport.DateTime = "yyyy-M-d H:mm"
            WorkSheet1.FormatsExport.Float = "#,###,##0.00"
            WorkSheet1.FormatsExport.Integer = "#,###,##0"
            WorkSheet1.FormatsExport.Time = "H:mm"
            StripStyle1.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle1.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle1.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle1.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle1.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightGreen
            StripStyle1.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid
            StripStyle1.Font.Name = "Arial"
            StripStyle2.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle2.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle2.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle2.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle2.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightTurquoise
            StripStyle2.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid
            StripStyle2.Font.Name = "Arial"
            WorkSheet1.ItemStyles.Add(StripStyle1)
            WorkSheet1.ItemStyles.Add(StripStyle2)
            WorkSheet1.ItemType = Spire.DataExport.XLS.CellItemType.Row
            WorkSheet1.Options.AggregateFormat.Font.Name = "Arial"
            WorkSheet1.Options.CustomDataFormat.Font.Name = "Arial"
            WorkSheet1.Options.DefaultFont.Name = "Arial"
            WorkSheet1.Options.FooterFormat.Font.Name = "Arial"
            WorkSheet1.Options.HeaderFormat.Font.Name = "Arial"
            WorkSheet1.Options.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            WorkSheet1.Options.HyperlinkFormat.Font.Name = "Arial"
            WorkSheet1.Options.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            WorkSheet1.Options.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            WorkSheet1.Options.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            WorkSheet1.Options.NoteFormat.Font.Bold = True
            WorkSheet1.Options.NoteFormat.Font.Name = "Tahoma"
            WorkSheet1.Options.NoteFormat.Font.Size = 8.0!
            WorkSheet1.Options.TitlesFormat.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet1.Options.TitlesFormat.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet1.Options.TitlesFormat.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet1.Options.TitlesFormat.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet1.Options.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightYellow
            WorkSheet1.Options.TitlesFormat.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid
            WorkSheet1.Options.TitlesFormat.Font.Bold = True
            WorkSheet1.Options.TitlesFormat.Font.Name = "Arial"
            WorkSheet1.SheetName = "Parts"
            WorkSheet1.SQLCommand = Me.oleDbCommand1
            WorkSheet1.StartDataCol = CType(0, Byte)
            WorkSheet2.AutoFitColWidth = True
            WorkSheet2.FormatsExport.CultureName = "zh-CN"
            WorkSheet2.FormatsExport.Currency = "гд#,###,##0.00"
            WorkSheet2.FormatsExport.DateTime = "yyyy-M-d H:mm"
            WorkSheet2.FormatsExport.Float = "#,###,##0.00"
            WorkSheet2.FormatsExport.Integer = "#,###,##0"
            WorkSheet2.FormatsExport.Time = "H:mm"
            StripStyle3.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle3.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle3.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle3.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle3.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightGreen
            StripStyle3.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid
            StripStyle3.Font.Name = "Arial"
            StripStyle4.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle4.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle4.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle4.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle4.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightTurquoise
            StripStyle4.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid
            StripStyle4.Font.Name = "Arial"
            WorkSheet2.ItemStyles.Add(StripStyle3)
            WorkSheet2.ItemStyles.Add(StripStyle4)
            WorkSheet2.ItemType = Spire.DataExport.XLS.CellItemType.Col
            WorkSheet2.Options.AggregateFormat.Font.Name = "Arial"
            WorkSheet2.Options.CustomDataFormat.Font.Name = "Arial"
            WorkSheet2.Options.DefaultFont.Name = "Arial"
            WorkSheet2.Options.FooterFormat.Font.Name = "Arial"
            WorkSheet2.Options.HeaderFormat.Font.Name = "Arial"
            WorkSheet2.Options.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            WorkSheet2.Options.HyperlinkFormat.Font.Name = "Arial"
            WorkSheet2.Options.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            WorkSheet2.Options.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            WorkSheet2.Options.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            WorkSheet2.Options.NoteFormat.Font.Bold = True
            WorkSheet2.Options.NoteFormat.Font.Name = "Tahoma"
            WorkSheet2.Options.NoteFormat.Font.Size = 8.0!
            WorkSheet2.Options.TitlesFormat.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet2.Options.TitlesFormat.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet2.Options.TitlesFormat.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet2.Options.TitlesFormat.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet2.Options.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightYellow
            WorkSheet2.Options.TitlesFormat.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid
            WorkSheet2.Options.TitlesFormat.Font.Bold = True
            WorkSheet2.Options.TitlesFormat.Font.Name = "Arial"
            WorkSheet2.SheetName = "Orders"
            WorkSheet2.SQLCommand = Me.oleDbCommand2
            WorkSheet2.StartDataCol = CType(0, Byte)
            Me.cellExport1.Sheets.Add(WorkSheet1)
            Me.cellExport1.Sheets.Add(WorkSheet2)
            '
            'cellExport2
            '
            Me.cellExport2.DataFormats.CultureName = "zh-CN"
            Me.cellExport2.DataFormats.Currency = "гд#,###,##0.00"
            Me.cellExport2.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.cellExport2.DataFormats.Float = "#,###,##0.00"
            Me.cellExport2.DataFormats.Integer = "#,###,##0"
            Me.cellExport2.DataFormats.Time = "H:mm"
            Me.cellExport2.SheetOptions.AggregateFormat.Font.Name = "Arial"
            Me.cellExport2.SheetOptions.CustomDataFormat.Font.Name = "Arial"
            Me.cellExport2.SheetOptions.DefaultFont.Name = "Arial"
            Me.cellExport2.SheetOptions.FooterFormat.Font.Name = "Arial"
            Me.cellExport2.SheetOptions.HeaderFormat.Font.Name = "Arial"
            Me.cellExport2.SheetOptions.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            Me.cellExport2.SheetOptions.HyperlinkFormat.Font.Name = "Arial"
            Me.cellExport2.SheetOptions.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            Me.cellExport2.SheetOptions.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            Me.cellExport2.SheetOptions.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            Me.cellExport2.SheetOptions.NoteFormat.Font.Bold = True
            Me.cellExport2.SheetOptions.NoteFormat.Font.Name = "Tahoma"
            Me.cellExport2.SheetOptions.NoteFormat.Font.Size = 8.0!
            Me.cellExport2.SheetOptions.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.Gray40Percent
            Me.cellExport2.SheetOptions.TitlesFormat.Font.Bold = True
            Me.cellExport2.SheetOptions.TitlesFormat.Font.Name = "Arial"
            ColumnFormat2.FieldName = "PartNo"
            ColumnFormat2.Font.Bold = True
            ColumnFormat2.Font.Name = "Arial"
            ColumnFormat3.FieldName = "VendorNo"
            ColumnFormat3.Font.Color = Spire.DataExport.XLS.CellColor.Color1
            ColumnFormat3.Font.Italic = True
            ColumnFormat3.Font.Name = "Arial"
            ColumnFormat4.FieldName = "Description"
            ColumnFormat4.Font.Name = "Arial"
            ColumnFormat4.Font.Strikeout = True
            ColumnFormat4.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.DoubleAccounting
            ColumnFormat5.FieldName = "OnHand"
            ColumnFormat5.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightTurquoise
            ColumnFormat5.FillStyle.Foreground = Spire.DataExport.XLS.CellColor.Pink
            ColumnFormat5.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.ThinGorizontal
            ColumnFormat5.Font.Name = "Arial"
            ColumnFormat6.FieldName = "ListPrice"
            ColumnFormat6.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightYellow
            ColumnFormat6.FillStyle.Foreground = Spire.DataExport.XLS.CellColor.SkyBlue
            ColumnFormat6.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.ThinVertical
            ColumnFormat6.Font.Name = "Arial"
            WorkSheet3.ColumnFormats.Add(ColumnFormat2)
            WorkSheet3.ColumnFormats.Add(ColumnFormat3)
            WorkSheet3.ColumnFormats.Add(ColumnFormat4)
            WorkSheet3.ColumnFormats.Add(ColumnFormat5)
            WorkSheet3.ColumnFormats.Add(ColumnFormat6)
            WorkSheet3.FormatsExport.CultureName = "zh-CN"
            WorkSheet3.FormatsExport.Currency = "гд#,###,##0.00"
            WorkSheet3.FormatsExport.DateTime = "yyyy-M-d H:mm"
            WorkSheet3.FormatsExport.Float = "#,###,##0.00"
            WorkSheet3.FormatsExport.Integer = "#,###,##0"
            WorkSheet3.FormatsExport.Time = "H:mm"
            WorkSheet3.Options.AggregateFormat.Font.Name = "Arial"
            WorkSheet3.Options.CustomDataFormat.Font.Name = "Arial"
            WorkSheet3.Options.DefaultFont.Name = "Arial"
            WorkSheet3.Options.FooterFormat.Font.Name = "Arial"
            WorkSheet3.Options.HeaderFormat.Font.Name = "Arial"
            WorkSheet3.Options.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            WorkSheet3.Options.HyperlinkFormat.Font.Name = "Arial"
            WorkSheet3.Options.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            WorkSheet3.Options.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            WorkSheet3.Options.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            WorkSheet3.Options.NoteFormat.Font.Bold = True
            WorkSheet3.Options.NoteFormat.Font.Name = "Tahoma"
            WorkSheet3.Options.NoteFormat.Font.Size = 8.0!
            WorkSheet3.Options.TitlesFormat.Font.Bold = True
            WorkSheet3.Options.TitlesFormat.Font.Name = "Arial"
            WorkSheet3.SheetName = "Sheet 1"
            WorkSheet3.SQLCommand = Me.oleDbCommand1
            WorkSheet3.StartDataCol = CType(0, Byte)
            Me.cellExport2.Sheets.Add(WorkSheet3)
            '
            'cellExport3
            '
            Me.cellExport3.DataFormats.CultureName = "zh-CN"
            Me.cellExport3.DataFormats.Currency = "гд#,###,##0.00"
            Me.cellExport3.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.cellExport3.DataFormats.Float = "#,###,##0.00"
            Me.cellExport3.DataFormats.Integer = "#,###,##0"
            Me.cellExport3.DataFormats.Time = "H:mm"
            CellPicture1.FileName = "images/sample.gif"
            CellPicture1.Name = "Picture_0"
            Me.cellExport3.Pictures.Add(CellPicture1)
            Me.cellExport3.SheetOptions.AggregateFormat.Font.Name = "Arial"
            Me.cellExport3.SheetOptions.CustomDataFormat.Font.Name = "Arial"
            Me.cellExport3.SheetOptions.DefaultFont.Name = "Arial"
            Me.cellExport3.SheetOptions.FooterFormat.Font.Name = "Arial"
            Me.cellExport3.SheetOptions.HeaderFormat.Font.Name = "Arial"
            Me.cellExport3.SheetOptions.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            Me.cellExport3.SheetOptions.HyperlinkFormat.Font.Name = "Arial"
            Me.cellExport3.SheetOptions.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            Me.cellExport3.SheetOptions.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            Me.cellExport3.SheetOptions.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            Me.cellExport3.SheetOptions.NoteFormat.Font.Bold = True
            Me.cellExport3.SheetOptions.NoteFormat.Font.Name = "Tahoma"
            Me.cellExport3.SheetOptions.NoteFormat.Font.Size = 8.0!
            Me.cellExport3.SheetOptions.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.Gray40Percent
            Me.cellExport3.SheetOptions.TitlesFormat.Font.Bold = True
            Me.cellExport3.SheetOptions.TitlesFormat.Font.Name = "Arial"
            WorkSheet4.DataExported = False
            WorkSheet4.FormatsExport.CultureName = "zh-CN"
            WorkSheet4.FormatsExport.Currency = "гд#,###,##0.00"
            WorkSheet4.FormatsExport.DateTime = "yyyy-M-d H:mm"
            WorkSheet4.FormatsExport.Float = "#,###,##0.00"
            WorkSheet4.FormatsExport.Integer = "#,###,##0"
            WorkSheet4.FormatsExport.Time = "H:mm"
            CellImage1.Column = 1
            CellImage1.PictureName = "Picture_0"
            CellImage1.Row = 1
            CellImage1.Title = "Image_0"
            CellImage2.Column = 1
            CellImage2.PictureName = "Picture_0"
            CellImage2.Row = 16
            CellImage2.Title = "Image_1"
            WorkSheet4.Images.Add(CellImage1)
            WorkSheet4.Images.Add(CellImage2)
            WorkSheet4.ItemType = Spire.DataExport.XLS.CellItemType.Col
            WorkSheet4.Options.AggregateFormat.Font.Name = "Arial"
            WorkSheet4.Options.CustomDataFormat.Font.Name = "Arial"
            WorkSheet4.Options.DefaultFont.Name = "Arial"
            WorkSheet4.Options.FooterFormat.Font.Name = "Arial"
            WorkSheet4.Options.HeaderFormat.Font.Name = "Arial"
            WorkSheet4.Options.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            WorkSheet4.Options.HyperlinkFormat.Font.Name = "Arial"
            WorkSheet4.Options.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            WorkSheet4.Options.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            WorkSheet4.Options.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            WorkSheet4.Options.NoteFormat.Font.Bold = True
            WorkSheet4.Options.NoteFormat.Font.Name = "Tahoma"
            WorkSheet4.Options.NoteFormat.Font.Size = 8.0!
            WorkSheet4.Options.TitlesFormat.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet4.Options.TitlesFormat.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet4.Options.TitlesFormat.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet4.Options.TitlesFormat.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet4.Options.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightYellow
            WorkSheet4.Options.TitlesFormat.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid
            WorkSheet4.Options.TitlesFormat.Font.Bold = True
            WorkSheet4.Options.TitlesFormat.Font.Name = "Arial"
            WorkSheet4.SheetName = "Parts"
            WorkSheet4.StartDataCol = CType(0, Byte)
            Me.cellExport3.Sheets.Add(WorkSheet4)
            '
            'cellExport5
            '
            Me.cellExport5.DataExported = False
            Me.cellExport5.DataFormats.CultureName = "zh-CN"
            Me.cellExport5.DataFormats.Currency = "гд#,###,##0.00"
            Me.cellExport5.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.cellExport5.DataFormats.Float = "#,###,##0.00"
            Me.cellExport5.DataFormats.Integer = "#,###,##0"
            Me.cellExport5.DataFormats.Time = "H:mm"
            Me.cellExport5.SheetOptions.AggregateFormat.Font.Name = "Arial"
            Me.cellExport5.SheetOptions.CustomDataFormat.Font.Name = "Arial"
            Me.cellExport5.SheetOptions.DefaultFont.Name = "Arial"
            Me.cellExport5.SheetOptions.FooterFormat.Font.Name = "Arial"
            Me.cellExport5.SheetOptions.HeaderFormat.Font.Name = "Arial"
            Me.cellExport5.SheetOptions.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            Me.cellExport5.SheetOptions.HyperlinkFormat.Font.Name = "Arial"
            Me.cellExport5.SheetOptions.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            Me.cellExport5.SheetOptions.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            Me.cellExport5.SheetOptions.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            Me.cellExport5.SheetOptions.NoteFormat.Font.Bold = True
            Me.cellExport5.SheetOptions.NoteFormat.Font.Name = "Tahoma"
            Me.cellExport5.SheetOptions.NoteFormat.Font.Size = 8.0!
            Me.cellExport5.SheetOptions.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.Gray40Percent
            Me.cellExport5.SheetOptions.TitlesFormat.Font.Bold = True
            Me.cellExport5.SheetOptions.TitlesFormat.Font.Name = "Arial"
            '
            'cellExport6
            '
            Me.cellExport6.DataFormats.CultureName = "zh-CN"
            Me.cellExport6.DataFormats.Currency = "гд#,###,##0.00"
            Me.cellExport6.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.cellExport6.DataFormats.Float = "#,###,##0.00"
            Me.cellExport6.DataFormats.Integer = "#,###,##0"
            Me.cellExport6.DataFormats.Time = "H:mm"
            Me.cellExport6.SheetOptions.AggregateFormat.Font.Name = "Arial"
            Me.cellExport6.SheetOptions.CustomDataFormat.Font.Name = "Arial"
            Me.cellExport6.SheetOptions.DefaultFont.Name = "Arial"
            Me.cellExport6.SheetOptions.FooterFormat.Font.Name = "Arial"
            Me.cellExport6.SheetOptions.HeaderFormat.Font.Name = "Arial"
            Me.cellExport6.SheetOptions.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            Me.cellExport6.SheetOptions.HyperlinkFormat.Font.Name = "Arial"
            Me.cellExport6.SheetOptions.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            Me.cellExport6.SheetOptions.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            Me.cellExport6.SheetOptions.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            Me.cellExport6.SheetOptions.NoteFormat.Font.Bold = True
            Me.cellExport6.SheetOptions.NoteFormat.Font.Name = "Tahoma"
            Me.cellExport6.SheetOptions.NoteFormat.Font.Size = 8.0!
            Me.cellExport6.SheetOptions.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.Gray40Percent
            Me.cellExport6.SheetOptions.TitlesFormat.Font.Bold = True
            Me.cellExport6.SheetOptions.TitlesFormat.Font.Name = "Arial"
            WorkSheet5.AutoFitColWidth = True
            Chart1.CategoryLabelsColumn = "PartNo"
            Chart1.DataRangeSheet = ""
            Chart1.Position.AutoPosition.Placement = Spire.DataExport.XLS.ChartPlacement.Right
            ChartSeries1.DataColumn = "ListPrice"
            ChartSeries1.DataRangeSheet = ""
            Chart1.Series.Add(ChartSeries1)
            Chart1.Style = Spire.DataExport.XLS.ChartStyle.Pie3d
            WorkSheet5.Charts.Add(Chart1)
            WorkSheet5.FormatsExport.CultureName = "zh-CN"
            WorkSheet5.FormatsExport.Currency = "гд#,###,##0.00"
            WorkSheet5.FormatsExport.DateTime = "yyyy-M-d H:mm"
            WorkSheet5.FormatsExport.Float = "#,###,##0.00"
            WorkSheet5.FormatsExport.Integer = "#,###,##0"
            WorkSheet5.FormatsExport.Time = "H:mm"
            StripStyle5.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle5.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle5.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle5.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle5.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightGreen
            StripStyle5.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid
            StripStyle5.Font.Name = "Arial"
            StripStyle6.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle6.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle6.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle6.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle6.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightTurquoise
            StripStyle6.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid
            StripStyle6.Font.Name = "Arial"
            WorkSheet5.ItemStyles.Add(StripStyle5)
            WorkSheet5.ItemStyles.Add(StripStyle6)
            WorkSheet5.ItemType = Spire.DataExport.XLS.CellItemType.Col
            WorkSheet5.Options.AggregateFormat.Font.Name = "Arial"
            WorkSheet5.Options.CustomDataFormat.Font.Name = "Arial"
            WorkSheet5.Options.DefaultFont.Name = "Arial"
            WorkSheet5.Options.FooterFormat.Font.Name = "Arial"
            WorkSheet5.Options.HeaderFormat.Font.Name = "Arial"
            WorkSheet5.Options.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            WorkSheet5.Options.HyperlinkFormat.Font.Name = "Arial"
            WorkSheet5.Options.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            WorkSheet5.Options.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            WorkSheet5.Options.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            WorkSheet5.Options.NoteFormat.Font.Bold = True
            WorkSheet5.Options.NoteFormat.Font.Name = "Tahoma"
            WorkSheet5.Options.NoteFormat.Font.Size = 8.0!
            WorkSheet5.Options.TitlesFormat.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet5.Options.TitlesFormat.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet5.Options.TitlesFormat.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet5.Options.TitlesFormat.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet5.Options.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightYellow
            WorkSheet5.Options.TitlesFormat.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid
            WorkSheet5.Options.TitlesFormat.Font.Bold = True
            WorkSheet5.Options.TitlesFormat.Font.Name = "Arial"
            WorkSheet5.SheetName = "Parts"
            WorkSheet5.SQLCommand = Me.oleDbCommand1
            WorkSheet5.StartDataCol = CType(0, Byte)
            Me.cellExport6.Sheets.Add(WorkSheet5)
            '
            'cellExport7
            '
            Me.cellExport7.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView
            Me.cellExport7.AutoFitColWidth = True
            Me.cellExport7.DataFormats.CultureName = "zh-CN"
            Me.cellExport7.DataFormats.Currency = "гд#,###,##0.00"
            Me.cellExport7.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.cellExport7.DataFormats.Float = "#,###,##0.00"
            Me.cellExport7.DataFormats.Integer = "#,###,##0"
            Me.cellExport7.DataFormats.Time = "H:mm"
            Me.cellExport7.FileName = "chart2.xls"
            Me.cellExport7.SheetOptions.AggregateFormat.Font.Name = "Arial"
            Me.cellExport7.SheetOptions.CustomDataFormat.Font.Name = "Arial"
            Me.cellExport7.SheetOptions.DefaultFont.Name = "Arial"
            Me.cellExport7.SheetOptions.FooterFormat.Font.Name = "Arial"
            Me.cellExport7.SheetOptions.HeaderFormat.Font.Name = "Arial"
            Me.cellExport7.SheetOptions.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            Me.cellExport7.SheetOptions.HyperlinkFormat.Font.Name = "Arial"
            Me.cellExport7.SheetOptions.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            Me.cellExport7.SheetOptions.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            Me.cellExport7.SheetOptions.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            Me.cellExport7.SheetOptions.NoteFormat.Font.Bold = True
            Me.cellExport7.SheetOptions.NoteFormat.Font.Name = "Tahoma"
            Me.cellExport7.SheetOptions.NoteFormat.Font.Size = 8.0!
            Me.cellExport7.SheetOptions.TitlesFormat.Font.Bold = True
            Me.cellExport7.SheetOptions.TitlesFormat.Font.Name = "Arial"
            Chart2.AutoColor = False
            Chart2.CategoryLabels.ColX = CType(1, Byte)
            Chart2.CategoryLabels.ColY = CType(1, Byte)
            Chart2.CategoryLabels.RowX = 1
            Chart2.CategoryLabels.RowY = 9
            Chart2.CategoryLabelsColumn = "PartNo"
            Chart2.DataRangeSheet = "Sheet 2"
            Chart2.Position.AutoPosition.Height = 23
            Chart2.Position.AutoPosition.Left = 1
            Chart2.Position.AutoPosition.Top = 1
            Chart2.Position.AutoPosition.Width = 11
            Chart2.Position.CustomPosition.X1 = CType(1, Byte)
            Chart2.Position.CustomPosition.X2 = CType(15, Byte)
            Chart2.Position.CustomPosition.Y1 = 1
            Chart2.Position.CustomPosition.Y2 = 30
            ChartSeries2.Color = Spire.DataExport.XLS.CellColor.Tan
            ChartSeries2.DataColumn = "Cost"
            ChartSeries2.DataRangeSheet = "Sheet 2"
            ChartSeries2.Title = "Cost"
            Chart2.Series.Add(ChartSeries2)
            Chart2.Style = Spire.DataExport.XLS.ChartStyle.Bar
            Chart2.Title = "Chart demo"
            WorkSheet6.Charts.Add(Chart2)
            WorkSheet6.DataExported = False
            WorkSheet6.FormatsExport.CultureName = "zh-CN"
            WorkSheet6.FormatsExport.Currency = "гд#,###,##0.00"
            WorkSheet6.FormatsExport.DateTime = "yyyy-M-d H:mm"
            WorkSheet6.FormatsExport.Float = "#,###,##0.00"
            WorkSheet6.FormatsExport.Integer = "#,###,##0"
            WorkSheet6.FormatsExport.Time = "H:mm"
            WorkSheet6.Options.AggregateFormat.Font.Name = "Arial"
            WorkSheet6.Options.CustomDataFormat.Font.Name = "Arial"
            WorkSheet6.Options.DefaultFont.Name = "Arial"
            WorkSheet6.Options.FooterFormat.Font.Name = "Arial"
            WorkSheet6.Options.HeaderFormat.Font.Bold = True
            WorkSheet6.Options.HeaderFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            WorkSheet6.Options.HeaderFormat.Font.Name = "Arial"
            WorkSheet6.Options.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            WorkSheet6.Options.HyperlinkFormat.Font.Name = "Arial"
            WorkSheet6.Options.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            WorkSheet6.Options.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            WorkSheet6.Options.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            WorkSheet6.Options.NoteFormat.Font.Bold = True
            WorkSheet6.Options.NoteFormat.Font.Name = "Tahoma"
            WorkSheet6.Options.NoteFormat.Font.Size = 8.0!
            WorkSheet6.Options.TitlesFormat.Font.Bold = True
            WorkSheet6.Options.TitlesFormat.Font.Name = "Times New Roman"
            WorkSheet6.Options.TitlesFormat.Font.Size = 13.0!
            WorkSheet6.SheetName = "charts"
            WorkSheet6.StartDataCol = CType(0, Byte)
            WorkSheet7.AutoFitColWidth = True
            WorkSheet7.FormatsExport.CultureName = "zh-CN"
            WorkSheet7.FormatsExport.Currency = "гд#,###,##0.00"
            WorkSheet7.FormatsExport.DateTime = "yyyy-M-d H:mm"
            WorkSheet7.FormatsExport.Float = "#,###,##0.00"
            WorkSheet7.FormatsExport.Integer = "#,###,##0"
            WorkSheet7.FormatsExport.Time = "H:mm"
            StripStyle7.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle7.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle7.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle7.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle7.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightGreen
            StripStyle7.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid
            StripStyle7.Font.Name = "Arial"
            StripStyle8.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle8.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle8.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle8.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            StripStyle8.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightTurquoise
            StripStyle8.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid
            StripStyle8.Font.Name = "Arial"
            WorkSheet7.ItemStyles.Add(StripStyle7)
            WorkSheet7.ItemStyles.Add(StripStyle8)
            WorkSheet7.ItemType = Spire.DataExport.XLS.CellItemType.Col
            WorkSheet7.Options.AggregateFormat.Font.Name = "Arial"
            WorkSheet7.Options.CustomDataFormat.Font.Name = "Arial"
            WorkSheet7.Options.DefaultFont.Name = "Arial"
            WorkSheet7.Options.FooterFormat.Font.Name = "Arial"
            WorkSheet7.Options.HeaderFormat.Font.Name = "Arial"
            WorkSheet7.Options.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            WorkSheet7.Options.HyperlinkFormat.Font.Name = "Arial"
            WorkSheet7.Options.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            WorkSheet7.Options.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            WorkSheet7.Options.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            WorkSheet7.Options.NoteFormat.Font.Bold = True
            WorkSheet7.Options.NoteFormat.Font.Name = "Tahoma"
            WorkSheet7.Options.NoteFormat.Font.Size = 8.0!
            WorkSheet7.Options.TitlesFormat.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet7.Options.TitlesFormat.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet7.Options.TitlesFormat.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet7.Options.TitlesFormat.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium
            WorkSheet7.Options.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightYellow
            WorkSheet7.Options.TitlesFormat.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid
            WorkSheet7.Options.TitlesFormat.Font.Bold = True
            WorkSheet7.Options.TitlesFormat.Font.Name = "Arial"
            WorkSheet7.SheetName = "Sheet 2"
            WorkSheet7.SQLCommand = Me.oleDbCommand1
            WorkSheet7.StartDataCol = CType(0, Byte)
            Me.cellExport7.Sheets.Add(WorkSheet6)
            Me.cellExport7.Sheets.Add(WorkSheet7)
            Me.cellExport7.SQLCommand = Me.oleDbCommand1
            '
            'cellExport8
            '
            Me.cellExport8.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView
            Me.cellExport8.ColumnsWidth.AddRange(New Object() {"100", "200"})
            Me.cellExport8.DataExported = False
            Me.cellExport8.DataFormats.CultureName = "zh-CN"
            Me.cellExport8.DataFormats.Currency = "гд#,###,##0.00"
            Me.cellExport8.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.cellExport8.DataFormats.Float = "#,###,##0.00"
            Me.cellExport8.DataFormats.Integer = "#,###,##0"
            Me.cellExport8.DataFormats.Time = "H:mm"
            Me.cellExport8.FileName = "formula.xls"
            Me.cellExport8.SheetOptions.AggregateFormat.Font.Name = "Arial"
            Me.cellExport8.SheetOptions.CustomDataFormat.Font.Name = "Arial"
            Me.cellExport8.SheetOptions.DefaultFont.Name = "Arial"
            Me.cellExport8.SheetOptions.FooterFormat.Font.Name = "Arial"
            Me.cellExport8.SheetOptions.HeaderFormat.Font.Name = "Arial"
            Me.cellExport8.SheetOptions.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            Me.cellExport8.SheetOptions.HyperlinkFormat.Font.Name = "Arial"
            Me.cellExport8.SheetOptions.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            Me.cellExport8.SheetOptions.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            Me.cellExport8.SheetOptions.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            Me.cellExport8.SheetOptions.NoteFormat.Font.Bold = True
            Me.cellExport8.SheetOptions.NoteFormat.Font.Name = "Tahoma"
            Me.cellExport8.SheetOptions.NoteFormat.Font.Size = 8.0!
            Me.cellExport8.SheetOptions.TitlesFormat.Font.Bold = True
            Me.cellExport8.SheetOptions.TitlesFormat.Font.Name = "Arial"
            Me.cellExport8.SQLCommand = Me.oleDbCommand1

        End Sub
		#End Region

		Private Sub btnMultiSheet_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMultiSheet.Click
			oleDbConnection1.Open()
            Try
                cellExport1.SaveToHttpResponse("multisheets.xls", Response)
            Finally
                oleDbConnection1.Close()
            End Try

		End Sub

		Private Sub btnCharts_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCharts.Click
			oleDbConnection1.Open()
			Try
                cellExport6.SaveToHttpResponse("charts.xls", Response)
			Finally
				oleDbConnection1.Close()
			End Try

		End Sub

		Private Sub btnImages_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImages.Click
			oleDbConnection1.Open()
			Try
                cellExport3.SaveToHttpResponse("images.xls", Response)
			Finally
				oleDbConnection1.Close()
			End Try
		End Sub

		Private Sub btnStream_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStream.Click
			oleDbConnection1.Open()
			Try
				Dim ms As MemoryStream = New MemoryStream()
				cellExport1.SaveToStream(ms)
				Dim data As Byte() = New Byte(ms.Length - 1){}
				ms.Read(data, 0, data.Length)
				ms.Close()

                Response.ContentType = "application/vnd.ms-excel"
                Response.AddHeader("content-disposition", "attachment;  filename=Stream.xls")
				Response.BinaryWrite(data)
				Response.End()
			Finally
				oleDbConnection1.Close()
			End Try
		End Sub

		Private Sub btnHyberLinks_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHyberLinks.Click
			oleDbConnection1.Open()
			Try
                cellExport5.AddString(Convert.ToUInt16(2), Convert.ToUInt16(4D), "Home Page")
                cellExport5.AddHyperLink(Convert.ToUInt16(2), Convert.ToUInt16(5), "http://www.e-iceblue.com", "http://www.e-iceblue.com")
                cellExport5.AddString(Convert.ToUInt16(2), Convert.ToUInt16(7), "Contact US")
                cellExport5.AddHyperLink(Convert.ToUInt16(2), Convert.ToUInt16(8), "support@e-iceblue.com", "mailto:support@e-iceblue.com")
                cellExport5.AddString(Convert.ToUInt16(2), Convert.ToUInt16(10), "Buy Now!")
                cellExport5.AddHyperLink(Convert.ToUInt16(2), Convert.ToUInt16(11), "http://www.e-iceblue.com/dataexport/exporturchase.htm", "http://www.e-iceblue.com/dataexport/exporturchase.htm")
				cellExport5.SaveToHttpResponse("HyberLinks.xls",Response)
			Finally
				oleDbConnection1.Close()
			End Try
		End Sub

		Private Sub btnTextSample_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTextSample.Click
			oleDbConnection1.Open()
            Try
                cellExport2.SaveToHttpResponse("Texts.xls", Response)
            Finally
                oleDbConnection1.Close()
            End Try
		End Sub

		Private Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click
			Response.Redirect("Default.Aspx")
		End Sub

		Private Sub cellExport1_GetDataParams(ByVal sender As Object, ByVal e As Spire.DataExport.EventArgs.DataParamsEventArgs) Handles cellExport1.GetDataParams, cellExport7.GetDataParams
			If (e.Sheet = 0) AndAlso (e.Col = 6) Then
				e.FormatText = cellExport1.DataFormats.Currency
			End If

			If e.Sheet = 1 Then
				If e.Col = 4 Then
					e.FormatText = cellExport1.DataFormats.DateTime
				End If
				If e.Col = 5 Then
					e.FormatText = cellExport1.DataFormats.Currency
				End If
			End If
		End Sub

		Private Sub Button8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.Click
			oleDbConnection1.Open()
            Try
                cellExport7.SaveToHttpResponse("chart1.xls", Response)
            Finally
                oleDbConnection1.Close()
            End Try
		End Sub

		Private Sub Button10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button10.Click
            Dim currentRow As Integer = 1
            Dim firstCol As UInt16 = Convert.ToUInt16(1)
            Dim secondCol As UInt16 = Convert.ToUInt16(2)
            Dim currentFormula As String = String.Empty

            Dim cell As cell = Nothing

            cellExport8.Cells.Clear()
            cellExport8.SetColumnWidth(System.Convert.ToUInt16(1), System.Convert.ToUInt16(32))
            cellExport8.SetColumnWidth(System.Convert.ToUInt16(2), System.Convert.ToUInt16(16))
            cellExport8.SetColumnWidth(System.Convert.ToUInt16(3), System.Convert.ToUInt16(16))

            cell = cellExport8.AddString(System.Convert.ToUInt16(1), System.Convert.ToUInt16(currentRow), "Examples of formulas :")
            currentRow += 1
            cell.Format.Font.Bold = True
            cell.Format.FillStyle.Background = CellColor.LightGreen
            cell.Format.FillStyle.Pattern = Pattern.Solid
            cell.Format.Borders.Bottom.Style = CellBorderStyle.Medium

            cell = cellExport8.AddString(System.Convert.ToUInt16(1), System.Convert.ToUInt16(currentRow), "Test data:")
            currentRow += 1
            cell.Format.Font.Bold = True
            cell.Format.FillStyle.Background = CellColor.LightGreen
            cell.Format.FillStyle.Pattern = Pattern.Solid
            cell.Format.Borders.Bottom.Style = CellBorderStyle.Medium

            'test data
            cellExport8.AddNumeric(System.Convert.ToUInt16(2), System.Convert.ToUInt16(currentRow), 7.3)
            cellExport8.AddNumeric(System.Convert.ToUInt16(3), System.Convert.ToUInt16(currentRow), 5)
            cellExport8.AddNumeric(System.Convert.ToUInt16(4), System.Convert.ToUInt16(currentRow), 8.2)
            cellExport8.AddNumeric(System.Convert.ToUInt16(5), System.Convert.ToUInt16(currentRow), 4)
            cellExport8.AddNumeric(System.Convert.ToUInt16(6), System.Convert.ToUInt16(currentRow), 3)
            cellExport8.AddNumeric(System.Convert.ToUInt16(7), System.Convert.ToUInt16(currentRow), 11.3)
            currentRow += 1
            currentRow += 1


            cell = cellExport8.AddString(Convert.ToUInt16(1), Convert.ToUInt16(currentRow), "Formulas")
            '            currentRow += 1
            cell.Format.Font.Bold = True
            cell.Format.FillStyle.Background = CellColor.LightGreen
            cell.Format.FillStyle.Pattern = Pattern.Solid
            cell.Format.Borders.Bottom.Style = CellBorderStyle.Medium

            cell = cellExport8.AddString(secondCol, Convert.ToUInt16(currentRow), "Results")
            currentRow += 1
            cell.Format.Font.Bold = True
            cell.Format.FillStyle.Background = CellColor.LightGreen
            cell.Format.FillStyle.Pattern = Pattern.Solid
            cell.Format.Borders.Bottom.Style = CellBorderStyle.Medium

            'str.
            currentFormula = "=""hello"""
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), "=""hello""")
            cellExport8.AddFormula(Convert.ToUInt16(3), Convert.ToUInt16(currentRow), "=""" & ChrW(20320) & ChrW(22909) + """")
            currentRow += 1



            'int.
            currentFormula = "=300"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            ' float
            currentFormula = "=3389.639421"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1


            'bool.
            currentFormula = "=false"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=1+2+3+4+5-6-7+8-9"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=33*3/4-2+10"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            ' sheet reference
            currentFormula = "=Sheet1!$B$3"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            ' sheet area reference
            currentFormula = "=AVERAGE(Sheet1!$D$3:G$3)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            ' Functions
            currentFormula = "=Count(3,5,8,10,2,34)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1


            currentFormula = "=NOW()"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=SECOND(11)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=MINUTE(12)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=MONTH(9)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=DAY(10)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=TIME(4,5,7)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=DATE(6,4,2)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=RAND()"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=HOUR(12)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=TEXT(""world"", ""$d"")"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=MOD(5,3)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=WEEKDAY(3)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=YEAR(23)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=NOT(true)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=OR(true)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=AND(TRUE)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=VALUE(30)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=LEN(""world"")"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=MID(""world"",4,2)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=ROUND(7,3)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=SIGN(4)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=INT(200)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=ABS(-1.21)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=LN(15)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=EXP(20)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=SQRT(40)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=PI()"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=COS(9)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=SIN(45)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=MAX(10,30)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=MIN(5,7)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=AVERAGE(12,45)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=SUM(18,29)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=IF(4,2,2)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1

            currentFormula = "=SUBTOTAL(3,Sheet1!B2:E3)"
            cellExport8.AddString(firstCol, Convert.ToUInt16(currentRow), currentFormula)
            cellExport8.AddFormula(secondCol, Convert.ToUInt16(currentRow), currentFormula)
            currentRow += 1
	    Me.cellExport8.SaveToHttpResponse("formulas", Response)
	End Sub

		Private Sub Button9_Click(ByVal sender As Object, ByVal e As System.EventArgs)

		End Sub
	End Class
End Namespace
                     