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

namespace PdfViewer_Open
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
                    //Load pdf document from file.
                    this.pdfViewer1.LoadFromFile(dialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnOpenSteam_Click(object sender, RoutedEventArgs e)
        {
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
                    string pdfFile = dialog.FileName;
                    stream = new System.IO.FileStream(pdfFile, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
                    if (stream != null)
                    {
                        //Load pdf document from stream.
                        this.pdfViewer1.LoadFromStream(stream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnEncrypte_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "Pdf document(*.Pdf)|*.pdf",
                Title = "Open Pdf Document",
                Multiselect = false,
                InitialDirectory =System.IO.Path.GetFullPath(@"..\..\..\..\..\..\Data")
            };
            bool? result = dialog.ShowDialog();
            string pdfFile = dialog.FileName;
            if (result.Value)
            {
                try
                {
                    //Load pdf document from file.
                    this.pdfViewer1.LoadFromFile(pdfFile);
                }
                catch (Exception ex)
                {
                    while (true)
                    {
                        string passError = " password is invalid";
                        string message = ex.Message;
                        if (message.IndexOf(passError) > -1)
                        {
                            string info = pdfFile + " has password! \n\r You need input it's password!";
                            PasswordDlg passwordDialog = new PasswordDlg();

                            bool? dlgResult = passwordDialog.ShowDialog();
                            if (!dlgResult.Value)
                            {
                                break;
                            }
                            string password = passwordDialog.getPass();
                            if (!String.IsNullOrEmpty(password))
                            {
                                passwordDialog.Close();
                                try
                                {
                                    //Open encryption pdf document from file.
                                    this.pdfViewer1.LoadFromFile(pdfFile, password);
                                    break;
                                }
                                catch (Exception ex1)
                                {

                                }
                            }
                        }
                    }
                }

            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            //Close current pdf document.
            pdfViewer1.CloseDocument();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // Load pdf document from file.
                this.pdfViewer1.LoadFromFile(@"..\..\..\..\..\..\Data\Sample2.pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }     
    }
}
