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
            complaintRegister.CmpName = txtName.Text;
            complaintRegister.CmpOccupation = txtOccupation.Text;
            complaintRegister.CmpDetailsofSuspect = txtDetailsofSuspect.Text;
            complaintRegister.CmpAge = Convert.ToInt32(txtAge.Text);
            complaintRegister.CmpSex = txtSex.Text;
            complaintRegister.CmpFatherHusbandName = txtFatherHusbandName.Text;
            complaintRegister.CmpDate = Convert.ToDateTime(txtComplaintDate.Text);
            complaintRegister.CmdNationality = txtNationality.Text;

            try
            {
                complaintRegister.AddComplaint();
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

            txtName.Text = "";
            txtOccupation.Text = "";
            txtDetailsofSuspect.Text = "";
            txtAge.Text = "";
            txtSex.Text = "";
            txtFatherHusbandName.Text = "";
            txtComplaintDate.Text = "";
            txtNationality.Text = "";
        }
    }
}