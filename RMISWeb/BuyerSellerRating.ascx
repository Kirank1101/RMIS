<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BuyerSellerRating.ascx.cs"
    Inherits="BuyerSellerRating" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblSellerName" Text="<%$Resources:Resource,SellerName%>"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlsellernames" runat="server" AppendDataBoundItems="true">
                    <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
            <asp:Label runat="server" ID="lblrRating" Text="<%$Resources:Resource,Rating%>"></asp:Label>
            </td>
            <td>
                <asp:RadioButtonList ID="rbtLstRating" runat="server" RepeatDirection="Horizontal"
                    RepeatLayout="Table">
                    <asp:ListItem Text="Excellent" Value="5"></asp:ListItem>
                    <asp:ListItem Text="Very Good" Value="4"></asp:ListItem>
                    <asp:ListItem Text="Good" Value="3"></asp:ListItem>
                    <asp:ListItem Text="Fair" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Bad" Value="1"></asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblrRemarks" Text="<%$Resources:Resource,Remarks%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtRemarks" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>
</div>
