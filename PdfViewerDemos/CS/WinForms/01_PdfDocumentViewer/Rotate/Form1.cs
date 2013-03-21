using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.IO;
using System.Text;
using System.Windows.Forms;
using Spire.PdfViewer.Forms;

namespace Rotate
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
                string pdfFile = dialog.FileName;
                this.pdfDocumentViewer1.LoadFromFile(pdfFile);
            }
        }
        /// <summary>
        /// Rotate PDF document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRotate_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.IsDocumentLoaded)
            {
                if (this.comBoxAngle.SelectedIndex != -1)
                {
                    RotateAngle angle = (RotateAngle)this.comBoxAngle.SelectedIndex;
                    this.pdfDocumentViewer1.Rotate(angle);
                    
                }
            }
        }


    }
}
