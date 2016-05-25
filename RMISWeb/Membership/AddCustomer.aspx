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

    <p>
                    <b>Select a customer: </b><br />
                    <asp:DropDownList ID="ddlCustomeList" runat="server" AppendDataBoundItems="true"
                        DataTextField="Name" DataValueField="CustId">
                        <asp:ListItem Text="[Select]" Value=""></asp:ListItem>
                    </asp:DropDownList>     &nbsp;  &nbsp;  &nbsp;
                    <asp:Button ID="btnSetCustomer" runat="server" Text="Set Customer" 
                        onclick="btnSetCustomer_Click" />
              
                </p>

                <p>     

         
        Enter a username: 
        <asp:TextBox ID="Username" runat="server"></asp:TextBox>
        <br />
        
        Choose a password:
        <asp:TextBox ID="Password" TextMode="Password" runat="server"></asp:TextBox>        
        <br />
        
       
                
        <asp:Button ID="CreateAccountButton" runat="server" 
            Text="Create the User Account" onclick="CreateAccountButton_Click" />
    </p>
    <p>
        <asp:Label ID="CreateAccountResults" runat="server"></asp:Label>
    </p>    

</asp:Content>

