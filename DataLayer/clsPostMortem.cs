using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CriminalRecordManagement.DataLayer
{
    public class clsPostMortem
    {
        private string _POMOId;
        private int _POMOFIRNo;
        private string _POMOInvestigationResult;
        private string _POMOSex;
        private string _POMODeathDate;
        private string _POMOCaseDescription;
        private string _POMODoctorName;
        private string _POMOPoliceStation;
        DataConnection dc = new DataConnection();

        public string POMOId { get => _POMOId; }
        public int POMOFIRNo { get => _POMOFIRNo; set => _POMOFIRNo = value; }
        public string POMOInvestigationResult { get => _POMOInvestigationResult; set => _POMOInvestigationResult = value; }
        public string POMOSex { get => _POMOSex; set => _POMOSex = value; }
        public string POMODeathDate { get => _POMODeathDate; set => _POMODeathDate = value; }
        public string POMOCaseDescription { get => _POMOCaseDescription; set => _POMOCaseDescription = value; }
        public string POMODoctorName { get => _POMODoctorName; set => _POMODoctorName = value; }
        public string POMOPoliceStation { get => _POMOPoliceStation; set => _POMOPoliceStation = value; }

        public Boolean AddRecPostMortem(clsPostMortem postmortem)

        {
            string SQL = "CriminalRecordPostMortem";
            SqlConnection con = dc.getConnection();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramFIRNo = cmd.Parameters.Add("@POMOFIRNo", SqlDbType.VarChar, 50);
            SqlParameter paramResultofPostMortem = cmd.Parameters.Add("@POMOInvestigationResult", SqlDbType.VarChar, 100);
            SqlParameter paramSex = cmd.Parameters.Add("@POMOSex", SqlDbType.VarChar, 10);
            SqlParameter paramDateofDeath = cmd.Parameters.Add("@POMODeathDate", SqlDbType.DateTime);
            SqlParameter paramDescriptionofCase = cmd.Parameters.Add("@POMOCaseDescription", SqlDbType.VarChar, 100);
            SqlParameter paramDrName = cmd.Parameters.Add("@POMODoctorName", SqlDbType.VarChar, 100);
            SqlParameter paramPoliceStation = cmd.Parameters.Add("@POMOPoliceStation", SqlDbType.VarChar, 100);

            paramFIRNo.Value = postmortem.POMOFIRNo;
            paramResultofPostMortem.Value = postmortem.POMOInvestigationResult;
            paramSex.Value = postmortem.POMOSex;
            paramDateofDeath.Value = postmortem.POMODeathDate;
            paramDescriptionofCase.Value = postmortem.POMOCaseDescription;
            paramDrName.Value = postmortem.POMODoctorName;
            paramPoliceStation.Value = postmortem.POMOPoliceStation;


            if (con.State != ConnectionState.Open)
                con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }

        public int getPostMortemCount()
        {
            int postmortemCount = 1;
            //sqlComm2.ExecuteScalar()

            DataConnection con = new DataConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dc.getConnection();
            cmd.CommandText = "SELECT max( [POMOId]) + 1 FROM [dbo].[tblPostMortemRegister]";

            object retuvalue = cmd.ExecuteScalar();
            if (retuvalue != DBNull.Value)
            {
                postmortemCount = Convert.ToInt32(retuvalue);
            }
            return postmortemCount;
        }


    }
}