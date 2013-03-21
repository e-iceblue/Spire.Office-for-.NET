using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;
using Spire.Doc;



namespace MailMergeWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SaveFileDialog saveFileDialog = null;
        public MainWindow()
        {
            InitializeComponent();
            this.saveFileDialog = new SaveFileDialog();
            this.saveFileDialog.Filter = "Word Document (*.doc)|*.doc";
        }
        private void buttonMerge_Click(object sender, RoutedEventArgs e)
        {
            //new Document
            Document doc = new Document();
            doc.LoadFromFile(@"..\..\..\..\..\Data\Fax.doc");

            String[] fieldNames
                = new String[] { "Contact Name", "Fax", "From", "Date", "Subject", "Content" };
            DateTime faxDate
                = this.datePickerFaxDate.SelectedDate.HasValue ?
                    this.datePickerFaxDate.SelectedDate.Value : DateTime.Now;
            String[] fieldValues
                = new String[] 
                {
                    this.textBoxTo.Text,
                    this.textBoxFax.Text,
                    this.textBoxFrom.Text,
                    faxDate.ToShortDateString(),
                    this.textBoxSubject.Text,
                    this.textBoxContent.Text
                };
            doc.MailMerge.Execute(fieldNames, fieldValues);

            bool? result = this.saveFileDialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                using (Stream stream = this.saveFileDialog.OpenFile())
                {
                    doc.SaveToStream(stream, FileFormat.Doc);
					doc.Close();
                }
            }
        }
    }
}
