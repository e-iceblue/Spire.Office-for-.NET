using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

using Spire.Doc;

namespace MailMergeSL
{
    public partial class MainPage : UserControl
    {
        private SaveFileDialog saveFileDialog = null;
        private Document documentTemplate = null;
        public MainPage()
        {
            InitializeComponent();
            this.saveFileDialog = new SaveFileDialog();
            this.saveFileDialog.Filter = "Word Document (*.doc)|*.doc";
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            Uri baseUri = App.Current.Host.Source;
            if ("file" == baseUri.Scheme)
            {
                Assembly assembly = this.GetType().Assembly;
                foreach (String name in assembly.GetManifestResourceNames())
                {
                    if (name.EndsWith(".Fax.doc"))
                    {
                        using (Stream docStream = assembly.GetManifestResourceStream(name))
                        {
                            this.documentTemplate = new Document(docStream, FileFormat.Doc);
                        }
                        this.buttonMerge.IsEnabled = true;
                    }
                }
            }
            else
            {
                Uri docUri = new Uri(baseUri, "../Fax.doc");

                WebClient webClient = new WebClient();
                webClient.AllowReadStreamBuffering = true;
                webClient.OpenReadAsync(docUri);
                webClient.OpenReadCompleted += delegate(object eventSender, OpenReadCompletedEventArgs eventArgs)
                {
                    using (Stream docStream = eventArgs.Result)
                    {
                        this.documentTemplate = new Document(docStream, FileFormat.Doc);
                    }
                    this.buttonMerge.IsEnabled = true;
                };
            }
        }

        private void buttonMerge_Click(object sender, RoutedEventArgs e)
        {
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
            this.documentTemplate.MailMerge.Execute(fieldNames, fieldValues);

            bool? result = this.saveFileDialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                using (Stream stream = this.saveFileDialog.OpenFile())
                {
                    this.documentTemplate.SaveToStream(stream, FileFormat.Doc);
                }
            }
        }
    }
}
