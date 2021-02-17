<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dynamic Control Test</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <hr />
            <h1>Dynamic Controls</h1>
            <asp:Label ID="lblTextBoxText" runat="server"></asp:Label>
            <hr />
        </div>
        <!-- The Panel has three contained controls -->
        <asp:Panel ID="myPanel" runat="server" Height="218px">
            <asp:TextBox ID="myTextBox" runat="server"></asp:TextBox>
            <br/>
            <br/>
            <asp:Button ID="myButton" runat="server" Text="Button" />
            <br/>
            <br/>
            <asp:HyperLink ID="myLink" runat="server">HyperLink</asp:HyperLink>
        </asp:Panel>
        <br/>
        <br/>
        <asp:Label ID="lblControlInfo" runat="server"></asp:Label>
    </form>
</body>
</html>
