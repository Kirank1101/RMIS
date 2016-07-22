<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HullingProcess.ascx.cs"
    Inherits="HullingProcess" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<style type="text/css">
    .style1
    {
        background-color: #99CCFF;
    }
</style>
<div class="table-responsive">
    <h4>
        Hulling Process Paddy Details</h4>
    <table>
        <tr>
            <td>
                <h4>
                    <asp:Label runat="server" ID="lblpaddystockhulling" Text="<%$Resources:Resource,PaddyStockforHulling%>"></asp:Label>
                    <asp:Label runat="server" ID="lblpaddyStock"></asp:Label>
                </h4>
            </td>
        </tr>
        <tr>
            <td>
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
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lbltotalbags" Text="<%$Resources:Resource,TotalBags%>"></asp:Label><span
                                style="color: Red">*</span>
                        </td>
                        <td>
                            <asp:TextBox ID="txtTotalBags" runat="server" Height="22px" Width="100px" MaxLength="3"
                                onblur="GetPrice"></asp:TextBox>
                            <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender4" runat="server"
                                FilterType="Numbers" TargetControlID="txtTotalBags">
                            </ajaxToolkit:FilteredTextBoxExtender>
                        </td>
                        <td>
                            <asp:Button ID="btnGetPaddyPrice" runat="server" Text="Get Paddy Price" OnClick="btnGetPaddyPrice_Click" />
                        </td>
                        <td style="padding-left: 20px">
                            <asp:Label runat="server" ID="lbltotalpaddyprice" Text="<%$Resources:Resource,PriceperQuintal%>"></asp:Label><span
                                style="color: Red">*</span>
                        </td>
                        <td>
                            <asp:TextBox ID="txtpaddyprice" runat="server" MaxLength="4" Height="22px" Width="100px"></asp:TextBox>
                            <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender3" runat="server"
                                FilterType="Numbers, Custom" ValidChars="." TargetControlID="txtpaddyprice">
                            </ajaxToolkit:FilteredTextBoxExtender>
                        </td>
                        <td style="padding-left: 20px">
                            <asp:Label runat="server" ID="lblHullingExpenses" Text="<%$Resources:Resource,HullingExpenses%>"></asp:Label>
                        </td>
                        <td style="padding-left: 5px">
                            <asp:TextBox ID="txtHullingExpenses" runat="server" MaxLength="5" Height="22px" Width="100px"></asp:TextBox><span
                                style="color: Red">*</span>
                            <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server"
                                FilterType="Numbers" TargetControlID="txtHullingExpenses">
                            </ajaxToolkit:FilteredTextBoxExtender>
                            &nbsp;&nbsp;&nbsp;
                        </td>
                        <td>
                        </td>
                    </tr>
                </table>
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
                            <asp:TextBox ID="txtBRPriceperQuintal" runat="server" Width="50px" Height="22px"
                                MaxLength="4"></asp:TextBox>
                            <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender5" runat="server"
                                FilterType="Numbers" TargetControlID="txtBRPriceperQuintal">
                            </ajaxToolkit:FilteredTextBoxExtender>
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
                    Hulling Process Husk Details</h4>
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
    <div id="HullingprocessTable" runat="server">
        <table style="font-weight: bold">
            <tr>
                <td valign="top" style="padding-right: 20px">
                    <h3>
                        Hulling Process Calculation
                    </h3>
                    <table border="Solid" width="100%">
                        <tr>
                            <td style="width: 18%; padding-left: 15px" class="style1">
                                <h4>
                                    <asp:Label runat="server" ID="Label4" Text="<%$Resources:Resource,ItemName%>"></asp:Label></h4>
                            </td>
                            <td style="width: 25%; text-align: center;" class="style1">
                                <h4>
                                    <asp:Label runat="server" ID="Label8" Text="<%$Resources:Resource,RawMeterialCost%>"></asp:Label></h4>
                            </td>
                            <td style="width: 15%; text-align: center;" class="style1">
                                <h4>
                                    <asp:Label runat="server" ID="Label9" Text="<%$Resources:Resource,ProductCost%>"></asp:Label></h4>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left: 15px">
                                <asp:Label runat="server" ID="Label3" Text="<%$Resources:Resource,Paddy%>"></asp:Label>
                            </td>
                            <td align="right" style="padding-right: 15px">
                                <asp:Label ID="lbltotpaddycost" runat="server"></asp:Label>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left: 15px">
                                <asp:Label runat="server" ID="Label5" Text="<%$Resources:Resource,HullingExpenses%>"></asp:Label>
                            </td>
                            <td align="right" style="padding-right: 15px">
                                <asp:Label ID="lbltotexp" runat="server"></asp:Label>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left: 15px">
                                <asp:Label runat="server" ID="Label6" Text="<%$Resources:Resource,Rice%>"></asp:Label>
                            </td>
                            <td>
                            </td>
                            <td align="right" style="padding-right: 15px">
                                <asp:Label ID="lbltotriceprice" runat="server" Style="padding-left: 5px"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left: 15px">
                                <asp:Label runat="server" ID="Label7" Text="<%$Resources:Resource,BrokenRiceandBran%>"></asp:Label>
                            </td>
                            <td>
                            </td>
                            <td align="right" style="padding-right: 15px">
                                <asp:Label ID="lbltotbrokenriceprice" runat="server" Style="padding-left: 5px"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left: 15px">
                                <asp:Label runat="server" ID="Label11" Text="<%$Resources:Resource,Husk%>"></asp:Label>
                            </td>
                            <td>
                            </td>
                            <td align="right" style="padding-right: 15px">
                                <asp:Label ID="lbltotdustprice" runat="server" Style="padding-left: 5px"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" style="padding-left: 15px">
                                <h3>
                                    <b>
                                        <asp:Label runat="server" ID="Label10" Text="<%$Resources:Resource,RicePriceperQuintal%>"></asp:Label>
                                        =
                                        <asp:Label ID="lblpriceperricebag" runat="server" Style="padding-left: 5px"></asp:Label></b></h3>
                            </td>
                        </tr>
                    </table>
                </td>
                <td valign="top">
                    <h3>
                        Production Yield Calculation
                    </h3>
                    <table border="Solid">
                        <tr>
                            <td style="width: 18%; padding-left: 15px" class="style1">
                                <h4>
                                    <asp:Label runat="server" ID="Label12" Text="<%$Resources:Resource,ProductType%>"></asp:Label></h4>
                            </td>
                            <td style="width: 17%; padding-left: 15px" class="style1" align="center">
                                <h4>
                                    <asp:Label runat="server" ID="Label13" Text="<%$Resources:Resource,Yield%>"></asp:Label></h4>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left: 15px">
                                <asp:Label runat="server" ID="Label14" Text="<%$Resources:Resource,Rice%>"></asp:Label>
                            </td>
                            <td align="right" style="padding-right: 25px">
                                <asp:Label ID="lblriceYield" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left: 15px">
                                <asp:Label runat="server" ID="Label15" Text="<%$Resources:Resource,HalfBrokenRice%>"></asp:Label>
                            </td>
                            <td align="right" style="padding-right: 25px">
                                <asp:Label ID="lblHalfBRYield" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left: 15px">
                                <asp:Label runat="server" ID="Label16" Text="<%$Resources:Resource,SmallBrokenRice%>"></asp:Label>
                            </td>
                            <td align="right" style="padding-right: 25px">
                                <asp:Label ID="lblSmallBRYield" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left: 15px">
                                <asp:Label runat="server" ID="Label17" Text="<%$Resources:Resource,Bran%>"></asp:Label>
                            </td>
                            <td align="right" style="padding-right: 25px">
                                <asp:Label ID="lblBranYield" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left: 15px">
                                <asp:Label runat="server" ID="Label18" Text="<%$Resources:Resource,Husk%>"></asp:Label>
                            </td>
                            <td align="right" style="padding-right: 25px">
                                <asp:Label ID="lblHuskYield" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
            </tr>
        </table>
    </div>
    <table>
        <tr>
            <td>
                <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
                <asp:Button ID="btnSaveandClose" runat="server" Text="Save and Close" OnClick="btnSaveClose_Click" />
            </td>
        </tr>
    </table>
</div>
