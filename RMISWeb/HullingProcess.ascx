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
                <asp:Label runat="server" ID="Label1" Text="<%$Resources:Resource,GodownName%>"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlGodownName" runat="server" AppendDataBoundItems="true">
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
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSubmit_Click" />
                <asp:Button ID="btnProceed" runat="server" Text="Hulling Process Calculate" OnClick="btnHullingProcess_Click" />
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <h3>
                    Hulling Process Paddy Details</h3>
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblpaddypadytype" Text="<%$Resources:Resource,PaddyType%>"></asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lblpaddyunittype" Text="<%$Resources:Resource,UnitType%>"></asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lblpaddytotalbags" Text="<%$Resources:Resource,totalbags%>"></asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lblpaddypriceperbag" Text="<%$Resources:Resource,PricePerBag%>"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="ddlpaddypaddytype" runat="server" AppendDataBoundItems="true">
                                <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlpaddyunittype" runat="server" AppendDataBoundItems="true">
                                <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtpadyTotalBags" />
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtPaddyPriceperbag" />
                        </td>
                    </tr>
                </table>
                <br /><br />
            </td>
            <td>
                <h3>
                    Hulling Process Rice Details</h3>
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblricetype" Text="<%$Resources:Resource,RiceType%>"></asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lblriceunittype" Text="<%$Resources:Resource,UnitType%>"></asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lblricetotalbag" Text="<%$Resources:Resource,totalbags%>"></asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lblricepriceperbag" Text="<%$Resources:Resource,PricePerBag%>"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="ddlRiceType" runat="server" AppendDataBoundItems="true">
                                <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlRiceBrand" runat="server" AppendDataBoundItems="true">
                                <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlriceUnittype" runat="server" AppendDataBoundItems="true">
                                <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtricetotalbags" />
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtricepriceperbag" />
                        </td>
                    </tr>
                </table>
                <br /><br />
            </td>
        </tr>
        <tr>
            <td>
                <h3>
                    Hulling Process Broken Rice Details</h3>
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblBRType" Text="<%$Resources:Resource,BrokenRiceType%>"></asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lblBRUnittype" Text="<%$Resources:Resource,UnitType%>"></asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lblBRTotalBags" Text="<%$Resources:Resource,totalbags%>"></asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lblBRPriceperbag" Text="<%$Resources:Resource,PricePerBag%>"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="ddlBRType" runat="server" AppendDataBoundItems="true">
                                <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlBRUnitsType" runat="server" AppendDataBoundItems="true">
                                <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtBRTotalBags" />
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtBRPriceperbag" />
                        </td>
                    </tr>
                </table>
                
            </td>
            <td>
                <h3>
                    Hulling Process Dust Details</h3>
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lbldustUnitType" Text="<%$Resources:Resource,UnitType%>"></asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lbldusttotalbags" Text="<%$Resources:Resource,totalbags%>"></asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lbldustPriceperbag" Text="<%$Resources:Resource,PricePerBag%>"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="ddlDustUnitsType" runat="server" AppendDataBoundItems="true">
                                <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtDustTotalBags" />
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtDustPriceperbag" />
                        </td>
                    </tr>
                </table>
                
            </td>
        </tr>
    </table>
    <h3>
        Hulling Process Expenses Details</h3>
    <table>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblPowerExpenses" Text="<%$Resources:Resource,PowerExpenses%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtPowerExpenses" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblLabourExpenses" Text="<%$Resources:Resource,LabourExpenses%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtLabourExpenses" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblOtherExpenses" Text="<%$Resources:Resource,OtherExpenses%>"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtOtherExpenses" />
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
                <asp:Button ID="btnSaveandClose" runat="server" Text="Save and Close" OnClick="btnSaveClose_Click" />
            </td>
        </tr>
    </table>
</div>
