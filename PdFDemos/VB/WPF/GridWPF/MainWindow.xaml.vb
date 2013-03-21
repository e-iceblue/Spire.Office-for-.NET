Imports System.Text
Imports Spire.Pdf.Graphics
Imports Microsoft.Win32
Imports Spire.Pdf
Imports Spire.Pdf.Grid
Imports System.IO

Namespace GridWPF
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Private dataSource As List(Of Vendor) = Nothing

		Public Class Vendor
			Public Property VendorName() As String
			Public Property Address() As String
			Public Property City() As String
			Public Property State() As String
			Public Property Country() As String
		End Class

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim data() As String = { "Cacor Corporation;161 Southfield Rd;Southfield;OH;U.S.A.", "Underwater;50 N 3rd Street;Indianapolis;IN;U.S.A.", "J.W.  Luscher Mfg.;65 Addams Street;Berkely;MA;U.S.A.", "Scuba Professionals;3105 East Brace;Rancho Dominguez;CA;U.S.A.", "Divers'  Supply Shop;5208 University Dr;Macon;GA;U.S.A.", "Techniques;52 Dolphin Drive;Redwood City;CA;U.S.A.", "Perry Scuba;3443 James Ave;Hapeville;GA;U.S.A.", "Beauchat, Inc.;45900 SW 2nd Ave;Ft Lauderdale;FL;U.S.A.", "Amor Aqua;42 West 29th Street;New York;NY;U.S.A.", "Aqua Research Corp.;P.O. Box 998;Cornish;NH;U.S.A.", "B&K Undersea Photo;116 W 7th Street;New York;NY;U.S.A.", "Diving International Unlimited;1148 David Drive;San Diego;DA;U.S.A.", "Nautical Compressors;65 NW 167 Street;Miami;FL;U.S.A.", "Glen Specialties, Inc.;17663 Campbell Lane;Huntington Beach;CA;U.S.A.", "Dive Time;20 Miramar Ave;Long Beach;CA;U.S.A.", "Undersea Systems, Inc.;18112 Gotham Street;Huntington Beach;CA;U.S.A.", "Felix Diving;310 S Michigan Ave;Chicago;IL;U.S.A.", "Central Valley Skin Divers;160 Jameston Ave;Jamaica;NY;U.S.A.", "Parkway Dive Shop;241 Kelly Street;South Amboy;NJ;U.S.A.", "Marine Camera & Dive;117 South Valley Rd;San Diego;CA;U.S.A.", "Dive Canada;275 W Ninth Ave;Vancouver;British Columbia;Canada", "Dive & Surf;P.O. Box 20210;Indianapolis;IN;U.S.A.", "Fish Research Labs;29 Wilkins Rd Dept. SD;Los Banos;CA;U.S.A." }

			Dim vendorList As List(Of Vendor) = data.Select(Function(i) i.Split(";"c)).Select(Function(a) New Vendor With {.VendorName = a(0), .Address = a(1), .City = a(2), .State = a(3), .Country = a(4)}).ToList()

			Me.dataSource = vendorList
			Me.dataGridVendorList.ItemsSource = Me.dataSource

			AddHandler Me.dataGridVendorList.AutoGeneratingColumn, Sub(obj As Object, args As DataGridAutoGeneratingColumnEventArgs)
					If args.PropertyName = "VendorName" Then
						args.Column.Header = "Vendor Name"
					End If
			End Sub
		End Sub

		Private Sub buttonRun_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim saveFiledialog As New SaveFileDialog()
			saveFiledialog.Filter = "PDF Document (*.pdf)|*.pdf"
			Dim result? As Boolean = saveFiledialog.ShowDialog()
			If (Not result.HasValue) OrElse (Not result.Value) Then
				Return
			End If

			'create a pdf document
			Dim document As New PdfDocument()
			'margin
			Dim unitCvtr As New PdfUnitConvertor()
			Dim margin As New PdfMargins()
			margin.Top = unitCvtr.ConvertUnits(2.54f, PdfGraphicsUnit.Centimeter, PdfGraphicsUnit.Point)
			margin.Bottom = margin.Top
			margin.Left = unitCvtr.ConvertUnits(3.17f, PdfGraphicsUnit.Centimeter, PdfGraphicsUnit.Point)
			margin.Right = margin.Left


			'create one page
			Dim page As PdfPageBase = document.Pages.Add(PdfPageSize.A4, margin, PdfPageRotateAngle.RotateAngle0, PdfPageOrientation.Landscape)
			Dim y As Single = 0

			'title
			Dim brush1 As PdfBrush = PdfBrushes.Black
            Dim font1 As New PdfTrueTypeFont(New Font("Arial", 16.0F, System.Drawing.FontStyle.Bold), True)
			Dim format1 As New PdfStringFormat(PdfTextAlignment.Center)
			page.Canvas.DrawString("Vendor List", font1, brush1, page.Canvas.ClientSize.Width \ 2, y, format1)
			y = y + font1.MeasureString("Vendor List", format1).Height
			y = y + 5

			Dim grid As New PdfGrid()
			grid.Style.CellPadding = New PdfPaddings(1, 1, 1, 1)
			grid.Columns.Add(Me.dataGridVendorList.Columns.Count)

			Dim width As Single = page.Canvas.ClientSize.Width - (grid.Columns.Count + 1)
			grid.Columns(0).Width = width * 0.25f
			grid.Columns(1).Width = width * 0.25f
			grid.Columns(2).Width = width * 0.25f
			grid.Columns(3).Width = width * 0.15f
			grid.Columns(4).Width = width * 0.10f

			'header of grid
			Dim headerRow As PdfGridRow = grid.Headers.Add(1)(0)
            headerRow.Style.Font = New PdfTrueTypeFont(New Font("Arial", 11.0F, System.Drawing.FontStyle.Bold), True)
			Dim header() As String = { "Vendor Name", "Address", "City", "State", "Country" }
			For i As Integer = 0 To header.Length - 1
				headerRow.Cells(i).Value = header(i)
				headerRow.Cells(i).StringFormat = New PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle)

			Next i
			headerRow.Style.BackgroundBrush = PdfBrushes.SeaGreen

			'datarow of grid
			Dim rowIndex As Integer = 1
			For Each vendor As Vendor In Me.dataSource
				Dim row As PdfGridRow = grid.Rows.Add()
				row.Style.Font = New PdfTrueTypeFont(New Font("Arial", 10f), True)
				row.Cells(0).Value = vendor.VendorName
				row.Cells(1).Value = vendor.Address
				row.Cells(2).Value = vendor.City
				row.Cells(3).Value = vendor.State
				row.Cells(4).Value = vendor.Country

				row.Cells(0).Style.BackgroundBrush = PdfBrushes.LightGray
				row.Cells(2).StringFormat = New PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle)
				row.Cells(1).StringFormat = row.Cells(2).StringFormat
				row.Cells(0).StringFormat = row.Cells(1).StringFormat
				row.Cells(4).StringFormat = New PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle)
				row.Cells(3).StringFormat = row.Cells(4).StringFormat
				If rowIndex Mod 2 = 0 Then
					row.Style.BackgroundBrush = PdfBrushes.YellowGreen
				Else
					row.Style.BackgroundBrush = PdfBrushes.Bisque
				End If
				rowIndex += 1
			Next vendor

			Dim totalAmount As New StringBuilder()

			Dim groupByCountry = Me.dataSource.GroupBy(Function(v) v.Country).Select(Function(g) New With {Key .Name = g.Key, Key .Count = g.Count()})

			For Each item In groupByCountry
				totalAmount.AppendFormat("{0}:" & vbTab & "{1}", item.Name, item.Count)
				totalAmount.AppendLine()
			Next item

			Dim totalAmountRow As PdfGridRow = grid.Rows.Add()
			totalAmountRow.Style.BackgroundBrush = PdfBrushes.Plum
			totalAmountRow.Cells(0).Value = "Total Amount"
            totalAmountRow.Cells(0).Style.Font = New PdfTrueTypeFont(New Font("Arial", 10.0F, System.Drawing.FontStyle.Bold), True)
			totalAmountRow.Cells(0).StringFormat = New PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle)
			totalAmountRow.Cells(1).ColumnSpan = 4
			totalAmountRow.Cells(1).Value = totalAmount.ToString()
            totalAmountRow.Cells(1).Style.Font = New PdfTrueTypeFont(New Font("Arial", 10.0F, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), True)
			   ' = new Font("Arial", 10f, System.Drawing.FontStyle.Bold);
			totalAmountRow.Cells(1).StringFormat = New PdfStringFormat(PdfTextAlignment.Right, PdfVerticalAlignment.Middle)

			Dim resultl As PdfLayoutResult = grid.Draw(page, New PointF(0, y))
			y = y + resultl.Bounds.Height + 5

			Dim brush2 As PdfBrush = PdfBrushes.Gray
			Dim font2 As New PdfTrueTypeFont(New Font("Arial", 9f))
			resultl.Page.Canvas.DrawString(String.Format("* All {0} vendors in the list", grid.Rows.Count - 1), font2, brush2, 5, y)

			'Save pdf file.
			Using stream As Stream = saveFiledialog.OpenFile()
				document.SaveToStream(stream)
			End Using
			document.Close()
		End Sub
	End Class
End Namespace
