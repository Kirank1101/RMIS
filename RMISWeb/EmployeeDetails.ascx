<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EmployeeDetails.ascx.cs"
    Inherits="EmployeeDetails" %>
<div class="table-responsive">

    <table>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblEmployeeName" Text="<%$Resources:Resource,EmployeeName%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtEmployeeName" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblStreet1" Text="<%$Resources:Resource,Street1%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtStreet1" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblStreet2" Text="<%$Resources:Resource,Street2%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtStreet2" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblTown" Text="<%$Resources:Resource,Town%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtTown" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblCity" Text="<%$Resources:Resource,City%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtCity" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblDistrict" Text="<%$Resources:Resource,District%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtDistrict" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblState" Text="<%$Resources:Resource,State%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtState" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblPincode" Text="<%$Resources:Resource,Pincode%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtPincode" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblContactno" Text="<%$Resources:Resource,ContactNo%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtContactNo" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblMobileno" Text="<%$Resources:Resource,MobileNo%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtMobileNo" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblphoneno" Text="<%$Resources:Resource,PhoneNo%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtPhoneNo" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                <asp:Button ID="Button2" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>
</div>
