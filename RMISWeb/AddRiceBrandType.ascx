<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddRiceBrandType.ascx.cs"
    Inherits="AddRiceBrandType" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <h4>
                                Add Brand Type</h4>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtRiceBrandType" />
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
    <asp:PagingGridView ID="rptRiceBrandType" Width="80%" runat="server" AllowSorting="true"
        OnPageIndexChanging="rptRiceBrandType_PageIndexChanging" DataKeyNames="Id" OnSorting="rptRiceBrandType_Sorting"
        AllowPaging="True" AutoGenerateColumns="false" OrderBy="" OnRowCancelingEdit="rptRiceBrandType_RowCancelingEdit"
        OnRowDeleting="rptRiceBrandType_RowDeleting" OnRowEditing="rptRiceBrandType_RowEditing"
        OnRowUpdating="rptRiceBrandType_RowUpdating">
        <Columns>
            <asp:BoundField DataField="RiceBrand" SortExpression="RiceBrand" HeaderText="<%$Resources:Resource,RiceBrandType%>" />
            <asp:BoundField DataField="Indicator" ReadOnly="True" HeaderText="<%$Resources:Resource,IsRiceBrandDeleted%>" />
            <asp:CommandField ShowEditButton="true" HeaderText="Edit"  />
            <asp:CommandField ShowDeleteButton="true"  HeaderText="Delete"/>
        </Columns>
    </asp:PagingGridView>
</div>
