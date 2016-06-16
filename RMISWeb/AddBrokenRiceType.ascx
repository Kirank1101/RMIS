<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddBrokenRiceType.ascx.cs"
    Inherits="AddBrokenRiceType" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <h4>
                                Broken Rice Type</h4>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtBrokenRiceType" />
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
    <asp:PagingGridView ID="rptBrokenRiceType" Width="80%" runat="server" AllowSorting="true"
        OnPageIndexChanging="rptBrokenRiceType_PageIndexChanging" DataKeyNames="Id" OnSorting="rptBrokenRiceType_Sorting"
        AllowPaging="True" AutoGenerateColumns="false" OrderBy="" OnRowCancelingEdit="rptBrokenRiceType_RowCancelingEdit"
        OnRowDeleting="rptBrokenRiceType_RowDeleting" OnRowEditing="rptBrokenRiceType_RowEditing"
        OnRowUpdating="rptBrokenRiceType_RowUpdating">
        <Columns>
            <asp:BoundField DataField="BrokenRiceType" SortExpression="BrokenRiceType" HeaderText="<%$Resources:Resource,BrokenRiceType%>" />
            <asp:BoundField DataField="Indicator" ReadOnly="True" HeaderText="<%$Resources:Resource,IsBrokenRiceDeleted%>" />
            <asp:CommandField ShowEditButton="true" HeaderText="Edit" />
            <asp:CommandField ShowDeleteButton="true" HeaderText="Delete" />
        </Columns>
    </asp:PagingGridView>
</div>
