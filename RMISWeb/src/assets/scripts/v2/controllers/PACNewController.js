angular.module('PACeFiling', ['customSelect2', 'customSelect2Key', 'serverError']).
    controller('PACNewController', function ($scope, $http, $q, $parse) {
        $scope.init = function () {
            IelsV2Lib.BlockUI();

            $scope.request1 = $http({
                method: 'POST',
                url: 'Step1_NewPAC.aspx/GetSalutations',
                data: '',
                headers: { 'Content-Type': 'application/json; charset=utf-8' },
                dataType: 'json'
            }).
            success(function (data, status, headers, config) {
                if (!data || typeof data.d == 'undefined')
                    $scope.Salutations = JSON.parse(JSON.parse(data));
                else
                    $scope.Salutations = JSON.parse(data.d);
                //console.log("Done loading Salutations...");
            }).
            error(function (data, status) {
                //console.log("Error loading Salutations.");
            });

            $scope.request2 = $http({
                method: 'POST',
                url: 'Step1_NewPAC.aspx/GetIdentityTypes',
                data: '',
                headers: { 'Content-Type': 'application/json; charset=utf-8' },
                dataType: 'json'
            }).
            success(function (data, status, headers, config) {
                if (!data || typeof data.d == 'undefined')
                    $scope.IdentityTypes = JSON.parse(JSON.parse(data));
                else
                    $scope.IdentityTypes = JSON.parse(data.d);
                //console.log("Done loading Identity Types...");
            }).
            error(function (data, status) {
                //console.log("Error loading Identity Types.");
            });

            $scope.request3 = $http({
                method: 'POST',
                url: 'Step1_NewPAC.aspx/GetNationalities',
                data: '',
                headers: { 'Content-Type': 'application/json; charset=utf-8' },
                dataType: 'json'
            }).
            success(function (data, status, headers, config) {
                if (!data || typeof data.d == 'undefined')
                    $scope.Nationalities = JSON.parse(JSON.parse(data));
                else
                    $scope.Nationalities = JSON.parse(data.d);
                //console.log("Done loading Nationalities...");
            }).
            error(function (data, status) {
                //console.log("Error loading Nationalities.");
            });

            $scope.request4 = $http({
                method: 'POST',
                url: 'Step1_NewPAC.aspx/GetCountries',
                data: '',
                headers: { 'Content-Type': 'application/json; charset=utf-8' },
                dataType: 'json'
            }).
            success(function (data, status, headers, config) {
                if (!data || typeof data.d == 'undefined') {
                    $scope.Countries = JSON.parse(JSON.parse(data));
                    $scope.IssuingCountries = JSON.parse(JSON.parse(data));
                }
                else {
                    $scope.Countries = JSON.parse(data.d);
                    $scope.IssuingCountries = JSON.parse(data.d);
                }
                //console.log("Done loading Countries...");
            }).
            error(function (data, status) {
                //console.log("Error loading Countries.");
            });

            $q.all([$scope.request1, $scope.request2, $scope.request3, $scope.request4]).then(function (values) {
                var sgidParam = null;
                if (getParameterByName('sgid') != '') sgidParam = getParameterByName('sgid');
                var parameterName = "sgid";
                var parameters = '{"' + parameterName + '":' + JSON.stringify(JSON.stringify(sgidParam)) + '}';

                $http({
                    method: 'POST',
                    url: 'Step1_NewPAC.aspx/GetPACDetails',
                    data: parameters,
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
                        var salutationIndex = IelsV2Lib.GetIndexFromArray($scope.Salutations, retValue.SalutationCode);
                        $scope.SalutationCode = $scope.Salutations[salutationIndex];
                        $scope.FullName = retValue.FullName;
                        var idTypeIndex = IelsV2Lib.GetIndexFromArray($scope.IdentityTypes, retValue.IdentityTypeCode);
                        $scope.IdentityTypeCode = $scope.IdentityTypes[idTypeIndex];
                        $scope.IdentityNo = retValue.IdentityNo;
                        var nationalityIndex = IelsV2Lib.GetIndexFromArray($scope.Nationalities, retValue.NationalityCode);
                        $scope.NationalityCode = $scope.Nationalities[nationalityIndex];
                        //console.log("GenderCode: " + retValue.GenderCode);
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

                        $scope.Address1 = (retValue.Address1 == null ? null : retValue.Address1);
                        $scope.Address2 = (retValue.Address2 == null ? null : retValue.Address2);
                        $scope.State = (retValue.State == null ? null : retValue.State);
                        $scope.City = (retValue.City == null ? null : retValue.City);
                        var countryIndex = IelsV2Lib.GetIndexFromArray($scope.Countries, retValue.CountryCode);
                        $scope.CountryCode = $scope.Countries[countryIndex];
                        $scope.PostalCode = (retValue.PostalCode == null ? null : retValue.PostalCode);
                    }

                    //console.log("CurrentUserRoleCode: " + retValue.CurrentUserRoleCode);
                    if (retValue.CurrentUserRoleCode == '0') {
                        $scope.shouldBeDisabled = true;
                    } else {
                        $scope.showRflFormTop = true;
                    }

                    IelsV2Lib.UnblockUI();
                }).
                error(function (data, status) {
                    //console.log("Error loading PACDetails.");
                });
            });
      }

      $scope.submit = function (form, methodName) {
          IelsV2Lib.BlockUI();
          $scope.submitted = true;

          if (form.$invalid) {
              IelsV2Lib.UnblockUI();
              return;
          } else {
              var entity = IelsV2Lib.CreateEntity($scope);
              var parameterName = "rflDetails";
              var parameters = '{"' + parameterName + '":' + JSON.stringify(JSON.stringify(entity)) + '}';

              $http({
                  method: "POST",
                  url: 'Step1_NewPAC.aspx/' + methodName,
                  data: parameters,
                  headers: { 'Content-Type': 'application/json' }
              }).success(function (data, status, headers, config) {
                  //console.log("Done sending to server...");
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
                      if (methodName == "Save_Step1_NewPAC") {
                          $("#pnlSaveSuccessMessage").show();
                      } else {
                          this.window.location.href = validationResult.URLToRedirect;
                      }
                  }
                  IelsV2Lib.UnblockUI();
              }).error(function (data, status, headers, config) {
                  $scope.status = status + ' ' + headers;
              });
          }
      }

        $scope.retrieveEmailAdClear = function () {
            $scope.RetrieveEmail = null;
            $scope.SalutationCode = null;
            $scope.FullName = null;
            $scope.IdentityTypeCode = null;
            $scope.IdentityNo = null;
            $scope.NationalityCode = null;
            $scope.GenderCode = null;

            $scope.TelCountryCode = null;
            $scope.TelAreaCode = null;
            $scope.TelNumber = null;
            $scope.FaxCountryCode = null;
            $scope.FaxAreaCode = null;
            $scope.FaxNumber = null;
            $scope.MobileCountryCode = null;
            $scope.MobileNumber = null;
            $scope.Email = null;

            $scope.Address1 = null;
            $scope.Address2 = null;
            $scope.State = null;
            $scope.City = null;
            $scope.CountryCode = null;
            $scope.PostalCode = null;

            $scope.IdentityTypeCode = $scope.IdentityTypes[0];
            $scope.shouldBeDisabled = false;

            $('#divServerErrorMsg').hide();
        }

        $scope.retrieveEmailAd = function (form) {
            IelsV2Lib.BlockUI();
            $scope.submittedFormTop = true;

            if (form.$invalid) {
                IelsV2Lib.UnblockUI();
                return;
            } else {
                var parameterName = "email";
                var parameters = '{"' + parameterName + '":' + JSON.stringify(JSON.stringify($scope.RetrieveEmail)) + '}';

                $http({
                    method: "POST",
                    url: 'Step1_NewPAC.aspx/RetrievePACDetailsByEmail',
                    data: parameters,
                    headers: { 'Content-Type': 'application/json' }
                }).success(function (data, status, headers, config) {
                    var retValue = '';
                    if (!data || typeof data.d == 'undefined') {
                        if (JSON.parse(data) != '') retValue = JSON.parse(JSON.parse(data));
                    } else {
                        if (data.d != '') retValue = JSON.parse(data.d);
                    }

                    if (retValue != '') {
                        var salutationIndex = IelsV2Lib.GetIndexFromArray($scope.Salutations, retValue.SalutationCode);
                        $scope.SalutationCode = $scope.Salutations[salutationIndex];
                        $scope.FullName = retValue.FullName;
                        var idTypeIndex = IelsV2Lib.GetIndexFromArray($scope.IdentityTypes, retValue.IdentityTypeCode);
                        $scope.IdentityTypeCode = $scope.IdentityTypes[idTypeIndex];
                        $scope.IdentityNo = retValue.IdentityNo;
                        var nationalityIndex = IelsV2Lib.GetIndexFromArray($scope.Nationalities, retValue.NationalityCode);
                        $scope.NationalityCode = $scope.Nationalities[nationalityIndex];
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

                        $scope.Address1 = (retValue.Address1 == null ? " " : retValue.Address1);
                        $scope.Address2 = (retValue.Address2 == null ? " " : retValue.Address2);
                        $scope.State = (retValue.State == null ? " " : retValue.State);
                        $scope.City = (retValue.City == null ? " " : retValue.City);
                        var countryIndex = IelsV2Lib.GetIndexFromArray($scope.Countries, retValue.CountryCode);
                        $scope.CountryCode = $scope.Countries[countryIndex];
                        $scope.PostalCode = (retValue.PostalCode == null ? " " : retValue.PostalCode);

                        $scope.shouldBeDisabled = true;
                    } else {
                        $('#server-error-message').html("E-mail address does not exist in the system.");
                        $('#divServerErrorMsg').show();
                    }

                    IelsV2Lib.UnblockUI();
                }).error(function (data, status, headers, config) {
                    $scope.status = status + ' ' + headers;
                    $('#server-error-message').html("There was an error in retrieving the profile of the E-mail address you entered. Please try again later.");
                    $('#divServerErrorMsg').show();
                    IelsV2Lib.UnblockUI();
                });
            }
        }

        function getParameterByName(name) {
            name = name.replace(/[\[]/, "\\\[").replace(/[\]]/, "\\\]");
            var regex = new RegExp("[\\?&]" + name + "=([^&#]*)"),
            results = regex.exec(location.search);
            return results == null ? "" : decodeURIComponent(results[1].replace(/\+/g, " "));
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
                    ngModelController[0].$setValidity('serverMessage', true);
                });
            });
        }
    }
});