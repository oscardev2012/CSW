<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Book.aspx.cs" Inherits="FrontEndASP.Book" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Js/jquery-1.10.2.js" type="text/javascript"></script>
    <script src="../Js/JScriptBook.js" type="text/javascript"></script>
    <script src="../Js/AjaxBase.js" type="text/javascript"></script>

    <link href='../css/foundation.css' rel='stylesheet' type='text/css' />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="test" class="row">
                <div class="large-6 columns">
                </div>
            </div>
            <div class="row">
                <div class="large-3 columns">
                    <input type="text" id="txtNombre" style="display: none;" />
                </div>
                <div class="large-3 columns">
                  
                </div>
                <div class="large-3 columns">
                  
                </div>
                <div class="large-3 columns">
              
                </div>
            </div>
             <div class="row">
                <div class="large-3 columns">
                    <input type="button" id="btnSave" class="button radius transactionButtonForm" value="Commit" style="display: none;" />
                </div>
                <div class="large-3 columns">
                  
                </div>
                <div class="large-3 columns">
                  
                </div>
                <div class="large-3 columns">
              
                </div>
            </div>
        </div>

    </form>
</body>
</html>
