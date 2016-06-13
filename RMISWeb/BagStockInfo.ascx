<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BagStockInfo.ascx.cs"
    Inherits="BagStockInfo" %>
<div class="table-responsive">
    <h3>
        Bag Stock Infor</h3>
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
                <asp:Label runat="server" ID="lblBagType" Text="<%$Resources:Resource,BagType%>"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlBagType" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="Label2" Text="<%$Resources:Resource,RiceBrandName%>"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlRiceBrand" runat="server" AppendDataBoundItems="true" 
                    Height="16px">
                    <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblriceunittype" Text="<%$Resources:Resource,UnitType%>"></asp:Label>
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
                <asp:Label runat="server" ID="lblPricePerBag" Text="<%$Resources:Resource,PricePerBag%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtpricePerBag" />
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
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                <asp:Button ID="Button2" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>
</div>