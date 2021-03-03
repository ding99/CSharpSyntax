<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Data Caching</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="The Add New Car Page"></asp:Label>
            <br /><hr />
            <asp:Label ID="Lable2" runat="server" Text="Make"></asp:Label>
            <asp:TextBox ID="txtCarMake" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label3" runat="server" Text="Color"></asp:Label>
            <asp:TextBox ID="txtCarColor" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label4" runat="server" Text="Pet Name"></asp:Label>
            <asp:TextBox ID="txtCarPetName" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnAddCar" runat="server" Text="Add This Car" OnClick="btnAddCar_Click" />
            <br /><hr id="HR1" />
            <asp:Label ID="Label5" runat="server" Font-Size="X-Large" Text="Current Inventory"></asp:Label>
            <br /><br />
            <asp:GridView ID="carsGridView" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
