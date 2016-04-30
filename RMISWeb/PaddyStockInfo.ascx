<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PaddyStockInfo.ascx.cs" Inherits="PaddyStockInfo" %>
<div class="table-responsive">
<h3>Paddy Stock Infor</h3>
    <table>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblsellername" Text="<%$Resources:Resource,SellerName%>"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlsellernames" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblPaddyType" Text="<%$Resources:Resource,PaddyType%>"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlPaddyType" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblGodownName" Text="<%$Resources:Resource,GodownName%>"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlGodownname" OnSelectedIndexChanged="ddlGodownSelectedIndexChanged" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblLotDetails" Text="<%$Resources:Resource,LotDetails%>"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlLotDetails" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblvehicalno" Text="<%$Resources:Resource,VehicalNo%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtVehicalNo" />
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
                <asp:Label runat="server" ID="lblQWeight" Text="<%$Resources:Resource,QWeight%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtQweight" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblQPrice" Text="<%$Resources:Resource,QPrice%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtQprice" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblPruchaseDate" Text="<%$Resources:Resource,PruchaseDate%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtPruchaseDate" />
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