using System;
using System.Collections.Generic;
using System.IO;
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
using Spire.PdfViewer.Wpf;
using Spire.PdfViewer.Wpf.PdfViewerMode;

namespace ViewerMode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.txtMaxPages.Text = this.pdfDocumentViewer1.MultiPagesThreshold.ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string pdfFileName = @"..\..\..\..\..\..\Data\Lslam.pdf";
            if (File.Exists(pdfFileName))
            {
                this.pdfDocumentViewer1.LoadFromFile(pdfFileName);
            }

        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PDF document(*.pdf)|*.pdf";
            bool? dialogResult = dialog.ShowDialog();
            if (dialogResult.HasValue && dialogResult.Value)
            {
                string pdfFileName = dialog.FileName;
                this.pdfDocumentViewer1.LoadFromFile(pdfFileName);
            }

        }

        private void CboViewerMode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.pdfDocumentViewer1!=null&&this.pdfDocumentViewer1.IsDocumentLoaded && this.CboViewerMode.SelectedIndex != -1)
            {
                PdfViewerMode viewerMode = (PdfViewerMode)this.CboViewerMode.SelectedIndex;
                if (viewerMode == PdfViewerMode.DynamicSet)
                {
                    try
                    {
                        int maxPageThreshold = Int32.Parse(this.txtMaxPages.Text);
                        this.pdfDocumentViewer1.MultiPagesThreshold = maxPageThreshold;
                    }
                    catch
                    {
                    }
                    
                }
                //set PDF document Viewer mode
                this.pdfDocumentViewer1.SetViewerMode(viewerMode);
            }

        }

        private void pdfDocumentViewer1_PageNumberChanged(object sender, EventArgs args)
        {
            this.lblPageNo.Content = this.pdfDocumentViewer1.CurrentPageNumber.ToString();
        }



    }
}
