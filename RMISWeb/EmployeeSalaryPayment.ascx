<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EmployeeSalaryPayment.ascx.cs"
    Inherits="EmployeeSalaryPayment" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblHEmployeeName" Text="<%$Resources:Resource,EmployeeName%>"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlEmployeeName" runat="server">
                            </asp:DropDownList>
                            <asp:Button ID="Button1" runat="server" Text="Search" OnClick="btnSearch_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblHSalaryType" Text="<%$Resources:Resource,SalaryType%>"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlSalaryType" runat="server" Enabled="false">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblHDesignation" Text="<%$Resources:Resource,Designation%>"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlDesignation" runat="server" Enabled="false">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblHSalary" Text="<%$Resources:Resource,Salary%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtSalary" runat="server" ReadOnly="true"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="LblHSalaryPaid" Text="<%$Resources:Resource,SalaryPaid%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtSalaryPaid" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblHOTPay" Text="<%$Resources:Resource,OTPay%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtOTPay" runat="server"></asp:TextBox>
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
                    Employee Salary Payment Details</h3>
                <asp:Repeater ID="rptSalaryDetails" runat="server">
                    <HeaderTemplate>
                        <table class="table table-striped table-bordered">
                            <thead>
                                <tr>
                                    <th>
                                        <asp:Label runat="server" ID="lblHPaymentDt" Text="<%$Resources:Resource,PaymentDt%>"></asp:Label>
                                    </th>
                                    <th>
                                        <asp:Label runat="server" ID="lblHSalaryPaid" Text="<%$Resources:Resource,SalaryPaid%>"></asp:Label>
                                    </th>
                                    <th>
                                        <asp:Label runat="server" ID="lblOT" Text="<%$Resources:Resource,OTPay%>"></asp:Label>
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
                                    <asp:Label runat="server" ID="lblPaidSalary" Text='<%# Eval("AmountSpent") %>' />
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="LblOTPay" Text='<%# Eval("ExtraCharges") %>' />
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
