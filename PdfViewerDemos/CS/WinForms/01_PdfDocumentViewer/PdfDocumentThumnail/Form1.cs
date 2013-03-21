using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.IO;
using System.Text;
using System.Windows.Forms;
using Spire.PdfViewer.Forms;
using Spire.PdfViewer.Forms.PdfThumbnails;


namespace PdfDocumentThumnail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtThumbnailRatio.Text = this.pdfDocumentThumbnail1.ZoomPercent.ToString();
            if (File.Exists(@"..\..\..\..\..\..\Data\Italin.pdf"))
            {
                this.pdfDocumentViewer1.LoadFromFile(@"..\..\..\..\..\..\Data\Italin.pdf");
            }

        }


        /// <summary>
        /// Load PDF document
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
        /// Set PdfDocumentThumbnail ratio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThumbnailRatio_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.IsDocumentLoaded)
            {
                int percent = 0;
                bool isNumeric = int.TryParse(this.txtThumbnailRatio.Text, out percent);
                if (isNumeric)
                {
                    this.pdfDocumentThumbnail1.ZoomPercent =Math.Abs(percent);
                }
            }
        }


    }
}
