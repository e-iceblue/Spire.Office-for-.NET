using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ViewerMode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"..\..\..\..\..\..\Data\Italin.pdf"))
            {
                this.pdfDocumentViewer1.LoadFromFile(@"..\..\..\..\..\..\Data\Italin.pdf");
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
                string pdfFile = dialog.FileName;
                this.pdfDocumentViewer1.LoadFromFile(pdfFile);
            }
        }
        /// <summary>
        /// Continuous page mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContinuous_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.IsDocumentLoaded)
            {
                this.pdfDocumentViewer1.SetViewerMode(Spire.PdfViewer.Forms.PdfViewerMode.PdfViewerMode.MultiPage);
            }

        }
        /// <summary>
        /// Single page mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSingle_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.IsDocumentLoaded)
            {
                this.pdfDocumentViewer1.SetViewerMode(Spire.PdfViewer.Forms.PdfViewerMode.PdfViewerMode.SinglePage);
            }
        }
        /// <summary>
        /// Auto mode,if PDF document height greater than 32767,display with single page mode,otherwise display with continuous page mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAuto_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.IsDocumentLoaded)
            {
                this.pdfDocumentViewer1.SetViewerMode(Spire.PdfViewer.Forms.PdfViewerMode.PdfViewerMode.Auto);
            }
        }
        /// <summary>
        /// Threshold mode,if PDF document page count less than Threshold value,display with continuous page mode ,otherwize display with single page mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThreshold_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.IsDocumentLoaded)
            {
                int threshold = 0;
                bool isNumeric = int.TryParse(this.txtThreshold.Text, out threshold);
                if (isNumeric)
                {
                    this.pdfDocumentViewer1.Threshold = Math.Abs(threshold);
                    this.pdfDocumentViewer1.SetViewerMode(Spire.PdfViewer.Forms.PdfViewerMode.PdfViewerMode.DynamicSet);
                }
            }
        }

        private void pdfDocumentViewer1_PageNumberChanged(object sender, EventArgs args)
        {
            this.lblPage.Text = this.pdfDocumentViewer1.CurrentPageNumber.ToString();
        }

 
    }
}
