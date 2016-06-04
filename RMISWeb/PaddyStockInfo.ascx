﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PaddyStockInfo.ascx.cs"
    Inherits="PaddyStockInfo" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<div class="table-responsive">
    <table>
        <tr>
            <td valign="top" style="padding-right: 70px">
            <h3>Paddy Stock Info</h3>
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
                            <asp:Label runat="server" ID="lblPaddyType" Text="<%$Resources:Resource,PaddyType%>"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlPaddyType" runat="server" AppendDataBoundItems="true">
                                <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblGodownName" Text="<%$Resources:Resource,GodownName%>"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlGodownname" OnSelectedIndexChanged="ddlGodownSelectedIndexChanged"
                                runat="server" AutoPostBack="true" AppendDataBoundItems="true">
                                <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblLotDetails" Text="<%$Resources:Resource,LotDetails%>"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlLotDetails" runat="server" AppendDataBoundItems="true">
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
                            <asp:Label runat="server" ID="lblPrice" Text="<%$Resources:Resource,Price%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtPrice" />
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
                </table>
            </td>
            <td valign="top">
            <h3>Paddy Payment Info</h3>
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lbltotalpaddyamount" Text="<%$Resources:Resource,TotalAmount%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txttotalpaddyamount" ReadOnly="true" />
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <asp:Label runat="server" ID="lblpaymentmode" Text="<%$Resources:Resource,PaymentMode%>"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButtonList ID="rbtPaymnetMode" runat="server" RepeatDirection="Vertical">
                                <asp:ListItem Text="Cash" Value="Cash"></asp:ListItem>
                                <asp:ListItem Text="Cheque" Value="Cheque"></asp:ListItem>
                                <asp:ListItem Text="Fund Transfer" Value="Transfer"></asp:ListItem>
                                <asp:ListItem Text="Credit" Value="Credit"></asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblchequeno" Text="<%$Resources:Resource,ChequeNo%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtChequeNo" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblbankname" Text="<%$Resources:Resource,BankName%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="BankName" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblamount" Text="<%$Resources:Resource,AmountPaid%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtamountpaid" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblPaidDate" Text="<%$Resources:Resource,PaidDate%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtPaidDate" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblBalanceAmount" Text="<%$Resources:Resource,BalanceAmount%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtbalanceamount" ReadOnly="true" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblHandoverto" Text="<%$Resources:Resource,AmountGivenTo%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtHandoverto" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblNextpaymentdate" Text="<%$Resources:Resource,Nextpaymentdate%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtNextpaymentdate" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                <asp:Button ID="Button2" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>
</div>

<asp:PagingGridView ID="rptPaddyStockInfo" Width="80%" runat="server" OnPageIndexChanging="rptPaddyStockInfo_PageIndexChanging"  DataKeyNames="Id" 
         AllowPaging="True"  
        AutoGenerateColumns="true"  OrderBy=""  >
       
      
    </asp:PagingGridView>
