Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Imports System.Web
Imports System.Web.SessionState
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls

Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace Spire.WebDemo

	Partial Public Class DefaultForm
		Inherits System.Web.UI.Page
		Protected oleDbConnection1 As System.Data.OleDb.OleDbConnection
		Protected oleDbCommand1 As System.Data.OleDb.OleDbCommand
		Protected RadioButtonList1 As System.Web.UI.WebControls.RadioButtonList
		Protected RadioButtonList2 As System.Web.UI.WebControls.RadioButtonList

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
		End Sub

		#Region "Web Form Designer generated code"
		Protected Overrides Sub OnInit(ByVal e As EventArgs)
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

		Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			'Create word document
			Dim document_Renamed As New Document()

			InsertWatermark(document_Renamed)

			'Save doc file.
			document_Renamed.SaveToFile("Sample.doc", FileFormat.Doc,Response, HttpContentType.Attachment)
		End Sub
		Private Sub InsertWatermark(ByVal document_Renamed As Document)
			Dim paragraph_Renamed As Paragraph = document_Renamed.AddSection().AddParagraph()
			paragraph_Renamed.AppendText("The sample demonstrates how to insert a watermark into a document.")
			paragraph_Renamed.ApplyStyle(BuiltinStyle.Heading2)


			Dim txtWatermark As New TextWatermark()
			txtWatermark.Text = "Watermark Demo"
			txtWatermark.FontSize = 90
			txtWatermark.Layout = WatermarkLayout.Diagonal
			document_Renamed.Watermark = txtWatermark

		End Sub

		Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
		End Sub
	End Class
End Namespace