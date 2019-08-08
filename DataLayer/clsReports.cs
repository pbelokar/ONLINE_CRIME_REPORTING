using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CriminalRecordManagement.DataLayer
{
    public class clsReports
    {
        private string _searchCriteria;
        private string _searchID;
        private string _columnName;
        DataConnection dc = new DataConnection();
        public string SearchCriteria { get => _searchCriteria; set => _searchCriteria = value; }
        public string SearchID { get => _searchID; set => _searchID = value; }
        public string ColumnName { get => _columnName; set => _columnName = value; }

        public DataSet RetriveData()
        {
            DataSet ds = new DataSet();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dc.getConnection();
            cmd.CommandText = "select * from " + this.SearchCriteria + " where " + this.ColumnName + " = " + this.SearchID;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            da.Fill(ds, "users");
            
            return ds;
            
        }

        public DataSet getDropDownList()
        {
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dc.getConnection();
            cmd.CommandText = "select * from tblDict";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            da.Fill(ds, "users");
                        
            return ds;
        }
    }
}