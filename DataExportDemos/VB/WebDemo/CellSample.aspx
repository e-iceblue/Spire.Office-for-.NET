<%@ Page language="vb" AutoEventWireup="false" Inherits="Spire.WebDemo.CellSample" CodeFile="CellSample.aspx.vb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Welcome to Spire.DataExport Featured Demos</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="VB" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<style>BODY { FONT-WEIGHT: normal; FONT-SIZE: 9pt; COLOR: black; FONT-FAMILY: "Verdana" }
	P { MARGIN-TOP: -5px; FONT-WEIGHT: normal; COLOR: black; FONT-FAMILY: "Verdana" }
	B { MARGIN-TOP: -5px; FONT-WEIGHT: bold; COLOR: black; FONT-FAMILY: "Verdana" }
	H1 { FONT-WEIGHT: normal; FONT-SIZE: 18pt; COLOR: red; FONT-FAMILY: "Verdana" }
	H2 { FONT-WEIGHT: normal; FONT-SIZE: 14pt; COLOR: maroon; FONT-FAMILY: "Verdana" }
	PRE { FONT-SIZE: 0.9em; FONT-FAMILY: "Lucida Console" }
		</style>
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label2" style="Z-INDEX: 102; LEFT: 40px; POSITION: absolute; TOP: 24px" runat="server"
				Font-Size="Large" Font-Bold="True" Height="24px" Width="472px">Spire.DataExport for .NET</asp:label>
			<asp:button id="Button10" style="Z-INDEX: 130; LEFT: 400px; POSITION: absolute; TOP: 280px"
				runat="server" Width="96px" Text="Run"></asp:button>
			<asp:label id="Label19" style="Z-INDEX: 129; LEFT: 72px; POSITION: absolute; TOP: 312px" runat="server"
				Width="504px" Height="24px">This sample demonstrates how to work with Excel formulas inside a workbook.</asp:label>
			<asp:label id="Label18" style="Z-INDEX: 128; LEFT: 56px; POSITION: absolute; TOP: 288px" runat="server"
				Width="208px" Height="24px" Font-Bold="True" ForeColor="#C00000">03 - Formulas Sample</asp:label>
			<asp:label id="Label17" style="Z-INDEX: 116; LEFT: 80px; POSITION: absolute; TOP: 376px" runat="server"
				Width="456px" Height="24px">This sample demonstrates how to work with image inside a workbook.</asp:label>
			<asp:button id="Button8" style="Z-INDEX: 127; LEFT: 528px; POSITION: absolute; TOP: 224px" runat="server"
				Width="96px" Text="Chart2"></asp:button><asp:button id="btnTextSample" style="Z-INDEX: 125; LEFT: 400px; POSITION: absolute; TOP: 520px"
				runat="server" Width="96px" Text="Run"></asp:button><asp:button id="btnHyberLinks" style="Z-INDEX: 124; LEFT: 400px; POSITION: absolute; TOP: 456px"
				runat="server" Width="96px" Text="Run"></asp:button><asp:button id="btnStream" style="Z-INDEX: 119; LEFT: 400px; POSITION: absolute; TOP: 400px"
				runat="server" Width="96px" Text="Run"></asp:button><asp:label id="Label16" style="Z-INDEX: 123; LEFT: 56px; POSITION: absolute; TOP: 520px" runat="server"
				Font-Bold="True" Height="24px" Width="208px" ForeColor="#C00000">07 - Text Sample</asp:label><asp:label id="Label15" style="Z-INDEX: 122; LEFT: 88px; POSITION: absolute; TOP: 552px" runat="server"
				Height="24px" Width="456px">This sample demonstrates how to format text in cells.</asp:label><asp:label id="Label14" style="Z-INDEX: 121; LEFT: 88px; POSITION: absolute; TOP: 488px" runat="server"
				Height="24px" Width="456px">This sample demonstrates how to write hyperlinks in cells.</asp:label><asp:label id="Label13" style="Z-INDEX: 120; LEFT: 56px; POSITION: absolute; TOP: 464px" runat="server"
				Font-Bold="True" Height="24px" Width="208px" ForeColor="#C00000">06 - Hyperlinks Sample</asp:label><asp:label id="Label12" style="Z-INDEX: 118; LEFT: 56px; POSITION: absolute; TOP: 408px" runat="server"
				Font-Bold="True" Height="24px" Width="208px" ForeColor="#C00000">05 - Stream Sample</asp:label><asp:label id="Label11" style="Z-INDEX: 117; LEFT: 80px; POSITION: absolute; TOP: 432px" runat="server"
				Height="24px" Width="456px">This sample demonstrates how to save spreadsheet as stream.</asp:label><asp:button id="btnImages" style="Z-INDEX: 113; LEFT: 400px; POSITION: absolute; TOP: 344px"
				runat="server" Width="96px" Text="Run"></asp:button><asp:label id="Label9" style="Z-INDEX: 115; LEFT: 80px; POSITION: absolute; TOP: 376px" runat="server"
				Height="24px" Width="456px">This sample demonstrates how to work with image inside a workbook.</asp:label><asp:button id="btnCharts" style="Z-INDEX: 110; LEFT: 400px; POSITION: absolute; TOP: 224px"
				runat="server" Width="96px" Text="Chart1"></asp:button><asp:label id="Label8" style="Z-INDEX: 112; LEFT: 56px; POSITION: absolute; TOP: 344px" runat="server"
				Font-Bold="True" Height="24px" Width="208px" ForeColor="#C00000">04 - Images Sample</asp:label><asp:label id="Label7" style="Z-INDEX: 109; LEFT: 56px; POSITION: absolute; TOP: 232px" runat="server"
				Font-Bold="True" Height="24px" Width="208px" ForeColor="#C00000">02 - Charts Sample</asp:label><asp:label id="Label6" style="Z-INDEX: 108; LEFT: 72px; POSITION: absolute; TOP: 256px" runat="server"
				Height="24px" Width="528px">This sample demonstrates how to export data into excel charts inside a workbook.</asp:label><asp:label id="Label5" style="Z-INDEX: 104; LEFT: 56px; POSITION: absolute; TOP: 160px" runat="server"
				Font-Bold="True" Height="24px" Width="208px" ForeColor="#C00000">01 - Multi-Sheets Sample</asp:label><asp:image id="Image1" style="Z-INDEX: 101; LEFT: 608px; POSITION: absolute; TOP: 16px" runat="server"
				Height="136px" Width="158px" ImageUrl="http://www.e-iceblue.com/images/stories/exportlogo.gif"></asp:image><asp:label id="Label1" style="Z-INDEX: 103; LEFT: 56px; POSITION: absolute; TOP: 160px" runat="server"
				Font-Bold="True" Height="24px" Width="208px" ForeColor="#C00000">01 - Multi-Sheets Sample</asp:label><asp:label id="Label3" style="Z-INDEX: 105; LEFT: 72px; POSITION: absolute; TOP: 192px" runat="server"
				Height="24px" Width="536px">This sample demonstrates how to export data into multi-sheets in an excel workbook.</asp:label><asp:button id="btnMultiSheet" style="Z-INDEX: 106; LEFT: 400px; POSITION: absolute; TOP: 160px"
				runat="server" Width="96px" Text="Run"></asp:button><asp:label id="Label4" style="Z-INDEX: 107; LEFT: 48px; POSITION: absolute; TOP: 80px" runat="server"
				Height="40px" Width="464px" ForeColor="Blue"> Notes : Not needing to have Microsoft Excel installed on the machine,The Spire.DataExport can create Excel spreadsheet document.</asp:label>
			<asp:Button id="btnReturn" style="Z-INDEX: 126; LEFT: 680px; POSITION: absolute; TOP: 520px"
				runat="server" Width="96px" Text="Return"></asp:Button>
		</form>
	</body>
</HTML>
