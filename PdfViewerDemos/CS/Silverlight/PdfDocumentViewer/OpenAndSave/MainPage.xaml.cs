using System;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Windows.Resources;

namespace OpenAndSave
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            bool? result = dialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                using (Stream stream = dialog.File.OpenRead())
                {
                    this.pdfDocumentViewer1.LoadFromStream(stream);
                }
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PDF documents(*pdf)|*.pdf";

            bool? result = dialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                using (Stream stream = dialog.OpenFile())
                {
                    this.pdfDocumentViewer1.SaveToFile(stream);
                }
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            StreamResourceInfo resource = Application.GetResourceStream(new Uri("OpenAndSave;component/Sample1.pdf", UriKind.Relative));
            this.pdfDocumentViewer1.LoadFromStream(resource.Stream);
        }
    }
}
