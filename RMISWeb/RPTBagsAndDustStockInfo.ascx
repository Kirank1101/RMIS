<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RPTBagsAndDustStockInfo.ascx.cs"
    Inherits="RPTBagsAndDustStockInfo" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblBagType" Text="<%$Resources:Resource,BagType%>"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlBagType" runat="server">
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
