using System;
using System.IO;
using System.Windows.Forms;

namespace PdfDocumentViewer_Save
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string pdfDoc = @"..\..\..\..\..\..\Data\PartList.pdf";
            if (File.Exists(pdfDoc))
            {
                this.pdfDocumentViewer1.LoadFromFile(pdfDoc);
            }
        }

        private void BtnOpen_Click(object sender, EventArgs e)
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.PageCount > 0)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "PDF document (*.pdf)|*.pdf";
                DialogResult result = dialog.ShowDialog();
                string fileName = dialog.FileName;
                if (result == DialogResult.OK)
                {
                    pdfDocumentViewer1.SaveToFile(fileName);
                    MessageBox.Show("You have saved this PdfDocuemnt as:\n" + fileName,"Spire.PdfViewer Demo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                

            }
        }

        private void btnSaveStream_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.PageCount > 0)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "PDF document (*.pdf)|*.pdf";
                DialogResult result = dialog.ShowDialog();
                string fileName = dialog.FileName;
                if (result == DialogResult.OK)
                {
                  
                   MemoryStream stream = new MemoryStream();
                   pdfDocumentViewer1.SaveToFile(stream);
                   byte[] fileBytes = stream.ToArray();
                   FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
                   fileStream.Write(fileBytes, 0, fileBytes.Length);
                   fileStream.Flush();
                   fileStream.Close();
                   stream.Close();
                   MessageBox.Show("You have first saved this PDF docuemnt as memory stream,\nthen write the memory stream in a file :\n" + fileName,"Spire.PdfViewer Demo",MessageBoxButtons.OK,MessageBoxIcon.Information);
             
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

        private void pdfDocumentViewer1_PageNumberChanged(object sender, EventArgs args)
        {
            if (this.comBoxPages.Items.Count <= 0)
                return;
            if (this.pdfDocumentViewer1.CurrentPageNumber != this.comBoxPages.SelectedIndex + 1)
            {
                this.comBoxPages.SelectedIndex = this.pdfDocumentViewer1.CurrentPageNumber - 1;
            }
        }

        private void comBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            int soucePage = this.pdfDocumentViewer1.CurrentPageNumber;
            int targetPage = this.comBoxPages.SelectedIndex + 1;
            if (soucePage != targetPage)
            {
                this.pdfDocumentViewer1.GoToPage(targetPage);
            }
        }

       
    }
}
