<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ToolkitSample.ascx.cs"
    Inherits="ToolkitSample" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
Here you find just two examples of integrated controls from the AJAX Control Toolkit.<br />
Just as a sample that it works... ;-)
<h2>
    NumericUpDown Demonstration</h2>
<asp:TextBox ID="NumericTextBox1" runat="server" Text="3" Width="120" Style="text-align: center" />
<ajaxToolkit:NumericUpDownExtender ID="NumericUpDownExtender1" runat="server" TargetControlID="NumericTextBox1"
    Width="120" RefValues="" ServiceDownMethod="" ServiceUpMethod="" TargetButtonDownID=""
    TargetButtonUpID="" Minimum="1" Maximum="7" />
<h2>
    AutoComplete Demonstration</h2>
<asp:Panel runat="server" DefaultButton="Button1">
    Type some characters in this textbox. The web service returns random words that
    start with the text you have typed.
    <br />
    <br />
    <p />
    Value from myTextBox:
    <asp:Label runat="server" ID="Label1" Text="nothing entered yet" Font-Bold="true" />
    <p />
    <asp:TextBox runat="server" ID="myTextBox" Width="200" autocomplete="off" />
    <ajaxToolkit:AutoCompleteExtender runat="server" BehaviorID="AutoCompleteEx" ID="autoComplete1"
        TargetControlID="myTextBox" ServicePath="AutoComplete.asmx" ServiceMethod="GetCompletionList"
        MinimumPrefixLength="2" CompletionInterval="1000" EnableCaching="true" CompletionSetCount="20"
        CompletionListCssClass="autocomplete_completionListElement" CompletionListItemCssClass="autocomplete_listItem"
        CompletionListHighlightedItemCssClass="autocomplete_highlightedListItem" DelimiterCharacters=";, :">
        <Animations>
        <OnShow>
            <Sequence>
                <%-- Make the completion list transparent and then show it --%>
                <OpacityAction Opacity="0" />
                <HideAction Visible="true" />
                
                <%--Cache the original size of the completion list the first time
                    the animation is played and then set it to zero --%>
                <ScriptAction Script="
                    // Cache the size and setup the initial size
                    var behavior = $find('AutoCompleteEx');
                    if (!behavior._height) {
                        var target = behavior.get_completionList();
                        behavior._height = target.offsetHeight - 2;
                        target.style.height = '0px';
                    }" />
                
                <%-- Expand from 0px to the appropriate size while fading in --%>
                <Parallel Duration=".4">
                    <FadeIn />
                    <Length PropertyKey="height" StartValue="0" EndValueScript="$find('AutoCompleteEx')._height" />
                </Parallel>
            </Sequence>
        </OnShow>
        <OnHide>
            <%-- Collapse down to 0px and fade out --%>
            <Parallel Duration=".4">
                <FadeOut />
                <Length PropertyKey="height" StartValueScript="$find('AutoCompleteEx')._height" EndValue="0" />
            </Parallel>
        </OnHide>
        </Animations>
    </ajaxToolkit:AutoCompleteExtender>
    <asp:Button runat="server" ID="Button1" Text="Make a partial PostBack" UseSubmitBehavior="false"
        OnClick="Button1_Click" />
    <br />
    <br />
    <asp:LinkButton ID="LinkButton1" runat="server" Text="Open a modal dialog box" />
    <asp:Panel ID="Panel1" runat="server" Style="display: none" CssClass="modalPopup">
        <asp:Panel ID="Panel3" runat="server" Style="cursor: move; background-color: #DDDDDD;
            border: solid 1px Gray; color: Black">
            <div>
                <p>
                    ModalPopup</p>
            </div>
        </asp:Panel>
        <div>
            <p>
                Yeah, this finally works too :-)
            </p>
            <p style="text-align: center;">
                <%-- The click on OkButton causes a partial PostBack --%>
                <asp:Button ID="OkButton" runat="server" Text="OK" />
                <%-- The click on CancelButton does nothing --%>
                <input id="CancelButton" runat="server" type="button"
                    value="Cancel" />                
            </p>
        </div>
    </asp:Panel>
    <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender" runat="server" TargetControlID="LinkButton1"
        PopupControlID="Panel1" BackgroundCssClass="modalBackground" OkControlID="OkButton"
        CancelControlID="CancelButton" DropShadow="true" PopupDragHandleControlID="Panel3" />
</asp:Panel>
