<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddLotDetails.ascx.cs"
    Inherits="AddLotDetails" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblHGodownName" Text="<%$Resources:Resource,GodownName%>"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlGodownName" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <h4>
                                Lot Details</h4>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtLotDetails" />
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
    <asp:Repeater ID="rptLotDetails" runat="server">
        <HeaderTemplate>
            <table class="table table-striped table-bordered">
                <thead>
                    <tr>
                        <th>
                            <asp:Label runat="server" ID="lblHLotDetails" Text="<%$Resources:Resource,LotDetails%>"></asp:Label>
                        </th>
                        <th>
                            <asp:Label runat="server" ID="lblHObsInd" Text="<%$Resources:Resource,IsLotDeleted%>"></asp:Label>
                        </th>
                    </tr>
                </thead>
        </HeaderTemplate>
        <ItemTemplate>
            <tbody>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lblLotDetails" Text='<%# Eval("LotDetails") %>' />
                    </td>
                    <td>
                        <asp:Label runat="server" ID="lblObsInd" Text='<%# Eval("Indicator") %>' />
                    </td>
                </tr>
            </tbody>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</div>
