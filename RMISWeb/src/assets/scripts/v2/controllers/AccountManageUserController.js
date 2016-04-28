angular.module('Account', ['customSelect2', 'customSelect2Key']).controller('AccountManageUserController', function ($scope, $http, $q) {
    $scope.init = function () {
        IelsV2Lib.BlockUI();

        $scope.request1 = $http({
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

        $q.all([$scope.request1]).then(function (values) {
            //console.log("Done loading all HTTP requests..");
            $http({
                method: 'POST',
                url: 'ManageUser.aspx/GetCurrentUserInfo',
                data: '',
                headers: { 'Content-Type': 'application/json; charset=utf-8' },
                dataType: 'json'
            }).
            success(function (data, status, headers, config) {
                var retValue = '';
                if (!data || typeof data.d == 'undefined') {
                    if (JSON.parse(data) != '') retValue = JSON.parse(JSON.parse(data));
                } else {
                    if (data.d != '') retValue = JSON.parse(data.d);
                }

                if (retValue != '') {
                    $scope.SalutationCode = retValue.SalutationCode;
                    $scope.FullName = retValue.FullName;
                    $scope.IdentityType = retValue.IdentityType;
                    $scope.IdentityTypeCode = retValue.IdentityTypeCode;
                    $scope.IdentityNo = retValue.IdentityNo;
                    $scope.Nationality = retValue.Nationality;
                    $scope.NationalityCode = retValue.NationalityCode;
                    $scope.Gender = retValue.Gender;
                    $scope.GenderCode = retValue.GenderCode;

                    $scope.TelCountryCode = Number(retValue.TelCountryCode);
                    $scope.TelAreaCode = Number(retValue.TelAreaCode);
                    $scope.TelNumber = Number(retValue.TelNumber);
                    $scope.FaxCountryCode = Number(retValue.FaxCountryCode);
                    $scope.FaxAreaCode = Number(retValue.FaxAreaCode);
                    $scope.FaxNumber = Number(retValue.FaxNumber);
                    $scope.MobileCountryCode = Number(retValue.MobileCountryCode);
                    $scope.MobileNumber = Number(retValue.MobileNumber);
                    $scope.Email = retValue.Email;

                    $scope.Address1 = retValue.Address1;
                    $scope.Address2 = retValue.Address2;
                    $scope.State = retValue.State;
                    $scope.City = retValue.City;
                    var countryIndex = IelsV2Lib.GetIndexFromArray($scope.Countries, retValue.CountryCode);
                    $scope.CountryCode = $scope.Countries[countryIndex];
                    $scope.PostalCode = retValue.PostalCode;
                }
            }).
            error(function (data, status) {
                //console.log("Error loading RFLDetails.");
            });

            IelsV2Lib.UnblockUI();
        });
    }

    $scope.submit = function (form) {
        IelsV2Lib.BlockUI();
        $scope.submitted = true;

        if (form.$invalid) {
            IelsV2Lib.UnblockUI();
            return;
        } else {
            var entity = IelsV2Lib.CreateEntity($scope);
            //console.log("Done creating entity. Now sending data to server...");
            var parameterName = "userInfo";
            var parameters = '{"' + parameterName + '":' + JSON.stringify(JSON.stringify(entity)) + '}';

            $http({
                method: "POST",
                url: 'ManageUser.aspx/SaveUserInfo',
                data: parameters,
                headers: { 'Content-Type': 'application/json' }
            }).success(function (data, status, headers, config) {
                //console.log("Done sending to server...");
                $('.alert-success').show();
                $('#divContent').hide();
                IelsV2Lib.UnblockUI();
            }).error(function (data, status, headers, config) {
                $scope.status = status + ' ' + headers;
                IelsV2Lib.UnblockUI();
            });
        }
    }
});