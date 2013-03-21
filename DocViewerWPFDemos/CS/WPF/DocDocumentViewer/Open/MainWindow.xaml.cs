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


namespace PdfDocumentViewer_Open
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.IO.FileStream stream;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            //open a pdf document
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "Word document(*.doc,*.docx)|*.doc;*.docx",
                Title = "Open Pdf Document",
                Multiselect = false,
                InitialDirectory =System.IO.Path.GetFullPath(@"..\..\..\..\..\..\Data")
            };
            bool? result = dialog.ShowDialog();
            if (result.Value)
            {
                try
                {
                    //Load pdf document from file.
                    this.docDocumentViewer1.LoadFromFile(dialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnOpenSteam_Click(object sender, RoutedEventArgs e)
        {
            //open a doc document
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "Word document(*.doc,*.docx)|*.doc;*.docx",
                Title = "Open Doc Document",
                Multiselect = false,
                InitialDirectory =System.IO.Path.GetFullPath(@"..\..\..\..\..\..\Data")
            };
            bool? result = dialog.ShowDialog();
            if (result.Value)
            {
                try
                {
                    string pdfFile = dialog.FileName;
                    stream = new System.IO.FileStream(pdfFile, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
                    if (stream != null)
                    {
                        //Load doc document from stream.
                        this.docDocumentViewer1.LoadFromStream(stream,Spire.Doc.FileFormat.Auto);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
     

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            //Close current doc document.
            docDocumentViewer1.CloseDocument();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // Load doc document from file.
                this.docDocumentViewer1.LoadFromFile(@"..\..\..\..\..\..\Data\Summary_of_Science.docx");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
