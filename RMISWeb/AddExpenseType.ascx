<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddExpenseType.ascx.cs" Inherits="AddExpenseType" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <h4>
                                Expense Type</h4>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtExpenseType" />
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
    
    
    <asp:PagingGridView ID="rptExpenseType" Width="80%" runat="server" AllowSorting="true"
        OnPageIndexChanging="rptExpenseType_PageIndexChanging" DataKeyNames="Id" OnSorting="rptExpenseType_Sorting"
        AllowPaging="True" AutoGenerateColumns="false" OrderBy="" OnRowCancelingEdit="rptExpenseType_RowCancelingEdit"
        OnRowDeleting="rptExpenseType_RowDeleting" OnRowEditing="rptExpenseType_RowEditing"
        OnRowUpdating="rptExpenseType_RowUpdating">
        <Columns>
            <asp:BoundField DataField="ExpenseType" SortExpression="ExpenseType" HeaderText="<%$Resources:Resource,ExpenseType%>" />
            <asp:BoundField DataField="Indicator" ReadOnly="True" HeaderText="<%$Resources:Resource,IsExpenseDeleted%>" />
            <asp:CommandField ShowEditButton="true" HeaderText="Edit" />
            <asp:CommandField ShowDeleteButton="true" HeaderText="Delete" />
        </Columns>
    </asp:PagingGridView>
</div>
