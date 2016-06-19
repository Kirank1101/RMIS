<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="MasterDataSettings" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<%@ Register Assembly="iucon.web.Controls.PartialUpdatePanel" Namespace="iucon.web.Controls"
    TagPrefix="iucon" %>
<%@ Register Src="MenuItems.ascx" TagName="MenuItems" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <!-- Meta, title, CSS, favicons, etc. -->
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">

    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- Bootstrap -->
    <link href="src/assets/css/bootstrap.min.css" rel="stylesheet">
    <!-- Font Awesome -->
    <link href="vendors/font-awesome/css/font-awesome.min.css" rel="stylesheet">
    <!-- iCheck -->
    <link href="vendors/iCheck/skins/flat/green.css" rel="stylesheet">
    <!-- bootstrap-progressbar -->
    <link href="vendors/bootstrap-progressbar/css/bootstrap-progressbar-3.3.4.min.css"
        rel="stylesheet">
    <!-- jVectorMap -->
    <link href="css/maps/jquery-jvectormap-2.0.3.css" rel="stylesheet" />
    <!-- Custom Theme Style -->
    <link href="css/custom.css" rel="stylesheet">


   
 


    <title>Rice Management Systems </title>
    <script type="text/javascript">
        function changeControlSample(path) {

            $find('<%= pnlMain.ClientID %>').set_UserControlPath(path);
            $find('<%= pnlMain.ClientID %>').refresh();

        }    



    </script>

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

     

     <script  type="text/javascript"  src="vendors/select2/docs/vendor/js/jquery.min.js"></script>
      <script  type="text/javascript"  src="vendors/select2/docs/vendor/js/bootstrap.min.js"></script>
       <script  type="text/javascript"  src="vendors/fastclick/lib/fastclick.js"></script>
        <script  type="text/javascript"  src="vendors/nprogress/nprogress.js"></script>
         <script  type="text/javascript"  src="src/assets/js/bootstrap-datepicker.js"></script>

   
</head>
<body class="nav-md">
    <form id="MainForm" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" >

    <Scripts>

<asp:ScriptReference Name="MicrosoftAjax.js" />

<asp:ScriptReference Name="AjaxControlToolkit.Common.Common.js" Assembly="AjaxControlToolkit" />

<asp:ScriptReference Name="AjaxControlToolkit.ExtenderBase.BaseScripts.js" Assembly="AjaxControlToolkit" />

<asp:ScriptReference Name="AjaxControlToolkit.Tabs.Tabs.js" Assembly="AjaxControlToolkit" />

<asp:ScriptReference Name="AjaxControlToolkit.DynamicPopulate.DynamicPopulateBehavior.js"

Assembly="AjaxControlToolkit" />

<asp:ScriptReference Name="AjaxControlToolkit.Common.DateTime.js" Assembly="AjaxControlToolkit" />

<asp:ScriptReference Name="AjaxControlToolkit.Compat.Timer.Timer.js" Assembly="AjaxControlToolkit" />

<asp:ScriptReference Name="AjaxControlToolkit.Animation.Animations.js" Assembly="AjaxControlToolkit" />

<asp:ScriptReference Name="AjaxControlToolkit.Animation.AnimationBehavior.js" Assembly="AjaxControlToolkit" />

<asp:ScriptReference Name="AjaxControlToolkit.PopupExtender.PopupBehavior.js" Assembly="AjaxControlToolkit" />

<asp:ScriptReference Name="AjaxControlToolkit.Common.Threading.js" Assembly="AjaxControlToolkit" />

<asp:ScriptReference Name="AjaxControlToolkit.Calendar.CalendarBehavior.js" Assembly="AjaxControlToolkit" />

 <asp:ScriptReference Name="AjaxControlToolkit.Compat.DragDrop.DragDropScripts.js"

Assembly="AjaxControlToolkit" />

<asp:ScriptReference Name="AjaxControlToolkit.Slider.SliderBehavior.js" Assembly="AjaxControlToolkit" />



</Scripts>



 <Services>
    <asp:ServiceReference Path="~/AutoCompleteService.asmx" />
   </Services>

