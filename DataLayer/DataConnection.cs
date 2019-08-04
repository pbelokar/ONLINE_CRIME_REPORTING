using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CriminalRecordManagement.DataLayer
{
    public class DataConnection
    {
        SqlConnection con = new SqlConnection();
        public DataConnection()
        {

            con.ConnectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();
            con.Open();

        }

        ~DataConnection()
        {
            //if(con.State == ConnectionState.Open)
            //con.Close();
        }

        public SqlConnection getConnection()
        {
            return con;
        }
              

       
    }
}