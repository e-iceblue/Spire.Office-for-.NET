using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Export
{
    public partial class Form1 : Form
    {
        public static Dictionary<string, Image> bitMap = new Dictionary<string, Image>();
        public static int m_CurrentPageNum = 0;
        public Form1()
        {
            InitializeComponent();

            this.docDocumentViewer1.PageNumberChanged += new Spire.DocViewer.PageNumberChangedEventHandler(docDocumentViewer1_PageNumberChanged);
            this.docDocumentViewer1.DocLoaded += new Spire.DocViewer.DocumentOpenedEventHandler(docDocumentViewer1_DocLoaded);
            this.textBox1.Enabled = ckbFrom.Checked;
            this.textBox2.Enabled = ckbTo.Checked;
            try
            {
                // Load doc document from file.
                this.docDocumentViewer1.LoadFromFile(@"..\..\..\..\..\..\Data\PartList.docx");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void docDocumentViewer1_DocLoaded(object sender, EventArgs args)
        {
            this.textBox2.Text = this.docDocumentViewer1.PageCount.ToString();
        }

        private void docDocumentViewer1_PageNumberChanged(object sender, EventArgs args)
        {
            textBox1.Text = this.docDocumentViewer1.CurrentPageNumber.ToString();           
        }


        private void ckbHandtool_CheckedChanged(object sender, EventArgs e)
        {
            this.docDocumentViewer1.EnableHandTools = ckbHandtool.Checked;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //Open a Doc Document
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter="Word97-2003 files(*.doc)|*.doc|Word2007-2010 files (*.docx)|*.docx|All files (*.*)|*.*";
            dialog.Title="Select a DOC file";
            dialog.Multiselect=false;
            dialog.InitialDirectory=System.IO.Path.GetFullPath(@"..\..\..\..\..\..\Data");           
           
            DialogResult result = dialog.ShowDialog();
            if (result==DialogResult.OK)
            {
                try
                {
                    // Load doc document from file.
                    this.docDocumentViewer1.LoadFromFile(dialog.FileName);
                    this.textBox2.Text = this.docDocumentViewer1.PageCount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            bitMap.Clear();
            try
            {
                if (ckbFrom.Checked && ckbTo.Checked)
                {
                    try
                    {
                        int startIndex = 0;
                        int.TryParse(textBox1.Text, out startIndex);
                        m_CurrentPageNum = startIndex;
                        int endIndex = 0;
                        int.TryParse(textBox2.Text, out endIndex);

                        // Exports the specified pages as Images
                        Image[] bitmapsource = this.docDocumentViewer1.SaveImage((ushort)(startIndex), (ushort)(endIndex));
                        SaveImageToFile(bitmapsource);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (ckbFrom.Checked && !ckbTo.Checked)
                {
                    try
                    {
                        int currepageIndex = 0;
                        int.TryParse(textBox1.Text, out currepageIndex);
                        m_CurrentPageNum = currepageIndex;
                        //Saves the specified page as Image
                        Image bitmapsource = this.docDocumentViewer1.SaveImage((ushort)(currepageIndex));
                        SaveImageToFile(new Image[] { bitmapsource });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
            ShowImage();
            this.Enabled = true;
        }

        private void SaveImageToFile(Image[] bitmpaSource)
        {
            int startIndex = 1;
            int.TryParse(textBox1.Text, out startIndex);
            foreach (Bitmap bitmap in bitmpaSource)
            {
                WriteImageFile(bitmap, startIndex);
                startIndex++;
            }
        }

        // <summary>
        // BitmapSource Write to File
        // </summary>
        // <param name="bitMapImg">bitmapSource </param>
        private void WriteImageFile(Image bitMapImg, int currentPageIndex)
        {
            try
            {
                if (bitMapImg != null)
                {
                    string date = DateTime.Now.ToShortDateString().Replace("-", "").Replace(@"/", "").Replace(".", "");
                    string path = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
                    string dirPathFullname = path + @"\" + date + @"\";
                    string filename = System.IO.Path.GetFileNameWithoutExtension(this.docDocumentViewer1.FileName);
                    string FullfileName = dirPathFullname + filename + "_" + currentPageIndex.ToString() + ".png";

                    if (!System.IO.Directory.Exists(dirPathFullname))
                    {
                        System.IO.Directory.CreateDirectory(dirPathFullname);
                    }

                    bitMapImg.Save(FullfileName, System.Drawing.Imaging.ImageFormat.Png);
                    bitMap.Add(FullfileName, bitMapImg);
                }
            }
            catch (Exception ex)
            {
#if DEBUG
                System.Diagnostics.Debug.WriteLine(ex.Message + ex.Source);
#endif
            }
        }

        // <summary>
        // Show ImageViewer Window
        // </summary>
        private void ShowImage()
        {
            int count = bitMap.Count;
            if (count > 0)
            {
                ImageViewer iv = new ImageViewer();
                iv.ShowDialog();
            }
        }      

        private void ckbTo_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Enabled = ckbTo.Checked;
        }
    }
}
