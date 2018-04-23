using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace T339643 {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Init(object sender, EventArgs e) {
            if (Session["MyVaraible"] == null) {
                Session["MyVaraible"] = "Default Value";
            }
            tbSessionVariableValue.Text = Convert.ToString(Session["MyVaraible"]);
        }

        protected void Page_Load(object sender, EventArgs e) {
            Session["MyVaraible"] = tbSessionVariableValue.Text;
        
            ASPxReportDesigner1.OpenReport("SampleReportUrl");
        }
    }
}