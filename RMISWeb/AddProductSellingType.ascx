<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddProductSellingType.ascx.cs" Inherits="AddProductSellingType" %>
<div class="table-responsive">
    <asp:Repeater ID="rptProductSellingType" runat="server">
        <HeaderTemplate>
            <table class="table table-striped table-bordered">
                <thead>
                    <tr>
                        <th>
                            <asp:Label runat="server" ID="lblHProductSellingType" Text="<%$Resources:Resource,ProductSellingType%>"></asp:Label>
                        </th>
                        <th>
                            <asp:Label runat="server" ID="lblHObsInd" Text="<%$Resources:Resource,IsProductDeleted%>"></asp:Label>
                        </th>
                    </tr>
                </thead>
        </HeaderTemplate>
        <ItemTemplate>
            <tbody>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lblProductSellingType" Text='<%# Eval("ProductSellingType") %>' />
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
    <table>
        <tr>
            <td>
                <h4>
                    Product Selling Type</h4>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtProductSellingType" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>
</div>