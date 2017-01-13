<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="FrontEndASP.Category" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Js/jquery-1.10.2.js" type="text/javascript"></script>
    <script src="../Js/JScriptCategory.js" type="text/javascript"></script>
    <script src="../Js/AjaxBase.js" type="text/javascript"></script>
    <link href='../css/foundation.css' rel='stylesheet' type='text/css' />
    <link href='../css/reset.css' rel='stylesheet' type='text/css' />
    <link href='../css/style.css' rel='stylesheet' type='text/css' />

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <div id="test" class="row RightControl">
                <div class="large-6 columns">
                </div>
            </div>
            <br />
            <br />
            <div class="row RightControl">
                <div class="large-6 columns">
                    <input type="text" id="txtNombre" style="display: block;" />
                </div>
            </div>
        </div>
        <div class="row CenterControl">
            <div class="large-6 columns">
                <a class="button radius doTransactionButtom" tabindex="200">
                    <asp:Label runat="server" ID="Label" ClientIDMode="Static" Text="Add Record" />
                </a>
            </div>
        </div>
        <div class="row CenterControl">
            <div class="large-6 columns">
                <a href="Home.aspx" class="button radius doTransactionButtomm" tabindex="200">
                    <asp:Label runat="server" ID="Label1" ClientIDMode="Static" Text=" Go To Home  " />
                </a>
            </div>
        </div>


        <div id="Correct" class="cd-popup" role="alert">
            <div class="cd-popup-container">
                <p>Data saved Successfully</p>
                <ul class="cd-buttons">
                    <li><a href="#0" id="Ok">Yes</a></li>

                </ul>
                <a href="#0" class="cd-popup-close img-replace">Close</a>
            </div>
            <!-- cd-popup-container -->
        </div>

        <div id="Error" class="cd-popup" role="alert">
            <div class="cd-popup-container">
                <p>
                    Can not delete
                </p>
                <ul class="cd-buttons">
                    <li><a href="#0" id="OkError">Yes</a></li>

                </ul>
                <a href="#0" class="cd-popup-close img-replace">Close</a>
            </div>
            <!-- cd-popup-container -->
        </div>
    </form>
</body>
</html>
