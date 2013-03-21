using System;
using System.IO;
using System.Windows.Forms;
using Spire.PdfViewer.Forms;


namespace PdfDocumentViewer_Zoom
{
    
    public partial class Form1 : Form
    {
   
        public Form1()
        {
            InitializeComponent();
        }
 
        //private bool _isZoomout = true;

        private int _zoom=100;
        private bool _isZoomDynamic = false;
       


        private void Form1_Load(object sender, EventArgs e)
        {
            string pdfDoc = @"..\..\..\..\..\..\Data\PDFViewer.pdf";
            if (File.Exists(pdfDoc))
            {
                this.pdfDocumentViewer1.LoadFromFile(pdfDoc);
            }
          
            //add zoom values to combox
            int[] intZooms = new Int32[] { 25, 50, 75, 100, 125, 150, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };
            foreach (int zoom in intZooms)
            {
                this.comBoxZoom.Items.Add(zoom.ToString());
            }
            this.comBoxZoom.SelectedIndex = 3;

            //pdfDocumentViewer mouseWheel event

            this.pdfDocumentViewer1.MouseWheel += new MouseEventHandler(this.pdfDocumentViewer1_MouseWheel);
            this.pdfDocumentViewer1.LostFocus += new EventHandler(this.pdfDocumentViewer_LostFocus);

            


        }
        private void pdfDocumentViewer_LostFocus(Object sender, EventArgs args)
        {
            this._isZoomDynamic = false;
            this._zoom = 100;
        }

        private void  pdfDocumentViewer1_MouseWheel(Object sender,MouseEventArgs args)
        {
            if (this._isZoomDynamic)
            {
                int wheelValue= (Int32)args.Delta / 24;
             

                this._zoom += wheelValue;
            
                if (this._zoom < 0)
                    this._zoom = 0;
                this.pdfDocumentViewer1.ZoomTo(this._zoom);
            }
            //else
            //{
            //    int wheelValue = -(Int32)args.Delta / 12;
            //    this._zoom += wheelValue;
            //    if (this._zoom < 0)
            //        this._zoom = 0;
            //   // MessageBox.Show(this._zoom.ToString());
            //    this.pdfDocumentViewer1.ZoomTo(this._zoom);
            //}
            
            
            
        }

        private void btnOPen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PDF document (*.pdf)|*.pdf";
          
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    string pdfFile = dialog.FileName;
                    this.pdfDocumentViewer1.LoadFromFile(pdfFile);
                   
                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.Message, "Spire.PdfViewer Demo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

       

     

        private void comBoxZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.PageCount > 0)
            {
                int zoomValue = Int32.Parse(this.comBoxZoom.SelectedItem.ToString());
                this.pdfDocumentViewer1.ZoomTo(zoomValue);
            }
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.PageCount > 0)
            {
                int delta = 10;
                this._zoom += delta;
                this.pdfDocumentViewer1.ZoomTo(this._zoom);
            }
        }

        private void btnZoonIn_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.PageCount > 0)
            {
                int delta = 5;
                this._zoom -= delta;
                if (this._zoom < 0)
                    this._zoom = 0;
                this.pdfDocumentViewer1.ZoomTo(this._zoom);
            }
        }

        private void btnActural_Click(object sender, EventArgs e)
        {
            this._zoom = 100;
            this._isZoomDynamic = false;
            this.btnDynamic.Text = "Zoom Dynamic";
            if (this.pdfDocumentViewer1.PageCount > 0)
            {
                this.pdfDocumentViewer1.ZoomTo(100);
                this.comBoxZoom.SelectedIndex = 3;
            }
        }

       

        private void btnFitPage_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.PageCount > 0)
            {
                this.pdfDocumentViewer1.ZoomTo(ZoomMode.FitPage);
            }
        }

        private void btnFitWidth_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.PageCount > 0)
            {
                this.pdfDocumentViewer1.ZoomTo(ZoomMode.FitWidth);
            }
        }

        private void btnDynamic_Click(object sender, EventArgs e)
        {
            this._isZoomDynamic = !this._isZoomDynamic;
            if (this._isZoomDynamic)
            {

                this.btnDynamic.Text = "Cancel dynamic zoom";
                this.btnDynamic.ToolTipText = "Cancel dynamic zoom";
            }

            else
            {
                this.btnDynamic.Text = "Zoom dynamic";
                this.btnDynamic.ToolTipText = "Zoom dynamic";
            }

        }

        private void pdfDocumentViewer1_PdfLoaded(object sender, EventArgs args)
        {
            this.btnDynamic.Enabled = true;
            this.comBoxPages.Items.Clear();
            int totalPage = this.pdfDocumentViewer1.PageCount;

            for (int i = 1; i <= totalPage; i++)
            {
                this.comBoxPages.Items.Add(i.ToString());
            }

            this.comBoxPages.SelectedIndex = 0;  
        }

        private void pdfDocumentViewer1_PageNumberChanged(object sender, EventArgs args)
        {
            if (this.comBoxPages.Items.Count <= 0)
                return;
            if (this.pdfDocumentViewer1.CurrentPageNumber != this.comBoxPages.SelectedIndex + 1)
            {
                this.comBoxPages.SelectedIndex = this.pdfDocumentViewer1.CurrentPageNumber - 1;
            }
        }

        private void comBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            int soucePage = this.pdfDocumentViewer1.CurrentPageNumber;
            int targetPage = this.comBoxPages.SelectedIndex + 1;
            if (soucePage != targetPage)
            {
                this.pdfDocumentViewer1.GoToPage(targetPage);
            }
        }

    }
}
