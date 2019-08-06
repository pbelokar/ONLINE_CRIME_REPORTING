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
            prisonerRegister.ChargeSheetNo = Convert.ToInt32(txtChargeSheetNo.Text);
            prisonerRegister.NickName = txtNickName.Text;
            prisonerRegister.TypeofCrime = txtTypeofCrime.Text;
            prisonerRegister.FamilyMembers = txtFamilyMember.Text;
            prisonerRegister.IdentificationMark = txtIdentificationMark.Text;
            prisonerRegister.Height = txtHeight.Text;
            prisonerRegister.Weight = Convert.ToInt32(txtWeight.Text);
            prisonerRegister.Color = txtColor.Text;

            try
            {

                prisonerRegister.AddPrisoner();

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
            txtChargeSheetNo.Text = "";
            txtNickName.Text = "";
            txtTypeofCrime.Text = "";
            txtFamilyMember.Text = "";
            txtIdentificationMark.Text = "";
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtColor.Text = "";

        }
    }
}