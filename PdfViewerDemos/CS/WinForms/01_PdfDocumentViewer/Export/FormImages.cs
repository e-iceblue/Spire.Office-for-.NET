using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PdfDocumentViewer_Export
{
    public partial class FormImages : Form
    {
    
        private Dictionary<String,Image> _dictionaryImags;
   
        public Dictionary<String ,Image> DictionaryImages
        {
            get {return this._dictionaryImags;}
            set  {
                this._dictionaryImags=value;
                this.ViewImages();
            }
        }
        public FormImages()
        {
            InitializeComponent();
        }

        public void ViewImages()
        {
            if (this.DictionaryImages!=null&&this.DictionaryImages.Count>0)
            {
                this.panelImages1.Controls.Clear();
                String image_name = "";
                int panelHeight = 0;
                int panelWidth = 0;

                foreach (KeyValuePair<String, Image> pair in this.DictionaryImages)
                {
                    image_name = pair.Key;
                    
                    Panel panelImage = new Panel();
                    panelImage.AutoSize = true;
                  
                
                    PictureBox ptrBox = new PictureBox();
                    ptrBox.Height = 150;
                    ptrBox.Width = 200;
                    
                    ptrBox.SizeMode = PictureBoxSizeMode.Zoom;
                    
                    ptrBox.Image = pair.Value;
                    ptrBox.Cursor = Cursors.Hand;
                
                    panelImage.Controls.Add(ptrBox);

                    LinkLabel lbl = new LinkLabel();
                    String imageName = Path.GetFileName(pair.Key);
                    lbl.Text = imageName;
                    int x = (Int32)(ptrBox.Width / 2 - lbl.Width / 2);
                    int y = ptrBox.Height;
                    lbl.Left = x;
                    lbl.Top = y;
                    panelImage.Controls.Add(lbl);

                    this.panelImages1.Controls.Add(panelImage);

                    this.SetClickEventHandler(ptrBox,lbl, image_name);
                    panelHeight = panelImage.Height;
                    panelWidth = panelImage.Width;

                }
                int nimages = this._dictionaryImags.Count;
                if (nimages >= 4)
                {

                    int n = (Int32)Math.Ceiling(Math.Sqrt(nimages));

                    this.Width = panelWidth * n + 20*(n-1)+40;
                    this.Height = panelHeight * n + 20 * (n - 1)+40;
                }
            }
        }
        private void SetClickEventHandler(PictureBox ptrBox,LinkLabel lbl, string imageName)
        {
            ptrBox.Click += new EventHandler(delegate(Object sender, EventArgs args)
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo(imageName);
                process.StartInfo = info;
                process.Start();
            });
        
            lbl.Click += new EventHandler(delegate(Object sender, EventArgs args)
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo(imageName);
                process.StartInfo = info;
                process.Start();
            });

        }
    }
}
