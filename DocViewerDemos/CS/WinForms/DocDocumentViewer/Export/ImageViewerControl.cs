using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Export
{
    public partial class ImageViewerControl : UserControl
    {
        private string m_filename;
        public ImageViewerControl()
        {
            InitializeComponent();
            this.label1.BackColor = this.BackColor;
            this.pictureBox1.BackColor = this.BackColor;
            this.pictureBox1.MouseClick += new MouseEventHandler(pictureBox1_MouseClick);
            this.label1.MouseClick += new MouseEventHandler(label1_MouseClick);
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            this.OnMouseClick(e);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.OnMouseClick(e);
        }     


        private void ImageViewerControl_SizeChanged(object sender, EventArgs e)
        {
            int width = this.Width;
            int height = this.Height;

            this.pictureBox1.Width = width;
            this.pictureBox1.Height = height - 30;

            this.label1.Top = height - 30;
            this.label1.Width = width;
        }

        private void ImageViewerControl_BackColorChanged(object sender, EventArgs e)
        {
            this.label1.BackColor = this.BackColor;
            this.pictureBox1.BackColor = this.BackColor;
        }

        public String FileName
        {
            set
            {
                m_filename = value;
                this.toolTipMsg.Active = true;
                this.toolTipMsg.SetToolTip(this, m_filename);
                this.toolTipMsg.SetToolTip(this.label1, m_filename);
                this.toolTipMsg.SetToolTip(this.pictureBox1, m_filename);
            }
            get { return this.m_filename; }
        }

        public Image Image
        {
            set
            {
                this.pictureBox1.Image = value;
                this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        public String Text
        {
            set { this.label1.Text = value; }
        }
    }
}
