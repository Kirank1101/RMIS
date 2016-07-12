<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RentHulling.ascx.cs"
    Inherits="RentHulling" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblHJobWork" Text="<%$Resources:Resource,JobWorkType%>"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlJobWorkType" runat="server" Height="22px" Width="156px">
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
                            <asp:Label runat="server" ID="lblHPaddyType" Text="<%$Resources:Resource,PaddyType%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtPaddyType" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblHTotalBags" Text="<%$Resources:Resource,TotalBags%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtTotalBags" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblHPrice" Text="<%$Resources:Resource,Price%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblHProcessedDate" Text="<%$Resources:Resource,ProcessDate%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBoxDatenTimeExtender ID="txtProcessedDate" runat="server"></asp:TextBoxDatenTimeExtender>
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
