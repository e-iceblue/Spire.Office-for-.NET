using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace DocDocumentViewer_Export
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Dictionary<string, BitmapSource> bitMap = new Dictionary<string, BitmapSource>();
        public static int m_CurrentPageNum = 0;
        public MainWindow()
        {
            InitializeComponent();
            this.docDocumentViewer1.PageNumberChanged += new Spire.DocViewer.PageNumberChangedEventHandler(docDocumentViewer1_PageNumberChanged);
            this.docDocumentViewer1.DocLoaded += new Spire.DocViewer.DocumentOpenedEventHandler(docDocumentViewer1_DocLoaded);
            this.textBox1.IsEnabled = ckbFrom.IsChecked.Value;
            this.textBox2.IsEnabled = ckbTo.IsChecked.Value;
        }

        private void docDocumentViewer1_DocLoaded(object sender, EventArgs args)
        {
            this.textBox2.Text = this.docDocumentViewer1.PageCount.ToString();
        }

        private void docDocumentViewer1_PageNumberChanged(object sender, EventArgs args)
        {
            textBox1.Text = this.docDocumentViewer1.CurrentPageNumber.ToString();
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            //Open a Doc Document
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Word97-2003 files(*.doc)|*.doc|Word2007-2010 files (*.docx)|*.docx|All files (*.doc;*.docx)|*.doc;*.docx",
                Title = "Select a DOC file",
                Multiselect = false,
                InitialDirectory = System.IO.Path.GetFullPath(@"..\..\..\..\..\..\Data")
            };
            bool? boolVar = dialog.ShowDialog().Value;
            if (boolVar.Value)
            {
                try
                {
                    // Load doc document from file.
                    this.docDocumentViewer1.LoadFromFile(dialog.FileName);
                    this.textBox2.Text = this.docDocumentViewer1.PageCount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void ckbHandTool_Click(object sender, RoutedEventArgs e)
        {
            docDocumentViewer1.EnableHandTools = ckbHandTool.IsChecked.Value;
        }

        private void btnSaveImage_Click(object sender, RoutedEventArgs e)
        {
            this.IsEnabled = false;
            bitMap.Clear();
            try
            {
                if (ckbFrom.IsChecked.Value && ckbTo.IsChecked.Value)
                {
                    try
                    {
                        int startIndex = 0;
                        int.TryParse(textBox1.Text, out startIndex);
                        m_CurrentPageNum = startIndex;
                        int endIndex = 0;
                        int.TryParse(textBox2.Text, out endIndex);

                        // Exports the specified pages as Images
                        BitmapSource[] bitmapsource = this.docDocumentViewer1.SaveImage((ushort)(startIndex), (ushort)(endIndex));
                        SaveImageToFile(bitmapsource);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else if (ckbFrom.IsChecked.Value && !ckbTo.IsChecked.Value)
                {
                    try
                    {
                        int currepageIndex = 0;
                        int.TryParse(textBox1.Text, out currepageIndex);
                        m_CurrentPageNum = currepageIndex;
                        //Saves the specified page as Image
                        BitmapSource bitmapsource = this.docDocumentViewer1.SaveImage((ushort)(currepageIndex));
                        SaveImageToFile(new BitmapSource[] { bitmapsource });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch { }
            ShowImage();
            this.IsEnabled = true;
        }

        private void ckbTo_Click(object sender, RoutedEventArgs e)
        {
            textBox2.IsEnabled = ckbTo.IsChecked.Value;
        }

        private void SaveImageToFile(BitmapSource[] bitmpaSource)
        {
            int startIndex = 1;
            int.TryParse(textBox1.Text, out startIndex);
            foreach (BitmapSource bitmap in bitmpaSource)
            {
                WriteBitmapSourecToFile(bitmap, startIndex);
                startIndex++;
            }
        }

        // <summary>
        // BitmapSource Write to File
        // </summary>
        // <param name="bitMapImg">bitmapSource </param>
        private void WriteBitmapSourecToFile(BitmapSource bitMapImg, int currentPageIndex)
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

                    System.IO.FileStream fs = new System.IO.FileStream(FullfileName, System.IO.FileMode.Create);
                    BitmapEncoder encoder = new PngBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(bitMapImg));
                    encoder.Save(fs);
                    fs.Close();

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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // Load doc document from file.
                this.docDocumentViewer1.LoadFromFile(@"..\..\..\..\..\..\Data\PartList.docx");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
