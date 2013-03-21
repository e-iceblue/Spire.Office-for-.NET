using System;
using System.IO;
using System.Windows.Forms;
using Spire.PdfViewer.Forms;


namespace PdfViewer_HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string pdfDoc = @"..\..\..\..\..\..\Data\Le_Petit_Prince_French.pdf";
            if (File.Exists(pdfDoc))
            {
                this.pdfViewer1.LoadFromFile(pdfDoc);
            }

        }

      
    }
}
