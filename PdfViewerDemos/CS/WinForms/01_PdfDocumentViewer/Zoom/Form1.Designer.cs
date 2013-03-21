namespace PdfDocumentViewer_Zoom
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
            this.btnOPen = new System.Windows.Forms.ToolStripButton();
            this.comBoxPages = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.comBoxZoom = new System.Windows.Forms.ToolStripComboBox();
            this.btnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.btnZoonIn = new System.Windows.Forms.ToolStripButton();
            this.btnDynamic = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActural = new System.Windows.Forms.ToolStripButton();
            this.btnFitPage = new System.Windows.Forms.ToolStripButton();
            this.btnFitWidth = new System.Windows.Forms.ToolStripButton();
            this.pdfDocumentViewer1 = new Spire.PdfViewer.Forms.PdfDocumentViewer();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOPen,
            this.comBoxPages,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.comBoxZoom,
            this.btnZoomOut,
            this.btnZoonIn,
            this.btnDynamic,
            this.toolStripSeparator2,
            this.btnActural,
            this.btnFitPage,
            this.btnFitWidth});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOPen
            // 
            this.btnOPen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOPen.Image = ((System.Drawing.Image)(resources.GetObject("btnOPen.Image")));
            this.btnOPen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOPen.Name = "btnOPen";
            this.btnOPen.Size = new System.Drawing.Size(23, 22);
            this.btnOPen.Text = "Open";
            this.btnOPen.ToolTipText = "Open PDF Document";
            this.btnOPen.Click += new System.EventHandler(this.btnOPen_Click);
            // 
            // comBoxPages
            // 
            this.comBoxPages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxPages.Name = "comBoxPages";
            this.comBoxPages.Size = new System.Drawing.Size(121, 25);
            this.comBoxPages.SelectedIndexChanged += new System.EventHandler(this.comBoxPages_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "Zoom:";
            // 
            // comBoxZoom
            // 
            this.comBoxZoom.Name = "comBoxZoom";
            this.comBoxZoom.Size = new System.Drawing.Size(121, 25);
            this.comBoxZoom.SelectedIndexChanged += new System.EventHandler(this.comBoxZoom_SelectedIndexChanged);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomOut.Image")));
            this.btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(23, 22);
            this.btnZoomOut.Text = "Zoom Out";
            this.btnZoomOut.ToolTipText = "Zoom Out ";
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoonIn
            // 
            this.btnZoonIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoonIn.Image = ((System.Drawing.Image)(resources.GetObject("btnZoonIn.Image")));
            this.btnZoonIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoonIn.Name = "btnZoonIn";
            this.btnZoonIn.Size = new System.Drawing.Size(23, 22);
            this.btnZoonIn.Text = "ZoonIn";
            this.btnZoonIn.ToolTipText = "Zoon In ";
            this.btnZoonIn.Click += new System.EventHandler(this.btnZoonIn_Click);
            // 
            // btnDynamic
            // 
            this.btnDynamic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDynamic.Enabled = false;
            this.btnDynamic.Image = ((System.Drawing.Image)(resources.GetObject("btnDynamic.Image")));
            this.btnDynamic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDynamic.Name = "btnDynamic";
            this.btnDynamic.Size = new System.Drawing.Size(23, 22);
            this.btnDynamic.Text = "Zoom Dynamic";
            this.btnDynamic.ToolTipText = "Zoom Dynamic";
            this.btnDynamic.Click += new System.EventHandler(this.btnDynamic_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnActural
            // 
            this.btnActural.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnActural.Image = ((System.Drawing.Image)(resources.GetObject("btnActural.Image")));
            this.btnActural.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActural.Name = "btnActural";
            this.btnActural.Size = new System.Drawing.Size(23, 22);
            this.btnActural.Text = "Actual";
            this.btnActural.ToolTipText = "Actual Size ";
            this.btnActural.Click += new System.EventHandler(this.btnActural_Click);
            // 
            // btnFitPage
            // 
            this.btnFitPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFitPage.Image = ((System.Drawing.Image)(resources.GetObject("btnFitPage.Image")));
            this.btnFitPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFitPage.Name = "btnFitPage";
            this.btnFitPage.Size = new System.Drawing.Size(23, 22);
            this.btnFitPage.Text = "FitPage";
            this.btnFitPage.ToolTipText = "Fit Page";
            this.btnFitPage.Click += new System.EventHandler(this.btnFitPage_Click);
            // 
            // btnFitWidth
            // 
            this.btnFitWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFitWidth.Image = ((System.Drawing.Image)(resources.GetObject("btnFitWidth.Image")));
            this.btnFitWidth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFitWidth.Name = "btnFitWidth";
            this.btnFitWidth.Size = new System.Drawing.Size(23, 22);
            this.btnFitWidth.Text = "FitWidth";
            this.btnFitWidth.ToolTipText = "Fit Width";
            this.btnFitWidth.Click += new System.EventHandler(this.btnFitWidth_Click);
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
            this.Text = "Spire.PdfViewer Demo - Zoom and Page layout";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOPen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox comBoxZoom;
        private System.Windows.Forms.ToolStripButton btnZoomOut;
        private System.Windows.Forms.ToolStripButton btnZoonIn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnActural;
        private System.Windows.Forms.ToolStripButton btnFitPage;
        private System.Windows.Forms.ToolStripButton btnFitWidth;
        private System.Windows.Forms.ToolStripButton btnDynamic;
        private Spire.PdfViewer.Forms.PdfDocumentViewer pdfDocumentViewer1;
        private System.Windows.Forms.ToolStripComboBox comBoxPages;
    }
}

