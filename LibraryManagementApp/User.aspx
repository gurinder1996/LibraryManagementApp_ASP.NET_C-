<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="User.aspx.cs" Inherits="LibraryManagementApp.User" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--//Author: Prabhjot Singh
//this page allows to add new users to library database
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
    <!-- =============================================== -->
    <!-- Content Wrapper. Contains page content -->
    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
      <h1>
        User Details
        <small>User Listing</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li class="active">User Details</li>
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
              <h3 class="box-title">User Details</h3>
            </div>
            <!-- /.box-header -->

            <!-- form start -->
            <form role="form">
              <div class="box-body">

              <div class="row">
                 <div class="col-md-12">
                    <div class="form-group">
                    <label for="exampleInputEmail1">Name</label>
                    <asp:TextBox ID="txtName" runat="server" CssClass="form-control" placeholder="Name"></asp:TextBox>
                  </div>
                </div>
                </div>
                 <div class="row">
                <div class="col-md-12">
                  <div class="form-group">
                    <label for="exampleInputEmail1">Email-Address</label>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Email-Address"></asp:TextBox>
                  </div>
                </div>
              </div>
              
              <div class="row">
                 <div class="col-md-12">
                    <div class="form-group">
                    <label for="exampleInputEmail1">Phone No</label>
                    <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control" placeholder="Phone No"></asp:TextBox>
                  </div>
                </div>
              </div>  
              
              <div class="row">
                 <div class="col-md-12">
                    <div class="form-group">
                    <label for="exampleInputEmail1">Address</label>
                    <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control" placeholder="Address"></asp:TextBox>
                  </div>
                </div>
              </div>    


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
