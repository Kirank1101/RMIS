<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddPaddyType.ascx.cs"
    Inherits="AddPaddyType" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <h4>
                                Paddy Type</h4>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtPaddyType" />
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
    <asp:PagingGridView ID="rptPaddyType" Width="80%" runat="server" AllowSorting="true"  
        OnPageIndexChanging="rptPaddyType_PageIndexChanging" DataKeyNames="Id" OnSorting="rptPaddyType_Sorting"
        AllowPaging="True" AutoGenerateColumns="false" OrderBy="" OnRowCancelingEdit="rptPaddyType_RowCancelingEdit"
        OnRowDeleting="rptPaddyType_RowDeleting" OnRowEditing="rptPaddyType_RowEditing"
        OnRowUpdating="rptPaddyType_RowUpdating">
        <Columns>         
            <asp:BoundField DataField="PaddyType" SortExpression="PaddyType" HeaderText="<%$Resources:Resource,PaddyType%>" />
            <asp:BoundField DataField="Indicator" ReadOnly="True" HeaderText="<%$Resources:Resource,IsPaddyDeleted%>" />
            <asp:CommandField ShowEditButton="true" />
            <asp:CommandField ShowDeleteButton="true" />
        </Columns>
    </asp:PagingGridView>
</div>
