Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace T339643
    Public Class ReportDataItem
        Protected Const ITEMS_COUNT As Integer = 10

        Public Property Text() As String

        Public Function GetReportData(ByVal sessionVaraible As String, ByVal userName As String) As List(Of ReportDataItem)
            Dim data As New List(Of ReportDataItem)()
            For itemIndex As Integer = 0 To ITEMS_COUNT - 1
                data.Add(New ReportDataItem() With {.Text = String.Format("Item {0}," & ControlChars.Tab & " Session variable: {1}," & ControlChars.Tab & " User: {2}", itemIndex, sessionVaraible, userName)})
            Next itemIndex
            Return data
        End Function
    End Class
End Namespace