<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Widget_BrokenRiceStock.ascx.cs" Inherits="Widget_BrokenRiceStock" %>

 <asp:Repeater ID="rptWidget" runat="server" >
       
        <ItemTemplate>
            <div class="widget_summary">
                    <div class="w_left w_25">
                      <span><%# Eval("Headerone") %></span>    
                       <span><%# Eval("HeaderTwo") %></span>                  
                    </div>
                    <div class="w_center w_55">
                      <div class="progress">
                        <div class="progress-bar bg-green" role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100" style="width:<%# Eval("Percentage") %>;">
                          <span class="sr-only"></span>
                        </div>
                      </div>
                    </div>
                    <div class="w_right w_20">
                      <span><%# Eval("Value") %></span>
                    </div>
                    <div class="clearfix"></div>
                  </div>
        </ItemTemplate>
        
    </asp:Repeater>

