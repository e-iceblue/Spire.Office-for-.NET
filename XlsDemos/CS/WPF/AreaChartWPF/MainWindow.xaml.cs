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
using Spire.Xls.Charts;
using System.Drawing;
using System.Data;
using System.Collections.ObjectModel;
namespace AreaChartWPF
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

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            Workbook workbook = new Workbook();

            //Initailize worksheet
            workbook.CreateEmptySheets(1);
            Worksheet sheet = workbook.Worksheets[0];
            sheet.Name = "Chart data";
            sheet.GridLinesVisible = false;

            //Writes chart data
            CreateChartData(sheet);
            //Add a new  chart worsheet to workbook
            Chart chart = sheet.Charts.Add();

            //Set region of chart data
            chart.DataRange = sheet.Range["A1:C5"];
            chart.SeriesDataFromRange = false;

            //Set position of chart
            chart.LeftColumn = 1;
            chart.TopRow = 7;
            chart.RightColumn = 11;
            chart.BottomRow = 30;
            
            if (chk3D.IsChecked==true)
            {
                chart.ChartType = ExcelChartType.Area3D;
            }
            else
            {
                chart.ChartType = ExcelChartType.Area;
            }

            //Chart title area
            chart.ChartTitle = "Sales market by country";
            chart.ChartTitleArea.IsBold = true;
            chart.ChartTitleArea.Size = 12;

            chart.PrimaryCategoryAxis.Title = "Country";
            chart.PrimaryCategoryAxis.Font.IsBold = true;
            chart.PrimaryCategoryAxis.TitleArea.IsBold = true;

            chart.PrimaryValueAxis.Title = "Sales(in Dollars)";
            chart.PrimaryValueAxis.HasMajorGridLines = true;
            chart.PrimaryValueAxis.TitleArea.TextRotationAngle = 90;
            chart.PrimaryValueAxis.MinValue = 1000;
            chart.PrimaryValueAxis.TitleArea.IsBold = true;

            foreach (Spire.Xls.Charts.ChartSerie cs in chart.Series)
            {
                cs.Format.Options.IsVaryColor = true;
                cs.DataPoints.DefaultDataPoint.DataLabels.HasValue = true;
            }

            chart.Legend.Position = LegendPositionType.Top;
            workbook.SaveToFile("Sample.xls");
            ExcelDocViewer(workbook.FileName);
        }
        private void CreateChartData(Worksheet sheet)
        {
            //Country
            sheet.Range["A1"].Value = "Country";
            sheet.Range["A2"].Value = "Cuba";
            sheet.Range["A3"].Value = "Mexico";
            sheet.Range["A4"].Value = "France";
            sheet.Range["A5"].Value = "German";
            //Jun
            sheet.Range["B1"].Value = "Jun";
            sheet.Range["B2"].NumberValue = 6000;
            sheet.Range["B3"].NumberValue = 8000;
            sheet.Range["B4"].NumberValue = 9000;
            sheet.Range["B5"].NumberValue = 8500;

            //Jun
            sheet.Range["C1"].Value = "Aug";
            sheet.Range["C2"].NumberValue = 3000;
            sheet.Range["C3"].NumberValue = 10000;
            sheet.Range["C4"].NumberValue = 2300;
            sheet.Range["C5"].NumberValue = 4200;

            //Style
            sheet.Range["A1:C1"].Style.Font.IsBold = true;
            sheet.Range["A2:C2"].Style.KnownColor = ExcelColors.LightYellow;
            sheet.Range["A3:C3"].Style.KnownColor = ExcelColors.LightGreen1;
            sheet.Range["A4:C4"].Style.KnownColor = ExcelColors.LightOrange;
            sheet.Range["A5:C5"].Style.KnownColor = ExcelColors.LightTurquoise;

            //Border
            sheet.Range["A1:C5"].Style.Borders[BordersLineType.EdgeTop].Color = Color.FromArgb(0, 0, 128);
            sheet.Range["A1:C5"].Style.Borders[BordersLineType.EdgeTop].LineStyle = LineStyleType.Thin;
            sheet.Range["A1:C5"].Style.Borders[BordersLineType.EdgeBottom].Color = Color.FromArgb(0, 0, 128);
            sheet.Range["A1:C5"].Style.Borders[BordersLineType.EdgeBottom].LineStyle = LineStyleType.Thin;
            sheet.Range["A1:C5"].Style.Borders[BordersLineType.EdgeLeft].Color = Color.FromArgb(0, 0, 128);
            sheet.Range["A1:C5"].Style.Borders[BordersLineType.EdgeLeft].LineStyle = LineStyleType.Thin;
            sheet.Range["A1:C5"].Style.Borders[BordersLineType.EdgeRight].Color = Color.FromArgb(0, 0, 128);
            sheet.Range["A1:C5"].Style.Borders[BordersLineType.EdgeRight].LineStyle = LineStyleType.Thin;

            sheet.Range["B2:C5"].Style.NumberFormat = "\"$\"#,##0";
        }
        private void ExcelDocViewer(string fileName)
        {
            try
            {
                System.Diagnostics.Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "information", MessageBoxButton.OK);
            }
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
