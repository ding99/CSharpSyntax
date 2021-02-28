<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" EnableViewState="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="Lable1" runat="server" Font-Size="X-Large" Text="View State"></asp:Label><br />
        <hr />
        </div>
        <asp:ListBox ID="myListBox" runat="server">
        </asp:ListBox>
        <br />
        <br />
        <asp:Button ID="btnPostback" runat="server" Text="Button" />
    </form>
</body>
</html>
