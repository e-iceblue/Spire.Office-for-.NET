<%@ Page language="vb" Inherits="Spire.WebDemo.DefaultForm" uiCulture="en-US" CodeFile="Default.aspx.vb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Welcome to Spire.XLS Featured Demos</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<style>
        	BODY { FONT-WEIGHT: normal; FONT-SIZE: 11pt; COLOR: black; FONT-FAMILY: "Verdana" }
        	LABEL { FONT-WEIGHT: normal; FONT-SIZE: 11pt; COLOR: black; FONT-FAMILY: "Verdana" }
        	P { MARGIN-TOP: -5px; FONT-WEIGHT: normal; COLOR: black; FONT-FAMILY: "Verdana" }
        	B { MARGIN-TOP: -5px; FONT-WEIGHT: bold; COLOR: black; FONT-FAMILY: "Verdana" }
        	H1 { FONT-WEIGHT: normal; FONT-SIZE: 18pt; COLOR: red; FONT-FAMILY: "Verdana" }
        	H2 { FONT-WEIGHT: normal; FONT-SIZE: 14pt; COLOR: maroon; FONT-FAMILY: "Verdana" }
        	PRE { FONT-SIZE: 0.9em; FONT-FAMILY: "Lucida Console" }
		</style>
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:button id="Button1" style="Z-INDEX: 100; LEFT: 600px; POSITION: absolute; TOP: 296px" runat="server"
				Width="96px" Text="Run" onclick="Button1_Click"></asp:button>
			<asp:label id="Label1" style="Z-INDEX: 110; LEFT: 72px; POSITION: absolute; TOP: 168px" runat="server"
				Width="680px" Height="40px" ForeColor="Blue">For more detailed usage of Spire.Doc, run SampleCenter to view more samples.</asp:label>
			<asp:Label id="Label6" style="Z-INDEX: 108; LEFT: 80px; POSITION: absolute; TOP: 224px" runat="server"
				Width="136px" Height="24px" Font-Bold="True">Home:</asp:Label><asp:label id="Label3" style="Z-INDEX: 103; LEFT: 72px; POSITION: absolute; TOP: 128px" runat="server"
				Width="656px" ForeColor="Blue" Height="40px"> Notes : Not needing to have Microsoft Word installed on the machine,The Spire.Doc can read/write Word document.</asp:label><asp:hyperlink id="HyperLink1" style="Z-INDEX: 101; LEFT: 88px; POSITION: absolute; TOP: 256px"
				runat="server" Width="224px" Height="24px" NavigateUrl="http://www.e-iceblue.com">http://www.e-iceblue.com</asp:hyperlink><asp:label id="Label2" style="Z-INDEX: 102; LEFT: 64px; POSITION: absolute; TOP: 32px" runat="server"
				Width="464px" Height="24px" Font-Bold="True" Font-Size="Large"> Spire.Doc for .NET</asp:label>
			<asp:Label id="Label4" style="Z-INDEX: 106; LEFT: 72px; POSITION: absolute; TOP: 96px" runat="server"
				Width="104px" Height="24px" Font-Bold="True">important</asp:Label></form>
	</body>
</HTML>
