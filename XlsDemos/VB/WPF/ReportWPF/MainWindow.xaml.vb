Imports System.Text
Imports Spire.Xls
Imports Microsoft.Win32
Imports System.IO
Imports System.Reflection
Imports System.ComponentModel
Imports System.Collections

Namespace ReportWPF
	Public Module Extenders
		<System.Runtime.CompilerServices.Extension> _
		Public Function ToDataTable(Of T)(ByVal items As IEnumerable(Of T)) As DataTable
			' Create the result table, and gather all properties of a T             
			Dim table As New DataTable(GetType(T).Name)
			Dim props() As PropertyInfo = GetType(T).GetProperties(BindingFlags.Public Or BindingFlags.Instance)
			' Add the properties as columns to the datatable     
			For Each prop In props
				Dim propType As Type = prop.PropertyType
				' Is it a nullable type? Get the underlying type          
				If propType.IsGenericType AndAlso propType.GetGenericTypeDefinition().Equals(GetType(Nullable(Of ))) Then
					propType = New NullableConverter(propType).UnderlyingType
				End If
					table.Columns.Add(prop.Name, propType)
			Next prop
			' Add the property values per T as rows to the datatable     
			For Each item In items
				Dim values = New Object(props.Length - 1){}
				For i = 0 To props.Length - 1
					values(i) = props(i).GetValue(item, Nothing)
				Next i
				table.Rows.Add(values)
			Next item
			Return table
		End Function
	End Module
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Class Country
			Public Property Name() As String
			Public Property Capital() As String
			Public Property Continent() As String
			Public Property Area() As Double
			Public Property Population() As Long
		End Class

		Private saveFileDialog As SaveFileDialog = Nothing
		Private dataSource As List(Of Country) = Nothing

		Public Sub New()
			InitializeComponent()
			Me.saveFileDialog = New SaveFileDialog()
			Me.saveFileDialog.Filter = "Excel workbooks (*.xls) |*.xls"
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim workbook As New Workbook()
			workbook.LoadFromFile("..\..\..\..\..\Data\DataTableSample.xls")

			'Initailize worksheet
			Dim sheet As Worksheet = workbook.Worksheets(0)
			Me.dataSource = New List(Of Country)()
			For Each row As CellRange In sheet.Rows
				If row IsNot Nothing AndAlso row.Cells IsNot Nothing AndAlso row.Cells.Length = 5 AndAlso (Not row.Cells(0).IsBlank) Then
					If row.Cells(0).Row = 1 Then
						Continue For
					End If
					Me.dataSource.Add(New Country() With {.Name = row.Cells(0).Value, .Capital = row.Cells(1).Value, .Continent = row.Cells(2).Value, .Area = row.Cells(3).NumberValue, .Population = Convert.ToInt64(row.Cells(4).NumberValue)})
				Else
					Exit For
				End If
			Next row
			Me.dataGrid.ItemsSource = Me.dataSource
		End Sub

		Private Sub buttonGenerate_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim workbook As New Workbook()

			'Initailize worksheet
			Dim sheet As Worksheet = workbook.Worksheets(0)
			sheet.Name = "Country"
			Dim itemsSource As IEnumerable(Of Country) = Me.dataGrid.ItemsSource.OfType(Of Country)()
			Dim dt As DataTable = Extenders.ToDataTable(Of Country)(itemsSource)
			sheet.InsertDataTable(dt, True, 2, 1, -1, -1)

			'Sets body style
			Dim oddStyle As CellStyle = workbook.Styles.Add("oddStyle")
			oddStyle.Borders(BordersLineType.EdgeLeft).LineStyle = LineStyleType.Thin
			oddStyle.Borders(BordersLineType.EdgeRight).LineStyle = LineStyleType.Thin
			oddStyle.Borders(BordersLineType.EdgeTop).LineStyle = LineStyleType.Thin
			oddStyle.Borders(BordersLineType.EdgeBottom).LineStyle = LineStyleType.Thin
			oddStyle.KnownColor = ExcelColors.LightGreen1

			Dim evenStyle As CellStyle = workbook.Styles.Add("evenStyle")
			evenStyle.Borders(BordersLineType.EdgeLeft).LineStyle = LineStyleType.Thin
			evenStyle.Borders(BordersLineType.EdgeRight).LineStyle = LineStyleType.Thin
			evenStyle.Borders(BordersLineType.EdgeTop).LineStyle = LineStyleType.Thin
			evenStyle.Borders(BordersLineType.EdgeBottom).LineStyle = LineStyleType.Thin
			evenStyle.KnownColor = ExcelColors.LightTurquoise

			For Each range As CellRange In sheet.AllocatedRange.Rows
				If range.Row Mod 2 = 0 Then
					range.CellStyleName = evenStyle.Name
				Else
					range.CellStyleName = oddStyle.Name
				End If
			Next range

			'Sets header style
			Dim styleHeader As CellStyle = sheet.Rows(0).Style
			styleHeader.Borders(BordersLineType.EdgeLeft).LineStyle = LineStyleType.Thin
			styleHeader.Borders(BordersLineType.EdgeRight).LineStyle = LineStyleType.Thin
			styleHeader.Borders(BordersLineType.EdgeTop).LineStyle = LineStyleType.Thin
			styleHeader.Borders(BordersLineType.EdgeBottom).LineStyle = LineStyleType.Thin
			styleHeader.VerticalAlignment = VerticalAlignType.Center
			styleHeader.KnownColor = ExcelColors.Green
			styleHeader.Font.KnownColor = ExcelColors.White
			styleHeader.Font.IsBold = True

			sheet.Columns(sheet.AllocatedRange.LastColumn - 1).Style.NumberFormat = """$""#,##0"
			sheet.Columns(sheet.AllocatedRange.LastColumn - 2).Style.NumberFormat = """$""#,##0"

			sheet.AllocatedRange.AutoFitColumns()
			sheet.AllocatedRange.AutoFitRows()

			sheet.Rows(0).RowHeight = 20

			Dim result? As Boolean = Me.saveFileDialog.ShowDialog()
			If result.HasValue AndAlso result.Value Then
				Using stream As Stream = Me.saveFileDialog.OpenFile()
					workbook.SaveToStream(stream)
				End Using
			End If
		End Sub


	End Class
End Namespace