﻿using System;
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

namespace Print
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
            //Open a pdf document.
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
            //Close current pdf document.
            pdfDocumentViewer1.CloseDocument();
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            //Show a Print Dialog
            PrintDialog dialog = new PrintDialog();
            dialog.MaxPage = this.pdfDocumentViewer1.PageCount > 0 ? (uint)this.pdfDocumentViewer1.PageCount : 1;
            dialog.MinPage = 1;
            dialog.UserPageRangeEnabled = true;
            bool? result = dialog.ShowDialog();
            if (result.Value)
            {
                try
                {
                    //Set print parnameters.
                    this.pdfDocumentViewer1.PrintDialog = dialog;
                    //Gets the PrintDocument.
                    dialog.PrintDocument(pdfDocumentViewer1.PrintDocument.DocumentPaginator, "Print Document");
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
                this.pdfDocumentViewer1.LoadFromFile(@"..\..\..\..\..\..\Data\PartList.pdf");               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
