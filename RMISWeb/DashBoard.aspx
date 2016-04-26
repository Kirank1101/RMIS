<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" %>
<%@ Register Assembly="iucon.web.Controls.PartialUpdatePanel" Namespace="iucon.web.Controls"
    TagPrefix="iucon" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<!--[if gt IE 8]><!-->
<html >
<!--<![endif]-->
<head>
    <meta charset="utf-8" />
    <!-- Always force latest IE rendering engine (even in intranet) & Chrome Frame -->
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <!-- Mobile viewport optimized: h5bp.com/viewport -->
    <meta name="viewport" content="width=device-width">
    <title>Rice Management Information System</title>
    <meta name="robots" content="noindex, nofollow">
    <meta name="description" content="BootMetro : Simple and complete web UI framework to create web apps with Windows 8 Metro user interface." />
    <meta name="keywords" content="bootmetro, modern ui, modern-ui, metro, metroui, metro-ui, metro ui, windows 8, metro style, bootstrap, framework, web framework, css, html" />
    <meta name="author" content="AozoraLabs by Marcello Palmitessa" />
    <!-- remove or comment this line if you want to use the local fonts -->
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700' rel='stylesheet'
        type='text/css'>
    <link rel="stylesheet" type="text/css" href="src/assets/css/bootmetro.css">
    <link rel="stylesheet" type="text/css" href="src/assets/css/bootmetro-responsive.css">
    <link rel="stylesheet" type="text/css" href="src/assets/css/bootmetro-icons.css">
    <link rel="stylesheet" type="text/css" href="src/assets/css/bootmetro-ui-light.css">
    <link rel="stylesheet" type="text/css" href="src/assets/css/datepicker.css">
    <!--  these two css are to use only for documentation -->
    <link rel="stylesheet" type="text/css" href="src/assets/css/demo.css">
    <!-- Le fav and touch icons -->
    <link rel="shortcut icon" href="src/assets/ico/favicon.ico">
    <link rel="apple-touch-icon-precomposed" sizes="144x144" href="src/assets/ico/apple-touch-icon-144-precomposed.png">
    <link rel="apple-touch-icon-precomposed" sizes="114x114" href="src/assets/ico/apple-touch-icon-114-precomposed.png">
    <link rel="apple-touch-icon-precomposed" sizes="72x72" href="src/assets/ico/apple-touch-icon-72-precomposed.png">
    <link rel="apple-touch-icon-precomposed" href="src/assets/ico/apple-touch-icon-57-precomposed.png">
    <!-- All JavaScript at the bottom, except for Modernizr and Respond.
      Modernizr enables HTML5 elements & feature detects; Respond is a polyfill for min/max-width CSS3 Media Queries
      For optimal performance, use a custom Modernizr build: www.modernizr.com/download/ -->
    <script src="src/assets/js/modernizr-2.6.2.min.js"></script>
    <script type="text/javascript">
        var _gaq = _gaq || [];
        _gaq.push(['_setAccount', 'UA-3182578-6']);
        _gaq.push(['_trackPageview']);
        (function () {
            var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
            ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
            var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
        })();
    </script>
