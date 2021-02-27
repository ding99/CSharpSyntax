<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Simple State Example</h2>
            <asp:Button ID="btnSetCar" runat="server" Text="Set Favorite Car" />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnGetCar" runat="server" Text="Get Favorite Car" />
            <asp:Label ID="lblFavCar" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
