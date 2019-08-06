using CriminalRecordManagement.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CriminalRecordManagement
{
    public partial class MostWanted : System.Web.UI.Page
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

        public void clearAll()
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            clsMostWanted mostWanted = new clsMostWanted();
            mostWanted.ID = Convert.ToInt32(txtID.Text);
            mostWanted.Name = txtName.Text;
            mostWanted.NickName = txtNickName.Text;
            mostWanted.Age = Convert.ToInt32(txtAge.Text);
            mostWanted.Sex = txtSex.Text;
            mostWanted.Description = txtDescription.Text;

            try
            {
                mostWanted.AddMostWanted();
            }
            catch (Exception ex)
            {

                throw;
            }

            ClearAll();

            lblMessage.Text = "Most Wanted record has been added successfully.";
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        public void ClearAll()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtNickName.Text = "";
            txtAge.Text = "";
            txtSex.Text = "";
            txtDescription.Text = "";
        }
    }
}