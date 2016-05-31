///<reference name="MicrosoftAjax.js" />
Type.registerNamespace('RMIS.CustomControls');

RMIS.CustomControls.GridViewKeyBoardPagerBehavior = function(element) {

    RMIS.CustomControls.GridViewKeyBoardPagerBehavior.initializeBase(this, [element]);

    this._firstKeyCode = null;
    this._lastKeyCode = null;
    this._prevKeyCode = null;
    this._nextKeyCode = null;
    this._firstCmdArgument = null;
    this._lastCmdArgument = null;
    this._prevCmdArgument = null;
    this._nextCmdArgument = null;

    this._prevSelectKeyCode = null;
    this._nextSelectKeyCode = null;
    this._prevSelectCmdArgument = null;
    this._nextSelectCmdArgument = null;

    this._editBeginKeyCode = null;
    this._editCancelKeyCode = null;
    this._editUpdateKeyCode = null;
    this._editBeginCmdArgument = null;
    this._editCancelCmdArgument = null;
    this._editUpdateCmdArgument = null;

    this._delKeyCode = null;
    this._delCmdArgument = null;

    this._sortColumns = null;

    this._postBackCtrlID = null;
}
RMIS.CustomControls.GridViewKeyBoardPagerBehavior.prototype = {
    initialize: function() {
        RMIS.CustomControls.GridViewKeyBoardPagerBehavior.callBaseMethod(this, 'initialize');
        // we catch the keydown event at the document level of the HTML DOM tree
        $addHandler(document, 'keydown', Function.createDelegate(this, this._onKeyDown));
    },

    dispose: function() {
        RMIS.CustomControls.GridViewKeyBoardPagerBehavior.callBaseMethod(this, 'dispose');

        $clearHandlers(document);
    },

    get_editBeginKeyCode: function() {
        return this._editBeginKeyCode;
    },

    set_editBeginKeyCode: function(value) {
        this._editBeginKeyCode = value;
    },

    get_editCancelKeyCode: function() {
        return this._editCancelKeyCode;
    },

    set_editCancelKeyCode: function(value) {
        this._editCancelKeyCode = value;
    },

    get_editUpdateKeyCode: function() {
        return this._editUpdateKeyCode;
    },

    set_editUpdateKeyCode: function(value) {
        this._editUpdateKeyCode = value;
    },

    get_prevSelectKeyCode: function() {
        return this._prevSelectKeyCode;
    },

    set_prevSelectKeyCode: function(value) {
        this._prevSelectKeyCode = value;
    },

    get_nextSelectKeyCode: function() {
        return this._nextSelectKeyCode;
    },

    set_nextSelectKeyCode: function(value) {
        this._nexteSelectKeyCode = value;
    },

    get_firstKeyCode: function() {
        return this._firstKeyCode;
    },

    set_firstKeyCode: function(value) {
        this._firstKeyCode = value;
    },

    get_lastKeyCode: function() {
        return this._lastKeyCode;
    },

    set_lastKeyCode: function(value) {
        this._lastKeyCode = value;
    },

    get_prevKeyCode: function() {
        return this._prevKeyCode;
    },

    set_prevKeyCode: function(value) {
        this._prevKeyCode = value;
    },

    get_nextKeyCode: function() {
        return this._nextKeyCode;
    },

    set_nextKeyCode: function(value) {
        this._nextKeyCode = value;
    },

    get_delKeyCode: function() {
        return this._delKeyCode;
    },

    set_delKeyCode: function(value) {
        this._delKeyCode = value;
    },

    get_editBeginCmdArgument: function() {
        return this._editBeginCmdArgument;
    },

    set_editBeginCmdArgument: function(value) {
        this._editBeginCmdArgument = value;
    },

    get_editCancelCmdArgument: function() {
        return this._editCancelCmdArgument;
    },

    set_editCancelCmdArgument: function(value) {
        this._editCancelCmdArgument = value;
    },

    get_editUpdateCmdArgument: function() {
        return this._editUpdateCmdArgument;
    },

    set_editUpdateCmdArgument: function(value) {
        this._editUpdateCmdArgument = value;
    },

    get_prevSelectCmdArgument: function() {
        return this._prevSelectCmdArgument;
    },

    set_prevSelectCmdArgument: function(value) {
        this._prevSelectCmdArgument = value;
    },

    get_nextSelectCmdArgument: function() {
        return this._nextSelectCmdArgument;
    },

    set_nextSelectCmdArgument: function(value) {
        this._nextSelectCmdArgument = value;
    },

    get_firstCmdArgument: function() {
        return this._firstCmdArgument;
    },

    set_firstCmdArgument: function(value) {
        this._firstCmdArgument = value;
    },


    get_lastCmdArgument: function() {
        return this._lastCmdArgument;
    },

    set_lastCmdArgument: function(value) {
        this._lastCmdArgument = value;
    },


    get_nextCmdArgument: function() {
        return this._nextCmdArgument;
    },

    set_nextCmdArgument: function(value) {
        this._nextCmdArgument = value;
    },

    get_prevCmdArgument: function() {
        return this._prevCmdArgument;
    },

    set_prevCmdArgument: function(value) {
        this._prevCmdArgument = value;
    },

    get_delCmdArgument: function() {
        return this._delCmdArgument;
    },

    set_delCmdArgument: function(value) {
        this._delCmdArgument = value;
    },

    get_sortColumns: function() {
        return (this._sortColumns != null) ? Sys.Serialization.JavaScriptSerializer.deserialize(this._sortColumns) : '';
    },

    set_sortColumns: function(value) {
        this._sortColumns = value;
    },

    get_postBackCtrlID: function() {
        return this._postBackCtrlID;
    },

    set_postBackCtrlID: function(value) {
        this._postBackCtrlID = value;
    },

    // Event Handler that catches the keyboard event
    _onKeyDown: function(keyEvent) {
        try {
            var cmdArgument = "";
            if (keyEvent.altKey == true) {
                // user pressed a number (ASCII code 48-57)
                if ((keyEvent.keyCode >= 48) || (keyEvent.keyCode <= 57)) {
                    var index = (keyEvent.keyCode == 48) ? 9 : keyEvent.keyCode - 49;
                    if ((index < this.get_sortColumns().length) && (index >= 0)) {
                        cmdArgument = "Sort$" + this.get_sortColumns()[index];
                    }
                }

                if (keyEvent.keyCode == this._firstKeyCode) {
                    cmdArgument = this._firstCmdArgument;
                }

                if (keyEvent.keyCode == this._lastKeyCode) {
                    cmdArgument = this._lastCmdArgument;
                }

                if (keyEvent.keyCode == this._editBeginKeyCode) {
                    cmdArgument = this._editBeginCmdArgument;
                }

                if (keyEvent.keyCode == this._editCancelKeyCode) {
                    cmdArgument = this._editCancelCmdArgument;
                }

                if (keyEvent.keyCode == this._editUpdateKeyCode) {
                    window.onkeypress = function(keyEvent) { return false; }
                    if (this._editUpdateCmdArgument != "") {
                        FeedBack = confirm("Save Changes?");
                        if (FeedBack) {
                            cmdArgument = this._editUpdateCmdArgument;
                        }
                        else {
                            cmdArgument = this._cancelUpdateCmdArgument;
                        }
                    }
                }
                if (cmdArgument != "") {
                    keyEvent.stopPropagation();
                    keyEvent.preventDefault();
                    __doPostBack(this._postBackCtrlID, cmdArgument);
                    return;
                }
            }

            // Selecting Rows
            if (keyEvent.keyCode == this._nextSelectKeyCode) {
                cmdArgument = this._nextSelectCmdArgument;
            }

            if (keyEvent.keyCode == this._prevSelectKeyCode) {
                cmdArgument = this._prevSelectCmdArgument;
            }

            if (keyEvent.keyCode == this._nextKeyCode) {
                cmdArgument = this._nextCmdArgument;
            }

            if (keyEvent.keyCode == this._prevKeyCode) {
                cmdArgument = this._prevCmdArgument;
            }

            if (keyEvent.keyCode == this._delKeyCode) {
                if (this._delCmdArgument != "") {
                    FeedBack = confirm("Do you really want delete this row?");
                    if (FeedBack) {
                        cmdArgument = this._delCmdArgument;
                    }
                }
            }
            if (cmdArgument != "") {
                __doPostBack(this._postBackCtrlID, cmdArgument);
                return;
            }
        }
        catch (e) {
            Sys.Debug.traceDump(e);
        }
    }
}

RMIS.CustomControls.GridViewKeyBoardPagerBehavior.registerClass('RMIS.CustomControls.GridViewKeyBoardPagerBehavior', Sys.UI.Behavior);