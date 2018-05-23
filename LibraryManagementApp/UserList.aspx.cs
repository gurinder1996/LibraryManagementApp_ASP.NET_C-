//Author: Prabhjot Singh
//this class helps list all the users from library database to user list webpage
   

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementApp
{
    public partial class UserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL _dl = new DAL();
            if (!_dl.IsUserSessionAlive())
                Response.Redirect("Login.aspx");

            if (!IsPostBack)
            {
                PopualteData();
            }
        }

        protected void gvPhotoAlbum_DataBound(object sender, EventArgs e)
        {

        }

        // get isuue record details from database
        void PopualteData()
        {
            DAL _dl = new DAL();
            string sLoginQuery = "SELECT * FROM T003_USER ";
            DataResponse _DataResponse = new DataResponse();
            _DataResponse = _dl.SelectDateOnTable(sLoginQuery);
            if (_DataResponse.Response)
            {
                if (_DataResponse.Result.Rows.Count > 0)
                {
                    gvPhotoAlbum.DataSource = _DataResponse.Result;
                    gvPhotoAlbum.DataBind();
                }
                else
                {
                    gvPhotoAlbum.DataSource = null;
                    gvPhotoAlbum.DataBind();
                }
            }
            else
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + _DataResponse.Error.ToString() + "')", true);
        }

        // edit icon click event set
        protected void imgbtnEdit_Command(object sender, CommandEventArgs e)
        {
            int id = 0;
            int.TryParse(e.CommandArgument.ToString(), out id);
            Response.Redirect("User.aspx?id=" + id);
        }

        // delete icon click event set
        protected void imgbtnDelete_Command(object sender, CommandEventArgs e)
        {
            int id = 0;
            int.TryParse(e.CommandArgument.ToString(), out id);

            if (id > 0)
            {
                string sQuery = "";
                sQuery = "DELETE FROM T003_USER WHERE T003_USERID=" + id;
                DAL _dal = new DAL();
                if (_dal.ExecuteMethod(sQuery))
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Deleted')", true);
                    PopualteData();
                }
            }
        }

        // set every row to delete confirmation
        protected void gvPhotoAlbum_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {

                var _data = e.Row.DataItem;
                //HyperLink hyperViewMore = (HyperLink)e.Row.FindControl("hyperViewMore");
                //hyperViewMore.NavigateUrl = "CarrerDetails.aspx?sID=" + aFeedback.T005_CAREERID;

                ImageButton l = (ImageButton)e.Row.FindControl("imgbtnDelete");
                l.Attributes.Add("onclick", "javascript:return " + "confirm(' Are you sure, Do you want to delete this record..?')");
            }
        }

    }
}