﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TransactionPaddyStockInfo.ascx.cs"
    Inherits="TransactionPaddyStockInfo" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<style type="text/css">
    .MyTabStyle .ajax__tab_header
    {
        font-family: "Helvetica Neue" , Arial, Sans-Serif;
        font-size: 14px;
        font-weight: bold;
        display: block;
    }
    .MyTabStyle .ajax__tab_header .ajax__tab_outer
    {
        border-color: #222;
        color: #222;
        padding-left: 10px;
        margin-right: 3px;
        border: solid 1px #d7d7d7;
    }
    .MyTabStyle .ajax__tab_header .ajax__tab_inner
    {
        border-color: #666;
        color: #666;
        padding: 3px 10px 2px 0px;
    }
    .MyTabStyle .ajax__tab_hover .ajax__tab_outer
    {
        background-color: #9c3;
    }
    .MyTabStyle .ajax__tab_hover .ajax__tab_inner
    {
        color: #fff;
    }
    .MyTabStyle .ajax__tab_active .ajax__tab_outer
    {
        border-bottom-color: #ffffff;
        background-color: #d7d7d7;
    }
    .MyTabStyle .ajax__tab_active .ajax__tab_inner
    {
        color: #000;
        border-color: #333;
    }
</style>
<script language="javascript" type="text/javascript">

    // Solution to sys.invalidoperationexception bug
    Sys.Application.initialize = function Sys$_Application$initialize() {
        if (!this._initialized && !this._initializing) {
            this._initializing = true;
            var loadMethodSet = false;
            var initializeDelegate = Function.createDelegate(this, this._doInitialize);
            if (document.addEventListener) {
                loadMethodSet = true;
                document.addEventListener("DOMContentLoaded", initializeDelegate, false);
            }
            if (/WebKit/i.test(navigator.userAgent)) {
                loadMethodSet = true;
                this._load_timer = setInterval(function () {
                    if (/loaded|complete/.test(document.readyState)) {
                        initializeDelegate();
                    }
                }, 10);
            }
            else {
                /*@cc_on@*/
                /*@if (@_win32)
                loadMethodSet = true;
                document.write("<script id=__ie_onload defer src=BLOCKED SCRIPTvoid(0)><\/scr" + "ipt>");
                var deferScript = document.getElementById("__ie_onload");
                if (deferScript) {
                    deferScript.onreadystatechange = function () {
                        if (this.readyState == "complete") {
                            initializeDelegate();
                        }
                    };
                }
                /*@end@*/
            }

            // only if no other method will execute initializeDelegate is
            // it wired to the window's load method.
            if (!loadMethodSet) {
                $addHandler(window, "load", initializeDelegate);
            }
        }
    }
    Sys.Application._doInitialize = function Sys$_Application$_doInitialize() {
        if (this._load_timer !== null) {
            clearInterval(this._load_timer);
            this._load_timer = null;
        }

        Sys._Application.callBaseMethod(this, 'initialize');

        var handler = this.get_events().getHandler("init");
        if (handler) {
            this.beginCreateComponents();
            handler(this, Sys.EventArgs.Empty);
            this.endCreateComponents();
        }
        this.raiseLoad();
        this._initializing = false;
    }

    Sys.Application._loadHandler = function Sys$_Application$_loadHandler() {
        if (this._loadHandlerDelegate) {
            Sys.UI.DomEvent.removeHandler(window, "load",
                  this._loadHandlerDelegate);
            this._loadHandlerDelegate = null;
        }
        this._initializing = true;
        this._doInitialize();
    }         

