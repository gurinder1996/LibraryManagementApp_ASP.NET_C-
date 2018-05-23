﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LibraryManagementApp.Login" %>
<!--//Author: Tushar Chopra
//this page allows users from login table from library database to login and view library system
    -->
<!--Personal Log:
        Week 1:
        Week 2:
        Week 3:
        Week 4:
        Week 5:
        
        -->

    <!--Conclusion:
        Lessons learned:
        1.
        2.
        3.
        -->
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <title>Log in</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no"
        name="viewport">
    <!-- Bootstrap 3.3.7 -->
    <link rel="stylesheet" href="bower_components/bootstrap/dist/css/bootstrap.min.css" />
    <!-- Font Awesome -->
    <link rel="stylesheet" href="bower_components/font-awesome/css/font-awesome.min.css">
    <!-- Theme style -->
    <link rel="stylesheet" href="dist/css/AdminLTE.min.css">
    <!-- Google Font -->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic">
</head>
<body class="hold-transition login-page">
    <form runat="server">
    <div class="login-box">
        <div class="login-logo">
            <a href="/Login.aspx"><b>Library</b>MS</a>
        </div>
        <!-- /.login-logo -->
        <div class="login-box-body">
            <p class="login-box-msg">
                Sign in to start your session</p>
            <form action="#" method="post">
            <div class="form-group has-feedback">
                <asp:TextBox ID="txt_uname" runat="server" CssClass="form-control" placeholder="User name"></asp:TextBox>
                <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
            </div>
            <div class="form-group has-feedback">
                <asp:TextBox ID="txt_password" TextMode="Password" runat="server" CssClass="form-control"
                    placeholder="Password"></asp:TextBox>
                <span class="glyphicon glyphicon-lock form-control-feedback"></span>
            </div>
            <div class="row">
                <div class="col-xs-8">
                </div>
                <!-- /.col -->
                <div class="col-xs-4">
                    <asp:Button ID="btnLogin" class="btn btn-primary btn-block btn-flat" runat="server"
                        Text="Sign In" OnClick="Login_Click" />
                </div>
                <!-- /.col -->
            </div>
            </form>
        </div>
        <!-- /.login-box-body -->
    </div>
    </form>
    <!-- /.login-box -->
    <!-- jQuery 3 -->
    <script src="bower_components/jquery/dist/jquery.min.js"></script>
    <!-- Bootstrap 3.3.7 -->
    <script src="bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
</body>
</html>
