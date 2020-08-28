<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="T339643.Default" %>

<%@ Register Assembly="DevExpress.XtraReports.v15.2.Web, Version=15.2.20.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/styles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="floatingMenu">
        <table style="width: 100%">
            <tr>
                <td>
                    Session variable:
                    <asp:TextBox ID="tbSessionVariableValue" runat="server" Width="200px"></asp:TextBox>
                    <asp:Button ID="btSubmit" runat="server" Text="Submit" />
                </td>
                <td style="text-align: right;">
                    User Name: <%=Context.User.Identity.Name%>
                </td>
            </tr>
        </table>
    </div>
    <div class="pageContent">       
        <dx:ASPxReportDesigner ID="ASPxReportDesigner1" runat="server">
        </dx:ASPxReportDesigner>
    </div>
    </div>
    </form>
</body>
</html>