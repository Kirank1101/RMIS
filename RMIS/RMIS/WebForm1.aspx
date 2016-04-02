<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RMIS.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<!--[if gt IE 8]><!-->
<html class="no-js">
<!--<![endif]-->
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <meta name="viewport" content="width=device-width">
    <title>BootMetro Demo - Table</title>
    <link rel="stylesheet" type="text/css" href="src/assets/css/demo.css">
    <style>
        div
        {
            width: 300px;
            height: 200px;
            background-color: transparent;
            position: fixed;
            top: 0;
            bottom: 0;
            left: 0;
            right: 0;
            margin: auto;
        }
        td
        {
            padding: 5px;
        }
        
        input[type='text']
        {
            font-family: Verdana;
        }
    </style>
</head>
<body>
    <div>
        <table>
            <tr>
                <td>
                    UserName
                </td>
                <td>
                    <input type="text" id="txtusername" style="width: 150px" />
                </td>
            </tr>
            <tr>
                <td>
                    Password
                </td>
                <td>
                    <input type="password" id="txtPassword" style="width: 150px" />
                </td>
            </tr>
            <tr>
                <th colspan="2" style="padding-top:5px">
                    <input type="button" value="Submit" id="btnsubmit" />
                </th>
            </tr>
        </table>
    </div>
</body>
</html>
