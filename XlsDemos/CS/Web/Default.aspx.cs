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

using Spire.Xls;

namespace Spire.WebDemo
{

	public partial class DefaultForm : System.Web.UI.Page
	{
		protected System.Data.OleDb.OleDbConnection oleDbConnection1;
		protected System.Data.OleDb.OleDbCommand oleDbCommand1;
		protected System.Web.UI.WebControls.RadioButtonList RadioButtonList1;
		protected System.Web.UI.WebControls.RadioButtonList RadioButtonList2;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
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

		}
		#endregion

		protected void Button1_Click(object sender, System.EventArgs e)
		{
			Workbook workbook = new Workbook();
			
			//Initailize worksheet
			workbook.LoadFromFile(Page.MapPath(@"./Data/EditChartSample.xls"),true);
			Worksheet sheet = workbook.Worksheets[0];

			//Writes chart data
			CreateChartData(sheet);

			workbook.SaveToHttpResponse("Sample.xls", Response);
		}

		private void CreateChartData(Worksheet sheet)
		{
			//Jun
			sheet.Range["F6"].NumberValue = 6000;
			sheet.Range["F7"].NumberValue = 8000;
			sheet.Range["F8"].NumberValue = 9000;
			sheet.Range["F9"].NumberValue = 8500;

			//Aug
			sheet.Range["G6"].NumberValue = 4000;
			sheet.Range["G7"].NumberValue = 7000;
			sheet.Range["G8"].NumberValue = 2000;
			sheet.Range["G9"].NumberValue = 5000;

			sheet.Range["F6:F9"].Style.NumberFormat = "\"$\"#,##0";
			sheet.Range["G6:G9"].Style.NumberFormat = "\"$\"#,##0";
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
		}
	}
}
