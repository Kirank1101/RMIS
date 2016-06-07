<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddEmpDesig.ascx.cs" Inherits="AddEmpDesig" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <h4>
                                Designation Type</h4>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtDesigType" />
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
    <asp:Repeater ID="rptDesigType" runat="server">
        <HeaderTemplate>
            <table class="table table-striped table-bordered">
                <thead>
                    <tr>
                        <th>
                            <asp:Label runat="server" ID="lblHDesigType" Text="<%$Resources:Resource,DesigType%>"></asp:Label>
                        </th>
                        <th>
                            <asp:Label runat="server" ID="lblHObsInd" Text="<%$Resources:Resource,IsDesigDeleted%>"></asp:Label>
                        </th>
                    </tr>
                </thead>
        </HeaderTemplate>
        <ItemTemplate>
            <tbody>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lblDesigType" Text='<%# Eval("DesignationType") %>' />
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
