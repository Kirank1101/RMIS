angular.module('Account', ['serverError']).controller('AccountLoginController', function ($scope, $http, $parse) {
    $scope.submit = function (form) {
        IelsV2Lib.BlockUI();
        $scope.submitted = true;

        if (form.$invalid) {
            IelsV2Lib.UnblockUI();
            return;
        } else {
            var entity = IelsV2Lib.CreateEntity($scope);
            var parameterName = "authenticationToken";
            var parameters = '{"' + parameterName + '":' + JSON.stringify(JSON.stringify(entity)) + '}';

            $http({
                method: "POST",
                url: 'Login.aspx/Authenticate',
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
                    this.window.location.href = validationResult.URLToRedirect;
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
                $('#server-error-message').html('');
                $('#divServerErrorMsg').hide();

                scope.$apply(function () {
                    //scope.login.Email.$setValidity('serverMessage', true);
                    ngModelController[0].$setValidity('serverMessage', true);
                });
            });
        }
    }
});