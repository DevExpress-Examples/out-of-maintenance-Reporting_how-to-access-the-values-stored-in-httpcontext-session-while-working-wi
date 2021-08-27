<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128598202/15.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T341232)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/T339643/Default.aspx) (VB: [Default.aspx](./VB/T339643/Default.aspx))
* [Default.aspx.cs](./CS/T339643/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/T339643/Default.aspx.vb))
* [Global.asax.cs](./CS/T339643/Global.asax.cs) (VB: [Global.asax.vb](./VB/T339643/Global.asax.vb))
* [ReportDataItem.cs](./CS/T339643/ReportDataItem.cs) (VB: [ReportDataItem.vb](./VB/T339643/ReportDataItem.vb))
* [SampleReport.cs](./CS/T339643/SampleReport.cs) (VB: [SampleReport.vb](./VB/T339643/SampleReport.vb))
* [SampleReport.Designer.cs](./CS/T339643/SampleReport.Designer.cs) (VB: [SampleReport.Designer.vb](./VB/T339643/SampleReport.Designer.vb))
* **[SampleReportStorageWebExtension.cs](./CS/T339643/SampleReportStorageWebExtension.cs) (VB: [SampleReportStorageWebExtension.vb](./VB/T339643/SampleReportStorageWebExtension.vb))**
* [Web.config](./CS/T339643/Web.config) (VB: [Web.config](./VB/T339643/Web.config))
<!-- default file list end -->
# How to access the values stored in HttpContext/Session while working with the ASP.NET HTML5 Document Viewer and End-User Report Designer controls


<p>This example demonstrates the approaches described in the <a href="https://www.devexpress.com/Support/Center/p/T339643">T339643: How to access the values stored in HttpContext/Session while working with the ASP.NET HTML5 Document Viewer and End-User Report Designer controls</a> article.<br><br>A report instance is created in the custom report storage extension (<em>SampleReportStorageWebExtension </em>class) <strong>GetData</strong> method's code. The values stored in the HttpContext/Session (the session field and the User name) are used there to initialize the report parameters. The report displays these parameters values in the ReportHeaderBand. Also, these parameter values are passed to the ObjectDataSource's data class's (<em>ReportDataItem</em> class) <strong>GetReportData</strong> method that is used to populate the report with data.</p>

<br/>


