<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="BookMaster.aspx.cs" Inherits="LibraryManagementApp.BookMaster" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Author: Gurinder Saini
    This page allows to add new book to the book table in library database is MS Access-->

    <!-- =============================================== -->
    <!-- Content Wrapper. Contains page content -->
    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
      <h1>
        Book Details
        <small>Book Listing</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li class="active">Book Details</li>
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
              <h3 class="box-title">Book Details</h3>
            </div>
            <!-- /.box-header -->

            <!-- form start -->
            <form role="form">
              <div class="box-body">

              <div class="row">
                 <div class="col-md-6">
                    <div class="form-group">
                    <label for="exampleInputEmail1">Subject</label>
                    <asp:TextBox ID="txtSubject" runat="server" CssClass="form-control" placeholder="Subject"></asp:TextBox>
                  </div>
                </div>
                <div class="col-md-6">
                  <div class="form-group">
                    <label for="exampleInputEmail1">ISBN</label>
                    <asp:TextBox ID="txtISBN" runat="server" CssClass="form-control" placeholder="ISBN"></asp:TextBox>
                  </div>
                </div>
              </div>
              
              <div class="row">
                 <div class="col-md-6">
                    <div class="form-group">
                    <label for="exampleInputEmail1">Title</label>
                    <asp:TextBox ID="txtTitle" runat="server" CssClass="form-control" placeholder="Title"></asp:TextBox>
                  </div>
                </div>
                <div class="col-md-6">
                  <div class="form-group">
                    <label for="exampleInputEmail1">Number Of Books</label>
                    <asp:TextBox ID="txtNumberOfBooks" runat="server" CssClass="form-control" placeholder="Number Of Books"></asp:TextBox>
                  </div>
                </div>
              </div>  
              
              <div class="row">
                 <div class="col-md-6">
                    <div class="form-group">
                    <label for="exampleInputEmail1">Author</label>
                    <asp:TextBox ID="txtAuthor" runat="server" CssClass="form-control" placeholder="Author"></asp:TextBox>
                  </div>
                </div>
                <div class="col-md-6">
                  <div class="form-group">
                    <label for="exampleInputEmail1">Number Of Available Books</label>
                    <asp:TextBox ID="txtNumberOfAvailableBooks" runat="server" CssClass="form-control" placeholder="Number Of Available Books"></asp:TextBox>
                  </div>
                </div>
              </div>    

              <div class="row">
                 <div class="col-md-6">
                    <div class="form-group">
                    <label for="exampleInputEmail1">Publisher</label>
                    <asp:TextBox ID="txtPublisher" runat="server" CssClass="form-control" placeholder="Publisher"></asp:TextBox>
                  </div>
                </div>
                <div class="col-md-6">
                  <div class="form-group">
                    <label for="exampleInputEmail1">NumberOfBorrowedBooks</label>
                    <asp:TextBox ID="txtNumberOfBorrowedBooks" runat="server" CssClass="form-control" placeholder="Number Of Borrowed Books"></asp:TextBox>
                  </div>
                </div>
              </div> 

               <div class="row">
                 <div class="col-md-6">
                    <div class="form-group">
                    <label for="exampleInputEmail1">Copyright</label>
                    <asp:TextBox ID="txtCopyright" runat="server" CssClass="form-control" placeholder="Copyright"></asp:TextBox>
                  </div>
                </div>
                <div class="col-md-6">
                  <div class="form-group">
                    <label for="exampleInputEmail1">Library</label>
                    <asp:TextBox ID="txtLibrary" runat="server" CssClass="form-control" placeholder="Library"></asp:TextBox>
                  </div>
                </div>
              </div> 

              <div class="row">
                 <div class="col-md-6">
                    <div class="form-group">
                    <label for="exampleInputEmail1">Edition</label>
                    <asp:TextBox ID="txtEdition" runat="server" CssClass="form-control" placeholder="Edition"></asp:TextBox>
                  </div>
                </div>
                <div class="col-md-6">
                  <div class="form-group">
                    <label for="exampleInputEmail1">SelfNo</label>
                    <asp:TextBox ID="txtSelfNo" runat="server" CssClass="form-control" placeholder="SelfNo"></asp:TextBox>
                  </div>
                </div>
              </div> 

               <div class="row">
                 <div class="col-md-6">
                    <div class="form-group">
                    <label for="exampleInputEmail1">Pages</label>
                    <asp:TextBox ID="txtPages" runat="server" CssClass="form-control" placeholder="Pages"></asp:TextBox>
                  </div>
                </div>
                <div class="col-md-6">
                  <div class="form-group">
                    <label for="exampleInputEmail1">Available</label>
                    <asp:CheckBox ID="chkAvailable" runat="server" CssClass="form-control" />
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
