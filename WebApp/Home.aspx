<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FrontEndASP.BookByAuthor" %>

<!DOCTYPE html>

<html class=" js no-touch" lang="en">
<head>
    <meta http-equiv="content-type" content="text/html; charset=UTF-8">
    <meta charset="utf-8">
    <title>By Oscar Sierra</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="Your page description here">
    <meta name="author" content="">
    <!-- css -->
    <link href='../css/menu.css' rel='stylesheet' type='text/css' />
</head>
<body>
    <div style="background: #999; font-size: 22px; text-align: center; line-height: 160px; color: #FFF; font-weight: bold;">
        Programming Task By Oscar Sierra
    </div>
    <!-- start header -->
    <header>
        <div class="container">
            <div class="navbar navbar-static-top">
                <div class="navigation">
                    <nav>
                        <ul class="nav topnav bold">
                            <li class="dropdown active">
                                <a href="Book.aspx">Maintenance Book <i class="icon-angle-down"></i></a>
                                <ul class="dropdown-menu bold">
                                </ul>
                            </li>
                            <li class="dropdown active">
                                <a href="Author.aspx">Maintenance Author <i class="icon-angle-down"></i></a>
                                <ul style="display: none;" class="dropdown-menu bold">
                                </ul>
                            </li>
                            <li class="dropdown active">
                                <a href="Category.aspx">Maintenance Category <i class="icon-angle-down"></i></a>
                                <ul class="dropdown-menu bold">
                                </ul>
                            </li>
                            <li class="dropdown active">
                                <a href="BookByAuthor.aspx">List Book by Author <i class="icon-angle-down"></i></a>
                                <ul style="display: none;" class="dropdown-menu bold">
                                </ul>
                            </li>

                        </ul>
                    </nav>
                </div>
                <!-- end navigation -->
            </div>
        </div>

    </header>

    <script src="../Js/jquery-1.10.2.js" type="text/javascript"></script>
    <script src="../Js/custom.js" type="text/javascript"></script>

</body>
</html>
