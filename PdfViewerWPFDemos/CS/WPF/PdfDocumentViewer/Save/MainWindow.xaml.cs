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
using Spire.PdfViewer.Wpf;
using Spire.PdfViewer;

namespace Save
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

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            //Open a pdf document          
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "Pdf document(*.Pdf)|*.pdf",
                Title = "Open Pdf Document",
                Multiselect = false,
                InitialDirectory =System.IO.Path.GetFullPath(@"..\..\..\..\..\..\Data")
            };
            bool? result = dialog.ShowDialog();
            if (result.Value)
            {
                try
                {
                    this.pdfDocumentViewer1.LoadFromFile(dialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            pdfDocumentViewer1.CloseDocument();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog()
            {
                Filter = "Pdf Document(*.Pdf)|*.Pdf",
                Title = "Save"
            };
            bool? result = savefile.ShowDialog();
            if (result.Value)
            {
                try
                {
                    //Save PDF documetns
                    pdfDocumentViewer1.SaveToFile(savefile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }

        private void btnSaveStream_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog()
            {
                Filter = "Pdf Document(*.Pdf)|*.Pdf",
                Title = "Save"
            };
            bool? result = savefile.ShowDialog();
            if (result.Value)
            {
                try
                {
                    System.IO.MemoryStream stream = new System.IO.MemoryStream();
                    //Pdf document to save the file stream.
                    pdfDocumentViewer1.SaveToFile(stream);
                    stream.Position = 0;
                    byte[] fileBytes = stream.ToArray();
                    stream.Close();
                    System.IO.FileStream fileStream = new System.IO.FileStream(savefile.FileName, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite);
                    fileStream.Write(fileBytes, 0, fileBytes.Length);
                    fileStream.Flush();
                    fileStream.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // Load pdf document from file.
                this.pdfDocumentViewer1.LoadFromFile(@"..\..\..\..\..\..\Data\Spire.Office.pdf");               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
