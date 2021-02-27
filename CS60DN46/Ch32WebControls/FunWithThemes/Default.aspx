<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Theme="CrazyOrange" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h2>Fun With Themes</h2>
    <form id="form1" runat="server">
        <asp:Button ID="btnNoTheme" runat="server" Text="No Theme" OnClick="btnNoTheme_Click" />
        &nbsp;
        <asp:Button ID="btnGreenTheme" runat="server" Text="Green Theme" OnClick="btnGreenTheme_Click" />
        &nbsp;
        <asp:Button ID="btnOrangeTheme" runat="server" Text="Orange Theme" OnClick="btnOrangeTheme_Click" />
        <hr />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Text="Theme Sample"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Big Font!" SkinID="BigFontButton" />
    </form>
</body>
</html>