</script>
<div class="table-responsive">
    <asp:CustomTabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" ScrollBars="Auto"
        CssClass="MyTabStyle" OnActiveTabChanged="TabContainer1_ActiveTabChanged">
        <ajaxToolkit:TabPanel runat="server" ID="TabPanel1">
            <HeaderTemplate>
                Paddy Information
            </HeaderTemplate>
            <ContentTemplate>
                <table>
                    <tr>
                        <td valign="top" style="padding-right: 70px">
                            <table>
                                <tr>
                                    <td>
                                        <asp:Label runat="server" ID="lblsellername" Text="<%$Resources:Resource,SellerName%>"></asp:Label>
                                    </td>
                                    <td>
                                        <p />
                                        <asp:TextBoxAutoExtender ID="TextBoxAutoExtender1" runat="server" ServiceMethod="GetSellerNames">
                                        </asp:TextBoxAutoExtender>
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
                                        <asp:TextBox runat="server" ID="txtVehicalNo" MaxLength="10" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label runat="server" ID="lblDriverName" Text="<%$Resources:Resource,DriverName%>"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox runat="server" ID="txtDriverName" MaxLength="50" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label runat="server" ID="lbltotalbags" Text="<%$Resources:Resource,TotalBags%>"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox runat="server" ID="txtTotalBags" MaxLength="3" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label runat="server" ID="lblPrice" Text="<%$Resources:Resource,Price%>"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox runat="server" ID="txtPrice" MaxLength="6" />
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
                    </tr>
                </table>
                <table>
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="btnSubmit_Click" ValidationGroup="OnSave" />
                            <asp:Button ID="Button2" runat="server" Text="Cancel" />
                        </td>
                    </tr>
                </table>
                <asp:PagingGridView ID="rptPaddyStockInfo" Width="80%" runat="server" OnPageIndexChanging="rptPaddyStockInfo_PageIndexChanging"
                    AlternatingRowStyle-BorderColor="Red" DataKeyNames="Id" AllowPaging="True" AutoGenerateColumns="false"
                    CssClass="table table-hover table-striped" AlternatingRowStyle-Font-Bold="true">
                    <Columns>
                        <asp:BoundField DataField="SellerName" HeaderText="Seller Name" />
                        <asp:BoundField DataField="PaddyName" HeaderText="Paddy Name" />
                        <asp:BoundField DataField="GodownName" HeaderText="Godown Name" />
                        <asp:BoundField DataField="LotName" HeaderText="Lot Name" />
                        <asp:BoundField DataField="UnitName" HeaderText="Unit Name" />
                        <asp:BoundField DataField="VehicalNo" HeaderText="Vehical Number" />
                        <asp:BoundField DataField="DriverName" HeaderText="Driver Name" />
                        <asp:BoundField DataField="TotalBags" HeaderText="Total Bags" />
                        <asp:BoundField DataField="Price" HeaderText="Price" />
                        <asp:BoundField DataField="PurchaseDate" HeaderText="Purchase Date" />
                    </Columns>
                </asp:PagingGridView>
            </ContentTemplate>
        </ajaxToolkit:TabPanel>
        <ajaxToolkit:TabPanel ID="TabPanel2" runat="server">
            <HeaderTemplate>
                Payment Information
            </HeaderTemplate>
            <ContentTemplate>
                <table>
                    <tr>
                        <td valign="top">
                            <h3>
                                Paddy Payment Info</h3>
                            <table>
                                <tr>
                                    <td>
                                        <asp:Label runat="server" ID="Label1" Text="<%$Resources:Resource,SellerName%>"></asp:Label>
                                    </td>
                                    <td>
                                        <p />
                                        <asp:TextBoxAutoExtender ID="TextBoxAutoExtender2" runat="server" ServiceMethod="GetSellerNames">
                                        </asp:TextBoxAutoExtender>
                                        <asp:Button ID="btnSellerDetails" runat="server" Text="Get Payment Details" OnClick="btnSellerDetails_Click"
                                            ValidationGroup="OnSave" />
                                    </td>
                                </tr>
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
                                        <asp:TextBox runat="server" ID="txtChequeNo" MaxLength="50" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label runat="server" ID="lblbankname" Text="<%$Resources:Resource,BankName%>"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox runat="server" ID="txtBankName" MaxLength="50" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label runat="server" ID="lblamount" Text="<%$Resources:Resource,AmountPaid%>"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox runat="server" ID="txtamountpaid" MaxLength="10" />
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
                                        <asp:TextBox runat="server" ID="txtHandoverto" MaxLength="50" />
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
                            <asp:Button ID="Button3" runat="server" Text="Pay" OnClick="btnPay_Click" ValidationGroup="OnSave" />
                            <asp:Button ID="Button4" runat="server" Text="Cancel" />
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </ajaxToolkit:TabPanel>
    </asp:CustomTabContainer>
</div>
