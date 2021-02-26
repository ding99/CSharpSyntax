<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validator Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="Label5" runat="server" Font-Bold="true" Font-Size="X-Large" Text="ASP.NET Validators"></asp:Label>
        <hr />

        <asp:Label ID="Label1" runat="server" Font-Bold="true" Text="Required Field:"></asp:Label>
        <br />
        <asp:TextBox ID="txtRequiredField" runat="server">Please enter your name</asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtRequiredField" ErrorMessage="Oops! Need to enter data."></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label2" runat="server" Font-Bold="true" Text="Range 0 - 100:"></asp:Label>
        <br />
        <asp:TextBox ID="txtRange" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtRange" ErrorMessage="Please enter value between 0 and 100." MaximumValue="100" MinimumValue="0" Type="Integer"></asp:RangeValidator>
        <br />

        <asp:Label ID="Label3" runat="server" Font-Bold="true" Text="Enter your US SSN"></asp:Label>
        <br />
        <asp:TextBox ID="txtRegExp" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtRegExp" ErrorMessage="Please enter a valid US SSN." ValidationExpression="\d{3}-\d{2}-\d{4}" ></asp:RegularExpressionValidator>
        <br />

        <asp:Label ID="Label4" runat="server" Font-Bold="true" Text="Value &lt; 20"></asp:Label>
        <br />
        <asp:TextBox ID="txtComparison" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtComparison" ErrorMessage="Enter a value less than 20." Operator="LessThan" ValueToCompare="20" Type="Integer" ></asp:CompareValidator>
        <br />

        <asp:Button ID="btnPostBack" runat="server" Text="Post Back" OnClick="btnPostBack_Click" />
        <br />
        <hr />
        <asp:Label ID="lblValidationComplete" runat="server"></asp:Label>
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server"  Width="353px" HeaderText="Here are the things you must correct." />
        </div>
    </form>
</body>
</html>
