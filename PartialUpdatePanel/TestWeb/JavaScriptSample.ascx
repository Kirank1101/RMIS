<%@ Control Language="C#" AutoEventWireup="true" CodeFile="JavaScriptSample.ascx.cs" Inherits="JavaScriptSample" %>
The following text will be shown in an alert-Box after partial post back<br />
<br />
<asp:Label ID="Label1" runat="server" Text="Text" />
<asp:TextBox ID="TextBox1" runat="server" />
<asp:Button ID="Button1" runat="server" Text="Show" OnClick="Button1_Click" />