<%@ Control Language="C#" AutoEventWireup="true" CodeFile="OtherExpenses.ascx.cs"
    Inherits="OtherExpenses" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblHDescription" Text="<%$Resources:Resource,Description%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblHGivenTo" Text="<%$Resources:Resource,GivenTo%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtGivenTo" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblHAmountSpent" Text="<%$Resources:Resource,AmountPaid%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtAmountPaid" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button ID="btnSubmit" runat="server" Text="Save" OnClick="btnSubmit_Click" />
                            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <h3>
                    Amount Spent for this mount</h3>
                <asp:Repeater ID="rptamountspent" runat="server">
                    <HeaderTemplate>
                        <table class="table table-striped table-bordered">
                            <thead>
                                <tr>
                                    <th>
                                        <asp:Label runat="server" ID="lblHPaymentDt" Text="<%$Resources:Resource,PaymentDt%>"></asp:Label>
                                    </th>
                                    <th>
                                        <asp:Label runat="server" ID="lblHDesc" Text="<%$Resources:Resource,Description%>"></asp:Label>
                                    </th>
                                    <th>
                                        <asp:Label runat="server" ID="lblamountpaidTo" Text="<%$Resources:Resource,GivenTo%>"></asp:Label>
                                    </th>
                                    <th>
                                        <asp:Label runat="server" ID="lblamount" Text="<%$Resources:Resource,AmountPaid%>"></asp:Label>
                                    </th>
                                </tr>
                            </thead>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tbody>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="lblPartPaymentDate" Text='<%# Eval("PaymentDate") %>' />
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblPaidSalary" Text='<%# Eval("Description") %>' />
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="LblGivenTo" Text='<%# Eval("GivenTo") %>' />
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblamountpaid" Text='<%# Eval("AmountPaid") %>' />
                                </td>
                            </tr>
                        </tbody>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
            </td>
        </tr>
    </table>
</div>
