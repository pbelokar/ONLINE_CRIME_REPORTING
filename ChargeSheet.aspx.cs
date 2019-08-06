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
            chargeSheet.CsNameofPoliceStation = txtNameofPoliceStation.Text;
            chargeSheet.CsDate = Convert.ToDateTime(txtDate.Text);
            chargeSheet.CsFIRNo = Convert.ToInt32(txtFIRNo.Text);
            chargeSheet.CsDistrict = txtDistrict.Text;

            try
            {
                chargeSheet.AddChargeSheet();
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
            txtDate.Text = "";
            txtDistrict.Text = "";
            txtNameofPoliceStation.Text = "";
            txtFIRNo.Text = "";
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllTextBox();
        }
    }
}