using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PageDisplayMode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"..\..\..\..\..\..\Data\Lslam.pdf"))
            {
                this.pdfDocumentViewer1.LoadFromFile(@"..\..\..\..\..\..\Data\Lslam.pdf");
            }

        }

        /// <summary>
        /// Open PDF document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PDF document(*.pdf)|*.pdf";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string pdfDocument = dialog.FileName;
                this.pdfDocumentViewer1.LoadFromFile(pdfDocument);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSingleContinuous_Click(object sender, EventArgs e)
        {
            this.pdfDocumentViewer1.SetPageLayoutMode(Spire.PdfViewer.Forms.PageLayoutMode.SinglePageContinuous);
        }

        private void btnSingleDiscontinuous_Click(object sender, EventArgs e)
        {
            this.pdfDocumentViewer1.SetPageLayoutMode(Spire.PdfViewer.Forms.PageLayoutMode.SinglePageDiscontinuous);
        }

        private void btnDoubleContinuous_Click(object sender, EventArgs e)
        {
            this.pdfDocumentViewer1.SetPageLayoutMode(Spire.PdfViewer.Forms.PageLayoutMode.TwoPageContinuous);
        }

        private void btnDoubleDiscontinuous_Click(object sender, EventArgs e)
        {
            this.pdfDocumentViewer1.SetPageLayoutMode(Spire.PdfViewer.Forms.PageLayoutMode.TwoPageDiscontinuous);
        }

        private void pdfDocumentViewer1_PageNumberChanged(object sender, EventArgs args)
        {
            this.lblPage.Text = this.pdfDocumentViewer1.CurrentPageNumber.ToString();
        }




    }
}
