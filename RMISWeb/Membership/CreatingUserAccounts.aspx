<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CreatingUserAccounts.aspx.cs"
    Inherits="Membership_CreatingUserAccounts" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">
    <h2>
        Create a New User Account</h2>
    <p>
    </p>
    <p>
        <asp:Label runat="server" ID="InvalidUserNameOrPasswordMessage" Visible="false" EnableViewState="false"
            ForeColor="Red"></asp:Label>
    </p>
</asp:Content>
