<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EmployeeSalary.ascx.cs"
    Inherits="EmployeeSalary" %>
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
    </table>

</div>
