var Id = 0;

$(document).ready(function () {

    LoadAuthors();

    $(".doTransactionButtom").click(function () {
        LoadBooks();
    });

});
function LoadBooks() {

    AjaxBasicRequest(
            "http://localhost:51107/api/Book/?authorId=" + $('#selectAuthor').val() + "", "GET",
      function (jData) {
          $("#test").empty();
          $("#test").append('<table style="width:50%;"  id="ContendTable" tabindex=109>' +
                                                   '<thead id="background-table-blue">' +
                                                   '<tr><th>Id</th>' +
                                                   '<th>Name</th>' +
                                                   '</tr></thead>');

          for (var i = 0; i < jData.length; i++) {

              $('#ContendTable').append('<tbody>' + '<tr class="divBankDeposit" style="padding:5px;color:Black;" data-index="' + jData[i].Name + '" data-id="' + jData[i].Id + '">' +
                                '<td id="content-table-group">' + jData[i].Id + '</td>' +
                                '<td id="content-table-group">' + jData[i].Name + '</td>' +
                                '</tr></tbody>');

          }



      });
}

function LoadAuthors() {

    AjaxBasicRequest(
            "http://localhost:51107/api/Author", "GET",
      function (jData) {

          FillDropDownValueDefault(jData, "selectAuthor");
      });
}






