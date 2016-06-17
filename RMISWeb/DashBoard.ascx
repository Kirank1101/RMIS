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
                   Top 5 Bag Stock details</h2>
                
                <div class="clearfix">
                </div>
            </div>
            <div class="x_content">
                <iucon:PartialUpdatePanel runat="server" ID="PartialUpdatePanel5" UserControlPath="~/Widget_BagStock.ascx"
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
                   Top 5 Credit dues</h2>
               
                <div class="clearfix">
                </div>
            </div>
            <div class="x_content">
                <iucon:PartialUpdatePanel runat="server" ID="PartialUpdatePanel6" UserControlPath="~/Widget_TotalCreditDue.ascx"
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
