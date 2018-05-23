//Author: Tushar Chopra
//this class helps verify user info from login table from library database on login webpage

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txt_uname.Focus();
        }

        // login buttion click and check username is valid or not
        protected void Login_Click(object sender, EventArgs e)
        {
            string sUserName = txt_uname.Text.Trim();
            string sPassword = txt_password.Text.Trim();
            if (string.IsNullOrEmpty(sUserName))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('User name is required.')", true);
                txt_uname.Focus();
                return;
            }
            if (string.IsNullOrEmpty(sPassword))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Password is required.')", true);
                txt_password.Focus();
                return;
            }

            DAL _dl = new DAL();
            string sLoginQuery = "SELECT * FROM T00_LOGIN WHERE T00_USERNAME='" + sUserName + "' and T00_PASSWORD='" + sPassword + "'";
            DataResponse _DataResponse = new DataResponse();
            _DataResponse = _dl.SelectDateOnTable(sLoginQuery);
            if (_DataResponse.Response)
            {
                if (_DataResponse.Result.Rows.Count > 0)
                {
                    HttpContext.Current.Session["MYUSERID"] = _DataResponse.Result.Rows[0]["T00_LOGINID"].ToString();
                    Response.Redirect("/Books.aspx");
                }
                else
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Invalid username and password')", true);
            }
            else
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + _DataResponse.Error.ToString() + "')", true);

        }
    }
}