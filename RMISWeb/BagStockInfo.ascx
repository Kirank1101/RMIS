<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BagStockInfo.ascx.cs"
    Inherits="BagStockInfo" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<div class="table-responsive">
    <h3>
        Add Bag Stock</h3>
    <table>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblsellername" Text="<%$Resources:Resource,SellerName%>"></asp:Label>
            </td>
            <td>
                <asp:TextBoxAutoExtender ID="txtsellerName" runat="server" ServiceMethod="GetSellerNames">
                </asp:TextBoxAutoExtender>
            </td>
        </tr>
        
        <tr>
            <td>
                <asp:Label runat="server" ID="Label2" Text="<%$Resources:Resource,RiceBrandName%>"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlRiceBrand" runat="server" AppendDataBoundItems="true">
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
    <table>
        <tr>
            <td>
                <asp:PagingGridView ID="rptBagStockInfo" Width="80%" runat="server" OnPageIndexChanging="rptBagStockInfo_PageIndexChanging"
                    AlternatingRowStyle-BorderColor="Red" DataKeyNames="Id" AllowPaging="True" AutoGenerateColumns="false"
                    CssClass="table table-hover table-striped" AlternatingRowStyle-Font-Bold="true">
                    <Columns>
                        <asp:BoundField DataField="SellerName" HeaderText="Seller Name" />
                        <asp:BoundField DataField="TypeBrand" HeaderText="Type/Brand" />
                        <asp:BoundField DataField="UnitName" HeaderText="Unit Name(KG)" />
                        <asp:BoundField DataField="TotalBags" HeaderText="Total Bags" />
                        <asp:BoundField DataField="Price" HeaderText="Price Per Bag" />
                        <asp:BoundField DataField="TotalAmount" HeaderText="Total Amount" />
                        <asp:BoundField DataField="PurchaseDate" HeaderText="Purchase Date" />
                        <asp:BoundField DataField="VehicalNo" HeaderText="Vehical Number" />
                        <asp:BoundField DataField="DriverName" HeaderText="Driver Name" />
                    </Columns>
                </asp:PagingGridView>
            </td>
        </tr>
    </table>
</div>
