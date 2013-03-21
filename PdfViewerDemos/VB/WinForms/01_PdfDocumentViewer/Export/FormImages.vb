Imports System.IO
Imports System.Windows.Forms


Namespace PdfDocumentViewer_Export
	Partial Public Class FormImages
		Inherits Form

		Private _dictionaryImags As Dictionary(Of String,Image)

		Public Property DictionaryImages() As Dictionary(Of String,Image)
			Get
				Return Me._dictionaryImags
			End Get
			Set(ByVal value As Dictionary(Of String,Image))
				Me._dictionaryImags=value
				Me.ViewImages()
			End Set
		End Property
		Public Sub New()
			InitializeComponent()
		End Sub

		Public Sub ViewImages()
			If Me.DictionaryImages IsNot Nothing AndAlso Me.DictionaryImages.Count>0 Then
				Me.panelImages1.Controls.Clear()
				Dim image_name As String = ""
				Dim panelHeight As Integer = 0
				Dim panelWidth As Integer = 0

				For Each pair As KeyValuePair(Of String, Image) In Me.DictionaryImages
					image_name = pair.Key

					Dim panelImage As New Panel()
					panelImage.AutoSize = True


					Dim ptrBox As New PictureBox()
					ptrBox.Height = 150
					ptrBox.Width = 200

					ptrBox.SizeMode = PictureBoxSizeMode.Zoom

					ptrBox.Image = pair.Value
                    ptrBox.Cursor = Cursors.Hand
                    ptrBox.ImageLocation = image_name




					panelImage.Controls.Add(ptrBox)

					Dim lbl As New LinkLabel()
					Dim imageName As String = Path.GetFileName(pair.Key)
                    lbl.Text = imageName
                    lbl.Tag = image_name
					Dim x As Integer = CInt(Fix(ptrBox.Width \ 2 - lbl.Width \ 2))
					Dim y As Integer = ptrBox.Height
					lbl.Left = x
					lbl.Top = y
					panelImage.Controls.Add(lbl)

					Me.panelImages1.Controls.Add(panelImage)

					Me.SetClickEventHandler(ptrBox,lbl, image_name)
					panelHeight = panelImage.Height
					panelWidth = panelImage.Width

				Next pair
				Dim nimages As Integer = Me._dictionaryImags.Count
				If nimages >= 4 Then

					Dim n As Integer = CInt(Fix(Math.Ceiling(Math.Sqrt(nimages))))

					Me.Width = panelWidth * n + 20*(n-1)+40
					Me.Height = panelHeight * n + 20 * (n - 1)+40
				End If
			End If
		End Sub
        Private Sub SetClickEventHandler(ByVal ptrBox As PictureBox, ByVal lbl As LinkLabel, ByVal imageName As String)



            AddHandler ptrBox.Click, AddressOf Me.PtrBox_Click

            AddHandler lbl.Click, AddressOf Me.Lbl_Click
           

        End Sub
        Private Sub PtrBox_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim imageName As String
            Dim ptrbox As System.Windows.Forms.PictureBox
            ptrbox = CType(sender, PictureBox)
            imageName = ptrbox.ImageLocation
            Dim process As New Process()
            Dim info As New ProcessStartInfo(imageName)
            process.StartInfo = info
            process.Start()
        End Sub
        Private Sub Lbl_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim lbl As Label = CType(sender, Label)
            Dim imageName As String = CType(lbl.Tag, String)
            Dim process As New Process()
            Dim info As New ProcessStartInfo(imageName)
            process.StartInfo = info
            process.Start()
        End Sub





    End Class
End Namespace
