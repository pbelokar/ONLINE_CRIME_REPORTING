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
        private int complaintNo;  
        private string cmpName;
        private string cmpOccupation;
        private string cmpDetailsofSuspect;
        private int cmpAge;
        private string cmpSex;
        private string cmpFatherHusbandName;
        private DateTime cmpDate;
        private string cmdNationality;
        DataConnection dc = new DataConnection();

        public string CmpName { get => cmpName; set => cmpName = value; }
        public string CmpOccupation { get => cmpOccupation; set => cmpOccupation = value; }
        public string CmpDetailsofSuspect { get => cmpDetailsofSuspect; set => cmpDetailsofSuspect = value; }
        public int CmpAge { get => cmpAge; set => cmpAge = value; }
        public string CmpSex { get => cmpSex; set => cmpSex = value; }
        public string CmpFatherHusbandName { get => cmpFatherHusbandName; set => cmpFatherHusbandName = value; }
        public DateTime CmpDate { get => cmpDate; set => cmpDate = value; }
        public string CmdNationality { get => cmdNationality; set => cmdNationality = value; }
        public int ComplaintNo { get => complaintNo; }

        public Boolean AddComplaint()
        {
            string SQL = "CriminalRecordComplaintRegister";
            SqlConnection con = dc.getConnection();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prcmpName = cmd.Parameters.Add("@cmpName", SqlDbType.VarChar, 100);
            SqlParameter prcmpOccupation = cmd.Parameters.Add("@cmpOccupation", SqlDbType.VarChar, 100);
            SqlParameter prcmpDetailsofSuspect = cmd.Parameters.Add("@cmpDetailsofSuspect", SqlDbType.VarChar, 100);
            SqlParameter prcmpAge = cmd.Parameters.Add("@cmpAge", SqlDbType.Int);
            SqlParameter prcmpSex = cmd.Parameters.Add("@cmpSex", SqlDbType.VarChar, 100);
            SqlParameter prcmpFatherHusbandName = cmd.Parameters.Add("@cmpFatherHusbandName", SqlDbType.VarChar, 100);
            SqlParameter prcmpDate = cmd.Parameters.Add("@cmpDate", SqlDbType.DateTime);
            SqlParameter prcmdNationality = cmd.Parameters.Add("@cmdNationality", SqlDbType.VarChar, 100);

            prcmpName.Value = this.cmpName;
            prcmpOccupation.Value = this.CmpOccupation;
            prcmpDetailsofSuspect.Value = this.cmpDetailsofSuspect;
            prcmpAge.Value = this.cmpAge;
            prcmpSex.Value = this.cmpSex;
            prcmpFatherHusbandName.Value = this.cmpFatherHusbandName;
            prcmpDate.Value = this.cmpDate;
            prcmdNationality.Value = this.cmdNationality;

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
            cmd.CommandText = "SELECT max( [ComplaintNo]) + 1 FROM [dbo].[tblComplaintRegister]";

            object retuvalue = cmd.ExecuteScalar();
            if (retuvalue != DBNull.Value)
            {
                ComplaintCount = Convert.ToInt32(retuvalue);
            }
            return ComplaintCount;
        }
    }
}