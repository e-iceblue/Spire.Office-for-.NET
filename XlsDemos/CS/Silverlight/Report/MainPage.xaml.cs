using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

using Spire.Xls;

namespace Report
{
    public partial class MainPage : UserControl
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
        private Workbook template = null;
        public MainPage()
        {
            InitializeComponent();
            this.saveFileDialog = new SaveFileDialog();
            this.saveFileDialog.Filter = "Excel workbooks (*.xls) |*.xls";
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            Assembly assembly = this.GetType().Assembly;
            foreach (String name in assembly.GetManifestResourceNames())
            {
                if (name.EndsWith(".DatatableSample.xls"))
                {
                    using (Stream stream = assembly.GetManifestResourceStream(name))
                    {
                        Workbook workbook = new Workbook();
                        workbook.LoadFromStream(stream);
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
                    this.buttonGenerate.IsEnabled = true;
                }
                else if(name.EndsWith(".MarkerDesignerSample.xls"))
                {
                    using (Stream stream = assembly.GetManifestResourceStream(name))
                    {
                        this.template = new Workbook();
                        this.template.LoadFromStream(stream);
                    }
                }
            }
        }

        private void buttonGenerate_Click(object sender, RoutedEventArgs e)
        {
            Worksheet worksheet = this.template.Worksheets[0];

            this.template.MarkerDesigner.AddParameter("Variable1", 1234.5678);
            this.template.MarkerDesigner.AddArray("Country", dataSource.ToArray());
            this.template.MarkerDesigner.Apply();

            worksheet.AllocatedRange.AutoFitRows();
            worksheet.AllocatedRange.AutoFitColumns();

            bool? result = this.saveFileDialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                using (Stream stream = this.saveFileDialog.OpenFile())
                {
                    this.template.SaveToStream(stream);
                }
            }
        }
    }
}
