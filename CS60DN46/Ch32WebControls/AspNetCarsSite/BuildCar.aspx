<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BuildCar.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lblOrder" runat="server" Text="Build your Dream Car"></asp:Label>
    <p>
        <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="3" OnFinishButtonClick="ColorID_FinishButtonClick">
            <WizardSteps>
                <asp:WizardStep ID="WizardStep1" runat="server" title="Pick  Your Model">
                    <asp:TextBox ID="ModelID" runat="server"></asp:TextBox>
                </asp:WizardStep>
                <asp:WizardStep ID="WizardStep2" runat="server" title="Pick Your Color">
                    <asp:ListBox ID="ColorID" runat="server" Width="237px">
                        <asp:ListItem>Purple</asp:ListItem>
                        <asp:ListItem>Green</asp:ListItem>
                        <asp:ListItem>Red</asp:ListItem>
                        <asp:ListItem>Yellow</asp:ListItem>
                        <asp:ListItem>Pea Soup</asp:ListItem>
                        <asp:ListItem>Black</asp:ListItem>
                        <asp:ListItem>Lime Green</asp:ListItem>
                    </asp:ListBox>
                </asp:WizardStep>
                <asp:WizardStep ID="WizardStep3" runat="server" Title="Name Your Car">
                    <asp:TextBox ID="NameID" runat="server"></asp:TextBox>
                </asp:WizardStep>
                <asp:WizardStep ID="WizardStep4" runat="server" Title="Delivery Data">
                    <asp:Calendar ID="DateID" runat="server"></asp:Calendar>
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
    </p>
</asp:Content>

