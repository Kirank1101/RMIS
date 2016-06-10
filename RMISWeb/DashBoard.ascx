<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DashBoard.ascx.cs"
    Inherits="DashBoard" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>




    <!-- top tiles -->
          <div class="row tile_count">
            <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> Total Paddy Stock</span>
              <div class="count brown"><asp:Literal    ID="lblPaddyStock" runat="server" ></asp:Literal>
</div>              
            </div>
              
            <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> Total Rice Stock</span>
              <div class="count green"><asp:Literal ID="lblRiceStock" runat="server" ></asp:Literal></div>
               </div>
            
            <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> Total Broken Rice Stock</span>
              <div class="count green"><asp:Literal ID="lblBrokenRiceStock" runat="server" ></asp:Literal></div>
               </div>
             
            <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> Total Bag Stock</span>
              <div class="count">4,567</div>
             
            </div>
            <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> Total Credit Amount</span>
              <div class="count">2,315</div>
            
            </div>
            <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> Total Amount Due</span>
              <div class="count">7,325</div>
             
            </div>
          </div>
         
          <!-- /top tiles -->
