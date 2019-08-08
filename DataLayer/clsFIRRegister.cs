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
        private int _FIRNo;
        private int _FIRComplaintNo;
        private DateTime _FIRDate;
        private string _FIRTypeofInformation;
        private string _FIRPlaceofOccurance;
        private string _FIRForeignLocal;
        private string _FIRAct;
        private string _FIRDistrict;
        private string _FIRInformationAddress;
        private string _FIRPassportNo;
        private string _FIRPoliceOfficer;
        private DateTime _FIRReceivedTime;
        private string _FIRInformationReceived;

        public int FIRNo { get => _FIRNo;}
        public int FIRComplaintNo { get => _FIRComplaintNo; set => _FIRComplaintNo = value; }
        public DateTime FIRDate { get => _FIRDate; set => _FIRDate = value; }
        public string FIRTypeofInformation { get => _FIRTypeofInformation; set => _FIRTypeofInformation = value; }
        public string FIRPlaceofOccurance { get => _FIRPlaceofOccurance; set => _FIRPlaceofOccurance = value; }
        public string FIRForeignLocal { get => _FIRForeignLocal; set => _FIRForeignLocal = value; }
        public string FIRAct { get => _FIRAct; set => _FIRAct = value; }
        public string FIRDistrict { get => _FIRDistrict; set => _FIRDistrict = value; }
        public string FIRInformationAddress { get => _FIRInformationAddress; set => _FIRInformationAddress = value; }
        public string FIRPassportNo { get => _FIRPassportNo; set => _FIRPassportNo = value; }
        public string FIRPoliceOfficer { get => _FIRPoliceOfficer; set => _FIRPoliceOfficer = value; }
        public DateTime FIRReceivedTime { get => _FIRReceivedTime; set => _FIRReceivedTime = value; }
        public string FIRInformationReceived { get => _FIRInformationReceived; set => _FIRInformationReceived = value; }

        DataConnection dc = new DataConnection();

        public Boolean AddFIR()
        {
            string SQL = "CriminalRecordFIRRegister";
            SqlConnection con = dc.getConnection();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prFIRComplaintNo = cmd.Parameters.Add("@FIRComplaintNo", SqlDbType.Int);
            SqlParameter prFIRDate = cmd.Parameters.Add("@FIRDate", SqlDbType.DateTime);
            SqlParameter prFIRTypeofInformation = cmd.Parameters.Add("@FIRTypeofInformation", SqlDbType.VarChar, 100);
            SqlParameter prFIRPlaceofOccurance = cmd.Parameters.Add("@FIRPlaceofOccurance", SqlDbType.VarChar, 100);
            SqlParameter prFIRForeignLocal = cmd.Parameters.Add("@FIRForeignLocal", SqlDbType.VarChar, 100);
            SqlParameter prFIRAct = cmd.Parameters.Add("@FIRAct", SqlDbType.VarChar, 100);
            SqlParameter prFIRDistrict = cmd.Parameters.Add("@FIRDistrict", SqlDbType.VarChar, 100);
            SqlParameter prFIRInformationAddress = cmd.Parameters.Add("@FIRInformationAddress", SqlDbType.VarChar, 100);
            SqlParameter prFIRPassportNo = cmd.Parameters.Add("@FIRPassportNo", SqlDbType.VarChar, 100);
            SqlParameter prFIRPoliceOfficer = cmd.Parameters.Add("@FIRPoliceOfficer", SqlDbType.VarChar, 100);
            SqlParameter prFIRReceivedTime = cmd.Parameters.Add("@FIRReceivedTime", SqlDbType.DateTime);
            SqlParameter prFIRInformationReceived = cmd.Parameters.Add("@FIRInformationReceived", SqlDbType.VarChar, 100);


            prFIRComplaintNo.Value = this.FIRComplaintNo;
            prFIRDate.Value = this.FIRDate;
            prFIRTypeofInformation.Value = this.FIRTypeofInformation;
            prFIRPlaceofOccurance.Value = this.FIRPlaceofOccurance;
            prFIRForeignLocal.Value = this.FIRForeignLocal;
            prFIRAct.Value = this.FIRAct;
            prFIRDistrict.Value = this.FIRDistrict;
            prFIRInformationAddress.Value = this.FIRInformationAddress;
            prFIRPassportNo.Value = this.FIRPassportNo;
            prFIRPoliceOfficer.Value = this.FIRPoliceOfficer;
            prFIRReceivedTime.Value = this.FIRReceivedTime;
            prFIRInformationReceived.Value = this.FIRInformationReceived;

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
            cmd.CommandText = "SELECT max( [FIRNo]) + 1 FROM [dbo].[tblFIRRegister]";

            object retuvalue = cmd.ExecuteScalar();
            if (retuvalue != DBNull.Value)
            {
                firCount = Convert.ToInt32(retuvalue);
            }

            return firCount;
        }
    }
}