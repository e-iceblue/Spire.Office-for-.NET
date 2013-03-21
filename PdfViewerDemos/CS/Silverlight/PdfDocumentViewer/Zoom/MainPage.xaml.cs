using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.IO;
using Spire.PdfViewer.SL;
using System.Windows.Resources;

namespace Zoom
{
    public partial class MainPage : UserControl
    {
        private int[] zoomValues = new int[] { 25, 50, 100, 150, 200 };
        public MainPage()
        {
            InitializeComponent();
            this.cmbCurrentZoomLevel.KeyDown += new KeyEventHandler(cmbCurrentZoomLevel_KeyDown);
            this.pdfDocumentViewer1.ZoomChanged += new Spire.PdfViewer.ZoomChangedEventHandler(pdfDocumentViewer1_ZoomChanged);
        }

        void pdfDocumentViewer1_ZoomChanged(object sender, int zoomFactor)
        {
            string text = string.Format("{0}%", zoomFactor);
            ((this.cmbCurrentZoomLevel.SelectedItem) as ComboBoxItem).Content = text;
        }

        void cmbCurrentZoomLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Enter || e.Key == Key.Back)
            {
                string text = (cmbCurrentZoomLevel.SelectedItem as ComboBoxItem).Content.ToString().Replace("%", "");
                int currentZoomLevel = 0;
                int.TryParse(text, out currentZoomLevel);
                if (e.Key == Key.Enter && currentZoomLevel > 0)
                {
                    text = string.Format("{0}%", text);
                    cmbCurrentZoomLevel.SelectedValue = text;
                    this.pdfDocumentViewer1.ZoomTo(currentZoomLevel);
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private int GetCurrentZoomLevel()
        {
            string s = "";

            s = ((this.cmbCurrentZoomLevel.SelectedItem) as ComboBoxItem).Content.ToString();

            s = s.TrimEnd(new char[] { '%' });
            int result = 100;
            if (int.TryParse(s, out result))
            {
                return result;
            }

            return 100;
        }

        private int GetComboboxItemIndex(string text)
        {
            for (int i = 0; i < this.cmbCurrentZoomLevel.Items.Count; i++)
            {
                if (object.Equals((this.cmbCurrentZoomLevel.Items[i] as ComboBoxItem).Content, text))
                {
                    return i;
                }
            }
            return -1;
        }


        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            bool? result = dialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                try
                {
                    using (Stream stream = dialog.File.OpenRead())
                    {
                        this.pdfDocumentViewer1.LoadFromStream(stream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
                }
            }
        }

        private void btnZoomOut_Click(object sender, RoutedEventArgs e)
        {
            int currentZoomLevel = this.GetCurrentZoomLevel();
            int comboxItemIndex = this.GetComboboxItemIndex(string.Format("{0}%", currentZoomLevel));
            if ((comboxItemIndex - 1) >= 0)
            {
                this.cmbCurrentZoomLevel.SelectedIndex = comboxItemIndex - 1;
                return;
            }
            else
            {
                for (int i = 0; i < this.zoomValues.Length; i++)
                {
                    if ((((i + 1 < this.zoomValues.Length) && (currentZoomLevel >= this.zoomValues[i])) && (currentZoomLevel < this.zoomValues[i + 1])))
                    {
                        this.cmbCurrentZoomLevel.SelectedIndex = i;
                        return;
                    }
                }
            }
        }

        private void btnFitWidth_Click(object sender, RoutedEventArgs e)
        {
            this.pdfDocumentViewer1.ZoomMode = ZoomMode.FitWidth;
        }

        private void btnFitPage_Click(object sender, RoutedEventArgs e)
        {
            this.pdfDocumentViewer1.ZoomMode = ZoomMode.FitPage;
        }

        private void btnZoomIn_Click(object sender, RoutedEventArgs e)
        {
            int currentZoomLevel = this.GetCurrentZoomLevel();
            int comboxItemIndex = this.GetComboboxItemIndex(string.Format("{0}%", currentZoomLevel));
            if (((comboxItemIndex + 1 < this.cmbCurrentZoomLevel.Items.Count) && comboxItemIndex >= 0))
            {
                this.cmbCurrentZoomLevel.SelectedIndex = comboxItemIndex + 1;
                return;
            }
            else
            {
                for (int i = 0; i < this.zoomValues.Length; i++)
                {
                    if (((i - 1) >= 0) && (this.zoomValues[i] > currentZoomLevel))
                    {
                        this.cmbCurrentZoomLevel.SelectedIndex = i;
                        return;
                    }
                }
            }
        }

        private void cmbCurrentZoomLevel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int currentZoomLevel = this.GetCurrentZoomLevel();
            this.pdfDocumentViewer1.ZoomTo(currentZoomLevel);
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            this.cmbCurrentZoomLevel.SelectedIndex = 2;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            StreamResourceInfo resource = Application.GetResourceStream(new Uri("Zoom;component/Sample2.pdf", UriKind.Relative));
            this.pdfDocumentViewer1.LoadFromStream(resource.Stream);
        }

    }
}
