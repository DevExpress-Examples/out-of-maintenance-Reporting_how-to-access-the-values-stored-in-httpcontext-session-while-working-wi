Imports System.IO
Imports System.Collections.Generic
Imports System
Imports DevExpress.XtraReports.UI
Imports System.Web

Namespace T339643
    Public Class SampleReportStorageWebExtension
        Inherits DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension

        Public Overrides Function CanSetData(ByVal url As String) As Boolean
            ' Check if the URL is available in the report storage.
            Return url = "SampleReportUrl"
        End Function

        Public Overrides Function GetData(ByVal url As String) As Byte()
            ' Get the report data from the storage.
            If url = "SampleReportUrl" Then
                Dim report As New SampleReport()
                report.Parameters("SessionVariable").Value = HttpContext.Current.Session("MyVaraible")
                report.Parameters("UserName").Value = HttpContext.Current.User.Identity.Name

                Dim ms As New MemoryStream()
                report.SaveLayoutToXml(ms)
                Return ms.ToArray()
            End If
            Return Nothing
        End Function

        Public Overrides Function GetUrls() As Dictionary(Of String, String)
            ' Get URLs and display names for all reports available in the storage.
            Dim urls As New Dictionary(Of String, String)()
            urls.Add("SampleReportUrl", "Sample Report")
            Return urls
        End Function

        Public Overrides Function IsValidUrl(ByVal url As String) As Boolean
            ' Check if the specified URL is valid for the current report storage.
            ' In this example, a URL should be a string containing a numeric value that is used as a data row primary key.
            Return url = "SampleReportUrl"
        End Function

        'public override void SetData(XtraReport report, string url) {
        '    // Write a report to the storage under the specified URL.
        '    throw new NotSupportedException();
        '}

        'public override string SetNewData(XtraReport report, string defaultUrl) {
        '    // Save a report to the storage under a new URL. 
        '    // The defaultUrl parameter contains the report display name specified by a user.
        '    throw new NotSupportedException();
        '}
    End Class
End Namespace
