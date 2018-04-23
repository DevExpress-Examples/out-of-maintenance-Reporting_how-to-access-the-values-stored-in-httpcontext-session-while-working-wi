Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace T339643
    Partial Public Class [Default]
        Inherits System.Web.UI.Page

        Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
            If Session("MyVaraible") Is Nothing Then
                Session("MyVaraible") = "Default Value"
            End If
            tbSessionVariableValue.Text = Convert.ToString(Session("MyVaraible"))
        End Sub

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            Session("MyVaraible") = tbSessionVariableValue.Text

            ASPxReportDesigner1.OpenReport("SampleReportUrl")
        End Sub
    End Class
End Namespace