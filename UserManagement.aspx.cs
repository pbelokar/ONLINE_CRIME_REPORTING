using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CriminalRecordManagement.DataLayer;

namespace CriminalRecordManagement
{
    public partial class UserManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                checkUser();
                BindData();
            }
        }

        public void BindData()
        {
            clsUserManagement dcUsers = new clsUserManagement();
            DataSet dsUsers = new DataSet();
            dsUsers  = dcUsers.getAllUser();

            grdUser.DataSource = dsUsers;
            grdUser.DataBind();

        }

        public bool checkUser()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Session["userid"])))
            {
                Response.Redirect("Login.aspx?url=" + Server.UrlEncode(Request.Url.AbsoluteUri));
            }

            return true;

        }
    }
}