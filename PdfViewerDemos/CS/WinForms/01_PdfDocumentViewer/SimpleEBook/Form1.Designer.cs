namespace SimpleEBook_VS2010
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabelFirst = new System.Windows.Forms.LinkLabel();
            this.linkLabelPrevious = new System.Windows.Forms.LinkLabel();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.linkLableNext = new System.Windows.Forms.LinkLabel();
            this.linkLabelLast = new System.Windows.Forms.LinkLabel();
            this.pdfDocumentViewer1 = new Spire.PdfViewer.Forms.PdfDocumentViewer();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pdfDocumentViewer1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(742, 516);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(742, 30);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(23, 27);
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.4918F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.4918F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.03279F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.4918F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.4918F));
            this.tableLayoutPanel2.Controls.Add(this.linkLabelFirst, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.linkLabelPrevious, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtPage, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.linkLableNext, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.linkLabelLast, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 479);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(736, 34);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // linkLabelFirst
            // 
            this.linkLabelFirst.AutoSize = true;
            this.linkLabelFirst.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelFirst.Location = new System.Drawing.Point(3, 0);
            this.linkLabelFirst.Name = "linkLabelFirst";
            this.linkLabelFirst.Size = new System.Drawing.Size(40, 19);
            this.linkLabelFirst.TabIndex = 0;
            this.linkLabelFirst.TabStop = true;
            this.linkLabelFirst.Text = "First";
            this.linkLabelFirst.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFirst_LinkClicked);
            // 
            // linkLabelPrevious
            // 
            this.linkLabelPrevious.AutoSize = true;
            this.linkLabelPrevious.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelPrevious.Location = new System.Drawing.Point(153, 0);
            this.linkLabelPrevious.Name = "linkLabelPrevious";
            this.linkLabelPrevious.Size = new System.Drawing.Size(69, 19);
            this.linkLabelPrevious.TabIndex = 1;
            this.linkLabelPrevious.TabStop = true;
            this.linkLabelPrevious.Text = "Previous";
            this.linkLabelPrevious.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPrevious_LinkClicked);
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(303, 3);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(100, 21);
            this.txtPage.TabIndex = 2;
            this.txtPage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPage_KeyDown);
            // 
            // linkLableNext
            // 
            this.linkLableNext.AutoSize = true;
            this.linkLableNext.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLableNext.Location = new System.Drawing.Point(435, 0);
            this.linkLableNext.Name = "linkLableNext";
            this.linkLableNext.Size = new System.Drawing.Size(43, 19);
            this.linkLableNext.TabIndex = 3;
            this.linkLableNext.TabStop = true;
            this.linkLableNext.Text = "Next";
            this.linkLableNext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLableNext_LinkClicked);
            // 
            // linkLabelLast
            // 
            this.linkLabelLast.AutoSize = true;
            this.linkLabelLast.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabelLast.Location = new System.Drawing.Point(585, 0);
            this.linkLabelLast.Name = "linkLabelLast";
            this.linkLabelLast.Size = new System.Drawing.Size(38, 19);
            this.linkLabelLast.TabIndex = 4;
            this.linkLabelLast.TabStop = true;
            this.linkLabelLast.Text = "Last";
            this.linkLabelLast.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLast_LinkClicked);
            // 
            // pdfDocumentViewer1
            // 
            this.pdfDocumentViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pdfDocumentViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pdfDocumentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.pdfDocumentViewer1.IsClickJump = false;
            this.pdfDocumentViewer1.Location = new System.Drawing.Point(3, 33);
            this.pdfDocumentViewer1.Name = "pdfDocumentViewer1";
            this.pdfDocumentViewer1.Size = new System.Drawing.Size(736, 440);
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
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Spire.PdfViewer(for WinForms) Demo - Simple E-Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private Spire.PdfViewer.Forms.PdfDocumentViewer pdfDocumentViewer1;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.LinkLabel linkLabelFirst;
        private System.Windows.Forms.LinkLabel linkLabelPrevious;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.LinkLabel linkLableNext;
        private System.Windows.Forms.LinkLabel linkLabelLast;
    }
}

