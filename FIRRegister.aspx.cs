using CriminalRecordManagement.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CriminalRecordManagement
{
    public partial class FIRRegister : System.Web.UI.Page
    {
        private object dc;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                displayFirCount();
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

            fir.FIRComplaintNo = Convert.ToInt32(txtComplaintNo.Value);
            fir.FIRDate = Convert.ToDateTime(txtDate.Value);
            fir.FIRTypeofInformation = txtTypeofInformation.Value;
            fir.FIRPlaceofOccurance = txtPlaceofOccurance.Value;
            fir.FIRForeignLocal = txtForeignLocal.Value;
            fir.FIRAct = txtAct.Value;
            fir.FIRDistrict = txtDistrict.Value;
            fir.FIRInformationAddress = txtInformantAddress.Value;
            fir.FIRPassportNo = txtPassportNo.Value;
            fir.FIRPoliceOfficer = txtPoliceOfficer.Value;
            fir.FIRReceivedTime = Convert.ToDateTime(txtReceivedTime.Value);
            fir.FIRInformationReceived = txtInformationReceived.Value;

            try
            {
                fir.AddFIR();
                displayFirCount();
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
            txtComplaintNo.Value = "";
            txtDate.Value = "";
            txtTypeofInformation.Value = "";
            txtPlaceofOccurance.Value = "";
            txtForeignLocal.Value = "";
            txtAct.Value = "";
            txtDistrict.Value = "";
            txtInformantAddress.Value = "";
            txtPassportNo.Value = "";
            txtPoliceOfficer.Value = "";
            txtReceivedTime.Value = "";
            txtInformationReceived.Value = "";

        }

        public void displayFirCount()
        {
            clsFIRRegister count = new clsFIRRegister();
            txtFirNo.Value = count.getFirCount().ToString();
        }
    }
}