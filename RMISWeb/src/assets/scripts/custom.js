$(document).ready(function () {
    $('label.tree-toggler').click(function () {
        $(this).parent().children('ul.tree').toggle(300);
        $(this).toggleClass('tree-toggler-active');

        //$('id').load('/case.aspx?caseinfoid=123');
    });
});


//to be transferred to common lib...
function ApplyPaging(currentPage, lastPage, divToApply, startRow, endRow, itemsperpage, totalCount, functionName) {
    if (lastPage == 1) return;

    var pagingHtml = '<span class="paging-navigation-status" style="margin-top:2.5px">Showing ' + startRow + ' - ' + (endRow > totalCount ? totalCount : endRow)
		                    + ' of ' + totalCount + '</span>';

    pagingHtml += '<span class="paging-navigation">&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;Items per page:&nbsp;' +
		                '<select id="itemsPerPage" onchange="LoadItemsPerPage(this,\'' + functionName + '\')" binding-path="NumRecordsToShow">' +
		                    '<option ' + (itemsperpage == "25" ? 'selected="selected"' : '') + ' value="25">25</option>' +
						    '<option ' + (itemsperpage == "50" ? 'selected="selected"' : '') + ' value="50">50</option>' +
						    '<option ' + (itemsperpage == "100" ? 'selected="selected"' : '') + ' value="100">100</option>' +
                        '</select></span>';

    pagingHtml += '<span class="paging-navigation">&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;Go to page:' +
		                '<input onkeydown="NumericThis(this,' + lastPage + ',\'' + functionName + '\')" onkeyup="NumericThis(this)" id="pageNum" class="paging-goto-page" binding-path="CurrentPage" value="' + currentPage + '"/>' +
		                '<input onclick="GoToPageInput(this,' + lastPage + ',\'' + functionName + '\')" type="button" value="Go"/></span>';

    pagingHtml += '<span class="paging-navigation" style="margin-top:2.5px"><a ' + (currentPage > 1 ? 'onclick="GoToPageNumber(' + (currentPage - 1) + ',\'' + functionName + '\')"' : '') +
                		' class="' + (currentPage == 1 ? 'paging-inactive-link' : 'paging-active-link') + '">Previous</a>';

    for (i = 1; i <= lastPage; i++) {
        if (lastPage < 7) {
            if (currentPage == i) {
                pagingHtml += '<a class="paging-inactive-link">' + i + '</a>';
                //                        var anchor = $('<a/>');
                //                        anchor.click(function () {
                //                            GoToPageNumber(i, functionName);
                //                        });
            }
            else
                pagingHtml += '<a onclick="GoToPageNumber(' + i + ',\'' + functionName + '\')" class="paging-active-link">' + i + '</a>';
        } else if (i == 1 || i == lastPage) {
            if (currentPage == i)
                pagingHtml += '<a class="paging-inactive-link">' + i + '</a>';
            else
                pagingHtml += '<a onclick="GoToPageNumber(' + i + ',\'' + functionName + '\')" class="paging-active-link">' + i + '</a>';
        } else if (currentPage < 6 && i < 6 && i != 1) {
            if (currentPage == i)
                pagingHtml += '<a class="paging-inactive-link">' + i + '</a>';
            else
                pagingHtml += '<a onclick="GoToPageNumber(' + i + ',\'' + functionName + '\')" class="paging-active-link">' + i + '</a>';
            if (i == 5 && lastPage > 5)
                pagingHtml += '<a class="paging-inactive-link">...</a>';
        } else if (currentPage > 5 && currentPage < (lastPage - 4) && (i >= (currentPage - 2) && i <= (currentPage + 2))) {
            if (i == (currentPage - 2))
                pagingHtml += '<a class="paging-inactive-link">...</a>';
            if (currentPage == i)
                pagingHtml += '<a class="paging-inactive-link">' + i + '</a>';
            else
                pagingHtml += '<a onclick="GoToPageNumber(' + i + ',\'' + functionName + '\')" class="paging-active-link">' + i + '</a>';
            if (i == (currentPage + 2))
                pagingHtml += '<a class="paging-inactive-link">...</a>';
        } else if (currentPage >= (lastPage - 4) && i >= (lastPage - 4) && i < lastPage) {
            if (i == (lastPage - 4))
                pagingHtml += '<a class="paging-inactive-link">...</a>';
            if (currentPage == i)
                pagingHtml += '<a class="paging-inactive-link">' + i + '</a>';
            else
                pagingHtml += '<a onclick="GoToPageNumber(' + i + ',\'' + functionName + '\')" class="paging-active-link">' + i + '</a>';
        }
    }

    pagingHtml += '<a ' + (currentPage < lastPage ? 'onclick="GoToPageNumber(' + (currentPage + 1) + ',\'' + functionName + '\')"' : '') +
		                  ' class="' + (currentPage == lastPage ? 'paging-inactive-link' : 'paging-active-link') + '">Next</a></span>';

    divToApply.html(pagingHtml);
}

