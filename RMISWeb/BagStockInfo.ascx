﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BagStockInfo.ascx.cs"
    Inherits="BagStockInfo" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<div class="table-responsive">
    <asp:CustomTabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" ScrollBars="Auto"
        CssClass="MyTabStyle" OnActiveTabChanged="TabContainer1_ActiveTabChanged">
        <ajaxToolkit:TabPanel runat="server" ID="TabPanel1">
            <HeaderTemplate>
                Bag Stock
            </HeaderTemplate>
            <ContentTemplate>
                <h3>
                    Add Bag Stock</h3>
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblsellername" Text="<%$Resources:Resource,SellerName%>"></asp:Label><span
                                style="color: Red">*</span>
                        </td>
                        <td>
                            <asp:TextBoxAutoExtender ID="txtsellerName" runat="server" ServiceMethod="GetSellerNames">
                            </asp:TextBoxAutoExtender>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="Label2" Text="<%$Resources:Resource,BrandName%>"></asp:Label><span
                                style="color: Red">*</span>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlRiceBrand" runat="server" AppendDataBoundItems="true">
                                <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblriceunittype" Text="<%$Resources:Resource,UnitType%>"></asp:Label><span
                                style="color: Red">*</span>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlUnitsType" runat="server" AppendDataBoundItems="true">
                                <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lbltotalbags" Text="<%$Resources:Resource,TotalBags%>"></asp:Label><span
                                style="color: Red">*</span>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtTotalBags" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblPricePerBag" Text="<%$Resources:Resource,PricePerBag%>"></asp:Label><span
                                style="color: Red">*</span>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtpricePerBag" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblPruchaseDate" Text="<%$Resources:Resource,PruchaseDate%>"></asp:Label><span
                                style="color: Red">*</span>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtPruchaseDate" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblvehicalno" Text="<%$Resources:Resource,VehicalNo%>"></asp:Label><span
                                style="color: Red">*</span>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtVehicalNo" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblDriverName" Text="<%$Resources:Resource,DriverName%>"></asp:Label><span
                                style="color: Red">*</span>
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
            </ContentTemplate>
        </ajaxToolkit:TabPanel>
                <ajaxToolkit:TabPanel ID="TabPanel3" runat="server">
            <HeaderTemplate>
                Bag Payment
            </HeaderTemplate>
            <ContentTemplate>
                <table>
                    <tr>
                        <td valign="top">
                            <h3>
                                Bag Payment</h3>
                            <table>
                                <tr>
                                    <td>
                                        <asp:Label runat="server" ID="lblhtsellername" Text="<%$Resources:Resource,SellerName%>"></asp:Label>
                                        <span style="color: Red">*</span>
                                    </td>
                                    <td>
                                        <p />
                                        <asp:TextBoxAutoExtender ID="txtpaymentSellerName" runat="server" ServiceMethod="GetSellerNames">
                                        </asp:TextBoxAutoExtender>
                                        <asp:Button ID="btnSellerDetails" runat="server" Text="Get Payment Details" OnClick="btnSellerDetails_Click"
                                            ValidationGroup="OnSave" />
                                    </td>
                                </tr>
                                <tr>
                                    <td valign="top">
                                        <asp:Label runat="server" ID="lblpaymentmode" Text="<%$Resources:Resource,PaymentMode%>"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:RadioButtonList ID="rbtPaymnetMode" runat="server" RepeatDirection="Horizontal"
                                            CellPadding="3">
                                            <asp:ListItem Text="Cash" Value="Cash"></asp:ListItem>
                                            <asp:ListItem Text="Cheque" Value="Cheque"></asp:ListItem>
                                            <asp:ListItem Text="Fund Transfer" Value="Transfer"></asp:ListItem>
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
                                        <asp:Label runat="server" ID="lbltotalAmountDue" Text="<%$Resources:Resource,TotalAmountDue%>"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBoxDecimalExtender ID="txtTotalAmountDue" ReadOnly="true" ForeColor="Red"
                                            runat="server"></asp:TextBoxDecimalExtender>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label runat="server" ID="lblamount" Text="<%$Resources:Resource,AmountPaid%>"></asp:Label><span
                                            style="color: Red">*</span>
                                    </td>
                                    <td>
                                        <asp:TextBoxDecimalExtender ID="txtamountpaid" runat="server"></asp:TextBoxDecimalExtender>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label runat="server" ID="lblBalanceAmount" Text="<%$Resources:Resource,BalanceAmount%>"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBoxDecimalExtender ID="txtbalanceamount" runat="server" ReadOnly="true">
                                        </asp:TextBoxDecimalExtender>
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
                                        <asp:Label runat="server" ID="lblPaidDate" Text="<%$Resources:Resource,PaidDate%>"></asp:Label><span
                                            style="color: Red">*</span>
                                    </td>
                                    <td>
                                        <asp:TextBoxDatenTimeExtender ID="txtPaidDate" runat="server"></asp:TextBoxDatenTimeExtender>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label runat="server" ID="lblNextpaymentdate" Text="<%$Resources:Resource,Nextpaymentdate%>"></asp:Label><span
                                            style="color: Red">*</span>
                                    </td>
                                    <td>
                                        <asp:TextBoxDatenTimeExtender ID="txtNextpaymentdate" runat="server"></asp:TextBoxDatenTimeExtender>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
                <table>
                    <tr>
                        <td>
                            <asp:Button ID="btnPay" runat="server" Text="Pay" OnClick="btnPay_Click" ValidationGroup="OnSave" />
                            <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </ajaxToolkit:TabPanel>
        <ajaxToolkit:TabPanel runat="server" ID="TabPanel2">
            <HeaderTemplate>
                Bag Stock Details
            </HeaderTemplate>
            <ContentTemplate>
                <h3>
                    Bag Stock Details</h3>
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
            </ContentTemplate>
        </ajaxToolkit:TabPanel>
    </asp:CustomTabContainer>
</div>
