using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Spire.Xls;

namespace FontStylesWPF
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
            Worksheet sheet = workbook.Worksheets[0];

            sheet.Range["B1"].Text = "Font setting";
            sheet.Range["B1"].Style.Font.IsBold = true;

            sheet.Range["B3"].Text = "Arial";
            sheet.Range["B3"].Style.Font.FontName = "Arial";

            sheet.Range["B4"].Text = "Large size";
            sheet.Range["B4"].Style.Font.Size = 20;

            sheet.Range["B5"].Text = "Bold";
            sheet.Range["B5"].Style.Font.IsBold = true;

            sheet.Range["B6"].Text = "Italic";
            sheet.Range["B6"].Style.Font.IsItalic = true;

            sheet.Range["B7"].Text = "Superscript";
            sheet.Range["B7"].Style.Font.IsSuperscript = true;

            sheet.Range["B8"].Text = "Colored";
            sheet.Range["B8"].Style.Font.Color = System.Drawing.Color.FromArgb(255, 125, 125);

            sheet.Range["B9"].Text = "Underline";
            sheet.Range["B9"].Style.Font.Underline = FontUnderlineType.Single;

            sheet.AutoFitColumn(2);

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
                MessageBox.Show(e.Message, "information", MessageBoxButton.OK);
            }
        }
    }
}
