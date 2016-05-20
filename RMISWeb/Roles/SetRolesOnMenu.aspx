<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SetRolesOnMenu.aspx.cs" Inherits="Roles_SetRolesOnMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

 <h3>Role-Based Authorization Demo</h3>

  <h2>User Role Management</h2>
    <p align="center">
        <asp:Label ID="ActionStatus" runat="server" CssClass="Important"></asp:Label>
    </p>
    <h3>Manage Roles By User</h3>
    <p>
        <b>Select a Menu Item:</b>
        <asp:DropDownList ID="UserList" runat="server" AutoPostBack="True" 
            DataTextField="Title" DataValueField="MenuID" 
           >
        </asp:DropDownList>
    </p>
    

    <p>
       <b>Select a Role:</b>
        <asp:DropDownList ID="RoleList" runat="server" >
        </asp:DropDownList>
    </p>

    <p>
       <b>Selected a Customer:</b>
       <asp:Label ID="lblCustomer" runat="server" ></asp:Label>
    </p>

     <p>
         <asp:Button ID="btnAdd" runat="server" Text="Set Role" onclick="btnAdd_Click" />
     </p> 


     <asp:GridView ID="gdAll" runat="server" AutoGenerateColumns="true" 
            EmptyDataText="No Data belong to this role." >
           
           
        </asp:GridView>

</asp:Content>


