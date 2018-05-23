<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="Books.aspx.cs" Inherits="LibraryManagementApp.Books" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Author: Gurinder Saini ,This page lists all the books in the book table in MS Access database. Books info can also edited and deleted-->
    <!--Personal Log:
        Week 1: //we found a library bootstrap template to start our project and make the app look modern
                //still figuring out on how the fields will be placed
        Week 2: //decided to first build database table named- T001_BOOK
                //this table will contain all fields listed on add book webpage
        Week 3: // decided to make add book web page
                // this web page corresponds to field in the database table named- T001_BOOK
        Week 4: // decided to make book list web page
            // this page will retrive book list from database table named- T001_BOOK, and list 3-4 fields of each book, edit and delete button also provided
        Week 5: //decided to connect the database with book list and add book webpages
            // for edit function, the app will just retieve selected book's info and fill in on the add book page and there the user can edit info
        // for delete function, the app will just delete the selected from book database table named- T001_BOOK with using the book id
        
        -->

    <!--Conclusion:
        Lessons learned:
        1. ASP.NET is really convenient for designed and developing webpages compared to J2ee done in semester 3. 
            we are able to use post backs, session timers and cookies, all built.
        2. Really love the fact that visual studio allows to various database systems like, ms access, sql server and oracle
        3. visual studio does great job at providing the class diagrams, developers can edit and build uml structures right in the IDE!
        4. The visual studio debugging is really advanced and handy for programmers, allows to easily find bugs and shortcomings in the developed software
        -->
    <!-- =============================================== -->
    <!-- Content Wrapper. Contains page content -->
    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
      <h1>
        Book Details
        <small>Add/Update Book</small>
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

             <div class="row">
                 <div class="col-md-12">

                  <asp:GridView ID="gvPhotoAlbum" runat="server" AutoGenerateColumns="False" CellPadding="4"
                                EnableModelValidation="True" ForeColor="#333333" GridLines="None" 
                         Width="100%" ondatabound="gvPhotoAlbum_DataBound" 
                         onrowdatabound="gvPhotoAlbum_RowDataBound">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="T001_SUBJECT" HeaderText="Subject">
                                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="300px" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="T001_TITLE" HeaderText="Title">
                                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="300px" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="T001_NUMBER_OF_BOOK" HeaderText="Number Of Book">
                                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="300px" />
                                    </asp:BoundField>

                                    <asp:TemplateField HeaderText="Edit">
                                        <ItemTemplate>
                                            <asp:ImageButton ID="imgbtnEdit" runat="server" CausesValidation="False" CommandArgument='<%# Eval("T001_BOOKID") %>'
                                                Height="20px" ImageUrl="~/dist/img/edit-icn.gif" Width="20px" 
                                                OnCommand="imgbtnEdit_Command" />
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="50px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Delete">
                                        <ItemTemplate>
                                            <asp:ImageButton ID="imgbtnDelete" runat="server" CausesValidation="False" CommandArgument='<%# Eval("T001_BOOKID") %>'
                                                Height="20px" ImageUrl="~/dist/img/delete-icn.gif" Width="20px" 
                                                OnCommand="imgbtnDelete_Command" />
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="50px" />
                                    </asp:TemplateField>
                                </Columns>
                                <EditRowStyle BackColor="#2461BF" />
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" Height="35px"
                                    HorizontalAlign="Left" VerticalAlign="Middle" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#EFF3FB" Height="90px" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            </asp:GridView>


                 </div>
              </div>
         
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
