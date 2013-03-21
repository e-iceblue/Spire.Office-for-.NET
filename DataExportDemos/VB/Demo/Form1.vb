Imports Microsoft.VisualBasic
Imports System
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Spire.DataExport.TXT

Namespace Spire.DataExport.Sample
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private accessExport1 As Spire.DataExport.Access.AccessExport
		Private cellExport1 As Spire.DataExport.XLS.CellExport
		Private clipboardExport1 As Spire.DataExport.Clipboard.ClipboardExport
		Private dbfExport1 As Spire.DataExport.DBF.DBFExport
		Private htmlExport1 As Spire.DataExport.HTML.HTMLExport
		Private pdfExport1 As Spire.DataExport.PDF.PDFExport
		Private rtfExport1 As Spire.DataExport.RTF.RTFExport
		Private sqlExport1 As Spire.DataExport.SQL.SQLExport
		Private xmlExport1 As Spire.DataExport.XML.XMLExport
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private txtCommandText As System.Windows.Forms.TextBox
		Private txtConnectString As System.Windows.Forms.TextBox
		Private WithEvents rbnXLS As System.Windows.Forms.RadioButton
		Private WithEvents rbnHtml As System.Windows.Forms.RadioButton
		Private WithEvents rbnPdf As System.Windows.Forms.RadioButton
		Private WithEvents rbnRtf As System.Windows.Forms.RadioButton
		Private WithEvents rbnClipboard As System.Windows.Forms.RadioButton
		Private WithEvents rbnDbf As System.Windows.Forms.RadioButton
		Private WithEvents rbnAccess As System.Windows.Forms.RadioButton
		Private WithEvents rbnXml As System.Windows.Forms.RadioButton
		Private WithEvents rbnSql As System.Windows.Forms.RadioButton
		Private WithEvents rbnSYLK As System.Windows.Forms.RadioButton
		Private WithEvents rbnDIF As System.Windows.Forms.RadioButton
		Private WithEvents rbnCSV As System.Windows.Forms.RadioButton
		Private dgDetail As System.Windows.Forms.DataGrid
		Private WithEvents btnRun As System.Windows.Forms.Button
		Private WithEvents btnAbout As System.Windows.Forms.Button
		Private oleDbConnection1 As System.Data.OleDb.OleDbConnection
		Private oleDbCommand1 As System.Data.OleDb.OleDbCommand

		Private itemIndex As Integer = 1
		Private txtExport1 As Spire.DataExport.TXT.TXTExport
		Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
		Private WithEvents button2 As System.Windows.Forms.Button
		Private txtExport2 As Spire.DataExport.TXT.TXTExport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.accessExport1 = New Spire.DataExport.Access.AccessExport
            Me.oleDbCommand1 = New System.Data.OleDb.OleDbCommand
            Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection
            Me.cellExport1 = New Spire.DataExport.XLS.CellExport
            Me.clipboardExport1 = New Spire.DataExport.Clipboard.ClipboardExport
            Me.dbfExport1 = New Spire.DataExport.DBF.DBFExport
            Me.htmlExport1 = New Spire.DataExport.HTML.HTMLExport
            Me.pdfExport1 = New Spire.DataExport.PDF.PDFExport
            Me.rtfExport1 = New Spire.DataExport.RTF.RTFExport
            Me.sqlExport1 = New Spire.DataExport.SQL.SQLExport
            Me.xmlExport1 = New Spire.DataExport.XML.XMLExport
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.button2 = New System.Windows.Forms.Button
            Me.txtCommandText = New System.Windows.Forms.TextBox
            Me.label2 = New System.Windows.Forms.Label
            Me.txtConnectString = New System.Windows.Forms.TextBox
            Me.label1 = New System.Windows.Forms.Label
            Me.groupBox2 = New System.Windows.Forms.GroupBox
            Me.rbnSYLK = New System.Windows.Forms.RadioButton
            Me.rbnDIF = New System.Windows.Forms.RadioButton
            Me.rbnCSV = New System.Windows.Forms.RadioButton
            Me.rbnXLS = New System.Windows.Forms.RadioButton
            Me.rbnHtml = New System.Windows.Forms.RadioButton
            Me.rbnPdf = New System.Windows.Forms.RadioButton
            Me.rbnRtf = New System.Windows.Forms.RadioButton
            Me.rbnClipboard = New System.Windows.Forms.RadioButton
            Me.rbnDbf = New System.Windows.Forms.RadioButton
            Me.rbnAccess = New System.Windows.Forms.RadioButton
            Me.rbnXml = New System.Windows.Forms.RadioButton
            Me.rbnSql = New System.Windows.Forms.RadioButton
            Me.radioButton1 = New System.Windows.Forms.RadioButton
            Me.dgDetail = New System.Windows.Forms.DataGrid
            Me.btnRun = New System.Windows.Forms.Button
            Me.btnAbout = New System.Windows.Forms.Button
            Me.txtExport1 = New Spire.DataExport.TXT.TXTExport
            Me.txtExport2 = New Spire.DataExport.TXT.TXTExport
            Me.groupBox1.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'accessExport1
            '
            Me.accessExport1.DatabaseName = "test.mdb"
            Me.accessExport1.DataFormats.CultureName = "zh-CN"
            Me.accessExport1.DataFormats.Currency = "c"
            Me.accessExport1.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.accessExport1.DataFormats.Float = "g"
            Me.accessExport1.DataFormats.Integer = "g"
            Me.accessExport1.DataFormats.Time = "H:mm"
            Me.accessExport1.SQLCommand = Me.oleDbCommand1
            Me.accessExport1.TableName = "ExportData"
            '
            'oleDbCommand1
            '
            Me.oleDbCommand1.CommandText = "select * from parts"
            Me.oleDbCommand1.Connection = Me.oleDbConnection1
            '
            'oleDbConnection1
            '
            Me.oleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
            "ocking Mode=1;Jet OLEDB:Database Password=;Data Source=""..\database\demo.mdb"";Je" & _
            "t OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.J" & _
            "et.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties" & _
            "=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System " & _
            "Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Wi" & _
            "thout Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False"
            '
            'cellExport1
            '
            Me.cellExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView
            Me.cellExport1.AutoFitColWidth = True
            Me.cellExport1.DataFormats.CultureName = "zh-CN"
            Me.cellExport1.DataFormats.Currency = "гд#,###,##0.00"
            Me.cellExport1.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.cellExport1.DataFormats.Float = "#,###,##0.00"
            Me.cellExport1.DataFormats.Integer = "#,###,##0"
            Me.cellExport1.DataFormats.Time = "H:mm"
            Me.cellExport1.FileName = "sample.xls"
            Me.cellExport1.SheetOptions.AggregateFormat.Font.Name = "Arial"
            Me.cellExport1.SheetOptions.CustomDataFormat.Font.Name = "Arial"
            Me.cellExport1.SheetOptions.DefaultFont.Name = "Arial"
            Me.cellExport1.SheetOptions.FooterFormat.Font.Name = "Arial"
            Me.cellExport1.SheetOptions.HeaderFormat.Font.Name = "Arial"
            Me.cellExport1.SheetOptions.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            Me.cellExport1.SheetOptions.HyperlinkFormat.Font.Name = "Arial"
            Me.cellExport1.SheetOptions.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            Me.cellExport1.SheetOptions.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            Me.cellExport1.SheetOptions.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            Me.cellExport1.SheetOptions.NoteFormat.Font.Bold = True
            Me.cellExport1.SheetOptions.NoteFormat.Font.Name = "Tahoma"
            Me.cellExport1.SheetOptions.NoteFormat.Font.Size = 8.0!
            Me.cellExport1.SheetOptions.TitlesFormat.Font.Bold = True
            Me.cellExport1.SheetOptions.TitlesFormat.Font.Name = "Arial"
            Me.cellExport1.SQLCommand = Me.oleDbCommand1
            '
            'clipboardExport1
            '
            Me.clipboardExport1.DataFormats.CultureName = "zh-CN"
            Me.clipboardExport1.DataFormats.Currency = "c"
            Me.clipboardExport1.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.clipboardExport1.DataFormats.Float = "g"
            Me.clipboardExport1.DataFormats.Integer = "g"
            Me.clipboardExport1.DataFormats.Time = "H:mm"
            Me.clipboardExport1.ShowContent = True
            Me.clipboardExport1.SQLCommand = Me.oleDbCommand1
            '
            'dbfExport1
            '
            Me.dbfExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView
            Me.dbfExport1.FileName = "sample.dbf"
            Me.dbfExport1.SQLCommand = Me.oleDbCommand1
            '
            'htmlExport1
            '
            Me.htmlExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView
            Me.htmlExport1.DataFormats.CultureName = "zh-CN"
            Me.htmlExport1.DataFormats.Currency = "c"
            Me.htmlExport1.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.htmlExport1.DataFormats.Float = "g"
            Me.htmlExport1.DataFormats.Integer = "g"
            Me.htmlExport1.DataFormats.Time = "H:mm"
            Me.htmlExport1.FileName = "sample.html"
            Me.htmlExport1.HtmlStyle = Spire.DataExport.HTML.HtmlStyle.MSMoney
            Me.htmlExport1.HtmlTableOptions.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(231, Byte), CType(222, Byte))
            Me.htmlExport1.HtmlTableOptions.FontColor = System.Drawing.Color.Black
            Me.htmlExport1.HtmlTableOptions.HeadersBackColor = System.Drawing.Color.FromArgb(CType(206, Byte), CType(198, Byte), CType(181, Byte))
            Me.htmlExport1.HtmlTableOptions.HeadersFontColor = System.Drawing.Color.Black
            Me.htmlExport1.HtmlTableOptions.OddBackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(251, Byte), CType(240, Byte))
            Me.htmlExport1.HtmlTextOptions.BackgroundColor = System.Drawing.Color.White
            Me.htmlExport1.HtmlTextOptions.Font = New System.Drawing.Font("Arial", 8.0!)
            Me.htmlExport1.HtmlTextOptions.LinkActiveColor = System.Drawing.Color.Blue
            Me.htmlExport1.HtmlTextOptions.LinkColor = System.Drawing.Color.Red
            Me.htmlExport1.HtmlTextOptions.LinkVisitedColor = System.Drawing.Color.Purple
            Me.htmlExport1.SQLCommand = Me.oleDbCommand1
            '
            'pdfExport1
            '
            Me.pdfExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView
            Me.pdfExport1.DataFormats.CultureName = "zh-CN"
            Me.pdfExport1.DataFormats.Currency = "c"
            Me.pdfExport1.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.pdfExport1.DataFormats.Float = "g"
            Me.pdfExport1.DataFormats.Integer = "g"
            Me.pdfExport1.DataFormats.Time = "H:mm"
            Me.pdfExport1.FileName = "sample.pdf"
            Me.pdfExport1.PDFOptions.PageOptions.Format = Spire.DataExport.PDF.PageFormat.User
            Me.pdfExport1.PDFOptions.PageOptions.Height = 11.67
            Me.pdfExport1.PDFOptions.PageOptions.MarginBottom = 0.78
            Me.pdfExport1.PDFOptions.PageOptions.MarginLeft = 1.17
            Me.pdfExport1.PDFOptions.PageOptions.MarginRight = 0.57
            Me.pdfExport1.PDFOptions.PageOptions.MarginTop = 0.78
            Me.pdfExport1.PDFOptions.PageOptions.Width = 8.25
            Me.pdfExport1.SQLCommand = Me.oleDbCommand1
            '
            'rtfExport1
            '
            Me.rtfExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView
            Me.rtfExport1.DataFormats.CultureName = "zh-CN"
            Me.rtfExport1.DataFormats.Currency = "c"
            Me.rtfExport1.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.rtfExport1.DataFormats.Float = "g"
            Me.rtfExport1.DataFormats.Integer = "g"
            Me.rtfExport1.DataFormats.Time = "H:mm"
            Me.rtfExport1.FileName = "sample.doc"
            Me.rtfExport1.RTFOptions.DataStyle.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.rtfExport1.RTFOptions.FooterStyle.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.rtfExport1.RTFOptions.HeaderStyle.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.rtfExport1.RTFOptions.TitleStyle.Alignment = Spire.DataExport.RTF.RtfTextAlignment.Center
            Me.rtfExport1.RTFOptions.TitleStyle.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
            Me.rtfExport1.SQLCommand = Me.oleDbCommand1
            '
            'sqlExport1
            '
            Me.sqlExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView
            Me.sqlExport1.CommitStatement = "COMMIT;"
            Me.sqlExport1.DataFormats.CultureName = "zh-CN"
            Me.sqlExport1.DataFormats.Currency = "c"
            Me.sqlExport1.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.sqlExport1.DataFormats.Float = "g"
            Me.sqlExport1.DataFormats.Integer = "g"
            Me.sqlExport1.DataFormats.Time = "H:mm"
            Me.sqlExport1.FileName = "sample.sql"
            Me.sqlExport1.SQLCommand = Me.oleDbCommand1
            Me.sqlExport1.TableName = "TestTable"
            '
            'xmlExport1
            '
            Me.xmlExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView
            Me.xmlExport1.DataFormats.CultureName = "zh-CN"
            Me.xmlExport1.DataFormats.Currency = "c"
            Me.xmlExport1.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.xmlExport1.DataFormats.Float = "g"
            Me.xmlExport1.DataFormats.Integer = "g"
            Me.xmlExport1.DataFormats.Time = "H:mm"
            Me.xmlExport1.FileName = "sample.xml"
            Me.xmlExport1.SQLCommand = Me.oleDbCommand1
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.button2)
            Me.groupBox1.Controls.Add(Me.txtCommandText)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.txtConnectString)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Location = New System.Drawing.Point(16, 13)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(312, 155)
            Me.groupBox1.TabIndex = 0
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = " Data source "
            '
            'button2
            '
            Me.button2.Location = New System.Drawing.Point(232, 125)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(64, 23)
            Me.button2.TabIndex = 5
            Me.button2.Text = "Load"
            '
            'txtCommandText
            '
            Me.txtCommandText.Location = New System.Drawing.Point(17, 95)
            Me.txtCommandText.Name = "txtCommandText"
            Me.txtCommandText.Size = New System.Drawing.Size(279, 21)
            Me.txtCommandText.TabIndex = 3
            Me.txtCommandText.Text = "select * from parts"
            '
            'label2
            '
            Me.label2.Location = New System.Drawing.Point(16, 75)
            Me.label2.Name = "label2"
            Me.label2.TabIndex = 2
            Me.label2.Text = "Command Text:"
            '
            'txtConnectString
            '
            Me.txtConnectString.Location = New System.Drawing.Point(16, 43)
            Me.txtConnectString.Name = "txtConnectString"
            Me.txtConnectString.Size = New System.Drawing.Size(280, 21)
            Me.txtConnectString.TabIndex = 1
            Me.txtConnectString.Text = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\..\\..\\database\\demo.mdb"
            '
            'label1
            '
            Me.label1.Location = New System.Drawing.Point(15, 23)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(121, 16)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Connection string:"
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.rbnSYLK)
            Me.groupBox2.Controls.Add(Me.rbnDIF)
            Me.groupBox2.Controls.Add(Me.rbnCSV)
            Me.groupBox2.Controls.Add(Me.rbnXLS)
            Me.groupBox2.Controls.Add(Me.rbnHtml)
            Me.groupBox2.Controls.Add(Me.rbnPdf)
            Me.groupBox2.Controls.Add(Me.rbnRtf)
            Me.groupBox2.Controls.Add(Me.rbnClipboard)
            Me.groupBox2.Controls.Add(Me.rbnDbf)
            Me.groupBox2.Controls.Add(Me.rbnAccess)
            Me.groupBox2.Controls.Add(Me.rbnXml)
            Me.groupBox2.Controls.Add(Me.rbnSql)
            Me.groupBox2.Controls.Add(Me.radioButton1)
            Me.groupBox2.Location = New System.Drawing.Point(336, 12)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(264, 240)
            Me.groupBox2.TabIndex = 1
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = " Export file format "
            '
            'rbnSYLK
            '
            Me.rbnSYLK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.rbnSYLK.Location = New System.Drawing.Point(152, 144)
            Me.rbnSYLK.Name = "rbnSYLK"
            Me.rbnSYLK.Size = New System.Drawing.Size(96, 26)
            Me.rbnSYLK.TabIndex = 10
            Me.rbnSYLK.Tag = "10"
            Me.rbnSYLK.Text = " SYLK"
            '
            'rbnDIF
            '
            Me.rbnDIF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.rbnDIF.Location = New System.Drawing.Point(152, 176)
            Me.rbnDIF.Name = "rbnDIF"
            Me.rbnDIF.Size = New System.Drawing.Size(96, 26)
            Me.rbnDIF.TabIndex = 9
            Me.rbnDIF.Tag = "12"
            Me.rbnDIF.Text = " DIF"
            '
            'rbnCSV
            '
            Me.rbnCSV.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.rbnCSV.Location = New System.Drawing.Point(24, 176)
            Me.rbnCSV.Name = "rbnCSV"
            Me.rbnCSV.Size = New System.Drawing.Size(96, 26)
            Me.rbnCSV.TabIndex = 8
            Me.rbnCSV.Tag = "11"
            Me.rbnCSV.Text = " CSV"
            '
            'rbnXLS
            '
            Me.rbnXLS.Checked = True
            Me.rbnXLS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.rbnXLS.Location = New System.Drawing.Point(24, 16)
            Me.rbnXLS.Name = "rbnXLS"
            Me.rbnXLS.TabIndex = 0
            Me.rbnXLS.TabStop = True
            Me.rbnXLS.Tag = "1"
            Me.rbnXLS.Text = " XLS"
            '
            'rbnHtml
            '
            Me.rbnHtml.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.rbnHtml.Location = New System.Drawing.Point(152, 16)
            Me.rbnHtml.Name = "rbnHtml"
            Me.rbnHtml.TabIndex = 0
            Me.rbnHtml.Tag = "2"
            Me.rbnHtml.Text = " HTML"
            '
            'rbnPdf
            '
            Me.rbnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.rbnPdf.Location = New System.Drawing.Point(24, 48)
            Me.rbnPdf.Name = "rbnPdf"
            Me.rbnPdf.TabIndex = 0
            Me.rbnPdf.Tag = "3"
            Me.rbnPdf.Text = " PDF"
            '
            'rbnRtf
            '
            Me.rbnRtf.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.rbnRtf.Location = New System.Drawing.Point(152, 48)
            Me.rbnRtf.Name = "rbnRtf"
            Me.rbnRtf.TabIndex = 0
            Me.rbnRtf.Tag = "4"
            Me.rbnRtf.Text = " RTF"
            '
            'rbnClipboard
            '
            Me.rbnClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.rbnClipboard.Location = New System.Drawing.Point(24, 80)
            Me.rbnClipboard.Name = "rbnClipboard"
            Me.rbnClipboard.TabIndex = 0
            Me.rbnClipboard.Tag = "5"
            Me.rbnClipboard.Text = " Clipboard"
            '
            'rbnDbf
            '
            Me.rbnDbf.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.rbnDbf.Location = New System.Drawing.Point(152, 80)
            Me.rbnDbf.Name = "rbnDbf"
            Me.rbnDbf.TabIndex = 0
            Me.rbnDbf.Tag = "6"
            Me.rbnDbf.Text = " DBF"
            '
            'rbnAccess
            '
            Me.rbnAccess.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.rbnAccess.Location = New System.Drawing.Point(24, 112)
            Me.rbnAccess.Name = "rbnAccess"
            Me.rbnAccess.TabIndex = 0
            Me.rbnAccess.Tag = "7"
            Me.rbnAccess.Text = " MS Access"
            '
            'rbnXml
            '
            Me.rbnXml.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.rbnXml.Location = New System.Drawing.Point(152, 112)
            Me.rbnXml.Name = "rbnXml"
            Me.rbnXml.TabIndex = 0
            Me.rbnXml.Tag = "8"
            Me.rbnXml.Text = " XML"
            '
            'rbnSql
            '
            Me.rbnSql.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.rbnSql.Location = New System.Drawing.Point(24, 144)
            Me.rbnSql.Name = "rbnSql"
            Me.rbnSql.TabIndex = 0
            Me.rbnSql.Tag = "9"
            Me.rbnSql.Text = " SQL Script"
            '
            'radioButton1
            '
            Me.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.radioButton1.Location = New System.Drawing.Point(24, 208)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(96, 26)
            Me.radioButton1.TabIndex = 8
            Me.radioButton1.Tag = "13"
            Me.radioButton1.Text = " Text"
            '
            'dgDetail
            '
            Me.dgDetail.DataMember = ""
            Me.dgDetail.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dgDetail.Location = New System.Drawing.Point(16, 264)
            Me.dgDetail.Name = "dgDetail"
            Me.dgDetail.Size = New System.Drawing.Size(584, 128)
            Me.dgDetail.TabIndex = 0
            '
            'btnRun
            '
            Me.btnRun.Location = New System.Drawing.Point(432, 408)
            Me.btnRun.Name = "btnRun"
            Me.btnRun.TabIndex = 2
            Me.btnRun.Text = "Run"
            '
            'btnAbout
            '
            Me.btnAbout.Location = New System.Drawing.Point(520, 408)
            Me.btnAbout.Name = "btnAbout"
            Me.btnAbout.TabIndex = 3
            Me.btnAbout.Text = "Close"
            '
            'txtExport1
            '
            Me.txtExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView
            Me.txtExport1.DataFormats.CultureName = "zh-CN"
            Me.txtExport1.DataFormats.Currency = "c"
            Me.txtExport1.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.txtExport1.DataFormats.Float = "g"
            Me.txtExport1.DataFormats.Integer = "g"
            Me.txtExport1.DataFormats.Time = "H:mm"
            Me.txtExport1.DataEncoding = Spire.DataExport.Common.EncodingType.ASCII
            Me.txtExport1.SQLCommand = Me.oleDbCommand1
            '
            'txtExport2
            '
            Me.txtExport2.DataFormats.CultureName = "zh-CN"
            Me.txtExport2.DataFormats.Currency = "c"
            Me.txtExport2.DataFormats.DateTime = "yyyy-M-d H:mm"
            Me.txtExport2.DataFormats.Float = "g"
            Me.txtExport2.DataFormats.Integer = "g"
            Me.txtExport2.DataFormats.Time = "H:mm"
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
            Me.ClientSize = New System.Drawing.Size(616, 438)
            Me.Controls.Add(Me.btnAbout)
            Me.Controls.Add(Me.btnRun)
            Me.Controls.Add(Me.dgDetail)
            Me.Controls.Add(Me.groupBox2)
            Me.Controls.Add(Me.groupBox1)
            Me.Name = "Form1"
            Me.Text = "Sample"
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox2.ResumeLayout(False)
            CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub LoadData()
			oleDbConnection1.ConnectionString = txtConnectString.Text
			oleDbCommand1.CommandText = txtCommandText.Text
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(oleDbCommand1)
			Try
				Dim dt As DataTable = New DataTable()
				da.Fill(dt)
				dgDetail.DataSource = dt
			Finally
				CType(da, IDisposable).Dispose()
			End Try
        End Sub

        Private Sub btnRun_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRun.Click
            oleDbConnection1.Open()
            Try
                Select Case itemIndex
                    Case 1
                        cellExport1.SaveToFile()
                    Case 2
                        htmlExport1.SaveToFile()
                    Case 3
                        pdfExport1.SaveToFile()
                    Case 4
                        rtfExport1.SaveToFile()
                    Case 5
                        clipboardExport1.SaveToFile()
                    Case 6
                        dbfExport1.SaveToFile()
                    Case 7
                        accessExport1.SaveToFile()
                    Case 8
                        xmlExport1.SaveToFile()
                    Case 9
                        sqlExport1.SaveToFile()
                    Case 10
                        txtExport1.ExportType = TextExportType.SYLK
                        txtExport1.FileName = "sample.slk"
                        txtExport1.SaveToFile()
                    Case 11
                        txtExport1.ExportType = TextExportType.CSV
                        txtExport1.FileName = "sample.csv"
                        txtExport1.SaveToFile()
                    Case 12
                        txtExport1.ExportType = TextExportType.DIF
                        txtExport1.FileName = "sample.dif"
                        txtExport1.SaveToFile()
                    Case 13
                        txtExport1.ExportType = TextExportType.TXT
                        txtExport1.FileName = "sample.txt"
                        txtExport1.SaveToFile()

                End Select
            Finally
                Me.oleDbConnection1.Close()
            End Try
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            LoadData()
        End Sub

        Private Sub rbnHtml_CheckedChanged_1(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbnSYLK.CheckedChanged, rbnDIF.CheckedChanged, rbnCSV.CheckedChanged, rbnXLS.CheckedChanged, rbnHtml.CheckedChanged, rbnPdf.CheckedChanged, rbnRtf.CheckedChanged, rbnClipboard.CheckedChanged, rbnDbf.CheckedChanged, rbnAccess.CheckedChanged, rbnXml.CheckedChanged, rbnSql.CheckedChanged, radioButton1.CheckedChanged
            Dim rbTmp As RadioButton
            rbTmp = CType(IIf(TypeOf sender Is RadioButton, sender, Nothing), RadioButton)
            If rbTmp.Checked And Not IsNothing(rbTmp.Tag) Then
                itemIndex = Integer.Parse((CType(IIf(TypeOf sender Is RadioButton, sender, Nothing), RadioButton)).Tag.ToString())
            End If
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
            LoadData()
        End Sub

        Private Sub btnAbout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAbout.Click
            Close()
        End Sub

    End Class
End Namespace
