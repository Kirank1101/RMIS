<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default"
    MasterPageFile="~/MasterPage.master" %>

<%@ Register Assembly="iucon.web.Controls.PartialUpdatePanel" Namespace="iucon.web.Controls"
    TagPrefix="iucon" %>
<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <table border="0" cellspacing="10">
        <tr>
            <td>
                <h1>
                    Control PostBack sample</h1>
                <div class="sample">
                    <iucon:PartialUpdatePanel runat="server" ID="Panel1" UserControlPath="~/PostBackSample.ascx"
                        InitialRenderBehaviour="Serverside">
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
                </div>
            </td>
            <td>
                <h1>
                    External refresh sample</h1>
                <div class="sample">
                    <iucon:PartialUpdatePanel runat="server" ID="PartialUpdatePanel1" UserControlPath="~/ExternalRefreshSample.ascx"
                        InitialRenderBehaviour="None">
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
                        <InitialTemplate>
                            Nothing useful here until you click on the button
                        </InitialTemplate>
                    </iucon:PartialUpdatePanel>
                </div>
                <input type="button" onclick="$find('<%= PartialUpdatePanel1.ClientID %>').refresh(); return false;"
                    value="Click to update panel" />
            </td>
            <td>
                <h1>
                    Parameter sample</h1>
                <div class="sample">
                    <iucon:PartialUpdatePanel runat="server" ID="PartialUpdatePanel4" UserControlPath="~/ParameterSample.ascx">
                        <Parameters>
                            <iucon:Parameter Name="MyParameter" Value="Hello world" />
                            <iucon:Parameter Name="Counter" Value="0" />
                        </Parameters>
                        <ErrorTemplate>
                            Unable to refresh content
                        </ErrorTemplate>
                    </iucon:PartialUpdatePanel>
                </div>

                <script type="text/javascript">
                    var counter = 0;

                    function updateParameterSample() {
                        $find('<%= PartialUpdatePanel4.ClientID %>').get_Parameters()["Counter"] = ++counter;
                        $find('<%= PartialUpdatePanel4.ClientID %>').refresh();
                    }
                </script>

                <input type="button" onclick="updateParameterSample(); return false;" value="Click to update panel with counter" />
            </td>
        </tr>
        <tr>
            <td>
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
            </td>
            <td>
                <h1>
                    DataBinding sample</h1>
                <div class="sample">
                    <iucon:PartialUpdatePanel runat="server" ID="PartialUpdatePanel3" UserControlPath="~/DataBindingSample.ascx"
                        InitialRenderBehaviour="Serverside" DisplayLoadingAfter="500">
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
                </div>
            </td>
            <td>
                <h1>
                    Change control during runtime sample</h1>
                <div class="sample">

                    <script type="text/javascript">
                        function changeControlSample(path) {
                            $find('<%= PartialUpdatePanel7.ClientID %>').set_UserControlPath(path);
                            $find('<%= PartialUpdatePanel7.ClientID %>').refresh();
                        }
                    </script>

                    Klick on a button to load a new control<br />
                    <input type="button" value="PostBackSample" onclick="changeControlSample('~/PostBackSample.ascx')" />
                    <input type="button" value="DataBindingSample" onclick="changeControlSample('~/DataBindingSample.ascx')" />
                    <br />
                    <br />
                    <iucon:PartialUpdatePanel runat="server" ID="PartialUpdatePanel7" UserControlPath="~/PostBackSample.ascx"
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
            </td>
        </tr>
        <tr>
            <td>
                <h1>
                    JavaScript sample</h1>
                <div class="sample">
                    <iucon:PartialUpdatePanel runat="server" ID="PartialUpdatePanel6" UserControlPath="~/JavaScriptSample.ascx">
                    </iucon:PartialUpdatePanel>
                </div>
            </td>
            <td>
                <h1>
                    Auto refresh sample</h1>
                <div class="sample">
                    <iucon:PartialUpdatePanel runat="server" ID="PartialUpdatePanel5" UserControlPath="~/ExternalRefreshSample.ascx"
                        AutoRefreshInterval="1000">
                        <ErrorTemplate>
                            Unable to refresh content
                        </ErrorTemplate>
                    </iucon:PartialUpdatePanel>
                </div>
            </td>
            <td>
                <h1>
                    Redirect sample</h1>
                <div class="sample">
                    <iucon:PartialUpdatePanel runat="server" ID="PartialUpdatePanel8" UserControlPath="~/RedirectSample.ascx">
                    </iucon:PartialUpdatePanel>
                </div>
            </td>
        </tr>
        <tr>
            <td colspan="3" align="center">
                <asp:Button ID="Button1" runat="server" Text="Make a full PostBack" />
            </td>
        </tr>
    </table>
</asp:Content>
