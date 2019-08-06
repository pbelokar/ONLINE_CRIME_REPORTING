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
        private string pmId;
        private int pmFIRNo;
        private string pmResultofPostMortem;
        private string pmSex;
        private string pmDateofDeath;
        private string pmDescriptionofCase;
        private string pmHouseName;
        private string pmDrName;
        private string pmPoliceStation;
        DataConnection dc = new DataConnection();

        public string PmId { get => pmId; }
        public int PmFIRNo { get => pmFIRNo; set => pmFIRNo = value; }
        public string PmResultofPostMortem { get => pmResultofPostMortem; set => pmResultofPostMortem = value; }
        public string PmSex { get => pmSex; set => pmSex = value; }
        public string PmDateofDeath { get => pmDateofDeath; set => pmDateofDeath = value; }
        public string PmDescriptionofCase { get => pmDescriptionofCase; set => pmDescriptionofCase = value; }
        public string PmHouseName { get => pmHouseName; set => pmHouseName = value; }
        public string PmDrName { get => pmDrName; set => pmDrName = value; }
        public string PmPoliceStation { get => pmPoliceStation; set => pmPoliceStation = value; }

        public Boolean AddRecPostMortem(clsPostMortem postmortem)

        {
            string SQL = "CriminalRecordPostMortem";
            SqlConnection con = dc.getConnection();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramFIRNo = cmd.Parameters.Add("@pmFIRNo", SqlDbType.VarChar, 50);
            SqlParameter paramResultofPostMortem = cmd.Parameters.Add("@pmResultofPostMortem", SqlDbType.VarChar, 100);
            SqlParameter paramSex = cmd.Parameters.Add("@pmSex", SqlDbType.VarChar, 10);
            SqlParameter paramDateofDeath = cmd.Parameters.Add("@pmDateofDeath", SqlDbType.DateTime);
            SqlParameter paramDescriptionofCase = cmd.Parameters.Add("@pmDescriptionofCase", SqlDbType.VarChar, 100);
            SqlParameter paramHouseName = cmd.Parameters.Add("@pmHouseName", SqlDbType.VarChar, 100);
            SqlParameter paramDrName = cmd.Parameters.Add("@pmDrName", SqlDbType.VarChar, 100);
            SqlParameter paramPoliceStation = cmd.Parameters.Add("@pmPoliceStation", SqlDbType.VarChar, 100);

            paramFIRNo.Value = postmortem.PmFIRNo;
            paramResultofPostMortem.Value = postmortem.pmResultofPostMortem;
            paramSex.Value = postmortem.pmSex;
            paramDateofDeath.Value = postmortem.pmDateofDeath;
            paramDescriptionofCase.Value = postmortem.pmDescriptionofCase;
            paramHouseName.Value = postmortem.pmHouseName;
            paramDrName.Value = postmortem.pmDrName;
            paramPoliceStation.Value = postmortem.PmPoliceStation;


            if (con.State != ConnectionState.Open)
                con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }

    }
}