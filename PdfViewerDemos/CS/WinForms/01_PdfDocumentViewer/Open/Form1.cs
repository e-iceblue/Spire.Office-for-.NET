using System;
using System.IO;
using System.Windows.Forms;
using Spire.PdfViewer.Forms;

namespace PdfViewer_Open
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
                catch(Exception exe)
                {
                    MessageBox.Show(exe.Message, "Spire.PdfViewer Demo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void BtnOpenStream_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PDF document (*.pdf)|*.pdf";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string pdfFile = dialog.FileName;
                FileStream stream = new FileStream(pdfFile, FileMode.Open, FileAccess.Read, FileShare.Read);
                {
                    try
                    {
                        stream.Position = 0;
                        pdfDocumentViewer1.LoadFromStream(stream as Stream);
                        MessageBox.Show("Open PDF document from data stream success!","Spire.PdfViewer Demo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    catch (IOException exe)
                    {
                        MessageBox.Show("Error occurrs!\n" + exe.Message, "Spire.PdfViewer Demo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void BtnOpenPass_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PDF document (*.pdf)|*.pdf";
          
            DialogResult result = dialog.ShowDialog();
             string pdfFile = dialog.FileName;
            if (result == DialogResult.OK)
            {
               
                try
                {
                   
                    this.pdfDocumentViewer1.LoadFromFile(pdfFile);
                }
                catch (Exception exe)
                {
                    while (true)
                    {
                        string passError = " password is invalid";
                        string message = exe.Message;
                        if (message.IndexOf(passError) > -1)
                        {
                            string info = pdfFile + " has password !\n You  need input its password!";
                            PasswordDlg dlg = new PasswordDlg();

                           DialogResult dlgResult= dlg.ShowDialog();
                           if (dlgResult == DialogResult.Cancel)
                               break;                        
                            string pass = dlg.getPass();
                            if (!String.IsNullOrEmpty(pass))
                            {
                                try
                                {
                                    this.pdfDocumentViewer1.LoadFromFile(pdfFile, pass);
                                    dlg.Dispose();
                                    break;
                                }
                                catch (Exception exc)
                                {
                                    dlg.Dispose();
                                }
                            }
                        }
                    }
                }


            }

        }

      

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.PageCount > 0)
            {
                this.pdfDocumentViewer1.CloseDocument();
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.pdfDocumentViewer1.CloseDocument();

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
    }
}
