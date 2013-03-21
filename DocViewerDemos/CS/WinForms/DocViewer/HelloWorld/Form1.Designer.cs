namespace HelloWorld
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
            this.docViewer1 = new Spire.DocViewer.Forms.DocViewer();
            this.SuspendLayout();
            // 
            // docViewer1
            // 
            this.docViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docViewer1.IsToolBarVisible = true;
            this.docViewer1.Location = new System.Drawing.Point(0, 0);
            this.docViewer1.Name = "docViewer1";
            this.docViewer1.Size = new System.Drawing.Size(792, 573);
            this.docViewer1.TabIndex = 0;
            this.docViewer1.Text = "docViewer1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.docViewer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spire.DocViewer for .NET – Demo – How to Use DocViewer Component.";
            this.ResumeLayout(false);

        }

        #endregion

        private Spire.DocViewer.Forms.DocViewer docViewer1;
    }
}

