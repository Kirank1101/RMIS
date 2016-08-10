<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductSellingInfo.ascx.cs"
    Inherits="ProductSellingInfo" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="CC1" %>
<asp:Menu ID="MenuProductSelling" runat="server" Orientation="Horizontal" OnMenuItemClick="Menu1_MenuItemClick">
    <Items>
        <asp:MenuItem Text="Product Selling Information " Value="0"></asp:MenuItem>
        <asp:MenuItem Text=" Product Payment Details" Value="1"></asp:MenuItem>
    </Items>
    <LevelMenuItemStyles>
        <asp:MenuItemStyle CssClass="main_menuTab" />
        <asp:MenuItemStyle CssClass="level_menuTab" />
    </LevelMenuItemStyles>
</asp:Menu>
<asp:MultiView ID="TabSellingInfo" runat="server" ActiveViewIndex="0">
    <asp:View ID="Tab1" runat="server">
        <h3>
            Selling</h3>
        <table>
            <tr>
                <td>
                    <h4>
                        <asp:Label runat="server" ID="lblProductStockInfo"></asp:Label>
                        <asp:Label runat="server" ID="lblProductStock"></asp:Label>
                    </h4>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td valign="top">
                    <asp:Label runat="server" ID="lblprductsellingtype" Text="<%$Resources:Resource,ProductSellingType%>"></asp:Label>
                    <span style="color: Red">*</span>
                </td>
                <td>
                    <asp:RadioButtonList ID="rbtProductSellingtype" runat="server" RepeatDirection="Horizontal"
                        CellPadding="3" RepeatLayout="Table" OnSelectedIndexChanged="rbtProductSellingtype_OnSelectChange"
                        AutoPostBack="true">
                        <asp:ListItem Text="Rice" Value="Rice"></asp:ListItem>
                        <asp:ListItem Text="BrokenRice" Value="BrokenRice"></asp:ListItem>
                        <asp:ListItem Text="Dust" Value="Dust"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="lblMediatorName" Text="<%$Resources:Resource,MediatorName%>"></asp:Label>
                </td>
                <td>
                    <asp:TextBoxAutoExtender ID="txtMediatorName" runat="server" ServiceMethod="GetMediatorNames">
                    </asp:TextBoxAutoExtender>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="lblBuyername" Text="<%$Resources:Resource,BuyerName%>"></asp:Label><span
                        style="color: Red">*</span>
                </td>
                <td>
                    <asp:TextBoxAutoExtender ID="txtBuyerName" runat="server" ServiceMethod="GetBuyerNames">
                    </asp:TextBoxAutoExtender>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="lblRiceType" Text="<%$Resources:Resource,RiceType%>"></asp:Label><span
                        runat="server" id="spRiceType" style="color: Red">*</span>
                </td>
                <td>
                    <asp:DropDownList ID="ddlRiceType" runat="server" AppendDataBoundItems="true" OnSelectedIndexChanged="ddlRiceType_OnSelectedIndexChanged"
                        AutoPostBack="true">
                        <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="lblRiceBrandName" Text="<%$Resources:Resource,BrandName%>"></asp:Label><span
                        runat="server" id="spBrandName" style="color: Red">*</span>
                </td>
                <td>
                    <asp:DropDownList ID="ddlRiceBrand" runat="server" AutoPostBack="true" AppendDataBoundItems="true"
                        OnSelectedIndexChanged="ddlRiceBrand_OnSelectedIndexChanged">
                        <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="lblBrokenRiceType" Text="<%$Resources:Resource,BrokenRiceType%>"></asp:Label><span
                        runat="server" id="spBrokenRiceType" style="color: Red">*</span>
                </td>
                <td>
                    <asp:DropDownList ID="ddlBrokenRiceType" runat="server" AppendDataBoundItems="true"
                        OnSelectedIndexChanged="ddlBrokenRiceType_OnSelectedIndexChanged" AutoPostBack="true">
                        <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="lblUnits" Text="<%$Resources:Resource,UnitType%>"></asp:Label><span
                        style="color: Red">*</span>
                </td>
                <td>
                    <asp:DropDownList ID="ddlUnitsType" runat="server" AppendDataBoundItems="true" OnSelectedIndexChanged="ddlUnitsType_OnSelectedIndexChanged"
                        AutoPostBack="true">
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
                    <asp:TextBoxIntegerExtender ID="txtTotalBags" runat="server" MaxLength="3"></asp:TextBoxIntegerExtender>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="lblHPrice" Text="<%$Resources:Resource,PriceperQuintal%>"></asp:Label><span
                        style="color: Red">*</span>
                </td>
                <td>
                    <asp:TextBoxDecimalExtender ID="txtprice" ForeColor="Red" runat="server"></asp:TextBoxDecimalExtender>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="lblSellingDate" Text="<%$Resources:Resource,SellingDate%>"></asp:Label><span
                        style="color: Red">*</span>
                </td>
                <td>
                    <asp:TextBoxDatenTimeExtender ID="txtSellingDate" runat="server"></asp:TextBoxDatenTimeExtender>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="lblHnextpaydate" Text="<%$Resources:Resource,Nextpaymentdate%>"></asp:Label><span
                        style="color: Red">*</span>
                </td>
                <td>
                    <asp:TextBoxDatenTimeExtender ID="txtNextPayDate" runat="server"></asp:TextBoxDatenTimeExtender>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="lbldiscount" Text="<%$Resources:Resource,Discount%>"></asp:Label>
                </td>
                <td>
                    <asp:TextBoxIntegerExtender ID="txtDiscount" runat="server"></asp:TextBoxIntegerExtender>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="lblvehicalno" Text="<%$Resources:Resource,VehicalNo%>"></asp:Label>
                    <span style="color: Red">*</span>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtVehicalNo" MaxLength="13" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="lblDriverName" Text="<%$Resources:Resource,DriverName%>"></asp:Label>
                    <span style="color: Red">*</span>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtDriverName" MaxLength="50" />
                </td>
            </tr>
            <tr>
                <td align="center">
                    <br />
                    <br />
                    <table>
                        <tr>
                            <td>
                                <asp:Button ID="btnadd" runat="server" Text="Add" OnClick="btnAdd_Click" />
                                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                                <asp:Button ID="btnclear" runat="server" Text="Clear" OnClick="btnclear_click" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td>
                    <h3>
                        Product Selling Details</h3>
                    <asp:PagingGridView ID="rptProductSellingDetails" Width="80%" runat="server" AllowSorting="true"
                        DataKeyNames="ProductID" AutoGenerateColumns="false" OnRowDeleting="rptProductSellingDetails_RowDeleting"
                        class="table table-striped table-bordered">
                        <Columns>
                            <asp:BoundField DataField="ProductID" HeaderText="<%$Resources:Resource,ItemNo%>" />
                            <asp:BoundField DataField="MediatorName" HeaderText="<%$Resources:Resource,MediatorName%>" />
                            <asp:BoundField DataField="BuyerName" HeaderText="<%$Resources:Resource,Name%>" />
                            <asp:BoundField DataField="ProductName" HeaderText="<%$Resources:Resource,ProductName%>" />
                            <asp:BoundField DataField="ProductType" HeaderText="<%$Resources:Resource,ProductType%>" />
                            <asp:BoundField DataField="Brand" HeaderText="<%$Resources:Resource,BrandName%>" />
                            <asp:BoundField DataField="TotalBags" HeaderText="<%$Resources:Resource,totalbags%>" />
                            <asp:BoundField DataField="Price" HeaderText="<%$Resources:Resource,Price%>" />
                            <asp:BoundField DataField="TotalPrice" HeaderText="<%$Resources:Resource,TotalAmount%>" />
                            <asp:CommandField HeaderText="Delete" ShowDeleteButton="true" />
                        </Columns>
                    </asp:PagingGridView>
                </td>
            </tr>
        </table>
    </asp:View>
    <asp:View ID="Tab2" runat="server">
        <table>
            <tr>
                <td valign="top" style="width: 45%">
                    <h3>
                        Payment</h3>
                    <table>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="lblProPaymentMediator" Text="<%$Resources:Resource,MediatorName%>"></asp:Label>
                                <span style="color: Red">*</span>
                            </td>
                            <td>
                                <asp:TextBoxAutoExtender ID="txtMediatorNamePayment" runat="server" ServiceMethod="GetMediatorNames">
                                </asp:TextBoxAutoExtender>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" align="left">
                                And / OR
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="Label2" Text="<%$Resources:Resource,BuyerName%>"></asp:Label>
                                <span style="color: Red">*</span>
                            </td>
                            <td>
                                <asp:TextBoxAutoExtender ID="txtBuyerNamePayment" runat="server" ServiceMethod="GetBuyerNames">
                                </asp:TextBoxAutoExtender>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" align="left">
                                <asp:Button ID="btnBuyerDetails" runat="server" Text="Search" OnClick="btnBuyerDetails_Click"
                                    ValidationGroup="OnSave" />
                                <asp:Button ID="btnReset" runat="server" Text="Search" OnClick="btnReset_Click" ValidationGroup="OnSave" />
                            </td>
                        </tr>
                        <tr>
                            <td valign="top">
                                <asp:Label runat="server" ID="lblpaymentmode" Text="<%$Resources:Resource,PaymentMode%>"></asp:Label><span
                                    style="color: Red">*</span>
                            </td>
                            <td>
                                <asp:RadioButtonList ID="rbtPaymnetMode" runat="server" RepeatDirection="Vertical"
                                    RepeatLayout="Table">
                                    <asp:ListItem Text="Cash" Value="Cash"></asp:ListItem>
                                    <asp:ListItem Text="Cheque" Value="Cheque"></asp:ListItem>
                                    <asp:ListItem Text="Demand Draft" Value="DD"></asp:ListItem>
                                    <asp:ListItem Text="Fund Transfer" Value="Transfer"></asp:ListItem>
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
                                <asp:Label runat="server" ID="lblddno" Text="<%$Resources:Resource,DDNo%>"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtDDno" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="lblbankname" Text="<%$Resources:Resource,BankName%>"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtBankName" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="lbltotalamountDue" Text="<%$Resources:Resource,TotalAmountDue%>"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBoxDecimalExtender ID="txtTotalProductCost" runat="server" ReadOnly="true"
                                    ForeColor="Red" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="lblreceivedamount" Text="<%$Resources:Resource,ReceivedAmount%>"></asp:Label><span
                                    style="color: Red">*</span>
                            </td>
                            <td>
                                <asp:TextBoxDecimalExtender ID="txtReceivedAmount" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="lblBalanceAmount" Text="<%$Resources:Resource,BalanceAmount%>"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBoxDecimalExtender ID="txtBalanceAmount" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="Label1" Text="<%$Resources:Resource,Nextpaymentdate%>"></asp:Label><span
                                    style="color: Red">*</span>
                            </td>
                            <td>
                                <asp:TextBoxDatenTimeExtender ID="txtNextPaymentDate" runat="server"></asp:TextBoxDatenTimeExtender>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="lblsettlementPay" Text="<%$Resources:Resource,SettlementPay%>"></asp:Label>
                            </td>
                            <td>
                                <asp:CheckBox ID="ChkSettlementPay" Text="Yes" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btnSavePayment" runat="server" Text="Save" OnClick="btnSavePayment_Click" />
                                <asp:Button ID="btnCancel" runat="server" Text="clear" OnClick="btnCancel_click" />
                            </td>
                        </tr>
                    </table>
                </td>
                <td valign="top" align="left" style="width: 55%">
                    <h3>
                        Pending Payment Details</h3>
                    <asp:PagingGridView ID="rptBuyerPaymentDue" Width="80%" runat="server" AllowSorting="true"
                        DataKeyNames="ProductPaymentID" AutoGenerateColumns="false" OnRowCommand="rptBuyerPaymentDue_RowCommand"
                        class="table table-striped table-bordered">
                        <Columns>
                            <asp:BoundField DataField="SlNo" ItemStyle-Width="80px" HeaderText="<%$Resources:Resource,SlNo%>" />
                            <asp:BoundField DataField="MediatorName" ItemStyle-Width="300px" HeaderText="<%$Resources:Resource,MediatorName%>" />
                            <asp:BoundField DataField="BuyerName" ItemStyle-Width="300px" HeaderText="<%$Resources:Resource,BuyerName%>" />
                            <asp:BoundField DataField="TotalAmountDue" ItemStyle-Width="200px" HeaderText="<%$Resources:Resource,TotalAmountDue%>" />
                            <asp:ButtonField ButtonType="Button" CommandName="PayAmount" Text="Pay" />
                        </Columns>
                    </asp:PagingGridView>
                </td>
            </tr>
            <asp:HiddenField ID="hfProdPaymentID" runat="server" />
        </table>
    </asp:View>
</asp:MultiView>
