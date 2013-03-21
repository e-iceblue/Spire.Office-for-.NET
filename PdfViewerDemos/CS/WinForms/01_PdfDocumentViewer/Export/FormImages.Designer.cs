namespace PdfDocumentViewer_Export
{
    partial class FormImages
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
            this.panelImages1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panelImages1
            // 
            this.panelImages1.AutoScroll = true;
            this.panelImages1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImages1.Location = new System.Drawing.Point(0, 0);
            this.panelImages1.Name = "panelImages1";
            this.panelImages1.Size = new System.Drawing.Size(484, 362);
            this.panelImages1.TabIndex = 1;
            // 
            // FormImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.panelImages1);
            this.Name = "FormImages";
            this.Text = "Spire.PdfViewer Demo - View Exported Images";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelImages1;
    }
}