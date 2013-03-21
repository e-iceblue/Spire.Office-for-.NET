Imports System.Drawing
Imports System.IO
Imports System.Text
Imports Spire.Pdf
Imports Spire.Pdf.Graphics
Imports Spire.Pdf.Grid

Namespace GridSL
    Partial Public Class MainPage
        Inherits UserControl

        Private dataSource As List(Of Vendor) = Nothing

        Public Class Vendor

            Private m_VendorName As [String]
            Private m_Address As [String]
            Private m_City As [String]
            Private m_State As [String]
            Private m_Country As [String]

            Public Property VendorName() As [String]
                Get
                    Return m_VendorName
                End Get
                Set(ByVal value As [String])
                    m_VendorName = value
                End Set
            End Property

            Public Property Address() As [String]
                Get
                    Return m_Address
                End Get
                Set(ByVal value As [String])
                    m_Address = value
                End Set
            End Property

            Public Property City() As [String]
                Get
                    Return m_City
                End Get
                Set(ByVal value As [String])
                    m_City = value
                End Set
            End Property

            Public Property State() As [String]
                Get
                    Return m_State
                End Get
                Set(ByVal value As [String])
                    m_State = value
                End Set
            End Property

            Public Property Country() As [String]
                Get
                    Return m_Country
                End Get
                Set(ByVal value As [String])
                    m_Country = value
                End Set
            End Property
        End Class

        Public Sub New()
            InitializeComponent()
        End Sub


        Private Function ConvertUnits(ByVal value As Single, ByVal fromType As PdfGraphicsUnit, ByVal toType As PdfGraphicsUnit) As Single
            If fromType = PdfGraphicsUnit.Centimeter AndAlso toType = PdfGraphicsUnit.Point Then
                Return value * 28.34646F
            End If

            Throw New ArithmeticException()
        End Function

        Private Sub buttonRun_Click(ByVal sender As Object, ByVal e As RoutedEventArgs) Handles buttonRub.Click
            Dim saveFiledialog As New SaveFileDialog()
            saveFiledialog.Filter = "PDF Document (*.pdf)|*.pdf"
            Dim result As Global.System.Nullable(Of Boolean) = saveFiledialog.ShowDialog()
            If Not result.HasValue Or Not result.Value Then
                Return
            End If

            'create a pdf document
            Dim document As New PdfDocument()

            'margin
            Dim margin As New PdfMargins()
            margin.Top = ConvertUnits(1.54F, PdfGraphicsUnit.Centimeter, PdfGraphicsUnit.Point)
            margin.Bottom = margin.Top
            margin.Left = ConvertUnits(3.17F, PdfGraphicsUnit.Centimeter, PdfGraphicsUnit.Point)
            margin.Right = margin.Left

            'create one page
            Dim page As PdfPageBase _
                = document.Pages.Add(PdfPageSize.A4, margin, PdfPageRotateAngle.RotateAngle0, PdfPageOrientation.Landscape)
            Dim y As Single = 0

            'title
            Dim brush1 As PdfBrush = PdfBrushes.Black
            Dim font1 As PdfTrueTypeFont = _
                New PdfInternalFont(New Font("Arial", 16.0F, System.Drawing.FontStyle.Bold), True)
            Dim format1 As New PdfStringFormat(PdfTextAlignment.Center)
            page.Canvas.DrawString("Vendor List", font1, brush1, page.Canvas.ClientSize.Width / 2, y, format1)
            y = y + font1.MeasureString("Vendor List", format1).Height
            y = y + 5

            Dim grid As New PdfGrid()
            grid.Style.CellPadding = New PdfPaddings(1, 1, 1, 1)
            grid.Columns.Add(Me.dataGridVendorList.Columns.Count)

            Dim width As Single = page.Canvas.ClientSize.Width - (grid.Columns.Count + 1)
            grid.Columns(0).Width = width * 0.25F
            grid.Columns(1).Width = width * 0.25F
            grid.Columns(2).Width = width * 0.25F
            grid.Columns(3).Width = width * 0.15F
            grid.Columns(4).Width = width * 0.1F

            'header of grid
            Dim headerRow As PdfGridRow = grid.Headers.Add(1)(0)
            headerRow.Style.Font _
                = New PdfInternalFont(New Font("Arial", 11.0F, System.Drawing.FontStyle.Bold), True)
            Dim header As [String]() = {"Vendor Name", "Address", "City", "State", "Country"}
            For i As Integer = 0 To header.Length - 1
                headerRow.Cells(i).Value = header(i)

                headerRow.Cells(i).StringFormat _
                    = New PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle)
            Next
            headerRow.Style.BackgroundBrush = PdfBrushes.SeaGreen

            'datarow of grid
            Dim rowIndex As Integer = 1
            For Each vendor As Vendor In Me.dataSource
                Dim row As PdfGridRow = grid.Rows.Add()
                row.Style.Font = New PdfInternalFont(New Font("Arial", 10.0F), True)
                row.Cells(0).Value = vendor.VendorName
                row.Cells(1).Value = vendor.Address
                row.Cells(2).Value = vendor.City
                row.Cells(3).Value = vendor.State
                row.Cells(4).Value = vendor.Country

                row.Cells(0).Style.BackgroundBrush = PdfBrushes.LightGray
                row.Cells(0).StringFormat _
                    = New PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle)
                row.Cells(1).StringFormat = row.Cells(0).StringFormat
                row.Cells(2).StringFormat = row.Cells(0).StringFormat

                row.Cells(3).StringFormat _
                    = New PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle)
                row.Cells(4).StringFormat = row.Cells(3).StringFormat

                If rowIndex Mod 2 = 0 Then
                    row.Style.BackgroundBrush = PdfBrushes.YellowGreen
                Else
                    row.Style.BackgroundBrush = PdfBrushes.Bisque
                End If
                rowIndex += 1
            Next

            Dim totalAmount As New StringBuilder()

            Dim groupByCountry _
                = Me.dataSource.GroupBy(Function(v) v.Country).[Select](Function(g) New With { _
                    Key .Name = g.Key, _
                    Key .Count = g.Count() _
                })

            For Each item In groupByCountry
                totalAmount.AppendFormat("{0}:" & vbTab & "{1}", item.Name, item.Count)
                totalAmount.AppendLine()
            Next

            Dim totalAmountRow As PdfGridRow = grid.Rows.Add()
            totalAmountRow.Style.BackgroundBrush = PdfBrushes.Plum
            totalAmountRow.Cells(0).Value = "Total Amount"
            totalAmountRow.Cells(0).Style.Font = New PdfInternalFont(New Font("Arial", 10.0F, System.Drawing.FontStyle.Bold), True)
            totalAmountRow.Cells(0).StringFormat = New PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle)
            totalAmountRow.Cells(1).ColumnSpan = 4
            totalAmountRow.Cells(1).Value = totalAmount.ToString()
            totalAmountRow.Cells(1).Style.Font = New PdfInternalFont(New Font("Arial", 10.0F, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), True)
            totalAmountRow.Cells(1).StringFormat = New PdfStringFormat(PdfTextAlignment.Right, PdfVerticalAlignment.Middle)

            Dim resultl As PdfLayoutResult = grid.Draw(page, New PointF(0, y))
            y = y + resultl.Bounds.Height + 5

            Dim brush2 As PdfBrush = PdfBrushes.Gray
            Dim font2 As PdfTrueTypeFont = New PdfInternalFont(New Font("Arial", 9.0F))
            resultl.Page.Canvas.DrawString([String].Format("* All {0} vendors in the list", grid.Rows.Count - 1), font2, brush2, 5, y)

            'Save pdf file.
            Using stream As Stream = saveFiledialog.OpenFile()
                document.SaveToStream(stream)
            End Using
            document.Close()
        End Sub

        Private Sub UserControl_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs) Handles MyBase.Loaded
            Dim data As [String]() _
                = New String() {
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
                }

            Dim vendorList As List(Of Vendor) _
                = data.[Select](Function(i) i.Split(";"c)).[Select](Function(a) New Vendor() With {
             .VendorName = a(0),
             .Address = a(1),
             .City = a(2),
             .State = a(3),
             .Country = a(4)
            }).ToList()

            Me.dataSource = vendorList
            Me.dataGridVendorList.ItemsSource = Me.dataSource
        End Sub

        Private Sub ChangePropertyName(ByVal obj As [Object], ByVal args As DataGridAutoGeneratingColumnEventArgs) Handles dataGridVendorList.AutoGeneratingColumn
            If args.PropertyName = "VendorName" Then
                args.Column.Header = "Vendor Name"
            End If
        End Sub
    End Class
End Namespace
