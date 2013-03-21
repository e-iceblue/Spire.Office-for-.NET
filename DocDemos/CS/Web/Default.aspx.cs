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

using Spire.Doc;
using Spire.Doc.Documents;

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
            //Create word document
            Document document = new Document();

            InsertWatermark(document);

            //Save doc file.
            document.SaveToFile("Sample.doc", FileFormat.Doc,Response, HttpContentType.Attachment);
		}
        private void InsertWatermark(Document document)
        {
            Paragraph paragraph = document.AddSection().AddParagraph();
            paragraph.AppendText("The sample demonstrates how to insert a watermark into a document.");
            paragraph.ApplyStyle(BuiltinStyle.Heading2);


            TextWatermark txtWatermark = new TextWatermark();
            txtWatermark.Text = "Watermark Demo";
            txtWatermark.FontSize = 90;
            txtWatermark.Layout = WatermarkLayout.Diagonal;
            document.Watermark = txtWatermark;

        }

		private void Button2_Click(object sender, System.EventArgs e)
		{
		}
	}
}
