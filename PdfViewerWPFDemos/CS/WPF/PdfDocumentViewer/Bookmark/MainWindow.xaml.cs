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

namespace Bookmark
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
            string pdfFileName = @"..\..\..\..\..\..\Data\bookmark.pdf";
            if (File.Exists(pdfFileName))
            {
                this.pdfDocumentViewer1.LoadFromFile(pdfFileName);
            }

        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PDF document(*.pdf)|*.pdf";
            bool? dlgResult = dialog.ShowDialog();
            if (dlgResult.HasValue && dlgResult.Value)
            {
                string pdfFileName = dialog.FileName;
                this.pdfDocumentViewer1.LoadFromFile(pdfFileName);
            }
            

        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeViewItem node = (TreeViewItem)e.NewValue;
            if (node == null)
                return;
            PdfDocumentBookmark bookmark = node.Tag as PdfDocumentBookmark;
            if (this.pdfDocumentViewer1.IsDocumentLoaded)
            {
                this.pdfDocumentViewer1.GoToBookmark(bookmark);
            }
        }

        private void pdfDocumentViewer1_PdfLoaded(object sender, EventArgs args)
        {
            if (this.pdfDocumentViewer1.IsDocumentLoaded)
            {
                PdfDocumentBookmarkContainer container = this.pdfDocumentViewer1.GetBookmarkContainer();
                if (container == null)
                {
                    MessageBox.Show("Current PDF document has not bookmarks");
                    return;
                }
                this.treeView1.Items.Clear();
                PdfDocumentBookmark[] bookmarks = container.Childs;
                if (bookmarks.Length > 0)
                {
                    for (int i = 0; i < bookmarks.Length; i++)
                    {
                        PdfDocumentBookmark bookmark = bookmarks[i];
                        TreeViewItem node = new TreeViewItem();
                        node.Header = bookmark.Title;
                        Color fontColor = bookmark.Color;
                        node.Foreground = new SolidColorBrush(fontColor);
                        node.Tag = bookmark;
                        this.LoadChidNode(node);
                        this.treeView1.Items.Add(node);


                    }
                }

            }
        }

        private void LoadChidNode(TreeViewItem node)
        {
            PdfDocumentBookmark bookmark = node.Tag as PdfDocumentBookmark;
            int childCount = bookmark.Children.Count;
            if (childCount > 0)
            {
                for (int i = 0; i < childCount; i++)
                {
                    PdfDocumentBookmark childBookmark = bookmark.Children[i];
                    TreeViewItem childNode = new TreeViewItem();
                    childNode.Header = childBookmark.Title;
                    childNode.Foreground = new SolidColorBrush(childBookmark.Color);
                    childNode.Tag = childBookmark;
                    node.Items.Add(childNode);
                    this.LoadChidNode(childNode);
                }

            }


        }


    }
}
