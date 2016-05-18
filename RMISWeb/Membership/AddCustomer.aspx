<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AddCustomer.aspx.cs" Inherits="Membership_AddCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<h2>Add New Customer</h2>
<br />

 <p>
        Customer Name: 
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        <br />
        
        Organization Name:
        <asp:TextBox ID="txtOrganization"  runat="server"></asp:TextBox>        
        <br />       
                
        <asp:Button ID="btnCreateCustomer" runat="server" 
            Text="Create customer" onclick="btnCreateCustomer_Click"  />
    </p>
</asp:Content>

