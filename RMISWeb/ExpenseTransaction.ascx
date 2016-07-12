<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ExpenseTransaction.ascx.cs"
    Inherits="ExpenseTransaction" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblHExpenseType" Text="<%$Resources:Resource,ExpenseType%>"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlExpenseType" runat="server" Height="22px" Width="156px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblHName" Text="<%$Resources:Resource,Name%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblHAmount" Text="<%$Resources:Resource,Amount%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblhReason" Text="<%$Resources:Resource,Reason%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtReason" runat="server"></asp:TextBox>
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
</div>
