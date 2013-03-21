using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.IO;
using System.Windows.Forms;
using Spire.PdfViewer.Forms;


namespace Attachment
{
    public partial class Form1 : Form
    {
        private bool m_isAttachmentAnnotation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listView1.Visible = false;
            this.tableLayoutPanel1.SetRowSpan(this.pdfDocumentViewer1, 2);
            if (File.Exists(@"..\..\..\..\..\..\Data\Attachment.pdf"))
            {
                this.pdfDocumentViewer1.LoadFromFile(@"..\..\..\..\..\..\Data\Attachment.pdf");
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
            dialog.Filter = "PDF document(*.pdf)|*.pdf";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string pdfFile = dialog.FileName;
                this.pdfDocumentViewer1.LoadFromFile(pdfFile);
            }
        }
        /// <summary>
        /// Read PDF document common attachments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAttachment_Click(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.SetRowSpan(this.pdfDocumentViewer1, 1);
            this.m_isAttachmentAnnotation = false;
            this.listView1.Visible = true;
            this.listView1.Columns.Clear();
            this.listView1.Items.Clear();
            if (this.pdfDocumentViewer1.IsDocumentLoaded)
            {
                //Get common attachment in PDF document
                PdfDocumentAttachment[] attchments = this.pdfDocumentViewer1.GetAttachments();
                this.listView1.View = View.Details;
                this.listView1.Columns.Add("FileName",80);
                this.listView1.Columns.Add("MimeType",80);
                this.listView1.Columns.Add("Description",120);
                this.listView1.Columns.Add("CreationTime",100);
                this.listView1.Columns.Add("ModifyTime",100);
                if (attchments != null && attchments.Length > 0)
                {
                    //get common attachment property
                    for (int i = 0; i < attchments.Length; i++)
                    {
                        PdfDocumentAttachment attachment = attchments[i];
                        string fileName = attachment.FileName;
                        string mimeType = attachment.MimeType;
                        string desc = attachment.Description;
                        DateTime createDate = attachment.CreationTime;
                        DateTime modifyDate = attachment.ModifyTime;
                        Object data = attachment.Data;
                        ListViewItem item = new ListViewItem();
                        item.Text = Path.GetFileName(fileName);
                        item.SubItems.Add(mimeType);
                        item.SubItems.Add(desc);
                        item.SubItems.Add(createDate.ToShortDateString());
                        item.SubItems.Add(modifyDate.ToShortDateString());
                        item.Tag = attachment;
                        this.listView1.Items.Add(item);
                    }
                }
            }
        }
        /// <summary>
        /// Read PDF document attachment annotation 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAttachmentAnnotation_Click(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.SetRowSpan(this.pdfDocumentViewer1, 1);
            this.m_isAttachmentAnnotation = true;
            this.listView1.Visible = true;
            this.listView1.Items.Clear();
            this.listView1.Columns.Clear();
            if (this.pdfDocumentViewer1.IsDocumentLoaded && this.pdfDocumentViewer1.PageCount > 0)
            {
                this.listView1.View = View.Details;
                this.listView1.Columns.Add("FileName",200);
                this.listView1.Columns.Add("Text",180);
                this.listView1.Columns.Add("PageIndex",80);
                this.listView1.Columns.Add("Location",160);
                //Get attachment annotations in PDF document
                PdfDocumentAttachmentAnnotation[] annotations = this.pdfDocumentViewer1.GetAttachmentAnnotaions();
                if (annotations != null && annotations.Length > 0)
                {
                    //read attachment annotation property
                    for (int i = 0; i < annotations.Length; i++)
                    {
                        PdfDocumentAttachmentAnnotation annotation = annotations[i];
                        ListViewItem item = new ListViewItem(annotation.FileName);
                        item.SubItems.Add(annotation.Text);
                        item.SubItems.Add(annotation.PageIndex.ToString());
                        item.SubItems.Add(annotation.Location.ToString());
                        item.Tag = annotation;
                        this.listView1.Items.Add(item);
                    }
                }

            }
        }
        /// <summary>
        /// Go to Specified attachment annotation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_Click(object sender, EventArgs e)
        {
            if (this.m_isAttachmentAnnotation)
            {
                PdfDocumentAttachmentAnnotation annotation = (PdfDocumentAttachmentAnnotation)this.listView1.SelectedItems[0].Tag;
                this.pdfDocumentViewer1.GotoAttachmentAnnotation(annotation);
            }
        }
        /// <summary>
        /// Export PDF document attachment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = this.listView1.SelectedItems[0];
            SaveFileDialog dialog = new SaveFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                FileStream stream = new FileStream(fileName, FileMode.Create);
                BinaryWriter writer = new BinaryWriter(stream);
                if (this.m_isAttachmentAnnotation)
                {
                    PdfDocumentAttachmentAnnotation annotation = (PdfDocumentAttachmentAnnotation)item.Tag;
                    byte[] data = annotation.Data;
                    writer.Write(data);
                }
                else
                {
                    PdfDocumentAttachment annotation = (PdfDocumentAttachment)item.Tag;
                    byte[] data = annotation.Data;
                    writer.Write(data);
                }

                writer.Close();
                stream.Close();
                System.Diagnostics.Process.Start(fileName);
               
            }
        }

        private void BtnCloseAttachment_Click(object sender, EventArgs e)
        {
            this.listView1.Visible = false;
            this.tableLayoutPanel1.SetRowSpan(this.pdfDocumentViewer1, 2);
        }


    }
}
