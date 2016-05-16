<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddBrokenRiceType.ascx.cs" Inherits="AddBrokenRiceType" %>
<div class="table-responsive">
    <asp:Repeater ID="rptBrokenRiceType" runat="server">
        <HeaderTemplate>
            <table class="table table-striped table-bordered">
                <thead>
                    <tr>
                        <th>
                            <asp:Label runat="server" ID="lblHBrokenRiceType" Text="<%$Resources:Resource,BrokenRiceType%>"></asp:Label>
                        </th>
                        <th>
                            <asp:Label runat="server" ID="lblHObsInd" Text="<%$Resources:Resource,IsBrokenRiceDeleted%>"></asp:Label>
                        </th>
                    </tr>
                </thead>
        </HeaderTemplate>
        <ItemTemplate>
            <tbody>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lblBrokenRiceType" Text='<%# Eval("BrokenRiceType") %>' />
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
                    Broken Rice Type</h4>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtBrokenRiceType" />
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
