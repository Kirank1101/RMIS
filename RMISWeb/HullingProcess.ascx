<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HullingProcess.ascx.cs"
    Inherits="HullingProcess" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<div class="table-responsive">
    <h4>
        Hulling Process Paddy Details</h4>
    <table>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblPaddyType" Text="<%$Resources:Resource,PaddyType%>"></asp:Label>
                <span style="color: Red">*</span>
            </td>
            <td>
                <asp:DropDownList ID="ddlPaddyType" runat="server" AppendDataBoundItems="true" OnSelectedIndexChanged="ddlPaddyType_SelectedIndexChanged"
                    AutoPostBack="true" Width="100px">
                    <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="padding-left: 20px">
                <asp:Label runat="server" ID="lblUnits" Text="<%$Resources:Resource,UnitType%>"></asp:Label><span
                    style="color: Red">*</span>
            </td>
            <td>
                <asp:DropDownList ID="ddlUnitsType" runat="server" AppendDataBoundItems="true" OnSelectedIndexChanged="ddlUnitsType_SelectedIndexChanged"
                    AutoPostBack="true" Width="100px">
                    <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="padding-left: 20px">
                <asp:Label runat="server" ID="Label1" Text="<%$Resources:Resource,GodownName%>"></asp:Label><span
                    style="color: Red">*</span>
            </td>
            <td>
                <asp:DropDownList ID="ddlGodownName" runat="server" AppendDataBoundItems="true" OnSelectedIndexChanged="ddlGodownSelectedIndexChanged"
                    AutoPostBack="true" Width="100px">
                    <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="padding-left: 20px">
                <asp:Label runat="server" ID="lblLotDetails" Text="<%$Resources:Resource,LotDetails%>"></asp:Label><span
                    style="color: Red">*</span>
            </td>
            <td>
                <asp:DropDownList ID="ddlLotDetails" runat="server" AppendDataBoundItems="true" OnSelectedIndexChanged="ddlLotDetails_SelectedIndexChanged"
                    AutoPostBack="true" Width="100px">
                    <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lbltotalbags" Text="<%$Resources:Resource,TotalBags%>"></asp:Label><span
                    style="color: Red">*</span>
            </td>
            <td>
                <asp:TextBox ID="txtTotalBags" runat="server" Height="22px" Width="100px" MaxLength="3"></asp:TextBox>
                <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender4" runat="server"
                    FilterType="Numbers" TargetControlID="txtTotalBags">
                </ajaxToolkit:FilteredTextBoxExtender>
            </td>
            <td style="padding-left: 20px">
                <asp:Label runat="server" ID="lbltotalpaddyprice" Text="<%$Resources:Resource,PriceperQuintal%>"></asp:Label><span
                    style="color: Red">*</span>
            </td>
            <td>
                <asp:TextBoxBagPrice ID="txtpaddyprice" runat="server" Mask="99,999.99"></asp:TextBoxBagPrice>
            </td>
            <td style="padding-left: 20px">
                <asp:Label runat="server" ID="lblProcessDate" Text="<%$Resources:Resource,HullingProcessDate%>"></asp:Label><span
                    style="color: Red">*</span>
            </td>
            <td>
                <asp:TextBoxDatenTimeExtender ID="txtHullingProcessDate" runat="server"></asp:TextBoxDatenTimeExtender>
            </td>
            <td style="padding-left: 20px">
                <asp:Label runat="server" ID="lblProcessBy" Text="<%$Resources:Resource,HullingProcessBy%>"></asp:Label>
            </td>
            <td>
                <asp:TextBoxAutoExtender ID="txtHullingProcessBy" runat="server" ServiceMethod="GetEmployeeNames">
                </asp:TextBoxAutoExtender>
            </td>
        </tr>
        <tr>
            <td valign="top" colspan="8">
                <h4>
                    Hulling Process Expenses Details</h4>
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblHullingExpenses" Text="<%$Resources:Resource,HullingExpenses%>"></asp:Label>
                        </td>
                        <td style="padding-left: 5px">
                            <asp:TextBox ID="txtHullingExpenses" runat="server" MaxLength="5" Height="22px" Width="100px"></asp:TextBox>
                            <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server"
                                FilterType="Numbers" TargetControlID="txtHullingExpenses">
                            </ajaxToolkit:FilteredTextBoxExtender>
                            &nbsp;&nbsp;&nbsp;
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan="8">
                <h4>
                    <asp:Label runat="server" ID="lblpaddystockhulling" Text="<%$Resources:Resource,PaddyStockforHulling%>"></asp:Label>
                    <asp:Label runat="server" ID="lblpaddyStock"></asp:Label>
                </h4>
            </td>
        </tr>
        <tr>
            <td style="padding-left: 20px">
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSubmit_Click" />
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td valign="top">
                <h4>
                    Hulling Process Rice Details</h4>
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblricetype" Text="<%$Resources:Resource,RiceType%>"></asp:Label><span
                                style="color: Red">*</span>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="Label2" Text="<%$Resources:Resource,BrandName%>"></asp:Label><span
                                style="color: Red">*</span>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lblriceunittype" Text="<%$Resources:Resource,UnitType%>"></asp:Label><span
                                style="color: Red">*</span>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lblricetotalbag" Text="<%$Resources:Resource,totalbags%>"></asp:Label><span
                                style="color: Red">*</span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="ddlRiceType" runat="server" AppendDataBoundItems="true" Width="100px">
                                <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlRiceBrand" runat="server" AppendDataBoundItems="true" Width="100px">
                                <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlriceUnittype" runat="server" AppendDataBoundItems="true"
                                Width="100px">
                                <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:TextBox ID="txtricetotalbags" runat="server" Height="22px" Width="50px" MaxLength="3"></asp:TextBox>
                            <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server"
                                FilterType="Numbers" TargetControlID="txtricetotalbags">
                            </ajaxToolkit:FilteredTextBoxExtender>
                        </td>
                        <td>
                            <asp:Button ID="btnAddRice" runat="server" Text="Add" OnClick="btnAddRice_Click" />
                        </td>
                    </tr>
                </table>
            </td>
            <td valign="top" style="padding-left: 20px">
                <h4>
                    Hulling Process Broken Rice Details</h4>
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblBRType" Text="<%$Resources:Resource,BrokenRiceType%>"></asp:Label><span
                                style="color: Red">*</span>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lblBRUnittype" Text="<%$Resources:Resource,UnitType%>"></asp:Label><span
                                style="color: Red">*</span>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lblBRTotalBags" Text="<%$Resources:Resource,totalbags%>"></asp:Label><span
                                style="color: Red">*</span>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lblBRPricePriceperQuintal" Text="<%$Resources:Resource,PriceperQuintal%>"></asp:Label><span
                                style="color: Red">*</span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="ddlBRType" runat="server" AppendDataBoundItems="true" Width="100px">
                                <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlBRUnitsType" runat="server" AppendDataBoundItems="true"
                                Width="100px">
                                <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:TextBox ID="txtBRTotalBags" runat="server" MaxLength="3" Width="50px" Height="22px"></asp:TextBox>
                            <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender6" runat="server"
                                FilterType="Numbers" TargetControlID="txtBRTotalBags">
                            </ajaxToolkit:FilteredTextBoxExtender>
                        </td>
                        <td>
                            <asp:TextBoxBagPrice ID="txtBRPriceperQuintal" runat="server"></asp:TextBoxBagPrice>
                        </td>
                        <td>
                            <asp:Button ID="btnaddBrokenRice" runat="server" Text="Add" OnClick="btnaddBrokenRice_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td valign="top">
                <h4>
                    Rice Details</h4>
                <table>
                    <tr>
                        <td>
                            <asp:PagingGridView ID="rptRiceDetails" runat="server" AllowSorting="true" DataKeyNames="Id"
                                AutoGenerateColumns="false" OnRowDeleting="rptRiceDetails_RowDeleting" class="table table-striped table-bordered">
                                <Columns>
                                    <asp:BoundField DataField="RiceType" HeaderText="<%$Resources:Resource,RiceType%>" />
                                    <asp:BoundField DataField="BrandName" HeaderText="<%$Resources:Resource,BrandName%>" />
                                    <asp:BoundField DataField="UnitsType" HeaderText="<%$Resources:Resource,UnitType%>" />
                                    <asp:BoundField DataField="TotalBags" HeaderText="<%$Resources:Resource,TotalBags%>" />
                                    <asp:CommandField HeaderText="Delete" ShowDeleteButton="true" />
                                </Columns>
                            </asp:PagingGridView>
                        </td>
                    </tr>
                </table>
            </td>
            <td valign="top" style="padding-left: 20px">
                <h4>
                    Broken Rice Details</h4>
                <table>
                    <tr>
                        <td>
                            <asp:PagingGridView ID="rptBrokenRiceDetails" runat="server" AllowSorting="true"
                                DataKeyNames="Id" AutoGenerateColumns="false" OnRowDeleting="rptBrokenRiceDetails_RowDeleting"
                                class="table table-striped table-bordered">
                                <Columns>
                                    <asp:BoundField DataField="BrokenRiceType" HeaderText="<%$Resources:Resource,BrokenRiceType%>" />
                                    <asp:BoundField DataField="UnitsType" HeaderText="<%$Resources:Resource,UnitType%>" />
                                    <asp:BoundField DataField="TotalBags" HeaderText="<%$Resources:Resource,TotalBags%>" />
                                    <asp:BoundField DataField="PriceperQuintal" HeaderText="<%$Resources:Resource,PriceperQuintal%>" />
                                    <asp:CommandField HeaderText="Delete" ShowDeleteButton="true" />
                                </Columns>
                            </asp:PagingGridView>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td valign="top">
                <h4>
                    Hulling Process Dust Details</h4>
                <table>
                    <tr>
                        <td valign="top">
                            <table>
                                <tr>
                                    <td>
                                        <asp:Label runat="server" ID="lbldustUnitType" Text="<%$Resources:Resource,UnitType%>"></asp:Label><span
                                            style="color: Red">*</span>
                                    </td>
                                    <td>
                                        <asp:Label runat="server" ID="lbldusttotalbags" Text="<%$Resources:Resource,totalbags%>"></asp:Label><span
                                            style="color: Red">*</span>
                                    </td>
                                    <td>
                                        <asp:Label runat="server" ID="lbldustPriceperQuintal" Text="<%$Resources:Resource,PriceperQuintal%>"></asp:Label><span
                                            style="color: Red">*</span>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:DropDownList ID="ddlDustUnitsType" runat="server" AppendDataBoundItems="true">
                                            <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtDustTotalBags" runat="server" MaxLength="3" Width="50px" Height="22px"></asp:TextBox>
                                        <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender7" runat="server"
                                            FilterType="Numbers" TargetControlID="txtDustTotalBags">
                                        </ajaxToolkit:FilteredTextBoxExtender>
                                    </td>
                                    <td>
                                        <asp:TextBoxBagPrice ID="txtDustPriceperQuintal" runat="server"></asp:TextBoxBagPrice>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
            <td>
            </td>
        </tr>
    </table>
    <br />
    <h3>
        Hulling Process Calculation
    </h3>
    <h5>
        <table width="70%" style="font-weight: bold">
            <tr>
                <td valign="top">
                    <table>
                        <tr>
                            <td align="right">
                                <asp:Label runat="server" ID="lblhTotalPaddyCost" Text="<%$Resources:Resource,TotalPaddyCost%>"></asp:Label>
                            </td>
                            <td style="padding-left: 5px">
                                <asp:Label ID="lbltotpaddycost" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label runat="server" ID="lblhTotalExpenses" Text="<%$Resources:Resource,TotalExpenses%>"></asp:Label>
                            </td>
                            <td align="right" style="padding-left: 5px">
                                <asp:Label ID="lbltotexp" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
                <td>
                    <table>
                        <tr>
                            <td style="padding-left: 20px" align="right">
                                <asp:Label runat="server" ID="lblhTotalbrokenRicePrice" Text="<%$Resources:Resource,TotalBrokenRicePrice%>"></asp:Label>
                            </td>
                            <td align="right">
                                <asp:Label ID="lbltotbrokenriceprice" runat="server" Style="padding-left: 5px"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left: 20px" align="right">
                                <asp:Label runat="server" ID="lblhTotalDustPrice" Text="<%$Resources:Resource,TotalDustPrice%>"></asp:Label>
                            </td>
                            <td align="right">
                                <asp:Label ID="lbltotdustprice" runat="server" Style="padding-left: 5px"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
                <td>
                    <table>
                        <tr>
                            <td align="right">
                                <asp:Label runat="server" ID="lblhTotalRicePrice" Text="<%$Resources:Resource,TotalRicePrice%>"></asp:Label>
                            </td>
                            <td align="right">
                                <asp:Label ID="lbltotriceprice" runat="server" Style="padding-left: 5px"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label runat="server" ID="lblhRicePriceperQuintal" Text="<%$Resources:Resource,RicePriceperQuintal%>"></asp:Label>
                            </td>
                            <td align="right">
                                <asp:Label ID="lblpriceperricebag" runat="server" Style="padding-left: 5px"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </h5>
    <table>
        <tr>
            <td>
                <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
                <asp:Button ID="btnSaveandClose" runat="server" Text="Save and Close" OnClick="btnSaveClose_Click" />
            </td>
        </tr>
    </table>
</div>
