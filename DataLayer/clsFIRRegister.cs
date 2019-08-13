using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CriminalRecordManagement.DataLayer
{
    public class clsFIRRegister
    {
        private int _FIRENo;
        private int _FIRECORENo;
        private DateTime _FIREDateOfFIR;
        private string _FIREInformationType;
        private string _FIREPlace;
        private string _FIRENationality;
        private string _FIREActionDone;
        private string _FIREInformantAddress;
        private string _FIREOnDutyOfficer;
        private DateTime _FIRETimeReceived;
        private string _FIREReceivedInformation;


        DataConnection dc = new DataConnection();

        public int FIRENo { get => _FIRENo; }
        public int FIRECORENo { get => _FIRECORENo; set => _FIRECORENo = value; }
        public DateTime FIREDateOfFIR { get => _FIREDateOfFIR; set => _FIREDateOfFIR = value; }
        public string FIREInformationType { get => _FIREInformationType; set => _FIREInformationType = value; }
        public string FIREPlace { get => _FIREPlace; set => _FIREPlace = value; }
        public string FIRENationality { get => _FIRENationality; set => _FIRENationality = value; }
        public string FIREActionDone { get => _FIREActionDone; set => _FIREActionDone = value; }
        public string FIREInformantAddress { get => _FIREInformantAddress; set => _FIREInformantAddress = value; }
        public string FIREOnDutyOfficer { get => _FIREOnDutyOfficer; set => _FIREOnDutyOfficer = value; }
        public DateTime FIRETimeReceived { get => _FIRETimeReceived; set => _FIRETimeReceived = value; }
        public string FIREReceivedInformation { get => _FIREReceivedInformation; set => _FIREReceivedInformation = value; }

        public Boolean AddFIR()
        {
            string SQL = "CriminalRecordFIRRegister";
            SqlConnection con = dc.getConnection();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prFIRComplaintNo = cmd.Parameters.Add("@FIRECORENo", SqlDbType.Int);
            SqlParameter prFIRDate = cmd.Parameters.Add("@FIREDateOfFIR", SqlDbType.DateTime);
            SqlParameter prFIRTypeofInformation = cmd.Parameters.Add("@FIREInformationType", SqlDbType.VarChar, 100);
            SqlParameter prFIRPlaceofOccurance = cmd.Parameters.Add("@FIREPlace", SqlDbType.VarChar, 100);
            SqlParameter prFIRForeignLocal = cmd.Parameters.Add("@FIRENationality", SqlDbType.VarChar, 100);
            SqlParameter prFIRAct = cmd.Parameters.Add("@FIREActionDone", SqlDbType.VarChar, 100);
            SqlParameter prFIRInformationAddress = cmd.Parameters.Add("@FIREInformantAddress", SqlDbType.VarChar, 100);
            SqlParameter prFIRPoliceOfficer = cmd.Parameters.Add("@FIREOnDutyOfficer", SqlDbType.VarChar, 100);
            SqlParameter prFIRReceivedTime = cmd.Parameters.Add("@FIRETimeReceived", SqlDbType.DateTime);
            SqlParameter prFIRInformationReceived = cmd.Parameters.Add("@FIREReceivedInformation", SqlDbType.VarChar, 100);


            prFIRComplaintNo.Value = this.FIRECORENo;
            prFIRDate.Value = this.FIREDateOfFIR;
            prFIRTypeofInformation.Value = this.FIREInformationType;
            prFIRPlaceofOccurance.Value = this.FIREPlace;
            prFIRForeignLocal.Value = this.FIRENationality;
            prFIRAct.Value = this.FIREActionDone;
            prFIRInformationAddress.Value = this.FIREInformantAddress;
            prFIRPoliceOfficer.Value = this.FIREOnDutyOfficer;
            prFIRReceivedTime.Value = this.FIRETimeReceived;
            prFIRInformationReceived.Value = this.FIREReceivedInformation;

            if (con.State != ConnectionState.Open)
                con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }

        public int getFirCount()
        {
            int firCount = 1;
            //sqlComm2.ExecuteScalar()

            DataConnection con = new DataConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dc.getConnection();
            cmd.CommandText = "SELECT max( [FIRENo]) + 1 FROM [dbo].[tblFIRLaunching]";

            object retuvalue = cmd.ExecuteScalar();
            if (retuvalue != DBNull.Value)
            {
                firCount = Convert.ToInt32(retuvalue);
            }

            return firCount;
        }
    }
}