using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.IO;
using System.Windows.Media.Imaging;
using System.Windows.Resources;

namespace Paging
{
    public partial class MainPage : UserControl
    {
        private bool m_canFirstPage = false;
        private bool m_canNextPage = false;
        private bool m_canPreviousPage = false;
        private bool m_canLastPage = false;

        public MainPage()
        {
            InitializeComponent();

            this.pdfDocumentViewer1.PageNumberChanged += new Spire.PdfViewer.PageNumberChangedEventHandler(pdfDocumentViewer1_PageNumberChanged);
            this.btnGotoFirst.IsEnabled = this.m_canFirstPage;
            this.btnGotoLast.IsEnabled = this.m_canLastPage;
            this.btnGotoNext.IsEnabled = this.m_canNextPage;
            this.btnGotoPre.IsEnabled = this.m_canPreviousPage;
        }

        void pdfDocumentViewer1_PageNumberChanged(object sender, EventArgs args)
        {
            int currentNum = this.pdfDocumentViewer1.CurrentPageNumber;
            int result = 0;
            int.TryParse(txtCurrentPageIndex.Text, out result);
            if (currentNum != result && result > 0)
            {
                SetButtonState();
            }
            this.txtCurrentPageIndex.Text = currentNum.ToString();
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
                    this.txtPageCount.Text = this.pdfDocumentViewer1.PageCount.ToString();
                    SetButtonState();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
                }
            }
        }

        private void btnGotoFirst_Click(object sender, RoutedEventArgs e)
        {
            //go to first page
            this.pdfDocumentViewer1.GoToFirstPage();
        }

        private void btnGotoPre_Click(object sender, RoutedEventArgs e)
        {
            //go to previous page
            this.pdfDocumentViewer1.GoToPreviousPage();
        }

        private void btnGotoNext_Click(object sender, RoutedEventArgs e)
        {
            //go to next page
            this.pdfDocumentViewer1.GoToNextPage();
        }

        private void btnGotoLast_Click(object sender, RoutedEventArgs e)
        {
            //go to last page
            this.pdfDocumentViewer1.GoToLastPage();
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
            m_canPreviousPage = false;
            m_canNextPage = false;
            m_canLastPage = false;
        }

        private void SetButtonState()
        {
            buttonStatesChanged();
            this.btnGotoFirst.IsEnabled = this.m_canFirstPage;
            this.btnGotoLast.IsEnabled = this.m_canLastPage;
            this.btnGotoNext.IsEnabled = this.m_canNextPage;
            this.btnGotoPre.IsEnabled = this.m_canPreviousPage;
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

        private void btnFirst_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Image content = ((Button)sender).Content as Image;
            content.Source = this.btnGotoFirst.IsEnabled ? (new BitmapImage(new Uri("Resource/GotoFirstPage_Enabled.png", UriKind.Relative))) : (new BitmapImage(new Uri("Resource/GotoFirstPage_Disabled.png", UriKind.Relative)));
        }

        private void btnPre_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Image content = ((Button)sender).Content as Image;
            content.Source = this.btnGotoPre.IsEnabled ? (new BitmapImage(new Uri("Resource/GotoPreviousPage_Enabled.png", UriKind.Relative))) : (new BitmapImage(new Uri("Resource/GotoPreviousPage_Disabled.png", UriKind.Relative)));
        }

        private void btnNext_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Image content = ((Button)sender).Content as Image;
            content.Source = this.btnGotoNext.IsEnabled ? (new BitmapImage(new Uri("Resource/GotoNextPage_Enabled.png", UriKind.Relative))) : (new BitmapImage(new Uri("Resource/GotoNextPage_Disabled.png", UriKind.Relative)));
        }

        private void btnLast_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Image content = ((Button)sender).Content as Image;
            content.Source = this.btnGotoLast.IsEnabled ? (new BitmapImage(new Uri("Resource/GotoLastPage_Enabled.png", UriKind.Relative))) : (new BitmapImage(new Uri("Resource/GotoLastPage_Disabled.png", UriKind.Relative)));
        }

        private void chkHandTool_Click(object sender, RoutedEventArgs e)
        {
            this.pdfDocumentViewer1.EnableHandTools = this.chkHandTool.IsChecked.Value;
        }

        private void txtCurrentPageIndex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key == Key.Enter || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
            {
                if (e.Key == Key.Enter)
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

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            StreamResourceInfo resource = Application.GetResourceStream(new Uri("Paging;component/Sample.pdf", UriKind.Relative));
            this.pdfDocumentViewer1.LoadFromStream(resource.Stream);
            this.txtPageCount.Text = this.pdfDocumentViewer1.PageCount.ToString();
            SetButtonState();
        }
    }
}
