angular.module('RFLeFiling', ['customSelect2', 'customSelect2Key', 'serverError']).
  controller('RFLRenewalController', function ($scope, $http, $q, $parse) {
      $scope.init = function () {
          IelsV2Lib.BlockUI();

          $scope.request1 = $http({
              method: 'POST',
              url: 'Step1_RenewRFL.aspx/GetSalutations',
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
              url: 'Step1_RenewRFL.aspx/GetIdentityTypes',
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
              url: 'Step1_RenewRFL.aspx/GetNationalities',
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
              url: 'Step1_RenewRFL.aspx/GetCountries',
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

          function LoadOtherComboBoxes() {
              var arrRFLTypes = [];
              arrRFLTypes.push({ "Code": "U", "Description": "FULL" });
              arrRFLTypes.push({ "Code": "C", "Description": "RESTRICTED" });
              $scope.RFLTypes = arrRFLTypes;

              var startYear = 1950;
              var endYear = new Date().getFullYear();
              var arrYears = [];
              for (var year = endYear; year >= startYear; year--) {
                  arrYears.push({ "Code": year });
              };
              $scope.ConfermentYears = arrYears;
              $scope.AdmissionYears = arrYears;

              var arrPaymentModes = [];
              arrPaymentModes.push({ "Code": "CC", "Description": "Credit Card" });
              arrPaymentModes.push({ "Code": "BT", "Description": "Bank Transfer" });
              $scope.PaymentModes = arrPaymentModes;
          }

          $q.all([$scope.request1, $scope.request2, $scope.request3, $scope.request4]).then(function (values) {
              LoadOtherComboBoxes();

              var sgidParam = null;
              if (getParameterByName('sgid') != '') sgidParam = getParameterByName('sgid');
              var parameterName = "sgid";
              var parameters = '{"' + parameterName + '":' + JSON.stringify(JSON.stringify(sgidParam)) + '}';

              $http({
                  method: 'POST',
                  url: 'Step1_RenewRFL.aspx/GetRFLDetails',
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

                $scope.PracticeInfoItems = [];
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

                    $scope.Address1 = (retValue.Address1 == null ? " " : retValue.Address1);
                    $scope.Address2 = (retValue.Address2 == null ? " " : retValue.Address2);
                    $scope.State = (retValue.State == null ? " " : retValue.State);
                    $scope.City = (retValue.City == null ? " " : retValue.City);
                    var countryIndex = IelsV2Lib.GetIndexFromArray($scope.Countries, retValue.CountryCode);
                    $scope.CountryCode = $scope.Countries[countryIndex];
                    $scope.PostalCode = (retValue.PostalCode == null ? " " : retValue.PostalCode);
                }

                if (retValue.IssuingCountryCode != null) {
                    var issuingCountryIndex = IelsV2Lib.GetIndexFromArray($scope.IssuingCountries, retValue.IssuingCountryCode);
                    $scope.IssuingCountryCode = $scope.IssuingCountries[issuingCountryIndex];
                }
                $scope.Qualification = retValue.Qualification;
                $scope.University = retValue.University;
                if (retValue.YearOfAdmissionCode != null) {
                    var admissionYearIndex = IelsV2Lib.GetIndexFromArray($scope.AdmissionYears, retValue.YearOfAdmissionCode);
                    $scope.YearOfAdmissionCode = $scope.ConfermentYears[admissionYearIndex];
                }
                if (retValue.YearOfConfermentCode != null) {
                    var confermentYearIndex = IelsV2Lib.GetIndexFromArray($scope.ConfermentYears, retValue.YearOfConfermentCode);
                    $scope.YearOfConfermentCode = $scope.ConfermentYears[confermentYearIndex];
                }
                if (retValue.RFLPracticeInfoList != null) $scope.PracticeInfoItems = retValue.RFLPracticeInfoList;
                if (retValue.RFLTypeCode != null) {
                    var rflTypeIndex = IelsV2Lib.GetIndexFromArray($scope.RFLTypes, retValue.RFLTypeCode);
                    $scope.RFLTypeCode = $scope.RFLTypes[rflTypeIndex];
                    $scope.OrderNo = retValue.OrderNo;
                    $scope.CaseNo = retValue.CaseNo;
                }

                if (retValue.PaymentModeCode != null) {
                    var paymentTypeIndex = IelsV2Lib.GetIndexFromArray($scope.PaymentModes, retValue.PaymentModeCode);
                    $scope.PaymentModeCode = $scope.PaymentModes[paymentTypeIndex];
                }
                //console.log("FileRefNo: " + retValue.FileRefNo);
                $scope.FileRefNo = retValue.FileRefNo;

                console.log("CurrentUserRoleCode: " + retValue.CurrentUserRoleCode);
                if (retValue.CurrentUserRoleCode == '0') $scope.shouldBeDisabled = true;

                IelsV2Lib.UnblockUI();
            }).
            error(function (data, status) {
                //console.log("Error loading RFLDetails.");
            });
          });
      }

      // Add an item to the PracticeInfo list
      $scope.AddPracticeInfo = function () {
          if (($scope.IssuingJurisdiction != undefined && $scope.IssuingJurisdiction.Code != "") &&
                ($scope.YearOfAdmission != undefined && $scope.YearOfAdmission.Code != "")) {
              $scope.PracticeInfoItems.push({
                  IssuingJurisdiction: $scope.IssuingJurisdiction.Description,
                  IssuingJurisdictionCode: $scope.IssuingJurisdiction.Code,
                  YearOfAdmission: $scope.YearOfAdmission.Code,
                  YearOfAdmissionCode: $scope.YearOfAdmission.Code,
                  Remarks: $scope.Remarks,
                  InformationType: 'P'
              });

              //update the correct Sequence No.
              for (var i = 0; i < $scope.getTotalItems(); i++) {
                  $scope.PracticeInfoItems[i].SequenceNo = i + 1;
              }

              // Clear input fields after push
              $scope.IssuingJurisdiction = "-- Select Country --";
              $scope.YearOfAdmission = "-- Select Year --";
              $scope.Remarks = "";
          }
      };

      // Delete item from PracticeInfo list
      $scope.DeletePracticeInfo = function (index) {
          $scope.PracticeInfoItems.splice(index, 1);

          //update the correct Sequence No.
          for (var i = 0; i < $scope.getTotalItems(); i++) {
              $scope.PracticeInfoItems[i].SequenceNo = i + 1;
          }
      };

      // Get PracticeInfo
      $scope.getTotalItems = function () {
          return $scope.PracticeInfoItems.length;
      };

      $scope.submit = function (form, methodName) {
          IelsV2Lib.BlockUI();
          $scope.submitted = true;

          if (form.$invalid) {
              IelsV2Lib.UnblockUI();
              return;
          } else {
              if ($scope.PracticeInfoItems.length < 1) {
                  $('#server-error-message').html("Practice information is required to have at least one entry.");
                  $('#divServerErrorMsg').show();
                  $(window).scrollTop(0);
                  IelsV2Lib.UnblockUI();
              } else {
                  var entity = IelsV2Lib.CreateEntity($scope);
                  var parameterName = "rflDetails";
                  var parameters = '{"' + parameterName + '":' + JSON.stringify(JSON.stringify(entity)) + '}';

                  $http({
                      method: "POST",
                      url: 'Step1_RenewRFL.aspx/' + methodName,
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
                          $(window).scrollTop(0);
                          IelsV2Lib.UnblockUI();
                      }
                      else {
                          if (methodName == "Save_Step1_RenewRFL") {
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