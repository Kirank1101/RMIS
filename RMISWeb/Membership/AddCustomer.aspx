<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="AddCustomer.aspx.cs" Inherits="Membership_AddCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">
    <p>
        <asp:Label CssClass="Important" ID="CreateAccountResults" runat="server"></asp:Label>
    </p>
    <h2>
        Add New Customer</h2>
    <br />
    <p>
        Customer Name:
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        <br />
        Organization Name:
        <asp:TextBox ID="txtOrganization" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnCreateCustomer" runat="server" Text="Create customer" OnClick="btnCreateCustomer_Click" />
    </p>
    <p>
        <b>Select a customer: </b>
        <br />
        <asp:DropDownList ID="ddlCustomeList" runat="server" AppendDataBoundItems="true"
            AutoPostBack="true" DataTextField="Name" DataValueField="CustId" Height="59px"
            OnSelectedIndexChanged="ddlCustomeList_SelectedIndexChanged" Width="207px">
            <asp:ListItem Text="[Select]" Value=""></asp:ListItem>
        </asp:DropDownList>
        &nbsp; &nbsp; &nbsp;
    </p>
    <h2>
        Manage Roles</h2>
    <p>
        <b>Create a New Role: </b>
        <asp:TextBox ID="RoleName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RoleNameReqField" runat="server" ControlToValidate="RoleName"
            Display="Dynamic" ErrorMessage="You must enter a role name."></asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="CreateRoleButton" runat="server" Text="Create Role" OnClick="CreateRoleButton_Click" />
    </p>
    <p>
        <asp:GridView ID="gdRoleList" runat="server" AutoGenerateColumns="False" OnRowDeleting="RoleList_RowDeleting">
            <Columns>
                <asp:CommandField DeleteText="Delete Role" ShowDeleteButton="True" />
                <asp:TemplateField HeaderText="Role">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="RoleNameLabel" Text='<%# Container.DataItem %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </p>
    <h2>
        Add New User</h2>
    <p>
        Enter a username:
        <asp:TextBox ID="Username" runat="server"></asp:TextBox>
        <br />
        Choose a password:
        <asp:TextBox ID="Password" TextMode="Password" runat="server"></asp:TextBox>
        <br />
        <p>
            <b>Select a Role:</b>
            <asp:DropDownList ID="ddlRoles" runat="server">
            </asp:DropDownList>
        </p>
        <asp:Button ID="CreateAccountButton" runat="server" Text="Create the User Account"
            OnClick="CreateAccountButton_Click" />
        <asp:GridView ID="gdUsers" runat="server" AutoGenerateColumns="true" EmptyDataText="No Data belong to this role.">
        </asp:GridView>
    </p>
    <h3>
        Role-Based Authorization</h3>
    <h2>
        User Role Management</h2>
    <p align="center">
        <asp:Label ID="ActionStatus" runat="server" CssClass="Important"></asp:Label>
    </p>
    <h3>
        Manage Roles By User</h3>
    <p>
        <b>Select a Menu Item:</b>
        <asp:DropDownList ID="UserList" runat="server" AutoPostBack="True" DataTextField="Title"
            DataValueField="MenuID">
        </asp:DropDownList>
    </p>
    <p>
        <b>Select a Role:</b>
        <asp:DropDownList ID="RoleList" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        <b>Selected a Customer:</b>
        <asp:Label ID="lblCustomer" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnAdd" runat="server" Text="Set Role" OnClick="btnAdd_Click" />
    </p>
    <asp:GridView ID="gdAll" runat="server" AutoGenerateColumns="true" EmptyDataText="No Data belong to this role.">
    </asp:GridView>
</asp:Content>
