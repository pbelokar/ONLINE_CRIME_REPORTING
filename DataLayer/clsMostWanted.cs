using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CriminalRecordManagement.DataLayer
{
    public class clsMostWanted
    {
        private int _ID;
        private string _Name;
        private string _NickName;
        private int _Age;
        private string _Sex;
        private string _Description;

        DataConnection dc = new DataConnection();

        public int ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public int Age { get => _Age; set => _Age = value; }
        public string Sex { get => _Sex; set => _Sex = value; }
        public string Description { get => _Description; set => _Description = value; }
        public string NickName { get => _NickName; set => _NickName = value; }

        public Boolean AddMostWanted()
        {
            string SQL = "CriminalRecordMostWanted";
            SqlConnection con = dc.getConnection();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prID = cmd.Parameters.Add("@mwID", SqlDbType.Int);
            SqlParameter prName = cmd.Parameters.Add("@mwName", SqlDbType.VarChar, 100);
            SqlParameter prAge = cmd.Parameters.Add("@mwAge", SqlDbType.Int);
            SqlParameter prSex = cmd.Parameters.Add("@mwSex", SqlDbType.VarChar, 100);
            SqlParameter prDescription = cmd.Parameters.Add("@mwDescription", SqlDbType.VarChar, 100);

            prID.Value = this.ID;
            prName.Value = this.Name;
            prAge.Value = this.Age;
            prSex.Value = this.Sex;
            prDescription.Value = this.Description;

            if (con.State != ConnectionState.Open)
                con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }
    }
}