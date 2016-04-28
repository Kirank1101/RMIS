var IelsV2Lib = new IelsV2Class();

function IelsV2Class() {
    this.BlockUI = function () {
        var centerY = true;
        $('body').block({
            message: '<img src="/_layouts/1033/Styles/IELS/SICC/img/ajax-loading.gif" align="">',
            centerY: centerY != undefined ? centerY : true,
            css: {
                top: '10%',
                border: 'none',
                padding: '2px',
                backgroundColor: 'none'
            },
            overlayCSS: {
                backgroundColor: '#000',
                opacity: 0.05,
                cursor: 'wait'
            }
        });
    }

    this.UnblockUI = function () {
        $('body').unblock({
            onUnblock: function () {
                $('body').css('position', '');
                $('body').css('zoom', '');
            }
        });
    }

    this.CreateEntity = function ($scope) {
        var elementBind = $('[ng-model]');
        var bindingInstance = {};
        $.each(elementBind, function (index, item) {
            var bindingPath = $(item).attr('ng-model');
            if (bindingPath.substr(bindingPath.length - 4) == "Code"
                && ($(item).attr('custom-select2') == "")) {
                bindingInstance[bindingPath] = $scope.$eval(bindingPath).Code;
                //console.log(bindingPath + ": " + $scope.$eval(bindingPath).Code);
            }
            else {
                bindingInstance[bindingPath] = $scope.$eval(bindingPath);
                //console.log(bindingPath + ": " + $scope.$eval(bindingPath));
            }
        });
        if ($scope.PracticeInfoItems != undefined && $scope.PracticeInfoItems.length > 0)
            bindingInstance["RFLPracticeInfoList"] = $scope.PracticeInfoItems;
        //console.log("Done creating entity.");
        return bindingInstance;
    }

    this.GetIndexFromArray = function (arrayObject, valueToSearch) {
        var indexFound = false;
        var retIndex = 0;
        $.each(arrayObject, function (index, obj) {
            if (!indexFound) {
                $.each(obj, function (attr, value) {
                    if (attr == "Code" && value == valueToSearch) {
                        retIndex = index;
                        indexFound = true;
                    }
                });
            }
        });
        return retIndex;
    }

    this.GetParameterByNameFromURL = function (name) {
        name = name.replace(/[\[]/, "\\\[").replace(/[\]]/, "\\\]");
        var regex = new RegExp("[\\?&]" + name + "=([^&#]*)"),
                    results = regex.exec(location.search);
        return results == null ? "" : decodeURIComponent(results[1].replace(/\+/g, " "));
    }
};