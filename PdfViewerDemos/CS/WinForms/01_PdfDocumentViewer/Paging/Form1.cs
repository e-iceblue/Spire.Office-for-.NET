using System;
using System.IO;
using System.Windows.Forms;

namespace PdfDocumentViewer_Paging
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string pdfDoc = @"..\..\..\..\..\..\Data\Spire.Office.pdf";
            if (File.Exists(pdfDoc))
            {
                this.pdfDocumentViewer1.LoadFromFile(pdfDoc);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PDF document (*.pdf)|*.pdf";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
            
                {
                    string pdfFile = dialog.FileName;
                    this.pdfDocumentViewer1.LoadFromFile(pdfFile);
                   
                }

            }
        }

        private void binFirst_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.PageCount > 0)
            {
                int currentPage = this.pdfDocumentViewer1.CurrentPageNumber;
                if (currentPage != 1)
                {
                    this.pdfDocumentViewer1.GoToFirstPage();
                }
                else
                {
                    MessageBox.Show("Current page is already the first!" ,"Spire.PdfViewer Demo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
        
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.PageCount > 0)
            {

                int currentPage = this.pdfDocumentViewer1.CurrentPageNumber;

                if (currentPage > 1)
                {
                    this.pdfDocumentViewer1.GoToPreviousPage();
                }
                else
                {
                    MessageBox.Show("Current page is already the first!","Spire.PdfViewer Demo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.PageCount>0)
            {
                int currentPage = this.pdfDocumentViewer1.CurrentPageNumber;
                int totalPage=this.pdfDocumentViewer1.PageCount;
                if (currentPage < totalPage)
                {
                    this.pdfDocumentViewer1.GoToNextPage();
                                   
                }
                else
                {
                    MessageBox.Show("Current page is already the last!","Spire.PdfViewer Demo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
          

        }

        private void pdfDocumentViewer1_PdfLoaded(object sender, EventArgs args)
        {
            this.comBoxPages.Items.Clear();
            int totalPage = this.pdfDocumentViewer1.PageCount;
                  
            for (int i = 1; i <= totalPage; i++)
            {
                this.comBoxPages.Items.Add(i.ToString());
            }
          
            this.comBoxPages.SelectedIndex = 0;

        }

        private void comBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            int soucePage = this.pdfDocumentViewer1.CurrentPageNumber;
            int targetPage = this.comBoxPages.SelectedIndex+1 ;
            if (soucePage != targetPage)
            {
                this.pdfDocumentViewer1.GoToPage(targetPage);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.PageCount > 0)
            {
                int currentPage = this.pdfDocumentViewer1.CurrentPageNumber;
                int totalPage = this.pdfDocumentViewer1.PageCount;
                if (currentPage != totalPage)
                {
                    this.pdfDocumentViewer1.GoToLastPage();
                }
                else
                {
                    MessageBox.Show("Current page is already the last!","Spire.PdfViewer Demo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
          
        }

        private void pdfDocumentViewer1_PageNumberChanged(object sender, EventArgs args)
        {
            if (this.comBoxPages.Items.Count <= 0)
                return;
            if (this.pdfDocumentViewer1.CurrentPageNumber!=this.comBoxPages.SelectedIndex+1)
            {
                this.comBoxPages.SelectedIndex=this.pdfDocumentViewer1.CurrentPageNumber-1;
            }
            
         
          

        }

       

      

     

                    
        
    }
}
