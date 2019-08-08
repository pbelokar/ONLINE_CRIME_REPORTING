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
        private int criminalNo;
        private string criminalName;
        private string criminalNickName;
        private int age;
        private string occupation;
        private string crimeType;
        private string address;
        private Boolean mostWanted;

        public int CriminalNo { get => criminalNo; set => criminalNo = value; }
        public string CriminalName { get => criminalName; set => criminalName = value; }
        public string CriminalNickName { get => criminalNickName; set => criminalNickName = value; }
        public int Age { get => age; set => age = value; }
        public string Occupation { get => occupation; set => occupation = value; }
        public string CrimeType { get => crimeType; set => crimeType = value; }
        public string Address { get => address; set => address = value; }
        public Boolean MostWanted { get => mostWanted; set => mostWanted = value; }
        DataConnection dc = new DataConnection();
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

            SqlParameter prCrName = cmd.Parameters.Add("@CrName", SqlDbType.VarChar, 50);
            SqlParameter prCrNickName = cmd.Parameters.Add("@CrNickName", SqlDbType.VarChar, 50);
            SqlParameter prcrAge = cmd.Parameters.Add("@crAge ", SqlDbType.Int);
            SqlParameter prcrOccupation = cmd.Parameters.Add("@crOccupation", SqlDbType.VarChar, 50);
            SqlParameter prcrCrimeType = cmd.Parameters.Add("@crCrimeType", SqlDbType.VarChar, 50);
            SqlParameter prcrAddress = cmd.Parameters.Add("@crAddress", SqlDbType.VarChar, 50);
            SqlParameter prCrMostWanted = cmd.Parameters.Add("@CrMostWanted", SqlDbType.Bit);


            prCrName.Value = criminalRegistration.criminalName;
            prCrNickName.Value = criminalRegistration.criminalNickName;
            prcrAge.Value = criminalRegistration.age;
            prcrOccupation.Value = criminalRegistration.occupation;
            prcrCrimeType.Value = criminalRegistration.crimeType;
            prcrAddress.Value = criminalRegistration.address;
            prCrMostWanted.Value = criminalRegistration.mostWanted;
                                 

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
            cmd.CommandText = "SELECT max( [CriminalID]) + 1 FROM [dbo].[tblCriminalRegister]";

            object retuvalue = cmd.ExecuteScalar();
            if (retuvalue != DBNull.Value)
            {
                criminalCount = Convert.ToInt32(retuvalue);
            }
            return criminalCount;
        }

    }
}