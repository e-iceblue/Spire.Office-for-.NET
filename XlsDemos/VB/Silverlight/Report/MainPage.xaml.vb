Imports System
Imports System.IO
Imports System.Net
Imports System.Reflection
Imports System.Windows
Imports System.Windows.Controls

Imports Spire.Xls

Partial Public Class MainPage
    Inherits UserControl

    Public Class Country
        Public Property Name() As [String]
            Get
                Return m_Name
            End Get
            Set(ByVal value As [String])
                m_Name = Value
            End Set
        End Property
        Private m_Name As [String]
        Public Property Capital() As [String]
            Get
                Return m_Capital
            End Get
            Set(ByVal value As [String])
                m_Capital = Value
            End Set
        End Property
        Private m_Capital As [String]
        Public Property Continent() As [String]
            Get
                Return m_Continent
            End Get
            Set(ByVal value As [String])
                m_Continent = Value
            End Set
        End Property
        Private m_Continent As [String]
        Public Property Area() As Double
            Get
                Return m_Area
            End Get
            Set(ByVal value As Double)
                m_Area = Value
            End Set
        End Property
        Private m_Area As Double
        Public Property Population() As Long
            Get
                Return m_Population
            End Get
            Set(ByVal value As Long)
                m_Population = Value
            End Set
        End Property
        Private m_Population As Long
    End Class

    Private saveFileDialog As SaveFileDialog = Nothing
    Private dataSource As List(Of Country) = Nothing
    Private xlsTemplate As Workbook = Nothing

    Public Sub New()
        InitializeComponent()
        Me.saveFileDialog = New SaveFileDialog()
        Me.saveFileDialog.Filter = "Excel workbooks (*.xls) |*.xls"
    End Sub

    Private Sub LayoutRoot_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        Dim assembly As Assembly = Me.[GetType]().Assembly
        For Each name As [String] In assembly.GetManifestResourceNames()
            If name.EndsWith(".DatatableSample.xls") Then
                Using stream As Stream = assembly.GetManifestResourceStream(name)
                    Dim workbook As New Workbook()
                    workbook.LoadFromStream(stream)
                    Dim sheet As Worksheet = workbook.Worksheets(0)

                    Me.dataSource = New List(Of Country)()
                    For Each row As CellRange In sheet.Rows
                        If row IsNot Nothing AndAlso row.Cells IsNot Nothing AndAlso row.Cells.Length = 5 AndAlso Not row.Cells(0).IsBlank Then
                            If row.Cells(0).Row = 1 Then
                                Continue For
                            End If
                            Me.dataSource.Add(New Country() With { _
                             .Name = row.Cells(0).Value, _
                             .Capital = row.Cells(1).Value, _
                             .Continent = row.Cells(2).Value, _
                             .Area = row.Cells(3).NumberValue, _
                             .Population = Convert.ToInt64(row.Cells(4).NumberValue) _
                            })
                        Else
                            Exit For
                        End If
                    Next
                    Me.dataGrid.ItemsSource = Me.dataSource
                End Using
                Me.buttonGenerate.IsEnabled = True
            ElseIf name.EndsWith(".MarkerDesignerSample.xls") Then
                Using stream As Stream = assembly.GetManifestResourceStream(name)
                    Me.xlsTemplate = New Workbook()
                    Me.xlsTemplate.LoadFromStream(stream)
                End Using
            End If
        Next
    End Sub

    Private Sub buttonGenerate_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        Dim worksheet As Worksheet = Me.xlsTemplate.Worksheets(0)

        Me.xlsTemplate.MarkerDesigner.AddParameter("Variable1", 1234.5678)
        Me.xlsTemplate.MarkerDesigner.AddArray("Country", dataSource.ToArray())
        Me.xlsTemplate.MarkerDesigner.Apply()

        worksheet.AllocatedRange.AutoFitRows()
        worksheet.AllocatedRange.AutoFitColumns()

        Dim result As System.Nullable(Of Boolean) = Me.saveFileDialog.ShowDialog()
        If result.HasValue AndAlso result.Value Then
            Using stream As Stream = Me.saveFileDialog.OpenFile()
                Me.xlsTemplate.SaveToStream(stream)
            End Using
        End If
    End Sub
End Class