<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddJobWork.ascx.cs" Inherits="AddJobWork" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <h4>
                                JobWork Type</h4>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtJobWorkType" />
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
    
    
    <asp:PagingGridView ID="rptJobWorkType" Width="80%" runat="server" AllowSorting="true"
        OnPageIndexChanging="rptJobWorkType_PageIndexChanging" DataKeyNames="Id" OnSorting="rptJobWorkType_Sorting"
        AllowPaging="True" AutoGenerateColumns="false" OrderBy="" OnRowCancelingEdit="rptJobWorkType_RowCancelingEdit"
        OnRowDeleting="rptJobWorkType_RowDeleting" OnRowEditing="rptJobWorkType_RowEditing"
        OnRowUpdating="rptJobWorkType_RowUpdating">
        <Columns>
            <asp:BoundField DataField="JobWorkType" SortExpression="JobWorkType" HeaderText="<%$Resources:Resource,JobWorkType%>" />
            <asp:BoundField DataField="Indicator" ReadOnly="True" HeaderText="<%$Resources:Resource,IsJobWorkDeleted%>" />
            <asp:CommandField ShowEditButton="true" HeaderText="Edit" />
            <asp:CommandField ShowDeleteButton="true" HeaderText="Delete" />
        </Columns>
    </asp:PagingGridView>
</div>
