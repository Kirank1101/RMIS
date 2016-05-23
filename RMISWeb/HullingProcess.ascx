<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HullingProcess.ascx.cs"
    Inherits="HullingProcess" %>
<div class="table-responsive">
    <table>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblPaddyType" Text="<%$Resources:Resource,PaddyType%>"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlPaddyType" runat="server" AppendDataBoundItems="true">
                    <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblUnits" Text="<%$Resources:Resource,UnitType%>"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlUnitsType" runat="server" AppendDataBoundItems="true">
                    <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lbltotalbags" Text="<%$Resources:Resource,TotalBags%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtTotalBags" />
            </td>
        </tr>        
        <tr>
            <td>
                <asp:Label runat="server" ID="lblProcessDate" Text="<%$Resources:Resource,HullingProcessDate%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtHullingProcessDate" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblProcessBy" Text="<%$Resources:Resource,HullingProcessBy%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtHullingProcessBy" />
            </td>
        </tr>        
        <tr>
            <td>
                <asp:Button ID="btnstartprocess" runat="server" Text="Start Process" OnClick="btnSubmit_Click" />
                <asp:Button ID="btncancel" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>
</div>
