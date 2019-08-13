using CriminalRecordManagement.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CriminalRecordManagement
{
    public partial class MostWanted : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                checkUser();
            }
        }

        public bool checkUser()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Session["userid"])))
            {
                Response.Redirect("Login.aspx?url=" + Server.UrlEncode(Request.Url.AbsoluteUri));
            }

            return true;

        }

        public void clearAll()
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            clsMostWanted mostWanted = new clsMostWanted();
            mostWanted.MOWAID = Convert.ToInt32(txtID.Value);
            mostWanted.MOWAName = txtName.Value;
            mostWanted.MOWAAge = Convert.ToInt32(txtAge.Value);
            mostWanted.MOWASex = txtSex.Value;
            mostWanted.MOWADetails = txtDescription.Value;

            try
            {
                mostWanted.AddMostWanted();
            }
            catch (Exception ex)
            {

                throw;
            }

            ClearAll();

            lblMessage.Text = "Most Wanted record has been added successfully.";
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        public void ClearAll()
        {
            txtID.Value = "";
            txtName.Value = "";
            txtAge.Value = "";
            txtSex.Value = "";
            txtDescription.Value = "";
        }
    }
}