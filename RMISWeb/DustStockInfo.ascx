﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DustStockInfo.ascx.cs"
    Inherits="DustStockInfo" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblUnits" Text="<%$Resources:Resource,UnitType%>"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlUnitsType" runat="server" AppendDataBoundItems="true">
                    <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>        
        <tr>
            <td>
                <asp:Label runat="server" ID="lbltotalbags" Text="<%$Resources:Resource,TotalBags%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtTotalBags" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                <asp:Button ID="Button2" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>
</div>
