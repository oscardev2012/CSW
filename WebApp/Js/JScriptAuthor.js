var Id = 0;

$(document).ready(function () {

    AjaxBasicRequest(
             "http://localhost:51107/api/Author", "GET",
       function (jData) {

           $("#test").append('<table style="width:50%;"  id="ContendTable" tabindex=109>' +
                                                   '<thead id="background-table-blue">' +
                                                   '<tr><th>Id</th>' +
                                                   '<th>Name</th>' +
                                                                                                         '<th>Action</th>' +
                                                   '<th>Action</th>' +
                                                                                                '</tr></thead>');

           for (var i = 0; i < jData.length; i++) {

               $('#ContendTable').append('<tbody>' + '<tr class="divBankDeposit" style="padding:5px;color:Black;" data-index="' + jData[i].Name + '" data-id="' + jData[i].Id + '">' +


                                 '<td id="content-table-group">' + jData[i].Id + '</td>' +
                                 '<td id="content-table-group">' + jData[i].Name + '</td>' +
                                                                          '<td id="content-table-group"><a href="#"  onClick="editRow(' + (i + 1) + ');">Edit</a></td>' +
                                           '<td id="content-table-group"><a class="test" href="#"  onClick="deleteRow(' + (i + 1) + ');">Delete</a></td>' +
                                                         '</tr></tbody>');

           }

       })


    $(".doTransactionButtom").click(function () {
        if ($("#txtNombre").val().length == 0)
        {
            return;
        }
        if (Id != 0) {
            updateRecord();
        }
        else {
            InsertRecord();
        }
    });

    $("#Ok").click(function () {
        location.reload();
    });

    $("#OkError").click(function () {
        location.reload();
    });
});





function visibleControl() {
    $("#txtNombre").css('display', 'block');
    $("#btnSave").css('display', 'block');
}


function editRow(indexRow) {
    Id = $('#ContendTable').find('tr:eq(' + (indexRow) + ') td:eq(0)').text();
    $("#txtNombre").val($('#ContendTable').find('tr:eq(' + (indexRow) + ') td:eq(1)').text());
    $("#Label").text('Update Record');
    visibleControl();

}

function deleteRow(indexRow) {
    Id = $('#ContendTable').find('tr:eq(' + (indexRow) + ') td:eq(0)').text();
    AjaxBasicRequest(
           "http://localhost:51107/api/Author/?id=" + Id + "", "DELETE",
     function (jData) {
         Message();

     });
}
function updateRecord() {

    AjaxBasicRequest(
             "http://localhost:51107/api/Author/?id=" + Id + "&name=" + $("#txtNombre").val() + "", "POST",
       function (jData) {

           Message();

       });
}


function Message()
{
    $('#Correct').addClass('is-visible');
}
function InsertRecord() {

    AjaxBasicRequest(
           "http://localhost:51107/api/Author/?name=" + $("#txtNombre").val() + "", "POST",
     function (jData) {

         Message();

     });
}






