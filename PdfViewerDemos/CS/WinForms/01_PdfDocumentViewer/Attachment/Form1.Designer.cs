namespace Attachment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnAttachment = new System.Windows.Forms.ToolStripButton();
            this.btnAttachmentAnnotation = new System.Windows.Forms.ToolStripButton();
            this.BtnCloseAttachment = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pdfDocumentViewer1 = new Spire.PdfViewer.Forms.PdfDocumentViewer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnAttachment,
            this.btnAttachmentAnnotation,
            this.BtnCloseAttachment});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(742, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(23, 22);
            this.btnOpen.Text = "Open";
            this.btnOpen.ToolTipText = "Open PDF document";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnAttachment
            // 
            this.btnAttachment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAttachment.Image = ((System.Drawing.Image)(resources.GetObject("btnAttachment.Image")));
            this.btnAttachment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAttachment.Name = "btnAttachment";
            this.btnAttachment.Size = new System.Drawing.Size(23, 22);
            this.btnAttachment.Text = "CommonAttachment";
            this.btnAttachment.ToolTipText = "Common attachment";
            this.btnAttachment.Click += new System.EventHandler(this.btnAttachment_Click);
            // 
            // btnAttachmentAnnotation
            // 
            this.btnAttachmentAnnotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAttachmentAnnotation.Image = ((System.Drawing.Image)(resources.GetObject("btnAttachmentAnnotation.Image")));
            this.btnAttachmentAnnotation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAttachmentAnnotation.Name = "btnAttachmentAnnotation";
            this.btnAttachmentAnnotation.Size = new System.Drawing.Size(23, 22);
            this.btnAttachmentAnnotation.Text = "AttachmentAnnotation";
            this.btnAttachmentAnnotation.ToolTipText = "Attachment annotation";
            this.btnAttachmentAnnotation.Click += new System.EventHandler(this.btnAttachmentAnnotation_Click);
            // 
            // BtnCloseAttachment
            // 
            this.BtnCloseAttachment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnCloseAttachment.Image = ((System.Drawing.Image)(resources.GetObject("BtnCloseAttachment.Image")));
            this.BtnCloseAttachment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCloseAttachment.Name = "BtnCloseAttachment";
            this.BtnCloseAttachment.Size = new System.Drawing.Size(23, 22);
            this.BtnCloseAttachment.Text = "Closeattachment";
            this.BtnCloseAttachment.ToolTipText = "Close attachment";
            this.BtnCloseAttachment.Click += new System.EventHandler(this.BtnCloseAttachment_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pdfDocumentViewer1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(742, 491);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pdfDocumentViewer1
            // 
            this.pdfDocumentViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pdfDocumentViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pdfDocumentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.pdfDocumentViewer1.IsClickJump = false;
            this.pdfDocumentViewer1.Location = new System.Drawing.Point(3, 3);
            this.pdfDocumentViewer1.Name = "pdfDocumentViewer1";
            this.pdfDocumentViewer1.Size = new System.Drawing.Size(736, 386);
            this.pdfDocumentViewer1.TabIndex = 0;
            this.pdfDocumentViewer1.Text = "pdfDocumentViewer1";
            this.pdfDocumentViewer1.Threshold = 60;
            this.pdfDocumentViewer1.ZoomMode = Spire.PdfViewer.Forms.ZoomMode.Default;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 395);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(736, 93);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 516);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Spire.PdfViewer(for WinForms) Demo - Attachment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnAttachment;
        private System.Windows.Forms.ToolStripButton btnAttachmentAnnotation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Spire.PdfViewer.Forms.PdfDocumentViewer pdfDocumentViewer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripButton BtnCloseAttachment;
    }
}

