using CriminalRecordManagement.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CriminalRecordManagement
{
    public partial class FIRRegister : System.Web.UI.Page
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
            clsFIRRegister fir = new clsFIRRegister();

            fir.FIRComplaintNo = Convert.ToInt32(txtComplaintNo.Text);
            fir.FIRDate = Convert.ToDateTime(txtDate.Text);
            fir.FIRTypeofInformation = txtTypeofInformation.Text;
            fir.FIRPlaceofOccurance = txtPlaceofOccurance.Text;
            fir.FIRForeignLocal = txtForeignLocal.Text;
            fir.FIRAct = txtAct.Text;
            fir.FIRDistrict = txtDistrict.Text;
            fir.FIRInformationAddress = txtInformantAddress.Text;
            fir.FIRPassportNo = txtPassportNo.Text;
            fir.FIRPoliceOfficer = txtPoliceOfficer.Text;
            fir.FIRReceivedTime = Convert.ToDateTime(txtReceivedTime.Text);
            fir.FIRInformationReceived = txtInformationReceived.Text;

            try
            {
                fir.AddFIR();
            }
            catch (Exception ex)
            {
                throw;
            }

            ClearAll();
            lblMessage.Text = "FIR has been registered successfully.";

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        public void ClearAll()
        {
            txtComplaintNo.Text = "";
            txtDate.Text = "";
            txtTypeofInformation.Text = "";
            txtPlaceofOccurance.Text = "";
            txtForeignLocal.Text = "";
            txtAct.Text = "";
            txtDistrict.Text = "";
            txtInformantAddress.Text = "";
            txtPassportNo.Text = "";
            txtPoliceOfficer.Text = "";
            txtReceivedTime.Text = "";
            txtInformationReceived.Text = "";

        }
    }
}