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
using Spire.Xls;
using Spire.Xls.Charts;
using Microsoft.Win32;
namespace EditSheetWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            Workbook workbook = new Workbook();

            //Load workbook from disk.
            workbook.LoadFromFile(@"..\..\..\..\..\Data\EditSheetSample.xls");
            //Initailize worksheet
            Worksheet sheet = workbook.Worksheets[0];

            //Writes string
            sheet.Range["B1"].Text = "Hello,World!";
            //Writes number
            sheet.Range["B2"].NumberValue = 1234.5678;
            //Writes date
            sheet.Range["B3"].DateTimeValue = System.DateTime.Now;
            //Writes formula
            sheet.Range["B4"].Formula = "=1111*11111";
            sheet.Range["B5"].Value = "ABCDEFG";
            workbook.SaveToFile("Sample.xls");
            ExcelDocViewer(workbook.FileName);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ExcelDocViewer(string fileName)
        {
            try
            {
                System.Diagnostics.Process.Start(fileName);
            }
            catch (Exception e)
            {
               MessageBox.Show(e.Message,"information",MessageBoxButton.OK);
            }
        }
    }
}
