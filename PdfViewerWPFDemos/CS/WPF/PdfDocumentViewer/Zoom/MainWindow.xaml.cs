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

using Microsoft.Win32;
using Spire.PdfViewer.Wpf;
using Spire.PdfViewer;

namespace Zoom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[] zoomValues = new int[] { 10, 50, 100, 150, 200, 400, 800, 1600 };
        public MainWindow()
        {
            InitializeComponent();
            this.cmbCurrentZoomLevel.KeyDown += new KeyEventHandler(cmbCurrentZoomLevel_KeyDown);
            this.pdfDocumentViewer1.ZoomChanged += new ZoomChangedEventHandler(pdfDocumentViewer1_ZoomChanged);
        }

        private void pdfDocumentViewer1_ZoomChanged(object sender, int zoomFactor)
        {
            string text = string.Format("{0}%", zoomFactor);
            this.cmbCurrentZoomLevel.Text = text;
        }

        private int GetCurrentZoomLevel()
        {
            string s = "";
            if (this.cmbCurrentZoomLevel.SelectedValue == null)
            {
                s = this.cmbCurrentZoomLevel.Text;
            }
            else
            {
                s = (this.cmbCurrentZoomLevel.SelectedValue as ComboBoxItem).Content.ToString();
            }
            s = s.TrimEnd(new char[] { '%' });
            int result = 100;
            if (int.TryParse(s, out result))
            {
                return result;
            }
            return 100;
        }

        private int GetComboBoxItemIndex(string text)
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

        private void cmbCurrentZoomLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Return || e.Key == Key.Back)
            {
                string text = cmbCurrentZoomLevel.Text.Replace("%", "");
                int currentZoomLevel = 0;
                int.TryParse(text, out currentZoomLevel);
                if (e.Key == Key.Return && currentZoomLevel > 0)
                {
                    text = string.Format("{0}%", text);
                    cmbCurrentZoomLevel.SelectedValue = text;
                    cmbCurrentZoomLevel.Text = text;
                    this.pdfDocumentViewer1.ZoomTo(currentZoomLevel);
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            //open a pdf Document
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "Pdf document(*.Pdf)|*.pdf",
                Title = "Open Pdf Document",
                Multiselect = false,
                InitialDirectory =System.IO.Path.GetFullPath(@"..\..\..\..\..\..\Data")
            };
            bool? result = dialog.ShowDialog();
            if (result.Value)
            {
                try
                {
                    //Load pdf document from file.
                    this.pdfDocumentViewer1.LoadFromFile(dialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            //Close current pdf document.
            pdfDocumentViewer1.CloseDocument();
        }

        private void btnZooIn_Click(object sender, RoutedEventArgs e)
        {
            int currentZoomLevel = this.GetCurrentZoomLevel();
            int comboBoxItemIndex = this.GetComboBoxItemIndex(string.Format("{0}%", currentZoomLevel));
            if (((comboBoxItemIndex + 1) < this.cmbCurrentZoomLevel.Items.Count) && comboBoxItemIndex >= 0)
            {
                this.cmbCurrentZoomLevel.SelectedIndex = comboBoxItemIndex + 1;
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

        private void btnZoomOut_Click(object sender, RoutedEventArgs e)
        {
            int currentZoomLevel = this.GetCurrentZoomLevel();
            int comboBoxItemIndex = this.GetComboBoxItemIndex(string.Format("{0}%", currentZoomLevel));
            if ((comboBoxItemIndex - 1) >= 0)
            {
                this.cmbCurrentZoomLevel.SelectedIndex = comboBoxItemIndex - 1;
                return;
            }
            else
            {
                for (int i = 0; i < this.zoomValues.Length; i++)
                {
                    if ((((i + 1) < this.zoomValues.Length) && (currentZoomLevel >= this.zoomValues[i])) && (currentZoomLevel < this.zoomValues[i + 1]))
                    {
                        this.cmbCurrentZoomLevel.SelectedIndex = i;                        
                        return;
                    }
                }
            }
        }

        private void btnFitPage_Click(object sender, RoutedEventArgs e)
        {
            this.pdfDocumentViewer1.ZoomMode = ZoomMode.FitPage;
        }

        private void btnFitWidth_Click(object sender, RoutedEventArgs e)
        {
            this.pdfDocumentViewer1.ZoomMode = ZoomMode.FitWidth;
        }

        private void cmbCurrentZoomLevel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int currentZoomLevel = this.GetCurrentZoomLevel();
            this.pdfDocumentViewer1.ZoomTo(currentZoomLevel);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // Load pdf document from file.
                this.pdfDocumentViewer1.LoadFromFile(@"..\..\..\..\..\..\Data\Spire.Office.pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
