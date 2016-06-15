<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddBagType.ascx.cs" Inherits="AddBagType" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <h4>
                                Bag Type</h4>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtBagType" />
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <table>
                    <tr>
                        <td>
                            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    
    
    <asp:PagingGridView ID="rptBagType" Width="80%" runat="server" AllowSorting="true"
        OnPageIndexChanging="rptBagType_PageIndexChanging" DataKeyNames="Id" OnSorting="rptBagType_Sorting"
        AllowPaging="True" AutoGenerateColumns="false" OrderBy="" OnRowCancelingEdit="rptBagType_RowCancelingEdit"
        OnRowDeleting="rptBagType_RowDeleting" OnRowEditing="rptBagType_RowEditing"
        OnRowUpdating="rptBagType_RowUpdating">
        <Columns>
            <asp:BoundField DataField="BagType" SortExpression="BagType" HeaderText="<%$Resources:Resource,BagType%>" />
            <asp:BoundField DataField="Indicator" ReadOnly="True" HeaderText="<%$Resources:Resource,IsBagDeleted%>" />
            <asp:CommandField ShowEditButton="true" HeaderText="Edit" />
            <asp:CommandField ShowDeleteButton="true" HeaderText="Delete" />
        </Columns>
    </asp:PagingGridView>
</div>
