var Id = 0;
var IdCategory = 0;
var IdAuthor = 0;





$(document).ready(function () {
    $('#Correct').addClass('cd-popup');
    $('#Error').addClass('cd-popup');
    LoadAuthors();
    LoadCategory();
    AjaxBasicRequest(
             "http://localhost:51107/api/Book", "GET",
       function (jData) {

           $("#test").append('<table style="width:50%;"  id="ContendTable" tabindex=109>' +
                                                   '<thead id="background-table-blue">' +
                                                   '<tr><th>Id</th>' +
                                                   '<th>Name</th>' +
                                                      '<th>Author</th>' +
                                                   '<th>Catgory</th>' +
                                                     '<th>Action</th>' +
                                                   '<th>Action</th>' +
                                                                                                '</tr></thead>');

           for (var i = 0; i < jData.length; i++) {

               $('#ContendTable').append('<tbody>' + '<tr class="divBankDeposit" style="padding:5px;color:Black;" data-index="' + jData[i].Name + '" data-id="' + jData[i].Id + '">' +


                                 '<td id="content-table-group">' + jData[i].IdBook + '</td>' +
                                 '<td id="content-table-group">' + jData[i].NameBook + '</td>' +
                                  '<td id="content-table-group">' + jData[i].NameAuthor + '</td>' +
                                   '<td id="content-table-group">' + jData[i].NameCategory + '</td>' +
                                   '<td id="content-table-group" style="display:none;">' + jData[i].IdCategory + '</td>' +
                                    '<td id="content-table-group" style="display:none;">' + jData[i].IdAuthor + '</td>' +
                                        '<td id="content-table-group"><a href="#"  onClick="editRow(' + (i + 1) + ');">Edit</a></td>' +
                                           '<td id="content-table-group"><a class="test" href="#"  onClick="deleteRow(' + (i + 1) + ');">Delete</a></td>' +
                                                         '</tr></tbody>');

           }

       })


    $(".doTransactionButtom").click(function () {
        if ($("#txtNombre").val().length == 0) {
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

function LoadAuthors() {

    AjaxBasicRequest(
            "http://localhost:51107/api/Author", "GET",
      function (jData) {

          FillDropDownValueDefault(jData, "selectAuthor");
      });
}

function LoadCategory() {

    AjaxBasicRequest(
            "http://localhost:51107/api/Category", "GET",
      function (jData) {

          FillDropDownValueDefault(jData, "selectCategory");
      });
}

function visibleControl() {
    $("#txtNombre").css('display', 'block');
    $("#btnSave").css('display', 'block');
}


function editRow(indexRow) {



    IdCategory = $('#ContendTable').find('tr:eq(' + (indexRow) + ') td:eq(4)').text();
    IdAuthor = $('#ContendTable').find('tr:eq(' + (indexRow) + ') td:eq(5)').text();
    Id = $('#ContendTable').find('tr:eq(' + (indexRow) + ') td:eq(0)').text();

    $("#txtNombre").val($('#ContendTable').find('tr:eq(' + (indexRow) + ') td:eq(1)').text());
    $("#selectCategory").val(IdCategory);
    $("#selectAuthor").val(IdAuthor);
    $("#Label").text('Update Record');
    visibleControl();

}

function deleteRow(indexRow) {
    Id = $('#ContendTable').find('tr:eq(' + (indexRow) + ') td:eq(0)').text();
    AjaxBasicRequest(
           "http://localhost:51107/api/Book/?id=" + Id + "", "POST",
     function (jData) {
         Message();

     });
}
function updateRecord() {

    AjaxBasicRequest(
             "http://localhost:51107/api/Book/?id=" + Id + "&name=" + $("#txtNombre").val() + "&authorId=" + IdAuthor + "&categoryId=" + IdCategory + "", "POST",
       function (jData) {

           Message();

       });
}

function Message() {
    $('#Correct').addClass('is-visible');
}

function InsertRecord() {

    IdCategory = $("#selectCategory").val();
    IdAuthor = $("#selectAuthor").val();
    AjaxBasicRequest(
           "http://localhost:51107/api/Book/?name=" + $("#txtNombre").val() + "&authorId=" + IdAuthor + "&categoryId=" + IdCategory + "", "POST",
     function (jData) {

         Message();

     });
}






