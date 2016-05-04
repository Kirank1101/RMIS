﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MasterDataSettings.aspx.cs"
    Inherits="MasterDataSettings" %>

<%@ Register Assembly="iucon.web.Controls.PartialUpdatePanel" Namespace="iucon.web.Controls"
    TagPrefix="iucon" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=Edge" />
    <meta content="width=device-width, initial-scale=1.0" name="viewport" />
    <link href="src/assets/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="src/assets/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="src/assets/css/uniform.default.css" rel="stylesheet" type="text/css" />
    <link href="src/assets/css/jquery-ui.css" rel="stylesheet" type="text/css" />
    <%--<link href="src/assets/css/style-metronic.css" rel="stylesheet" type="text/css" />--%>
    <link href="src/assets/css/style.css" rel="stylesheet" type="text/css" />
    <link href="src/assets/css/red.css" rel="stylesheet" type="text/css" />
    <link href="src/assets/css/style-responsive.css" rel="stylesheet" type="text/css" />
    <link href="src/assets/css/custom.css?v=1.0.0" rel="stylesheet" type="text/css" />
    <link href="src/assets/css/dropzone.css?v=1.0.0" rel="stylesheet" />
    <script type="text/javascript" src="src/assets/scripts/jquery-1.11.1.js"></script>
    <script type="text/javascript" src="src/assets/scripts/jquery-ui.js"></script>
    <script type="text/javascript" src="src/assets/scripts/jquery-migrate-1.2.1.min.js"></script>
    <script type="text/javascript" src="src/assets/scripts/jquery.uniform.min.js"></script>
    <script type="text/javascript" src="src/assets/scripts/jquery.blockui.min.js"></script>
    <script type="text/javascript" src="src/assets/scripts/bootstrap.min.js"></script>
    <script type="text/javascript" src="src/assets/scripts/bootstrap-datepicker.js"></script>
    <script type="text/javascript" src="src/assets/scripts/back-to-top.js"></script>
    <script type="text/javascript" src="src/assets/scripts/json2.js"></script>
    <script type="text/javascript" src="src/assets/scripts/sicc-lib.js?v=1.0.1"></script>
    <script type="text/javascript" src="src/assets/scripts/custom.js?v=1.0.0"></script>
    <title>Rice Management Systems </title>

      <script type="text/javascript">
          function changeControlSample(path) {
              $find('<%= pnlMain.ClientID %>').set_UserControlPath(path);
              $find('<%= pnlMain.ClientID %>').refresh();
          }
                    </script>

</head>
<body>
<form id="MainForm" runat="server">
                   
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
 </asp:ScriptManager>
    <div class="container-fluid">
        <!-- BEGIN Header -->
        <div id="rowheader" class="topbarlogo">
            <div class="col-md-3">
                <img src="src/assets/img/logo-banner.jpg" width="214" height="121" alt="logo" />
            </div>
            <div class="col-md-9 banner">
            </div>
        </div>
        <div class="row" id="welcomebar">
            <div class="col-md-6">
                <h2>
                    <font color="black">Welcome, </font><b>
                        <asp:Label runat="server" ID="LabelLoginName" /></b><font color="black">!</font></h2>
            </div>
            <div class="col-md-6">
                <div class="signout">
                    <div id="backToElit" style="float: left;">
                        <a class="btn white" id="AnchorBackToElit" runat="server">Back to eLitigation</a>&nbsp;&nbsp;|&nbsp;&nbsp;
                    </div>
                    <a class="btn btn-md white" id="AnchorSignOut" runat="server">Sign Out&nbsp;&nbsp;&nbsp;&nbsp;<i
                        class="fa fa-sign-out"></i></a>
                </div>
            </div>
        </div>
        <!-- END Header -->
        <!-- BEGIN MainContent -->
        <div class="row" id="elitforms">
          
                    <iucon:PartialUpdatePanel runat="server" ID="pnlMenu" UserControlPath="~/MenuItems.ascx"
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
                


               
            

            
            <div id="main-div">
                
                <div>
                    <iucon:PartialUpdatePanel runat="server" ID="pnlMain" UserControlPath="~/AddSellerType.ascx"
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
        <!-- BEGIN MainContent -->
        <!-- BEGIN COPYRIGHT -->
        <div class="copyright">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-md-6">
                        <p>
                            <a href="../../Home/eLitigation_Privacy_Policy.htm" target="_blank">Privacy Policy</a>
                            | <a href="../../Home/eLitigation_Terms_of_Use.htm" target="_blank">Terms of Use</a>
                        </p>
                    </div>
                    <div class="col-md-6">
                        <p class="text-right">
                            2016 © Goverment of India
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form> 
</body>
</html>