</head>
<body>

 <form id="form1" runat="server">   
 <asp:ScriptManager ID="ScriptManager1" runat="server">
 </asp:ScriptManager>



    <!--[if lt IE 7]>
   <p class="chromeframe">You are using an <strong>outdated</strong> browser. Please <a href="http://browsehappy.com/">upgrade your browser</a> or <a href="http://www.google.com/chromeframe/?redirect=true">activate Google Chrome Frame</a> to improve your experience.</p>
   <![endif]-->
    <div id="wrap">
        <!-- Header
      ================================================== -->
        <div id="nav-bar" class="">
            <div class="pull-left">
                <div id="header-container">
                    <h1>
                        Nandi Rice Mill, Davangere</h1>
                </div>
            </div>
            <div class="pull-right">
                <div id="top-info" class="pull-right">
                    <a id="settings" href="#" class="win-command pull-right"><span class="win-commandicon win-commandring icon-cog-3">
                    </span></a><a id="logged-user" href="#" class="win-command pull-right"><span class="win-commandicon win-commandring icon-user">
                    </span></a>
                    <div class="pull-left">
                        <h4>
                            Welcome</h4>
                    </div>
                </div>
            </div>
        </div>


        
 <div id="home-tiles" class="container-fluid metro-responsive-tiles">
      <div class="row-fluid">

       <div class="span4">
            <a class="tile wide imagetext bg-color-orange first" href="https://github.com/aozora/bootmetro">
               <div class="image-wrapper">
                  <span class="icon icon-github"></span>
               </div>
               <div class="column-text">
                  <div class="text-header2">View project on GitHub</div>
                  <div class="text4">
                     <iframe class="github-btn" src="http://ghbtns.com/github-btn.html?user=aozora&repo=bootmetro&type=watch&count=true" allowtransparency="true" frameborder="0" scrolling="0" width="100px" height="20px"></iframe>
                     <iframe class="github-btn" src="http://ghbtns.com/github-btn.html?user=aozora&repo=bootmetro&type=fork&count=true" allowtransparency="true" frameborder="0" scrolling="0" width="98px" height="20px"></iframe>
                  </div>
               </div>
            </a>
         </div>
         <div class="span4">
            <a class="tile wide imagetext bg-color-green middle" href="./hub.html">
               <div class="image-wrapper">
                  <span class="icon icon-grid"></span>
               </div>
               <div class="column-text">
                  <div class="text-header3">View the Demo online</div>
               </div>
            </a>
         </div>
         <div class="span4">
            <a class="tile wide imagetext bg-color-blue last" href="https://twitter.com/aozoralabs">
               <div class="image-wrapper">
                  <span class="icon icon-twitter"></span>
               </div>
               <div class="column-text">
                  <div class="text-header3">Follow on Twitter</div>
               </div>
            </a>
         </div>
      </div>
      </div> 


        <!--<div id="metro-container" class="-container">-->
        <!--<div class="row">-->
        <!--<div id="hub" class="metro">-->
        <div class="metro panorama">
            <div class="panorama-sections">
                <div class="panorama-section">
                    <h2>
                        Paddy Stock Details</h2>
                    <!--<a class="tile widepeek" href="#">-->
                    <!--<div class="tile wide image">-->
                    <!--<img src="http://upload.wikimedia.org/wikipedia/commons/thumb/8/8a/Darvasa_gas_crater_panorama.jpg/640px-Darvasa_gas_crater_panorama.jpg" alt=""/>-->
                    <!--</div>-->
                    <!--<div class="tile wide text bg-color-orange">-->
                    <!--<div class="text5">The Door to Hell, a burning natural gas field in Derweze, Turkmenistan</div>-->
                    <!--</div>-->
                    <!--</a>-->
                    <div class="tile-column-span-2">
                        <a class="tile wide imagetext wideimage bg-color-blue" href="#">


                            <iucon:PartialUpdatePanel runat="server" ID="PartialUpdatePanel3" UserControlPath="~/AddSellerType.ascx"
                      >
                        <ErrorTemplate>
                            Unable to refresh content
                        </ErrorTemplate>
                        <LoadingTemplate>
                            <div style="margin-left: 84px; margin-top: 10px;">
                                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/loading.gif" />
                            </div>
                            <div style="text-align: center">
                                Updating...
                            </div>
                        </LoadingTemplate>
                    </iucon:PartialUpdatePanel>


                           
                      

               </a><a class="tile wide imagetext wideimage bg-color-green" href="#">
                    <h2>
                        Data Binding 2 Process</h2>
                    <!--<a class="tile widepeek" href="#">-->
                    <!--<div class="tile wide image">-->
                    <!--<img src="http://upload.wikimedia.org/wikipedia/commons/thumb/8/8a/Darvasa_gas_crater_panorama.jpg/640px-Darvasa_gas_crater_panorama.jpg" alt=""/>-->
                    <!--</div>-->
                    <!--<div class="tile wide text bg-color-orange">-->
                    <!--<div class="text5">The Door to Hell, a burning natural gas field in Derweze, Turkmenistan</div>-->
                    <!--</div>-->
                    <!--</a>-->
                   

                       


                           
                        </a>
                    </div>
                </div>

                <div class="panorama-section">
                    <h2>
                        Featured articles</h2>
                    <div class="tile-column-span-2">
                        <a class="tile widepeek" href="#">
                            <div class="tile wide image">
                                  <h1>
                    Long time to update sample</h1>
                <div class="sample">
                    <iucon:PartialUpdatePanel runat="server" ID="PartialUpdatePanel2" UserControlPath="~/LongTimeUpdateSample.ascx">
                        <ErrorTemplate>
                            Unable to refresh content
                        </ErrorTemplate>
                        <LoadingTemplate>
                            <div style="margin-left: 84px; margin-top: 10px;">
                                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/loading.gif" />
                            </div>
                            <div style="text-align: center">
                                Updating...
                            </div>
                        </LoadingTemplate>
                    </iucon:PartialUpdatePanel>
                    Click on one of the other controls while this one is updating.
                </div>
                            </div>
                            <div class="tile wide text">
                                <div class="text-header">
                                    Fusō</div>
                                <div class="text4">
                                    Japanese battleship Fusō (扶桑, a classical name for Japan) was the lead ship of the
                                    two Fusō-class dreadnought battleships built for the Imperial Japanese Navy.</div>
                            </div>
                        </a><a class="tile wide imagetext wideimage bg-color-green" href="#">
                            <img src="http://upload.wikimedia.org/wikipedia/en/e/e9/Famous_Fantastic_Mysteries_August_1942_cover.jpg"
                                alt="" />
                            <div class="textover-wrapper transparent">
                                <div class="text2">
                                    Famous Fantastic Mysteries</div>
                            </div>
                        </a>
                    </div>
                </div>
              <%--  <div class="panorama-section tile-span-4">
                    <h2>
                        Featured apps</h2>
                    <a class="tile app bg-color-orange" href="#">
                        <div class="image-wrapper">
                            <span class="icon icon-mail"></span>
                        </div>
                        <div class="app-label">
                            Mail</div>
                        <div class="app-count">
                            12</div>
                    </a><a class="tile app bg-color-blue" href="#">
                        <div class="image-wrapper">
                            <span class="icon icon-map"></span>
                        </div>
                        <div class="app-label">
                            Map</div>
                    </a><a class="tile wide imagetext bg-color-greenDark" href="#">
                        <div class="image-wrapper">
                            <span class="icon icon-chat-2"></span>
                        </div>
                        <div class="column-text">
                            <div class="text4">
                                Chat with your friends</div>
                        </div>
                        <div class="app-label">
                            145 friends online</div>
                    </a><a class="tile app bg-color-purple" href="#">
                        <div class="image-wrapper">
                            <span class="icon icon-weather"></span>
                        </div>
                        <div class="app-label">
                            Weather</div>
                    </a><a class="tile app bg-color-green" href="#">
                        <div class="image-wrapper">
                            <span class="icon icon-linkedin"></span>
                        </div>
                        <div class="app-label">
                            LinkedIn</div>
                    </a>
                </div>--%>
                <%--<div class="panorama-section tile-span-4">
                    <h2>
                        Group two</h2>
                    <a class="tile wide imagetext bg-color-blue" href="#">
                        <div class="image-wrapper">
                            <span class="icon icon-music-3"></span>
                        </div>
                        <div class="column-text">
                            <div class="text">
                                Top 10</div>
                            <div class="text">
                                Favorites</div>
                            <div class="text">
                                Best choices</div>
                        </div>
                        <span class="app-label">MUSIC</span> </a><a class="tile wide imagetext bg-color-blueDark"
                            href="./base-css.html">
                            <div class="image-wrapper">
                                <img src="src/assets/img/Coding app.png" />
                            </div>
                            <div class="column-text">
                                <div class="text">
                                    Typography</div>
                                <div class="text">
                                    Tables</div>
                                <div class="text">
                                    Forms</div>
                                <div class="text">
                                    Buttons</div>
                            </div>
                            <span class="app-label">BASE CSS</span> </a><a class="tile app bg-color-orange" href="#">
                                <div class="image-wrapper">
                                    <img src="src/assets/img/RegEdit.png" alt="" />
                                </div>
                                <span class="app-label">COMPONENTS</span> </a><a class="tile app bg-color-red" href="./javascript.html">
                                    <div class="image-wrapper">
                                        <img src="src/assets/img/Devices.png" alt="" />
                                    </div>
                                    <span class="app-label">JAVASCRIPT</span> </a>
                </div>--%>
            </div>
        </div>
        <a id="panorama-scroll-prev" href="#"></a><a id="panorama-scroll-next" href="#">
        </a>
        <div id="panorama-scroll-prev-bkg">
        </div>
        <div id="panorama-scroll-next-bkg">
        </div>
        <!--</div>-->
        <!--</div>-->
        <!--</div>-->
    </div>
    <div id="charms" class="win-ui-dark slide">
        <div id="theme-charms-section" class="charms-section">
            <div class="charms-header">
                <a href="#" class="close-charms win-backbutton"></a>
                <h2>
                    Settings</h2>
            </div>
            <div class="row-fluid">
                <div class="span12">
                    <form class="">
                    <label for="win-theme-select">
                        Change theme:</label>
                    <select id="win-theme-select" class="">
                        <option value="metro-ui-light">Light</option>
                        <option value="metro-ui-dark">Dark</option>
                    </select>
                    </form>
                </div>
            </div>
        </div>
    </div>
    </form> 
</body>
</html>
