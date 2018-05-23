//Author: Gurinder Saini
//this class helps list all books from  MS Access database to the Book List web page
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementApp
{
    public partial class Books : System.Web.UI.Page
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

        // get data from database and fill to grid view 
        void PopualteData()
        {
            DAL _dl = new DAL();
            string sLoginQuery = "SELECT * FROM T001_BOOK";
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

        // Edit icon to record fill in add form
        protected void imgbtnEdit_Command(object sender, CommandEventArgs e)
        {
            int id = 0;
            int.TryParse(e.CommandArgument.ToString(), out id);
            Response.Redirect("BookMaster.aspx?id=" + id);
        }

        // delete record from database
        protected void imgbtnDelete_Command(object sender, CommandEventArgs e)
        {
            int id = 0;
            int.TryParse(e.CommandArgument.ToString(), out id);

            if (id > 0)
            {
                string sQuery = "";
                sQuery = "DELETE FROM T001_BOOK WHERE T001_BOOKID=" + id;
                DAL _dal = new DAL();
                if (_dal.ExecuteMethod(sQuery))
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Deleted')", true);
                    PopualteData();
                }
            }
        }

        protected void gvPhotoAlbum_DataBound(object sender, EventArgs e)
        {

        }

        // every row set delete confirmation
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