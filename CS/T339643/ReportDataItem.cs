using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T339643 {
    public class ReportDataItem {
        protected const int ITEMS_COUNT = 10;

        public string Text { get; set; }

        public List<ReportDataItem> GetReportData(string sessionVaraible, string userName) {
            List<ReportDataItem> data = new List<ReportDataItem>();
            for (int itemIndex = 0; itemIndex < ITEMS_COUNT; itemIndex++) {
                data.Add(new ReportDataItem() {
                    Text = String.Format("Item {0},\t Session variable: {1},\t User: {2}", itemIndex, sessionVaraible, userName)
                });
            }
            return data;
        }
    }
}