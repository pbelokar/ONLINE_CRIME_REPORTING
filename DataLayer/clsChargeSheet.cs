using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CriminalRecordManagement.DataLayer
{
    public class clsChargeSheet
    {
        private int chargeSheetNo;
        private string csNameofPoliceStation;
        private DateTime csDate;
        private int csFIRNo;
        private string csDistrict;
        DataConnection dc = new DataConnection();

        public int ChargeSheetNo { get => chargeSheetNo; }
        public string CsNameofPoliceStation { get => csNameofPoliceStation; set => csNameofPoliceStation = value; }
        public DateTime CsDate { get => csDate; set => csDate = value; }
        public int CsFIRNo { get => csFIRNo; set => csFIRNo = value; }
        public string CsDistrict { get => csDistrict; set => csDistrict = value; }

        public Boolean AddChargeSheet()
        {
            string SQL = "CriminalRecordChargeSheet";
            SqlConnection con = dc.getConnection();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter prNameofPoliceStation = cmd.Parameters.Add("@csNameofPoliceStation", SqlDbType.VarChar, 100);
            SqlParameter prDate = cmd.Parameters.Add("@csDate", SqlDbType.DateTime);
            SqlParameter prFIRNo = cmd.Parameters.Add("@csFIRNo", SqlDbType.Int); 
            SqlParameter prDistrict = cmd.Parameters.Add("@csDistrict", SqlDbType.VarChar, 100);

            prNameofPoliceStation.Value = this.CsNameofPoliceStation;
            prDate.Value = this.CsDate;
            prFIRNo.Value = this.CsFIRNo;
            prDistrict.Value = this.csDistrict;



            if (con.State != ConnectionState.Open)
                con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            return true;

        }

        public int getChargeSheetCount()
        {
            int chargesheetCount = 1;
            //sqlComm2.ExecuteScalar()

            DataConnection con = new DataConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dc.getConnection();
            cmd.CommandText = "SELECT max( [ChargeSheetNo]) + 1 FROM [dbo].[tblChargeSheet]";

            object retuvalue = cmd.ExecuteScalar();
            if (retuvalue != DBNull.Value)
            {
                chargesheetCount = Convert.ToInt32(retuvalue);
            }
            return chargesheetCount;
        }
    }
}