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


namespace ExtendFunction
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


        //Load default PDF document when window loaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string pdfFileName = @"..\..\..\..\..\..\Data\PDFViewer.pdf";
            if (File.Exists(pdfFileName))
            {
                this.pdfDocumentViewer1.LoadFromFile(pdfFileName);
            }

        }
        //Open PDF document
        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PDF document(*.pdf)|*.pdf";
            bool? dialogResult = dialog.ShowDialog();
            if (dialogResult.HasValue && dialogResult.Value)
            {
                string pdfFileName = dialog.FileName;
                //load PDF document
                this.pdfDocumentViewer1.LoadFromFile(pdfFileName);
            }

        }

        //Get PDF document basic informations.
        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            if (this.pdfDocumentViewer1.IsDocumentLoaded)
            {
                string info = "";
                info += "File name: " + this.pdfDocumentViewer1.FileName + "\n";
                PdfDocumentInfo docInfo = this.pdfDocumentViewer1.GetDocumentInfomation();
                info += "Author: " + docInfo.Author + "\n";
                info += "Creator: " + docInfo.Creator + "\n";
                info += "Producer: " + docInfo.Producer + "\n";
                info += "Title: " + docInfo.Title + "\n";
                info += "Subject: " + docInfo.Subject + "\n";
                info += "Keywords: " + docInfo.Keywords + "\n";
                info += "Creation date: " + docInfo.CreationDate.ToString() + "\n";
                info += "Modifaction date: " + docInfo.ModificationDate.ToString() + "\n";
                MessageBox.Show(info, "Document information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnLink_Click(object sender, RoutedEventArgs e)
        {
            this.LoadPDFFromWebPage();

        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            Key key = e.Key;
            if (key == Key.Enter)
            {
                this.LoadPDFFromWebPage();

            }
        }
        //Convert webpage to PDF document then load with PdfDocumentViewer component.
        private void LoadPDFFromWebPage()
        {
            string url = this.txtUrl.Text.Trim();
            string convertPdfFileName = System.IO.Path.GetFileName(url);
            if (String.IsNullOrEmpty(convertPdfFileName))
                convertPdfFileName = "default.pdf";
            else
            {
                convertPdfFileName = convertPdfFileName.Substring(0, convertPdfFileName.LastIndexOf("."));
                convertPdfFileName += ".pdf";
            }
            try
            {
                this.pdfDocumentViewer1.LoadFromHtml(url, convertPdfFileName);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }


      

      
    }
}
