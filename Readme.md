# How to access the values stored in HttpContext/Session while working with the ASP.NET HTML5 Document Viewer and End-User Report Designer controls


<p>This example demonstrates the approaches described in the <a href="https://www.devexpress.com/Support/Center/p/T339643">T339643: How to access the values stored in HttpContext/Session while working with the ASP.NET HTML5 Document Viewer and End-User Report Designer controls</a> article.<br><br>A report instance is created in the custom report storage extension (<em>SampleReportStorageWebExtension </em>class) <strong>GetData</strong> method's code. The values stored in the HttpContext/Session (the session field and the User name) are used there to initialize the report parameters. The report displays these parameters values in the ReportHeaderBand. Also, these parameter values are passed to the ObjectDataSource's data class's (<em>ReportDataItem</em> class) <strong>GetReportData</strong> method that is used to populate the report with data.</p>

<br/>


