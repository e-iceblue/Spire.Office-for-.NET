using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SimpleFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"..\..\..\..\..\..\Data\PDFViewer.pdf"))
            {
                this.pdfDocumentViewer1.LoadFromFile(@"..\..\..\..\..\..\Data\PDFViewer.pdf");
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
        /// Get PDF document information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.IsDocumentLoaded)
            {
                string info = "";
                info += "File name: " + this.pdfDocumentViewer1.FileName+"\n";
                Spire.PdfViewer.Forms.PdfDocumentInfo docInfo = this.pdfDocumentViewer1.GetDocumentInfomation();
                info += "Author: " + docInfo.Author + "\n";
                info += "Creator: " + docInfo.Creator + "\n";
                info += "Producer: " + docInfo.Producer + "\n";
                info += "Title: " + docInfo.Title + "\n";
                info += "Subject: " + docInfo.Subject + "\n";
                info += "Keywords: " + docInfo.Keywords + "\n";
                info += "Creation date: " + docInfo.CreationDate.ToString()+"\n";
                info += "Modifaction date: " + docInfo.ModificationDate.ToString()+"\n";
                MessageBox.Show(info, "Document information", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Verify PDF document whether to encrypt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerifyEncrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PDF document(*.pdf)|*.pdf";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string pdfDocument = dialog.FileName;
                bool isEncrypted = Spire.PdfViewer.Forms.PdfDocumentViewer.VeryfyDocumentEncrypted(pdfDocument);
                string info = "The PDF document file  " + dialog.FileName + "\nEncrypted: " + isEncrypted.ToString();
                MessageBox.Show(info, "Verify Encrypt", MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }

        }
        /// <summary>
        /// Open html document as PDF document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFromHtml_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "html files(*.html)|*.html";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string htmlDocument = dialog.FileName;
                String pdfDocument=htmlDocument.Substring(0,htmlDocument.Length-4)+"pdf";
                this.pdfDocumentViewer1.LoadFromHtml(htmlDocument,pdfDocument);
            }
        }


    }
}
