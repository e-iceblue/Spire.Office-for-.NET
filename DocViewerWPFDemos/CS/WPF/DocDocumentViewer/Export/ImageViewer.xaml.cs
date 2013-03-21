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
using System.Windows.Shapes;

namespace DocDocumentViewer_Export
{
    /// <summary>
    /// Interaction logic for ImageViewer.xaml
    /// </summary>
    public partial class ImageViewer : Window
    {
        public ImageViewer()
        {
            InitializeComponent();
            int bitMapCount = MainWindow.bitMap.Count;
            int pageNum =MainWindow.m_CurrentPageNum;;
            if (bitMapCount > 0)
            {
                foreach (KeyValuePair<string, BitmapSource> dic in MainWindow.bitMap)
                {
                    string filename = dic.Key;
                    BitmapSource bmap = dic.Value;
                    int width = bmap.PixelWidth;
                    int height = bmap.PixelHeight;
                    StackPanel stackpanel = new StackPanel();
                    stackpanel.Width = width * 0.2;
                    stackpanel.Height = height * 0.2 + 30;

                    Image image = new Image();
                    image.VerticalAlignment = VerticalAlignment.Top;
                    image.Source = bmap;
                    Label label = new Label();
                    label.VerticalAlignment = VerticalAlignment.Bottom;
                    label.HorizontalAlignment = HorizontalAlignment.Center;
                    label.Foreground = System.Windows.Media.Brushes.Blue;
                    label.Content = pageNum.ToString();
                    label.FontSize = 15;
                    stackpanel.Children.Add(image);
                    stackpanel.Children.Add(label);
                    stackpanel.ToolTip = filename;
                    stackpanel.MouseDown += new MouseButtonEventHandler(stackpanel_MouseDown);
                    stackpanel.Cursor = System.Windows.Input.Cursors.Hand;
                    this.StackPanel1.Children.Add(stackpanel);
                    pageNum++;
                }
            }
        }

        private void stackpanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string filename = (string)((StackPanel)(sender)).ToolTip;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo(filename);
            process.Start();
        }
    }
}
