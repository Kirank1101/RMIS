<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RPTPaymentInfo.ascx.cs"
    Inherits="RPTPaymentInfo" %>
<div class="table-responsive">
    <table>
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
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                <asp:Button ID="btnClear" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>
</div>
