using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CriminalRecordManagement
{
    public partial class CriminalRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                checkUser();
                FillRadioButton();
            }
        }

        public void FillRadioButton()
        {
            rdmostWated.Items.Add(new ListItem("Yes", "1"));
            rdmostWated.Items.Add(new ListItem("No", "0"));
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllTextBox();
        }

        public void ClearAllTextBox()
        {
            txtCriminalNo.Text = "";
            txtCriminalName.Text = "";

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