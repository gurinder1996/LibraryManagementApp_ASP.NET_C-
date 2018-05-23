//Author: Tushar Chopra
//this class helps change password for users from login table from library database on change password webpage
   
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementApp
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // change password to database 
        void ChangePasswod()
        {
            try
            {
                string sPassword = "", sConfirmPassword = "";
                sPassword = txtpassword.Text.Trim();
                sConfirmPassword = txtConfirmPassword.Text.Trim();

                if (string.IsNullOrEmpty(sPassword))
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Password is required')", true);
                    txtpassword.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(sConfirmPassword))
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Confirm Password is required')", true);
                    txtConfirmPassword.Focus();
                    return;
                }

                if (sPassword != sConfirmPassword)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Password and Confirm Password is not same.')", true);
                    txtConfirmPassword.Focus();
                    return;
                }

                string sQuery = "";
                sQuery = "UPDATE T00_LOGIN SET T00_PASSWORD='" + sPassword + "'";

                DAL _dal = new DAL();
                if (_dal.ExecuteMethod(sQuery))
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Password updated.')", true);

                    ResetData();
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + ex.Message.ToString() + "')", true);
            }
        }

        // clear input values
        void ResetData()
        {
            txtConfirmPassword.Text = "";
            txtpassword.Text = "";
        }

        // buttion click events
        protected void btnSave_Click(object sender, EventArgs e)
        {
            ChangePasswod();
        }
    }
}