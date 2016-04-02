<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Toolkit.aspx.cs" Inherits="Toolkit"
    MasterPageFile="~/MasterPage.master" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register Assembly="iucon.web.Controls.PartialUpdatePanel" Namespace="iucon.web.Controls"
    TagPrefix="iucon" %>
<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <ajaxToolkit:ToolkitScriptManager runat="server" EnablePartialRendering="true" CombineScriptsHandlerUrl="~/CombineScriptsHandler.ashx"
        CombineScripts="">
    </ajaxToolkit:ToolkitScriptManager>
    <table border="0" cellspacing="10">
        <tr>
            <td rowspan="2">
                <h1>
                    Integrating AJAX Control Toolkit sample</h1>
                <div class="sample">
                    <iucon:PartialUpdatePanel runat="server" ID="PartialUpdatePanel7" UserControlPath="~/ToolkitSample.ascx"
                        DisplayLoadingAfter="500" InitialRenderBehaviour="Clientside">
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
            </td>
        </tr>
    </table>
</asp:Content>
