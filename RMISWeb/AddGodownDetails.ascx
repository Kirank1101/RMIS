<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddGodownDetails.ascx.cs"
    Inherits="AddGodownDetails" %>
    <%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <h4>
                                Godown Name</h4>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtGodownName" />
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
        <asp:PagingGridView ID="rptGodownType" Width="80%" runat="server" AllowSorting="true"
        OnPageIndexChanging="rptGodownType_PageIndexChanging" DataKeyNames="Id" OnSorting="rptGodownType_Sorting"
        AllowPaging="True" AutoGenerateColumns="false" OrderBy="" OnRowCancelingEdit="rptGodownType_RowCancelingEdit"
        OnRowDeleting="rptGodownType_RowDeleting" OnRowEditing="rptGodownType_RowEditing"
        OnRowUpdating="rptGodownType_RowUpdating">
        <Columns>
            <asp:BoundField DataField="GodownType" SortExpression="GodownType" HeaderText="<%$Resources:Resource,GodownName%>" />
            <asp:BoundField DataField="Indicator" ReadOnly="True" HeaderText="<%$Resources:Resource,IsGodownDeleted%>" />
            <asp:CommandField ShowEditButton="true" HeaderText="Edit"  />
            <asp:CommandField ShowDeleteButton="true"  HeaderText="Delete"/>
        </Columns>
    </asp:PagingGridView>
</div>
