<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductReturnInfo.ascx.cs"
    Inherits="ProductReturnInfo" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblOrderNo" Text="<%$Resources:Resource,OrderNo%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtorderno" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblprductsellingtype" Text="<%$Resources:Resource,ProductSellingType%>"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlProductTypeID" runat="server" AppendDataBoundItems="true">
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
                <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                <asp:Button ID="Button2" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>
</div>
