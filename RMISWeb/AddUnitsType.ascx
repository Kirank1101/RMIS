<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddUnitsType.ascx.cs"
    Inherits="AddUnitsType" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <h4>
                                Units Type</h4>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtUnitsType" />
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
    <asp:PagingGridView ID="rptUnitsType" Width="80%" runat="server" AllowSorting="true"
        OnPageIndexChanging="rptUnitsType_PageIndexChanging" DataKeyNames="Id" OnSorting="rptUnitsType_Sorting"
        AllowPaging="True" AutoGenerateColumns="false" OrderBy="" OnRowCancelingEdit="rptUnitsType_RowCancelingEdit"
        OnRowDeleting="rptUnitsType_RowDeleting" OnRowEditing="rptUnitsType_RowEditing"
        OnRowUpdating="rptUnitsType_RowUpdating">
        <Columns>
            <asp:BoundField DataField="UnitsType" SortExpression="UnitsType" HeaderText="<%$Resources:Resource,UnitsType%>" />
            <asp:BoundField DataField="Indicator" ReadOnly="True" HeaderText="<%$Resources:Resource,IsUnitsDeleted%>" />
            <asp:CommandField ShowEditButton="true" HeaderText="Edit"  />
            <asp:CommandField ShowDeleteButton="true"  HeaderText="Delete"/>
        </Columns>
    </asp:PagingGridView>

</div>
