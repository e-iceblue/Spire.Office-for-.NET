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

namespace Rotate
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
            string pdfFileName = @"..\..\..\..\..\..\Data\PDFViewer.pdf";
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

        private void btnRotate_Click(object sender, RoutedEventArgs e)
        {
            if (this.pdfDocumentViewer1.IsDocumentLoaded && this.CboRotate.SelectedIndex != -1)
            {
                RotateAngle rotateAngle = (RotateAngle)this.CboRotate.SelectedIndex;
                //Rotate PDF document
                this.pdfDocumentViewer1.Rotate(rotateAngle);

            }

        }


     
    }
}
