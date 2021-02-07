<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong style="font-weight:700">Basic Request / Response Info
                <br />
                <asp:Button ID="btnGetBrowserStats" runat="server" OnClick="btnGetBrowserStats_Click" Text="Get Stats" BorderColor="Green" BorderStyle="Solid" BorderWidth="3px" />
                <br />
                <asp:Label ID="lblOutput" runat="server"></asp:Label>
                <br />
                <br />
                <label>First name</label>
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="btnGetFormData" runat="server" OnClick="btnGetFormData_Click" Text="Get First Name" />
                <br />
                <br />
                <asp:Button runat="server" ID="btnHttpResponse" OnClick="btnHttpResponse_Click" Text="Get First Name" BolderColor="DarkCyan" BorderWidth="3" BackColor="Cyan" />
                <br />
                <br />
                <asp:Button runat="server" ID="btnTriggerError" OnClick="btnTriggerError_Click" Text="Trigger Error" BolderColor="DarkRed" BorderWidth="3" />
            </strong>
        </div>
    </form>
</body>
</html>
