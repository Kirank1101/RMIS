<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RPTPaddyPurchasedInfo.ascx.cs"
    Inherits="RPTPaddyPurchasedInfo" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblPaddyType" Text="<%$Resources:Resource,PaddyType%>"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlPaddyType" runat="server" AppendDataBoundItems="true">
                    <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblsellername" Text="<%$Resources:Resource,SellerName%>"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlsellernames" runat="server" AppendDataBoundItems="true">
                    <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblPaddyPurchasedDated" Text="<%$Resources:Resource,PaddyPurchasedDate%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPaddyPurchasedFromDate" runat="server"></asp:TextBox> &nbsp; &&nbsp;  <asp:TextBox ID="txtPaddyPurchasedToDate" runat="server"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                <asp:Button ID="btnClear" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>
</div>
