namespace PdfViewer_Open
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
            this.BtnOpen = new System.Windows.Forms.ToolStripButton();
            this.BtnOpenStream = new System.Windows.Forms.ToolStripButton();
            this.BtnOpenPass = new System.Windows.Forms.ToolStripButton();
            this.comBoxPages = new System.Windows.Forms.ToolStripComboBox();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.pdfDocumentViewer1 = new Spire.PdfViewer.Forms.PdfDocumentViewer();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnOpen,
            this.BtnOpenStream,
            this.BtnOpenPass,
            this.comBoxPages,
            this.btnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnOpen
            // 
            this.BtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("BtnOpen.Image")));
            this.BtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(23, 22);
            this.BtnOpen.Text = "Open";
            this.BtnOpen.ToolTipText = "Open PDF document ";
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BtnOpenStream
            // 
            this.BtnOpenStream.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnOpenStream.Image = ((System.Drawing.Image)(resources.GetObject("BtnOpenStream.Image")));
            this.BtnOpenStream.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnOpenStream.Name = "BtnOpenStream";
            this.BtnOpenStream.Size = new System.Drawing.Size(23, 22);
            this.BtnOpenStream.Text = "Open Stream";
            this.BtnOpenStream.ToolTipText = "Open PDF document data streaam";
            this.BtnOpenStream.Click += new System.EventHandler(this.BtnOpenStream_Click);
            // 
            // BtnOpenPass
            // 
            this.BtnOpenPass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnOpenPass.Image = ((System.Drawing.Image)(resources.GetObject("BtnOpenPass.Image")));
            this.BtnOpenPass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnOpenPass.Name = "BtnOpenPass";
            this.BtnOpenPass.Size = new System.Drawing.Size(23, 22);
            this.BtnOpenPass.Text = "Open Encryption";
            this.BtnOpenPass.ToolTipText = "Open encrypted PDF document";
            this.BtnOpenPass.Click += new System.EventHandler(this.BtnOpenPass_Click);
            // 
            // comBoxPages
            // 
            this.comBoxPages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxPages.Name = "comBoxPages";
            this.comBoxPages.Size = new System.Drawing.Size(121, 25);
            this.comBoxPages.SelectedIndexChanged += new System.EventHandler(this.comBoxPages_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 22);
            this.btnClose.Text = "Close";
            this.btnClose.ToolTipText = "Close PDF document";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // pdfDocumentViewer1
            // 
            this.pdfDocumentViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pdfDocumentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfDocumentViewer1.Location = new System.Drawing.Point(0, 25);
            this.pdfDocumentViewer1.Name = "pdfDocumentViewer1";
            this.pdfDocumentViewer1.Size = new System.Drawing.Size(784, 537);
            this.pdfDocumentViewer1.TabIndex = 1;
            this.pdfDocumentViewer1.Text = "pdfDocumentViewer1";
            this.pdfDocumentViewer1.ZoomMode = Spire.PdfViewer.Forms.ZoomMode.Default;
            this.pdfDocumentViewer1.PageNumberChanged += new Spire.PdfViewer.PageNumberChangedEventHandler(this.pdfDocumentViewer1_PageNumberChanged);
            this.pdfDocumentViewer1.PdfLoaded += new Spire.PdfViewer.DocumentOpenedEventHandler(this.pdfDocumentViewer1_PdfLoaded);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pdfDocumentViewer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Spire.PdfViewer Demo - Open";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnOpen;
        private System.Windows.Forms.ToolStripButton BtnOpenStream;
        private System.Windows.Forms.ToolStripButton BtnOpenPass;
        private Spire.PdfViewer.Forms.PdfDocumentViewer pdfDocumentViewer1;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripComboBox comBoxPages;
    }
}

