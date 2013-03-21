namespace ViewerMode
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
            this.btnContinuous = new System.Windows.Forms.ToolStripButton();
            this.btnSingle = new System.Windows.Forms.ToolStripButton();
            this.btnAuto = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtThreshold = new System.Windows.Forms.ToolStripTextBox();
            this.btnThreshold = new System.Windows.Forms.ToolStripButton();
            this.pdfDocumentViewer1 = new Spire.PdfViewer.Forms.PdfDocumentViewer();
            this.lblPage = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.toolStripSeparator1,
            this.btnContinuous,
            this.btnSingle,
            this.btnAuto,
            this.toolStripLabel1,
            this.txtThreshold,
            this.btnThreshold,
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
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnContinuous
            // 
            this.btnContinuous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnContinuous.Image = ((System.Drawing.Image)(resources.GetObject("btnContinuous.Image")));
            this.btnContinuous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnContinuous.Name = "btnContinuous";
            this.btnContinuous.Size = new System.Drawing.Size(23, 22);
            this.btnContinuous.Text = "Continuous";
            this.btnContinuous.ToolTipText = "Continuous mode";
            this.btnContinuous.Click += new System.EventHandler(this.btnContinuous_Click);
            // 
            // btnSingle
            // 
            this.btnSingle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSingle.Image = ((System.Drawing.Image)(resources.GetObject("btnSingle.Image")));
            this.btnSingle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(23, 22);
            this.btnSingle.Text = "Single";
            this.btnSingle.ToolTipText = "Single mode";
            this.btnSingle.Click += new System.EventHandler(this.btnSingle_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAuto.Image = ((System.Drawing.Image)(resources.GetObject("btnAuto.Image")));
            this.btnAuto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(23, 22);
            this.btnAuto.Text = "Auto";
            this.btnAuto.ToolTipText = "Auto mode";
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 22);
            this.toolStripLabel1.Text = "Threshold:";
            // 
            // txtThreshold
            // 
            this.txtThreshold.Name = "txtThreshold";
            this.txtThreshold.Size = new System.Drawing.Size(100, 25);
            // 
            // btnThreshold
            // 
            this.btnThreshold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnThreshold.Image = ((System.Drawing.Image)(resources.GetObject("btnThreshold.Image")));
            this.btnThreshold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThreshold.Name = "btnThreshold";
            this.btnThreshold.Size = new System.Drawing.Size(23, 22);
            this.btnThreshold.Text = "Specify Threshold";
            this.btnThreshold.Click += new System.EventHandler(this.btnThreshold_Click);
            // 
            // pdfDocumentViewer1
            // 
            this.pdfDocumentViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
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
            // lblPage
            // 
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(11, 22);
            this.lblPage.Text = "0";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 516);
            this.Controls.Add(this.pdfDocumentViewer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Spire.PdfViewer(for WinForms) Demo - Viewer Mode";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnContinuous;
        private System.Windows.Forms.ToolStripButton btnSingle;
        private System.Windows.Forms.ToolStripButton btnAuto;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtThreshold;
        private System.Windows.Forms.ToolStripButton btnThreshold;
        private Spire.PdfViewer.Forms.PdfDocumentViewer pdfDocumentViewer1;
        private System.Windows.Forms.ToolStripLabel lblPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

