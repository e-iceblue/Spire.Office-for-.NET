Imports System.ComponentModel
Imports System.Text

Namespace HelloWorld
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			Try
				' Load doc document from file.
				Me.docViewer1.LoadFromFile("..\..\..\..\..\..\Data\Spire.Office.doc")
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error)
			End Try
		End Sub
	End Class
End Namespace
