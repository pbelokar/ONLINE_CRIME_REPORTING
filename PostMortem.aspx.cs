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
            postmortem.PmFIRNo = Convert.ToInt32(txtFirNo.Text);
            postmortem.PmResultofPostMortem = txtResultofMortem.Text;
            postmortem.PmSex = txtSex.Text;
            postmortem.PmDateofDeath = txtDateofDeath.Text;
            postmortem.PmDescriptionofCase = txtDescriptionofCase.Text;
            postmortem.PmHouseName = txtHouseName.Text;
            postmortem.PmDrName = txtDrName.Text;
            postmortem.PmPoliceStation = txtPoliceStation.Text;

            try
            {
                Boolean success = postmortem.AddRecPostMortem(postmortem);
            }
            catch (Exception ex)
            {
                throw;
            }


        }
    }
}