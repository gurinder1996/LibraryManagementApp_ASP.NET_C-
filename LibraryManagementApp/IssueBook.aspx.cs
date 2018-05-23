//Author: Dilpreet Shergill
//this class helps add new issue and return entries to library database from issue book webpage
    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementApp
{
    public partial class IssueBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL _dl = new DAL();
            if (!_dl.IsUserSessionAlive())
                Response.Redirect("Login.aspx");

            if (!IsPostBack)
            {
                PopualteBooks();
                PopualteUser();
                PopualteData();
            }
        }

        // bind book list to droupdown 
        void PopualteBooks()
        {
            DAL _dl = new DAL();
            string sLoginQuery = "SELECT * FROM T001_BOOK ";
            DataResponse _DataResponse = new DataResponse();
            _DataResponse = _dl.SelectDateOnTable(sLoginQuery);
            if (_DataResponse.Response)
            {
                if (_DataResponse.Result.Rows.Count > 0)
                {
                    ddBookList.DataSource = _DataResponse.Result;
                    ddBookList.DataTextField = "T001_TITLE";
                    ddBookList.DataValueField = "T001_BOOKID";
                    ddBookList.DataBind();
                }
            }
        }

        // bind User list to droupdown 
        void PopualteUser()
        {
            DAL _dl = new DAL();
            string sLoginQuery = "SELECT * FROM T003_USER ";
            DataResponse _DataResponse = new DataResponse();
            _DataResponse = _dl.SelectDateOnTable(sLoginQuery);
            if (_DataResponse.Response)
            {
                if (_DataResponse.Result.Rows.Count > 0)
                {
                    ddUserList.DataSource = _DataResponse.Result;
                    ddUserList.DataTextField = "T003_NAME";
                    ddUserList.DataValueField = "T003_USERID";
                    ddUserList.DataBind();
                }
            }
        }

        // populate record for edit record.
        void PopualteData()
        {
            string id = "";
            id = Convert.ToString(Request.QueryString["id"]);
            if (!string.IsNullOrEmpty(id))
            {
                DAL _dl = new DAL();
                string sLoginQuery = "SELECT * FROM T002_ISSUE where T002_ISSUEID=" + id;
                DataResponse _DataResponse = new DataResponse();
                _DataResponse = _dl.SelectDateOnTable(sLoginQuery);
                if (_DataResponse.Response)
                {
                    if (_DataResponse.Result.Rows.Count > 0)
                    {
                        ddBookList.SelectedValue = Convert.ToString(_DataResponse.Result.Rows[0]["T001_BOOKID"]);
                        ddUserList.SelectedValue = Convert.ToString(_DataResponse.Result.Rows[0]["T003_USERID"]);
                        txtDetails.Text = Convert.ToString(_DataResponse.Result.Rows[0]["T002_DETAILS"]);
                        ddStatus.Text = Convert.ToString(_DataResponse.Result.Rows[0]["T002_STATUS"]);
                    }
                }
            }

        }

        // save record to database.
        void SaveData()
        {
            try
            {

                int T001_BOOKID = 0, T003_USERID=0;
                string T002_NAME = "", T002_DETAILS = "", T002_STATUS = "";
                int.TryParse(ddBookList.SelectedValue.ToString(), out T001_BOOKID);
                int.TryParse(ddUserList.SelectedValue.ToString(), out T003_USERID);
                T002_DETAILS = txtDetails.Text.Trim();
                T002_STATUS = ddStatus.SelectedValue.ToString();
                
                string id = "";
                id = Convert.ToString(Request.QueryString["id"]);
                string sQuery = "";
                if (string.IsNullOrEmpty(id))
                    sQuery = "INSERT INTO T002_ISSUE(T001_BOOKID,T003_USERID,T002_DETAILS,T002_STATUS) VALUES('" + T001_BOOKID + "','" + T003_USERID + "','" + T002_DETAILS + "','" + T002_STATUS + "')";
                else
                    sQuery = "UPDATE T002_ISSUE SET T001_BOOKID='" + T001_BOOKID + "',T003_USERID='" + T003_USERID + "',T002_DETAILS='" + T002_DETAILS + "',T002_STATUS='" + T002_STATUS + "' WHERE T002_ISSUEID=" + id;

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

        // clear input values.
        void ResetData()
        {
            ddBookList.SelectedIndex = 0;
            ddUserList.SelectedIndex = 0;
            ddStatus.SelectedIndex = 0;
            txtDetails.Text = "";
        }

        // fire click event to save record
        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}