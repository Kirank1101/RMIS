<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddSalaryType.ascx.cs" Inherits="AddSalaryType" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <h4>
                                Salary Type</h4>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtSalaryType" />
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

    <asp:PagingGridView ID="rptSalaryType" Width="80%" runat="server" AllowSorting="true"
        OnPageIndexChanging="rptSalaryType_PageIndexChanging" DataKeyNames="Id" OnSorting="rptSalaryType_Sorting"
        AllowPaging="True" AutoGenerateColumns="false" OrderBy="" OnRowCancelingEdit="rptSalaryType_RowCancelingEdit"
        OnRowDeleting="rptSalaryType_RowDeleting" OnRowEditing="rptSalaryType_RowEditing"
        OnRowUpdating="rptSalaryType_RowUpdating">
        <Columns>
            <asp:BoundField DataField="SalaryType" SortExpression="SalaryType" HeaderText="<%$Resources:Resource,SalaryType%>" />
            <asp:BoundField DataField="Indicator" ReadOnly="True" HeaderText="<%$Resources:Resource,IsSalaryDeleted%>" />
            <asp:CommandField ShowEditButton="true" HeaderText="Edit"  />
            <asp:CommandField ShowDeleteButton="true"  HeaderText="Delete"/>
        </Columns>
    </asp:PagingGridView>
</div>
