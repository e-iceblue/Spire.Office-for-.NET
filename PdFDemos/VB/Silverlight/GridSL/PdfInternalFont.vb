Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports Spire.Pdf.Graphics

Namespace GridSL
    Friend Class PdfInternalFont
        Private internalFont As PdfTrueTypeFont = Nothing

        Public Sub New(ByVal font As Font)
            Using stream As Stream = Me.GetFontStream(font)
                Me.internalFont = New PdfTrueTypeFont(stream, font.Size, font.Style)
            End Using
        End Sub

        Public Sub New(ByVal font As Font, ByVal unicode As Boolean)
            Using stream As Stream = Me.GetFontStream(font)
                Me.internalFont = New PdfTrueTypeFont(stream, font.Size, font.Style)
            End Using
        End Sub

        Public Shared Widening Operator CType(ByVal font As PdfInternalFont) As PdfTrueTypeFont
            Return font.internalFont
        End Operator

        Private Function GetFontStream(ByVal font As Font) As Stream
            Dim fontFileName As [String] = Nothing
            If font.Name = "Arial" Then
                Dim advancedStyle As Integer = CInt(PdfFontStyle.Strikeout Or PdfFontStyle.Underline)
                advancedStyle = advancedStyle And CInt(font.Style)
                Dim normalStyle As Integer _
                    = CInt(PdfFontStyle.Regular Or PdfFontStyle.Bold Or PdfFontStyle.Italic)
                normalStyle = normalStyle And CInt(font.Style)
                Dim style As PdfFontStyle = DirectCast(normalStyle, PdfFontStyle)

                If style = PdfFontStyle.Regular Then
                    fontFileName = "arial.ttf"
                ElseIf style = PdfFontStyle.Bold Then
                    fontFileName = "arialbd.ttf"
                ElseIf style = PdfFontStyle.Italic Then
                    fontFileName = "ariali.ttf"
                ElseIf style = (PdfFontStyle.Bold Or PdfFontStyle.Italic) Then
                    fontFileName = "arialbi.ttf"
                End If
                font.Style = DirectCast(advancedStyle, PdfFontStyle)
            End If

            If fontFileName Is Nothing Then
                Throw New ArgumentException("fontName")
            End If

            Return GetFontStream(fontFileName)
        End Function

        Private Function GetFontStream(ByVal fontFileName As [String]) As Stream
            Dim m_assembly As Assembly = Assembly.GetExecutingAssembly()
            For Each resName As [String] In m_assembly.GetManifestResourceNames()
                If resName.EndsWith(fontFileName) Then
                    Return m_assembly.GetManifestResourceStream(resName)
                End If
            Next
            Return Nothing
        End Function
    End Class
End Namespace
Namespace System.Drawing
    Public Enum FontStyle
        ' Summary:
        '     Normal text.
        Regular = 0
        '
        ' Summary:
        '     Bold text.
        Bold = 1
        '
        ' Summary:
        '     Italic text.
        Italic = 2
        '
        ' Summary:
        '     Underlined text.
        Underline = 4
        '
        ' Summary:
        '     Text with a line through the middle.
        Strikeout = 8
    End Enum

    Public Class Font
        Public Sub New(ByVal name As [String], ByVal size As Single)
            Me.New(name, size, FontStyle.Regular)
        End Sub

        Public Sub New(ByVal name As [String], ByVal size As Single, ByVal style As FontStyle)
            Me.Name = name
            Me.Size = size
            Me.Style = GetPdfFontStyle(style)
        End Sub

        Private Function GetPdfFontStyle(ByVal style As FontStyle) As PdfFontStyle
            Return DirectCast([Enum].Parse(GetType(PdfFontStyle), style.ToString(), False), PdfFontStyle)
        End Function

        Friend Property Name() As [String]
            Get
                Return m_Name
            End Get
            Set(ByVal value As [String])
                m_Name = value
            End Set
        End Property
        Private m_Name As [String]
        Friend Property Size() As Single
            Get
                Return m_Size
            End Get
            Set(ByVal value As Single)
                m_Size = value
            End Set
        End Property
        Private m_Size As Single
        Friend Property Style() As PdfFontStyle
            Get
                Return m_Style
            End Get
            Set(ByVal value As PdfFontStyle)
                m_Style = value
            End Set
        End Property
        Private m_Style As PdfFontStyle
    End Class
End Namespace