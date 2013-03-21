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
using Spire.PdfViewer.Wpf.PdfThumbnails;

namespace PdfDocumentThumbnail
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string pdfFileName = @"..\..\..\..\..\..\Data\Italin.pdf";
            if (File.Exists(pdfFileName))
            {
                this.pdfDocumentViewer1.LoadFromFile(pdfFileName);
            }

        }

        private void btnThumnail_Click(object sender, RoutedEventArgs e)
        {
            // PdfDocumentThumnail control Asscoiate with PdfDocumentViewer control
            this.pdfDocumentThumbnail1.Viewer = this.pdfDocumentViewer1;

        }


        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "PDF document(*.pdf)|*.pdf";
            bool? result = dlg.ShowDialog();
            if (result.HasValue && result.Value)
            {
                string pdfFileName = dlg.FileName;
                this.pdfDocumentViewer1.LoadFromFile(pdfFileName);
            }            
        }



    }
}
