<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MenuItems.ascx.cs" Inherits="MenuItems" %>
<ul class="nav side-menu">
    <li><a><i class="fa fa-sitemap"></i>All Config<span class="fa fa-chevron-down"></span></a>
        <ul class="nav child_menu">
            <asp:PlaceHolder ID="phMenuItems" runat="server"></asp:PlaceHolder>
        </ul>
    </li>
</ul>
