<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RPTRiceStockInfo.ascx.cs"
    Inherits="RPTRiceStockInfo" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblRiceType" Text="<%$Resources:Resource,RiceType%>"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlRiceType" runat="server" AppendDataBoundItems="true">
                    <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblRiceBrandName" Text="<%$Resources:Resource,BrandName%>"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlRiceBrand" 
                    runat="server" AutoPostBack="true" AppendDataBoundItems="true">
                    <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                </asp:DropDownList>
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
