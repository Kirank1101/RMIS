<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddRiceType.ascx.cs" Inherits="AddRiceType" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <h4>
                                Rice Type</h4>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtRiceType" />
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
    
    <asp:PagingGridView ID="rptRiceType" Width="80%" runat="server" AllowSorting="true"
        OnPageIndexChanging="rptRiceType_PageIndexChanging" DataKeyNames="Id" OnSorting="rptRiceType_Sorting"
        AllowPaging="True" AutoGenerateColumns="false" OrderBy="" OnRowCancelingEdit="rptRiceType_RowCancelingEdit"
        OnRowDeleting="rptRiceType_RowDeleting" OnRowEditing="rptRiceType_RowEditing"
        OnRowUpdating="rptRiceType_RowUpdating">
        <Columns>
            <asp:BoundField DataField="RiceType" SortExpression="RiceType" HeaderText="<%$Resources:Resource,RiceType%>" />
            <asp:BoundField DataField="Indicator" ReadOnly="True" HeaderText="<%$Resources:Resource,IsRiceDeleted%>" />
            <asp:CommandField ShowEditButton="true" HeaderText="Edit"  />
            <asp:CommandField ShowDeleteButton="true"  HeaderText="Delete"/>
        </Columns>
    </asp:PagingGridView>
</div>
