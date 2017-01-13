var Id=0;
$(document).ready(function () {

    AjaxBasicRequest(
             "http://localhost:51107/api/Book","GET",
       function (jData) {

           $("#test").append('<table style="width:40%;"  id="ContendTable" tabindex=109>' +
                                                   '<thead id="background-table-blue">' +
                                                   '<tr><th>Id</th>' +
                                                   '<th>Name</th>' +
                                                                                                '</tr></thead>');

           for (var i = 0; i < jData.length; i++) {

               $('#ContendTable').append('<tbody>' + '<tr class="divBankDeposit" style="padding:5px;color:Black;" data-index="' + jData[i].Name + '" data-id="' + jData[i].Id + '">' +

                              
                                 '<td id="content-table-group">' + jData[i].Id + '</td>' +
                               
                                 '<td id="content-table-group">' + jData[i].Name + '</td>' +
                                        '<td id="content-table-group"><a href="#"  onClick="editRow();">Edit</a></td>' +
                                           '<td id="content-table-group"><a href="#"  onClick="deleteRow();">Delete</a></td>' +
                                                         '</tr></tbody>');
   
           }

       })
});

function visibleControl() {
    $("#txtNombre").css('display', 'block');
    $("#btnSave").css('display', 'block');
}

function editRow() {
    visibleControl();
    $("#txtNombre").val($(".divBankDeposit").attr("data-index"));
    Id = $(".divBankDeposit").attr("data-id");
}

function deleteRow() {
    debugger
}
function updateRecord() {
    
    AjaxBasicRequest(
             "http://localhost:51107/api/Book/?id=5&name=oscar","PUT",
       function (jData) {

       });
}


$("#bntSave").click(function () {
    if (Id!=0)
    {
        updateRecord();
    }
    else
    {

    }
});
