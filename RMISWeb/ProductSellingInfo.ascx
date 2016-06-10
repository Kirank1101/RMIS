<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductSellingInfo.ascx.cs"
    Inherits="ProductSellingInfo" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblprductsellingtype" Text="<%$Resources:Resource,ProductSellingType%>"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlProductTypeID" runat="server" AppendDataBoundItems="true">
                                <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
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
                            <asp:Label runat="server" ID="lblRiceType" Text="<%$Resources:Resource,RiceType%>"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlRiceType" runat="server" AppendDataBoundItems="true">
                                <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblRiceBrandName" Text="<%$Resources:Resource,RiceBrandName%>"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlRiceBrand" runat="server" AutoPostBack="true" AppendDataBoundItems="true">
                                <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblBrokenRiceType" Text="<%$Resources:Resource,BrokenRiceType%>"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlBrokenRiceType" runat="server" AppendDataBoundItems="true">
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
                            <asp:Label runat="server" ID="lbltotalbags" Text="<%$Resources:Resource,TotalBags%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtTotalBags" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblQWeight" Text="<%$Resources:Resource,QWeight%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtQweight" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblQPrice" Text="<%$Resources:Resource,QPrice%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtQprice" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblSellingDate" Text="<%$Resources:Resource,SellingDate%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtSellingDate" />
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <h3>
                    Payment Details</h3>
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblrOrderNo" Text="<%$Resources:Resource,OrderNo%>"></asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lblOrderNo"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lbltotalamount" Text="<%$Resources:Resource,TotalAmount%>"></asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lblTotalProductCost"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <asp:Label runat="server" ID="lblpaymentmode" Text="<%$Resources:Resource,PaymentMode%>"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButtonList ID="rbtPaymnetMode" runat="server" RepeatDirection="Vertical"
                                RepeatLayout="Table">
                                <asp:ListItem Text="Cash" Value="Cash"></asp:ListItem>
                                <asp:ListItem Text="Cheque" Value="Cheque"></asp:ListItem>
                                <asp:ListItem Text="Demand Draft" Value="DD"></asp:ListItem>
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
                            <asp:TextBox runat="server" ID="BankName" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblreceivedamount" Text="<%$Resources:Resource,ReceivedAmount%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtReceivedAmount" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblBalanceAmount" Text="<%$Resources:Resource,BalanceAmount%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtBalanceAmount" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="Label1" Text="<%$Resources:Resource,Nextpaymentdate%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtNextPaymentDate" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <table>
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                            <asp:Button ID="Button2" runat="server" Text="Cancel" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</div>
