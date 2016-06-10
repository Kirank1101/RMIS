<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EmployeeSalary.ascx.cs"
    Inherits="EmployeeSalary" %>
    <%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<style type="text/css">
    .style1
    {
        width: 492px;
    }
</style>
<div class="table-responsive">
    <table>
        <tr>
            <td class="style1">
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblHEmployeeName" Text="<%$Resources:Resource,EmployeeName%>"></asp:Label>
                        </td>
                        <td>
                             <asp:TextBoxAutoExtender ID="txtExtenEmployeeName" runat="server" ServiceMethod="GetEmployeeNames"></asp:TextBoxAutoExtender>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblHSalaryType" Text="<%$Resources:Resource,SalaryType%>"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlSalaryType" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblHDesignation" Text="<%$Resources:Resource,Designation%>"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlDesignation" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblHSalary" Text="<%$Resources:Resource,Salary%>"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
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
        <tr>
            <td class="style1">
                <h3>
                    Employee Salary Details</h3>
                <asp:Repeater ID="rptSalaryDetails" runat="server">
                    <HeaderTemplate>
                        <table class="table table-striped table-bordered">
                            <thead>
                                <tr>
                                    <th>
                                        <asp:Label runat="server" ID="lblHEmployeeName" Text="<%$Resources:Resource,EmployeeName%>"></asp:Label>
                                    </th>
                                    <th>
                                        <asp:Label runat="server" ID="lblHDesigType" Text="<%$Resources:Resource,DesigType%>"></asp:Label>
                                    </th>
                                    <th>
                                        <asp:Label runat="server" ID="lblHSalaryType" Text="<%$Resources:Resource,SalaryType%>"></asp:Label>
                                    </th>
                                    <th>
                                        <asp:Label runat="server" ID="Label1" Text="<%$Resources:Resource,Salary%>"></asp:Label>
                                    </th>
                                </tr>
                            </thead>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tbody>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="lblEmployeeName" Text='<%# Eval("EmployeeID") %>' />
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblDesignation" Text='<%# Eval("MEmpDsgID") %>' />
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblSalaryType" Text='<%# Eval("MSalaryTypeID") %>' />
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblSalary" Text='<%# Eval("Salary") %>' />
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
