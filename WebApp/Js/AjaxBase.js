function AjaxBasicRequest(strMethod, Action, handleData) {

    var StrUrl = strMethod;
    $.ajax({
        cache: false,
        type: Action,
        async: true,
        dataType: "json",
        contentType: "application/json",
        url: StrUrl,
        success: function (data) {

            handleData(data);
        },
        error: function (a, b, c) {
            if (a.responseJSON.ExceptionMessage == 'Delete') {
                $('#Error').addClass('is-visible');

            }
       }
    });
}

function FillDropDownValueDefault(jDataResult, dropDownName) {
    $.each(jDataResult, function (i, item) {
        $('#' + dropDownName).append($('<option>', {
            value: item.Id,
            text: item.Name
        }));
    });
}

