<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Fun With Profiles"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Street Address"></asp:Label>
&nbsp;<asp:TextBox ID="txtStreet" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="City"></asp:Label>
&nbsp;<asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="State"></asp:Label>
&nbsp;<asp:TextBox ID="txtState" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit Data" />
            <br />
            <br />
            <asp:Label ID="lblUserData" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
