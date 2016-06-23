<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BuyerInfoDetails.ascx.cs"
    Inherits="BuyerInfoDetails" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<div class="table-responsive">
    <table>
        <tr>
            <td valign="top">
                <h3>
                    Add Buyer</h3>
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblBuyerName" Text="<%$Resources:Resource,BuyerName%>"></asp:Label><span
                                style="color: Red">*</span>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtBuyerName" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblStreet1" Text="<%$Resources:Resource,Street1%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtStreet1" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblStreet2" Text="<%$Resources:Resource,Street2%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtStreet2" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblTown" Text="<%$Resources:Resource,Town%>"></asp:Label><span
                                style="color: Red">*</span>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtTown" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblCity" Text="<%$Resources:Resource,City%>"></asp:Label><span
                                style="color: Red">*</span>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtCity" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblDistrict" Text="<%$Resources:Resource,District%>"></asp:Label><span
                                style="color: Red">*</span>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtDistrict" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblState" Text="<%$Resources:Resource,State%>"></asp:Label><span
                                style="color: Red">*</span>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtState" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblPincode" Text="<%$Resources:Resource,Pincode%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtPincode" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblContactno" Text="<%$Resources:Resource,ContactNo%>"></asp:Label><span
                                style="color: Red">*</span>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtContactNo" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblMobileno" Text="<%$Resources:Resource,MobileNo%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtMobileNo" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblphoneno" Text="<%$Resources:Resource,PhoneNo%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtPhoneNo" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnSubmit" runat="server" Text="Save" OnClick="btnSubmit_Click" />
                            <asp:Button ID="btnClear" runat="server" Text="Clear"  OnClick="btnClear_Click" />
                        </td>
                    </tr>
                </table>
            </td>
            <td valign="top" align="left" style="padding-left: 15px">
                <h3> Buyer Information</h3>
                <table>
                    <tr>
                        <td>                            
                            <asp:PagingGridView ID="rptBuyerInfo" runat="server" AllowSorting="true" OnPageIndexChanging="rptBuyerInfo_PageIndexChanging"
                                DataKeyNames="ID" OnSorting="rptBuyerInfo_Sorting" AllowPaging="True" AutoGenerateColumns="false"
                                OrderBy="" OnRowCancelingEdit="rptBuyerInfo_RowCancelingEdit" OnRowDeleting="rptBuyerInfo_RowDeleting"
                                OnRowEditing="rptBuyerInfo_RowEditing" OnRowUpdating="rptBuyerInfo_RowUpdating">
                                <Columns>
                                    <asp:BoundField DataField="BuyerName" SortExpression="Name" HeaderText="<%$Resources:Resource,Name%>" />
                                    <asp:BoundField DataField="Town" SortExpression="Name" HeaderText="<%$Resources:Resource,Town%>" />
                                    <asp:BoundField DataField="ContactNo" SortExpression="Name" HeaderText="<%$Resources:Resource,ContactNo%>" />
                                    <asp:BoundField DataField="MobileNo" SortExpression="Name" HeaderText="<%$Resources:Resource,MobileNo%>" />
                                    <asp:CommandField ShowEditButton="true" />
                                    <asp:CommandField ShowDeleteButton="true" />
                                </Columns>
                            </asp:PagingGridView>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</div>
