<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SellerInfoDetails.ascx.cs"
    Inherits="SellerInfoDetails" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<div class="table-responsive">
    <table>
        <tr>
            <td valign="top" >
                <h3>
                    Add Seller</h3>
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblSellerName" Text="<%$Resources:Resource,SellerName%>"></asp:Label><span
                                style="color: Red">*</span>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtSellerName" />
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
                            <asp:Label runat="server" ID="lblCity" Text="<%$Resources:Resource,City%>"></asp:Label>
                            <span style="color: Red">*</span>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtCity" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblDistrict" Text="<%$Resources:Resource,District%>"></asp:Label>                            
                            <span style="color: Red">*</span>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtDistrict" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblState" Text="<%$Resources:Resource,State%>"></asp:Label>
                            <span style="color: Red">*</span>
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
                            <asp:Label runat="server" ID="lblContactno" Text="<%$Resources:Resource,ContactNo%>"></asp:Label>
                            <span style="color: Red">*</span>
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
            <td align="left" valign="top" style="padding-left: 15px" valign="top">
                <table>
                    <tr>
                        <td>
                            <h3>
                                Seller Information</h3>
                            <asp:PagingGridView ID="rptSellerInfo" runat="server" AllowSorting="true" OnPageIndexChanging="rptSellerInfo_PageIndexChanging"
                                DataKeyNames="ID" OnSorting="rptSellerInfo_Sorting" AllowPaging="True" AutoGenerateColumns="false"
                                OrderBy="" OnRowCancelingEdit="rptSellerInfo_RowCancelingEdit" OnRowDeleting="rptSellerInfo_RowDeleting"
                                OnRowEditing="rptSellerInfo_RowEditing" OnRowUpdating="rptSellerInfo_RowUpdating">
                                <Columns>
                                    <asp:BoundField DataField="SellerName" SortExpression="Name" HeaderText="<%$Resources:Resource,Name%>" />
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
