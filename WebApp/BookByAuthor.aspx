<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookByAuthor.aspx.cs" Inherits="FrontEndASP.BookByAuthor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Js/jquery-1.10.2.js" type="text/javascript"></script>
    <script src="../Js/JScriptBookByAuthor.js" type="text/javascript"></script>
    <script src="../Js/AjaxBase.js" type="text/javascript"></script>
    <link href='../css/foundation.css' rel='stylesheet' type='text/css' />
    <link href='../css/reset.css' rel='stylesheet' type='text/css' />
    <link href='../css/style.css' rel='stylesheet' type='text/css' />

</head>
<body>
    <form id="formBookByAuthor" runat="server">
        <div>
            <br />
            <br />
            <br />
            <div class="row RightControl">
                <div class="large-4 columns">
                    <select class="styled-select height_Dropdown" id="selectAuthor" tabindex="11">
                    </select>
                </div>
                <div class="large-3 columns">
                    <a class="button radius doTransactionButtom" tabindex="200">
                        <asp:Label runat="server" ID="Label" ClientIDMode="Static" Text="Find" />
                    </a>
                </div>
                <div class="large-6 columns">
                </div>
            </div>

            <div id="test" class="row RightControl">
                <div class="large-6 columns">
                </div>
            </div>
            <br />
            <div class="row CenterControl">
                <div class="large-6 columns">
                    <a href="Home.aspx" class="button radius doTransactionButtomm" tabindex="200">
                        <asp:Label runat="server" ID="Label1" ClientIDMode="Static" Text=" Go To Home  " />
                    </a>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
