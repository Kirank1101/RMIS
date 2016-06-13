<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DashBoard.ascx.cs" Inherits="DashBoard" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<%@ Register Assembly="iucon.web.Controls.PartialUpdatePanel" Namespace="iucon.web.Controls"
    TagPrefix="iucon" %>
<iucon:PartialUpdatePanel runat="server" ID="PartialUpdatePanel1" UserControlPath="~/Widget_TopTiles.ascx"
    DisplayLoadingAfter="500" InitialRenderBehaviour="Clientside" EncryptUserControlPath="false">
    <LoadingTemplate>
        <div style="margin-left: 84px; margin-top: 10px;">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/images/loading.gif" />
        </div>
        <div style="text-align: center">
            Updating...
        </div>
    </LoadingTemplate>
</iucon:PartialUpdatePanel>
<div class="row">
    <div class="col-md-4 col-sm-4 col-xs-12">
        <div class="x_panel tile fixed_height_320">
            <div class="x_title">
                <h2>
                    Top 5 Paddy Stock Details</h2>
                <div class="clearfix">
                </div>
            </div>
            <div class="x_content">
                <iucon:PartialUpdatePanel runat="server" ID="pnlMain" UserControlPath="~/Widget_PaddyStock.ascx"
                    DisplayLoadingAfter="500" InitialRenderBehaviour="Clientside" EncryptUserControlPath="false">
                    <LoadingTemplate>
                        <div style="margin-left: 84px; margin-top: 10px;">
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/images/loading.gif" />
                        </div>
                        <div style="text-align: center">
                            Updating...
                        </div>
                    </LoadingTemplate>
                </iucon:PartialUpdatePanel>
            </div>
        </div>
    </div>
    <div class="col-md-4 col-sm-4 col-xs-12">
        <div class="x_panel tile fixed_height_320 overflow_hidden">
            <div class="x_title">
                <h2>
                    Top 5 Rice Stock Details</h2>
            
                <div class="clearfix">
                </div>
            </div>
            <div class="x_content">
                 <iucon:PartialUpdatePanel runat="server" ID="PartialUpdatePanel2" UserControlPath="~/Widget_RiceStock.ascx"
                    DisplayLoadingAfter="500" InitialRenderBehaviour="Clientside" EncryptUserControlPath="false">
                    <LoadingTemplate>
                        <div style="margin-left: 84px; margin-top: 10px;">
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/images/loading.gif" />
                        </div>
                        <div style="text-align: center">
                            Updating...
                        </div>
                    </LoadingTemplate>
                </iucon:PartialUpdatePanel>
            </div>
        </div>
    </div>
    <div class="col-md-4 col-sm-4 col-xs-12">
        <div class="x_panel tile fixed_height_320">
            <div class="x_title">
                <h2>
                    Top 5 Broken Rice Stock Details</h2>
                
                <div class="clearfix">
                </div>
            </div>
            <div class="x_content">
             <iucon:PartialUpdatePanel runat="server" ID="PartialUpdatePanel3" UserControlPath="~/Widget_BrokenRiceStock.ascx"
                    DisplayLoadingAfter="500" InitialRenderBehaviour="Clientside" EncryptUserControlPath="false">
                    <LoadingTemplate>
                        <div style="margin-left: 84px; margin-top: 10px;">
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/images/loading.gif" />
                        </div>
                        <div style="text-align: center">
                            Updating...
                        </div>
                    </LoadingTemplate>
                </iucon:PartialUpdatePanel>
            </div>
        </div>
    </div>
