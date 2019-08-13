using CriminalRecordManagement.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CriminalRecordManagement
{
    public partial class ChargeSheet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                displayChargeSheetCount();
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
            clsChargeSheet chargeSheet = new clsChargeSheet();
            chargeSheet.CHSHPoliceStation = txtPoliceStation.Value;
            chargeSheet.CHSHDateOfRegister = Convert.ToDateTime(txtDateOfRegister.Value);
            chargeSheet.CHSHFIRNo = Convert.ToInt32(txtFIRNo.Value);
            chargeSheet.CHSHPlace = txtPlace.Value;

            try
            {
                chargeSheet.AddChargeSheet();
                displayChargeSheetCount();
            }
            catch (Exception ex)
            {

                throw;
            }

            ClearAllTextBox();
            lblMessage.Text = "Charge Sheet has been created successfully.";
        }

        public void ClearAllTextBox()
        {
            txtDateOfRegister.Value = "";
            txtPlace.Value = "";
            txtPoliceStation.Value = "";
            txtFIRNo.Value = "";
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllTextBox();
        }

        public void displayChargeSheetCount()
        {
            clsChargeSheet count = new clsChargeSheet();
            txtChargeSheetNo.Value = count.getChargeSheetCount().ToString();
        }
    }
}