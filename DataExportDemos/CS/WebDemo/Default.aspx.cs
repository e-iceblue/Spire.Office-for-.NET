using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

using Spire.DataExport.TXT;

namespace Spire.WebDemo
{

	public partial class DefaultForm : System.Web.UI.Page
	{
		protected System.Data.OleDb.OleDbConnection oleDbConnection1;
		protected System.Data.OleDb.OleDbCommand oleDbCommand1;
		protected System.Web.UI.WebControls.RadioButtonList RadioButtonList1;
		protected System.Web.UI.WebControls.RadioButtonList RadioButtonList2;
		protected Spire.DataExport.Access.AccessExport accessExport1;
		protected Spire.DataExport.XLS.CellExport cellExport1;
		protected Spire.DataExport.DBF.DBFExport dbfExport1;
		protected Spire.DataExport.PDF.PDFExport pdfExport1;
		protected Spire.DataExport.RTF.RTFExport rtfExport1;
		protected Spire.DataExport.SQL.SQLExport sqlExport1;
		protected Spire.DataExport.TXT.TXTExport txtExport1;
		protected Spire.DataExport.XML.XMLExport xmlExport1;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			string path = MapPath(".");						
			path = path.Substring(0, path.LastIndexOf("\\"));	
			oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + 
				"\\..\\Database\\demo.mdb";
			this.oleDbCommand1.CommandText = "SELECT * FROM PARTS";
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
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
			this.accessExport1 = new Spire.DataExport.Access.AccessExport();
			this.cellExport1 = new Spire.DataExport.XLS.CellExport();
			this.dbfExport1 = new Spire.DataExport.DBF.DBFExport();
			this.pdfExport1 = new Spire.DataExport.PDF.PDFExport();
			this.rtfExport1 = new Spire.DataExport.RTF.RTFExport();
			this.sqlExport1 = new Spire.DataExport.SQL.SQLExport();
			this.txtExport1 = new Spire.DataExport.TXT.TXTExport();
			this.xmlExport1 = new Spire.DataExport.XML.XMLExport();
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source="".\..\database\demo.mdb"";Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// oleDbCommand1
			// 
			this.oleDbCommand1.CommandText = "SELECT * FROM country";
			this.oleDbCommand1.Connection = this.oleDbConnection1;
			// 
			// accessExport1
			// 
			this.accessExport1.DataFormats.CultureName = "zh-CN";
			this.accessExport1.DataFormats.Currency = "c";
			this.accessExport1.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.accessExport1.DataFormats.Float = "g";
			this.accessExport1.DataFormats.Integer = "g";
			this.accessExport1.DataFormats.Time = "H:mm";
			this.accessExport1.SQLCommand = this.oleDbCommand1;
			// 
			// cellExport1
			// 
			this.cellExport1.DataFormats.CultureName = "zh-CN";
			this.cellExport1.DataFormats.Currency = "гд#,###,##0.00";
			this.cellExport1.DataFormats.DateTime = "yyyy-M-d H:mm";
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
			this.cellExport1.SheetOptions.TitlesFormat.Font.Bold = true;
			this.cellExport1.SheetOptions.TitlesFormat.Font.Name = "Arial";
			this.cellExport1.SQLCommand = this.oleDbCommand1;
			// 
			// dbfExport1
			// 
			this.dbfExport1.SQLCommand = this.oleDbCommand1;
			// 
			// pdfExport1
			// 
			this.pdfExport1.DataFormats.CultureName = "zh-CN";
			this.pdfExport1.DataFormats.Currency = "c";
			this.pdfExport1.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.pdfExport1.DataFormats.Float = "g";
			this.pdfExport1.DataFormats.Integer = "g";
			this.pdfExport1.DataFormats.Time = "H:mm";
			this.pdfExport1.PDFOptions.PageOptions.Format = Spire.DataExport.PDF.PageFormat.User;
			this.pdfExport1.PDFOptions.PageOptions.Height = 11.67;
			this.pdfExport1.PDFOptions.PageOptions.MarginBottom = 0.78;
			this.pdfExport1.PDFOptions.PageOptions.MarginLeft = 1.17;
			this.pdfExport1.PDFOptions.PageOptions.MarginRight = 0.57;
			this.pdfExport1.PDFOptions.PageOptions.MarginTop = 0.78;
			this.pdfExport1.PDFOptions.PageOptions.Width = 8.25;
			this.pdfExport1.SQLCommand = this.oleDbCommand1;
			// 
			// rtfExport1
			// 
			this.rtfExport1.DataFormats.CultureName = "zh-CN";
			this.rtfExport1.DataFormats.Currency = "c";
			this.rtfExport1.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.rtfExport1.DataFormats.Float = "g";
			this.rtfExport1.DataFormats.Integer = "g";
			this.rtfExport1.DataFormats.Time = "H:mm";
			this.rtfExport1.RTFOptions.DataStyle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
			this.rtfExport1.RTFOptions.FooterStyle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
			this.rtfExport1.RTFOptions.HeaderStyle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
			this.rtfExport1.RTFOptions.TitleStyle.Alignment = Spire.DataExport.RTF.RtfTextAlignment.Center;
			this.rtfExport1.RTFOptions.TitleStyle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.rtfExport1.SQLCommand = this.oleDbCommand1;
			// 
			// sqlExport1
			// 
			this.sqlExport1.DataFormats.CultureName = "zh-CN";
			this.sqlExport1.DataFormats.Currency = "c";
			this.sqlExport1.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.sqlExport1.DataFormats.Float = "g";
			this.sqlExport1.DataFormats.Integer = "g";
			this.sqlExport1.DataFormats.Time = "H:mm";
			this.sqlExport1.SQLCommand = this.oleDbCommand1;
			// 
			// txtExport1
			// 
			this.txtExport1.DataFormats.CultureName = "zh-CN";
			this.txtExport1.DataFormats.Currency = "c";
			this.txtExport1.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.txtExport1.DataFormats.Float = "g";
			this.txtExport1.DataFormats.Integer = "g";
			this.txtExport1.DataFormats.Time = "H:mm";
			this.txtExport1.SQLCommand = this.oleDbCommand1;
			// 
			// xmlExport1
			// 
			this.xmlExport1.DataFormats.CultureName = "zh-CN";
			this.xmlExport1.DataFormats.Currency = "c";
			this.xmlExport1.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.xmlExport1.DataFormats.Float = "g";
			this.xmlExport1.DataFormats.Integer = "g";
			this.xmlExport1.DataFormats.Time = "H:mm";
			this.xmlExport1.SQLCommand = this.oleDbCommand1;

		}
		#endregion