</div>
<div class="row">
    <div class="col-md-4 col-sm-4 col-xs-12">
        <div class="x_panel tile fixed_height_320">
            <div class="x_title">
                <h2>
                    App Versions</h2>
                <ul class="nav navbar-right panel_toolbox">
                    <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a></li>
                    <li class="dropdown"><a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button"
                        aria-expanded="false"><i class="fa fa-wrench"></i></a>
                        <ul class="dropdown-menu" role="menu">
                            <li><a href="#">Settings 1</a> </li>
                            <li><a href="#">Settings 2</a> </li>
                        </ul>
                    </li>
                    <li><a class="close-link"><i class="fa fa-close"></i></a></li>
                </ul>
                <div class="clearfix">
                </div>
            </div>
            <div class="x_content">
                <h4>
                    App Usage across versions</h4>
                <div class="widget_summary">
                    <div class="w_left w_25">
                        <span>0.1.5.2</span>
                    </div>
                    <div class="w_center w_55">
                        <div class="progress">
                            <div class="progress-bar bg-green" role="progressbar" aria-valuenow="60" aria-valuemin="0"
                                aria-valuemax="100" style="width: 66%;">
                                <span class="sr-only">60% Complete</span>
                            </div>
                        </div>
                    </div>
                    <div class="w_right w_20">
                        <span>123k</span>
                    </div>
                    <div class="clearfix">
                    </div>
                </div>
                <div class="widget_summary">
                    <div class="w_left w_25">
                        <span>0.1.5.3</span>
                    </div>
                    <div class="w_center w_55">
                        <div class="progress">
                            <div class="progress-bar bg-green" role="progressbar" aria-valuenow="60" aria-valuemin="0"
                                aria-valuemax="100" style="width: 45%;">
                                <span class="sr-only">60% Complete</span>
                            </div>
                        </div>
                    </div>
                    <div class="w_right w_20">
                        <span>53k</span>
                    </div>
                    <div class="clearfix">
                    </div>
                </div>
                <div class="widget_summary">
                    <div class="w_left w_25">
                        <span>0.1.5.4</span>
                    </div>
                    <div class="w_center w_55">
                        <div class="progress">
                            <div class="progress-bar bg-green" role="progressbar" aria-valuenow="60" aria-valuemin="0"
                                aria-valuemax="100" style="width: 25%;">
                                <span class="sr-only">60% Complete</span>
                            </div>
                        </div>
                    </div>
                    <div class="w_right w_20">
                        <span>23k</span>
                    </div>
                    <div class="clearfix">
                    </div>
                </div>
                <div class="widget_summary">
                    <div class="w_left w_25">
                        <span>0.1.5.5</span>
                    </div>
                    <div class="w_center w_55">
                        <div class="progress">
                            <div class="progress-bar bg-green" role="progressbar" aria-valuenow="60" aria-valuemin="0"
                                aria-valuemax="100" style="width: 5%;">
                                <span class="sr-only">60% Complete</span>
                            </div>
                        </div>
                    </div>
                    <div class="w_right w_20">
                        <span>3k</span>
                    </div>
                    <div class="clearfix">
                    </div>
                </div>
                <div class="widget_summary">
                    <div class="w_left w_25">
                        <span>0.1.5.6</span>
                    </div>
                    <div class="w_center w_55">
                        <div class="progress">
                            <div class="progress-bar bg-green" role="progressbar" aria-valuenow="60" aria-valuemin="0"
                                aria-valuemax="100" style="width: 2%;">
                                <span class="sr-only">60% Complete</span>
                            </div>
                        </div>
                    </div>
                    <div class="w_right w_20">
                        <span>1k</span>
                    </div>
                    <div class="clearfix">
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="col-md-4 col-sm-4 col-xs-12">
        <div class="x_panel tile fixed_height_320 overflow_hidden">
            <div class="x_title">
                <h2>
                    Device Usage</h2>
                <ul class="nav navbar-right panel_toolbox">
                    <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a></li>
                    <li class="dropdown"><a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button"
                        aria-expanded="false"><i class="fa fa-wrench"></i></a>
                        <ul class="dropdown-menu" role="menu">
                            <li><a href="#">Settings 1</a> </li>
                            <li><a href="#">Settings 2</a> </li>
                        </ul>
                    </li>
                    <li><a class="close-link"><i class="fa fa-close"></i></a></li>
                </ul>
                <div class="clearfix">
                </div>
            </div>
            <div class="x_content">
                <table class="" style="width: 100%">
                    <tr>
                        <th style="width: 37%;">
                            <p>
                                Top 5</p>
                        </th>
                        <th>
                            <div class="col-lg-7 col-md-7 col-sm-7 col-xs-7">
                                <p class="">
                                    Device</p>
                            </div>
                            <div class="col-lg-5 col-md-5 col-sm-5 col-xs-5">
                                <p class="">
                                    Progress</p>
                            </div>
                        </th>
                    </tr>
                    <tr>
                        <td>
                            <canvas id="canvas1" height="140" width="140" style="margin: 15px 10px 10px 0"></canvas>
                        </td>
                        <td>
                            <table class="tile_info">
                                <tr>
                                    <td>
                                        <p>
                                            <i class="fa fa-square blue"></i>IOS
                                        </p>
                                    </td>
                                    <td>
                                        30%
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <p>
                                            <i class="fa fa-square green"></i>Android
                                        </p>
                                    </td>
                                    <td>
                                        10%
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <p>
                                            <i class="fa fa-square purple"></i>Blackberry
                                        </p>
                                    </td>
                                    <td>
                                        20%
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <p>
                                            <i class="fa fa-square aero"></i>Symbian
                                        </p>
                                    </td>
                                    <td>
                                        15%
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <p>
                                            <i class="fa fa-square red"></i>Others
                                        </p>
                                    </td>
                                    <td>
                                        30%
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <div class="col-md-4 col-sm-4 col-xs-12">
        <div class="x_panel tile fixed_height_320">
            <div class="x_title">
                <h2>
                    Top 5 Amount dues</h2>
               
                <div class="clearfix">
                </div>
            </div>
            <div class="x_content">
                 <iucon:PartialUpdatePanel runat="server" ID="PartialUpdatePanel4" UserControlPath="~/Widget_TotalAmountDue.ascx"
                    DisplayLoadingAfter="500" InitialRenderBehaviour="Clientside" EncryptUserControlPath="false">
                    <LoadingTemplate>
                        <div style="margin-left: 84px; margin-top: 10px;">
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/images/loading.gif" />
                        </div>
                        <div style="text-align: center">
                            Updating...
                        </div>
                    </LoadingTemplate>
                </iucon:PartialUpdatePanel>
            </div>
        </div>
    </div>
</div>
