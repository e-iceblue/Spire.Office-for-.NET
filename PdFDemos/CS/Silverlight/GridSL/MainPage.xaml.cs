using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using Spire.Pdf;
using Spire.Pdf.Graphics;
using Spire.Pdf.Grid;

namespace GridSL
{
    public partial class MainPage : UserControl
    {
        private List<Vendor> dataSource = null;

        public class Vendor
        {
            public String VendorName { get; set; }
            public String Address { get; set; }
            public String City { get; set; }
            public String State { get; set; }
            public String Country { get; set; }
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private float ConvertUnits(float value, PdfGraphicsUnit fromType, PdfGraphicsUnit toType)
        {
            if (fromType == PdfGraphicsUnit.Centimeter
                && toType == PdfGraphicsUnit.Point)
            {
                return value * 28.34646f;
            }

            throw new ArithmeticException();
        }

        private void buttonRun_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFiledialog = new SaveFileDialog();
            saveFiledialog.Filter = "PDF Document (*.pdf)|*.pdf";
            bool? result = saveFiledialog.ShowDialog();
            if (!result.HasValue || !result.Value)
            {
                return;
            }

            //create a pdf document
            PdfDocument document = new PdfDocument();

            //margin
            PdfMargins margin = new PdfMargins();
            margin.Top = ConvertUnits(1.54f, PdfGraphicsUnit.Centimeter, PdfGraphicsUnit.Point);
            margin.Bottom = margin.Top;
            margin.Left = ConvertUnits(3.17f, PdfGraphicsUnit.Centimeter, PdfGraphicsUnit.Point);
            margin.Right = margin.Left;

            //create one page
            PdfPageBase page
                = document.Pages.Add(PdfPageSize.A4, margin, PdfPageRotateAngle.RotateAngle0,
                PdfPageOrientation.Landscape);
            float y = 0;

            //title
            PdfBrush brush1 = PdfBrushes.Black;
            PdfTrueTypeFont font1
                = new PdfInternalFont(new Font("Arial", 16f, System.Drawing.FontStyle.Bold), true);
            PdfStringFormat format1
                = new PdfStringFormat(PdfTextAlignment.Center);
            page.Canvas.DrawString("Vendor List", font1, brush1, page.Canvas.ClientSize.Width / 2, y, format1);
            y = y + font1.MeasureString("Vendor List", format1).Height;
            y = y + 5;

            PdfGrid grid = new PdfGrid();
            grid.Style.CellPadding = new PdfPaddings(1, 1, 1, 1);
            grid.Columns.Add(this.dataGridVendorList.Columns.Count);

            float width
                = page.Canvas.ClientSize.Width - (grid.Columns.Count + 1);
            grid.Columns[0].Width = width * 0.25f;
            grid.Columns[1].Width = width * 0.25f;
            grid.Columns[2].Width = width * 0.25f;
            grid.Columns[3].Width = width * 0.15f;
            grid.Columns[4].Width = width * 0.10f;

            //header of grid
            PdfGridRow headerRow = grid.Headers.Add(1)[0];
            headerRow.Style.Font
                = new PdfInternalFont(new Font("Arial", 11f, System.Drawing.FontStyle.Bold), true);
            String[] header = { "Vendor Name", "Address", "City", "State", "Country" };
            for (int i = 0; i < header.Length; i++)
            {
                headerRow.Cells[i].Value = header[i];
                headerRow.Cells[i].StringFormat
                    = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);

            }
            headerRow.Style.BackgroundBrush = PdfBrushes.SeaGreen;

            //datarow of grid
            int rowIndex = 1;
            foreach (Vendor vendor in this.dataSource)
            {
                PdfGridRow row = grid.Rows.Add();
                row.Style.Font = new PdfInternalFont(new Font("Arial", 10f), true);
                row.Cells[0].Value = vendor.VendorName;
                row.Cells[1].Value = vendor.Address;
                row.Cells[2].Value = vendor.City;
                row.Cells[3].Value = vendor.State;
                row.Cells[4].Value = vendor.Country;

                row.Cells[0].Style.BackgroundBrush = PdfBrushes.LightGray;
                row.Cells[0].StringFormat = row.Cells[1].StringFormat = row.Cells[2].StringFormat
                    = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle);
                row.Cells[3].StringFormat = row.Cells[4].StringFormat
                    = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
                if (rowIndex % 2 == 0)
                {
                    row.Style.BackgroundBrush = PdfBrushes.YellowGreen;
                }
                else
                {
                    row.Style.BackgroundBrush = PdfBrushes.Bisque;
                }
                rowIndex++;
            }

            StringBuilder totalAmount = new StringBuilder();

