Imports Microsoft.VisualBasic
Imports System
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Spire.DataExport.TXT

Namespace Spire.DataExport.HtmlSample
    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1
        Inherits System.Windows.Forms.Form
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private label1 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private txtCommandText As System.Windows.Forms.TextBox
        Private txtConnectString As System.Windows.Forms.TextBox
        Private dgDetail As System.Windows.Forms.DataGrid
        Private WithEvents btnRun As System.Windows.Forms.Button
        Private WithEvents btnAbout As System.Windows.Forms.Button
        Private oleDbConnection1 As System.Data.OleDb.OleDbConnection
        Private oleDbCommand1 As System.Data.OleDb.OleDbCommand

        Private WithEvents button2 As System.Windows.Forms.Button
        Private htmlExport1 As Spire.DataExport.HTML.HTMLExport
        Private lblTitle As System.Windows.Forms.Label
        Private lstStyles As System.Windows.Forms.ListBox
        ''' <summary>
        ''' Required designer variable.
        ''' </summary
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
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
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
            Me.oleDbCommand1 = New System.Data.OleDb.OleDbCommand
            Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.button2 = New System.Windows.Forms.Button
            Me.txtCommandText = New System.Windows.Forms.TextBox
            Me.label2 = New System.Windows.Forms.Label
            Me.txtConnectString = New System.Windows.Forms.TextBox
            Me.label1 = New System.Windows.Forms.Label
            Me.dgDetail = New System.Windows.Forms.DataGrid
            Me.btnRun = New System.Windows.Forms.Button
            Me.btnAbout = New System.Windows.Forms.Button
            Me.htmlExport1 = New Spire.DataExport.HTML.HTMLExport
            Me.lblTitle = New System.Windows.Forms.Label
            Me.lstStyles = New System.Windows.Forms.ListBox
            Me.groupBox1.SuspendLayout()
            CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
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
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.button2)
            Me.groupBox1.Controls.Add(Me.txtCommandText)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.txtConnectString)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Location = New System.Drawing.Point(16, 13)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(312, 171)
            Me.groupBox1.TabIndex = 0
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = " Data source "
            '
            'button2
            '
            Me.button2.Location = New System.Drawing.Point(232, 128)
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
            Me.label2.Size = New System.Drawing.Size(240, 13)
            Me.label2.TabIndex = 2
            Me.label2.Text = "Command text :"
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
            'dgDetail
            '
            Me.dgDetail.DataMember = ""
            Me.dgDetail.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dgDetail.Location = New System.Drawing.Point(16, 200)
            Me.dgDetail.Name = "dgDetail"
            Me.dgDetail.Size = New System.Drawing.Size(584, 128)
            Me.dgDetail.TabIndex = 0
            '
            'btnRun
            '
            Me.btnRun.Location = New System.Drawing.Point(528, 24)
            Me.btnRun.Name = "btnRun"
            Me.btnRun.Size = New System.Drawing.Size(72, 23)
            Me.btnRun.TabIndex = 2
            Me.btnRun.Text = "Run"
            '
            'btnAbout
            '
            Me.btnAbout.Location = New System.Drawing.Point(528, 56)
            Me.btnAbout.Name = "btnAbout"
            Me.btnAbout.TabIndex = 3
            Me.btnAbout.Text = "Close"
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
            Me.htmlExport1.FileName = "test.html"
            Me.htmlExport1.HtmlTableOptions.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(122, Byte), CType(236, Byte))
            Me.htmlExport1.HtmlTableOptions.FontColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte))
            Me.htmlExport1.HtmlTableOptions.HeadersBackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte))
            Me.htmlExport1.HtmlTableOptions.HeadersFontColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte))
            Me.htmlExport1.HtmlTableOptions.OddBackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(107, Byte), CType(206, Byte))
            Me.htmlExport1.HtmlTextOptions.BackgroundColor = System.Drawing.Color.FromArgb(CType(51, Byte), CType(51, Byte), CType(153, Byte))
            Me.htmlExport1.HtmlTextOptions.Font = New System.Drawing.Font("Arial", 8.0!)
            Me.htmlExport1.HtmlTextOptions.FontColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte))
            Me.htmlExport1.HtmlTextOptions.LinkActiveColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(255, Byte), CType(0, Byte))
            Me.htmlExport1.HtmlTextOptions.LinkColor = System.Drawing.Color.FromArgb(CType(105, Byte), CType(239, Byte), CType(125, Byte))
            Me.htmlExport1.HtmlTextOptions.LinkVisitedColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte))
            Me.htmlExport1.SQLCommand = Me.oleDbCommand1
            '
            'lblTitle
            '
            Me.lblTitle.Location = New System.Drawing.Point(352, 16)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(100, 16)
            Me.lblTitle.TabIndex = 4
            Me.lblTitle.Text = "Html styles:"
            '
            'lstStyles
            '
            Me.lstStyles.ItemHeight = 12
            Me.lstStyles.Location = New System.Drawing.Point(352, 40)
            Me.lstStyles.Name = "lstStyles"
            Me.lstStyles.Size = New System.Drawing.Size(160, 136)
            Me.lstStyles.TabIndex = 5
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
            Me.ClientSize = New System.Drawing.Size(616, 350)
            Me.Controls.Add(Me.lstStyles)
            Me.Controls.Add(Me.lblTitle)
            Me.Controls.Add(Me.btnAbout)
            Me.Controls.Add(Me.btnRun)
            Me.Controls.Add(Me.dgDetail)
            Me.Controls.Add(Me.groupBox1)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.Text = "Cell demo"
            Me.groupBox1.ResumeLayout(False)
            CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New Form1)
        End Sub

        Private Sub LoadData()
            oleDbConnection1.ConnectionString = txtConnectString.Text
            oleDbCommand1.CommandText = txtCommandText.Text
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(oleDbCommand1)
            Try
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgDetail.DataSource = dt
            Finally
                CType(da, IDisposable).Dispose()
            End Try
        End Sub

        Private Sub btnRun_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRun.Click
            oleDbConnection1.Open()
            Try
                If lstStyles.SelectedIndex > 0 Then
                    htmlExport1.HtmlStyle = CType(System.Enum.Parse(GetType(Spire.DataExport.HTML.HtmlStyle), lstStyles.SelectedItem.ToString()), Spire.DataExport.HTML.HtmlStyle)
                End If
                htmlExport1.SaveToFile()
            Finally
                Me.oleDbConnection1.Close()
            End Try
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.lstStyles.Items.AddRange(System.Enum.GetNames(GetType(Spire.DataExport.HTML.HtmlStyle)))
            If lstStyles.Items.Count > 1 Then
                Me.lstStyles.SelectedIndex = 1
            End If
            LoadData()
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
            LoadData()
        End Sub

        Private Sub btnAbout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAbout.Click
            Close()
        End Sub


    End Class
End Namespace
