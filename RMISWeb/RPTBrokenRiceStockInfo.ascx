<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RPTBrokenRiceStockInfo.ascx.cs"
    Inherits="RPTBrokenRiceStockInfo" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblBrokenRiceType" Text="<%$Resources:Resource,BrokenRiceType%>"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlBrokenRiceType" runat="server" AppendDataBoundItems="true">
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
