namespace Export
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ckbHandtool = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbFrom = new System.Windows.Forms.CheckBox();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ckbTo = new System.Windows.Forms.CheckBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.docDocumentViewer1 = new Spire.DocViewer.Forms.DocDocumentViewer();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ckbHandtool);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnOpen);
            this.splitContainer1.Panel1MinSize = 30;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.docDocumentViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(792, 573);
            this.splitContainer1.SplitterDistance = 59;
            this.splitContainer1.TabIndex = 1;
            // 
            // ckbHandtool
            // 
            this.ckbHandtool.AutoSize = true;
            this.ckbHandtool.Location = new System.Drawing.Point(446, 19);
            this.ckbHandtool.Name = "ckbHandtool";
            this.ckbHandtool.Size = new System.Drawing.Size(78, 16);
            this.ckbHandtool.TabIndex = 2;
            this.ckbHandtool.Text = "Hand Tool";
            this.ckbHandtool.UseVisualStyleBackColor = true;
            this.ckbHandtool.CheckedChanged += new System.EventHandler(this.ckbHandtool_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbFrom);
            this.groupBox1.Controls.Add(this.btnSaveImage);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.ckbTo);
            this.groupBox1.Location = new System.Drawing.Point(117, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export Image";
            // 
            // ckbFrom
            // 
            this.ckbFrom.AutoSize = true;
            this.ckbFrom.Checked = true;
            this.ckbFrom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbFrom.Location = new System.Drawing.Point(6, 24);
            this.ckbFrom.Name = "ckbFrom";
            this.ckbFrom.Size = new System.Drawing.Size(54, 16);
            this.ckbFrom.TabIndex = 6;
            this.ckbFrom.Text = "From:";
            this.ckbFrom.UseVisualStyleBackColor = true;
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(212, 21);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(101, 23);
            this.btnSaveImage.TabIndex = 5;
            this.btnSaveImage.Text = "Save to Image";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(46, 21);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 21);
            this.textBox1.TabIndex = 3;
            // 
            // ckbTo
            // 
            this.ckbTo.AutoSize = true;
            this.ckbTo.Location = new System.Drawing.Point(114, 24);
            this.ckbTo.Name = "ckbTo";
            this.ckbTo.Size = new System.Drawing.Size(42, 16);
            this.ckbTo.TabIndex = 1;
            this.ckbTo.Text = "To:";
            this.ckbTo.UseVisualStyleBackColor = true;
            this.ckbTo.CheckedChanged += new System.EventHandler(this.ckbTo_CheckedChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 16);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(99, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open Document";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // docDocumentViewer1
            // 
            this.docDocumentViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.docDocumentViewer1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.docDocumentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docDocumentViewer1.EnableHandTools = false;
            this.docDocumentViewer1.Location = new System.Drawing.Point(0, 0);
            this.docDocumentViewer1.Name = "docDocumentViewer1";
            this.docDocumentViewer1.Size = new System.Drawing.Size(792, 510);
            this.docDocumentViewer1.TabIndex = 1;
            this.docDocumentViewer1.Text = "docDocumentViewer1";
            this.docDocumentViewer1.ZoomMode = Spire.DocViewer.Forms.ZoomMode.Default;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spire.DocViewer.Forms - Demo - Export Image via DocDocumentViewer Component.";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Spire.DocViewer.Forms.DocDocumentViewer docDocumentViewer1;
        private System.Windows.Forms.CheckBox ckbHandtool;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox ckbTo;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.CheckBox ckbFrom;

    }
}

