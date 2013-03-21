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
		private System.Windows.Forms.CheckBox checkBox1;
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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
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
			this.label1.Size = new System.Drawing.Size(434, 18);
			this.label1.TabIndex = 4;
			this.label1.Text = "The sample demonstrates how to scatter chart in an excel workbook.";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(16, 56);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(144, 24);
			this.checkBox1.TabIndex = 5;
			this.checkBox1.Text = "Smoothed line chart";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(616, 94);
			this.Controls.Add(this.checkBox1);
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

			//Add a new  chart worsheet to workbook
			Chart chart = sheet.Charts.Add();

			CreateChartData(sheet);
			CreateChart(sheet, chart);

			if (checkBox1.Checked)
				chart.ChartType = ExcelChartType.ScatterSmoothedLineMarkers;
			else
				chart.ChartType = ExcelChartType.ScatterLineMarkers;


			chart.Legend.Position = LegendPositionType.Top;
			workbook.SaveToFile("Sample.xls");
			ExcelDocViewer(workbook.FileName);
		}

		private void CreateChart(Worksheet  sheet, Chart chart)
		{
			//Set region of chart data
			chart.DataRange = sheet.Range["B1:B12"];
			chart.SeriesDataFromRange = false;

			//Set position of chart
			chart.LeftColumn = 3;
			chart.TopRow = 6;
			chart.RightColumn = 11;
			chart.BottomRow = 29;


			//Chart title
			chart.ChartTitle = "Reflex Time Analysis";
			chart.ChartTitleArea.IsBold = true;
			chart.ChartTitleArea.Size = 12;

			chart.PrimaryCategoryAxis.Title = "Age";
			chart.PrimaryCategoryAxis.Font.IsBold = true;
			chart.PrimaryCategoryAxis.TitleArea.IsBold = true;
			
			chart.PrimaryValueAxis.Title = "Reflex Time";
			chart.PrimaryValueAxis.HasMajorGridLines = false;
			chart.PrimaryValueAxis.TitleArea.IsBold = true;
			chart.PrimaryValueAxis.TitleArea.TextRotationAngle = 90;

		

			Charts.ChartSerie cs = chart.Series[0];
			cs.CategoryLabels = sheet.Range["A2:A12"];
		}
	

		private void CreateChartData(Worksheet sheet)
		{
			string RCAddress = "A{0}:B{0}";
			//Age
			sheet.Range["A1"].Value = "Age";
			sheet.Range["A2"].NumberValue = 29;
			sheet.Range["A3"].NumberValue = 32;
			sheet.Range["A4"].NumberValue = 33;
			sheet.Range["A5"].NumberValue = 33;
			sheet.Range["A6"].NumberValue = 34;
			sheet.Range["A7"].NumberValue = 34;
			sheet.Range["A8"].NumberValue = 40;
			sheet.Range["A9"].NumberValue = 61;
			sheet.Range["A10"].NumberValue = 62;
			sheet.Range["A11"].NumberValue = 70;
			sheet.Range["A12"].NumberValue = 78;
                                                   
			//Reflex Time
			sheet.Range["B1"].Value = "Reflex Time";
			sheet.Range["B2"].NumberValue = 0.46; 
			sheet.Range["B3"].NumberValue = 0.45; 
			sheet.Range["B4"].NumberValue = 0.43;
			sheet.Range["B5"].NumberValue = 0.41 ;
			sheet.Range["B6"].NumberValue = 0.38 ;
			sheet.Range["B7"].NumberValue = 0.37 ;
			sheet.Range["B8"].NumberValue = 0.19 ;
			sheet.Range["B9"].NumberValue = 0.19 ;
			sheet.Range["B10"].NumberValue =0.17 ;
			sheet.Range["B11"].NumberValue =0.13 ;
			sheet.Range["B12"].NumberValue =0.076 ;


			//Style
			sheet.Range["A1:C1"].Style.Font.IsBold = true;
			for( int i = 2; i < 13; i++)
			{
				if ( i % 2 == 0)
				  sheet.Range[ string.Format(RCAddress,i)].Style.KnownColor = ExcelColors.LightYellow;
				else
				  sheet.Range[ string.Format(RCAddress,i)].Style.KnownColor = ExcelColors.LightGreen1;
			}

			//Border
			CellStyle style = sheet.Range["A1:B12"].Style;
			style.Borders[BordersLineType.EdgeTop].Color = Color.FromArgb(0, 0, 128);
			style.Borders[BordersLineType.EdgeTop].LineStyle = LineStyleType.Thin;
			style.Borders[BordersLineType.EdgeBottom].Color = Color.FromArgb(0, 0, 128);
			style.Borders[BordersLineType.EdgeBottom].LineStyle = LineStyleType.Thin;
			style.Borders[BordersLineType.EdgeLeft].Color = Color.FromArgb(0, 0, 128);
			style.Borders[BordersLineType.EdgeLeft].LineStyle = LineStyleType.Thin;
			style.Borders[BordersLineType.EdgeRight].Color = Color.FromArgb(0, 0, 128);
			style.Borders[BordersLineType.EdgeRight].LineStyle = LineStyleType.Thin;
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
