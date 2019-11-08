<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="app2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
		<asp:Panel ID="errorPanel" runat="server" Visible="false">
			<asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
		</asp:Panel>
        <div>
			<h1>App2 test</h1>
			Email of user <asp:Label ID="txtEmail" runat="server" Text="txtEmail"></asp:Label><br />
			LinnworksId of user: <asp:Label ID="txtLinnworksId" runat="server" Text="txtLinnworksId"></asp:Label>
        </div>
    </form>
</body>
</html>
