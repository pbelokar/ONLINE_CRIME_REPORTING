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
            clsCriminalRegistration crmnl = new clsCriminalRegistration();
            crmnl.CriminalName = txtCriminalName.Text;
            crmnl.CriminalNickName = txtcrNickName.Text;
            crmnl.Age = Convert.ToInt32(txtAge.Text);
            crmnl.Occupation = txtOccupation.Text;
            crmnl.CrimeType = txtCrimeType.Text;
            crmnl.Address = txtAddress.Text;
            crmnl.MostWanted = Convert.ToBoolean(Convert.ToInt32(rdmostWated.SelectedValue));

            try
            {
                crmnl.SaveCriminalRegister(crmnl);
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
            txtCriminalNo.Text = "";
            txtCriminalName.Text = "";
            txtCriminalName.Text = "";
            txtcrNickName.Text = "";
            txtAge.Text = "";
            txtOccupation.Text = "";
            txtCrimeType.Text = "";
            txtAddress.Text = "";
            rdmostWated.SelectedValue = default;

        }
    }
}