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
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PDF documents(*pdf)|*.pdf";

            bool? result = dialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                using (Stream stream = dialog.OpenFile())
                {
                    this.pdfViewer1.SaveToFile(stream);
                }
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            StreamResourceInfo resource = Application.GetResourceStream(new System.Uri("OpenAndSave;component/PdfViewer.pdf", System.UriKind.Relative));
            this.pdfViewer1.LoadFromStream(resource.Stream);
        }
    }
}
