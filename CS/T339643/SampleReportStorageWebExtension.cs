using System.IO;
using System.Collections.Generic;
using System;
using DevExpress.XtraReports.UI;
using System.Web;

namespace T339643 {
    public class SampleReportStorageWebExtension : DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension {
        public override bool CanSetData(string url) {
            // Check if the URL is available in the report storage.
            return url == "SampleReportUrl";
        }

        public override byte[] GetData(string url) {
            // Get the report data from the storage.
            if (url == "SampleReportUrl") {
                SampleReport report = new SampleReport();
                report.Parameters["SessionVariable"].Value = HttpContext.Current.Session["MyVaraible"];
                report.Parameters["UserName"].Value = HttpContext.Current.User.Identity.Name;

                MemoryStream ms = new MemoryStream();
                report.SaveLayoutToXml(ms);
                return ms.ToArray();
            }               
            return null;
        }

        public override Dictionary<string, string> GetUrls() {
            // Get URLs and display names for all reports available in the storage.
            Dictionary<string, string> urls = new Dictionary<string, string>();
            urls.Add("SampleReportUrl", "Sample Report");
            return urls;
        }

        public override bool IsValidUrl(string url) {
            // Check if the specified URL is valid for the current report storage.
            // In this example, a URL should be a string containing a numeric value that is used as a data row primary key.
            return url == "SampleReportUrl";
        }

        //public override void SetData(XtraReport report, string url) {
        //    // Write a report to the storage under the specified URL.
        //    throw new NotSupportedException();
        //}

        //public override string SetNewData(XtraReport report, string defaultUrl) {
        //    // Save a report to the storage under a new URL. 
        //    // The defaultUrl parameter contains the report display name specified by a user.
        //    throw new NotSupportedException();
        //}
    }
}
