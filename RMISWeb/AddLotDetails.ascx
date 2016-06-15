<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddLotDetails.ascx.cs"
    Inherits="AddLotDetails" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblHGodownName" Text="<%$Resources:Resource,GodownName%>"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlGodownName" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlGodownName_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <h4>
                                Lot Details</h4>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtLotDetails" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <asp:PagingGridView ID="rptLotDetails" Width="80%" runat="server" AllowSorting="true"
        OnPageIndexChanging="rptLotDetails_PageIndexChanging" DataKeyNames="Id" OnSorting="rptLotDetails_Sorting"
        AllowPaging="True" AutoGenerateColumns="false" OrderBy="" OnRowCancelingEdit="rptLotDetails_RowCancelingEdit"
        OnRowDeleting="rptLotDetails_RowDeleting" OnRowEditing="rptLotDetails_RowEditing"
        OnRowUpdating="rptLotDetails_RowUpdating">
        <Columns>
            <asp:BoundField DataField="LotDetails" SortExpression="LotDetails" HeaderText="<%$Resources:Resource,LotDetails%>" />
            <asp:BoundField DataField="Indicator" ReadOnly="True" HeaderText="<%$Resources:Resource,IsLotDeleted%>" />
            <asp:CommandField ShowEditButton="true" HeaderText="Edit" />
            <asp:CommandField ShowDeleteButton="true" HeaderText="Delete" />
        </Columns>
    </asp:PagingGridView>
</div>
