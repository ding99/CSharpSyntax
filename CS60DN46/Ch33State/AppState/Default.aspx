<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Application State"></asp:Label>
        <div>
            <asp:Button ID="btnShowCarOnSale" runat="server" Text="Show Car On Sale" OnClick="btnShowcarOnSale_Click" />
            <br />
            <br />
            <asp:Label ID="lblCurrCarOnSale" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
