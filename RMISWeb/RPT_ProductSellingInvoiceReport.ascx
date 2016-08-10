<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RPT_ProductSellingInvoiceReport.ascx.cs"
    Inherits="RPT_ProductSellingInvoiceReport" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<div class="table-responsive">
    <table>
        <tr>
            <td valign="middle" align="center">
                <asp:Label runat="server" ID="lblMediatorName" Text="<%$Resources:Resource,MediatorName%>"></asp:Label>:
                &nbsp;
            </td>
            <td>
                <p />
                <asp:TextBoxAutoExtender ID="txtMediatorName" runat="server" ServiceMethod="GetMediatorNames">
                </asp:TextBoxAutoExtender>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(And / OR)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td valign="middle" align="center">
                <asp:Label runat="server" ID="lblBuyerName" Text="<%$Resources:Resource,BuyerName%>"></asp:Label>:
                &nbsp;
            </td>
            <td>
                <p />
                <asp:TextBoxAutoExtender ID="txtBuyerNames" runat="server" ServiceMethod="GetBuyerNames">
                </asp:TextBoxAutoExtender>
            </td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                &nbsp;&nbsp;
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            </td>
        </tr>
    </table>
        <table>
        <tr>
            <td>
                <asp:PagingGridView ID="rptProductSellingInvoicInfo" runat="server" OnPageIndexChanging="rptProductSellingInvoicInfo_PageIndexChanging"
                    DataKeyNames="ProdID" AllowPaging="True" AutoGenerateColumns="false" OnRowCommand="rptProductSellingInvoicInfo_RowCommand"
                    CssClass="table table-hover table-striped" AlternatingRowStyle-Font-Bold="true">
                    <Columns>
                        <asp:BoundField DataField="MediatorName" SortExpression="MediatorName" HeaderText="Mediator Name" />
                        <asp:BoundField DataField="BuyerName" SortExpression="BuyerName" HeaderText="Buyer Name" />
                        <asp:BoundField DataField="ProductType" SortExpression="ProductType" HeaderText="Product Type" />
                        <asp:BoundField DataField="ProductName" SortExpression="ProductName" HeaderText="Product Name" />
                        <asp:BoundField DataField="UnitsType" SortExpression="UnitsType" HeaderText="UnitsType" />
                        <asp:BoundField DataField="TotalBags" SortExpression="TotalBags" HeaderText="Total Bags" />
                        <asp:BoundField DataField="Price" SortExpression="Price" HeaderText="Price" />
                        <asp:BoundField DataField="TotalPrice" SortExpression="TotalPrice" HeaderText="Total Price" />
                        
                        <asp:ButtonField ButtonType="Button" CommandName="PrintReceipt" Text="Print" />
                    </Columns>
                </asp:PagingGridView>
            </td>
        </tr>
    </table>
    <table width="100%">
        <tr>
            <td>
                <asp:Label ID="lblreportnodata" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt"
                    Height="900px" InteractiveDeviceInfos="(Collection)" WaitMessageFont-Names="Verdana"
                    WaitMessageFont-Size="14pt" Width="100%">
                    <LocalReport ReportPath="RDL_ProductSellingInvoiceReport.rdlc">
                        <DataSources>
                            <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="ProductSellingInvoiceDS" />
                        </DataSources>
                    </LocalReport>
                </rsweb:ReportViewer>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" TypeName="ProductSellingDataSetTableAdapters.">
                </asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</div>
