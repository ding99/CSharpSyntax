<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Required Field:"></asp:Label>
        <br />
        <asp:TextBox ID="RequiredFieldValidator1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Range 0 - 100:"></asp:Label>
        <br />
        <asp:TextBox ID="RangeValidator1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Enter your US SSN"></asp:Label>
        <br />
        <asp:TextBox ID="RegularExpressionValidator1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Value &lt; 20"></asp:Label>
        <br />
        <asp:TextBox ID="CompareValidator1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="lblValidationComplete" runat="server" Text="Button" />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Here are the things you must correct."></asp:Label>
        <br />
    </form>
</body>
</html>