function SearchNavigate(page) {
    if (page > lastPage || page < 1) return;
    currentPage = page;
    $("#pageNum").val(currentPage);
    SiccLib.ExecuteAjaxPostMethod($('#btnAdvancedSearch'));
    window.scrollTo(0, 290);
}

function LoadItemsPerPage(element, functionName) {
    var value = $(element).val();
    var functionToExecute = functionName + '(' + value + ')';

    currentPage = 1;
    $("#pageNum").val(currentPage);
    itemsToShow = value;

    SiccLib.ExecuteAjaxPostMethod($('#btnAdvancedSearch'));
    window.scrollTo(0, 290);
}

function GoToPageNumber(page, functionName) {
    var functionToExecute = functionName + '(' + page + ')';
    eval(functionToExecute);
}

function GoToPageInput(element, lastPage, functionName) {
    var value = $(element).prev().val();
    if (value > lastPage) {
        $(element).prev().val(lastPage);
        value = lastPage;
    }
    else if (value < 1) {
        $(element).prev().val(1);
        value = 1;
    }
    var functionToExecute = functionName + '(' + value + ')';
    eval(functionToExecute);
}

function NumericThis(element, lastPage, functionName) {
    var max_chars = 2;

    var theEvent = element.event || window.event;
    var key = theEvent.keyCode || theEvent.which;
    if (event.keyCode == 46 || event.keyCode == 8 || event.keyCode == 9 || event.keyCode == 27 ||
    // Allow: Ctrl+A
            (event.keyCode == 65 && event.ctrlKey === true) ||
    // Allow: home, end, left, right
            (event.keyCode >= 35 && event.keyCode <= 39)) {
        // let it happen, don't do anything
        return;
    }
    if (key == 13) {
        if (element.value > lastPage)
            element.value = lastPage;
        else if (element.value < 1)
            element.value = 1;
        var functionToExecute = functionName + '(' + element.value + ')';
        eval(functionToExecute);
        return;
    }

    if ((!isNumber(theEvent)) || (isNumber(theEvent) && element.value.length + 1 > max_chars)) {
        theEvent.returnValue = false;
        if (theEvent.preventDefault)
            theEvent.preventDefault();
    }
}

function isNumber(event) {
    return !(event.shiftKey || (event.keyCode < 48 || event.keyCode > 57) && (event.keyCode < 96 || event.keyCode > 105))
}
//END.. Pagination - related functions...

function ShowErrorPage(error) {
    //alert(error);
    window.location.href = "Error.aspx";
}

jQuery('body').on('click', '.portlet > .portlet-title > .tools > .collapse, .portlet .portlet-title > .tools > .expand', function (e) {
    e.preventDefault();
    var el = jQuery(this).closest(".portlet").children(".portlet-body");
    if (jQuery(this).hasClass("collapse")) {
        jQuery(this).removeClass("collapse").addClass("expand");
        el.slideUp(200);
    } else {
        jQuery(this).removeClass("expand").addClass("collapse");
        el.slideDown(200);
    }
});