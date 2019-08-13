using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CriminalRecordManagement.DataLayer;

namespace CriminalRecordManagement
{
    public partial class CriminalRegister : System.Web.UI.Page
    {
        public bool checkUser()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Session["userid"])))
            {
                Response.Redirect("Login.aspx?url=" + Server.UrlEncode(Request.Url.AbsoluteUri));
            }

            return true;

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                checkUser();
                displayCriminalCount();
                //FillRadioButton();
            }

        }

        //public void FillRadioButton()
        //{
        //    rdmostWated.Items.Add(new ListItem("Yes", "1"));
        //    rdmostWated.Items.Add(new ListItem("No", "0"));
        //}

        protected void btnSave_Click(object sender, EventArgs e)
        {
            clsCriminalRegistration crmnl = new clsCriminalRegistration();
            crmnl.CRREName = txtCriminalName.Value;
            crmnl.CRRENickName = txtcrNickName.Value;
            crmnl.CRREAge = Convert.ToInt32(txtAge.Value);
            crmnl.CRRECrimeType = txtCrimeType.Value;
            crmnl.CRREAddress = txtAddress.Value;
            crmnl.CRREMostWanted = Convert.ToBoolean(rdmostWatedYes.Checked ? 1 : 0);

            try
            {
                crmnl.SaveCriminalRegister(crmnl);
                displayCriminalCount();
            }
            catch (Exception ex)
            {
                throw;
            }

            ClearAllTextBox();

            lblMessage.Text = "The Record has been created successfully.";
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllTextBox();
        }

        public void ClearAllTextBox()
        {

            txtCriminalName.Value = "";
            txtcrNickName.Value = "";
            txtAge.Value = "";
            txtCrimeType.Value = "";
            txtAddress.Value = "";
        }

        public void displayCriminalCount()
        {
            clsCriminalRegistration count = new clsCriminalRegistration();
            txtCriminalNo.Value = count.getCriminalCount().ToString();
        }
    }
}