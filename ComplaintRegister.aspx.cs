using CriminalRecordManagement.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CriminalRecordManagement
{
    public partial class ComplaintRegister : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                displayComplaintCount();
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

        protected void btnSave_Click(object sender, EventArgs e)
        {
            clsComplaintRegister complaintRegister = new clsComplaintRegister();
            complaintRegister.COREName = txtName.Value;
            complaintRegister.COREOccupation = txtOccupation.Value;
            complaintRegister.CORESuspectDetails = txtDetailsofSuspect.Value;
            complaintRegister.COREAge = Convert.ToInt32(txtAge.Value);
            complaintRegister.CORESex = txtSex.Value;
            complaintRegister.COREDateOfRegistration = Convert.ToDateTime(txtComplaintDate.Value);
            complaintRegister.CORENationality = txtNationality.Value;

            try
            {
                complaintRegister.AddComplaint();
                displayComplaintCount();
            }
            catch (Exception ex)
            {

                throw;
            }

            ClearAllTextBox();
            lblMessage.Text = "Complaint registered successfully.";

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllTextBox();
        }

        public void ClearAllTextBox()
        {

            txtName.Value = "";
            txtOccupation.Value = "";
            txtDetailsofSuspect.Value = "";
            txtAge.Value = "";
            txtSex.Value = "";
            txtComplaintDate.Value = "";
            txtNationality.Value = "";
        }

        public void displayComplaintCount()
        {
            clsComplaintRegister count = new clsComplaintRegister();
            txtComplaintNo.Value = count.getComplaintCount().ToString();
        }
    }
}