            var groupByCountry
                = this.dataSource.GroupBy(v => v.Country)
                    .Select(g => new { Name = g.Key, Count = g.Count() });

            foreach (var item in groupByCountry)
            {
                totalAmount.AppendFormat("{0}:\t{1}", item.Name, item.Count);
                totalAmount.AppendLine();
            }

            PdfGridRow totalAmountRow = grid.Rows.Add();
            totalAmountRow.Style.BackgroundBrush = PdfBrushes.Plum;
            totalAmountRow.Cells[0].Value = "Total Amount";
            totalAmountRow.Cells[0].Style.Font
                = new PdfInternalFont(new Font("Arial", 10f, System.Drawing.FontStyle.Bold), true);
            totalAmountRow.Cells[0].StringFormat
                = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle);
            totalAmountRow.Cells[1].ColumnSpan = 4;
            totalAmountRow.Cells[1].Value = totalAmount.ToString();
            totalAmountRow.Cells[1].Style.Font
                = new PdfInternalFont(new Font("Arial", 10f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), true);
            totalAmountRow.Cells[1].StringFormat
                = new PdfStringFormat(PdfTextAlignment.Right, PdfVerticalAlignment.Middle);

            PdfLayoutResult resultl = grid.Draw(page, new PointF(0, y));
            y = y + resultl.Bounds.Height + 5;

            PdfBrush brush2 = PdfBrushes.Gray;
            PdfTrueTypeFont font2 = new PdfInternalFont(new Font("Arial", 9f));
            resultl.Page.Canvas.DrawString(String.Format("* All {0} vendors in the list", grid.Rows.Count - 1),
                font2, brush2, 5, y);

            //Save pdf file.
            using (Stream stream = saveFiledialog.OpenFile())
            {
                document.SaveToStream(stream);
            }
            document.Close();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            String[] data
                = {
                    "Cacor Corporation;161 Southfield Rd;Southfield;OH;U.S.A.",
                    "Underwater;50 N 3rd Street;Indianapolis;IN;U.S.A.",
                    "J.W.  Luscher Mfg.;65 Addams Street;Berkely;MA;U.S.A.",
                    "Scuba Professionals;3105 East Brace;Rancho Dominguez;CA;U.S.A.",
                    "Divers'  Supply Shop;5208 University Dr;Macon;GA;U.S.A.",
                    "Techniques;52 Dolphin Drive;Redwood City;CA;U.S.A.",
                    "Perry Scuba;3443 James Ave;Hapeville;GA;U.S.A.",
                    "Beauchat, Inc.;45900 SW 2nd Ave;Ft Lauderdale;FL;U.S.A.",
                    "Amor Aqua;42 West 29th Street;New York;NY;U.S.A.",
                    "Aqua Research Corp.;P.O. Box 998;Cornish;NH;U.S.A.",
                    "B&K Undersea Photo;116 W 7th Street;New York;NY;U.S.A.",
                    "Diving International Unlimited;1148 David Drive;San Diego;DA;U.S.A.",
                    "Nautical Compressors;65 NW 167 Street;Miami;FL;U.S.A.",
                    "Glen Specialties, Inc.;17663 Campbell Lane;Huntington Beach;CA;U.S.A.",
                    "Dive Time;20 Miramar Ave;Long Beach;CA;U.S.A.",
                    "Undersea Systems, Inc.;18112 Gotham Street;Huntington Beach;CA;U.S.A.",
                    "Felix Diving;310 S Michigan Ave;Chicago;IL;U.S.A.",
                    "Central Valley Skin Divers;160 Jameston Ave;Jamaica;NY;U.S.A.",
                    "Parkway Dive Shop;241 Kelly Street;South Amboy;NJ;U.S.A.",
                    "Marine Camera & Dive;117 South Valley Rd;San Diego;CA;U.S.A.",
                    "Dive Canada;275 W Ninth Ave;Vancouver;British Columbia;Canada",
                    "Dive & Surf;P.O. Box 20210;Indianapolis;IN;U.S.A.",
                    "Fish Research Labs;29 Wilkins Rd Dept. SD;Los Banos;CA;U.S.A."
                };

            List<Vendor> vendorList
                = data.Select(i => i.Split(';'))
                    .Select(a => new Vendor
                    {
                        VendorName = a[0],
                        Address = a[1],
                        City = a[2],
                        State = a[3],
                        Country = a[4]
                    }).ToList();

            this.dataSource = vendorList;
            this.dataGridVendorList.ItemsSource = this.dataSource;

            this.dataGridVendorList.AutoGeneratingColumn
                += delegate(Object obj, DataGridAutoGeneratingColumnEventArgs args)
            {
                if (args.PropertyName == "VendorName")
                {
                    args.Column.Header = "Vendor Name";
                }
            };
        }
    }
}
