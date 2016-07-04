<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MediatorInfoDetails.ascx.cs"
    Inherits="MediatorInfoDetails" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<style type="text/css">
    .hiddencol
    {
        display: none;
    }
</style>
<div class="table-responsive">
    <table>
        <tr>
            <td valign="top">
                <h3>
                    Add Mediator</h3>
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblMediatorName" Text="<%$Resources:Resource,MediatorName%>"></asp:Label><span
                                style="color: Red">*</span>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtMediatorName" />
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
                            <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
                        </td>
                    </tr>
                </table>
            </td>
            <td valign="top" align="left" style="padding-left: 15px">
                <h3>
                    Mediator Information</h3>
                <table>
                    <tr>
                        <td>
                            <asp:PagingGridView ID="rptMediatorInfo" runat="server" AllowSorting="true" OnPageIndexChanging="rptMediatorInfo_PageIndexChanging"
                                DataKeyNames="ID" OnSorting="rptMediatorInfo_Sorting" AllowPaging="True" AutoGenerateColumns="false"
                                OrderBy="" OnRowCancelingEdit="rptMediatorInfo_RowCancelingEdit" OnRowDeleting="rptMediatorInfo_RowDeleting"
                                OnRowEditing="rptMediatorInfo_RowEditing" OnRowUpdating="rptMediatorInfo_RowUpdating">
                                <Columns>
                                    <asp:BoundField DataField="MediatorName" SortExpression="Name" HeaderText="<%$Resources:Resource,Name%>" />
                                    <asp:BoundField DataField="Town" SortExpression="Name" HeaderText="<%$Resources:Resource,Town%>" />
                                    <asp:BoundField DataField="ContactNo" SortExpression="Name" HeaderText="<%$Resources:Resource,ContactNo%>" />
                                    <asp:BoundField DataField="MobileNo" SortExpression="Name" HeaderText="<%$Resources:Resource,MobileNo%>" />
                                    <asp:BoundField DataField="ID" SortExpression="Name" HeaderText="<%$Resources:Resource,ID%>"
                                        ItemStyle-CssClass="hiddencol" HeaderStyle-CssClass="hiddencol" />
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
