<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RPT_PaddyPurchaseReceiptReport.ascx.cs"
    Inherits="RPT_PaddyPurchaseReceiptReport" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblsellername" Text="<%$Resources:Resource,SellerName%>"></asp:Label>:
                &nbsp;&nbsp;
            </td>
            <td>
                <p />
                <asp:TextBoxAutoExtender ID="txtsellername" runat="server" ServiceMethod="GetSellerNames">
                </asp:TextBoxAutoExtender>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td>
                <asp:Label runat="server" ID="lblPruchaseDate" Text="<%$Resources:Resource,PruchaseDate%>"></asp:Label>:
                &nbsp;&nbsp; From
            </td>
            <td>
                <asp:TextBoxDatenTimeExtender ID="txtPruchaseDatefrom" runat="server"></asp:TextBoxDatenTimeExtender>
                &nbsp;&nbsp;
            </td>
            <td>
                To &nbsp;&nbsp;
                <asp:TextBoxDatenTimeExtender ID="txtPruchaseDateTo" runat="server"></asp:TextBoxDatenTimeExtender>
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
                <asp:PagingGridView ID="rptPaddyStockInfo" runat="server" OnPageIndexChanging="rptPaddyStockInfo_PageIndexChanging"
                    DataKeyNames="Id" AllowPaging="True" AutoGenerateColumns="false" OnRowCommand="rptPrintReceipt_RowCommand"
                     CssClass="table table-hover table-striped"
                    AlternatingRowStyle-Font-Bold="true">
                    <Columns>
                        <asp:BoundField DataField="SellerName" SortExpression="SellerName" HeaderText="Seller Name" />
                        <asp:BoundField DataField="PaddyName" SortExpression="PaddyName" HeaderText="Paddy Name" />
                        <asp:BoundField DataField="UnitName" SortExpression="UnitName" HeaderText="Unit Name" />
                        <asp:BoundField DataField="TotalBags" SortExpression="TotalBags" HeaderText="Total Bags" />
                        <asp:BoundField DataField="Price" SortExpression="Price" HeaderText="Price" />
                        <asp:BoundField DataField="PurchaseDate" SortExpression="PurchaseDate" HeaderText="Purchase Date" />
                         <asp:ButtonField ButtonType="Button" CommandName="PayAmount" Text="Pay" />
                    </Columns>
                </asp:PagingGridView>
            </td>
        </tr>
    </table>
    <table>
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
                    <LocalReport ReportPath="RDL_PaddyPurchaseReport.rdlc">
                        <DataSources>
                            <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="PaddyPurchaseBillDS" />
                        </DataSources>
                    </LocalReport>
                </rsweb:ReportViewer>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" TypeName="PaddyStockDataSetTableAdapters.">
                </asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</div>
