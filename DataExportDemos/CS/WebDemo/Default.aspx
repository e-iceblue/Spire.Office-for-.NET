<%@ Page language="c#" Inherits="Spire.WebDemo.DefaultForm" uiCulture="en-US" CodeFile="Default.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Welcome to Spire.DataExport Featured Demos</title>
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
			<asp:button id="Button1" style="Z-INDEX: 101; LEFT: 424px; POSITION: absolute; TOP: 424px" runat="server"
				Width="96px" Text="Run" onclick="Button1_Click"></asp:button>
			<asp:Label id="Label6" style="Z-INDEX: 110; LEFT: 72px; POSITION: absolute; TOP: 360px" runat="server"
				Width="136px" Height="24px" Font-Bold="True">more details</asp:Label><asp:label id="Label3" style="Z-INDEX: 105; LEFT: 72px; POSITION: absolute; TOP: 152px" runat="server"
				Width="680px" ForeColor="Blue" Height="32px">Notes : Not needing to have Microsoft Excel or Adobe Acrobat installed on the machine,The Spire.DataExport can create Excel spreadsheet and PDF document.</asp:label><asp:label id="Label1" style="Z-INDEX: 102; LEFT: 72px; POSITION: absolute; TOP: 128px" runat="server"
				Width="448px" ForeColor="Black" Height="16px"> Spire.DataExport totally independent and not affiliated with. </asp:label><asp:hyperlink id="HyperLink1" style="Z-INDEX: 103; LEFT: 80px; POSITION: absolute; TOP: 392px"
				runat="server" Width="224px" Height="24px" NavigateUrl="http:\\www.e-iceblue.com">http:\\www.e-iceblue.com</asp:hyperlink><asp:label id="Label2" style="Z-INDEX: 104; LEFT: 64px; POSITION: absolute; TOP: 32px" runat="server"
				Width="464px" Height="24px" Font-Bold="True" Font-Size="Large"> Spire.DataExport for .NET</asp:label><asp:radiobuttonlist id="RadioButtonList3" style="Z-INDEX: 106; LEFT: 80px; POSITION: absolute; TOP: 256px"
				runat="server" Width="548px" Height="56px" BorderStyle="Solid" BackColor="#FFE0C0" RepeatColumns="4">
				<asp:ListItem Value="0" Selected="True">XLS</asp:ListItem>
				<asp:ListItem Value="1">PDF</asp:ListItem>
				<asp:ListItem Value="2">RTF</asp:ListItem>
				<asp:ListItem Value="3">DBF</asp:ListItem>
				<asp:ListItem Value="4">MS Access</asp:ListItem>
				<asp:ListItem Value="5">XML</asp:ListItem>
				<asp:ListItem Value="6">SQL Script</asp:ListItem>
				<asp:ListItem Value="7">SYLK</asp:ListItem>
				<asp:ListItem Value="8">CSV</asp:ListItem>
				<asp:ListItem Value="9">DIF</asp:ListItem>
				<asp:ListItem Value="10">Text</asp:ListItem>
			</asp:radiobuttonlist><asp:image id="Image1" style="Z-INDEX: 107; LEFT: 552px; POSITION: absolute; TOP: 8px" runat="server"
				Width="158px" Height="138px" ImageUrl="http://www.e-iceblue.com/images/stories/exportlogo.gif"></asp:image>
			<asp:Label id="Label4" style="Z-INDEX: 108; LEFT: 72px; POSITION: absolute; TOP: 96px" runat="server"
				Width="104px" Height="24px" Font-Bold="True">important</asp:Label>
			<asp:Label id="Label5" style="Z-INDEX: 109; LEFT: 72px; POSITION: absolute; TOP: 216px" runat="server"
				Width="200px" Height="24px" Font-Bold="True">Quick Overview</asp:Label>
			<asp:Button id="Button2" style="Z-INDEX: 111; LEFT: 536px; POSITION: absolute; TOP: 424px" runat="server"
				Text="More..." Width="88px" onclick="Button2_Click"></asp:Button></form>
	</body>
</HTML>
