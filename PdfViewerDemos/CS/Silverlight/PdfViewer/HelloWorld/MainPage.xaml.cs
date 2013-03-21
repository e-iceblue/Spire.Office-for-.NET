using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Resources;

namespace HelloWorld
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            StreamResourceInfo resource = Application.GetResourceStream(new Uri("HelloWorld;component/SPireDoc.pdf", UriKind.Relative));
            this.pdfViewer1.LoadFromStream(resource.Stream);
        }
    }
}
