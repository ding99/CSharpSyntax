<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Inventory.aspx.cs" Inherits="InventoryPage" Async="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>Here is our current Inventory!</p>
    <p>
    <asp:DropDownList ID="cboMake" SelectMethod="GetMakes" AppendDataBoundItems="true" AutoPostBack="true" DataTextField="Make" DataValueField="Make" runat="server">
        <asp:ListItem Value="" Text="(All)" />
    </asp:DropDownList>
    </p>
    <p>
        Filter Model Type:
    <asp:GridView ID="carsGrid" runat="server" AllowPaging="true" PageSize="3" AllowSorting="true" AutoGenerateColumns="false" CellPadding="4" DataKeyNames="CarID, Timestamp" ItemType="AutoLotDAL.Models.Inventory" SelectMethod="GetData" DeleteMethod="Delete" UpdateMethod="Update" EmptyDataText="There are no data records to display." ForeColor="#333333" GridLines="None">
        <Columns>
            <asp:CommandField ShowDeleteButton="true" ShowEditButton="true" />
            <asp:BoundField DataField="CarID" HeaderText="CarID" ReadOnly="true" SortExpression="CarID" />
            <asp:BoundField DataField="Make" HeaderText="Make" SortExpression="Make" />
            <asp:BoundField DataField="Color" HeaderText="Color" SortExpression="Color" />
            <asp:BoundField DataField="PetName" HeaderText="PetName" SortExpression="PetName" />
        </Columns>
    </asp:GridView>
    </p>
</asp:Content>

