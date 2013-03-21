Imports System.Drawing

Imports Spire.Pdf
Imports Spire.Pdf.Graphics

Namespace Spire.WebDemo

	Public Partial Class DefaultForm
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(sender As Object, e As System.EventArgs)
		End Sub

		#Region "Web Form Designer generated code"
		Protected Overrides Sub OnInit(e As EventArgs)
			'
			' CODEGEN: This call is required by the ASP.NET Web Form Designer.
			'
			InitializeComponent()
			MyBase.OnInit(e)
		End Sub

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()

		End Sub
		#End Region

		Protected Sub Button1_Click(sender As Object, e As System.EventArgs)
			'Create a pdf document.
			Dim doc As New PdfDocument()

			' Create one page
			Dim page As PdfPageBase = doc.Pages.Add()

			DrawSpiro(page)
			DrawPath(page)

			'Save to browser
			doc.SaveToHttpResponse("Shape.pdf", Response, HttpReadType.Save)
			doc.Close()
		End Sub

		Private Sub DrawPath(page As PdfPageBase)
			Dim points As PointF() = New PointF(4) {}
			For i As Integer = 0 To points.Length - 1
				Dim x As Single = CSng(Math.Cos(i * 2 * Math.PI / 5))
				Dim y As Single = CSng(Math.Sin(i * 2 * Math.PI / 5))
				points(i) = New PointF(x, y)
			Next
			Dim path As New PdfPath()
			path.AddLine(points(2), points(0))
			path.AddLine(points(0), points(3))
			path.AddLine(points(3), points(1))
			path.AddLine(points(1), points(4))
			path.AddLine(points(4), points(2))

			'save graphics state
			Dim state As PdfGraphicsState = page.Canvas.Save()
			Dim pen As New PdfPen(Color.DeepSkyBlue, 0.02F)
			Dim brush1 As PdfBrush = New PdfSolidBrush(Color.CadetBlue)

			page.Canvas.ScaleTransform(50F, 50F)
			page.Canvas.TranslateTransform(5F, 1.2F)
			page.Canvas.DrawPath(pen, path)

			page.Canvas.TranslateTransform(2F, 0F)
			path.FillMode = PdfFillMode.Alternate
			page.Canvas.DrawPath(pen, brush1, path)

			page.Canvas.TranslateTransform(2F, 0F)
			path.FillMode = PdfFillMode.Winding
			page.Canvas.DrawPath(pen, brush1, path)

			Dim brush2 As New PdfLinearGradientBrush(New PointF(-2, 0), New PointF(2, 0), Color.Red, Color.Blue)
			page.Canvas.TranslateTransform(-4F, 2F)
			path.FillMode = PdfFillMode.Alternate
			page.Canvas.DrawPath(pen, brush2, path)

			Dim brush3 As New PdfRadialGradientBrush(New PointF(0F, 0F), 0F, New PointF(0F, 0F), 1F, Color.Red, Color.Blue)
			page.Canvas.TranslateTransform(2F, 0F)
			path.FillMode = PdfFillMode.Winding
			page.Canvas.DrawPath(pen, brush3, path)

			Dim brush4 As New PdfTilingBrush(New RectangleF(0, 0, 4F, 4F))
			brush4.Graphics.DrawRectangle(brush2, 0, 0, 4F, 4F)

			page.Canvas.TranslateTransform(2F, 0F)
			path.FillMode = PdfFillMode.Winding
			page.Canvas.DrawPath(pen, brush4, path)

			'restor graphics
			page.Canvas.Restore(state)
		End Sub

		Private Sub DrawSpiro(page As PdfPageBase)
			'save graphics state
			Dim state As PdfGraphicsState = page.Canvas.Save()

			'Draw shap - spiro
			Dim pen As PdfPen = PdfPens.DeepSkyBlue

			Dim nPoints As Integer = 1000
			Dim r1 As Double = 30
			Dim r2 As Double = 25
			Dim p As Double = 35
			Dim x1 As Double = r1 + r2 - p
			Dim y1 As Double = 0
			Dim x2 As Double = 0
			Dim y2 As Double = 0

			page.Canvas.TranslateTransform(100, 100)

			For i As Integer = 0 To nPoints - 1
				Dim t As Double = i * Math.PI / 90
				x2 = (r1 + r2) * Math.Cos(t) - p * Math.Cos((r1 + r2) * t / r2)
				y2 = (r1 + r2) * Math.Sin(t) - p * Math.Sin((r1 + r2) * t / r2)
				page.Canvas.DrawLine(pen, CSng(x1), CSng(y1), CSng(x2), CSng(y2))
				x1 = x2
				y1 = y2
			Next

			'restor graphics
			page.Canvas.Restore(state)
		End Sub
	End Class
End Namespace