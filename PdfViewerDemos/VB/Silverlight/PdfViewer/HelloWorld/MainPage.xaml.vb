Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports System.Windows.Resources

Namespace HelloWorld
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub UserControl_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim resource As StreamResourceInfo = Application.GetResourceStream(New Uri("HelloWorld;component/SPireDoc.pdf", UriKind.Relative))
			Me.pdfViewer1.LoadFromStream(resource.Stream)
		End Sub
	End Class
End Namespace
