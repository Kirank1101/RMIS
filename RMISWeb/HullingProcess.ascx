﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HullingProcess.ascx.cs"
    Inherits="HullingProcess" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
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
                    AutoPostBack="true">
                    <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="padding-left: 20px">
                <asp:Label runat="server" ID="lblUnits" Text="<%$Resources:Resource,UnitType%>"></asp:Label><span
                    style="color: Red">*</span>
            </td>
            <td>
                <asp:DropDownList ID="ddlUnitsType" runat="server" AppendDataBoundItems="true" OnSelectedIndexChanged="ddlUnitsType_SelectedIndexChanged"
                    AutoPostBack="true">
                    <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="padding-left: 20px">
                <asp:Label runat="server" ID="Label1" Text="<%$Resources:Resource,GodownName%>"></asp:Label><span
                    style="color: Red">*</span>
            </td>
            <td>
                <asp:DropDownList ID="ddlGodownName" runat="server" AppendDataBoundItems="true" OnSelectedIndexChanged="ddlGodownSelectedIndexChanged"
                    AutoPostBack="true">
                    <asp:ListItem Selected="True" Text="[Select]" Value=""></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="padding-left: 20px">
                <asp:Label runat="server" ID="lblLotDetails" Text="<%$Resources:Resource,LotDetails%>"></asp:Label><span
                    style="color: Red">*</span>
            </td>
            <td>
                <asp:DropDownList ID="ddlLotDetails" runat="server" AppendDataBoundItems="true" OnSelectedIndexChanged="ddlLotDetails_SelectedIndexChanged"
                    AutoPostBack="true">
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
                <asp:TextBoxIntegerExtender ID="txtTotalBags" runat="server"></asp:TextBoxIntegerExtender>
            </td>
            <td style="padding-left: 20px">
                <asp:Label runat="server" ID="lbltotalpaddyprice" Text="<%$Resources:Resource,Price%>"></asp:Label><span
                    style="color: Red">*</span>
            </td>
            <td>
                <asp:TextBoxDecimalExtender ID="txtpaddyprice" runat="server" Mask="99,999.99"></asp:TextBoxDecimalExtender>
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
            <td id="PaddyStockDisplay" colspan="8">
                <h4>
                    <asp:Label runat="server" ID="lblpaddystockhulling" Text="<%$Resources:Resource,PaddyStockforHulling%>"></asp:Label>
                    <asp:Label runat="server" ID="lblpaddyStock" ></asp:Label>
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
                            <asp:TextBoxIntegerExtender ID="txtricetotalbags" runat="server"></asp:TextBoxIntegerExtender>
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
                            <asp:Label runat="server" ID="lblBRPriceperbag" Text="<%$Resources:Resource,PricePerBag%>"></asp:Label><span
                                style="color: Red">*</span>
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
                            <asp:TextBoxIntegerExtender ID="txtBRTotalBags" runat="server"></asp:TextBoxIntegerExtender>
                        </td>
                        <td>
                            <asp:TextBoxDecimalExtender ID="txtBRPriceperbag" runat="server"></asp:TextBoxDecimalExtender>
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
                                    <asp:BoundField DataField="PricePerBag" HeaderText="<%$Resources:Resource,PricePerBag%>" />
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
                                        <asp:Label runat="server" ID="lbldustPriceperbag" Text="<%$Resources:Resource,PricePerBag%>"></asp:Label><span
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
                                        <asp:TextBoxIntegerExtender ID="txtDustTotalBags" runat="server"></asp:TextBoxIntegerExtender>
                                    </td>
                                    <td>
                                        <asp:TextBoxDecimalExtender ID="txtDustPriceperbag" runat="server"></asp:TextBoxDecimalExtender>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
            <td valign="top" style="padding-left: 20px">
                <h4>
                    Hulling Process Expenses Details</h4>
                <table>
                    <tr>
                        <td valign="top">
                            <table>
                                <tr>
                                    <td>
                                        <asp:Label runat="server" ID="lblPowerExpenses" Text="<%$Resources:Resource,PowerExpenses%>"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBoxDecimalExtender ID="txtPowerExpenses" runat="server"></asp:TextBoxDecimalExtender>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label runat="server" ID="lblLabourExpenses" Text="<%$Resources:Resource,LabourExpenses%>"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBoxDecimalExtender ID="txtLabourExpenses" runat="server"></asp:TextBoxDecimalExtender>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label runat="server" ID="lblOtherExpenses" Text="<%$Resources:Resource,OtherExpenses%>"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBoxDecimalExtender ID="txtOtherExpenses" runat="server"></asp:TextBoxDecimalExtender>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
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
                                <asp:Label runat="server" ID="lblhPricePerRiceBag" Text="<%$Resources:Resource,PricePerRiceBag%>"></asp:Label>
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
