angular.module('Account', ['customSelect2', 'customSelect2Key', 'serverError', 'uniqueEmail']).
  controller('AccountRegistrationController', function ($scope, $http, $q, $parse) {
    $scope.init = function () {
        IelsV2Lib.BlockUI();

        $scope.request1 = $http({
            method: 'POST',
            url: 'Registration.aspx/GetSalutations',
            data: '',
            headers: { 'Content-Type': 'application/json; charset=utf-8' },
            dataType: 'json'
        }).
        success(function (data, status, headers, config) {
            if (!data || typeof data.d == 'undefined')
                $scope.Salutations = JSON.parse(JSON.parse(data));
            else
                $scope.Salutations = JSON.parse(data.d);
        }).
        error(function (data, status) {
            //console.log("Error loading Salutations.");
        });

        $scope.request2 = $http({
            method: 'POST',
            url: 'Registration.aspx/GetIdentityTypes',
            data: '',
            headers: { 'Content-Type': 'application/json; charset=utf-8' },
            dataType: 'json'
        }).
        success(function (data, status, headers, config) {
            if (!data || typeof data.d == 'undefined')
                $scope.IdentityTypes = JSON.parse(JSON.parse(data));
            else
                $scope.IdentityTypes = JSON.parse(data.d);

            $scope.IdentityTypeCode = $scope.IdentityTypes[0];
        }).
        error(function (data, status) {
            //console.log("Error loading Identity Types.");
        });

        $scope.request3 = $http({
            method: 'POST',
            url: 'Registration.aspx/GetNationalities',
            data: '',
            headers: { 'Content-Type': 'application/json; charset=utf-8' },
            dataType: 'json'
        }).
        success(function (data, status, headers, config) {
            if (!data || typeof data.d == 'undefined')
                $scope.Nationalities = JSON.parse(JSON.parse(data));
            else
                $scope.Nationalities = JSON.parse(data.d);
        }).
        error(function (data, status) {
            //console.log("Error loading Nationalities.");
        });

        $scope.request4 = $http({
            method: 'POST',
            url: 'Registration.aspx/GetCountries',
            data: '',
            headers: { 'Content-Type': 'application/json; charset=utf-8' },
            dataType: 'json'
        }).
        success(function (data, status, headers, config) {
            if (!data || typeof data.d == 'undefined')
                $scope.Countries = JSON.parse(JSON.parse(data));
            else {
                $scope.Countries = JSON.parse(data.d);
            }
        }).
        error(function (data, status) {
            //console.log("Error loading Countries.");
        });

        $q.all([$scope.request1, $scope.request2, $scope.request3, $scope.request4]).then(function (values) {
            //console.log("Done loading all HTTP requests..");

            IelsV2Lib.UnblockUI();
        });
    }

    $scope.submit = function (form) {
        IelsV2Lib.BlockUI();
        $scope.submitted = true;

        if (form.$invalid) {
            $("#btnCaptchaRefresh").click();
            $scope.SecurityCode = '';
            IelsV2Lib.UnblockUI();
            return;
        } else {
            var entity = IelsV2Lib.CreateEntity($scope);
            //console.log("Done creating entity. Now sending data to server...");
            var parameterName = "registrationInfo";
            var parameters = '{"' + parameterName + '":' + JSON.stringify(JSON.stringify(entity)) + '}';

            $http({
                method: "POST",
                url: 'Registration.aspx/Register',
                data: parameters,
                headers: { 'Content-Type': 'application/json' }
            }).success(function (data, status, headers, config) {
                var validationResult = null;
                if (!data || typeof data.d == 'undefined')
                    validationResult = JSON.parse(JSON.parse(data));
                else
                    validationResult = JSON.parse(data.d);

                if (!validationResult.IsValid) {
                    var prevItemPropertyName = '';
                    $.each(validationResult.Items, function (index, item) {
                        if (typeof item.PropertyName != 'undefined' && item.PropertyName != ''
                            && item.PropertyName != null) {
                            if (prevItemPropertyName != item.PropertyName) {
                                prevItemPropertyName = item.PropertyName;
                                form[item.PropertyName].$setValidity('serverMessage', false);

                                var serverMessage = $parse(form.$name + '.' + item.PropertyName + '.$error.serverMessage');
                                serverMessage.assign($scope, item.ErrorMessage);
                            }
                        } else {
                            $('#server-error-message').html(item.ErrorMessage);
                            $('#divServerErrorMsg').show();
                        }
                    });
                }
                else {
                    //console.log("Done sending to server...");
                    $('.alert-success').show();
                    $('#divContent').hide();
                }
                IelsV2Lib.UnblockUI();
            }).error(function (data, status, headers, config) {
                $scope.status = status + ' ' + headers;
                IelsV2Lib.UnblockUI();
            });
        }
    }
});

angular.module('serverError', []).directive('serverError', function () {
    return {
        restrict: 'A',
        require: ['?ngModel'],
        link: function (scope, element, attrs, ngModelController) {
            element.on('keyup change', function (e) {
                scope.$apply(function () {
                    ngModelController[0].$setValidity('serverMessage', true);
                });
            });
        }
    }
});

angular.module('uniqueEmail', []).directive('uniqueEmail', function ($http) {
    var toId;
    return {
        restrict: 'A',
        require: 'ngModel',
        link: function (scope, elem, attr, ctrl) {
            //when the scope changes, check the email.
            scope.$watch(attr.ngModel, function (value) {
                // if there was a previous attempt, stop it.
                if (toId) clearTimeout(toId);

                // start a new attempt with a delay to keep it from
                // getting too "chatty".
                toId = setTimeout(function () {
                    var bindingInstance = {};
                    bindingInstance["IdentityNo"] = scope.$eval("IdentityNo");
                    bindingInstance["FullName"] = scope.$eval("FullName");
                    bindingInstance["Email"] = value;

                    var parameterName = "userData";
                    var parameters = '{"' + parameterName + '":' + JSON.stringify(JSON.stringify(bindingInstance)) + '}';

                    $http({
                        method: "POST",
                        url: 'Registration.aspx/IsForeignUserValidOrNotBlacklisted',
                        data: parameters,
                        headers: { 'Content-Type': 'application/json' }
                    }).success(function (data, status, headers, config) {
                        //set the validity of the field
                        if (!data || typeof data.d == 'undefined')
                            validationResult = JSON.parse(JSON.parse(data));
                        else
                            validationResult = JSON.parse(data.d);

                        if (!validationResult.IsValid) {
                            if (validationResult.Items[0].ErrorMessage == "invalidEmail") {
                                ctrl.$setValidity('uniqueEmail', false);
                            } else {
                                ctrl.$setValidity('uniqueEmail', true);
                            }

                            if (validationResult.Items[0].ErrorMessage == "userIsBlacklisted") {
                                ctrl.$setValidity('blacklisted', false);
                            } else {
                                ctrl.$setValidity('blacklisted', true);
                            }
                        }
                    }).error(function (data, status, headers, config) {
                    });
                }, 200);
            })
        }
    }
});