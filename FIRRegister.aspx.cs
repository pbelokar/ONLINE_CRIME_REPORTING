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

            fir.FIRECORENo = Convert.ToInt32(txtComplaintNo.Value);
            fir.FIREDateOfFIR = Convert.ToDateTime(txtDate.Value);
            fir.FIREInformationType = txtTypeofInformation.Value;
            fir.FIREPlace = txtPlaceofOccurance.Value;
            fir.FIRENationality = txtForeignLocal.Value;
            fir.FIREActionDone = txtAct.Value;
            fir.FIREInformantAddress = txtInformantAddress.Value;
            fir.FIREOnDutyOfficer = txtPoliceOfficer.Value;
            fir.FIRETimeReceived = Convert.ToDateTime(txtReceivedTime.Value);
            fir.FIREReceivedInformation = txtInformationReceived.Value;

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
            txtInformantAddress.Value = "";
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