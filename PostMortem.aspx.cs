using CriminalRecordManagement.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CriminalRecordManagement
{
    public partial class PostMortem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                displayPostMortemCount();
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
            clsPostMortem postmortem = new clsPostMortem();
            postmortem.POMOFIRNo = Convert.ToInt32(txtFirNo.Value);
            postmortem.POMOInvestigationResult = txtResultofMortem.Value;
            postmortem.POMOSex = txtSex.Value;
            postmortem.POMODeathDate = txtDateofDeath.Value;
            postmortem.POMOCaseDescription = txtDescriptionofCase.Value;
            postmortem.POMODoctorName = txtDrName.Value;
            postmortem.POMOPoliceStation = txtPoliceStation.Value;

            //postmortem.AddRecPostMortem(postmortem);

            try
            {
                Boolean success = postmortem.AddRecPostMortem(postmortem);
                displayPostMortemCount();
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

            txtResultofMortem.Value = "";
            txtSex.Value = "";
            txtDateofDeath.Value = "";
            txtDescriptionofCase.Value = "";
            txtDrName.Value = "";
            txtPoliceStation.Value = "";
            txtFirNo.Value = "";

        }

        public void displayPostMortemCount()
        {
            clsPostMortem count = new clsPostMortem();
            txtPostMortelNo.Value = count.getPostMortemCount().ToString();
        }
    }
}