using CriminalRecordManagement.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CriminalRecordManagement
{
    public partial class PrisonerRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                displayPrisonRegCount();
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

            clsPrisonerRegister prisonerRegister = new clsPrisonerRegister();
            prisonerRegister.ChargeSheetNo = Convert.ToInt32(txtChargeSheetNo.Value);
            prisonerRegister.NickName = txtNickName.Value;
            prisonerRegister.TypeofCrime = txtTypeofCrime.Value;
            prisonerRegister.FamilyMembers = txtFamilyMember.Value;
            prisonerRegister.IdentificationMark = txtIdentificationMark.Value;
            prisonerRegister.Height = txtHeight.Value;
            prisonerRegister.Weight = Convert.ToInt32(txtWeight.Value);
            prisonerRegister.Color = txtColor.Value;

            try
            {

                prisonerRegister.AddPrisoner();
                displayPrisonRegCount();

            }
            catch (Exception ex)
            {

                throw;
            }

            ClearAll();

            lblMessage.Text = "Prisoner record has been added successfully.";


        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }

        public void ClearAll()
        {
            txtChargeSheetNo.Value = "";
            txtNickName.Value = "";
            txtTypeofCrime.Value = "";
            txtFamilyMember.Value = "";
            txtIdentificationMark.Value = "";
            txtHeight.Value = "";
            txtWeight.Value = "";
            txtColor.Value = "";

        }

        public void displayPrisonRegCount()
        {
            clsPrisonerRegister count = new clsPrisonerRegister();
            txtPrisonerNo.Value = count.getPrisonRegCount().ToString();
        }
    }
}