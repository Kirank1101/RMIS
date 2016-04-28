angular.module('SICCCaseView', []).
controller('CaseViewController', function ($scope, $http, $q, $parse) {
    $scope.init = function () {
        IelsV2Lib.BlockUI();

        var idParam = null;
        if (getParameterByName('id') != '') idParam = getParameterByName('id');
        var parameterName = "id";
        var parameters = '{"' + parameterName + '":' + JSON.stringify(idParam) + '}';

        $scope.request1 = $http({
            method: 'POST',
            url: 'CaseView.aspx/GetCaseInformation',
            data: parameters,
            headers: { 'Content-Type': 'application/json; charset=utf-8' },
            dataType: 'json'
        }).success(function (data, status, headers, config) {
            var retValue = '';
            if (!data || typeof data.d == 'undefined') {
                if (JSON.parse(data) != '') retValue = JSON.parse(JSON.parse(data));
            } else {
                if (data.d != '') retValue = JSON.parse(data.d);
            }

            if (retValue != '') {
                $scope.CaseType = retValue.SectionCaseInfo.CaseType;
                //console.log('$scope.CaseType: ' + $scope.CaseType);
                $scope.CaseName = retValue.SectionCaseInfo.CaseName;
                $scope.CaseNo = retValue.SectionCaseInfo.CaseNo;
                $scope.CaseStatus = retValue.SectionCaseInfo.CaseStatus;
                $scope.CaseFileRefNo = typeof retValue.SectionCaseInfo.FileRefNo == 'undefined' || retValue.SectionCaseInfo.FileRefNo == '' ? 'N/A' : retValue.SectionCaseInfo.FileRefNo;

                $scope.CaseDateFiled = retValue.SectionCaseInfo.CaseDateFiled;
                $scope.CaseForumName = retValue.SectionCaseInfo.ForumName;

                $scope.SectionSubCaseInfo = retValue.SectionSubCaseInfo;

                $scope.SectionCaseRelationships = retValue.SectionCaseRelationships;

                if (retValue.SectionCaseInfo.CaseType == 'RFL') $scope.SectionMoreInfoRFL = retValue.SectionMoreInfoRFL;
                if (retValue.SectionCaseInfo.CaseType == 'S' || retValue.SectionCaseInfo.CaseType == 'OS'
                    || retValue.SectionCaseInfo.CaseType == 'SICCS' || retValue.SectionCaseInfo.CaseType == 'SICCOS'
                    || retValue.SectionCaseInfo.CaseType == 'SICCST' || retValue.SectionCaseInfo.CaseType == 'SICCOST')
                    $scope.SectionMoreInfoCivilCases = retValue.SectionMoreInfoCivilCases;

                $scope.PaymentMode = retValue.SectionCaseInfo.PaymentMode;
            }
        }).error(function (data, status) {
            //console.log("Error loading GetCaseInformation.");
        });


        $scope.request2 = $http({
            method: 'POST',
            url: 'CaseView.aspx/GetCaseParties',
            data: parameters,
            headers: { 'Content-Type': 'application/json; charset=utf-8' },
            dataType: 'json'
        }).success(function (data, status, headers, config) {
            var retValue = '';
            if (!data || typeof data.d == 'undefined') {
                if (JSON.parse(data) != '') retValue = JSON.parse(JSON.parse(data));
            } else {
                if (data.d != '') retValue = JSON.parse(data.d);
            }

            if (retValue != '') {
                $scope.PartyList = retValue;
            }
        }).error(function (data, status) {
            //console.log("Error loading GetCaseParties.");
        });


        var docParameters = '{"id":' + JSON.stringify(idParam) + ', "filterType" : null}';
        $scope.request3 = $http({
            method: 'POST',
            url: 'CaseView.aspx/GetDocumentListInformation',
            data: docParameters,
            headers: { 'Content-Type': 'application/json; charset=utf-8' },
            dataType: 'json'
        }).success(function (data, status, headers, config) {
            var retValue = '';
            if (!data || typeof data.d == 'undefined') {
                if (JSON.parse(data) != '') retValue = JSON.parse(JSON.parse(data));
            } else {
                if (data.d != '') retValue = JSON.parse(data.d);
            }

            if (retValue != '') {
                $scope.DocumentList = retValue;
            }
        }).error(function (data, status) {
            //console.log("Error loading GetDocumentListInformation.");
        });


        var docParameters = '{"id":' + JSON.stringify(idParam) + ', "filterType" : null}';
        $scope.request4 = $http({
            method: 'POST',
            url: 'CaseView.aspx/GetDocumentTreeInformation',
            data: docParameters,
            headers: { 'Content-Type': 'application/json; charset=utf-8' },
            dataType: 'json'
        }).success(function (data, status, headers, config) {
            var retValue = '';
            if (!data || typeof data.d == 'undefined') {
                if (JSON.parse(data) != '') retValue = JSON.parse(JSON.parse(data));
            } else {
                if (data.d != '') retValue = JSON.parse(data.d);
            }

            if (retValue != '') {
                $scope.DocumentTreeView = retValue;
            }
        }).error(function (data, status) {
            //console.log("Error loading GetDocumentTreeInformation.");
        });


        $scope.request5 = $http({
            method: 'POST',
            url: 'CaseView.aspx/GetCaseHearing',
            data: parameters,
            headers: { 'Content-Type': 'application/json; charset=utf-8' },
            dataType: 'json'
        }).success(function (data, status, headers, config) {
            var retValue = '';
            if (!data || typeof data.d == 'undefined') {
                if (JSON.parse(data) != '') retValue = JSON.parse(JSON.parse(data));
            } else {
                if (data.d != '') retValue = JSON.parse(data.d);
            }

            if (retValue != '') {
                $scope.HearingList = retValue;
            }
        }).error(function (data, status) {
            //console.log("Error loading GetCaseHearing.");
        });

        $q.all([$scope.request1, $scope.request2, $scope.request3, $scope.request4, $scope.request5]).then(function (values) {
            //once case info, case party, documents and hearing tabs are loaded, we unblock the UI...
            IelsV2Lib.UnblockUI();

            //we now load the bill details and notification tab...
            $scope.requestBill1 = $http({
                method: 'POST',
                url: 'CaseView.aspx/GetBillingFilingFee',
                data: parameters,
                headers: { 'Content-Type': 'application/json; charset=utf-8' },
                dataType: 'json'
            }).success(function (data, status, headers, config) {
                var retValue = '';
                if (!data || typeof data.d == 'undefined') {
                    if (JSON.parse(data) != '') retValue = JSON.parse(JSON.parse(data));
                } else {
                    if (data.d != '') retValue = JSON.parse(data.d);
                }

                if (retValue != '') {
                    $scope.BillingFilingFee = retValue;
                }
            }).error(function (data, status) {
                //console.log("Error loading GetBillingFilingFee.");
            });

            $scope.requestBill2 = $http({
                method: 'POST',
                url: 'CaseView.aspx/GetBillingRefundFee',
                data: parameters,
                headers: { 'Content-Type': 'application/json; charset=utf-8' },
                dataType: 'json'
            }).success(function (data, status, headers, config) {
                var retValue = '';
                if (!data || typeof data.d == 'undefined') {
                    if (JSON.parse(data) != '') retValue = JSON.parse(JSON.parse(data));
                } else {
                    if (data.d != '') retValue = JSON.parse(data.d);
                }

                if (retValue != '') {
                    $scope.BillingRefundFee = retValue;
                }
            }).error(function (data, status) {
                //console.log("Error loading GetBillingRefundFee.");
            });

            $scope.requestBill3 = $http({
                method: 'POST',
                url: 'CaseView.aspx/GetBillingEServiceFee',
                data: parameters,
                headers: { 'Content-Type': 'application/json; charset=utf-8' },
                dataType: 'json'
            }).success(function (data, status, headers, config) {
                var retValue = '';
                if (!data || typeof data.d == 'undefined') {
                    if (JSON.parse(data) != '') retValue = JSON.parse(JSON.parse(data));
                } else {
                    if (data.d != '') retValue = JSON.parse(data.d);
                }

                if (retValue != '') {
                    $scope.BillingEServiceFee = retValue;
                }
            }).error(function (data, status) {
                //console.log("Error loading GetBillingEServiceFee.");
            });

            $q.all([$scope.requestBill1, $scope.requestBill2, $scope.requestBill3]).then(function (values) {
                var filingFee = $scope.BillingFilingFee.TotalAmount ? $scope.BillingFilingFee.TotalAmount : '0.00';
                var refundFee = $scope.BillingRefundFee.TotalAmount ? $scope.BillingRefundFee.TotalAmount : '0.00';
                var eServiceFee = $scope.BillingEServiceFee.TotalAmount ? $scope.BillingEServiceFee.TotalAmount : '0.00';

                filingFee = filingFee.replace("S$NaN", "").replace("S$", "").replace(",", "");
                refundFee = refundFee.replace("S$NaN", "").replace("S$", "").replace(",", "");
                eServiceFee = eServiceFee.replace("S$NaN", "").replace("S$", "").replace(",", "");
                //console.log("filingFee: " + filingFee);
                //console.log("refundFee: " + refundFee);
                //console.log("eServiceFee: " + eServiceFee);

                var overAllTotal = ((+filingFee) + (+refundFee) + (+eServiceFee))
                var overAllTotalStr = "S$" + (overAllTotal).formatMoney(2, '.', ',');
                $scope.TotalFilingFees = overAllTotalStr;
                //console.log("overAllTotal: " + overAllTotal);
                //console.log("overAllTotalStr: " + overAllTotalStr);
            });

            if ($scope.CaseType === 'S' || $scope.CaseType === 'OS' || $scope.CaseType === 'SICCS' || $scope.CaseType === 'SICCOS'
                || $scope.CaseType === 'SICCST' || $scope.CaseType === 'SICCOST' || $scope.CaseType === 'RFL') {

//                if ($scope.CaseType != 'SICCST' && $scope.CaseType != 'SICCOST') {
//                    console.log("caseType: " + $scope.CaseType + " :: I am now collapsing!!!");
//                    $('#collapseElitDocs').switchClass('collapse', 'expand');   //set to collapse
//                    $('#collapseElitDocsBody').css('display', 'none');
//                } else {
//                    console.log("caseType: " + $scope.CaseType + " :: I am now expanding!!!");
//                }

                $("#divSICCFeeCover").show();

                $http({
                    method: 'POST',
                    url: 'CaseView.aspx/GetSICCSpecificLedgerFees',
                    data: parameters,
                    headers: { 'Content-Type': 'application/json; charset=utf-8' },
                    dataType: 'json'
                }).success(function (data, status, headers, config) {
                    var retValue = '';
                    if (!data || typeof data.d == 'undefined') {
                        if (JSON.parse(data) != '') retValue = JSON.parse(JSON.parse(data));
                    } else {
                        if (data.d != '') retValue = JSON.parse(data.d);
                    }

                    if (retValue != '') {
                        $scope.SICCSpecificLedgerFees = retValue;

                        if (retValue != null && retValue.FeeItems != null || retValue.FeeItems.length != 0) {
                            var items = retValue.FeeItems;
                            var allApprovedDeposit = 0;
                            var allApprovedDeduction = 0;
                            var allPendingDeposit = 0;
                            var allPendingDeduction = 0;

                            $.each(items, function (index, entity) {
                                if (entity.Status == "Approved") {
                                    allApprovedDeduction += (+entity.Deduction);
                                    allApprovedDeposit += (+entity.Deposit);
                                } else if (entity.Status == "Pending") {
                                    allPendingDeduction += (+entity.Deduction);
                                    allPendingDeposit += (+entity.Deposit);
                                }
                            });

                            var accountBal = allApprovedDeposit - allApprovedDeduction;
                            var availableBal = (allApprovedDeposit + allPendingDeposit) - (allApprovedDeduction + allPendingDeduction);

                            $scope.SICCLedgerAccountBalance = "S$" + (accountBal).formatMoney(2, '.', ',')
                            $scope.SICCLedgerAvailableBalance = "S$" + (availableBal).formatMoney(2, '.', ',')
                        }
                    }
                }).error(function (data, status) {
                    //console.log("Error loading GetSICCSpecificLedgerFees.");
                });
            } else {
                $("#divSICCFeeCover").hide();
            }

            $scope.GetNotifications('I');
        });
    }

    $scope.ShowSICCFeeViewDocsPopup = function (id, header) {
        var url = "SICCFeeViewDocs.aspx";
        $("#txtFeeLedgerId").val(id);
        $("#txtFeeLedgerHeader").val(header);

        $('#myModal')
            .removeData('modal')
            .modal({
                remote: url,
                show: true
            });
    }

    $scope.ShowCasePartyPopup = function (CaseInfoId, CasePartyId) {
        var caseNumber = $("#lblCaseNo").html();
        var url = "ViewPartyInfo.aspx";
        //console.log(url);
        $("#txtCaseInfoId").val(CaseInfoId);
        $("#txtCasePartyId").val(CasePartyId);
        $("#txtCaseNumber").val(caseNumber);

        $('#myModal')
            .removeData('modal')
            .modal({
                remote: url,
                show: true
            });
    }

    $scope.LoadFormDocumentView = function (Docid, ExpungeInd) {
        if (ExpungeInd == "Y") {
            alert("This document can't be viewed as it is expunged.")
            return false;
        }
        else {
            var hostURL = window.location.protocol + "//" + window.location.host;
            window.open(hostURL + '/_layouts/iELS/DMS/OpenDocument.aspx?docid=' + Docid + '&docstatus=R');
        }
    }

    $scope.ShowDocumentDetails = function (DocID, DocCode, CaseInfoId) {
        IelsV2Lib.BlockUI();
        var url = "ViewDocumentInfo.aspx";
        //console.log(url);
        $("#txtDocID").val(DocID);
        $("#txtDocCode").val(DocCode);
        $("#txtCaseInfoId").val(CaseInfoId);
        $('#myModal')
                  .removeData('modal')
                  .modal({
                      remote: url,
                      show: true
                  });
        IelsV2Lib.UnblockUI();
    }

    $scope.FilterAll = function () {
        $(this).parent().children('ul.tree').toggle(300);
        $(this).toggleClass('tree-toggler-active');

        var idParam = parseInt(getParameterByName('id'));
        var docParameters = '{"id":' + JSON.stringify(idParam) + ', "filterType" : null}';
        $scope.request3 = $http({
            method: 'POST',
            url: 'CaseView.aspx/GetDocumentListInformation',
            data: docParameters,
            headers: { 'Content-Type': 'application/json; charset=utf-8' },
            dataType: 'json'
        }).success(function (data, status, headers, config) {
            var retValue = '';
            if (!data || typeof data.d == 'undefined') {
                if (JSON.parse(data) != '') retValue = JSON.parse(JSON.parse(data));
            } else {
                if (data.d != '') retValue = JSON.parse(data.d);
            }

            if (retValue != '') {
                $scope.DocumentList = retValue;
            }
        }).error(function (data, status) {
            //console.log("Error loading FilterAll.");
        });
    }

    $scope.FilterDocType = function (caseNo, docType) {
        var idParam = parseInt(getParameterByName('id'));
        var filterParams = 'CN=' + caseNo + "|DT=" + docType;

        var docParameters = '{"id":' + JSON.stringify(idParam) + ', "filterType":' + JSON.stringify(filterParams) + '}';
        $http({
            method: 'POST',
            url: 'CaseView.aspx/GetDocumentListInformation',
            data: docParameters,
            headers: { 'Content-Type': 'application/json; charset=utf-8' },
            dataType: 'json'
        }).success(function (data, status, headers, config) {
            var retValue = '';
            if (!data || typeof data.d == 'undefined') {
                if (JSON.parse(data) != '') retValue = JSON.parse(JSON.parse(data));
            } else {
                if (data.d != '') retValue = JSON.parse(data.d);
            }

            if (retValue != '') {
                $scope.DocumentList = retValue;
            }
        }).error(function (data, status) {
            //console.log("Error loading FilterDocType.");
        });
    }

    $scope.FilterSubcase = function (caseNo, subcaseNo) {
        var idParam = parseInt(getParameterByName('id'));
        var filterParams = 'CN=' + caseNo + "|SCN=" + subcaseNo;

        var docParameters = '{"id":' + JSON.stringify(idParam) + ', "filterType":' + JSON.stringify(filterParams) + '}';
        $http({
            method: 'POST',
            url: 'CaseView.aspx/GetDocumentListInformation',
            data: docParameters,
            headers: { 'Content-Type': 'application/json; charset=utf-8' },
            dataType: 'json'
        }).success(function (data, status, headers, config) {
            var retValue = '';
            if (!data || typeof data.d == 'undefined') {
                if (JSON.parse(data) != '') retValue = JSON.parse(JSON.parse(data));
            } else {
                if (data.d != '') retValue = JSON.parse(data.d);
            }

            if (retValue != '') {
                $scope.DocumentList = retValue;
            }
        }).error(function (data, status) {
            //console.log("Error loading FilterSubcase.");
        });
    }

    $scope.LoadFormDocumentViewFromNotification = function (Docid) {
        var hostURL = window.location.protocol + "//" + window.location.host;
        window.open(hostURL + '/_layouts/iELS/DMS/OpenDocument.aspx?docid=' + Docid + '&docstatus=R');
    }

    $scope.GetNotifications = function (type) {
        $scope.Notifications = '';
        if (getParameterByName('id') != '') idParam = getParameterByName('id');

        var notificationParameters = '{"id":' + JSON.stringify(idParam) + ', "type" : ' + JSON.stringify(type) + '}';
        $http({
            method: 'POST',
            url: 'CaseView.aspx/GetNotificationInbox',
            data: notificationParameters,
            headers: { 'Content-Type': 'application/json; charset=utf-8' },
            dataType: 'json'
        }).success(function (data, status, headers, config) {
            var retValue = '';
            if (!data || typeof data.d == 'undefined') {
                if (JSON.parse(data) != '') retValue = JSON.parse(JSON.parse(data));
            } else {
                if (data.d != '') retValue = JSON.parse(data.d);
            }

            if (retValue != '') {
                $scope.Notifications = retValue;
            }
        }).error(function (data, status) {
            //console.log("Error loading GetNotificationInbox.");
        });
    }

    function getParameterByName(name) {
        name = name.replace(/[\[]/, "\\\[").replace(/[\]]/, "\\\]");
        var regex = new RegExp("[\\?&]" + name + "=([^&#]*)"),
        results = regex.exec(location.search);
        return results == null ? "" : decodeURIComponent(results[1].replace(/\+/g, " "));
    }

    Number.prototype.formatMoney = function (c, d, t) {
        var n = this,
                    c = isNaN(c = Math.abs(c)) ? 2 : c,
                    d = d == undefined ? "." : d,
                    t = t == undefined ? "," : t,
                    s = n < 0 ? "-" : "",
                    i = parseInt(n = Math.abs(+n || 0).toFixed(c)) + "",
                    j = (j = i.length) > 3 ? j % 3 : 0;
        return s + (j ? i.substr(0, j) + t : "") + i.substr(j).replace(/(\d{3})(?=\d)/g, "$1" + t) + (c ? d + Math.abs(n - i).toFixed(c).slice(2) : "");
    };
});