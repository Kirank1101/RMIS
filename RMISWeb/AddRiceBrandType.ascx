<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddRiceBrandType.ascx.cs"
    Inherits="AddRiceBrandType" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <h4>
                                Rice Brand Type</h4>
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
    <asp:Repeater ID="rptRiceBrandType" runat="server">
        <HeaderTemplate>
            <table class="table table-striped table-bordered">
                <thead>
                    <tr>
                        <th>
                            <asp:Label runat="server" ID="lblHRiceType" Text="<%$Resources:Resource,RiceBrandType%>"></asp:Label>
                        </th>
                        <th>
                            <asp:Label runat="server" ID="lblHObsInd" Text="<%$Resources:Resource,IsRiceBrandDeleted%>"></asp:Label>
                        </th>
                    </tr>
                </thead>
        </HeaderTemplate>
        <ItemTemplate>
            <tbody>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lblRiceType" Text='<%# Eval("RiceBrandType") %>' />
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
