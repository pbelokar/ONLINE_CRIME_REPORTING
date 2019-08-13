using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CriminalRecordManagement.DataLayer
{
    public class clsComplaintRegister
    {
        private int _CORENo;  
        private string _COREName;
        private string _COREOccupation;
        private string _CORESuspectDetails;
        private int _COREAge;
        private string _CORESex;
        private DateTime _COREDateOfRegistration;
        private string _CORENationality;
        DataConnection dc = new DataConnection();

        public int CORENo { get => _CORENo;}
        public string COREName { get => _COREName; set => _COREName = value; }
        public string COREOccupation { get => _COREOccupation; set => _COREOccupation = value; }
        public string CORESuspectDetails { get => _CORESuspectDetails; set => _CORESuspectDetails = value; }
        public int COREAge { get => _COREAge; set => _COREAge = value; }
        public string CORESex { get => _CORESex; set => _CORESex = value; }
        public DateTime COREDateOfRegistration { get => _COREDateOfRegistration; set => _COREDateOfRegistration = value; }
        public string CORENationality { get => _CORENationality; set => _CORENationality = value; }

        public Boolean AddComplaint()
        {
            string SQL = "CriminalRecordComplaintRegister";
            SqlConnection con = dc.getConnection();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prcmpName = cmd.Parameters.Add("@COREName", SqlDbType.VarChar, 100);
            SqlParameter prcmpOccupation = cmd.Parameters.Add("@COREOccupation", SqlDbType.VarChar, 100);
            SqlParameter prcmpDetailsofSuspect = cmd.Parameters.Add("@CORESuspectDetails", SqlDbType.VarChar, 100);
            SqlParameter prcmpAge = cmd.Parameters.Add("@COREAge", SqlDbType.Int);
            SqlParameter prcmpSex = cmd.Parameters.Add("@CORESex", SqlDbType.VarChar, 100);
            SqlParameter prcmpDate = cmd.Parameters.Add("@COREDateOfRegistration", SqlDbType.DateTime);
            SqlParameter prcmdNationality = cmd.Parameters.Add("@CORENationality", SqlDbType.VarChar, 100);

            prcmpName.Value = this.COREName;
            prcmpOccupation.Value = this.COREOccupation;
            prcmpDetailsofSuspect.Value = this.CORESuspectDetails;
            prcmpAge.Value = this.COREAge;
            prcmpSex.Value = this.CORESex;
            prcmpDate.Value = this.COREDateOfRegistration;
            prcmdNationality.Value = this.CORENationality;

            if (con.State != ConnectionState.Open)
                con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }

        public int getComplaintCount()
        {
            int ComplaintCount = 1;
            //sqlComm2.ExecuteScalar()

            DataConnection con = new DataConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dc.getConnection();
            cmd.CommandText = "SELECT max( [CORENo]) + 1 FROM [dbo].[tblComplaintRegistration]";

            object retuvalue = cmd.ExecuteScalar();
            if (retuvalue != DBNull.Value)
            {
                ComplaintCount = Convert.ToInt32(retuvalue);
            }
            return ComplaintCount;
        }
    }
}