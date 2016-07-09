<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LogOn.aspx.cs" Inherits="LogOn"
    Async="true" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <!-- Meta, title, CSS, favicons, etc. -->
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- Bootstrap -->
    <link href="css/bootstrap.min.css" rel="stylesheet">
    <!-- Font Awesome -->
    <link href="css/font-awesome/css/font-awesome.min.css" rel="stylesheet">
    <!-- bootstrap-progressbar -->
    <link href="css/bootstrap-progressbar-3.3.4.min.css" rel="stylesheet">
    <!-- Custom Theme Style -->
    <link href="css/custom.css" rel="stylesheet">
    <title>Rice Management Systems </title>
</head>
<body class="nav-md">
    <form id="MainForm" runat="server">
    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server" EnablePartialRendering="true"
        CombineScripts="false">
    </ajaxToolkit:ToolkitScriptManager>
    <div class="container body">
        <div class="main_container">
            <div class="col-md-3 left_col">
                <div class="left_col scroll-view">
                    <div class="navbar nav_title" style="border: 0;">
                        <div class="site_title">
                            <i class="fa fa-paw"></i><span>RMIS!</span>
                        </div>
                    </div>
                    <div class="clearfix">
                    </div>
                    <!-- menu profile quick info -->
                    <div class="profile">
                        <div class="profile_pic">
                            &nbsp;</div>
                        <div class="profile_info">
                            <asp:LoginView ID="LoginView1" runat="server">
                                <LoggedInTemplate>
                                    Welcome back,
                                    <asp:LoginName ID="LoginName1" runat="server" />
                                    .
                                    <br />
                                </LoggedInTemplate>
                                <AnonymousTemplate>
                                    Hello, stranger.
                                </AnonymousTemplate>
                            </asp:LoginView>
                            <br />
                        </div>
                    </div>
                    <!-- /menu profile quick info -->
                    <br />
                    <!-- sidebar menu -->
                    <div id="sidebar-menu" class="main_menu_side hidden-print main_menu">
                        <div class="menu_section">
                            <h3>
                            </h3>
                        </div>
                    </div>
                    <!-- /sidebar menu -->
                    <!-- /menu footer buttons -->
                    <div class="sidebar-footer hidden-small">
                        <a data-toggle="tooltip" data-placement="top" title="Settings"><span class="glyphicon glyphicon-cog"
                            aria-hidden="true"></span></a><a data-toggle="tooltip" data-placement="top" title="FullScreen">
                                <span class="glyphicon glyphicon-fullscreen" aria-hidden="true"></span></a>
                        <a data-toggle="tooltip" data-placement="top" title="Lock"><span class="glyphicon glyphicon-eye-close"
                            aria-hidden="true"></span></a><a data-toggle="tooltip" data-placement="top" title="Logout">
                                <span class="glyphicon glyphicon-off" aria-hidden="true"></span></a>
                    </div>
                    <!-- /menu footer buttons -->
                </div>
            </div>
            <!-- top navigation -->
            <div class="top_nav">
                <div class="nav_menu">
                    <nav class="" role="navigation">
              <div class="nav toggle">
                <a id="menu_toggle"><i class="fa fa-bars"></i></a>
              </div>

              <ul class="nav navbar-nav navbar-right">

                <li role="presentation" class="dropdown">
              
                </li>

              </ul>
            </nav>
                </div>
            </div>
            <!-- /top navigation -->
            <!-- page content -->
            <div class="right_col" role="main">
                <div>
                    <br />
                    <asp:UpdateProgress ID="UpdateProgress" runat="server">
                        <ProgressTemplate>
                            <div style="text-align: center">
                                Updating...
                            </div>
                            <img alt="Updating..." src="images/loading.gif" />
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                    <ajaxToolkit:ModalPopupExtender ID="modalPopup" runat="server" TargetControlID="UpdateProgress"
                        PopupControlID="UpdateProgress" BackgroundCssClass="modalPopup" />
                    <asp:UpdatePanel ID="upMain" runat="server">
                        <ContentTemplate>
                        <br />
                         <br />
                          <br />
                           <br />
                            <br />
                            <fieldset>
                                <table width="100%">
                                    <tr>
                                        <td colspan="2">
                                            <div style="float: right;">
                                            </div>
                                            <p style="font-family: Calibri; font-size:medium ">
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><em>&nbsp;&nbsp;&nbsp; Rice Management information system</em></strong> is a 
                                                first ever built software product in India&nbsp; designed to automate all processes 
                                                of a Rice Mill such as Arrivals, Purchases, Production, Sales, Bags stocks, 
                                                Commodities Stocks and all kind of accounting tasks with latest double entry 
                                                transaction techniques but with lots of ease.</p>
                                                 <br />
                                            <p style="font-family: Calibri; font-size: medium">
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><em>Rice Management information system</em></strong> is a 
                                                highly customizable product where one can create unlimited number of commodities 
                                                (Products), processes, bags types or bags classes of his own choice. In addition 
                                                to this richness it is so user friendly that no one feels any difficulty to work 
                                                with Compute Rice.</p>
                                                 <br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td  colspan="2" >
                                        <table style="width:70%;">
                                        <tr>
                                        <td align="center"  >
                                         <asp:Login ID="lgAbalone" runat="server" OnAuthenticate="lgAbalone_Authenticate"
                                                Height="145px" Font-Bold="True" Font-Italic="True" Font-Size="Medium" Font-Names="Calibri">
                                            </asp:Login>
                                        </td>

                                        <td>

                                         <div style="font-family: Calibri; font-size: x-large; font-weight: bolder; font-style: oblique;">
                                                Rice Management</div>
                                            <div style="font-family: Calibri; font-size: x-large; font-weight: bolder; font-style: oblique;">
                                                Information System&nbsp;
                                            </div>
                                        </td>
                                        </tr>
                                        </table>
                                           
                                        
                                           
                                        </td>
                                    </tr>
                                </table>
                            </fieldset>
                             <br />
                              <br />
                               <br />
                                <br />
                                 <br />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
        </div>
        <!-- /page content -->
        <!-- footer content -->
        <footer>
          <div class="pull-right">
              
            Powered by Ormer Solutions India Pvt Ltd<a href="http://www.ormersolutions.com">( Ormer Solutions )</a>
          </div>
          <div class="clearfix"></div>
        </footer>
        <!-- /footer content -->
    </div>
    <!-- Bootstrap -->
    <script type="text/javascript" src="js/jquery-1.11.1.js"></script>
    <script type="text/javascript" src="js/jquery-ui.js"></script>
    <script type="text/javascript" src="js/jquery-migrate-1.2.1.min.js"></script>
    <script type="text/javascript" src="js/jquery.uniform.min.js"></script>
    <script type="text/javascript" src="js/jquery.blockui.min.js"></script>
    <script src="js/bootstrap.min.js" type="text/javascript"></script>
    <script type="text/javascript" src="js/bootstrap.min.js"></script>
    <script type="text/javascript" src="js/bootstrap-datepicker.js"></script>
    <script type="text/javascript" src="js/back-to-top.js"></script>
    <script type="text/javascript" src="js/json2.js"></script>
    <script type="text/javascript" src="js/sicc-lib.js?v=1.0.1"></script>
    <script type="text/javascript" src="js/custom.js?v=1.0.0"></script>
    <script type="text/javascript" src="js/customOld.js"></script>
    <script type="text/javascript">
        function pageLoad() {
            Sys.WebForms.PageRequestManager.getInstance().
                   add_endRequest(onEndRequest);
        }

        function onEndRequest(sender, args) {

            args.set_errorHandled(true);
        }

        var prm = Sys.WebForms.PageRequestManager.getInstance();
        //Raised before processing of an asynchronous postback starts and the postback request is sent to the server.
        prm.add_beginRequest(BeginRequestHandler);
        // Raised after an asynchronous postback is finished and control has been returned to the browser.
        prm.add_endRequest(EndRequestHandler);
        function BeginRequestHandler(sender, args) {
            //Shows the modal popup - the update progress
            var popup = $find('<%= modalPopup.ClientID %>');
            if (popup != null) {
                popup.show();
            }
        }

        function EndRequestHandler(sender, args) {
            //Hide the modal popup - the update progress
            var popup = $find('<%= modalPopup.ClientID %>');
            if (popup != null) {
                popup.hide();
            }
        }


        function printInvoice(div1) {
            var printFriendly = document.getElementById(div1)
            if (printFriendly.innerHTML != "") {
                var printWin = window.open("about:blank", "Voucher", "menubar=no;status=no;toolbar=no;");
                printWin.document.write(printFriendly.innerHTML);
                printWin.document.close();
                setInterval(printWin.window.print(), 1000);
                //printWin.window.print();        
            }
            else {
                alertbox('Print Invoice Error', 'Please Select Invoice No and Click on View');
                //customErroralert('Print Invoice Error','Please Select Invoice No and Click on View');
                //alert('Please Select Invoice No and Click on View')
            }
        }



    </script>
    </form>
</body>
</html>
