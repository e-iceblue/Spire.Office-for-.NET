using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PdfDocumentViewer_Export
{
    public partial class Form1 : Form
    {
        private FormImages _formImages;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string pdfDoc = @"..\..\..\..\..\..\Data\PDFViewer.pdf";
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
                try
                {
                    string pdfFile = dialog.FileName;
                    this.pdfDocumentViewer1.LoadFromFile(pdfFile);
                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.Message, "Spire.PdfViewer Demo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if(this.pdfDocumentViewer1.PageCount>0)
            {
                SaveFileDialog dialog=new SaveFileDialog ();
                dialog.Filter="JPG Format(*.jpg)|*.jpg|BMP Format(*.bmp)|*.bmp|PNG Format(*.png)|*.png|GIF Format(*.gif)|*.gif";
                DialogResult result=dialog.ShowDialog();
                string fileName=dialog.FileName;
                if (result==DialogResult.OK)
                {
              
                    int currentPage=this.pdfDocumentViewer1.CurrentPageNumber;
                    Bitmap image=this.pdfDocumentViewer1.SaveAsImage(currentPage-1);
                    image.Save(fileName);
                    MessageBox.Show("You have exported current page to an image:\n"+fileName,"Spire.PdfViewer Demo",MessageBoxButtons.OK,MessageBoxIcon.Information);

           
                    Dictionary<string, Image> dictionaryImages = new Dictionary<string, Image>();
                    dictionaryImages.Add(fileName, image);
              
                    this._formImages = new FormImages();
                    this._formImages.DictionaryImages = dictionaryImages;
                    this._formImages.Show();



             


                }
            }

        }

        private void pdfDocumentViewer1_PdfLoaded(object sender, EventArgs args)
        {
            this.comBoxFrom.Items.Clear();
            this.comboxTo.Items.Clear();

            int totalPage = this.pdfDocumentViewer1.PageCount;
            for (int i = 1; i <= totalPage; i++)
            {
                this.comBoxFrom.Items.Add(i.ToString());
                this.comboxTo.Items.Add(i.ToString());
               
                
            }
            this.comBoxFrom.SelectedIndex = 0;
            this.comboxTo.SelectedIndex = 0;

        }

        private void btnMultiExport_Click(object sender, EventArgs e)
        {


            if (this.pdfDocumentViewer1.PageCount <= 0)
            {
                return;
            }

            int fromPage = this.comBoxFrom.SelectedIndex;
            int toPage = this.comboxTo.SelectedIndex;
            if (fromPage > toPage)
            {
                MessageBox.Show("End page number must be not less than started page number!", "Spire.PdfViewer Demo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                
            
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                
                    string path = dialog.SelectedPath;
                    Bitmap[] images = this.pdfDocumentViewer1.SaveAsImage(fromPage, toPage);
                    Dictionary<String, Image> dictionaryImages = new Dictionary<string, Image>();
                    for (int i = 0; i < images.Length; i++)
                    {
                        string name = "image" + (i + 1 + fromPage).ToString() + ".bmp";
                        string fileName = path + "\\" + name;
                        images[i].Save(fileName);
                        dictionaryImages.Add(fileName, images[i]);
                     
                    }
                    string message = "You have exported " + (fromPage+1).ToString() + "-" + (toPage+1).ToString() +" pages as images to:\n"
                       + path;
                    MessageBox.Show(message,"Spire.PdfViewer Demo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                  
                    this._formImages = new FormImages();
                    this._formImages.DictionaryImages = dictionaryImages;
                    this._formImages.Show();



                   
                }
            }

        }
   

        

 


    }
}
