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
            postmortem.PmFIRNo = Convert.ToInt32(txtFirNo.Value);
            postmortem.PmResultofPostMortem = txtResultofMortem.Value;
            postmortem.PmSex = txtSex.Value;
            postmortem.PmDateofDeath = txtDateofDeath.Value;
            postmortem.PmDescriptionofCase = txtDescriptionofCase.Value;
            postmortem.PmHouseName = txtHouseName.Value;
            postmortem.PmDrName = txtDrName.Value;
            postmortem.PmPoliceStation = txtPoliceStation.Value;

            postmortem.AddRecPostMortem(postmortem);

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
            txtHouseName.Value = "";
            txtDrName.Value = "";
            txtPoliceStation.Value = "";

        }

        public void displayPostMortemCount()
        {
            clsPostMortem count = new clsPostMortem();
            txtPostMortelNo.Value = count.getPostMortemCount().ToString();
        }
    }
}