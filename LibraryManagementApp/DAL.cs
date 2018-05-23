//Author: Gurinder Saini
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;


namespace LibraryManagementApp
{
    // Database connectivity and session managements
    // 
    public class DAL
    {
        OleDbConnection MainConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + HttpContext.Current.Server.MapPath("~/App_Data") + "\\Database.accdb;Persist Security Info=False;");

        // execute query in database
        public Boolean ExecuteMethod(string qry)
        {
            try
            {
                //SqlCommand scom = new SqlCommand(qry, scon);
                OleDbCommand scom = new OleDbCommand(qry, MainConn);
                MainConn.Open();
                scom.ExecuteNonQuery();
                MainConn.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                MainConn.Close();
            }

        }

        // select data from database
        public DataResponse SelectDateOnTable(string sQuery)
        {
            DataResponse _DataResponse = new DataResponse();

            DataTable d1 = new DataTable();
            try
            {
                OleDbDataAdapter sda = new OleDbDataAdapter(sQuery, MainConn);
                sda.Fill(d1);

                _DataResponse.Response = true;
                _DataResponse.Result = d1;

            }
            catch (Exception ex)
            {
                _DataResponse.Response = false;
                _DataResponse.Error = ex.Message.ToString();
            }
            finally
            {
                MainConn.Close();
            }

            return _DataResponse;
        }


        public bool IsUserSessionAlive()
        {
            bool bReturn;
            try
            {
                bReturn = true;


                if (HttpContext.Current.Session == null)
                {
                    bReturn = false;
                }

                if (HttpContext.Current.Session["MYUSERID"] == null)
                {
                    bReturn = false;
                }

            }
            catch
            {
                bReturn = false;
            }
            return bReturn;
        }
    }

    public class DataResponse
    {
        public bool Response { get; set; }
        public DataTable Result { get; set; }
        public string Error { get; set; }
    }


}