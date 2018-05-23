//Author: Gurinder Saini
//this class is for Add Book page. This class allows to add new books to book table in Library MS Access database

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementApp
{
    public partial class BookMaster : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            DAL _dl = new DAL();
            // check session is available or not if not available then redirect to login page
            if (!_dl.IsUserSessionAlive())
                Response.Redirect("Login.aspx");
            if (!IsPostBack)
            {
                PopualteData();
            }
        }

        // populate edit time data 
        void PopualteData()
        {
            string id = "";
            id = Convert.ToString(Request.QueryString["id"]);
            if (!string.IsNullOrEmpty(id))
            {
                DAL _dl = new DAL();
                string sLoginQuery = "SELECT * FROM T001_BOOK where T001_BOOKID=" + id;
                DataResponse _DataResponse = new DataResponse();
                _DataResponse = _dl.SelectDateOnTable(sLoginQuery);
                if (_DataResponse.Response)
                {
                    if (_DataResponse.Result.Rows.Count > 0)
                    {
                        txtAuthor.Text = Convert.ToString(_DataResponse.Result.Rows[0]["T001_AUTHOR"]);
                        txtCopyright.Text = Convert.ToString(_DataResponse.Result.Rows[0]["T001_COPYRIGHT"]);
                        txtEdition.Text = Convert.ToString(_DataResponse.Result.Rows[0]["T001_EDITION"]);
                        txtISBN.Text = Convert.ToString(_DataResponse.Result.Rows[0]["T001_ISBN"]);
                        txtLibrary.Text = Convert.ToString(_DataResponse.Result.Rows[0]["T001_LIBRARY"]);
                        txtNumberOfAvailableBooks.Text = Convert.ToString(_DataResponse.Result.Rows[0]["T001_NUMBER_OF_AVAILBLE_BOOK"]);
                        txtNumberOfBooks.Text = Convert.ToString(_DataResponse.Result.Rows[0]["T001_NUMBER_OF_BOOK"]);
                        txtNumberOfBorrowedBooks.Text = Convert.ToString(_DataResponse.Result.Rows[0]["T001_NUMBER_OF_BORROWD"]);
                        txtPages.Text = Convert.ToString(_DataResponse.Result.Rows[0]["T001_PAGES"]);
                        txtPublisher.Text = Convert.ToString(_DataResponse.Result.Rows[0]["T001_PUBLISHER"]);
                        txtSelfNo.Text = Convert.ToString(_DataResponse.Result.Rows[0]["T001_SELEF_NO"]);
                        txtSubject.Text = Convert.ToString(_DataResponse.Result.Rows[0]["T001_SUBJECT"]);
                        txtTitle.Text = Convert.ToString(_DataResponse.Result.Rows[0]["T001_TITLE"]);
                        if (Convert.ToString(_DataResponse.Result.Rows[0]["T001_TITLE"]) == "Y")
                            chkAvailable.Checked = true;
                        else
                            chkAvailable.Checked = false;

                    }
                }
            }

        }

        // save record to database using DAL class
        void SaveData()
        {
            try
            {

                string T001_SUBJECT = "", T001_ISBN = "", T001_TITLE = "", T001_NUMBER_OF_BOOK = "", T001_AUTHOR = "", T001_NUMBER_OF_AVAILBLE_BOOK = "", T001_PUBLISHER = "", T001_NUMBER_OF_BORROWD = "", T001_COPYRIGHT = "", T001_LIBRARY = "", T001_EDITION = "", T001_SELEF_NO = "", T001_PAGES = "", T001_AVAILABLE = "";
                T001_SUBJECT = txtSubject.Text.Trim();
                T001_ISBN = txtISBN.Text.Trim();
                T001_TITLE = txtTitle.Text.Trim();
                T001_NUMBER_OF_BOOK = txtNumberOfBorrowedBooks.Text.Trim();
                T001_AUTHOR = txtAuthor.Text.Trim();
                T001_NUMBER_OF_AVAILBLE_BOOK = txtNumberOfAvailableBooks.Text.Trim();
                T001_PUBLISHER = txtPublisher.Text.Trim();
                T001_NUMBER_OF_BORROWD = txtNumberOfBorrowedBooks.Text.Trim();
                T001_COPYRIGHT = txtCopyright.Text.Trim();
                T001_LIBRARY = txtLibrary.Text.Trim();
                T001_EDITION = txtEdition.Text.Trim();
                T001_SELEF_NO = txtSelfNo.Text.Trim();
                T001_PAGES = txtPages.Text.Trim();
                if (chkAvailable.Checked)
                    T001_AVAILABLE = "Y";
                else
                    T001_AVAILABLE = "N";

                string id = "";
                id = Convert.ToString(Request.QueryString["id"]);
                string sQuery = "";
                if (string.IsNullOrEmpty(id))
                    sQuery = "INSERT INTO T001_BOOK(T001_SUBJECT,T001_ISBN,T001_TITLE,T001_NUMBER_OF_BOOK,T001_AUTHOR,T001_NUMBER_OF_AVAILBLE_BOOK,T001_PUBLISHER,T001_NUMBER_OF_BORROWD,T001_COPYRIGHT,T001_LIBRARY,T001_EDITION,T001_SELEF_NO,T001_PAGES,T001_AVAILABLE) VALUES('" + T001_SUBJECT + "','" + T001_ISBN + "','" + T001_TITLE + "','" + T001_NUMBER_OF_BOOK + "','" + T001_AUTHOR + "','" + T001_NUMBER_OF_AVAILBLE_BOOK + "','" + T001_PUBLISHER + "','" + T001_NUMBER_OF_BORROWD + "','" + T001_COPYRIGHT + "','" + T001_LIBRARY + "','" + T001_EDITION + "','" + T001_SELEF_NO + "','" + T001_PAGES + "','" + T001_AVAILABLE + "')";
                else
                    sQuery = "UPDATE T001_BOOK SET T001_SUBJECT='" + T001_SUBJECT + "',T001_ISBN='" + T001_ISBN + "',T001_TITLE='" + T001_TITLE + "',T001_NUMBER_OF_BOOK='" + T001_NUMBER_OF_BOOK + "',T001_AUTHOR='" + T001_AUTHOR + "',T001_NUMBER_OF_AVAILBLE_BOOK='" + T001_NUMBER_OF_AVAILBLE_BOOK + "',T001_PUBLISHER='" + T001_PUBLISHER + "',T001_NUMBER_OF_BORROWD='" + T001_NUMBER_OF_BORROWD + "',T001_COPYRIGHT='" + T001_COPYRIGHT + "',T001_LIBRARY='" + T001_LIBRARY + "',T001_EDITION='" + T001_EDITION + "',T001_SELEF_NO='" + T001_SELEF_NO + "',T001_PAGES='" + T001_PAGES + "',T001_AVAILABLE='" + T001_AVAILABLE + "' WHERE T001_BOOKID=" + id;

                DAL _dal = new DAL();
                if (_dal.ExecuteMethod(sQuery))
                {
                    if (string.IsNullOrEmpty(id))
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record inserted')", true);
                    else
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record updated')", true);

                    ResetData();
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + ex.Message.ToString() + "')", true);
            }
        }

        // Clear all input data
        void ResetData()
        {
            txtAuthor.Text = "";
            txtCopyright.Text = "";
            txtEdition.Text = "";
            txtISBN.Text = "";
            txtLibrary.Text = "";
            txtNumberOfAvailableBooks.Text = "";
            txtNumberOfBooks.Text = "";
            txtNumberOfBorrowedBooks.Text = "";
            txtPages.Text = "";
            txtPublisher.Text = "";
            txtSelfNo.Text = "";
            txtSubject.Text = "";
            txtTitle.Text = "";
            chkAvailable.Checked = false;
        }

        // save button click event to save data
        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}