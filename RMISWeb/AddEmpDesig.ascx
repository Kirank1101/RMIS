<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddEmpDesig.ascx.cs" Inherits="AddEmpDesig" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <h4>
                                Designation Type</h4>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtDesigType" />
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

    <asp:PagingGridView ID="rptDesigType" Width="80%" runat="server" AllowSorting="true"
        OnPageIndexChanging="rptDesigType_PageIndexChanging" DataKeyNames="Id" OnSorting="rptDesigType_Sorting"
        AllowPaging="True" AutoGenerateColumns="false" OrderBy="" OnRowCancelingEdit="rptDesigType_RowCancelingEdit"
        OnRowDeleting="rptDesigType_RowDeleting" OnRowEditing="rptDesigType_RowEditing"
        OnRowUpdating="rptDesigType_RowUpdating">
        <Columns>
            <asp:BoundField DataField="DesignationType" SortExpression="DesignationType" HeaderText="<%$Resources:Resource,DesigType%>" />
            <asp:BoundField DataField="Indicator" ReadOnly="True" HeaderText="<%$Resources:Resource,IsDesigDeleted%>" />
            <asp:CommandField ShowEditButton="true" HeaderText="Edit"  />
            <asp:CommandField ShowDeleteButton="true"  HeaderText="Delete"/>
        </Columns>
    </asp:PagingGridView>
</div>
