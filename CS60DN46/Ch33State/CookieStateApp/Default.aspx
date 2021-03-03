<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cookie Data</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Cookies"></asp:Label>
            <br /><hr />
            <asp:Label ID="Label2" runat="server" Text="Cookie Name: "></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label3" runat="server" Text="Cookie Value:"></asp:Label>
            <asp:TextBox ID="txtValue" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnWrite" runat="server" Text="Write This Cookie" OnClick="btnWrite_Click" />
            <br /><hr />
            <asp:Button ID="txtShow" runat="server" Text="Show Cookie Data" OnClick="btnShow_Click" />
            <br /><br />
            <asp:Label ID="lblCookieData" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
