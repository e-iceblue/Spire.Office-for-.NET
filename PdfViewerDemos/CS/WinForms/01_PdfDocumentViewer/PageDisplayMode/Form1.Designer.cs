namespace PageDisplayMode
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSingleContinuous = new System.Windows.Forms.ToolStripButton();
            this.btnSingleDiscontinuous = new System.Windows.Forms.ToolStripButton();
            this.btnDoubleContinuous = new System.Windows.Forms.ToolStripButton();
            this.btnDoubleDiscontinuous = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblPage = new System.Windows.Forms.ToolStripLabel();
            this.pdfDocumentViewer1 = new Spire.PdfViewer.Forms.PdfDocumentViewer();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.toolStripSeparator1,
            this.btnSingleContinuous,
            this.btnSingleDiscontinuous,
            this.btnDoubleContinuous,
            this.btnDoubleDiscontinuous,
            this.toolStripSeparator2,
            this.lblPage});
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSingleContinuous
            // 
            this.btnSingleContinuous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSingleContinuous.Image = ((System.Drawing.Image)(resources.GetObject("btnSingleContinuous.Image")));
            this.btnSingleContinuous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSingleContinuous.Name = "btnSingleContinuous";
            this.btnSingleContinuous.Size = new System.Drawing.Size(23, 22);
            this.btnSingleContinuous.Text = "SingleContinuous";
            this.btnSingleContinuous.ToolTipText = "Single continuous page mode";
            this.btnSingleContinuous.Click += new System.EventHandler(this.btnSingleContinuous_Click);
            // 
            // btnSingleDiscontinuous
            // 
            this.btnSingleDiscontinuous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSingleDiscontinuous.Image = ((System.Drawing.Image)(resources.GetObject("btnSingleDiscontinuous.Image")));
            this.btnSingleDiscontinuous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSingleDiscontinuous.Name = "btnSingleDiscontinuous";
            this.btnSingleDiscontinuous.Size = new System.Drawing.Size(23, 22);
            this.btnSingleDiscontinuous.Text = "SingleDiscontinuous";
            this.btnSingleDiscontinuous.ToolTipText = "Single discontinuous page mode";
            this.btnSingleDiscontinuous.Click += new System.EventHandler(this.btnSingleDiscontinuous_Click);
            // 
            // btnDoubleContinuous
            // 
            this.btnDoubleContinuous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDoubleContinuous.Image = ((System.Drawing.Image)(resources.GetObject("btnDoubleContinuous.Image")));
            this.btnDoubleContinuous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDoubleContinuous.Name = "btnDoubleContinuous";
            this.btnDoubleContinuous.Size = new System.Drawing.Size(23, 22);
            this.btnDoubleContinuous.Text = "DoubleContinuous";
            this.btnDoubleContinuous.ToolTipText = "Double continuous  page mode";
            this.btnDoubleContinuous.Click += new System.EventHandler(this.btnDoubleContinuous_Click);
            // 
            // btnDoubleDiscontinuous
            // 
            this.btnDoubleDiscontinuous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDoubleDiscontinuous.Image = ((System.Drawing.Image)(resources.GetObject("btnDoubleDiscontinuous.Image")));
            this.btnDoubleDiscontinuous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDoubleDiscontinuous.Name = "btnDoubleDiscontinuous";
            this.btnDoubleDiscontinuous.Size = new System.Drawing.Size(23, 22);
            this.btnDoubleDiscontinuous.Text = "DoubleDiscontinuous";
            this.btnDoubleDiscontinuous.Click += new System.EventHandler(this.btnDoubleDiscontinuous_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lblPage
            // 
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(11, 22);
            this.lblPage.Text = "0";
            // 
            // pdfDocumentViewer1
            // 
            this.pdfDocumentViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pdfDocumentViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pdfDocumentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfDocumentViewer1.Location = new System.Drawing.Point(0, 25);
            this.pdfDocumentViewer1.Name = "pdfDocumentViewer1";
            this.pdfDocumentViewer1.Size = new System.Drawing.Size(742, 491);
            this.pdfDocumentViewer1.TabIndex = 1;
            this.pdfDocumentViewer1.Text = "pdfDocumentViewer1";
            this.pdfDocumentViewer1.Threshold = 60;
            this.pdfDocumentViewer1.ZoomMode = Spire.PdfViewer.Forms.ZoomMode.Default;
            this.pdfDocumentViewer1.PageNumberChanged += new Spire.PdfViewer.PageNumberChangedEventHandler(this.pdfDocumentViewer1_PageNumberChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 516);
            this.Controls.Add(this.pdfDocumentViewer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Spire.PdfViewer(for WinForms) Demo _ Page Display Mode";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSingleContinuous;
        private System.Windows.Forms.ToolStripButton btnSingleDiscontinuous;
        private System.Windows.Forms.ToolStripButton btnDoubleContinuous;
        private System.Windows.Forms.ToolStripButton btnDoubleDiscontinuous;
        private Spire.PdfViewer.Forms.PdfDocumentViewer pdfDocumentViewer1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lblPage;
    }
}

