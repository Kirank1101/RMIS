<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PaddyStockInfo.ascx.cs" Inherits="PaddyStockInfo" %>
<div class="table-responsive">
<h3>Paddy Stock Infor</h3>
    <table>
        <tr>
            <td>
                <asp:Label runat="server" ID="Label1" Text="<%$Resources:Resource,SellerType%>"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="Label2" Text="<%$Resources:Resource,SellerName%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TextBox1" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="Label3" Text="<%$Resources:Resource,Street1%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TextBox2" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="Label4" Text="<%$Resources:Resource,Street2%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TextBox3" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="Label5" Text="<%$Resources:Resource,Town%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TextBox4" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="Label6" Text="<%$Resources:Resource,City%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TextBox5" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="Label7" Text="<%$Resources:Resource,District%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TextBox6" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="Label8" Text="<%$Resources:Resource,State%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TextBox7" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="Label9" Text="<%$Resources:Resource,Pincode%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TextBox8" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="Label10" Text="<%$Resources:Resource,ContactNo%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TextBox9" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="Label11" Text="<%$Resources:Resource,MobileNo%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TextBox10" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="Label12" Text="<%$Resources:Resource,PhoneNo%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TextBox11" />
            </td>
        </tr>
        <tr>
            <td>
                <%--<asp:Button ID="Button1" runat="server" Text="Submit" OnClick="btnSubmit_Click" />--%>
                <asp:Button ID="Button2" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>
</div>