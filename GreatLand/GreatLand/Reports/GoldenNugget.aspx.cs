using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreatLand.Models;
using GreatLand.DAL;
using Microsoft.Reporting.WebForms;

namespace GreatLand.Reports
{
    public partial class GoldenNugget : System.Web.UI.Page
    {
        private Dal dal = new Dal();
        protected void Page_Load(object sender, EventArgs e)
        {
            //this is the security - session end will redirect back to office and make them log in
            if (Session["email"] == null || Convert.ToString(Session["email"]) == "")
            {
                Response.Redirect("http://greatlandtours.azurewebsites.net/Office");
            }


            if (!IsPostBack)
            {


  


                var id = Request.QueryString["ID"];
                RenderReport(id);
            }
        }

        private void RenderReport(string id)
        {


            appReportViewer.Reset();
            appReportViewer.LocalReport.EnableExternalImages = true;
            appReportViewer.LocalReport.ReportPath = Server.MapPath("~\\bin\\Reports\\Casino.rdlc");
            //appReportViewer.LocalReport.ReportPath = Server.MapPath("Casino.rdlc");
            //appReportViewer.LocalReport.SetParameters(new Microsoft.Reporting.WebForms.ReportParameter("", ""));
            ReportParameter[] rptParams = new ReportParameter[]
            {
                new ReportParameter("route", "Golden Nugget Casino - " + id),
                new ReportParameter("fromDate",TxtFrom.Text),
                new ReportParameter("toDate",TxtTo.Text)
            };

            appReportViewer.LocalReport.SetParameters(rptParams);


            List<CasinoReport> casinoReport = new List<CasinoReport>();
            if (TxtFrom.Text != "" && TxtFrom.Text != "")
            {
                casinoReport = dal.GetCasinoReport(id, DateTime.Parse(TxtFrom.Text), DateTime.Parse(TxtTo.Text));
            }
            else
            {
                casinoReport = dal.GetCasinoReport(id, DateTime.Parse(DateTime.Now.ToShortDateString()), DateTime.Parse(DateTime.Now.ToShortDateString()));
            }

            var reportDataSource = new Microsoft.Reporting.WebForms.ReportDataSource();
            reportDataSource.Name = "DataSet1";
            reportDataSource.Value = casinoReport;

            //DataTable dtReportData = new DataTable();
            appReportViewer.LocalReport.DataSources.Clear();
            appReportViewer.LocalReport.DataSources.Add(reportDataSource);
            appReportViewer.LocalReport.Refresh();

            //List<MVCReportViwer.Customer> customers = null;
            //using (MVCReportViwer.MyDatabaseEntities dc = new MVCReportViwer.MyDatabaseEntities())
            //{
            //    customers = dc.Customers.OrderBy(a => a.CustomerID).ToList();
            //    ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Reports/rptCustomer.rdlc");
            //    ReportViewer1.LocalReport.DataSources.Clear();
            //    ReportDataSource rdc = new ReportDataSource("MyDataset", customers);
            //    ReportViewer1.LocalReport.DataSources.Add(rdc);
            //    ReportViewer1.LocalReport.Refresh();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            var id = Request.QueryString["ID"];
            RenderReport(id);
        }
    }
}