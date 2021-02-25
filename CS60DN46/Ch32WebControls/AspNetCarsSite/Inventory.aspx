<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Inventory.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView2" runat="server" CellPadding="4" AutoGenerateColumns="false" DataKeyNames="CarID, Timestamp" ItemType="AutoLotDAL.Models.Inventory" SelectMethod="GetData" DeleteMethod="Delete" UpdateMethod="Update" EmptyDataText="There are no data records to display." ForeColor="#333333" GridLines="None">
        <Columns>
            <asp:CommandField ShowDeleteButton="true" ShowEditButton="true" />
            <asp:BoundField DataField="CarID" HeaderText="CarID" ReadOnly="true" SortExpression="CarID" />
            <asp:BoundField DataField="Make" HeaderText="Make" SortExpression="Make" />
            <asp:BoundField DataField="Color" HeaderText="Color" SortExpression="Color" />
            <asp:BoundField DataField="PetName" HeaderText="PetName" SortExpression="PetName" />
        </Columns>
    </asp:GridView>
</asp:Content>

