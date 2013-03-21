using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.IO;
using System.Text;
using System.Windows.Forms;
using Spire.PdfViewer.Forms;

namespace Bookmark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"..\..\..\..\..\..\Data\BigBookmark.pdf"))
            {
                this.pdfDocumentViewer1.LoadFromFile(@"..\..\..\..\..\..\Data\BigBookmark.pdf");
            }

        }

        /// <summary>
        /// Open PDF document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string pdfDocument = dialog.FileName;
                this.pdfDocumentViewer1.LoadFromFile(pdfDocument);
            }

        }

        private void pdfDocumentViewer1_PdfLoaded(object sender, EventArgs args)
        {
            this.LoadBookmarks();

        }

        /// <summary>
        /// Load PDF document bookmark
        /// </summary>
        private void LoadBookmarks()
        {
            if (this.pdfDocumentViewer1.IsDocumentLoaded)
            {
                PdfDocumentBookmarkContainer container = this.pdfDocumentViewer1.GetBookmarkContainer();
                if (container == null)
                {
                    MessageBox.Show("Current PDF document has not bookmarks");
                    return;
                }
                this.treeViewBookmark.Nodes.Clear();
                PdfDocumentBookmark[] bookmarks = container.Childs;
                for (int i = 0; i < bookmarks.Length; i++)
                {
                    PdfDocumentBookmark bookmark = bookmarks[i];

                    TreeNode node = new TreeNode();
                    string title = bookmark.Title;
                    node.Text = title;
                    node.ForeColor = bookmark.Color;
                    FontStyle style = (FontStyle)bookmark.Style;
                    Font font = this.treeViewBookmark.Font;
                    node.NodeFont = new Font(font, style);
                    node.Tag = bookmark;
                    this.treeViewBookmark.Nodes.Add(node);
                    this.LoadChidNode(node);

                }

            }
        }
        /// <summary>
        /// Load specified bookmark children bookmark
        /// </summary>
        /// <param name="node"></param>
        private void LoadChidNode(TreeNode node)
        {
            PdfDocumentBookmark bookmark = node.Tag as PdfDocumentBookmark;
            int childCount = bookmark.Children.Count;
            if (childCount > 0)
            {
                for (int i = 0; i < childCount; i++)
                {
                    PdfDocumentBookmark childBookmark = bookmark.Children[i];
                    TreeNode childNode = new TreeNode();
                    childNode.Text = childBookmark.Title;
                    childNode.ForeColor = childBookmark.Color;
                    FontStyle style = (FontStyle)bookmark.Style;
                    Font font = this.treeViewBookmark.Font;
                    childNode.NodeFont = new Font(font, style);
                    childNode.Tag = childBookmark;
                    node.Nodes.Add(childNode);
                    LoadChidNode(childNode);
                }

            }
        }
        /// <summary>
        /// Go to PDF document bookmark
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeViewBookmark_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            PdfDocumentBookmark bookmark = (PdfDocumentBookmark)(node.Tag);
            this.pdfDocumentViewer1.GoToBookmark(bookmark);

        }
        /// <summary>
        /// Zoom PDF document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZoom_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.IsDocumentLoaded)
            {
                int zoomPercent=0;
                bool isNummeric = int.TryParse(this.txtZoomPercent.Text, out zoomPercent);
                if (isNummeric)
                {
                    this.pdfDocumentViewer1.ZoomTo(Math.Abs(zoomPercent));
                }
                    
            }

        }

  
    }
}
