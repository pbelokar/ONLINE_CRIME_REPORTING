using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CriminalRecordManagement.DataLayer
{
    public class clsUserManagement
    {
        private int _userId;
        private string _userName;
        private string _password;
        private string _firstName;
        private string _lastName;
        private int _roleId;
        DataConnection dc = new DataConnection();

        public int UserId { get => _userId; set => _userId = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int RoleId { get => _roleId; set => _roleId = value; }

        public int CheckUserDetails(string strusername, string strpassword)
        {
            int strRoleId = -1;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dc.getConnection();
            cmd.CommandText = "select * from [dbo].[tblUsers] where UserName = '" + strusername + "' and Password = '" + strpassword + "' and IsActive = 1";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "users");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    strRoleId = Convert.ToInt32(dr["RoleId"].ToString());
                }
            }

            return strRoleId;
        }

        public DataSet getAllUser()
        {
            DataSet dsUsers = new DataSet();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dc.getConnection();
            cmd.CommandText = "select * from [dbo].[tblUsers]";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            da.Fill(dsUsers, "users");

            return dsUsers;
        }

        public Boolean AddUser(clsUserManagement newuser)
        {
            string SQL = "CriminalRecordRegister";
            SqlConnection con = dc.getConnection();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramUserName = cmd.Parameters.Add("@UserName", SqlDbType.VarChar, 50);
            SqlParameter paramPassword = cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50);
            SqlParameter paramFirstName = cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50);
            SqlParameter paramLastName = cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50);
            paramUserName.Value = newuser.UserName;
            paramPassword.Value = newuser.Password;
            paramFirstName.Value = newuser.FirstName;
            paramLastName.Value = newuser.LastName;

            if (con.State != ConnectionState.Open)
            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            return true;
        
        }

        public Boolean UpdateUser(int isactive)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dc.getConnection();
            cmd.CommandText = "UPDATE [dbo].[tblUsers] SET [IsActive] = "+ isactive + " WHERE UserId = "+ this.UserId;
            cmd.ExecuteNonQuery();
            
            return true;
        }


    }
}