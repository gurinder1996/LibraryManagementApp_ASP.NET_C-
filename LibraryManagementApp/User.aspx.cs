//Author: Prabhjot Singh
//this class helps add new users from add user webpage to library database
   
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementApp
{
    public partial class User : System.Web.UI.Page
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
                string sLoginQuery = "SELECT * FROM T003_USER where T003_USERID=" + id;
                DataResponse _DataResponse = new DataResponse();
                _DataResponse = _dl.SelectDateOnTable(sLoginQuery);
                if (_DataResponse.Response)
                {
                    if (_DataResponse.Result.Rows.Count > 0)
                    {
                        txtAddress.Text = Convert.ToString(_DataResponse.Result.Rows[0]["T003_ADDRESS"]);
                        txtEmail.Text = Convert.ToString(_DataResponse.Result.Rows[0]["T003_EMAIL"]);
                        txtName.Text = Convert.ToString(_DataResponse.Result.Rows[0]["T003_NAME"]);
                        txtPhone.Text = Convert.ToString(_DataResponse.Result.Rows[0]["T003_PHONE"]);
                    }
                }
            }

        }

        // save record to database using DAL class
        void SaveData()
        {
            try
            {

                string T003_NAME = "", T003_EMAIL = "", T003_PHONE = "", T003_ADDRESS = "";
                T003_NAME = txtName.Text.Trim();
                T003_EMAIL = txtEmail.Text.Trim();
                T003_PHONE = txtPhone.Text.Trim();
                T003_ADDRESS = txtAddress.Text.Trim();


                string id = "";
                id = Convert.ToString(Request.QueryString["id"]);
                string sQuery = "";
                if (string.IsNullOrEmpty(id))
                    sQuery = "INSERT INTO T003_USER(T003_NAME,T003_EMAIL,T003_PHONE,T003_ADDRESS) VALUES('" + T003_NAME + "','" + T003_EMAIL + "','" + T003_PHONE + "','" + T003_ADDRESS + "')";
                else
                    sQuery = "UPDATE T003_USER SET T003_NAME='" + T003_NAME + "',T003_EMAIL='" + T003_EMAIL + "',T003_PHONE='" + T003_PHONE + "',T003_ADDRESS='" + T003_ADDRESS + "' WHERE T003_USERID=" + id;

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
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
        }

        // save buttion click event to save data
        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}