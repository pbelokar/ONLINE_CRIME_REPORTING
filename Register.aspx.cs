using CriminalRecordManagement.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CriminalRecordManagement
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            clsUserManagement newuser = new clsUserManagement();
            newuser.FirstName = txtfirstName.Text;
            newuser.LastName = txtlastname.Text;
            newuser.Password = txtpassword.Text;
            newuser.UserName = txtusername.Text;

            try
            {
                newuser.AddUser(newuser);
            }
            catch (Exception ex)
            {

                throw;
            }

            ClearAllTextBox();

            lblMessage.Text = "User has been created successfully.";
            lblContinueLogin.Text = "Continue to <a href=\"Login\">Login</a>";

        }

        public void ClearAllTextBox()
        {
            txtfirstName.Text = "";
            txtlastname.Text = "";
            txtusername.Text = "";
            txtpassword.Text = "";
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllTextBox();
        }
    }
}