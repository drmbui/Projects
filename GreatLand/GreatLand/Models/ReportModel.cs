using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Reporting.WebForms;
using System.Web.Mvc;


namespace GreatLand.Models
{
    public class ReportModel
    {
        public enum ReportFormat { PDF=1,Word=2,Excel=3}

        public ReportModel()
            {
            ReportDataSets = new List<ReportDataSet>();

            }

            //Name of the report
            public string Name { get; set; }

            //Language of the report
            public string ReportLanguage { get; set; }
     
            //Reference to the RDLC file that contain the report definition
            public string FileName { get; set; }
    
            //The main title for the reprt
            public string ReportTitle { get; set; }
    
            //The right and left titles and sub title for the report
            public string RightMainTitle { get; set; }
            public string RightSubTitle { get; set; }
            public string LeftMainTitle { get; set; }
            public string LeftSubTitle { get; set; }
      
            //the url for the logo, 
            public string ReportLogo { get; set; }
       
            //date for printing the report
            public DateTime ReportDate { get; set; }
    
            //the user name that is printing the report
            public string UserNamPrinting { get; set; }
    
            //dataset holder
            public List<ReportDataSet> ReportDataSets { get; set; }
     
            //report format needed
            public ReportFormat Format { get; set; }
            public bool ViewAsAttachment { get; set; }


            //an helper class to store the data for each report data set
            public class ReportDataSet
            {
                public string DatasetName { get; set; }
                public List<object> DataSetData { get; set; }
            }
     
            public string ReporExportFileName { get {
                 return string.Format("attachment; filename={0}.{1}", this.ReportTitle, ReporExportExtention);
             } }

            public string ReporExportExtention
            {
                get
                  {
                //switch (this.Format)
                //{
                //      case ReportViewModel.ReportFormat.Word: return ".doc";
                //       case ReportViewModel.ReportFormat.Excel: return ".xls";
                //      default:
                //        return ".pdf";
                //}
                return ".doc";
                  }
              }

        public string LastmimeType
           {
              get
               {
                   return mimeType;
               }
           }
            private string mimeType;

        public byte[] RenderReport()
        {
            //getting repot data from the business object

            //creating a new report and setting its path
            LocalReport localReport = new LocalReport();
            localReport.ReportPath = System.Web.HttpContext.Current.Server.MapPath(this.FileName);

            //adding the report datasets with there names
            foreach(var dataset in this.ReportDataSets)
            {
                ReportDataSource reportDataSource = new ReportDataSource(dataset.DatasetName, dataset.DataSetData);
                localReport.DataSources.Add(reportDataSource);
            }

            //enabeling external images
            localReport.EnableExternalImages = true;

            //setting the parameters for the report
            localReport.SetParameters(new ReportParameter("RightMainTitle", this.RightMainTitle));
            localReport.SetParameters(new ReportParameter("RightSubTitle", this.RightSubTitle));
            localReport.SetParameters(new ReportParameter("LeftMainTitle", this.LeftMainTitle));
            localReport.SetParameters(new ReportParameter("LeftSubTitle", this.LeftSubTitle));
            localReport.SetParameters(new ReportParameter("ReportTitle", this.ReportTitle));
            localReport.SetParameters(new ReportParameter("ReportLogo", System.Web.HttpContext.Current.Server.MapPath(this.ReportLogo)));
            localReport.SetParameters(new ReportParameter("ReportDate", this.ReportDate.ToShortDateString()));
            localReport.SetParameters(new ReportParameter("UserNamPrinting", this.UserNamPrinting));
   
            //preparing to render the report
    
            string reportType = this.Format.ToString();
                  
            string encoding;
            string fileNameExtension;

            //The DeviceInfo settings should be changed based on the reportType
            //http://msdn2.microsoft.com/en-us/library/ms155397.aspx
                  string deviceInfo =
                  "<DeviceInfo>" +
                  "  <OutputFormat>" + this.Format.ToString() + "</OutputFormat>" +
                  "</DeviceInfo>";
                  
                  Warning[] warnings;
                            string[] streams;
                            byte[] renderedBytes;
             
                  //Render the report
                  renderedBytes = localReport.Render(
                      reportType,
                      deviceInfo,
                     out mimeType,
                     out encoding,
                      out fileNameExtension,
                      out streams,
                      out warnings);
               
                 return renderedBytes;

        }

    }
}
