<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Annotations.aspx.cs" Inherits="Annotations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:FormView ID="fvDataBinding" runat="server" DataKeyNames="CarID" ItemType="Inventory" DefaultMode="Insert" InsertMethod="SaveCar" UpdateMethod="UpdateCar" SelectMethod="GetCar">
        </asp:FormView>
    </form>
</body>
</html>
