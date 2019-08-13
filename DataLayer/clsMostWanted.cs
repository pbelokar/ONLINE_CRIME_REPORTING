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
        private int _MOWAID;
        private string _MOWAName;
        private int _MOWAAge;
        private string _MOWASex;
        private string _MOWADetails;

        DataConnection dc = new DataConnection();

        public int MOWAID { get => _MOWAID; set => _MOWAID = value; }
        public string MOWAName { get => _MOWAName; set => _MOWAName = value; }
        public int MOWAAge { get => _MOWAAge; set => _MOWAAge = value; }
        public string MOWASex { get => _MOWASex; set => _MOWASex = value; }
        public string MOWADetails { get => _MOWADetails; set => _MOWADetails = value; }

        public Boolean AddMostWanted()
        {
            string SQL = "CriminalRecordMostWanted";
            SqlConnection con = dc.getConnection();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prID = cmd.Parameters.Add("@MOWAID", SqlDbType.Int);
            SqlParameter prName = cmd.Parameters.Add("@MOWAName", SqlDbType.VarChar, 100);
            SqlParameter prAge = cmd.Parameters.Add("@MOWAAge", SqlDbType.Int);
            SqlParameter prSex = cmd.Parameters.Add("@MOWASex", SqlDbType.VarChar, 100);
            SqlParameter prDescription = cmd.Parameters.Add("@MOWADetails", SqlDbType.VarChar, 100);

            prID.Value = this.MOWAID;
            prName.Value = this.MOWAName;
            prAge.Value = this.MOWAAge;
            prSex.Value = this.MOWASex;
            prDescription.Value = this.MOWADetails;

            if (con.State != ConnectionState.Open)
                con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }
    }
}