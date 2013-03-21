using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SimpleEBook_VS2010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"..\..\..\..\..\..\Data\Le_Petit_Prince_French.pdf"))
            {
                this.pdfDocumentViewer1.LoadFromFile(@"..\..\..\..\..\..\Data\Le_Petit_Prince_French.pdf");
                //Set viewer mode as single page mode
                this.pdfDocumentViewer1.SetViewerMode(Spire.PdfViewer.Forms.PdfViewerMode.PdfViewerMode.SinglePage);

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
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string pdfDocument = dialog.FileName;
                this.pdfDocumentViewer1.LoadFromFile(pdfDocument);
                //Set viewer mode as single page mode
                this.pdfDocumentViewer1.SetViewerMode(Spire.PdfViewer.Forms.PdfViewerMode.PdfViewerMode.SinglePage);

            }
        }
        /// <summary>
        /// Go to first page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelFirst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.pdfDocumentViewer1.IsDocumentLoaded)
                this.pdfDocumentViewer1.GoToFirstPage();
        }
        /// <summary>
        /// Go to previous page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelPrevious_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.pdfDocumentViewer1.IsDocumentLoaded)
                this.pdfDocumentViewer1.GoToPreviousPage();
        }


        /// <summary>
        /// Go to next page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLableNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.pdfDocumentViewer1.IsDocumentLoaded)
                this.pdfDocumentViewer1.GoToNextPage();
        }

        private void linkLabelLast_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.pdfDocumentViewer1.IsDocumentLoaded)
                this.pdfDocumentViewer1.GoToLastPage();
        }

        private void pdfDocumentViewer1_PageNumberChanged(object sender, EventArgs args)
        {
            this.txtPage.Text = this.pdfDocumentViewer1.CurrentPageNumber.ToString();
        }
        /// <summary>
        /// Go to specified page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int pageNumber = 0;
                bool isNumeric = int.TryParse(txtPage.Text.Trim(), out pageNumber);
                if (isNumeric)
                {
                    this.pdfDocumentViewer1.GoToPage(Math.Abs(pageNumber));
                }
            }
        }



    }
}
