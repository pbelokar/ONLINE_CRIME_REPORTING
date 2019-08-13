using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CriminalRecordManagement.DataLayer
{
    public class clsCriminalRegistration
    {
        private int _CRREID;
        private string _CRREName;
        private string _CRRENickName;
        private int _CRREAge;
        private string _CRRECrimeType;
        private string _CRREAddress;
        private Boolean _CRREMostWanted;

        DataConnection dc = new DataConnection();

        public int CRREID { get => _CRREID; }
        public string CRREName { get => _CRREName; set => _CRREName = value; }
        public string CRRENickName { get => _CRRENickName; set => _CRRENickName = value; }
        public int CRREAge { get => _CRREAge; set => _CRREAge = value; }
        public string CRRECrimeType { get => _CRRECrimeType; set => _CRRECrimeType = value; }
        public string CRREAddress { get => _CRREAddress; set => _CRREAddress = value; }
        public bool CRREMostWanted { get => _CRREMostWanted; set => _CRREMostWanted = value; }

        public DataSet getAllCriminalRecords()
        {
            DataSet ds = new DataSet();
            DataConnection con = new DataConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dc.getConnection();
            cmd.CommandText = "SELECT * FROM [dbo].[tblCriminalRegister]";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            da.Fill(ds, "CriminalRegister");
            return ds;
        }

        public Boolean SaveCriminalRegister(clsCriminalRegistration criminalRegistration)
        {
            string SQL = "CriminalRecordCriminalRegister";
            SqlConnection con = dc.getConnection();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prCrName = cmd.Parameters.Add("@CRREName", SqlDbType.VarChar, 50);
            SqlParameter prCrNickName = cmd.Parameters.Add("@CRRENickName", SqlDbType.VarChar, 50);
            SqlParameter prcrAge = cmd.Parameters.Add("@CRREAge ", SqlDbType.Int);
            SqlParameter prcrCrimeType = cmd.Parameters.Add("@CRRECrimeType", SqlDbType.VarChar, 50);
            SqlParameter prcrAddress = cmd.Parameters.Add("@CRREAddress", SqlDbType.VarChar, 50);
            SqlParameter prCrMostWanted = cmd.Parameters.Add("@CRREMostWanted", SqlDbType.Bit);


            prCrName.Value = criminalRegistration.CRREName;
            prCrNickName.Value = criminalRegistration.CRRENickName;
            prcrAge.Value = criminalRegistration.CRREAge;
            prcrCrimeType.Value = criminalRegistration.CRRECrimeType;
            prcrAddress.Value = criminalRegistration.CRREAddress;
            prCrMostWanted.Value = criminalRegistration.CRREMostWanted;
                                 

            if (con.State != ConnectionState.Open)
                con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }

        public int getCriminalCount()
        {
            int criminalCount = 1;
            //sqlComm2.ExecuteScalar()

            DataConnection con = new DataConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dc.getConnection();
            cmd.CommandText = "SELECT max( [CRREID]) + 1 FROM [dbo].[tblCriminalRegistration]";

            object retuvalue = cmd.ExecuteScalar();
            if (retuvalue != DBNull.Value)
            {
                criminalCount = Convert.ToInt32(retuvalue);
            }
            return criminalCount;
        }

    }
}