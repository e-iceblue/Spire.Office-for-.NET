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
using Microsoft.Win32;
using System.IO;
using System.Data;
using System.Reflection;
using System.ComponentModel;
using System.Collections;

namespace ReportWPF
{
    public static class Extenders
    {
        public static DataTable ToDataTable<T>(this IEnumerable<T> items)
        {
            // Create the result table, and gather all properties of a T             
            DataTable table = new DataTable(typeof(T).Name);
            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            // Add the properties as columns to the datatable     
            foreach (var prop in props)
            {
                Type propType = prop.PropertyType;
                // Is it a nullable type? Get the underlying type          
                if (propType.IsGenericType && propType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
                    propType = new NullableConverter(propType).UnderlyingType; table.Columns.Add(prop.Name, propType);
            }
            // Add the property values per T as rows to the datatable     
            foreach (var item in items)
            {
                var values = new object[props.Length];
                for (var i = 0; i < props.Length; i++)
                    values[i] = props[i].GetValue(item, null);
                table.Rows.Add(values);
            }
            return table;
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Country
        {
            public String Name { get; set; }
            public String Capital { get; set; }
            public String Continent { get; set; }
            public double Area { get; set; }
            public long Population { get; set; }
        }

        private SaveFileDialog saveFileDialog = null;
        private List<Country> dataSource = null;

        public MainWindow()
        {
            InitializeComponent();
            this.saveFileDialog = new SaveFileDialog();
            this.saveFileDialog.Filter = "Excel workbooks (*.xls) |*.xls";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(@"..\..\..\..\..\Data\DataTableSample.xls");

            //Initailize worksheet
            Worksheet sheet = workbook.Worksheets[0];
            this.dataSource = new List<Country>();
            foreach (CellRange row in sheet.Rows)
            {
                if (row != null && row.Cells != null && row.Cells.Length == 5
                    && !row.Cells[0].IsBlank)
                {
                    if (row.Cells[0].Row == 1)
                    {
                        continue;
                    }
                    this.dataSource.Add(new Country()
                    {
                        Name = row.Cells[0].Value,
                        Capital = row.Cells[1].Value,
                        Continent = row.Cells[2].Value,
                        Area = row.Cells[3].NumberValue,
                        Population = Convert.ToInt64(row.Cells[4].NumberValue)
                    });
                }
                else
                {
                    break;
                }
            }
            this.dataGrid.ItemsSource = this.dataSource;
        }

        private void buttonGenerate_Click(object sender, RoutedEventArgs e)
        {
            Workbook workbook = new Workbook();

            //Initailize worksheet
            Worksheet sheet = workbook.Worksheets[0];
            sheet.Name = "Country";
            IEnumerable<Country> itemsSource = this.dataGrid.ItemsSource.OfType<Country>();
            DataTable dt = Extenders.ToDataTable<Country>(itemsSource);
            sheet.InsertDataTable(dt, true, 2, 1, -1, -1);

            //Sets body style
            CellStyle oddStyle = workbook.Styles.Add("oddStyle");
            oddStyle.Borders[BordersLineType.EdgeLeft].LineStyle = LineStyleType.Thin;
            oddStyle.Borders[BordersLineType.EdgeRight].LineStyle = LineStyleType.Thin;
            oddStyle.Borders[BordersLineType.EdgeTop].LineStyle = LineStyleType.Thin;
            oddStyle.Borders[BordersLineType.EdgeBottom].LineStyle = LineStyleType.Thin;
            oddStyle.KnownColor = ExcelColors.LightGreen1;

            CellStyle evenStyle = workbook.Styles.Add("evenStyle");
            evenStyle.Borders[BordersLineType.EdgeLeft].LineStyle = LineStyleType.Thin;
            evenStyle.Borders[BordersLineType.EdgeRight].LineStyle = LineStyleType.Thin;
            evenStyle.Borders[BordersLineType.EdgeTop].LineStyle = LineStyleType.Thin;
            evenStyle.Borders[BordersLineType.EdgeBottom].LineStyle = LineStyleType.Thin;
            evenStyle.KnownColor = ExcelColors.LightTurquoise;

            foreach (CellRange range in sheet.AllocatedRange.Rows)
            {
                if (range.Row % 2 == 0)
                    range.CellStyleName = evenStyle.Name;
                else
                    range.CellStyleName = oddStyle.Name;
            }

            //Sets header style
            CellStyle styleHeader = sheet.Rows[0].Style;
            styleHeader.Borders[BordersLineType.EdgeLeft].LineStyle = LineStyleType.Thin;
            styleHeader.Borders[BordersLineType.EdgeRight].LineStyle = LineStyleType.Thin;
            styleHeader.Borders[BordersLineType.EdgeTop].LineStyle = LineStyleType.Thin;
            styleHeader.Borders[BordersLineType.EdgeBottom].LineStyle = LineStyleType.Thin;
            styleHeader.VerticalAlignment = VerticalAlignType.Center;
            styleHeader.KnownColor = ExcelColors.Green;
            styleHeader.Font.KnownColor = ExcelColors.White;
            styleHeader.Font.IsBold = true;

            sheet.Columns[sheet.AllocatedRange.LastColumn - 1].Style.NumberFormat = "\"$\"#,##0";
            sheet.Columns[sheet.AllocatedRange.LastColumn - 2].Style.NumberFormat = "\"$\"#,##0";

            sheet.AllocatedRange.AutoFitColumns();
            sheet.AllocatedRange.AutoFitRows();

            sheet.Rows[0].RowHeight = 20;

            bool? result = this.saveFileDialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                using (Stream stream = this.saveFileDialog.OpenFile())
                {
                    workbook.SaveToStream(stream);
                }
            }
        }

        
    }
}