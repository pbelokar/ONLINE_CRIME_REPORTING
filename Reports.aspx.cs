using CriminalRecordManagement.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CriminalRecordManagement
{
    public partial class Reports : System.Web.UI.Page
    {
        clsReports report = new clsReports();
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                checkUser();
                FillDDL();
                
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = report.getDropDownList();
            report.SearchCriteria = ddlSearch.SelectedValue.ToString();
            report.SearchID = txtSearch.Value;
            DataTable dt = ds.Tables[0];
            DataRow[] dr = dt.Select("DictTableName = '" + ddlSearch.SelectedValue + "'");
            string strColumnName = dr[0].ItemArray[2].ToString();
            report.ColumnName = strColumnName;
            DataSet dsReport = report.RetriveData();

            BindGrid(dsReport);

            ClearAll();


        }
        private void FillDDL()
        {
            //clsReports report = new clsReports();
           DataSet ds = report.getDropDownList();
            ddlSearch.DataSource = ds;
            ddlSearch.DataTextField = "DictDisplayName";
            ddlSearch.DataValueField = "DictTableName";
            ddlSearch.DataBind();
        }

        private void BindGrid(DataSet dsReport)
        {
            grdReport.DataSource = dsReport;
            grdReport.DataBind();
        }

        public bool checkUser()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Session["userid"])))
            {
                Response.Redirect("Login.aspx?url=" + Server.UrlEncode(Request.Url.AbsoluteUri));
            }

            return true;

        }

        public void ClearAll()
        {
            txtSearch.Value = "";

        }
    }
}