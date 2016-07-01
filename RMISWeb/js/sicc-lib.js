var SiccLib = new SiccClass();

function SiccClass() {
    this.Init = function () {
        $('[ajax=true]').click(function (e) {
            e.preventDefault();
            SiccLib.ExecuteAjaxPostMethod($(this));
        });

        $('.radio > span > input[type=radio]').click(function () {
            var name = $(this).attr('name');
            $('.radio > span').removeClass('checked');
            $('input[type=radio][name=' + name + ']').removeAttr('checked');
            $(this).attr('checked', 'checked');
            $(this).closest('span').addClass('checked');
        });

        if ($('[ajax-get=true]').length > 0) {
            SiccLib.ExecuteAjaxGetMethod($('[ajax-get=true]'));
        }
    }

    this.ExecuteAjaxPostMethod = function (element) {
        SiccLib.BlockUI();
        $('span[class=help-block][for]').remove();
        $('.alert-success').hide();
        $('.alert-danger').hide();
        $('.form-group').removeClass('has-error');
        $('.input-icon').children('i').removeClass('fa-warning');
        var aspx = window.location.href.substr(window.location.href.lastIndexOf("/") + 1).replace('#', '');
        var webmethod = $(element).attr('ajax-post-method');
        var parameterName = $(element).attr('ajax-post-parameter');
        var resultMethod = $(element).attr('ajax-post-result-method');
        var errorMethod = $(element).attr('ajax-post-error-method');
        var entity = SiccLib.CreateEntity();
        var parameterData = '{"' + parameterName + '":' + JSON.stringify(JSON.stringify(entity)) + '}';
        SiccLib.ExecuteJsonService(
                    aspx,
                    webmethod,
                    parameterData,
                    SiccLib.ServiceResult,
                    resultMethod,
                    SiccLib.AjaxError,
                    errorMethod);
    }

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

    this.ExecuteMethod = function (method, result, parameters) {
        var successCallback = window[method];
        if (typeof successCallback === 'function') {
            successCallback(result, parameters);
        }
    }

    this.UnblockUI = function () {
        $('body').unblock({
            onUnblock: function () {
                $('body').css('position', '');
                $('body').css('zoom', '');
            }
        });
    }

    this.CreateEntity = function () {
        var elementBind = $('[binding-path]');
        var bindingInstance = {};
        $.each(elementBind, function (index, item) {
            var bindingPath = $(item).attr('binding-path');
            if ($(item).attr('type') == 'checkbox') {
                bindingInstance[bindingPath] = $(item).is(':checked');
            }
            else if ($(item).attr('type') == 'radio') {
                bindingInstance[bindingPath] = $(item).is(':checked');
                //var name = $(item).attr('name');
                //bindingInstance[bindingPath] = $('[name=' + name + '][checked=true]').val();
            }
            else
                bindingInstance[bindingPath] = $(item).val();
        });
        return bindingInstance;
    }

    this.ServiceResult = function (result, parameters, resultMethod) {
        if (result != "" && typeof result != "undefined") {
            if (typeof resultMethod != 'undefined') {
                SiccLib.ExecuteMethod(resultMethod, result, parameters);
            }
            else {
                var validationResult = JSON.parse(result);
                SiccLib.Validate(validationResult);
            }
        }
        SiccLib.UnblockUI();
    }

    this.Validate = function (validationResult) {
        if (validationResult.IsValid) {
            $('.alert-success').show();
            $('#divContent').hide();
        }
        else {
            $('.alert-danger').show();
            var messageSummary = '';
            $.each(validationResult.Items, function (index, item) {
                if (typeof item.PropertyName != 'undefined' && item.PropertyName != '' && item.PropertyName != null) {
                    $('[binding-path=' + item.PropertyName + ']').closest('.form-group').addClass('has-error');
                    $('[binding-path=' + item.PropertyName + ']').closest('[class^=col-md-]').append('<span class="help-block" for="' + item.PropertyName + '">' + item.ErrorMessage + '</span>');
                    var icon = $('[binding-path=' + item.PropertyName + ']').parent('.input-icon').children('i');
                    icon.addClass("fa-warning");
                }
                else {
                    messageSummary = messageSummary + item.ErrorMessage + '<br/>';
                }
            });
            if (messageSummary == '')
                $('#error-message').html("Validation errors occurred. Please confirm the fields and submit it again.");
            else
                $('#error-message').html(messageSummary);
        }
    }

    this.AjaxError = function (errorResult, errorMethod) {
        if (typeof errorMethod != 'undefined')
            SiccLib.ExecuteMethod(errorMethod, errorResult);
        else
            alert("An error has occurred.");
    }

    this.ExecuteJsonService = function (page, serviceName, parameters, successCallback, successCallbackParameters, errorCallback, errorCallbackParameters) {
        $.ajax({
            type: "POST",
            url: page + "/" + serviceName,
            data: parameters,
            contentType: "application/json; charset=utf-8",
            dataType: "json",

            error: function (error) {
                if (typeof errorCallback != 'undefined')
                    errorCallback(error, errorCallbackParameters);
                else
                    alert("An error has occurred.");
            },
            success: function (result) {
                if (!result || typeof result.d == 'undefined')
                    successCallback(result, parameters, successCallbackParameters);
                else
                    successCallback(result.d, parameters, successCallbackParameters);
            }
        });
    }

    this.ExecuteAjaxGetMethod = function (element) {
        SiccLib.BlockUI();
        var webmethod = element.attr('ajax-get-method');
        var aspx = window.location.href.substr(window.location.href.lastIndexOf("/") + 1).replace('#', '');
        var parameterName = element.attr('ajax-get-parameter');
        var parameterData = null;
        var resultMethod = element.attr('ajax-get-result-method');
        var errorMethod = element.attr('ajax-get-error-method');
        if (parameterName != '' && typeof parameterName != 'undefined') {
            parameterData = '{"' + parameterName + '":' + JSON.stringify(JSON.stringify(entity)) + '}';
        }

        SiccLib.ExecuteJsonService(
                aspx,
                webmethod,
                parameterData,
                SiccLib.DisplayResult,
                resultMethod,
                SiccLib.AjaxError,
                errorMethod);
    }

    this.DisplayResult = function (result, parameters, resultMethod) {
        if (result != "" && typeof result != "undefined") {
            if (typeof resultMethod != 'undefined') {
                SiccLib.ExecuteMethod(resultMethod, result, parameters);
            }
            else {
                var entity = JSON.parse(result);
                for (var key in entity) {
                    var element = $('[binding-path=' + key + ']');
                    if (element.length > 0) {
                        if (element.get(0).tagName == 'P' || element.get(0).tagName == 'LABEL' || element.get(0).tagName == 'SPAN') {
                            if (entity[key] != undefined) element.text(entity[key]);
                        } else {
                            if (entity[key] != null && entity[key].length > 0) {
                                element.val(entity[key]);
                            }
                        }
                    }

                    //for special cases only
                    if (key == 'ConferementOfDegree' && entity[key] != null) {
                        var cdDate = entity[key].split(" ")[0].split("/");
                        element.val(("0" + cdDate[1]).slice(-2) + '/' + ("0" + cdDate[0]).slice(-2) + '/' + cdDate[2]);
                    }
                }
            }
        }
        SiccLib.UnblockUI();
    }
};

$(document).ready(function () {
    SiccLib.Init();
});