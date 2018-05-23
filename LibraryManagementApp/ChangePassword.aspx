<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="ChangePassword.aspx.cs" Inherits="LibraryManagementApp.ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!--//Author: Tushar Chopra
//this page allows users from login table from library database to change password
    -->
  

    <!-- =============================================== -->
    <!-- Content Wrapper. Contains page content -->
    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
      <h1>
        Change Password Details
        <small>Change Password</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li class="active">Change Password</li>
      </ol>
    </section>
        <!-- Main content -->
        <section class="content">

      <!-- Default box -->
      <div class="box">
        <div class="box-body">
         <div class="row">
            <div class="col-md-12">
            <div class="box box-primary">
            <div class="box-header with-border">
              <h3 class="box-title">Change Password</h3>
            </div>
            <!-- /.box-header -->

            <!-- form start -->
            <form role="form">
              <div class="box-body">

              <div class="row">
                <div class="col-md-12">
                  <div class="form-group">
                    <label for="exampleInputEmail1">Password</label>
                    <asp:TextBox ID="txtpassword" TextMode="Password" runat="server" CssClass="form-control" placeholder="Password"></asp:TextBox>
                  </div>
                </div>
              </div>
              
              <div class="row">
                <div class="col-md-12">
                  <div class="form-group">
                    <label for="exampleInputEmail1">Confirm Password</label>
                    <asp:TextBox ID="txtConfirmPassword" TextMode="Password" runat="server" CssClass="form-control" placeholder="Confirm Password"></asp:TextBox>
                  </div>
                </div>
              </div>
              

              </div>
              <!-- /.box-body -->

              <div class="box-footer">
               <asp:Button ID="btnSave"  runat="server" CssClass="btn btn-primary" Text="Save" OnClick="btnSave_Click" />
                
              </div>
            </form>
          </div>
            </div>
         </div>
        </div>
        
      </div>
      <!-- /.box -->

    </section>
        <!-- /.content -->
    </div>
    <!-- /.content-wrapper -->
</asp:Content>
