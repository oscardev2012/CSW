function AjaxBasicRequest( strMethod, handleData,Action) {
    
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
            

        }
    });
}