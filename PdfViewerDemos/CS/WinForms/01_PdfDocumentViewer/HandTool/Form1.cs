using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.IO;
using System.Text;
using System.Windows.Forms;

namespace HandTool
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
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string pdfDocument = dialog.FileName;
                this.pdfDocumentViewer1.LoadFromFile(pdfDocument);
            }
        }
        /// <summary>
        /// Enable hand tool
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHandTool_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.IsDocumentLoaded)
            {
                this.pdfDocumentViewer1.EnableHandTool();
            }
        }
        /// <summary>
        /// Escape hand hand tool
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(this.pdfDocumentViewer1.IsDocumentLoaded)
            {
                this.pdfDocumentViewer1.EscapeHandTool();
            }
        }
        /// <summary>
        /// Zoom PDF document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZoom_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.IsDocumentLoaded)
            {
                int zoomPercent = 0;
                bool isNumberic = int.TryParse(this.txtZoom.Text, out zoomPercent);
                if (isNumberic)
                {
                    this.pdfDocumentViewer1.ZoomTo(zoomPercent);
                }

            }

        }


    }
}