</asp:ScriptManager>



   
    <div class="container body">
        <div class="main_container">
            <div class="col-md-3 left_col">
                <div class="left_col scroll-view">
                    <div class="navbar nav_title" style="border: 0;">
                        <a href="Default.aspx" class="site_title"><i class="fa fa-paw"></i><span>RMIS!</span></a>
                    </div>
                    <div class="clearfix">
                    </div>
                    <!-- menu profile quick info -->
                    <div class="profile">
                        <div class="profile_pic">
                            <img src="images/img.jpg" alt="..." class="img-circle profile_img">
                        </div>
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
                            <asp:LoginStatus ID="LoginStatus1" runat="server" OnLoggingOut="LoginStatus1_LoggingOut" />
                        </div>
                    </div>
                    <!-- /menu profile quick info -->
                    <br />
                    <!-- sidebar menu -->
                    <div id="sidebar-menu" class="main_menu_side hidden-print main_menu">
                        <div class="menu_section">
                            <h3>
                                All</h3>
                            <uc1:MenuItems ID="MenuItems1" runat="server" />
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
                <li class="">
                  <a href="javascript:;" class="user-profile dropdown-toggle" data-toggle="dropdown" aria-expanded="false">
                    <img src="images/img.jpg" alt="">John Doe
                    <span class=" fa fa-angle-down"></span>
                  </a>
                  <ul class="dropdown-menu dropdown-usermenu pull-right">
                    <li><a href="javascript:;">  Profile</a>
                    </li>
                    <li>
                      <a href="javascript:;">
                        <span class="badge bg-red pull-right">50%</span>
                        <span>Settings</span>
                      </a>
                    </li>
                    <li>
                      <a href="javascript:;">Help</a>
                    </li>
                    <li><a href="login.html"><i class="fa fa-sign-out pull-right"></i> Log Out</a>
                    </li>
                  </ul>
                </li>

                <li role="presentation" class="dropdown">
                  <a href="javascript:;" class="dropdown-toggle info-number" data-toggle="dropdown" aria-expanded="false">
                    <i class="fa fa-envelope-o"></i>
                    <span class="badge bg-green">6</span>
                  </a>
                  <ul id="menu1" class="dropdown-menu list-unstyled msg_list" role="menu">
                    <li>
                      <a>
                        <span class="image">
                                          <img src="images/img.jpg" alt="Profile Image" />
                                      </span>
                        <span>
                                          <span>John Smith</span>
                        <span class="time">3 mins ago</span>
                        </span>
                        <span class="message">
                                          Film festivals used to be do-or-die moments for movie makers. They were where...
                                      </span>
                      </a>
                    </li>
                    <li>
                      <a>
                        <span class="image">
                                          <img src="images/img.jpg" alt="Profile Image" />
                                      </span>
                        <span>
                                          <span>John Smith</span>
                        <span class="time">3 mins ago</span>
                        </span>
                        <span class="message">
                                          Film festivals used to be do-or-die moments for movie makers. They were where...
                                      </span>
                      </a>
                    </li>
                    <li>
                      <a>
                        <span class="image">
                                          <img src="images/img.jpg" alt="Profile Image" />
                                      </span>
                        <span>
                                          <span>John Smith</span>
                        <span class="time">3 mins ago</span>
                        </span>
                        <span class="message">
                                          Film festivals used to be do-or-die moments for movie makers. They were where...
                                      </span>
                      </a>
                    </li>
                    <li>
                      <a>
                        <span class="image">
                                          <img src="images/img.jpg" alt="Profile Image" />
                                      </span>
                        <span>
                                          <span>John Smith</span>
                        <span class="time">3 mins ago</span>
                        </span>
                        <span class="message">
                                          Film festivals used to be do-or-die moments for movie makers. They were where...
                                      </span>
                      </a>
                    </li>
                    <li>
                      <div class="text-center">
                        <a href="inbox.html">
                          <strong>See All Alerts</strong>
                          <i class="fa fa-angle-right"></i>
                        </a>
                      </div>
                    </li>
                  </ul>
                </li>

              </ul>
            </nav>
                </div>
            </div>
            <!-- /top navigation -->
            <!-- page content -->
            <div class="right_col" role="main">
                <div>
                    <iucon:PartialUpdatePanel runat="server" ID="pnlMain" UserControlPath="~/DashBoard.ascx"   DisplayLoadingAfter="1000" InitialRenderBehaviour="Clientside" 
                       EncryptUserControlPath="false">
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
            <!-- /page content -->
            <!-- footer content -->
            <footer>
          <div class="pull-right">
              
            Powered by OrmerSolutions India Pvt Ltd<a href="http://www.ormersolutions.com">Colorlib</a>
          </div>
          <div class="clearfix"></div>
        </footer>
            <!-- /footer content -->
        </div>
    </div>

    
    <!-- bootstrap-progressbar -->
    <script  type="text/javascript"  src="vendors/bootstrap-progressbar/bootstrap-progressbar.min.js"></script>
    <!-- iCheck -->
    <script  type="text/javascript" src="vendors/iCheck/icheck.min.js"></script>
    <!-- Skycons -->
    <script  type="text/javascript" src="vendors/skycons/skycons.js"></script>
    <!-- Flot -->
    <script  type="text/javascript" src="vendors/Flot/jquery.flot.js"></script>
    <script  type="text/javascript" src="vendors/Flot/jquery.flot.pie.js"></script>
    <script  type="text/javascript" ="vendors/Flot/jquery.flot.time.js"></script>
    <script  type="text/javascript" src="vendors/Flot/jquery.flot.stack.js"></script>
    <script  type="text/javascript" src="vendors/Flot/jquery.flot.resize.js"></script>
    <!-- Flot plugins -->
    <script  type="text/javascript" src="js/flot/jquery.flot.orderBars.js"></script>
    <script  type="text/javascript" src="js/flot/date.js"></script>
    <script  type="text/javascript" src="js/flot/jquery.flot.spline.js"></script>
    <script  type="text/javascript" src="js/flot/curvedLines.js"></script>
    <!-- jVectorMap -->
    <script  type="text/javascript" src="js/maps/jquery-jvectormap-2.0.3.min.js"></script>
    <!-- bootstrap-daterangepicker -->
    <script  type="text/javascript" src="js/moment/moment.min.js"></script>
    <script type="text/javascript" src="js/datepicker/daterangepicker.js"></script>
    <!-- Custom Theme Scripts -->
    <script type="text/javascript" src="js/custom.js"></script>
  
    


    </form>
</body>
</html>
