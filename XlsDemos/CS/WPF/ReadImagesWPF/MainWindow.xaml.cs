using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Spire.Xls;
using System.Drawing;
using System.IO;
namespace ReadImagesWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(@"..\..\..\..\..\Data\ImageSample.xls");
            Worksheet sheet = workbook.Worksheets[0];
            //get picture
            ExcelPicture pic = sheet.Pictures[0];

            //save memoryStream
            System.Windows.Controls.Image img = new System.Windows.Controls.Image();
            System.IO.MemoryStream mem = new System.IO.MemoryStream();
            pic.Picture.Save(mem, System.Drawing.Imaging.ImageFormat.Png);
            img.Source = GetBitmapSourceFromStream(mem);
            //create window
            Window imgWindow = new Window();
            imgWindow.Title = "ImageSample";
            imgWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            imgWindow.Width = pic.Picture.Width;
            imgWindow.Height = pic.Picture.Height;
            imgWindow.ResizeMode = ResizeMode.NoResize;
            //set margin
            Thickness thick = new Thickness(0,0,0,0);
            img.Margin = thick;
            imgWindow.Content = img;
            imgWindow.ShowDialog();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private  BitmapImage GetBitmapSourceFromStream(Stream imgStream)
        {
            BitmapImage bitMapImg = new BitmapImage();
            bitMapImg.BeginInit();
            bitMapImg.StreamSource = imgStream;
            bitMapImg.EndInit();
            bitMapImg.Freeze();
            return bitMapImg;
        }

        private void ExcelDocViewer(string fileName)
        {
            try
            {
                System.Diagnostics.Process.Start(fileName);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "information", MessageBoxButton.OK);
            }
        }
    }
}
