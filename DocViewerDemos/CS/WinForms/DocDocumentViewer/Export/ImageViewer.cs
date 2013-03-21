using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Export
{
    public partial class ImageViewer : Form
    {
        public ImageViewer()
        {
            InitializeComponent();

            int bitMapCount = Form1.bitMap.Count;
            int pageNum = Form1.m_CurrentPageNum; ;
            if (bitMapCount > 0)
            {
                foreach (KeyValuePair<string, Image> dic in Form1.bitMap)
                {
                    string filename = dic.Key;
                    Image bmap = dic.Value;
                    ImageViewerControl iv = new ImageViewerControl();
                    iv.Image = bmap;
                    iv.FileName = filename;
                    iv.Text = pageNum.ToString();
                    iv.Cursor = Cursors.Hand;
                    iv.MouseClick += new MouseEventHandler(iv_MouseClick);
                    this.flowLayoutPanel1.Controls.Add(iv);
                    iv.Left = (int)(this.flowLayoutPanel1.Width - iv.Width) / 2;
                    pageNum++;
                }
            }
        }

        private void iv_MouseClick(object sender, MouseEventArgs e)
        {
            string filename = ((ImageViewerControl)(sender)).FileName;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo(filename);
            process.Start();
        }      
    }
}
