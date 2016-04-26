<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DataBindingSample.ascx.cs" Inherits="DataBindingSample" %>
<asp:XmlDataSource ID="XmlDataSource1" runat="server" 
    DataFile="~/App_Data/Countries.xml"></asp:XmlDataSource>
<asp:GridView ID="GridView1" runat="server" AllowPaging="True" CellPadding="4" PageSize="5"  CssClass="table table-condensed table-hover"
    DataSourceID="XmlDataSource1" GridLines="None" AutoGenerateColumns="false"> 
   
   
    <Columns>
        <asp:BoundField HeaderText="Country-Code" DataField="code" />
        <asp:BoundField HeaderText="Countryname" DataField="name" />
    </Columns>
</asp:GridView>
