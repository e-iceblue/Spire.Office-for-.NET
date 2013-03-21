using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

using Spire.DataExport.XLS;

using System.IO;

namespace Spire.WebDemo
{

	public partial class CellSample : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.Button Button3;
		protected System.Web.UI.WebControls.Button Button4;
		protected System.Web.UI.WebControls.Button Button5;
		protected System.Web.UI.WebControls.Button Button6;
		protected System.Web.UI.WebControls.Button Button7;
		protected Spire.DataExport.XLS.CellExport cellExport1;
		protected System.Data.OleDb.OleDbConnection oleDbConnection1;
		protected System.Data.OleDb.OleDbCommand oleDbCommand1;
		protected System.Data.OleDb.OleDbCommand oleDbCommand2;
		protected Spire.DataExport.XLS.CellExport cellExport2;
		protected Spire.DataExport.XLS.CellExport cellExport3;
		protected Spire.DataExport.XLS.CellExport cellExport4;
		protected Spire.DataExport.XLS.CellExport cellExport5;
		protected Spire.DataExport.XLS.CellExport cellExport6;
		protected Spire.DataExport.XLS.CellExport cellExport7;
		protected Spire.DataExport.XLS.CellExport cellExport8;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			string path = MapPath(".");						
			path = path.Substring(0, path.LastIndexOf("\\"));	
			oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + 
				"\\..\\Database\\demo.mdb";
			this.oleDbCommand1.CommandText = "SELECT * FROM PARTS";
			this.oleDbCommand2.CommandText = "SELECT * FROM Employee";
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			Spire.DataExport.XLS.WorkSheet workSheet1 = new Spire.DataExport.XLS.WorkSheet();
			Spire.DataExport.XLS.ColumnFormat columnFormat1 = new Spire.DataExport.XLS.ColumnFormat();
			Spire.DataExport.XLS.StripStyle stripStyle1 = new Spire.DataExport.XLS.StripStyle();
			Spire.DataExport.XLS.StripStyle stripStyle2 = new Spire.DataExport.XLS.StripStyle();
			Spire.DataExport.XLS.WorkSheet workSheet2 = new Spire.DataExport.XLS.WorkSheet();
			Spire.DataExport.XLS.StripStyle stripStyle3 = new Spire.DataExport.XLS.StripStyle();
			Spire.DataExport.XLS.StripStyle stripStyle4 = new Spire.DataExport.XLS.StripStyle();
			Spire.DataExport.XLS.WorkSheet workSheet3 = new Spire.DataExport.XLS.WorkSheet();
			Spire.DataExport.XLS.ColumnFormat columnFormat2 = new Spire.DataExport.XLS.ColumnFormat();
			Spire.DataExport.XLS.ColumnFormat columnFormat3 = new Spire.DataExport.XLS.ColumnFormat();
			Spire.DataExport.XLS.ColumnFormat columnFormat4 = new Spire.DataExport.XLS.ColumnFormat();
			Spire.DataExport.XLS.ColumnFormat columnFormat5 = new Spire.DataExport.XLS.ColumnFormat();
			Spire.DataExport.XLS.ColumnFormat columnFormat6 = new Spire.DataExport.XLS.ColumnFormat();
			Spire.DataExport.XLS.CellPicture cellPicture1 = new Spire.DataExport.XLS.CellPicture();
			Spire.DataExport.XLS.WorkSheet workSheet4 = new Spire.DataExport.XLS.WorkSheet();
			Spire.DataExport.XLS.CellImage cellImage1 = new Spire.DataExport.XLS.CellImage();
			Spire.DataExport.XLS.CellImage cellImage2 = new Spire.DataExport.XLS.CellImage();
			Spire.DataExport.XLS.WorkSheet workSheet5 = new Spire.DataExport.XLS.WorkSheet();
			Spire.DataExport.XLS.Chart chart1 = new Spire.DataExport.XLS.Chart();
			Spire.DataExport.XLS.ChartSeries chartSeries1 = new Spire.DataExport.XLS.ChartSeries();
			Spire.DataExport.XLS.StripStyle stripStyle5 = new Spire.DataExport.XLS.StripStyle();
			Spire.DataExport.XLS.StripStyle stripStyle6 = new Spire.DataExport.XLS.StripStyle();
			Spire.DataExport.XLS.WorkSheet workSheet6 = new Spire.DataExport.XLS.WorkSheet();
			Spire.DataExport.XLS.Chart chart2 = new Spire.DataExport.XLS.Chart();
			Spire.DataExport.XLS.ChartSeries chartSeries2 = new Spire.DataExport.XLS.ChartSeries();
			Spire.DataExport.XLS.WorkSheet workSheet7 = new Spire.DataExport.XLS.WorkSheet();
			Spire.DataExport.XLS.StripStyle stripStyle7 = new Spire.DataExport.XLS.StripStyle();
			Spire.DataExport.XLS.StripStyle stripStyle8 = new Spire.DataExport.XLS.StripStyle();
			this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbCommand2 = new System.Data.OleDb.OleDbCommand();
			this.cellExport1 = new Spire.DataExport.XLS.CellExport();
			this.cellExport2 = new Spire.DataExport.XLS.CellExport();
			this.cellExport3 = new Spire.DataExport.XLS.CellExport();
			this.cellExport5 = new Spire.DataExport.XLS.CellExport();
			this.cellExport6 = new Spire.DataExport.XLS.CellExport();
			this.cellExport7 = new Spire.DataExport.XLS.CellExport();
			this.cellExport8 = new Spire.DataExport.XLS.CellExport();
			// 
			// oleDbCommand1
			// 
			this.oleDbCommand1.CommandText = "SELECT * FROM PARTS";
			this.oleDbCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source="".\..\database\demo.mdb"";Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// oleDbCommand2
			// 
			this.oleDbCommand2.CommandText = "SELECT * FROM Employee";
			this.oleDbCommand2.Connection = this.oleDbConnection1;
			// 
			// cellExport1
			// 
			this.cellExport1.DataFormats.CultureName = "zh-CN";
			this.cellExport1.DataFormats.Currency = "$#,###,##0.00";
			this.cellExport1.DataFormats.DateTime = "yyyy-M-d";
			this.cellExport1.DataFormats.Float = "#,###,##0.00";
			this.cellExport1.DataFormats.Integer = "#,###,##0";
			this.cellExport1.DataFormats.Time = "H:mm";
			this.cellExport1.SheetOptions.AggregateFormat.Font.Name = "Arial";
			this.cellExport1.SheetOptions.CustomDataFormat.Font.Name = "Arial";
			this.cellExport1.SheetOptions.DefaultFont.Name = "Arial";
			this.cellExport1.SheetOptions.FooterFormat.Font.Name = "Arial";
			this.cellExport1.SheetOptions.HeaderFormat.Font.Name = "Arial";
			this.cellExport1.SheetOptions.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue;
			this.cellExport1.SheetOptions.HyperlinkFormat.Font.Name = "Arial";
			this.cellExport1.SheetOptions.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single;
			this.cellExport1.SheetOptions.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left;
			this.cellExport1.SheetOptions.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top;
			this.cellExport1.SheetOptions.NoteFormat.Font.Bold = true;
			this.cellExport1.SheetOptions.NoteFormat.Font.Name = "Tahoma";
			this.cellExport1.SheetOptions.NoteFormat.Font.Size = 8F;
			this.cellExport1.SheetOptions.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.Gray40Percent;
			this.cellExport1.SheetOptions.TitlesFormat.Font.Bold = true;
			this.cellExport1.SheetOptions.TitlesFormat.Font.Name = "Arial";
			workSheet1.AutoFitColWidth = true;
			columnFormat1.FieldName = "ListPrice";
			columnFormat1.Font.Name = "Arial";
			columnFormat1.Width = 8;
			workSheet1.ColumnFormats.Add(columnFormat1);
			workSheet1.FormatsExport.CultureName = "zh-CN";
			workSheet1.FormatsExport.Currency = "гд#,###,##0.00";
			workSheet1.FormatsExport.DateTime = "yyyy-M-d H:mm";
			workSheet1.FormatsExport.Float = "#,###,##0.00";
			workSheet1.FormatsExport.Integer = "#,###,##0";
			workSheet1.FormatsExport.Time = "H:mm";
			stripStyle1.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle1.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle1.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle1.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle1.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightGreen;
			stripStyle1.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid;
			stripStyle1.Font.Name = "Arial";
			stripStyle2.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle2.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle2.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle2.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle2.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightTurquoise;
			stripStyle2.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid;
			stripStyle2.Font.Name = "Arial";
			workSheet1.ItemStyles.Add(stripStyle1);
			workSheet1.ItemStyles.Add(stripStyle2);
			workSheet1.ItemType = Spire.DataExport.XLS.CellItemType.Row;
			workSheet1.Options.AggregateFormat.Font.Name = "Arial";
			workSheet1.Options.CustomDataFormat.Font.Name = "Arial";
			workSheet1.Options.DefaultFont.Name = "Arial";
			workSheet1.Options.FooterFormat.Font.Name = "Arial";
			workSheet1.Options.HeaderFormat.Font.Name = "Arial";
			workSheet1.Options.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue;
			workSheet1.Options.HyperlinkFormat.Font.Name = "Arial";
			workSheet1.Options.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single;
			workSheet1.Options.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left;
			workSheet1.Options.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top;
			workSheet1.Options.NoteFormat.Font.Bold = true;
			workSheet1.Options.NoteFormat.Font.Name = "Tahoma";
			workSheet1.Options.NoteFormat.Font.Size = 8F;
			workSheet1.Options.TitlesFormat.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			workSheet1.Options.TitlesFormat.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			workSheet1.Options.TitlesFormat.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			workSheet1.Options.TitlesFormat.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			workSheet1.Options.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightYellow;
			workSheet1.Options.TitlesFormat.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid;
			workSheet1.Options.TitlesFormat.Font.Bold = true;
			workSheet1.Options.TitlesFormat.Font.Name = "Arial";
			workSheet1.SheetName = "Parts";
			workSheet1.SQLCommand = this.oleDbCommand1;
			workSheet1.StartDataCol = ((System.Byte)(0));
			workSheet2.AutoFitColWidth = true;
			workSheet2.FormatsExport.CultureName = "zh-CN";
			workSheet2.FormatsExport.Currency = "гд#,###,##0.00";
			workSheet2.FormatsExport.DateTime = "yyyy-M-d H:mm";
			workSheet2.FormatsExport.Float = "#,###,##0.00";
			workSheet2.FormatsExport.Integer = "#,###,##0";
			workSheet2.FormatsExport.Time = "H:mm";
			stripStyle3.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle3.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle3.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle3.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle3.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightGreen;
			stripStyle3.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid;
			stripStyle3.Font.Name = "Arial";
			stripStyle4.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle4.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle4.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle4.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle4.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightTurquoise;
			stripStyle4.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid;
			stripStyle4.Font.Name = "Arial";
			workSheet2.ItemStyles.Add(stripStyle3);
			workSheet2.ItemStyles.Add(stripStyle4);
			workSheet2.ItemType = Spire.DataExport.XLS.CellItemType.Col;
			workSheet2.Options.AggregateFormat.Font.Name = "Arial";
			workSheet2.Options.CustomDataFormat.Font.Name = "Arial";
			workSheet2.Options.DefaultFont.Name = "Arial";
			workSheet2.Options.FooterFormat.Font.Name = "Arial";
			workSheet2.Options.HeaderFormat.Font.Name = "Arial";
			workSheet2.Options.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue;
			workSheet2.Options.HyperlinkFormat.Font.Name = "Arial";
			workSheet2.Options.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single;
			workSheet2.Options.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left;
			workSheet2.Options.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top;
			workSheet2.Options.NoteFormat.Font.Bold = true;
			workSheet2.Options.NoteFormat.Font.Name = "Tahoma";
			workSheet2.Options.NoteFormat.Font.Size = 8F;
			workSheet2.Options.TitlesFormat.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			workSheet2.Options.TitlesFormat.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			workSheet2.Options.TitlesFormat.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			workSheet2.Options.TitlesFormat.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			workSheet2.Options.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightYellow;
			workSheet2.Options.TitlesFormat.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid;
			workSheet2.Options.TitlesFormat.Font.Bold = true;
			workSheet2.Options.TitlesFormat.Font.Name = "Arial";
			workSheet2.SheetName = "Orders";
			workSheet2.SQLCommand = this.oleDbCommand2;
			workSheet2.StartDataCol = ((System.Byte)(0));
			this.cellExport1.Sheets.Add(workSheet1);
			this.cellExport1.Sheets.Add(workSheet2);
			this.cellExport1.GetDataParams += new Spire.DataExport.Delegates.DataParamsEventHandler(this.cellExport1_GetDataParams);
			// 
			// cellExport2
			// 
			this.cellExport2.DataFormats.CultureName = "zh-CN";
			this.cellExport2.DataFormats.Currency = "гд#,###,##0.00";
			this.cellExport2.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.cellExport2.DataFormats.Float = "#,###,##0.00";
			this.cellExport2.DataFormats.Integer = "#,###,##0";
			this.cellExport2.DataFormats.Time = "H:mm";
			this.cellExport2.SheetOptions.AggregateFormat.Font.Name = "Arial";
			this.cellExport2.SheetOptions.CustomDataFormat.Font.Name = "Arial";
			this.cellExport2.SheetOptions.DefaultFont.Name = "Arial";
			this.cellExport2.SheetOptions.FooterFormat.Font.Name = "Arial";
			this.cellExport2.SheetOptions.HeaderFormat.Font.Name = "Arial";
			this.cellExport2.SheetOptions.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue;
			this.cellExport2.SheetOptions.HyperlinkFormat.Font.Name = "Arial";
			this.cellExport2.SheetOptions.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single;
			this.cellExport2.SheetOptions.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left;
			this.cellExport2.SheetOptions.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top;
			this.cellExport2.SheetOptions.NoteFormat.Font.Bold = true;
			this.cellExport2.SheetOptions.NoteFormat.Font.Name = "Tahoma";
			this.cellExport2.SheetOptions.NoteFormat.Font.Size = 8F;
			this.cellExport2.SheetOptions.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.Gray40Percent;
			this.cellExport2.SheetOptions.TitlesFormat.Font.Bold = true;
			this.cellExport2.SheetOptions.TitlesFormat.Font.Name = "Arial";
			columnFormat2.FieldName = "PartNo";
			columnFormat2.Font.Bold = true;
			columnFormat2.Font.Name = "Arial";
			columnFormat3.FieldName = "VendorNo";
			columnFormat3.Font.Color = Spire.DataExport.XLS.CellColor.Color1;
			columnFormat3.Font.Italic = true;
			columnFormat3.Font.Name = "Arial";
			columnFormat4.FieldName = "Description";
			columnFormat4.Font.Name = "Arial";
			columnFormat4.Font.Strikeout = true;
			columnFormat4.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.DoubleAccounting;
			columnFormat5.FieldName = "OnHand";
			columnFormat5.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightTurquoise;
			columnFormat5.FillStyle.Foreground = Spire.DataExport.XLS.CellColor.Pink;
			columnFormat5.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.ThinGorizontal;
			columnFormat5.Font.Name = "Arial";
			columnFormat6.FieldName = "ListPrice";
			columnFormat6.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightYellow;
			columnFormat6.FillStyle.Foreground = Spire.DataExport.XLS.CellColor.SkyBlue;
			columnFormat6.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.ThinVertical;
			columnFormat6.Font.Name = "Arial";
			workSheet3.ColumnFormats.Add(columnFormat2);
			workSheet3.ColumnFormats.Add(columnFormat3);
			workSheet3.ColumnFormats.Add(columnFormat4);
			workSheet3.ColumnFormats.Add(columnFormat5);
			workSheet3.ColumnFormats.Add(columnFormat6);
			workSheet3.FormatsExport.CultureName = "zh-CN";
			workSheet3.FormatsExport.Currency = "гд#,###,##0.00";
			workSheet3.FormatsExport.DateTime = "yyyy-M-d H:mm";
			workSheet3.FormatsExport.Float = "#,###,##0.00";
			workSheet3.FormatsExport.Integer = "#,###,##0";
			workSheet3.FormatsExport.Time = "H:mm";
			workSheet3.Options.AggregateFormat.Font.Name = "Arial";
			workSheet3.Options.CustomDataFormat.Font.Name = "Arial";
			workSheet3.Options.DefaultFont.Name = "Arial";
			workSheet3.Options.FooterFormat.Font.Name = "Arial";
			workSheet3.Options.HeaderFormat.Font.Name = "Arial";
			workSheet3.Options.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue;
			workSheet3.Options.HyperlinkFormat.Font.Name = "Arial";
			workSheet3.Options.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single;
			workSheet3.Options.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left;
			workSheet3.Options.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top;
			workSheet3.Options.NoteFormat.Font.Bold = true;
			workSheet3.Options.NoteFormat.Font.Name = "Tahoma";
			workSheet3.Options.NoteFormat.Font.Size = 8F;
			workSheet3.Options.TitlesFormat.Font.Bold = true;
			workSheet3.Options.TitlesFormat.Font.Name = "Arial";
			workSheet3.SheetName = "Sheet 1";
			workSheet3.SQLCommand = this.oleDbCommand1;
			workSheet3.StartDataCol = ((System.Byte)(0));
			this.cellExport2.Sheets.Add(workSheet3);
			// 
			// cellExport3
			// 
			this.cellExport3.DataFormats.CultureName = "zh-CN";
			this.cellExport3.DataFormats.Currency = "гд#,###,##0.00";
			this.cellExport3.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.cellExport3.DataFormats.Float = "#,###,##0.00";
			this.cellExport3.DataFormats.Integer = "#,###,##0";
			this.cellExport3.DataFormats.Time = "H:mm";
			cellPicture1.FileName = "images/sample.gif";
			cellPicture1.Name = "Picture_0";
			this.cellExport3.Pictures.Add(cellPicture1);
			this.cellExport3.SheetOptions.AggregateFormat.Font.Name = "Arial";
			this.cellExport3.SheetOptions.CustomDataFormat.Font.Name = "Arial";
			this.cellExport3.SheetOptions.DefaultFont.Name = "Arial";
			this.cellExport3.SheetOptions.FooterFormat.Font.Name = "Arial";
			this.cellExport3.SheetOptions.HeaderFormat.Font.Name = "Arial";
			this.cellExport3.SheetOptions.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue;
			this.cellExport3.SheetOptions.HyperlinkFormat.Font.Name = "Arial";
			this.cellExport3.SheetOptions.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single;
			this.cellExport3.SheetOptions.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left;
			this.cellExport3.SheetOptions.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top;
			this.cellExport3.SheetOptions.NoteFormat.Font.Bold = true;
			this.cellExport3.SheetOptions.NoteFormat.Font.Name = "Tahoma";
			this.cellExport3.SheetOptions.NoteFormat.Font.Size = 8F;
			this.cellExport3.SheetOptions.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.Gray40Percent;
			this.cellExport3.SheetOptions.TitlesFormat.Font.Bold = true;
			this.cellExport3.SheetOptions.TitlesFormat.Font.Name = "Arial";
			workSheet4.DataExported = false;
			workSheet4.FormatsExport.CultureName = "zh-CN";
			workSheet4.FormatsExport.Currency = "гд#,###,##0.00";
			workSheet4.FormatsExport.DateTime = "yyyy-M-d H:mm";
			workSheet4.FormatsExport.Float = "#,###,##0.00";
			workSheet4.FormatsExport.Integer = "#,###,##0";
			workSheet4.FormatsExport.Time = "H:mm";
			cellImage1.Column = 1;
			cellImage1.PictureName = "Picture_0";
			cellImage1.Row = 1;
			cellImage1.Title = "Image_0";
			cellImage2.Column = 1;
			cellImage2.PictureName = "Picture_0";
			cellImage2.Row = 16;
			cellImage2.Title = "Image_1";
			workSheet4.Images.Add(cellImage1);
			workSheet4.Images.Add(cellImage2);
			workSheet4.ItemType = Spire.DataExport.XLS.CellItemType.Col;
			workSheet4.Options.AggregateFormat.Font.Name = "Arial";
			workSheet4.Options.CustomDataFormat.Font.Name = "Arial";
			workSheet4.Options.DefaultFont.Name = "Arial";
			workSheet4.Options.FooterFormat.Font.Name = "Arial";
			workSheet4.Options.HeaderFormat.Font.Name = "Arial";
			workSheet4.Options.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue;
			workSheet4.Options.HyperlinkFormat.Font.Name = "Arial";
			workSheet4.Options.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single;
			workSheet4.Options.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left;
			workSheet4.Options.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top;
			workSheet4.Options.NoteFormat.Font.Bold = true;
			workSheet4.Options.NoteFormat.Font.Name = "Tahoma";
			workSheet4.Options.NoteFormat.Font.Size = 8F;
			workSheet4.Options.TitlesFormat.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			workSheet4.Options.TitlesFormat.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			workSheet4.Options.TitlesFormat.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			workSheet4.Options.TitlesFormat.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			workSheet4.Options.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightYellow;
			workSheet4.Options.TitlesFormat.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid;
			workSheet4.Options.TitlesFormat.Font.Bold = true;
			workSheet4.Options.TitlesFormat.Font.Name = "Arial";
			workSheet4.SheetName = "Parts";
			workSheet4.StartDataCol = ((System.Byte)(0));
			this.cellExport3.Sheets.Add(workSheet4);
			// 
			// cellExport5
			// 
			this.cellExport5.DataExported = false;
			this.cellExport5.DataFormats.CultureName = "zh-CN";
			this.cellExport5.DataFormats.Currency = "гд#,###,##0.00";
			this.cellExport5.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.cellExport5.DataFormats.Float = "#,###,##0.00";
			this.cellExport5.DataFormats.Integer = "#,###,##0";
			this.cellExport5.DataFormats.Time = "H:mm";
			this.cellExport5.SheetOptions.AggregateFormat.Font.Name = "Arial";
			this.cellExport5.SheetOptions.CustomDataFormat.Font.Name = "Arial";
			this.cellExport5.SheetOptions.DefaultFont.Name = "Arial";
			this.cellExport5.SheetOptions.FooterFormat.Font.Name = "Arial";
			this.cellExport5.SheetOptions.HeaderFormat.Font.Name = "Arial";
			this.cellExport5.SheetOptions.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue;
			this.cellExport5.SheetOptions.HyperlinkFormat.Font.Name = "Arial";
			this.cellExport5.SheetOptions.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single;
			this.cellExport5.SheetOptions.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left;
			this.cellExport5.SheetOptions.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top;
			this.cellExport5.SheetOptions.NoteFormat.Font.Bold = true;
			this.cellExport5.SheetOptions.NoteFormat.Font.Name = "Tahoma";
			this.cellExport5.SheetOptions.NoteFormat.Font.Size = 8F;
			this.cellExport5.SheetOptions.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.Gray40Percent;
			this.cellExport5.SheetOptions.TitlesFormat.Font.Bold = true;
			this.cellExport5.SheetOptions.TitlesFormat.Font.Name = "Arial";
			// 
			// cellExport6
			// 
			this.cellExport6.DataFormats.CultureName = "zh-CN";
			this.cellExport6.DataFormats.Currency = "гд#,###,##0.00";
			this.cellExport6.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.cellExport6.DataFormats.Float = "#,###,##0.00";
			this.cellExport6.DataFormats.Integer = "#,###,##0";
			this.cellExport6.DataFormats.Time = "H:mm";
			this.cellExport6.SheetOptions.AggregateFormat.Font.Name = "Arial";
			this.cellExport6.SheetOptions.CustomDataFormat.Font.Name = "Arial";
			this.cellExport6.SheetOptions.DefaultFont.Name = "Arial";
			this.cellExport6.SheetOptions.FooterFormat.Font.Name = "Arial";
			this.cellExport6.SheetOptions.HeaderFormat.Font.Name = "Arial";
			this.cellExport6.SheetOptions.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue;
			this.cellExport6.SheetOptions.HyperlinkFormat.Font.Name = "Arial";
			this.cellExport6.SheetOptions.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single;
			this.cellExport6.SheetOptions.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left;
			this.cellExport6.SheetOptions.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top;
			this.cellExport6.SheetOptions.NoteFormat.Font.Bold = true;
			this.cellExport6.SheetOptions.NoteFormat.Font.Name = "Tahoma";
			this.cellExport6.SheetOptions.NoteFormat.Font.Size = 8F;
			this.cellExport6.SheetOptions.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.Gray40Percent;
			this.cellExport6.SheetOptions.TitlesFormat.Font.Bold = true;
			this.cellExport6.SheetOptions.TitlesFormat.Font.Name = "Arial";
			workSheet5.AutoFitColWidth = true;
			chart1.CategoryLabelsColumn = "PartNo";
			chart1.DataRangeSheet = "";
			chart1.Position.AutoPosition.Placement = Spire.DataExport.XLS.ChartPlacement.Right;
			chartSeries1.DataColumn = "ListPrice";
			chartSeries1.DataRangeSheet = "";
			chart1.Series.Add(chartSeries1);
			chart1.Style = Spire.DataExport.XLS.ChartStyle.Pie3d;
			workSheet5.Charts.Add(chart1);
			workSheet5.FormatsExport.CultureName = "zh-CN";
			workSheet5.FormatsExport.Currency = "гд#,###,##0.00";
			workSheet5.FormatsExport.DateTime = "yyyy-M-d H:mm";
			workSheet5.FormatsExport.Float = "#,###,##0.00";
			workSheet5.FormatsExport.Integer = "#,###,##0";
			workSheet5.FormatsExport.Time = "H:mm";
			stripStyle5.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle5.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle5.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle5.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle5.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightGreen;
			stripStyle5.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid;
			stripStyle5.Font.Name = "Arial";
			stripStyle6.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle6.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle6.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle6.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle6.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightTurquoise;
			stripStyle6.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid;
			stripStyle6.Font.Name = "Arial";
			workSheet5.ItemStyles.Add(stripStyle5);
			workSheet5.ItemStyles.Add(stripStyle6);
			workSheet5.ItemType = Spire.DataExport.XLS.CellItemType.Col;
			workSheet5.Options.AggregateFormat.Font.Name = "Arial";
			workSheet5.Options.CustomDataFormat.Font.Name = "Arial";
			workSheet5.Options.DefaultFont.Name = "Arial";
			workSheet5.Options.FooterFormat.Font.Name = "Arial";
			workSheet5.Options.HeaderFormat.Font.Name = "Arial";
			workSheet5.Options.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue;
			workSheet5.Options.HyperlinkFormat.Font.Name = "Arial";
			workSheet5.Options.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single;
			workSheet5.Options.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left;
			workSheet5.Options.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top;
			workSheet5.Options.NoteFormat.Font.Bold = true;
			workSheet5.Options.NoteFormat.Font.Name = "Tahoma";
			workSheet5.Options.NoteFormat.Font.Size = 8F;
			workSheet5.Options.TitlesFormat.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			workSheet5.Options.TitlesFormat.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			workSheet5.Options.TitlesFormat.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			workSheet5.Options.TitlesFormat.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			workSheet5.Options.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightYellow;
			workSheet5.Options.TitlesFormat.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid;
			workSheet5.Options.TitlesFormat.Font.Bold = true;
			workSheet5.Options.TitlesFormat.Font.Name = "Arial";
			workSheet5.SheetName = "Parts";
			workSheet5.SQLCommand = this.oleDbCommand1;
			workSheet5.StartDataCol = ((System.Byte)(0));
			this.cellExport6.Sheets.Add(workSheet5);
			// 
			// cellExport7
			// 
			this.cellExport7.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
			this.cellExport7.AutoFitColWidth = true;
			this.cellExport7.DataFormats.CultureName = "zh-CN";
			this.cellExport7.DataFormats.Currency = "гд#,###,##0.00";
			this.cellExport7.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.cellExport7.DataFormats.Float = "#,###,##0.00";
			this.cellExport7.DataFormats.Integer = "#,###,##0";
			this.cellExport7.DataFormats.Time = "H:mm";
			this.cellExport7.FileName = "chart2.xls";
			this.cellExport7.SheetOptions.AggregateFormat.Font.Name = "Arial";
			this.cellExport7.SheetOptions.CustomDataFormat.Font.Name = "Arial";
			this.cellExport7.SheetOptions.DefaultFont.Name = "Arial";
			this.cellExport7.SheetOptions.FooterFormat.Font.Name = "Arial";
			this.cellExport7.SheetOptions.HeaderFormat.Font.Name = "Arial";
			this.cellExport7.SheetOptions.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue;
			this.cellExport7.SheetOptions.HyperlinkFormat.Font.Name = "Arial";
			this.cellExport7.SheetOptions.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single;
			this.cellExport7.SheetOptions.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left;
			this.cellExport7.SheetOptions.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top;
			this.cellExport7.SheetOptions.NoteFormat.Font.Bold = true;
			this.cellExport7.SheetOptions.NoteFormat.Font.Name = "Tahoma";
			this.cellExport7.SheetOptions.NoteFormat.Font.Size = 8F;
			this.cellExport7.SheetOptions.TitlesFormat.Font.Bold = true;
			this.cellExport7.SheetOptions.TitlesFormat.Font.Name = "Arial";
			chart2.AutoColor = false;
			chart2.CategoryLabels.ColX = ((System.Byte)(1));
			chart2.CategoryLabels.ColY = ((System.Byte)(1));
			chart2.CategoryLabels.RowX = 1;
			chart2.CategoryLabels.RowY = 9;
			chart2.CategoryLabelsColumn = "PartNo";
			chart2.DataRangeSheet = "Sheet 2";
			chart2.Position.AutoPosition.Height = 23;
			chart2.Position.AutoPosition.Left = 1;
			chart2.Position.AutoPosition.Top = 1;
			chart2.Position.AutoPosition.Width = 11;
			chart2.Position.CustomPosition.X1 = ((System.Byte)(1));
			chart2.Position.CustomPosition.X2 = ((System.Byte)(15));
			chart2.Position.CustomPosition.Y1 = 1;
			chart2.Position.CustomPosition.Y2 = 30;
			chartSeries2.Color = Spire.DataExport.XLS.CellColor.Tan;
			chartSeries2.DataColumn = "Cost";
			chartSeries2.DataRangeSheet = "Sheet 2";
			chartSeries2.Title = "Cost";
			chart2.Series.Add(chartSeries2);
			chart2.Style = Spire.DataExport.XLS.ChartStyle.Bar;
			chart2.Title = "Chart demo";
			workSheet6.Charts.Add(chart2);
			workSheet6.DataExported = false;
			workSheet6.FormatsExport.CultureName = "zh-CN";
			workSheet6.FormatsExport.Currency = "гд#,###,##0.00";
			workSheet6.FormatsExport.DateTime = "yyyy-M-d H:mm";
			workSheet6.FormatsExport.Float = "#,###,##0.00";
			workSheet6.FormatsExport.Integer = "#,###,##0";
			workSheet6.FormatsExport.Time = "H:mm";
			workSheet6.Options.AggregateFormat.Font.Name = "Arial";
			workSheet6.Options.CustomDataFormat.Font.Name = "Arial";
			workSheet6.Options.DefaultFont.Name = "Arial";
			workSheet6.Options.FooterFormat.Font.Name = "Arial";
			workSheet6.Options.HeaderFormat.Font.Bold = true;
			workSheet6.Options.HeaderFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue;
			workSheet6.Options.HeaderFormat.Font.Name = "Arial";
			workSheet6.Options.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue;
			workSheet6.Options.HyperlinkFormat.Font.Name = "Arial";
			workSheet6.Options.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single;
			workSheet6.Options.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left;
			workSheet6.Options.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top;
			workSheet6.Options.NoteFormat.Font.Bold = true;
			workSheet6.Options.NoteFormat.Font.Name = "Tahoma";
			workSheet6.Options.NoteFormat.Font.Size = 8F;
			workSheet6.Options.TitlesFormat.Font.Bold = true;
			workSheet6.Options.TitlesFormat.Font.Name = "Times New Roman";
			workSheet6.Options.TitlesFormat.Font.Size = 13F;
			workSheet6.SheetName = "charts";
			workSheet6.StartDataCol = ((System.Byte)(0));
			workSheet7.AutoFitColWidth = true;
			workSheet7.FormatsExport.CultureName = "zh-CN";
			workSheet7.FormatsExport.Currency = "гд#,###,##0.00";
			workSheet7.FormatsExport.DateTime = "yyyy-M-d H:mm";
			workSheet7.FormatsExport.Float = "#,###,##0.00";
			workSheet7.FormatsExport.Integer = "#,###,##0";
			workSheet7.FormatsExport.Time = "H:mm";
			stripStyle7.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle7.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle7.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle7.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle7.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightGreen;
			stripStyle7.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid;
			stripStyle7.Font.Name = "Arial";
			stripStyle8.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle8.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle8.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle8.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			stripStyle8.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightTurquoise;
			stripStyle8.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid;
			stripStyle8.Font.Name = "Arial";
			workSheet7.ItemStyles.Add(stripStyle7);
			workSheet7.ItemStyles.Add(stripStyle8);
			workSheet7.ItemType = Spire.DataExport.XLS.CellItemType.Col;
			workSheet7.Options.AggregateFormat.Font.Name = "Arial";
			workSheet7.Options.CustomDataFormat.Font.Name = "Arial";
			workSheet7.Options.DefaultFont.Name = "Arial";
			workSheet7.Options.FooterFormat.Font.Name = "Arial";
			workSheet7.Options.HeaderFormat.Font.Name = "Arial";
			workSheet7.Options.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue;
			workSheet7.Options.HyperlinkFormat.Font.Name = "Arial";
			workSheet7.Options.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single;
			workSheet7.Options.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left;
			workSheet7.Options.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top;
			workSheet7.Options.NoteFormat.Font.Bold = true;
			workSheet7.Options.NoteFormat.Font.Name = "Tahoma";
			workSheet7.Options.NoteFormat.Font.Size = 8F;
			workSheet7.Options.TitlesFormat.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			workSheet7.Options.TitlesFormat.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			workSheet7.Options.TitlesFormat.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			workSheet7.Options.TitlesFormat.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			workSheet7.Options.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightYellow;
			workSheet7.Options.TitlesFormat.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid;
			workSheet7.Options.TitlesFormat.Font.Bold = true;
			workSheet7.Options.TitlesFormat.Font.Name = "Arial";
			workSheet7.SheetName = "Sheet 2";
			workSheet7.SQLCommand = this.oleDbCommand1;
			workSheet7.StartDataCol = ((System.Byte)(0));
			this.cellExport7.Sheets.Add(workSheet6);
			this.cellExport7.Sheets.Add(workSheet7);
			this.cellExport7.SQLCommand = this.oleDbCommand1;
			this.cellExport7.GetDataParams += new Spire.DataExport.Delegates.DataParamsEventHandler(this.cellExport1_GetDataParams);
			// 
			// cellExport8
			// 
			this.cellExport8.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
			this.cellExport8.ColumnsWidth.AddRange(new object[] {
																	"100",
																	"200"});
			this.cellExport8.DataExported = false;
			this.cellExport8.DataFormats.CultureName = "zh-CN";
			this.cellExport8.DataFormats.Currency = "гд#,###,##0.00";
			this.cellExport8.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.cellExport8.DataFormats.Float = "#,###,##0.00";
			this.cellExport8.DataFormats.Integer = "#,###,##0";
			this.cellExport8.DataFormats.Time = "H:mm";
			this.cellExport8.FileName = "formula.xls";
			this.cellExport8.SheetOptions.AggregateFormat.Font.Name = "Arial";
			this.cellExport8.SheetOptions.CustomDataFormat.Font.Name = "Arial";
			this.cellExport8.SheetOptions.DefaultFont.Name = "Arial";
			this.cellExport8.SheetOptions.FooterFormat.Font.Name = "Arial";
			this.cellExport8.SheetOptions.HeaderFormat.Font.Name = "Arial";
			this.cellExport8.SheetOptions.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue;
			this.cellExport8.SheetOptions.HyperlinkFormat.Font.Name = "Arial";
			this.cellExport8.SheetOptions.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single;
			this.cellExport8.SheetOptions.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left;
			this.cellExport8.SheetOptions.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top;
			this.cellExport8.SheetOptions.NoteFormat.Font.Bold = true;
			this.cellExport8.SheetOptions.NoteFormat.Font.Name = "Tahoma";
			this.cellExport8.SheetOptions.NoteFormat.Font.Size = 8F;
			this.cellExport8.SheetOptions.TitlesFormat.Font.Bold = true;
			this.cellExport8.SheetOptions.TitlesFormat.Font.Name = "Arial";
			this.cellExport8.SQLCommand = this.oleDbCommand1;

		}
		#endregion

		protected void btnMultiSheet_Click(object sender, System.EventArgs e)
		{
			oleDbConnection1.Open();
			try
			{
				cellExport1.SaveToHttpResponse("multisheets.xls",Response);
			}
			finally
			{
				oleDbConnection1.Close();
			}

		}

		protected void btnCharts_Click(object sender, System.EventArgs e)
		{
			oleDbConnection1.Open();
			try
			{
				cellExport6.SaveToHttpResponse("charts.xls",Response);
			}
			finally
			{
				oleDbConnection1.Close();
			}
		
		}

		protected void btnImages_Click(object sender, System.EventArgs e)
		{
			oleDbConnection1.Open();
			try
			{
				cellExport3.SaveToHttpResponse("images.xls",Response);
			}
			finally
			{
				oleDbConnection1.Close();
			}
		}

		protected void btnStream_Click(object sender, System.EventArgs e)
		{
			oleDbConnection1.Open();
			try
			{
				MemoryStream ms = new MemoryStream();
				cellExport1.SaveToStream(ms);
				byte[] data = new byte[ms.Length];
				ms.Read(data, 0, data.Length);
				ms.Close();
				
				Response.ContentType = "application/vnd.ms-excel";
				Response.AddHeader( "content-disposition","attachment;  filename=Stream.xls");
				Response.BinaryWrite(data);
				Response.End();
			}
			finally
			{
				oleDbConnection1.Close();
			}
		}

		protected void btnHyberLinks_Click(object sender, System.EventArgs e)
		{
			oleDbConnection1.Open();
			try
			{
				cellExport5.AddString(2,4,"Home Page");
				cellExport5.AddHyperLink(2,5,"http://www.e-iceblue.com","http://www.e-iceblue.com");
				cellExport5.AddString(2,7,"Contact US");
				cellExport5.AddHyperLink(2,8,"support@e-iceblue.com","mailto:support@e-iceblue.com");
				cellExport5.AddString(2,10,"Buy Now!");
				cellExport5.AddHyperLink(2,11,"http://www.e-iceblue.com/dataexport/exporturchase.htm","http://www.e-iceblue.com/dataexport/exporturchase.htm");
				cellExport5.SaveToHttpResponse("HyberLinks.xls",Response);
			}
			finally
			{
				oleDbConnection1.Close();
			}
		}

		protected void btnTextSample_Click(object sender, System.EventArgs e)
		{
			oleDbConnection1.Open();
			try
			{
				cellExport2.SaveToHttpResponse("Texts.xls",Response);
			}
			finally
			{
				oleDbConnection1.Close();
			}
		}

		protected void btnReturn_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("Default.Aspx");
		}

		private void cellExport1_GetDataParams(object sender, Spire.DataExport.EventArgs.DataParamsEventArgs e)
		{
			if 	((e.Sheet == 0) && (e.Col == 6))
			{
				e.FormatText = cellExport1.DataFormats.Currency;
			}

			if 	(e.Sheet == 1)
			{
				if (e.Col == 4)
					e.FormatText = cellExport1.DataFormats.DateTime;
				if (e.Col == 5)
					e.FormatText = cellExport1.DataFormats.Currency;
			}
		}

		protected void Button8_Click(object sender, System.EventArgs e)
		{
			oleDbConnection1.Open();
			try
			{
				cellExport7.SaveToHttpResponse("chart1.xls",Response);
			}
			finally
			{
				oleDbConnection1.Close();
			}	
		}

		protected void Button10_Click(object sender, System.EventArgs e)
		{
			ushort currentRow = 1;
			string currentFormula = string.Empty;

			Cell cell = null;

			cellExport8.Cells.Clear();
			cellExport8.SetColumnWidth(1, 32);
			cellExport8.SetColumnWidth(2, 16);
			cellExport8.SetColumnWidth(3, 16);

			cell = cellExport8.AddString(1,currentRow++,"Examples of formulas :");
			cell.Format.Font.Bold = true;
			cell.Format.FillStyle.Background = CellColor.LightGreen;
			cell.Format.FillStyle.Pattern = Pattern.Solid;
			cell.Format.Borders.Bottom.Style = CellBorderStyle.Medium;

			cell = cellExport8.AddString(1,++currentRow,"Test data:");
			cell.Format.Font.Bold = true;
			cell.Format.FillStyle.Background = CellColor.LightGreen;
			cell.Format.FillStyle.Pattern = Pattern.Solid;
			cell.Format.Borders.Bottom.Style = CellBorderStyle.Medium;
			
			//test data
			cellExport8.AddNumeric(2,currentRow, 7.3);
			cellExport8.AddNumeric(3,currentRow,5);
			cellExport8.AddNumeric(4,currentRow,8.2);
			cellExport8.AddNumeric(5,currentRow,  4);
			cellExport8.AddNumeric(6,currentRow, 3);
			cellExport8.AddNumeric(7,currentRow++, 11.3);

				
			cell = cellExport8.AddString(1,++currentRow, "Formulas");
			cell.Format.Font.Bold = true;
			cell.Format.FillStyle.Background = CellColor.LightGreen;
			cell.Format.FillStyle.Pattern = Pattern.Solid;
			cell.Format.Borders.Bottom.Style = CellBorderStyle.Medium;

			cell = cellExport8.AddString(2,currentRow, "Results");
			cell.Format.Font.Bold = true;
			cell.Format.FillStyle.Background = CellColor.LightGreen;
			cell.Format.FillStyle.Pattern = Pattern.Solid;
			cell.Format.Borders.Bottom.Style = CellBorderStyle.Medium;

			//str.
			currentFormula = "=\"hello\"";
			cellExport8.AddString(1, ++currentRow, currentFormula);
			cellExport8.AddFormula(2, currentRow, "=\"hello\"");			
			cellExport8.AddFormula(3, currentRow, "=\"" + new string(new char[]{'\u4f60', '\u597d'})+ "\"");			



			//int.
			currentFormula = "=300";
			cellExport8.AddString(1, ++currentRow,currentFormula);
			cellExport8.AddFormula(2,currentRow, currentFormula);			

			// float
			currentFormula = "=3389.639421";
			cellExport8.AddString(1, ++currentRow, currentFormula);			
			cellExport8.AddFormula(2,currentRow,currentFormula);

			//bool.
			currentFormula = "=false";
			cellExport8.AddString(1, ++currentRow, currentFormula);
			cellExport8.AddFormula(2, currentRow, currentFormula);

			currentFormula = "=1+2+3+4+5-6-7+8-9";
			cellExport8.AddString( 1, ++currentRow, currentFormula);
			cellExport8.AddFormula(2, currentRow, currentFormula);

			currentFormula = "=33*3/4-2+10";
			cellExport8.AddString( 1,++currentRow,currentFormula);			
			cellExport8.AddFormula(2, currentRow, currentFormula);			
			

			// sheet reference
			currentFormula = "=Sheet1!$B$3";
			cellExport8.AddString(1,++currentRow, currentFormula);			
			cellExport8.AddFormula(2,currentRow, currentFormula);
	
			// sheet area reference
			currentFormula = "=AVERAGE(Sheet1!$D$3:G$3)";
			cellExport8.AddString(1, ++currentRow, currentFormula);			
			cellExport8.AddFormula(2,currentRow, currentFormula);

			// Functions
			currentFormula = "=Count(3,5,8,10,2,34)";
			cellExport8.AddString(1,++currentRow,  currentFormula);			
			cellExport8.AddFormula(2,currentRow++, currentFormula);


			currentFormula = "=NOW()";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++,  currentFormula);

			currentFormula = "=SECOND(11)";
			cellExport8.AddString(1 ,currentRow, currentFormula);
			cellExport8.AddFormula(2, currentRow++, currentFormula);

			currentFormula = "=MINUTE(12)";
			cellExport8.AddString(1, currentRow,currentFormula);
			cellExport8.AddFormula(2, currentRow++, currentFormula);

			currentFormula = "=MONTH(9)";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=DAY(10)";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=TIME(4,5,7)";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=DATE(6,4,2)";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=RAND()";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=HOUR(12)";
			cellExport8.AddString(1, currentRow,currentFormula);
			cellExport8.AddFormula(2, currentRow++,  currentFormula);

			currentFormula = "=TEXT(\"world\", \"$d\")";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=MOD(5,3)";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=WEEKDAY(3)";
			cellExport8.AddString(1, currentRow, currentFormula);
			cellExport8.AddFormula(2, currentRow++, currentFormula);

			currentFormula = "=YEAR(23)";
			cellExport8.AddString(1, currentRow, currentFormula);
			cellExport8.AddFormula(2, currentRow++, currentFormula);

			currentFormula = "=NOT(true)";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=OR(true)";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=AND(TRUE)";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=VALUE(30)";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=LEN(\"world\")";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=MID(\"world\",4,2)";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=ROUND(7,3)";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=SIGN(4)";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=INT(200)";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=ABS(-1.21)";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=LN(15)";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=EXP(20)";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=SQRT(40)";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=PI()";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=COS(9)";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=SIN(45)";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=MAX(10,30)";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=MIN(5,7)";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=AVERAGE(12,45)";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=SUM(18,29)";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=IF(4,2,2)";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=SUBTOTAL(3,Sheet1!B2:E3)";
			cellExport8.AddString( 1, currentRow, currentFormula);
			cellExport8.AddFormula( 2, currentRow++, currentFormula);
		
			this.cellExport8.SaveToHttpResponse("Formulas.xls",Response);
		}

		private void Button9_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}
