<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Widget_TopTiles.ascx.cs" Inherits="Widget_TopTiles" %>

<!-- top tiles -->
<div class="row tile_count">
    <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
        <span class="count_top"><i class="fa fa-user"></i>Total Paddy Stock</span>
        <div  class="count red" >
            <asp:Literal ID="lblPaddyStock" runat="server"></asp:Literal>
           
        </div>
    </div>
    <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
        <span class="count_top"><i class="fa fa-user"></i>Total Rice Stock</span>
        <div class="count green">
            <asp:Literal ID="lblRiceStock" runat="server"></asp:Literal></div>
    </div>
    <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
        <span class="count_top"><i class="fa fa-user"></i>Total Broken Rice Stock</span>
        <div class="count green">
            <asp:Literal ID="lblBrokenRiceStock" runat="server"></asp:Literal></div>
    </div>
    <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
        <span class="count_top"><i class="fa fa-user"></i>Total Bag Stock</span>
        <div class="count">
            4,567</div>
    </div>
    <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
        <span class="count_top"><i class="fa fa-user"></i>Total Credit Amount</span>
        <div class="count">
            2,315</div>
    </div>
    <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
        <span class="count_top"><i class="fa fa-user"></i>Total Amount Due</span>
        <div class="count">
            <asp:Literal ID="ltrAmountDue" runat="server"></asp:Literal></div></div>
    </div>
</div>
<!-- /top tiles -->

