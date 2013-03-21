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
            //Open a doc document          
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "Doc document(*.doc;*.docx)|*.doc;*.docx|All files(*.*)|*.*",
                Title = "Open doc Document",
                Multiselect = false,
                InitialDirectory = System.IO.Path.GetFullPath(@"..\..\..\..\..\..\Data")
            };
            bool? result = dialog.ShowDialog();
            if (result.Value)
            {
                try
                {
                    this.docDocumentViewer1.LoadFromFile(dialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            docDocumentViewer1.CloseDocument();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // Load pdf document from file.
                this.docDocumentViewer1.LoadFromFile(@"..\..\..\..\..\..\Data\fax.doc");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnSaveToPdf_Click(object sender, RoutedEventArgs e)
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
                    this.docDocumentViewer1.SaveAs(savefile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnSaveToDoc97_2k3_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog()
            {
                Filter = "Word97-2003 Document(*.doc)|*.doc",
                Title = "Save"
            };
            bool? result = savefile.ShowDialog();
            if (result.Value)
            {
                try
                {
                    //Save as Word97-2003 documetns
                    this.docDocumentViewer1.SaveAs(savefile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnSaveToDoc2007_2010_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog()
            {
                Filter = "Word2007-2010 Document(*.docx)|*.docx",
                Title = "Save"
            };
            bool? result = savefile.ShowDialog();
            if (result.Value)
            {
                try
                {
                    //Save as Word2007-2010 documetns
                    this.docDocumentViewer1.SaveAs(savefile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
