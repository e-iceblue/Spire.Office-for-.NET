using System;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Windows.Media.Imaging;
using System.Windows.Resources;

namespace Export
{
    public partial class MainPage : UserControl
    {
        public static int m_CurrentPageNum = 0;
        public MainPage()
        {
            InitializeComponent();
            this.pdfViewer1.CurrentPageChange += new Spire.PdfViewer.PageNumberChangedEventHandler(pdfViewer1_CurrentPageChange);
            this.pdfViewer1.DocumentLoaded += new Spire.PdfViewer.DocumentOpenedEventHandler(pdfViewer1_DocumentLoaded);
            this.txtFrom.IsEnabled = this.ckbFrom.IsChecked.Value;
            this.txtTo.IsEnabled = this.ckbTo.IsChecked.Value;

            this.scrollViewer1.Content = this.canvasImg;
        }

        void pdfViewer1_DocumentLoaded(object sender, EventArgs args)
        {
            this.txtTo.Text = this.pdfViewer1.PageCount.ToString();
        }

        void pdfViewer1_CurrentPageChange(object sender, EventArgs args)
        {
            txtFrom.Text = this.pdfViewer1.CurrentPageNumber.ToString();
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            this.txtTo.Text = this.pdfViewer1.PageCount.ToString();
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            bool? result = dialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                using (Stream stream = dialog.File.OpenRead())
                {
                    this.pdfViewer1.LoadFromStream(stream);
                }
                this.txtTo.Text = this.pdfViewer1.PageCount.ToString();
            }

            this.tabItem3.IsSelected = true;
        }

        private void ckbTo_Click(object sender, RoutedEventArgs e)
        {
            txtTo.IsEnabled = ckbTo.IsChecked.Value;
        }

        private void btnSaveAsImg_Click(object sender, RoutedEventArgs e)
        {
            this.tabImg.IsSelected = true;
            try
            {
                if (ckbFrom.IsChecked.Value && ckbTo.IsChecked.Value)
                {
                    int startIndex = 0;
                    int.TryParse(txtFrom.Text, out startIndex);
                    m_CurrentPageNum = startIndex;
                    int endIndex = 0;
                    int.TryParse(txtTo.Text, out endIndex);

                    //exports the specified pages as images
                    BitmapSource[] bitmapSource = this.pdfViewer1.SaveAsImage(startIndex, endIndex);

                    double topLocation = 0;
                    double leftLocation = 0;
                    foreach (BitmapSource imgSource in bitmapSource)
                    {
                        Image image = new Image();
                        image.Source = imgSource;
                        leftLocation = (this.canvasImg.Width - imgSource.PixelWidth) / 2;
                        image.Margin = new Thickness(leftLocation, topLocation, 0, 0);
                        this.canvasImg.Children.Add(image);
                        topLocation += imgSource.PixelHeight + 10;
                        this.canvasImg.Height += imgSource.PixelHeight;
                    }
                }
                else if (ckbFrom.IsChecked.Value && !ckbTo.IsChecked.Value)
                {
                    int currentPageIndex = 0;
                    int.TryParse(txtFrom.Text, out currentPageIndex);
                    m_CurrentPageNum = currentPageIndex;
                    BitmapSource bitmapSource = this.pdfViewer1.SaveAsImage(currentPageIndex);
                    double topLocation = 0;
                    double leftLocation = 0;
                    Image image = new Image();
                    image.Source = bitmapSource;
                    leftLocation = (this.canvasImg.Width - bitmapSource.PixelWidth) / 2;
                    image.Margin = new Thickness(leftLocation, topLocation, 0, 0);
                    this.canvasImg.Children.Add(image);
                    topLocation += bitmapSource.PixelHeight + 10;
                    this.canvasImg.Height += bitmapSource.PixelHeight;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            StreamResourceInfo resource=Application.GetResourceStream(new Uri("Export;component/PartList.pdf",UriKind.Relative));
            this.pdfViewer1.LoadFromStream(resource.Stream);
        }
    }
}
