Imports System.ComponentModel
Imports System.Text

Namespace Export
	Partial Public Class ImageViewerControl
		Inherits UserControl
		Private m_filename As String
		Public Sub New()
			InitializeComponent()
			Me.label1.BackColor = Me.BackColor
			Me.pictureBox1.BackColor = Me.BackColor
			AddHandler pictureBox1.MouseClick, AddressOf pictureBox1_MouseClick
			AddHandler label1.MouseClick, AddressOf label1_MouseClick
		End Sub

		Private Sub label1_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
			Me.OnMouseClick(e)
		End Sub

		Private Sub pictureBox1_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
			Me.OnMouseClick(e)
		End Sub


		Private Sub ImageViewerControl_SizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.SizeChanged
			Dim width As Integer = Me.Width
			Dim height As Integer = Me.Height

			Me.pictureBox1.Width = width
			Me.pictureBox1.Height = height - 30

			Me.label1.Top = height - 30
			Me.label1.Width = width
		End Sub

		Private Sub ImageViewerControl_BackColorChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.BackColorChanged
			Me.label1.BackColor = Me.BackColor
			Me.pictureBox1.BackColor = Me.BackColor
		End Sub

		Public Property FileName() As String
			Set(ByVal value As String)
				m_filename = value
				Me.toolTipMsg.Active = True
				Me.toolTipMsg.SetToolTip(Me, m_filename)
				Me.toolTipMsg.SetToolTip(Me.label1, m_filename)
				Me.toolTipMsg.SetToolTip(Me.pictureBox1, m_filename)
			End Set
			Get
				Return Me.m_filename
			End Get
		End Property

		Public WriteOnly Property Image() As Image
			Set(ByVal value As Image)
				Me.pictureBox1.Image = value
				Me.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom
			End Set
		End Property

		Public WriteOnly Overloads Property Text() As String
			Set(ByVal value As String)
				Me.label1.Text = value
			End Set
		End Property
	End Class
End Namespace
