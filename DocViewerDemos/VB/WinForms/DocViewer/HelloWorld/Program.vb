Namespace HelloWorld
	Friend NotInheritable Class Program
		''' <summary>
		''' 应用程序的主入口点。
		''' </summary>
		Private Sub New()
		End Sub
                <STAThread()> _
                Shared Sub Main()
                          Application.EnableVisualStyles()
                          Application.SetCompatibleTextRenderingDefault(False)
                          Application.Run(New Form1())
        End Sub
	End Class
End Namespace
