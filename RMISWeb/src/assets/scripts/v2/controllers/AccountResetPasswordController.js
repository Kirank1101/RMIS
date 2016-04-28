angular.module('Account', []).controller('AccountResetPasswordController', function ($scope, $http, $parse) {
    $scope.submit = function (form) {
        IelsV2Lib.BlockUI();
        $scope.submitted = true;

        if (form.$invalid) {
            IelsV2Lib.UnblockUI();
            return;
        } else {
            $("#origMessage").html('We are now processing your request. Please wait patiently while we are resetting your password...');
            $("#btnSubmit").hide();

            var entity = IelsV2Lib.GetParameterByNameFromURL('t');
            var parameterName = "t";
            var parameters = '{"' + parameterName + '":' + JSON.stringify(JSON.stringify(entity)) + '}';

            $http({
                method: "POST",
                url: 'ResetPassword.aspx/ProceedToResetPassword',
                data: parameters,
                headers: { 'Content-Type': 'application/json' }
            }).success(function (data, status, headers, config) {
                var validationResult = null;
                if (!data || typeof data.d == 'undefined')
                    validationResult = JSON.parse(JSON.parse(data));
                else
                    validationResult = JSON.parse(data.d);

                if (!validationResult.IsValid) {
                    $("#pnlMessageError").show();
                }
                else {
                    $("#pnlMessageSuccess").show();
                }
                $("#messagePanel").hide();
                IelsV2Lib.UnblockUI();
            }).error(function (data, status, headers, config) {
                $scope.status = status + ' ' + headers;
                IelsV2Lib.UnblockUI();
            });
        }
    }
});