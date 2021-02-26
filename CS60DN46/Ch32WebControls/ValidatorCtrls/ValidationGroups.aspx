<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ValidationGroups.aspx.cs" Inherits="ValidationGroups" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <asp:Panel ID="Panel1" runat="server" Height="83px" Width="296px">
            <asp:TextBox ID="txtRequiredData" runat="server" ValidationGroup="FirstGroup"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Required field!" ControlToValidate="txtRequiredData" ValidationGroup="FirstGroup"></asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="btnValidateRequired" runat="server" OnClick="btnValidateRequired_Click" Text="Validate" ValidationGroup="FirstGroup" />
        </asp:Panel>

        <asp:Panel ID="Panel2" runat="server" Height="119px" Width="295px">
            <asp:TextBox ID="txtSSN" runat="server" ValidationGroup="SecondGroup"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtSSN" ValidationExpression="\d{3}-\d{2}-\d{4}" ValidationGroup="SecondGroup" ErrorMessage="*Need SSN"></asp:RegularExpressionValidator>
            <br />
            <asp:Button ID="btnValidateSSN" runat="server" OnClick="btnValidateSSN_Click" Text="Validate" ValidationGroup="SecondGroup" />
        </asp:Panel>
    </form>
</body>
</html>
