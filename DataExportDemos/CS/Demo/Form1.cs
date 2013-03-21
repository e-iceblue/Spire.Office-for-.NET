using System;
using System.Data.OleDb;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Spire.DataExport.TXT;

namespace Spire.DataExport.Sample
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Spire.DataExport.Access.AccessExport accessExport1;
		private Spire.DataExport.XLS.CellExport cellExport1;
		private Spire.DataExport.Clipboard.ClipboardExport clipboardExport1;
		private Spire.DataExport.DBF.DBFExport dbfExport1;
		private Spire.DataExport.HTML.HTMLExport htmlExport1;
		private Spire.DataExport.PDF.PDFExport pdfExport1;
		private Spire.DataExport.RTF.RTFExport rtfExport1;
		private Spire.DataExport.SQL.SQLExport sqlExport1;
		private Spire.DataExport.XML.XMLExport xmlExport1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtCommandText;
		private System.Windows.Forms.TextBox txtConnectString;
		private System.Windows.Forms.RadioButton rbnXLS;
		private System.Windows.Forms.RadioButton rbnHtml;
		private System.Windows.Forms.RadioButton rbnPdf;
		private System.Windows.Forms.RadioButton rbnRtf;
		private System.Windows.Forms.RadioButton rbnClipboard;
		private System.Windows.Forms.RadioButton rbnDbf;
		private System.Windows.Forms.RadioButton rbnAccess;
		private System.Windows.Forms.RadioButton rbnXml;
		private System.Windows.Forms.RadioButton rbnSql;
		private System.Windows.Forms.RadioButton rbnSYLK;
		private System.Windows.Forms.RadioButton rbnDIF;
		private System.Windows.Forms.RadioButton rbnCSV;
		private System.Windows.Forms.DataGrid dgDetail;
		private System.Windows.Forms.Button btnRun;
		private System.Windows.Forms.Button btnAbout;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbCommand oleDbCommand1;

		private int itemIndex = 1;
		private Spire.DataExport.TXT.TXTExport txtExport1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Button button2;
		private Spire.DataExport.TXT.TXTExport txtExport2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.accessExport1 = new Spire.DataExport.Access.AccessExport();
			this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.cellExport1 = new Spire.DataExport.XLS.CellExport();
			this.clipboardExport1 = new Spire.DataExport.Clipboard.ClipboardExport();
			this.dbfExport1 = new Spire.DataExport.DBF.DBFExport();
			this.htmlExport1 = new Spire.DataExport.HTML.HTMLExport();
			this.pdfExport1 = new Spire.DataExport.PDF.PDFExport();
			this.rtfExport1 = new Spire.DataExport.RTF.RTFExport();
			this.sqlExport1 = new Spire.DataExport.SQL.SQLExport();
			this.xmlExport1 = new Spire.DataExport.XML.XMLExport();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.txtCommandText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtConnectString = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbnSYLK = new System.Windows.Forms.RadioButton();
			this.rbnDIF = new System.Windows.Forms.RadioButton();
			this.rbnCSV = new System.Windows.Forms.RadioButton();
			this.rbnXLS = new System.Windows.Forms.RadioButton();
			this.rbnHtml = new System.Windows.Forms.RadioButton();
			this.rbnPdf = new System.Windows.Forms.RadioButton();
			this.rbnRtf = new System.Windows.Forms.RadioButton();
			this.rbnClipboard = new System.Windows.Forms.RadioButton();
			this.rbnDbf = new System.Windows.Forms.RadioButton();
			this.rbnAccess = new System.Windows.Forms.RadioButton();
			this.rbnXml = new System.Windows.Forms.RadioButton();
			this.rbnSql = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.dgDetail = new System.Windows.Forms.DataGrid();
			this.btnRun = new System.Windows.Forms.Button();
			this.btnAbout = new System.Windows.Forms.Button();
			this.txtExport1 = new Spire.DataExport.TXT.TXTExport();
			this.txtExport2 = new Spire.DataExport.TXT.TXTExport();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgDetail)).BeginInit();
			this.SuspendLayout();
			//
			// accessExport1
			//
			this.accessExport1.DatabaseName = "test.mdb";
			this.accessExport1.DataFormats.CultureName = "zh-CN";
			this.accessExport1.DataFormats.Currency = "c";
			this.accessExport1.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.accessExport1.DataFormats.Float = "g";
			this.accessExport1.DataFormats.Integer = "g";
			this.accessExport1.DataFormats.Time = "H:mm";
			this.accessExport1.SQLCommand = this.oleDbCommand1;
			this.accessExport1.TableName = "ExportData";
			//
			// oleDbCommand1
			//
			this.oleDbCommand1.CommandText = "select * from parts";
			this.oleDbCommand1.Connection = this.oleDbConnection1;
			//
			// oleDbConnection1
			//
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source="".\..\database\demo.mdb"";Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			//
			// cellExport1
			//
			this.cellExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
			this.cellExport1.AutoFitColWidth = true;
			this.cellExport1.DataFormats.CultureName = "zh-CN";
			this.cellExport1.DataFormats.Currency = "гд#,###,##0.00";
			this.cellExport1.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.cellExport1.DataFormats.Float = "#,###,##0.00";
			this.cellExport1.DataFormats.Integer = "#,###,##0";
			this.cellExport1.DataFormats.Time = "H:mm";
			this.cellExport1.FileName = "sample.xls";
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
			// clipboardExport1
			//
			this.clipboardExport1.DataFormats.CultureName = "zh-CN";
			this.clipboardExport1.DataFormats.Currency = "c";
			this.clipboardExport1.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.clipboardExport1.DataFormats.Float = "g";
			this.clipboardExport1.DataFormats.Integer = "g";
			this.clipboardExport1.DataFormats.Time = "H:mm";
			this.clipboardExport1.ShowContent = true;
			this.clipboardExport1.SQLCommand = this.oleDbCommand1;
			//
			// dbfExport1
			//
			this.dbfExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
			this.dbfExport1.FileName = "sample.dbf";
			this.dbfExport1.SQLCommand = this.oleDbCommand1;
			//
			// htmlExport1
			//
			this.htmlExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
			this.htmlExport1.DataFormats.CultureName = "zh-CN";
			this.htmlExport1.DataFormats.Currency = "c";
			this.htmlExport1.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.htmlExport1.DataFormats.Float = "g";
			this.htmlExport1.DataFormats.Integer = "g";
			this.htmlExport1.DataFormats.Time = "H:mm";
			this.htmlExport1.FileName = "sample.html";
			this.htmlExport1.HtmlStyle = Spire.DataExport.HTML.HtmlStyle.MSMoney;
			this.htmlExport1.HtmlTableOptions.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(222)), ((System.Byte)(231)), ((System.Byte)(222)));
			this.htmlExport1.HtmlTableOptions.FontColor = System.Drawing.Color.Black;
			this.htmlExport1.HtmlTableOptions.HeadersBackColor = System.Drawing.Color.FromArgb(((System.Byte)(206)), ((System.Byte)(198)), ((System.Byte)(181)));
			this.htmlExport1.HtmlTableOptions.HeadersFontColor = System.Drawing.Color.Black;
			this.htmlExport1.HtmlTableOptions.OddBackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(251)), ((System.Byte)(240)));
			this.htmlExport1.HtmlTextOptions.BackgroundColor = System.Drawing.Color.White;
			this.htmlExport1.HtmlTextOptions.Font = new System.Drawing.Font("Arial", 8F);
			this.htmlExport1.HtmlTextOptions.LinkActiveColor = System.Drawing.Color.Blue;
			this.htmlExport1.HtmlTextOptions.LinkColor = System.Drawing.Color.Red;
			this.htmlExport1.HtmlTextOptions.LinkVisitedColor = System.Drawing.Color.Purple;
			this.htmlExport1.SQLCommand = this.oleDbCommand1;
			//
			// pdfExport1
			//
			this.pdfExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
			this.pdfExport1.DataFormats.CultureName = "zh-CN";
			this.pdfExport1.DataFormats.Currency = "c";
			this.pdfExport1.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.pdfExport1.DataFormats.Float = "g";
			this.pdfExport1.DataFormats.Integer = "g";
			this.pdfExport1.DataFormats.Time = "H:mm";
			this.pdfExport1.FileName = "sample.pdf";
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
			this.rtfExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
			this.rtfExport1.DataFormats.CultureName = "zh-CN";
			this.rtfExport1.DataFormats.Currency = "c";
			this.rtfExport1.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.rtfExport1.DataFormats.Float = "g";
			this.rtfExport1.DataFormats.Integer = "g";
			this.rtfExport1.DataFormats.Time = "H:mm";
			this.rtfExport1.FileName = "sample.doc";
			this.rtfExport1.RTFOptions.DataStyle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
			this.rtfExport1.RTFOptions.FooterStyle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
			this.rtfExport1.RTFOptions.HeaderStyle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
			this.rtfExport1.RTFOptions.TitleStyle.Alignment = Spire.DataExport.RTF.RtfTextAlignment.Center;
			this.rtfExport1.RTFOptions.TitleStyle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.rtfExport1.SQLCommand = this.oleDbCommand1;
			//
			// sqlExport1
			//
			this.sqlExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
			this.sqlExport1.CommitStatement = "COMMIT;";
			this.sqlExport1.DataFormats.CultureName = "zh-CN";
			this.sqlExport1.DataFormats.Currency = "c";
			this.sqlExport1.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.sqlExport1.DataFormats.Float = "g";
			this.sqlExport1.DataFormats.Integer = "g";
			this.sqlExport1.DataFormats.Time = "H:mm";
			this.sqlExport1.FileName = "sample.sql";
			this.sqlExport1.SQLCommand = this.oleDbCommand1;
			this.sqlExport1.TableName = "TestTable";
			//
			// xmlExport1
			//
			this.xmlExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
			this.xmlExport1.DataFormats.CultureName = "zh-CN";
			this.xmlExport1.DataFormats.Currency = "c";
			this.xmlExport1.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.xmlExport1.DataFormats.Float = "g";
			this.xmlExport1.DataFormats.Integer = "g";
			this.xmlExport1.DataFormats.Time = "H:mm";
			this.xmlExport1.FileName = "sample.xml";
			this.xmlExport1.SQLCommand = this.oleDbCommand1;
			//
			// groupBox1
			//
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.txtCommandText);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtConnectString);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(16, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(312, 155);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = " Data source ";
			//
			// button2
			//
			this.button2.Location = new System.Drawing.Point(232, 125);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(64, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Load";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			//
			// txtCommandText
			//
			this.txtCommandText.Location = new System.Drawing.Point(17, 95);
			this.txtCommandText.Name = "txtCommandText";
			this.txtCommandText.Size = new System.Drawing.Size(279, 21);
			this.txtCommandText.TabIndex = 3;
			this.txtCommandText.Text = "select * from parts";
			//
			// label2
			//
			this.label2.Location = new System.Drawing.Point(16, 75);
			this.label2.Name = "label2";
			this.label2.TabIndex = 2;
			this.label2.Text = "Command Text:";
			//
			// txtConnectString
			//
			this.txtConnectString.Location = new System.Drawing.Point(16, 43);
			this.txtConnectString.Name = "txtConnectString";
			this.txtConnectString.Size = new System.Drawing.Size(280, 21);
			this.txtConnectString.TabIndex = 1;
			this.txtConnectString.Text = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\\\..\\\\..\\\\..\\\\database\\\\demo.mdb";
			//
			// label1
			//
			this.label1.Location = new System.Drawing.Point(15, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Connection string:";
			//
			// groupBox2
			//
			this.groupBox2.Controls.Add(this.rbnSYLK);
			this.groupBox2.Controls.Add(this.rbnDIF);
			this.groupBox2.Controls.Add(this.rbnCSV);
			this.groupBox2.Controls.Add(this.rbnXLS);
			this.groupBox2.Controls.Add(this.rbnHtml);
			this.groupBox2.Controls.Add(this.rbnPdf);
			this.groupBox2.Controls.Add(this.rbnRtf);
			this.groupBox2.Controls.Add(this.rbnClipboard);
			this.groupBox2.Controls.Add(this.rbnDbf);
			this.groupBox2.Controls.Add(this.rbnAccess);
			this.groupBox2.Controls.Add(this.rbnXml);
			this.groupBox2.Controls.Add(this.rbnSql);
			this.groupBox2.Controls.Add(this.radioButton1);
			this.groupBox2.Location = new System.Drawing.Point(336, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(264, 240);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = " Export file format ";
			//
			// rbnSYLK
			//
			this.rbnSYLK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.rbnSYLK.Location = new System.Drawing.Point(152, 144);
			this.rbnSYLK.Name = "rbnSYLK";
			this.rbnSYLK.Size = new System.Drawing.Size(96, 26);
			this.rbnSYLK.TabIndex = 10;
			this.rbnSYLK.Tag = "10";
			this.rbnSYLK.Text = " SYLK";
			this.rbnSYLK.CheckedChanged += new System.EventHandler(this.rbnHtml_CheckedChanged_1);
			//
			// rbnDIF
			//
			this.rbnDIF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.rbnDIF.Location = new System.Drawing.Point(152, 176);
			this.rbnDIF.Name = "rbnDIF";
			this.rbnDIF.Size = new System.Drawing.Size(96, 26);
			this.rbnDIF.TabIndex = 9;
			this.rbnDIF.Tag = "12";
			this.rbnDIF.Text = " DIF";
			this.rbnDIF.CheckedChanged += new System.EventHandler(this.rbnHtml_CheckedChanged_1);
			//
			// rbnCSV
			//
			this.rbnCSV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.rbnCSV.Location = new System.Drawing.Point(24, 176);
			this.rbnCSV.Name = "rbnCSV";
			this.rbnCSV.Size = new System.Drawing.Size(96, 26);
			this.rbnCSV.TabIndex = 8;
			this.rbnCSV.Tag = "11";
			this.rbnCSV.Text = " CSV";
			this.rbnCSV.CheckedChanged += new System.EventHandler(this.rbnHtml_CheckedChanged_1);
			//
			// rbnXLS
			//
			this.rbnXLS.Checked = true;
			this.rbnXLS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.rbnXLS.Location = new System.Drawing.Point(24, 16);
			this.rbnXLS.Name = "rbnXLS";
			this.rbnXLS.TabIndex = 0;
			this.rbnXLS.TabStop = true;
			this.rbnXLS.Tag = "1";
			this.rbnXLS.Text = " XLS";
			this.rbnXLS.CheckedChanged += new System.EventHandler(this.rbnHtml_CheckedChanged_1);
			//
			// rbnHtml
			//
			this.rbnHtml.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.rbnHtml.Location = new System.Drawing.Point(152, 16);
			this.rbnHtml.Name = "rbnHtml";
			this.rbnHtml.TabIndex = 0;
			this.rbnHtml.Tag = "2";
			this.rbnHtml.Text = " HTML";
			this.rbnHtml.CheckedChanged += new System.EventHandler(this.rbnHtml_CheckedChanged_1);
			//
			// rbnPdf
			//
			this.rbnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.rbnPdf.Location = new System.Drawing.Point(24, 48);
			this.rbnPdf.Name = "rbnPdf";
			this.rbnPdf.TabIndex = 0;
			this.rbnPdf.Tag = "3";
			this.rbnPdf.Text = " PDF";
			this.rbnPdf.CheckedChanged += new System.EventHandler(this.rbnHtml_CheckedChanged_1);
			//
			// rbnRtf
			//
			this.rbnRtf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.rbnRtf.Location = new System.Drawing.Point(152, 48);
			this.rbnRtf.Name = "rbnRtf";
			this.rbnRtf.TabIndex = 0;
			this.rbnRtf.Tag = "4";
			this.rbnRtf.Text = " RTF";
			this.rbnRtf.CheckedChanged += new System.EventHandler(this.rbnHtml_CheckedChanged_1);
			//
			// rbnClipboard
			//
			this.rbnClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.rbnClipboard.Location = new System.Drawing.Point(24, 80);
			this.rbnClipboard.Name = "rbnClipboard";
			this.rbnClipboard.TabIndex = 0;
			this.rbnClipboard.Tag = "5";
			this.rbnClipboard.Text = " Clipboard";
			this.rbnClipboard.CheckedChanged += new System.EventHandler(this.rbnHtml_CheckedChanged_1);
			//
			// rbnDbf
			//
			this.rbnDbf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.rbnDbf.Location = new System.Drawing.Point(152, 80);
			this.rbnDbf.Name = "rbnDbf";
			this.rbnDbf.TabIndex = 0;
			this.rbnDbf.Tag = "6";
			this.rbnDbf.Text = " DBF";
			this.rbnDbf.CheckedChanged += new System.EventHandler(this.rbnHtml_CheckedChanged_1);
			//
			// rbnAccess
			//
			this.rbnAccess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.rbnAccess.Location = new System.Drawing.Point(24, 112);
			this.rbnAccess.Name = "rbnAccess";
			this.rbnAccess.TabIndex = 0;
			this.rbnAccess.Tag = "7";
			this.rbnAccess.Text = " MS Access";
			this.rbnAccess.CheckedChanged += new System.EventHandler(this.rbnHtml_CheckedChanged_1);
			//
			// rbnXml
			//
			this.rbnXml.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.rbnXml.Location = new System.Drawing.Point(152, 112);
			this.rbnXml.Name = "rbnXml";
			this.rbnXml.TabIndex = 0;
			this.rbnXml.Tag = "8";
			this.rbnXml.Text = " XML";
			this.rbnXml.CheckedChanged += new System.EventHandler(this.rbnHtml_CheckedChanged_1);
			//
			// rbnSql
			//
			this.rbnSql.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.rbnSql.Location = new System.Drawing.Point(24, 144);
			this.rbnSql.Name = "rbnSql";
			this.rbnSql.TabIndex = 0;
			this.rbnSql.Tag = "9";
			this.rbnSql.Text = " SQL Script";
			this.rbnSql.CheckedChanged += new System.EventHandler(this.rbnHtml_CheckedChanged_1);
			//
			// radioButton1
			//
			this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.radioButton1.Location = new System.Drawing.Point(24, 208);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(96, 26);
			this.radioButton1.TabIndex = 8;
			this.radioButton1.Tag = "13";
			this.radioButton1.Text = " Text";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.rbnHtml_CheckedChanged_1);
			//
			// dgDetail
			//
			this.dgDetail.DataMember = "";
			this.dgDetail.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgDetail.Location = new System.Drawing.Point(16, 264);
			this.dgDetail.Name = "dgDetail";
			this.dgDetail.Size = new System.Drawing.Size(584, 128);
			this.dgDetail.TabIndex = 0;
			//
			// btnRun
			//
			this.btnRun.Location = new System.Drawing.Point(432, 408);
			this.btnRun.Name = "btnRun";
			this.btnRun.TabIndex = 2;
			this.btnRun.Text = "Run";
			this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
			//
			// btnAbout
			//
			this.btnAbout.Location = new System.Drawing.Point(520, 408);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.TabIndex = 3;
			this.btnAbout.Text = "Close";
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			//
			// txtExport1
			//
			this.txtExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
			this.txtExport1.DataFormats.CultureName = "zh-CN";
			this.txtExport1.DataFormats.Currency = "c";
			this.txtExport1.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.txtExport1.DataFormats.Float = "g";
			this.txtExport1.DataFormats.Integer = "g";
			this.txtExport1.DataFormats.Time = "H:mm";
            this.txtExport1.DataEncoding = Spire.DataExport.Common.EncodingType.ASCII;
			this.txtExport1.SQLCommand = this.oleDbCommand1;
			//
			// txtExport2
			//
			this.txtExport2.DataFormats.CultureName = "zh-CN";
			this.txtExport2.DataFormats.Currency = "c";
			this.txtExport2.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.txtExport2.DataFormats.Float = "g";
			this.txtExport2.DataFormats.Integer = "g";
			this.txtExport2.DataFormats.Time = "H:mm";
			//
			// Form1
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(616, 438);
			this.Controls.Add(this.btnAbout);
			this.Controls.Add(this.btnRun);
			this.Controls.Add(this.dgDetail);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Sample";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgDetail)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.Run(new Form1());
		}

		private void LoadData()
		{
			oleDbConnection1.ConnectionString = txtConnectString.Text;
			oleDbCommand1.CommandText = txtCommandText.Text;
			using (OleDbDataAdapter da = new OleDbDataAdapter(oleDbCommand1))
			{
				DataTable dt = new DataTable();
				da.Fill(dt);
				dgDetail.DataSource = dt;
			}
		}

		private void btnRun_Click(object sender, System.EventArgs e)
		{
			oleDbConnection1.Open();
			try
			{
				switch( itemIndex )
				{
					case 1:
						cellExport1.SaveToFile();
						break;
					case 2:
						htmlExport1.SaveToFile();
						break;
					case 3:
						pdfExport1.SaveToFile();
						break;
					case 4:
						rtfExport1.SaveToFile();
						break;
					case 5:
						clipboardExport1.SaveToFile();
						break;
					case 6:
						dbfExport1.SaveToFile();
						break;
					case 7:
						accessExport1.SaveToFile();
						break;
					case 8:
						xmlExport1.SaveToFile();
						break;
					case 9:
						sqlExport1.SaveToFile();
						break;
					case 10:
						txtExport1.ExportType = TextExportType.SYLK;
						txtExport1.FileName = "sample.slk";
						txtExport1.SaveToFile();
						break;
					case 11:
						txtExport1.ExportType = TextExportType.CSV;
						txtExport1.FileName = "sample.csv";
						txtExport1.SaveToFile();
						break;
					case 12:
						txtExport1.ExportType = TextExportType.DIF;
						txtExport1.FileName = "sample.dif";
						txtExport1.SaveToFile();
						break;
					case 13:
						txtExport1.ExportType = TextExportType.TXT;
						txtExport1.FileName = "sample.txt";
						txtExport1.SaveToFile();
						break;

				}
			}finally
			{
				this.oleDbConnection1.Close();
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			LoadData();
		}

		private void rbnHtml_CheckedChanged_1(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked)
			{
				itemIndex = int.Parse((sender as RadioButton).Tag.ToString());
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			LoadData();
		}

		private void btnAbout_Click(object sender, System.EventArgs e)
		{
			Close();
		}

	}
}
