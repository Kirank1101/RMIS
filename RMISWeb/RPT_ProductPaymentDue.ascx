﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RPT_ProductPaymentDue.ascx.cs"
    Inherits="RPT_ProductPaymentDue" %>
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
            <td>
                <asp:Label runat="server" ID="lblBuyername" Text="<%$Resources:Resource,BuyerName%>"></asp:Label>:
                <span style="color: Red">*</span>&nbsp;
            </td>
            <td>
                <p />
                <asp:TextBoxAutoExtender ID="txtBuyerName" runat="server" ServiceMethod="GetBuyerNames">
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
                <asp:Label ID="lblreportnodata" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt"
                    Height="550px" InteractiveDeviceInfos="(Collection)" WaitMessageFont-Names="Verdana"
                    WaitMessageFont-Size="14pt" Width="100%">
                    <LocalReport ReportPath="RDL_ProductPaymentDueReport.rdlc">
                        <DataSources>
                            <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="ProductPaymentDue" />
                        </DataSources>
                    </LocalReport>
                </rsweb:ReportViewer>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" TypeName="PaddyPaymentDueDataSetTableAdapters.">
                </asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</div>
