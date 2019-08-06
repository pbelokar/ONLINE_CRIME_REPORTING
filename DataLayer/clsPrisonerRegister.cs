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

        private int _PrisonerID;
        private int _ChargeSheetNo;
        private String _NickName;
        private String _TypeofCrime;
        private String _FamilyMembers;
        private String _IdentificationMark;
        private String _Height;
        private int _Weight;
        private String _Color;

        DataConnection dc = new DataConnection();

        public int PrisonerID { get => _PrisonerID; }
        public int ChargeSheetNo { get => _ChargeSheetNo; set => _ChargeSheetNo = value; }
        public string NickName { get => _NickName; set => _NickName = value; }
        public string TypeofCrime { get => _TypeofCrime; set => _TypeofCrime = value; }
        public string FamilyMembers { get => _FamilyMembers; set => _FamilyMembers = value; }
        public string IdentificationMark { get => _IdentificationMark; set => _IdentificationMark = value; }
        public string Height { get => _Height; set => _Height = value; }
        public int Weight { get => _Weight; set => _Weight = value; }
        public string Color { get => _Color; set => _Color = value; }


        public Boolean AddPrisoner()
        {
            string SQL = "CriminalRecordPrisonerRegister";
            SqlConnection con = dc.getConnection();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prPrisonerID = cmd.Parameters.Add("@PrisonerID", SqlDbType.Int);
            SqlParameter prChargeSheetNo = cmd.Parameters.Add("@ChargeSheetNo", SqlDbType.Int);
            SqlParameter prNickName = cmd.Parameters.Add("@NickName", SqlDbType.VarChar, 100);
            SqlParameter prTypeofCrime = cmd.Parameters.Add("@TypeofCrime", SqlDbType.VarChar, 100);
            SqlParameter prFamilyMembers = cmd.Parameters.Add("@FamilyMembers", SqlDbType.VarChar, 100);
            SqlParameter prIdentificationMark = cmd.Parameters.Add("@IdentificationMark", SqlDbType.VarChar, 50);
            SqlParameter prHeight = cmd.Parameters.Add("@Height", SqlDbType.VarChar, 50);
            SqlParameter prWeight = cmd.Parameters.Add("@Weight", SqlDbType.Int);
            SqlParameter prColor = cmd.Parameters.Add("@Color", SqlDbType.VarChar, 50);

            prPrisonerID.Value = this.PrisonerID;
            prChargeSheetNo.Value = this.ChargeSheetNo;
            prNickName.Value = this.NickName;
            prTypeofCrime.Value = this.TypeofCrime;
            prFamilyMembers.Value = this.FamilyMembers;
            prIdentificationMark.Value = this.IdentificationMark;
            prHeight.Value = this.Height;
            prWeight.Value = this.Weight;
            prColor.Value = this.Color;


            if (con.State != ConnectionState.Open)
                con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            return true;

        }

    }
}