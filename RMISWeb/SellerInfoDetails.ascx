<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SellerInfoDetails.ascx.cs" Inherits="SellerInfoDetails" %>
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
            <div class="col-md-10" id="main-div">
                <form id="form1" runat="server">
                <div>
                    <table>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="lblHSellerType" Text="<%$Resources:Resource,SellerType%>"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlSellerType" runat="server">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="Label1" Text="<%$Resources:Resource,SellerName%>"></asp:Label>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="Label2" Text="<%$Resources:Resource,Street1%>"></asp:Label>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="Label3" Text="<%$Resources:Resource,Street2%>"></asp:Label>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="Label4" Text="<%$Resources:Resource,Town%>"></asp:Label>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="Label5" Text="<%$Resources:Resource,City%>"></asp:Label>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="Label6" Text="<%$Resources:Resource,District%>"></asp:Label>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="Label7" Text="<%$Resources:Resource,State%>"></asp:Label>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="Label8" Text="<%$Resources:Resource,Pincode%>"></asp:Label>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="Label9" Text="<%$Resources:Resource,ContactNo%>"></asp:Label>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="Label10" Text="<%$Resources:Resource,MobileNo%>"></asp:Label>
                            </td>
                            <td>
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
