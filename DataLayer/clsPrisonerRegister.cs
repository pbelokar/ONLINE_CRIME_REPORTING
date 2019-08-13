using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CriminalRecordManagement.DataLayer
{
    public class clsPrisonerRegister
    {

        private int _PRISChShNo;
        private String _PRISCrimeDone;
        private String _PRISIdMark;
        private String _PRISHeight;
        private int _PRISWeight;
        private String _PRISColor;

        DataConnection dc = new DataConnection();

        public int PRISChShNo { get => _PRISChShNo; set => _PRISChShNo = value; }
        public string PRISCrimeDone { get => _PRISCrimeDone; set => _PRISCrimeDone = value; }
        public string PRISIdMark { get => _PRISIdMark; set => _PRISIdMark = value; }
        public string PRISHeight { get => _PRISHeight; set => _PRISHeight = value; }
        public int PRISWeight { get => _PRISWeight; set => _PRISWeight = value; }
        public string PRISColor { get => _PRISColor; set => _PRISColor = value; }

        public Boolean AddPrisoner()
        {
            string SQL = "CriminalRecordPrisonerRegister";
            SqlConnection con = dc.getConnection();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prChargeSheetNo = cmd.Parameters.Add("@PRISChShNo", SqlDbType.Int);
            SqlParameter prTypeofCrime = cmd.Parameters.Add("@PRISCrimeDone", SqlDbType.VarChar, 100);
            SqlParameter prIdentificationMark = cmd.Parameters.Add("@PRISIdMark", SqlDbType.VarChar, 50);
            SqlParameter prHeight = cmd.Parameters.Add("@PRISHeight", SqlDbType.VarChar, 50);
            SqlParameter prWeight = cmd.Parameters.Add("@PRISWeight", SqlDbType.Int);
            SqlParameter prColor = cmd.Parameters.Add("@PRISColor", SqlDbType.VarChar, 50);

            prChargeSheetNo.Value = this.PRISChShNo;
            prTypeofCrime.Value = this.PRISCrimeDone;
            prIdentificationMark.Value = this.PRISIdMark;
            prHeight.Value = this.PRISHeight;
            prWeight.Value = this.PRISWeight;
            prColor.Value = this.PRISColor;


            if (con.State != ConnectionState.Open)
                con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            return true;

        }

        public int getPrisonRegCount()
        {
            int prisonregCount = 1;
            //sqlComm2.ExecuteScalar()

            DataConnection con = new DataConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dc.getConnection();
            cmd.CommandText = "SELECT max( [PRISID]) + 1 FROM [dbo].[tblPrisonerRegistration]";

            object retuvalue = cmd.ExecuteScalar();
            if (retuvalue != DBNull.Value)
            {
                prisonregCount = Convert.ToInt32(retuvalue);
            }
            return prisonregCount;
        }

    }
}