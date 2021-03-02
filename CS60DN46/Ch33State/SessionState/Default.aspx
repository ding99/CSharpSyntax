<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label8" runat="server" Font-Size="X-Large" Text="Session State"></asp:Label>
            <br /><hr />
            <asp:Label ID="Label9" runat="server" Text="Which Color?"></asp:Label>
&nbsp;<asp:TextBox ID="txtColor" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label10" runat="server" Text="Which Make?"></asp:Label>
&nbsp;<asp:TextBox ID="txtMake" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label11" runat="server" Text="Down Payment?"></asp:Label>
&nbsp;<asp:TextBox ID="txtDownPay" runat="server"></asp:TextBox>
            <br /><br />
            <asp:CheckBox ID="chkLease" runat="server" Text="Lease?" />
            <br /><br />
            <asp:Label ID="Label12" runat="server" Text="Delivery Date:"></asp:Label>
            <br />
            <asp:Calendar ID="myCalender" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
                <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                <WeekendDayStyle BackColor="#CCCCFF" />
            </asp:Calendar>
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick ="btnSubmit_Click" />
            <br /><hr />
            <asp:Label ID="lblID" runat="server"></asp:Label>
            <br /><br />
            <asp:Label ID="lblInfo" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
