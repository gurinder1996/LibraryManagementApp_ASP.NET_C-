<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="IssueBook.aspx.cs" Inherits="LibraryManagementApp.IssueBook" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--//Author: Dilpreet Shergill
//this page allows to issue or return books from library database to users that have signed up
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
        Issue/Return Details
        <small>Issue/Return Book</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li class="active">Issue/Return Details</li>
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
              <h3 class="box-title">Book Issue/Return Details</h3>
            </div>
            <!-- /.box-header -->

            <!-- form start -->
            <form role="form">
              <div class="box-body">

              <div class="row">
                 <div class="col-md-6">
                    <div class="form-group">
                    <label for="exampleInputEmail1">Book</label>
                    <asp:DropDownList ID="ddBookList" CssClass="form-control" AutoPostBack="false" runat="server" Width="300px">
                            </asp:DropDownList>
                  </div>
                </div>
                <div class="col-md-6">
                  <div class="form-group">
                    <label for="exampleInputEmail1">Name</label>
                     <asp:DropDownList ID="ddUserList" CssClass="form-control" AutoPostBack="false" runat="server" Width="300px">
                            </asp:DropDownList>
                  </div>
                </div>
              </div>
              
              <div class="row">
                 <div class="col-md-6">
                    <div class="form-group">
                    <label for="exampleInputEmail1">Status</label>
                   <asp:DropDownList ID="ddStatus" CssClass="form-control" AutoPostBack="true" runat="server" Width="300px">
                   <asp:ListItem Value="Issue">Issue</asp:ListItem>
                   <asp:ListItem Value="Return">Return</asp:ListItem>
                            </asp:DropDownList>
                  </div>
                </div>
                <div class="col-md-6">
                  <div class="form-group">
                    <label for="exampleInputEmail1">Details</label>
                    <asp:TextBox ID="txtDetails" runat="server" CssClass="form-control" placeholder="Details"></asp:TextBox>
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
