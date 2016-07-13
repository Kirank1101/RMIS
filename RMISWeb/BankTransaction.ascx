<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BankTransaction.ascx.cs"
    Inherits="BankTransaction" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <h4>
                                Add Bank Balance Rs:
                            </h4>
                        </td>
                        <td>
                            &nbsp;&nbsp;
                            <asp:TextBox runat="server" ID="txtmoney" MaxLength="14" />
                            <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender4" runat="server"
                                FilterType="Numbers" ValidChars="." TargetControlID="txtmoney">
                            </ajaxToolkit:FilteredTextBoxExtender>
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
    <table>
        <tr>
            <td>
                <h3>
                    <b>Bank Balance In My Account is Rs: </b>
                </h3>
            </td>
            <td>
                <h3>
                    <b>
                        <asp:Label ID="lblBankBalance" runat="server"></asp:Label></b></h3>
            </td>
        </tr>
    </table>
</div>
