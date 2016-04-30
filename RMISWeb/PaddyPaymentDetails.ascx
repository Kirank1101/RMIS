<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PaddyPaymentDetails.ascx.cs"
    Inherits="PaddyPaymentDetails" %>
<div class="table-responsive">
    <h3>
        Paddy Payment Details</h3>
    <table>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblsellername" Text="<%$Resources:Resource,SellerName%>"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlsellernames" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblamount" Text="<%$Resources:Resource,AmountPaid%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtamountpaid" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblPaidDate" Text="<%$Resources:Resource,PaidDate%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtPaidDate" />
            </td>
        </tr>
        <tr>
            <td><asp:Label runat="server" ID="lblHandoverto" Text="<%$Resources:Resource,PaidTo%>"></asp:Label>
            </td>
            <td><asp:TextBox runat="server" ID="txtHandoverto" />
            </td>
        </tr>
        <tr>
            <td><asp:Label runat="server" ID="lblNextpaymentdate" Text="<%$Resources:Resource,Nextpaymentdate%>"></asp:Label>
            </td>
            <td><asp:TextBox runat="server" ID="txtNextpaymentdate" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                <asp:Button ID="Button2" runat="server" Text="Cancel" />
            </td>
            <td>
            </td>
        </tr>
    </table>
</div>
