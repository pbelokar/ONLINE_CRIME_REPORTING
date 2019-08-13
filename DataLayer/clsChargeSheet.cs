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
        private int _CHSHNo;
        private string _CHSHPoliceStation;
        private DateTime _CHSHDateOfRegister;
        private int _CHSHFIRNo;
        private string _CHSHPlace;
        DataConnection dc = new DataConnection();

        public int CHSHNo { get => _CHSHNo; }
        public string CHSHPoliceStation { get => _CHSHPoliceStation; set => _CHSHPoliceStation = value; }
        public DateTime CHSHDateOfRegister { get => _CHSHDateOfRegister; set => _CHSHDateOfRegister = value; }
        public int CHSHFIRNo { get => _CHSHFIRNo; set => _CHSHFIRNo = value; }
        public string CHSHPlace { get => _CHSHPlace; set => _CHSHPlace = value; }

        public Boolean AddChargeSheet()
        {
            string SQL = "CriminalRecordChargeSheet";
            SqlConnection con = dc.getConnection();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter prNameofPoliceStation = cmd.Parameters.Add("@CHSHPoliceStation", SqlDbType.VarChar, 100);
            SqlParameter prDate = cmd.Parameters.Add("@CHSHDateOfRegister", SqlDbType.DateTime);
            SqlParameter prFIRNo = cmd.Parameters.Add("@CHSHFIRNo", SqlDbType.Int); 
            SqlParameter prDistrict = cmd.Parameters.Add("@CHSHPlace", SqlDbType.VarChar, 100);

            prNameofPoliceStation.Value = this.CHSHPoliceStation;
            prDate.Value = this.CHSHDateOfRegister;
            prFIRNo.Value = this.CHSHFIRNo;
            prDistrict.Value = this.CHSHPlace;



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
            cmd.CommandText = "SELECT max([CHSHNo]) + 1 FROM [dbo].[tblChargeSheetRegister]";

            object retuvalue = cmd.ExecuteScalar();
            if (retuvalue != DBNull.Value)
            {
                chargesheetCount = Convert.ToInt32(retuvalue);
            }
            return chargesheetCount;
        }
    }
}