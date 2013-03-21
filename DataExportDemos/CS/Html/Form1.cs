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
		private Spire.DataExport.HTML.HTMLExport htmlExport1;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.ListBox lstStyles;
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
			this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.txtCommandText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtConnectString = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgDetail = new System.Windows.Forms.DataGrid();
			this.btnRun = new System.Windows.Forms.Button();
			this.btnAbout = new System.Windows.Forms.Button();
			this.htmlExport1 = new Spire.DataExport.HTML.HTMLExport();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lstStyles = new System.Windows.Forms.ListBox();
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
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.txtCommandText);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtConnectString);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(16, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(312, 171);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = " Data source ";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(232, 128);
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
			this.label2.Size = new System.Drawing.Size(240, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Command text :";
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
			this.dgDetail.Location = new System.Drawing.Point(16, 200);
			this.dgDetail.Name = "dgDetail";
			this.dgDetail.Size = new System.Drawing.Size(584, 128);
			this.dgDetail.TabIndex = 0;
			// 
			// btnRun
			// 
			this.btnRun.Location = new System.Drawing.Point(528, 24);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(72, 23);
			this.btnRun.TabIndex = 2;
			this.btnRun.Text = "Run";
			this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
			// 
			// btnAbout
			// 
			this.btnAbout.Location = new System.Drawing.Point(528, 56);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.TabIndex = 3;
			this.btnAbout.Text = "Close";
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
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
			this.htmlExport1.FileName = "test.html";
			this.htmlExport1.HtmlTableOptions.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(122)), ((System.Byte)(236)));
			this.htmlExport1.HtmlTableOptions.FontColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.htmlExport1.HtmlTableOptions.HeadersBackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.htmlExport1.HtmlTableOptions.HeadersFontColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.htmlExport1.HtmlTableOptions.OddBackColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(107)), ((System.Byte)(206)));
			this.htmlExport1.HtmlTextOptions.BackgroundColor = System.Drawing.Color.FromArgb(((System.Byte)(51)), ((System.Byte)(51)), ((System.Byte)(153)));
			this.htmlExport1.HtmlTextOptions.Font = new System.Drawing.Font("Arial", 8F);
			this.htmlExport1.HtmlTextOptions.FontColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.htmlExport1.HtmlTextOptions.LinkActiveColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(255)), ((System.Byte)(0)));
			this.htmlExport1.HtmlTextOptions.LinkColor = System.Drawing.Color.FromArgb(((System.Byte)(105)), ((System.Byte)(239)), ((System.Byte)(125)));
			this.htmlExport1.HtmlTextOptions.LinkVisitedColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(255)));
			this.htmlExport1.SQLCommand = this.oleDbCommand1;
			// 
			// lblTitle
			// 
			this.lblTitle.Location = new System.Drawing.Point(352, 16);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(100, 16);
			this.lblTitle.TabIndex = 4;
			this.lblTitle.Text = "Html styles:";
			// 
			// lstStyles
			// 
			this.lstStyles.ItemHeight = 12;
			this.lstStyles.Location = new System.Drawing.Point(352, 40);
			this.lstStyles.Name = "lstStyles";
			this.lstStyles.Size = new System.Drawing.Size(160, 136);
			this.lstStyles.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(616, 350);
			this.Controls.Add(this.lstStyles);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnAbout);
			this.Controls.Add(this.btnRun);
			this.Controls.Add(this.dgDetail);
			this.Controls.Add(this.groupBox1);
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
				if (lstStyles.SelectedIndex > 0) 
				{
					htmlExport1.HtmlStyle = (Spire.DataExport.HTML.HtmlStyle)Enum.Parse(typeof(Spire.DataExport.HTML.HtmlStyle),lstStyles.SelectedItem.ToString());
				}
				htmlExport1.SaveToFile();
			}
			finally
			{
				this.oleDbConnection1.Close();
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.lstStyles.Items.AddRange(System.Enum.GetNames(typeof(Spire.DataExport.HTML.HtmlStyle)));
			if (lstStyles.Items.Count > 1)
				this.lstStyles.SelectedIndex = 1;
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


	}
}
