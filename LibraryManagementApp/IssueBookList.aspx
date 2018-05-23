<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="IssueBookList.aspx.cs" Inherits="LibraryManagementApp.IssueBookList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--//Author: Dilpreet Shergill
//this page lists all books issued from library database
    -->

    <!-- =============================================== -->
    <!-- Content Wrapper. Contains page content -->
    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
      <h1>
        Issue/Return Book Details
        <small>Issue/Return Book Listing</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li class="active">Issue/Return Book Details</li>
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
              <h3 class="box-title">Issue/Return Book Details</h3>
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
                                    <asp:BoundField DataField="T003_NAME" HeaderText="Name">
                                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="300px" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="T001_TITLE" HeaderText="Book Title">
                                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="300px" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="T002_STATUS" HeaderText="Status">
                                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="300px" />
                                    </asp:BoundField>

                                    <asp:TemplateField HeaderText="Edit">
                                        <ItemTemplate>
                                            <asp:ImageButton ID="imgbtnEdit" runat="server" CausesValidation="False" CommandArgument='<%# Eval("T002_ISSUEID") %>'
                                                Height="20px" ImageUrl="~/dist/img/edit-icn.gif" Width="20px" 
                                                OnCommand="imgbtnEdit_Command" />
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="50px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Delete">
                                        <ItemTemplate>
                                            <asp:ImageButton ID="imgbtnDelete" runat="server" CausesValidation="False" CommandArgument='<%# Eval("T002_ISSUEID") %>'
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
