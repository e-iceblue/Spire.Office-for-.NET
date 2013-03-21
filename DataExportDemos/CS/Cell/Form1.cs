using System;
using System.Data.OleDb;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Spire.DataExport.TXT;
using Spire.DataExport.XLS;

namespace Spire.DataExport.Sample
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Spire.DataExport.XLS.CellExport cellExport1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCommandText;
		private System.Windows.Forms.TextBox txtConnectString;
		private System.Windows.Forms.DataGrid dgDetail;
		private System.Windows.Forms.Button btnRun;
		private System.Windows.Forms.Button btnAbout;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbCommand oleDbCommand1;

		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Data.OleDb.OleDbCommand oleDbCommand2;
		private System.Windows.Forms.TextBox txtCommandTxt1;
		private System.Windows.Forms.Button button1;
		private Spire.DataExport.XLS.CellExport cellExport2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private Spire.DataExport.XLS.CellExport cellExport3;
		private Spire.DataExport.XLS.CellExport cellExport4;
		private Spire.DataExport.XLS.CellExport cellExport5;
		/// <summary>
		/// Required designer variable.
		/// </summary
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
			Spire.DataExport.XLS.WorkSheet workSheet1 = new Spire.DataExport.XLS.WorkSheet();
			Spire.DataExport.XLS.StripStyle stripStyle1 = new Spire.DataExport.XLS.StripStyle();
			Spire.DataExport.XLS.StripStyle stripStyle2 = new Spire.DataExport.XLS.StripStyle();
			Spire.DataExport.XLS.WorkSheet workSheet2 = new Spire.DataExport.XLS.WorkSheet();
			Spire.DataExport.XLS.StripStyle stripStyle3 = new Spire.DataExport.XLS.StripStyle();
			Spire.DataExport.XLS.StripStyle stripStyle4 = new Spire.DataExport.XLS.StripStyle();
			Spire.DataExport.XLS.WorkSheet workSheet3 = new Spire.DataExport.XLS.WorkSheet();
			Spire.DataExport.XLS.Chart chart1 = new Spire.DataExport.XLS.Chart();
			Spire.DataExport.XLS.ChartSeries chartSeries1 = new Spire.DataExport.XLS.ChartSeries();
			Spire.DataExport.XLS.StripStyle stripStyle5 = new Spire.DataExport.XLS.StripStyle();
			Spire.DataExport.XLS.StripStyle stripStyle6 = new Spire.DataExport.XLS.StripStyle();
			Spire.DataExport.XLS.WorkSheet workSheet4 = new Spire.DataExport.XLS.WorkSheet();
			Spire.DataExport.XLS.Chart chart2 = new Spire.DataExport.XLS.Chart();
			Spire.DataExport.XLS.ChartSeries chartSeries2 = new Spire.DataExport.XLS.ChartSeries();
			Spire.DataExport.XLS.WorkSheet workSheet5 = new Spire.DataExport.XLS.WorkSheet();
			Spire.DataExport.XLS.StripStyle stripStyle7 = new Spire.DataExport.XLS.StripStyle();
			Spire.DataExport.XLS.StripStyle stripStyle8 = new Spire.DataExport.XLS.StripStyle();
			Spire.DataExport.XLS.WorkSheet workSheet6 = new Spire.DataExport.XLS.WorkSheet();
			Spire.DataExport.XLS.ColumnFormat columnFormat1 = new Spire.DataExport.XLS.ColumnFormat();
			Spire.DataExport.XLS.ColumnFormat columnFormat2 = new Spire.DataExport.XLS.ColumnFormat();
			Spire.DataExport.XLS.ColumnFormat columnFormat3 = new Spire.DataExport.XLS.ColumnFormat();
			Spire.DataExport.XLS.ColumnFormat columnFormat4 = new Spire.DataExport.XLS.ColumnFormat();
			Spire.DataExport.XLS.ColumnFormat columnFormat5 = new Spire.DataExport.XLS.ColumnFormat();
			this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbCommand2 = new System.Data.OleDb.OleDbCommand();
			this.cellExport1 = new Spire.DataExport.XLS.CellExport();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtCommandTxt1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.txtCommandText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtConnectString = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgDetail = new System.Windows.Forms.DataGrid();
			this.btnRun = new System.Windows.Forms.Button();
			this.btnAbout = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.cellExport2 = new Spire.DataExport.XLS.CellExport();
			this.button3 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.cellExport4 = new Spire.DataExport.XLS.CellExport();
			this.button5 = new System.Windows.Forms.Button();
			this.cellExport5 = new Spire.DataExport.XLS.CellExport();
			this.cellExport3 = new Spire.DataExport.XLS.CellExport();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgDetail)).BeginInit();
			this.SuspendLayout();
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
			// oleDbCommand2
			// 
			this.oleDbCommand2.CommandText = "select * from country";
			this.oleDbCommand2.Connection = this.oleDbConnection1;
			// 
			// cellExport1
			// 
			this.cellExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
			this.cellExport1.AutoFitColWidth = true;
			this.cellExport1.AutoFormula = true;
			this.cellExport1.DataFormats.CultureName = "zh-CN";
			this.cellExport1.DataFormats.Currency = "$#,###,##0.00";
			this.cellExport1.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.cellExport1.DataFormats.Float = "#,###,##0.00";
			this.cellExport1.DataFormats.Integer = "#,###,##0";
			this.cellExport1.DataFormats.Time = "H:mm";
			this.cellExport1.FileName = "Sheets.xls";
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
			workSheet1.AutoFitColWidth = true;
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
			workSheet1.ItemType = Spire.DataExport.XLS.CellItemType.Col;
			workSheet1.Options.AggregateFormat.Font.Name = "Arial";
			workSheet1.Options.CustomDataFormat.Font.Name = "Arial";
			workSheet1.Options.DefaultFont.Name = "Arial";
			workSheet1.Options.FooterFormat.Font.Name = "Arial";
			workSheet1.Options.HeaderFormat.Font.Bold = true;
			workSheet1.Options.HeaderFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue;
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
			workSheet1.SheetName = "parts";
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
			stripStyle4.FillStyle.Foreground = Spire.DataExport.XLS.CellColor.White;
			stripStyle4.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid;
			stripStyle4.Font.Name = "Arial";
			workSheet2.ItemStyles.Add(stripStyle3);
			workSheet2.ItemStyles.Add(stripStyle4);
			workSheet2.ItemType = Spire.DataExport.XLS.CellItemType.Col;
			workSheet2.Options.AggregateFormat.Font.Name = "Arial";
			workSheet2.Options.CustomDataFormat.Font.Name = "Arial";
			workSheet2.Options.DefaultFont.Name = "Arial";
			workSheet2.Options.FooterFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue;
			workSheet2.Options.FooterFormat.Font.Name = "Arial";
			workSheet2.Options.HeaderFormat.Font.Bold = true;
			workSheet2.Options.HeaderFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue;
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
			workSheet2.SheetName = "country";
			workSheet2.SQLCommand = this.oleDbCommand2;
			workSheet2.StartDataCol = ((System.Byte)(0));
			this.cellExport1.Sheets.Add(workSheet1);
			this.cellExport1.Sheets.Add(workSheet2);
			this.cellExport1.SQLCommand = this.oleDbCommand1;
			this.cellExport1.GetDataParams += new Spire.DataExport.Delegates.DataParamsEventHandler(this.cellExport1_GetDataParams);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtCommandTxt1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.txtCommandText);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtConnectString);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(16, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(312, 203);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = " Data source ";
			// 
			// txtCommandTxt1
			// 
			this.txtCommandTxt1.Location = new System.Drawing.Point(17, 144);
			this.txtCommandTxt1.Name = "txtCommandTxt1";
			this.txtCommandTxt1.Size = new System.Drawing.Size(279, 21);
			this.txtCommandTxt1.TabIndex = 7;
			this.txtCommandTxt1.Text = "select * from country";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(256, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Command text for the second work sheet:";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(232, 173);
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
			this.label2.Size = new System.Drawing.Size(240, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Command text for the first work sheet:";
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
			// dgDetail
			// 
			this.dgDetail.DataMember = "";
			this.dgDetail.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgDetail.Location = new System.Drawing.Point(16, 224);
			this.dgDetail.Name = "dgDetail";
			this.dgDetail.Size = new System.Drawing.Size(584, 128);
			this.dgDetail.TabIndex = 0;
			// 
			// btnRun
			// 
			this.btnRun.Location = new System.Drawing.Point(368, 24);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(96, 23);
			this.btnRun.TabIndex = 2;
			this.btnRun.Text = "Multi-Sheets";
			this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
			// 
			// btnAbout
			// 
			this.btnAbout.Location = new System.Drawing.Point(528, 368);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.TabIndex = 3;
			this.btnAbout.Text = "Close";
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(368, 56);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Chart1";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// cellExport2
			// 
			this.cellExport2.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
			this.cellExport2.AutoFitColWidth = true;
			this.cellExport2.DataFormats.CultureName = "zh-CN";
			this.cellExport2.DataFormats.Currency = "гд#,###,##0.00";
			this.cellExport2.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.cellExport2.DataFormats.Float = "#,###,##0.00";
			this.cellExport2.DataFormats.Integer = "#,###,##0";
			this.cellExport2.DataFormats.Time = "H:mm";
			this.cellExport2.FileName = "chart1.xls";
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
			this.cellExport2.SheetOptions.TitlesFormat.Font.Bold = true;
			this.cellExport2.SheetOptions.TitlesFormat.Font.Name = "Arial";
			workSheet3.AutoFitColWidth = true;
			chart1.CategoryLabels.ColX = ((System.Byte)(1));
			chart1.CategoryLabels.ColY = ((System.Byte)(1));
			chart1.CategoryLabels.RowX = 1;
			chart1.CategoryLabels.RowY = 9;
			chart1.CategoryLabelsColumn = "Name";
			chart1.DataRangeSheet = "charts";
			chart1.Position.AutoPosition.Height = 12;
			chart1.Position.AutoPosition.Top = 1;
			chart1.Position.AutoPosition.Width = 6;
			chartSeries1.DataColumn = "Population";
			chartSeries1.DataRangeSheet = "charts";
			chartSeries1.Title = "Population";
			chart1.Series.Add(chartSeries1);
			chart1.Style = Spire.DataExport.XLS.ChartStyle.Pie3d;
			chart1.Title = "Chart demo";
			workSheet3.Charts.Add(chart1);
			workSheet3.FormatsExport.CultureName = "zh-CN";
			workSheet3.FormatsExport.Currency = "гд#,###,##0.00";
			workSheet3.FormatsExport.DateTime = "yyyy-M-d H:mm";
			workSheet3.FormatsExport.Float = "#,###,##0.00";
			workSheet3.FormatsExport.Integer = "#,###,##0";
			workSheet3.FormatsExport.Time = "H:mm";
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
			workSheet3.ItemStyles.Add(stripStyle5);
			workSheet3.ItemStyles.Add(stripStyle6);
			workSheet3.ItemType = Spire.DataExport.XLS.CellItemType.Col;
			workSheet3.Options.AggregateFormat.Font.Name = "Arial";
			workSheet3.Options.CustomDataFormat.Font.Name = "Arial";
			workSheet3.Options.DefaultFont.Name = "Arial";
			workSheet3.Options.FooterFormat.Font.Name = "Arial";
			workSheet3.Options.HeaderFormat.Font.Bold = true;
			workSheet3.Options.HeaderFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue;
			workSheet3.Options.HeaderFormat.Font.Name = "Arial";
			workSheet3.Options.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue;
			workSheet3.Options.HyperlinkFormat.Font.Name = "Arial";
			workSheet3.Options.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single;
			workSheet3.Options.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left;
			workSheet3.Options.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top;
			workSheet3.Options.NoteFormat.Font.Bold = true;
			workSheet3.Options.NoteFormat.Font.Name = "Tahoma";
			workSheet3.Options.NoteFormat.Font.Size = 8F;
			workSheet3.Options.TitlesFormat.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			workSheet3.Options.TitlesFormat.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			workSheet3.Options.TitlesFormat.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			workSheet3.Options.TitlesFormat.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
			workSheet3.Options.TitlesFormat.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightYellow;
			workSheet3.Options.TitlesFormat.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid;
			workSheet3.Options.TitlesFormat.Font.Bold = true;
			workSheet3.Options.TitlesFormat.Font.Name = "Arial";
			workSheet3.SheetName = "charts";
			workSheet3.SQLCommand = this.oleDbCommand2;
			workSheet3.StartDataCol = ((System.Byte)(0));
			this.cellExport2.Sheets.Add(workSheet3);
			this.cellExport2.SQLCommand = this.oleDbCommand1;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(368, 88);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(96, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Misc";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(352, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(240, 64);
			this.label4.TabIndex = 4;
			this.label4.Text = "Notes : Not needing to have Microsoft Excel installed on the machine, The Spire.D" +
				"ataExport can create Excel spreadsheet. ";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(488, 56);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(88, 23);
			this.button4.TabIndex = 2;
			this.button4.Text = "Chart2";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// cellExport4
			// 
			this.cellExport4.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
			this.cellExport4.AutoFitColWidth = true;
			this.cellExport4.DataFormats.CultureName = "zh-CN";
			this.cellExport4.DataFormats.Currency = "гд#,###,##0.00";
			this.cellExport4.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.cellExport4.DataFormats.Float = "#,###,##0.00";
			this.cellExport4.DataFormats.Integer = "#,###,##0";
			this.cellExport4.DataFormats.Time = "H:mm";
			this.cellExport4.FileName = "chart2.xls";
			this.cellExport4.SheetOptions.AggregateFormat.Font.Name = "Arial";
			this.cellExport4.SheetOptions.CustomDataFormat.Font.Name = "Arial";
			this.cellExport4.SheetOptions.DefaultFont.Name = "Arial";
			this.cellExport4.SheetOptions.FooterFormat.Font.Name = "Arial";
			this.cellExport4.SheetOptions.HeaderFormat.Font.Name = "Arial";
			this.cellExport4.SheetOptions.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue;
			this.cellExport4.SheetOptions.HyperlinkFormat.Font.Name = "Arial";
			this.cellExport4.SheetOptions.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single;
			this.cellExport4.SheetOptions.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left;
			this.cellExport4.SheetOptions.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top;
			this.cellExport4.SheetOptions.NoteFormat.Font.Bold = true;
			this.cellExport4.SheetOptions.NoteFormat.Font.Name = "Tahoma";
			this.cellExport4.SheetOptions.NoteFormat.Font.Size = 8F;
			this.cellExport4.SheetOptions.TitlesFormat.Font.Bold = true;
			this.cellExport4.SheetOptions.TitlesFormat.Font.Name = "Arial";
			chart2.AutoColor = false;
			chart2.CategoryLabels.ColX = ((System.Byte)(1));
			chart2.CategoryLabels.ColY = ((System.Byte)(1));
			chart2.CategoryLabels.RowX = 1;
			chart2.CategoryLabels.RowY = 9;
			chart2.CategoryLabelsColumn = "Name";
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
			chartSeries2.DataColumn = "Area";
			chartSeries2.DataRangeSheet = "Sheet 2";
			chartSeries2.Title = "Population";
			chart2.Series.Add(chartSeries2);
			chart2.Style = Spire.DataExport.XLS.ChartStyle.Bar;
			chart2.Title = "Chart demo";
			workSheet4.Charts.Add(chart2);
			workSheet4.DataExported = false;
			workSheet4.FormatsExport.CultureName = "zh-CN";
			workSheet4.FormatsExport.Currency = "гд#,###,##0.00";
			workSheet4.FormatsExport.DateTime = "yyyy-M-d H:mm";
			workSheet4.FormatsExport.Float = "#,###,##0.00";
			workSheet4.FormatsExport.Integer = "#,###,##0";
			workSheet4.FormatsExport.Time = "H:mm";
			workSheet4.Options.AggregateFormat.Font.Name = "Arial";
			workSheet4.Options.CustomDataFormat.Font.Name = "Arial";
			workSheet4.Options.DefaultFont.Name = "Arial";
			workSheet4.Options.FooterFormat.Font.Name = "Arial";
			workSheet4.Options.HeaderFormat.Font.Bold = true;
			workSheet4.Options.HeaderFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue;
			workSheet4.Options.HeaderFormat.Font.Name = "Arial";
			workSheet4.Options.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue;
			workSheet4.Options.HyperlinkFormat.Font.Name = "Arial";
			workSheet4.Options.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single;
			workSheet4.Options.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left;
			workSheet4.Options.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top;
			workSheet4.Options.NoteFormat.Font.Bold = true;
			workSheet4.Options.NoteFormat.Font.Name = "Tahoma";
			workSheet4.Options.NoteFormat.Font.Size = 8F;
			workSheet4.Options.TitlesFormat.Font.Bold = true;
			workSheet4.Options.TitlesFormat.Font.Name = "Times New Roman";
			workSheet4.Options.TitlesFormat.Font.Size = 13F;
			workSheet4.SheetName = "charts";
			workSheet4.StartDataCol = ((System.Byte)(0));
			workSheet5.AutoFitColWidth = true;
			workSheet5.FormatsExport.CultureName = "zh-CN";
			workSheet5.FormatsExport.Currency = "гд#,###,##0.00";
			workSheet5.FormatsExport.DateTime = "yyyy-M-d H:mm";
			workSheet5.FormatsExport.Float = "#,###,##0.00";
			workSheet5.FormatsExport.Integer = "#,###,##0";
			workSheet5.FormatsExport.Time = "H:mm";
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
			workSheet5.ItemStyles.Add(stripStyle7);
			workSheet5.ItemStyles.Add(stripStyle8);
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
			workSheet5.SheetName = "Sheet 2";
			workSheet5.SQLCommand = this.oleDbCommand2;
			workSheet5.StartDataCol = ((System.Byte)(0));
			this.cellExport4.Sheets.Add(workSheet4);
			this.cellExport4.Sheets.Add(workSheet5);
			this.cellExport4.SQLCommand = this.oleDbCommand1;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(488, 24);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(88, 23);
			this.button5.TabIndex = 5;
			this.button5.Text = "Formula";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// cellExport5
			// 
			this.cellExport5.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
			this.cellExport5.ColumnsWidth.AddRange(new object[] {
																	"100",
																	"200"});
			this.cellExport5.DataExported = false;
			this.cellExport5.DataFormats.CultureName = "zh-CN";
			this.cellExport5.DataFormats.Currency = "гд#,###,##0.00";
			this.cellExport5.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.cellExport5.DataFormats.Float = "#,###,##0.00";
			this.cellExport5.DataFormats.Integer = "#,###,##0";
			this.cellExport5.DataFormats.Time = "H:mm";
			this.cellExport5.FileName = "formula.xls";
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
			this.cellExport5.SheetOptions.TitlesFormat.Font.Bold = true;
			this.cellExport5.SheetOptions.TitlesFormat.Font.Name = "Arial";
			this.cellExport5.SQLCommand = this.oleDbCommand1;
			// 
			// cellExport3
			// 
			this.cellExport3.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
			this.cellExport3.DataFormats.CultureName = "zh-CN";
			this.cellExport3.DataFormats.Currency = "гд#,###,##0.00";
			this.cellExport3.DataFormats.DateTime = "yyyy-M-d H:mm";
			this.cellExport3.DataFormats.Float = "#,###,##0.00";
			this.cellExport3.DataFormats.Integer = "#,###,##0";
			this.cellExport3.DataFormats.Time = "H:mm";
			this.cellExport3.FileName = "misc.xls";
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
			columnFormat1.FieldName = "PartNo";
			columnFormat1.Font.Bold = true;
			columnFormat1.Font.Name = "Arial";
			columnFormat2.FieldName = "VendorNo";
			columnFormat2.Font.Color = Spire.DataExport.XLS.CellColor.Color1;
			columnFormat2.Font.Italic = true;
			columnFormat2.Font.Name = "Arial";
			columnFormat3.FieldName = "Description";
			columnFormat3.Font.Name = "Arial";
			columnFormat3.Font.Strikeout = true;
			columnFormat3.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.DoubleAccounting;
			columnFormat4.FieldName = "OnHand";
			columnFormat4.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightTurquoise;
			columnFormat4.FillStyle.Foreground = Spire.DataExport.XLS.CellColor.Pink;
			columnFormat4.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.ThinGorizontal;
			columnFormat4.Font.Name = "Arial";
			columnFormat5.FieldName = "ListPrice";
			columnFormat5.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightYellow;
			columnFormat5.FillStyle.Foreground = Spire.DataExport.XLS.CellColor.SkyBlue;
			columnFormat5.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.ThinVertical;
			columnFormat5.Font.Name = "Arial";
			workSheet6.ColumnFormats.Add(columnFormat1);
			workSheet6.ColumnFormats.Add(columnFormat2);
			workSheet6.ColumnFormats.Add(columnFormat3);
			workSheet6.ColumnFormats.Add(columnFormat4);
			workSheet6.ColumnFormats.Add(columnFormat5);
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
			workSheet6.Options.TitlesFormat.Font.Name = "Arial";
			workSheet6.SheetName = "Sheet 1";
			workSheet6.SQLCommand = this.oleDbCommand1;
			workSheet6.StartDataCol = ((System.Byte)(0));
			this.cellExport3.Sheets.Add(workSheet6);
			this.cellExport3.GetDataParams += new Spire.DataExport.Delegates.DataParamsEventHandler(this.cellExport1_GetDataParams);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(616, 398);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnAbout);
			this.Controls.Add(this.btnRun);
			this.Controls.Add(this.dgDetail);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Cell demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
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
			this.oleDbCommand2.CommandText = txtCommandTxt1.Text;
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
				cellExport1.SaveToFile();
			}
			finally
			{
				this.oleDbConnection1.Close();
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			LoadData();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			LoadData();
		}

		private void btnAbout_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			oleDbConnection1.Open();
			try
			{
				cellExport2.SaveToFile();
			}
			finally
			{
				this.oleDbConnection1.Close();
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			oleDbConnection1.Open();
			try
			{
				cellExport3.SaveToFile();
			}
			finally
			{
				this.oleDbConnection1.Close();
			}
			
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			oleDbConnection1.Open();
			try
			{
				cellExport4.SaveToFile();
			}
			finally
			{
				this.oleDbConnection1.Close();
			}
		
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			ushort currentRow = 1;
			string currentFormula = string.Empty;

			Cell cell = null;

			cellExport5.Cells.Clear();
			cellExport5.SetColumnWidth(1, 32);
			cellExport5.SetColumnWidth(2, 16);
			cellExport5.SetColumnWidth(3, 16);

			cell = cellExport5.AddString(1,currentRow++,"Examples of formulas :");
			cell.Format.Font.Bold = true;
			cell.Format.FillStyle.Background = CellColor.LightGreen;
			cell.Format.FillStyle.Pattern = Pattern.Solid;
			cell.Format.Borders.Bottom.Style = CellBorderStyle.Medium;

			cell = cellExport5.AddString(1,++currentRow,"Test data:");
			cell.Format.Font.Bold = true;
			cell.Format.FillStyle.Background = CellColor.LightGreen;
			cell.Format.FillStyle.Pattern = Pattern.Solid;
			cell.Format.Borders.Bottom.Style = CellBorderStyle.Medium;
			
            //test data
			cellExport5.AddNumeric(2,currentRow, 7.3);
			cellExport5.AddNumeric(3,currentRow,5);
			cellExport5.AddNumeric(4,currentRow,8.2);
			cellExport5.AddNumeric(5,currentRow,  4);
			cellExport5.AddNumeric(6,currentRow, 3);
			cellExport5.AddNumeric(7,currentRow++, 11.3);

				
			cell = cellExport5.AddString(1,++currentRow, "Formulas");
			cell.Format.Font.Bold = true;
			cell.Format.FillStyle.Background = CellColor.LightGreen;
			cell.Format.FillStyle.Pattern = Pattern.Solid;
			cell.Format.Borders.Bottom.Style = CellBorderStyle.Medium;

			cell = cellExport5.AddString(2,currentRow, "Results");
			cell.Format.Font.Bold = true;
			cell.Format.FillStyle.Background = CellColor.LightGreen;
			cell.Format.FillStyle.Pattern = Pattern.Solid;
			cell.Format.Borders.Bottom.Style = CellBorderStyle.Medium;

			//str.
			currentFormula = "=\"hello\"";
			cellExport5.AddString(1, ++currentRow, currentFormula);
			cellExport5.AddFormula(2, currentRow, "=\"hello\"");			
			cellExport5.AddFormula(3, currentRow, "=\"" + new string(new char[]{'\u4f60', '\u597d'})+ "\"");			



			//int.
			currentFormula = "=300";
			cellExport5.AddString(1, ++currentRow,currentFormula);
			cellExport5.AddFormula(2,currentRow, currentFormula);			

			// float
			currentFormula = "=3389.639421";
			cellExport5.AddString(1, ++currentRow, currentFormula);			
			cellExport5.AddFormula(2,currentRow,currentFormula);

			//bool.
			currentFormula = "=false";
			cellExport5.AddString(1, ++currentRow, currentFormula);
			cellExport5.AddFormula(2, currentRow, currentFormula);

			currentFormula = "=1+2+3+4+5-6-7+8-9";
			cellExport5.AddString( 1, ++currentRow, currentFormula);
			cellExport5.AddFormula(2, currentRow, currentFormula);

			currentFormula = "=33*3/4-2+10";
			cellExport5.AddString( 1,++currentRow,currentFormula);			
			cellExport5.AddFormula(2, currentRow, currentFormula);			
			

			// sheet reference
			currentFormula = "=Sheet1!$B$3";
			cellExport5.AddString(1,++currentRow, currentFormula);			
			cellExport5.AddFormula(2,currentRow, currentFormula);
	
			// sheet area reference
			currentFormula = "=AVERAGE(Sheet1!$D$3:G$3)";
			cellExport5.AddString(1, ++currentRow, currentFormula);			
			cellExport5.AddFormula(2,currentRow, currentFormula);

			// Functions
			currentFormula = "=Count(3,5,8,10,2,34)";
			cellExport5.AddString(1,++currentRow,  currentFormula);			
			cellExport5.AddFormula(2,currentRow++, currentFormula);


			currentFormula = "=NOW()";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++,  currentFormula);

			currentFormula = "=SECOND(11)";
			cellExport5.AddString(1 ,currentRow, currentFormula);
			cellExport5.AddFormula(2, currentRow++, currentFormula);

			currentFormula = "=MINUTE(12)";
			cellExport5.AddString(1, currentRow,currentFormula);
			cellExport5.AddFormula(2, currentRow++, currentFormula);

			currentFormula = "=MONTH(9)";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=DAY(10)";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=TIME(4,5,7)";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=DATE(6,4,2)";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=RAND()";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=HOUR(12)";
			cellExport5.AddString(1, currentRow,currentFormula);
			cellExport5.AddFormula(2, currentRow++,  currentFormula);

			currentFormula = "=TEXT(\"world\", \"$d\")";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=MOD(5,3)";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=WEEKDAY(3)";
			cellExport5.AddString(1, currentRow, currentFormula);
			cellExport5.AddFormula(2, currentRow++, currentFormula);

			currentFormula = "=YEAR(23)";
			cellExport5.AddString(1, currentRow, currentFormula);
			cellExport5.AddFormula(2, currentRow++, currentFormula);

			currentFormula = "=NOT(true)";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=OR(true)";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=AND(TRUE)";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=VALUE(30)";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=LEN(\"world\")";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=MID(\"world\",4,2)";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=ROUND(7,3)";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=SIGN(4)";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=INT(200)";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=ABS(-1.21)";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=LN(15)";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=EXP(20)";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=SQRT(40)";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=PI()";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=COS(9)";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=SIN(45)";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=MAX(10,30)";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=MIN(5,7)";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=AVERAGE(12,45)";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=SUM(18,29)";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=IF(4,2,2)";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);

			currentFormula = "=SUBTOTAL(3,Sheet1!B2:E3)";
			cellExport5.AddString( 1, currentRow, currentFormula);
			cellExport5.AddFormula( 2, currentRow++, currentFormula);
		
			this.cellExport5.SaveToFile();
		}

		private void cellExport1_GetDataParams(object sender, Spire.DataExport.EventArgs.DataParamsEventArgs e)
		{
			if 	((e.Sheet == 0) && (e.Col == 6))
			{
				e.FormatText = cellExport1.DataFormats.Currency;
			}
		}

	}
}
