namespace Save
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bntOpen = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveToPdf = new System.Windows.Forms.ToolStripButton();
            this.btnSaveasToDoc = new System.Windows.Forms.ToolStripButton();
            this.btnSaveasToDocx = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.docDocumentViewer1 = new Spire.DocViewer.Forms.DocDocumentViewer();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bntOpen,
            this.btnClose,
            this.toolStripSeparator1,
            this.btnSaveToPdf,
            this.btnSaveasToDoc,
            this.btnSaveasToDocx,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(792, 39);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bntOpen
            // 
            this.bntOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bntOpen.Image = global::Save.Properties.Resources.Open;
            this.bntOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bntOpen.Name = "bntOpen";
            this.bntOpen.Size = new System.Drawing.Size(36, 36);
            this.bntOpen.Text = "toolStripButton1";
            this.bntOpen.ToolTipText = "Open from File";
            this.bntOpen.Click += new System.EventHandler(this.bntOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClose.Image = global::Save.Properties.Resources.Close;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 36);
            this.btnClose.Text = "toolStripButton2";
            this.btnClose.ToolTipText = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnSaveToPdf
            // 
            this.btnSaveToPdf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveToPdf.Image = global::Save.Properties.Resources.ToPdf;
            this.btnSaveToPdf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveToPdf.Name = "btnSaveToPdf";
            this.btnSaveToPdf.Size = new System.Drawing.Size(36, 36);
            this.btnSaveToPdf.Text = "toolStripButton3";
            this.btnSaveToPdf.ToolTipText = "Convert Doc document to Pdf document";
            this.btnSaveToPdf.Click += new System.EventHandler(this.btnSaveToPdf_Click);
            // 
            // btnSaveasToDoc
            // 
            this.btnSaveasToDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveasToDoc.Image = global::Save.Properties.Resources.ToDoc;
            this.btnSaveasToDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveasToDoc.Name = "btnSaveasToDoc";
            this.btnSaveasToDoc.Size = new System.Drawing.Size(36, 36);
            this.btnSaveasToDoc.Text = "toolStripButton4";
            this.btnSaveasToDoc.ToolTipText = "Save as Word97-2003 format document";
            this.btnSaveasToDoc.Click += new System.EventHandler(this.btnSaveasToDoc_Click);
            // 
            // btnSaveasToDocx
            // 
            this.btnSaveasToDocx.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveasToDocx.Image = global::Save.Properties.Resources.ToDocx;
            this.btnSaveasToDocx.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveasToDocx.Name = "btnSaveasToDocx";
            this.btnSaveasToDocx.Size = new System.Drawing.Size(36, 36);
            this.btnSaveasToDocx.Text = "toolStripButton5";
            this.btnSaveasToDocx.ToolTipText = "Save as Word2007-2010 format document";
            this.btnSaveasToDocx.Click += new System.EventHandler(this.btnSaveasToDocx_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // docDocumentViewer1
            // 
            this.docDocumentViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.docDocumentViewer1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.docDocumentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docDocumentViewer1.EnableHandTools = false;
            this.docDocumentViewer1.Location = new System.Drawing.Point(0, 39);
            this.docDocumentViewer1.Name = "docDocumentViewer1";
            this.docDocumentViewer1.Size = new System.Drawing.Size(792, 534);
            this.docDocumentViewer1.TabIndex = 1;
            this.docDocumentViewer1.Text = "docDocumentViewer1";
            this.docDocumentViewer1.ZoomMode = Spire.DocViewer.Forms.ZoomMode.Default;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.docDocumentViewer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spire.DocViewer for .NET - Demo – Save PDF via DocDocumentViewer Component.";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bntOpen;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSaveToPdf;
        private System.Windows.Forms.ToolStripButton btnSaveasToDoc;
        private System.Windows.Forms.ToolStripButton btnSaveasToDocx;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private Spire.DocViewer.Forms.DocDocumentViewer docDocumentViewer1;
    }
}

