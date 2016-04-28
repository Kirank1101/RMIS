<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddSellerType.ascx.cs"
    Inherits="AddSellerType" %>
<asp:Panel ID="pnlSellerType" runat="server" style="padding-left:5%">
    <table >
        <tr>
            <td>
                <asp:GridView ID="rptSellerType" runat="server" AutoGenerateColumns="false">
                    <Columns>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                Seller Type
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblSellerType" Text='<%# Eval("SellerType") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                Is Deleted
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblObsInd" Text='<%# Eval("Indicator") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
    <%--<asp:Repeater ID="rptSellerType" runat="server">
        <HeaderTemplate>
            <table>
                <thead>
                    <tr>
                        <th>
                            <asp:Label runat="server" ID="lblHSellerType" Text="<%$Resources:Resource,SellerType%>"></asp:Label>
                        </th>
                        <th>
                            <asp:Label runat="server" ID="lblHObsInd" Text="<%$Resources:Resource,IsSellerTypeDeleted%>"></asp:Label>
                        </th>
                    </tr>
                </thead>
        </HeaderTemplate>
        <ItemTemplate>
            <tbody>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lblSellerType" Text='<%# Eval("SellerType") %>' />
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
    </asp:Repeater>--%>
    <table>
        <tr>
            <td>
               <h4> Seller Type</h4>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtSellerType" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>
</asp:Panel>