		protected void Button1_Click(object sender, System.EventArgs e)
		{
		
			oleDbConnection1.Open();
			try
			{

				switch( RadioButtonList3.SelectedIndex ) 
				{
					case 0:
						cellExport1.SaveToHttpResponse("sample.xls",Response);
						break;
					case 1:
						pdfExport1.SaveToHttpResponse("sample.pdf",Response);
						break;
					case 2:
						rtfExport1.SaveToHttpResponse("sample.doc",Response);
						break;
					case 3:
						dbfExport1.SaveToHttpResponse("sample.dbf",Response);
						break;
					case 4:
						accessExport1.SaveToHttpResponse("sample.mdb",Response);
						break;
					case 5:
						xmlExport1.SaveToHttpResponse("sample.xml",Response);
						break;
					case 6:
						sqlExport1.SaveToHttpResponse("sample.sql",Response);
						break;
					case 7:
						txtExport1.ExportType = TextExportType.SYLK;
						txtExport1.SaveToHttpResponse("sample.slk",Response);
						break;
					case 8:
						txtExport1.ExportType = TextExportType.CSV;
						txtExport1.SaveToHttpResponse("sample.csv",Response);
						break;
					case 9:
						txtExport1.ExportType = TextExportType.DIF;
						txtExport1.SaveToHttpResponse("sample.dif",Response);
						break;
					case 10:
						txtExport1.ExportType = TextExportType.TXT;
						txtExport1.SaveToHttpResponse("sample.txt",Response);
						break;

				}
			}
			finally
			{
				this.oleDbConnection1.Close();
			}
		}

		protected void Button2_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("CellSample.aspx");
		}
	}
}
