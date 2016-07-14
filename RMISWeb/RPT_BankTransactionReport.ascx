<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RPT_BankTransactionReport.ascx.cs"
    Inherits="RPT_BankTransactionReport" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblTransFromDate" Text="<%$Resources:Resource,FromDate%>"></asp:Label>:
                &nbsp;&nbsp; 
            </td>
            <td>
                <asp:TextBoxDatenTimeExtender ID="txtTransFromDate" runat="server"></asp:TextBoxDatenTimeExtender>
                &nbsp;&nbsp;
            </td>
            <td>
                <asp:Label runat="server" ID="lbltransToDate" Text="<%$Resources:Resource,ToDate%>"></asp:Label>:
                &nbsp;&nbsp; 
            </td>
            <td>
                To &nbsp;&nbsp;
                <asp:TextBoxDatenTimeExtender ID="txtTransToDate" runat="server"></asp:TextBoxDatenTimeExtender>
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
                <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt"
                    Height="900px" InteractiveDeviceInfos="(Collection)" WaitMessageFont-Names="Verdana"
                    WaitMessageFont-Size="14pt" Width="100%">
                    <LocalReport ReportPath="RDL_BankTransactionReport.rdlc">
                        <DataSources>
                            <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="BankTransaction" />
                        </DataSources>
                    </LocalReport>
                </rsweb:ReportViewer>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" TypeName="BankTransactionDataSetTableAdapters.">
                </asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</div>
