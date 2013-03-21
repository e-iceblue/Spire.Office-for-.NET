using System;
using System.Data.OleDb;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Spire.Xls;
using Spire.Xls.Charts;

namespace Spire.Xls.Sample
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnRun;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.Label label1;
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
			this.btnRun = new System.Windows.Forms.Button();
			this.btnAbout = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnRun
			// 
			this.btnRun.Location = new System.Drawing.Point(448, 56);
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(466, 18);
			this.label1.TabIndex = 4;
			this.label1.Text = "The sample demonstrates how to create stock chart in an excel workbook.";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(616, 94);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAbout);
			this.Controls.Add(this.btnRun);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chart sample";
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

		private void btnRun_Click(object sender, System.EventArgs e)
		{
			Workbook workbook = new Workbook();
			
			//Initailize worksheet
			workbook.CreateEmptySheets(1);
			Worksheet sheet = workbook.Worksheets[0];
			sheet.Name = "Chart data";
			sheet.GridLinesVisible = false;

			//Writes chart data
			CreateChartData(sheet);
            //Add a new  chart worsheet to workbook
			Chart chart = sheet.Charts.Add();

			//Set region of chart data
			chart.DataRange = sheet.Range["A1:E8"];
			chart.SeriesDataFromRange = false;

			//Set position of chart
			chart.LeftColumn = 1;
			chart.TopRow = 6;
			chart.RightColumn = 11;
			chart.BottomRow = 29;

			chart.ChartType = ExcelChartType.StockVolumeOpenHighLowClose;

            //Chart title
			chart.ChartTitle = "Stock chart";
			chart.ChartTitleArea.IsBold = true;
			chart.ChartTitleArea.Size = 12;

			chart.PrimaryCategoryAxis.Title = "Stock";
			chart.PrimaryCategoryAxis.Font.IsBold = true;
			chart.PrimaryCategoryAxis.TitleArea.IsBold = true;

			chart.PrimaryValueAxis.Title = "Price(in Dollars)";
			chart.PrimaryValueAxis.HasMajorGridLines = false;
			chart.PrimaryValueAxis.TitleArea.TextRotationAngle = 90;
            chart.PrimaryValueAxis.MinValue = 1000;
			chart.PrimaryValueAxis.TitleArea.IsBold = true;

            Charts.ChartSerie cs = chart.Series[0];

			chart.Legend.Position = LegendPositionType.Top;
			workbook.SaveToFile("Sample.xls");
			ExcelDocViewer(workbook.FileName);
		}

		private void CreateChartData(Worksheet sheet)
		{
			string RCAddress = "A{0}:E{0}";
			//Volume
			sheet.Range["A1"].Value = "Volume";
			sheet.Range["A2"].NumberValue = 12000;
			sheet.Range["A3"].NumberValue = 10000;
			sheet.Range["A4"].NumberValue = 7000;
			sheet.Range["A5"].NumberValue = 8000;
			sheet.Range["A6"].NumberValue = 21000;
			sheet.Range["A7"].NumberValue = 14000;
			sheet.Range["A8"].NumberValue = 13000;

			//Open
            sheet.Range["B1"].Value = "Open";
			sheet.Range["B2"].NumberValue = 44;
			sheet.Range["B3"].NumberValue = 43;
			sheet.Range["B4"].NumberValue = 47;
			sheet.Range["B5"].NumberValue = 42;
			sheet.Range["B6"].NumberValue = 49;
			sheet.Range["B7"].NumberValue = 43;
			sheet.Range["B8"].NumberValue = 48;

			//High
			sheet.Range["C1"].Value = "High";
			sheet.Range["C2"].NumberValue = 47;
			sheet.Range["C3"].NumberValue = 49;
			sheet.Range["C4"].NumberValue = 45;
			sheet.Range["C5"].NumberValue = 48;
			sheet.Range["C6"].NumberValue = 51;
			sheet.Range["C7"].NumberValue = 55;
			sheet.Range["C8"].NumberValue = 56;

			//Low
			sheet.Range["D1"].Value = "Low";
			sheet.Range["D2"].NumberValue = 38;
			sheet.Range["D3"].NumberValue = 40;
			sheet.Range["D4"].NumberValue = 41;
			sheet.Range["D5"].NumberValue = 40;
			sheet.Range["D6"].NumberValue = 45;
			sheet.Range["D7"].NumberValue = 49;
			sheet.Range["D8"].NumberValue = 50;

			//Close
			sheet.Range["E1"].Value = "Close";
			sheet.Range["E2"].NumberValue = 42;
			sheet.Range["E3"].NumberValue = 45;
			sheet.Range["E4"].NumberValue = 44;
			sheet.Range["E5"].NumberValue = 48;
			sheet.Range["E6"].NumberValue = 59;
			sheet.Range["E7"].NumberValue = 53;
			sheet.Range["E8"].NumberValue = 51;

			//Style
			sheet.Range["A1:E1"].Style.Font.IsBold = true;
			for( int i = 2; i < 8; i++)
			{
				if ( i % 2 == 0)
					sheet.Range[ string.Format(RCAddress,i)].Style.KnownColor = ExcelColors.LightYellow;
				else
					sheet.Range[ string.Format(RCAddress,i)].Style.KnownColor = ExcelColors.LightGreen1;
			}

			//Border
			sheet.Range["A1:E8"].Style.Borders[BordersLineType.EdgeTop].Color = Color.FromArgb(0, 0, 128);
			sheet.Range["A1:E8"].Style.Borders[BordersLineType.EdgeTop].LineStyle = LineStyleType.Thin;
			sheet.Range["A1:E8"].Style.Borders[BordersLineType.EdgeBottom].Color = Color.FromArgb(0, 0, 128);
			sheet.Range["A1:E8"].Style.Borders[BordersLineType.EdgeBottom].LineStyle = LineStyleType.Thin;
			sheet.Range["A1:E8"].Style.Borders[BordersLineType.EdgeLeft].Color = Color.FromArgb(0, 0, 128);
			sheet.Range["A1:E8"].Style.Borders[BordersLineType.EdgeLeft].LineStyle = LineStyleType.Thin;
			sheet.Range["A1:E8"].Style.Borders[BordersLineType.EdgeRight].Color = Color.FromArgb(0, 0, 128);
			sheet.Range["A1:E8"].Style.Borders[BordersLineType.EdgeRight].LineStyle = LineStyleType.Thin;

			sheet.Range["B2:E8"].Style.NumberFormat = "\"$\"#,##0";
		}

		private void ExcelDocViewer( string fileName )
		{
			try
			{
				System.Diagnostics.Process.Start(fileName);
			}
			catch{}
		}

		private void btnAbout_Click(object sender, System.EventArgs e)
		{
			Close();
		}


	}
}
