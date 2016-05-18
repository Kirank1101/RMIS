<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DustSellingInfo.ascx.cs"
    Inherits="DustSellingInfo" %>
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
                <asp:Label runat="server" ID="lblvehicalno" Text="<%$Resources:Resource,VehicalNo%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtVehicalNo" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblDriverName" Text="<%$Resources:Resource,DriverName%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtDriverName" />
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
                <asp:Label runat="server" ID="lblSellingDate" Text="<%$Resources:Resource,SellingDate%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtSellingDate" />
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
