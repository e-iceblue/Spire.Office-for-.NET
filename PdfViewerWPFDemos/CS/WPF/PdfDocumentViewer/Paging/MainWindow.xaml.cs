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


namespace Paging
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool m_canFirstPage = false;
        private bool m_canNextPage = false;
        private bool m_canPreviousPage = false;
        private bool m_canLastPage = false;


        public MainWindow()
        {
            InitializeComponent();
            this.pdfDocumentViewer1.PageNumberChanged += new PageNumberChangedEventHandler(pdfDocumentViewer1_PageNumberChanged);
            this.btnFirstPage.IsEnabled = this.m_canFirstPage;
            this.btnLastPage.IsEnabled = this.m_canLastPage;
            this.btnNextPage.IsEnabled = this.m_canNextPage;
            this.btnPreviousPage.IsEnabled = this.m_canPreviousPage;
        }

        private void pdfDocumentViewer1_PageNumberChanged(object sender, EventArgs args)
        {
            int currentNum = this.pdfDocumentViewer1.CurrentPageNumber;
            int result = 0;
            int.TryParse(txtCurrentPageIndex.Text, out result);
            if (currentNum != result && result > 0)
            {
                SetbuttonState();
            }
            this.txtCurrentPageIndex.Text = currentNum.ToString();
        }

        private void buttonStatesChanged()
        {
            int currentPageIndex = this.pdfDocumentViewer1.CurrentPageNumber;
            int pageCount = this.pdfDocumentViewer1.PageCount;
            if (pageCount > 0)
            {
                if (pageCount > 1)
                {
                    if (currentPageIndex == 1)
                    {
                        m_canFirstPage = false;
                        m_canPreviousPage = false;
                        m_canNextPage = true;
                        m_canLastPage = true;
                        return;
                    }

                    if (currentPageIndex == pageCount)
                    {
                        m_canFirstPage = true;
                        m_canPreviousPage = true;
                        m_canNextPage = false;
                        m_canLastPage = false;
                        return;
                    }

                    m_canFirstPage = true;
                    m_canPreviousPage = true;
                    m_canNextPage = true;
                    m_canLastPage = true;
                    return;
                }
            }

            m_canFirstPage = false;
            m_canNextPage = false;
            m_canPreviousPage = false;
            m_canLastPage = false;
        }

        private void SetbuttonState()
        {
            buttonStatesChanged();
            this.btnFirstPage.IsEnabled = this.m_canFirstPage;
            this.btnLastPage.IsEnabled = this.m_canLastPage;
            this.btnNextPage.IsEnabled = this.m_canNextPage;
            this.btnPreviousPage.IsEnabled = this.m_canPreviousPage;
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            //Open a pdf document
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
                    this.txtPageCount.Text = this.pdfDocumentViewer1.PageCount.ToString();
                    SetbuttonState();
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
            this.txtPageCount.Text = this.pdfDocumentViewer1.PageCount.ToString();
        }

        private void txtCurrentPageIndex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Return || e.Key == Key.Back)
            {
                if (e.Key == Key.Return)
                {
                    int pageNumber = 0;
                    int.TryParse(txtCurrentPageIndex.Text, out pageNumber);
                    if (pageNumber >= 1 && pageNumber <= this.pdfDocumentViewer1.PageCount)
                    {
                        this.pdfDocumentViewer1.GoToPage(this.GetCurrentPageNumber());
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private int GetCurrentPageNumber()
        {
            if (string.IsNullOrEmpty(this.txtCurrentPageIndex.Text))
            {
                return 1;
            }
            int result = 1;
            if (int.TryParse(this.txtCurrentPageIndex.Text, out result))
            {
                return result;
            }
            return -1;
        }

        private void btnFirstPage_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Image content = ((Button)sender).Content as Image;
            content.Source = this.btnFirstPage.IsEnabled ? (new BitmapImage(new Uri("Resources/GoToFirstPage_Enabled.png", UriKind.Relative))) : (new BitmapImage(new Uri("Resources/GoToFirstPage_Disabled.png", UriKind.Relative)));
        }

        private void btnPreviousPage_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Image content = ((Button)sender).Content as Image;
            content.Source = this.btnPreviousPage.IsEnabled ? (new BitmapImage(new Uri("Resources/GoToPreviousPage_Enabled.png", UriKind.Relative))) : (new BitmapImage(new Uri("Resources/GoToPreviousPage_Disabled.png", UriKind.Relative)));
        }

        private void btnNextPage_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Image content = ((Button)sender).Content as Image;
            content.Source = this.btnNextPage.IsEnabled ? (new BitmapImage(new Uri("Resources/GoToNextPage_Enabled.png", UriKind.Relative))) : (new BitmapImage(new Uri("Resources/GoToNextPage_Disabled.png", UriKind.Relative)));
        }

        private void btnLastPage_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Image content = ((Button)sender).Content as Image;
            content.Source = this.btnLastPage.IsEnabled ? (new BitmapImage(new Uri("Resources/GoToLastPage_Enabled.png", UriKind.Relative))) : (new BitmapImage(new Uri("Resources/GoToLastPage_Disabled.png", UriKind.Relative)));
        }

        private void btnFirstPage_Click(object sender, RoutedEventArgs e)
        {
            //Go to first page.
            this.pdfDocumentViewer1.GoToFirstPage();
        }

        private void btnPreviousPage_Click(object sender, RoutedEventArgs e)
        {
            //Go To Previous Page
            this.pdfDocumentViewer1.GoToPreviousPage();
        }

        private void btnNextPage_Click(object sender, RoutedEventArgs e)
        {
            //Go to next page.
            this.pdfDocumentViewer1.GoToNextPage();
        }

        private void btnLastPage_Click(object sender, RoutedEventArgs e)
        {
            //Go to last page.
            this.pdfDocumentViewer1.GoToLastPage();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // Load pdf document from file.
                this.pdfDocumentViewer1.LoadFromFile(@"..\..\..\..\..\..\Data\Sample3.pdf");
                this.txtPageCount.Text = this.pdfDocumentViewer1.PageCount.ToString();
                SetbuttonState();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
