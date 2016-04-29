<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MasterDataSettings.aspx.cs"
    Inherits="MasterDataSettings" %>

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
</head>
<body>
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
            <div class="col-md-2" id="menu_items">
                <ul class="nav nav-pills nav-stacked">
                </ul>
            </div>
            <div id="main-div">
                <form id="form1" runat="server">
                <div>
                    <h2>
                        Master Data Settings</h2>
                    <table>
                        <tr>
                            <td>
                                <ul>
                                    <li>
                                        <h4>
                                            <a href="#">Paddy Type</a></h4>
                                    </li>
                                    <li>
                                        <h4>
                                            <a href="#">Godown Details </a>
                                        </h4>
                                    </li>
                                    <li>
                                        <h4>
                                            <a href="#">Lot Details</a></h4>
                                    </li>
                                    <li>
                                        <h4>
                                            <a href="#">Rice Type</a></h4>
                                    </li>
                                    <li>
                                        <h4>
                                            <a href="#">Seller Type</a></h4>
                                    </li>
                                </ul>
                            </td>
                        </tr>
                    </table>
                </div>
                </form>
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
                            2014 © Goverment of Singapore
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
