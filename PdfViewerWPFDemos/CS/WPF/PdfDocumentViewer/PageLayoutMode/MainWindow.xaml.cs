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



namespace PageLayoutMode
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
            string pdfFileName = @"..\..\..\..\..\..\Data\Le_Petit_Prince_French.pdf";
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
                this.pdfDocumentViewer1.LoadFromFile(pdfFileName);
            }
        }

        //Swith PDF document page layout mode
        private void CboLayoutMode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.pdfDocumentViewer1 != null && this.pdfDocumentViewer1.IsDocumentLoaded && this.CboLayoutMode.SelectedIndex != -1)
            {
                Spire.PdfViewer.Wpf.PageLayoutMode layoutMode = (Spire.PdfViewer.Wpf.PageLayoutMode)this.CboLayoutMode.SelectedIndex;
                this.pdfDocumentViewer1.SetPageLayoutMode(layoutMode);              
            }

        }

    }
}
