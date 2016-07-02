<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DashBoard.ascx.cs" Inherits="DashBoard" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>

<script type="text/javascript" src="js/jquery-1.11.1.js"></script>
<div id="divTopTiles">
    &nbsp;</div>
<script type="text/javascript">




    $(document).ready(function () {
        var ControlName = "Widget_TopTiles.ascx";
        $.ajax({
            type: "POST",
            url: "Default.aspx/Result",
            data: "{controlName:'" + ControlName + "'}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                $.unblockUI();
                $('#divTopTiles').html(response.d);
            },
            failure: function (msg) {
                $.unblockUI();
                $('#divTopTiles').html(msg);
            }
        });

    });      
</script>
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
                <div id="result1">
                    &nbsp;</div>
                <script type="text/javascript">
                    $(document).ready(function () {

                        var ControlName = "Widget_PaddyStock.ascx";
                        $.ajax({
                            type: "POST",
                            url: "Default.aspx/Result",
                            data: "{controlName:'" + ControlName + "'}",
                            contentType: "application/json; charset=utf-8",
                            dataType: "json",
                            success: function (response) {
                                $.unblockUI();
                                $('#result1').html(response.d);
                            },
                            failure: function (msg) {
                                $.unblockUI();
                                $('#result1').html(msg);
                            }
                        });

                    });      
                </script>
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
                <div id="divRiceStock">
                    &nbsp;</div>
                <script type="text/javascript">
                    $(document).ready(function () {

                        var ControlName = "Widget_RiceStock.ascx";
                        $.ajax({
                            type: "POST",
                            url: "Default.aspx/Result",
                            data: "{controlName:'" + ControlName + "'}",
                            contentType: "application/json; charset=utf-8",
                            dataType: "json",
                            success: function (response) {
                                $.unblockUI();
                                $('#divRiceStock').html(response.d);
                            },
                            failure: function (msg) {
                                $.unblockUI();
                                $('#divRiceStock').html(msg);
                            }
                        });

                    });      
                </script>
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
                <div id="divBrokenRiceStock">
                    &nbsp;</div>
                <script type="text/javascript">
                    $(document).ready(function () {

                        var ControlName = "Widget_BrokenRiceStock.ascx";
                        $.ajax({
                            type: "POST",
                            url: "Default.aspx/Result",
                            data: "{controlName:'" + ControlName + "'}",
                            contentType: "application/json; charset=utf-8",
                            dataType: "json",
                            success: function (response) {
                                $.unblockUI();
                                $('#divBrokenRiceStock').html(response.d);
                            },
                            failure: function (msg) {
                                $.unblockUI();
                                $('#divBrokenRiceStock').html(msg);
                            }
                        });

                    });      
                </script>
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
                <div id="divBagStock">
                    &nbsp;</div>
                <script type="text/javascript">
                    $(document).ready(function () {

                        var ControlName = "Widget_BagStock.ascx";
                        $.ajax({
                            type: "POST",
                            url: "Default.aspx/Result",
                            data: "{controlName:'" + ControlName + "'}",
                            contentType: "application/json; charset=utf-8",
                            dataType: "json",
                            success: function (response) {
                                $.unblockUI();
                                $('#divBagStock').html(response.d);
                            },
                            failure: function (msg) {
                                $.unblockUI();
                                $('#divBagStock').html(msg);
                            }
                        });

                    });      
                </script>
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
                <div id="divTotalCreditDue">
                    &nbsp;</div>
                <script type="text/javascript">
                    $(document).ready(function () {

                        var ControlName = "Widget_TotalCreditDue.ascx";
                        $.ajax({
                            type: "POST",
                            url: "Default.aspx/Result",
                            data: "{controlName:'" + ControlName + "'}",
                            contentType: "application/json; charset=utf-8",
                            dataType: "json",
                            success: function (response) {
                                $.unblockUI();
                                $('#divTotalCreditDue').html(response.d);
                            },
                            failure: function (msg) {
                                $.unblockUI();
                                $('#divTotalCreditDue').html(msg);
                            }
                        });

                    });      
                </script>
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
                <div id="divTotalAmountDue">
                    &nbsp;</div>
                <script type="text/javascript">
                    $(document).ready(function () {

                        var ControlName = "Widget_TotalAmountDue.ascx";
                        $.ajax({
                            type: "POST",
                            url: "Default.aspx/Result",
                            data: "{controlName:'" + ControlName + "'}",
                            contentType: "application/json; charset=utf-8",
                            dataType: "json",
                            success: function (response) {
                                $.unblockUI();
                                $('#divTotalAmountDue').html(response.d);
                            },
                            failure: function (msg) {
                                $.unblockUI();
                                $('#divTotalAmountDue').html(msg);
                            }
                        });

                    });      
                </script>
            </div>
        </div>
    </div>
</div>
