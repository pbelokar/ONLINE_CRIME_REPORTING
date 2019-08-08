using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using CriminalRecordManagement.DataLayer;

namespace CriminalRecordManagement
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // txtusername.Value = "username here";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            clsUserManagement um = new clsUserManagement();
            int roleid = um.CheckUserDetails(txtusername.Text, txtPassword.Text);
            if (roleid != -1)
            {
                Session["userid"] = txtusername.Text;

                string ReturnUrl = Convert.ToString(Request.QueryString["url"]);
                if (!string.IsNullOrEmpty(ReturnUrl))
                {
                    Response.Redirect(ReturnUrl);
                }
                else
                {
                    Response.Redirect("default.aspx");
                }
            }
            else
            {
                lblerror.Text = "The username or password is incorrect";
            }

        }
    }
}