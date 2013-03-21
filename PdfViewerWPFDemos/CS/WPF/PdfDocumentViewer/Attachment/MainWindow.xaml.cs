using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
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

namespace Attachment
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

        //Load default PDF document when Window loaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string pdfFileName = @"..\..\..\..\..\..\Data\Attachment.pdf";
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

        //Get all of attachments from loaded PDF document 
        private void btnAttachment_Click(object sender, RoutedEventArgs e)
        {
            if (this.pdfDocumentViewer1.IsDocumentLoaded)
            {
                //Get all of attachments from loaded PDF document
                PdfDocumentAttachment[] attachments = this.pdfDocumentViewer1.GetAttachments();
                if (attachments != null && attachments.Length > 0)
                {
                    //get attachment properties

                    GridView view = new GridView();
                    GridViewColumn column1 = new GridViewColumn();
                    column1.Header = "FileName";
                    Binding binding1 = new Binding("FileName");
                    column1.DisplayMemberBinding = binding1;
                    view.Columns.Add(column1);
                    GridViewColumn column2 = new GridViewColumn();
                    column2.Header = "Description";
                    Binding binding2 = new Binding("Description");
                    column2.DisplayMemberBinding = binding2;
                    GridViewColumn column3 = new GridViewColumn();
                    column3.Header = "MimeType";
                    column3.DisplayMemberBinding = new Binding("MimeType");
                    view.Columns.Add(column3);
                    GridViewColumn column4 = new GridViewColumn();
                    column4.Header = "CreationTime";
                    column4.DisplayMemberBinding = new Binding("CreationTime");
                    view.Columns.Add(column4);
                    GridViewColumn column5 = new GridViewColumn();
                    column5.Header = "ModifyTime";
                    column5.DisplayMemberBinding = new Binding("modifyTime");
                    this.listView1.View = view;
                    this.listView1.ItemsSource = attachments;
                    this.listView1.Visibility = Visibility.Visible;

                }
            }
        }

        //get all of attachment annotations from loaded PDF document
        private void btnAnnotation_Click(object sender, RoutedEventArgs e)
        {
            if (this.pdfDocumentViewer1.IsDocumentLoaded)
            {
                //get all of attachment annotations from loaded PDF document
                PdfDocumentAttachmentAnnotation[] annotations = this.pdfDocumentViewer1.GetAttachmentAnnotaions();
                if (annotations != null)
                {
                    //get attachment annotation properties
                    GridView view = new GridView();
                    GridViewColumn column1 = new GridViewColumn();
                    column1.Header = "FileName";
                    Binding binding1 = new Binding("FileName");
                    column1.DisplayMemberBinding = binding1;
                    view.Columns.Add(column1);
                    GridViewColumn column2 = new GridViewColumn();
                    column2.Header = "Text";
                    Binding binding2 = new Binding("Text");
                    column2.DisplayMemberBinding = binding2;
                    GridViewColumn column3 = new GridViewColumn();
                    column3.Header = "PageIndex";
                    column3.DisplayMemberBinding = new Binding("PageIndex");
                    view.Columns.Add(column3);
                    GridViewColumn column4 = new GridViewColumn();
                    column4.Header = "Location";
                    column4.DisplayMemberBinding = new Binding("Location");
                    view.Columns.Add(column4);
                    GridViewColumn column5 = new GridViewColumn();
                    column5.Header = "Color";
                    column5.DisplayMemberBinding = new Binding("Color");
                    this.listView1.View = view;
                    this.listView1.ItemsSource = annotations;
                    this.listView1.Visibility = Visibility.Visible;

                }
            }
        }
 
        //export attachment data to file
        private void listView1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.listView1.SelectedItem != null && this.listView1.SelectedItem is PdfDocumentAttachment)
            {
                PdfDocumentAttachment attachment = this.listView1.SelectedItem as PdfDocumentAttachment;
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "All files(*.*)|*.*";
                bool? isOk = dialog.ShowDialog();
                if (isOk.Value)
                {
                    string fileName = dialog.FileName;
                    attachment.SaveAS(fileName);
                    string info="Export attachment data to file: "+"\n"+fileName;
                    MessageBox.Show(info, "Export", MessageBoxButton.OK, MessageBoxImage.Information);
                    try
                    {
                        System.Diagnostics.Process.Start(fileName);
                    }
                    catch
                    {
                    }
                }
                return;
            }
            if (this.listView1.SelectedItem != null && this.listView1.SelectedItem is PdfDocumentAttachmentAnnotation)
            {
                PdfDocumentAttachmentAnnotation annotation = this.listView1.SelectedItem as PdfDocumentAttachmentAnnotation;
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "All files(*.*)|*.*";
                bool? isOk = dialog.ShowDialog();
                if (isOk.Value)
                {
                    string fileName = dialog.FileName;
                    annotation.SaveAs(fileName);
                    string info = "Export attachment data to file: " + "\n" + fileName;
                    MessageBox.Show(info, "Export", MessageBoxButton.OK, MessageBoxImage.Information);
                    try
                    {
                        System.Diagnostics.Process.Start(fileName);
                    }
                    catch
                    {
                    }
                }
                //can go to specify PdfDocumentAttachmentAnnotation instance  
                this.pdfDocumentViewer1.GotoAttachmentAnnotation(annotation);

            }

        }

        private void btnCloseAttachment_Click(object sender, RoutedEventArgs e)
        {
            this.listView1.Visibility = Visibility.Collapsed;
        }

    }
}
