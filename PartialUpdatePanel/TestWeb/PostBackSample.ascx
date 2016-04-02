<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PostBackSample.ascx.cs"
    Inherits="PostBackSample" %>
Last PostBack source:
<asp:Label ID="LabelSource" runat="server" Text="None"></asp:Label><br />
<br />
<asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /><br />
<br />
<asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton><br />
<br />
<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    <asp:ListItem Text="One" Value="One" />
    <asp:ListItem Text="Two" Value="Two" />
    <asp:ListItem Text="Three" Value="Three" />
</asp:DropDownList>
<br />
<br />
<asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple">
    <asp:ListItem Text="One" Value="One" />
    <asp:ListItem Text="Two" Value="Two" />
    <asp:ListItem Text="Three" Value="Three" />
</asp:ListBox>
