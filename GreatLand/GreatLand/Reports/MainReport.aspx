<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainReport.aspx.cs" Inherits="GreatLand.Reports.MainReport" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Report</title>


         <meta name="viewport" content="width=device-width" />
        <link href="@Url.Content("~/Content/themes/Gridmvc.css")" rel="stylesheet" />
        <link href="@Url.Content("~/Content/bootstrap.min.css")" rel="stylesheet" />

        <link href="@Url.Content("~/Content/themes/base/datepicker.css")" rel="stylesheet" />

        <script src="@Url.Content("~/Scripts/jquery-2.1.4.js")" type="text/javascript"></script>
        <script src="@Url.Content("~/Scripts/jquery-2.1.4.min.js")" type="text/javascript"></script>
        
        <script src="@Url.Content("~/Scripts/jquery-ui-1.11.4.js")"></script>
        <script src="@Url.Content("~/Scripts/jquery-ui-1.11.4.min.js")"></script>

        <script src="@Url.Content("~/Scripts/jquery.validate.min.js")" type="text/javascript"></script>
        <script src="@Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js")" type="text/javascript"></script>

        <script src="@Url.Content("~/Scripts/gridmvc.min.js")"></script>

    <!--Date Picker-->
     <link rel="stylesheet" href="//code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css">
  <script src="//code.jquery.com/jquery-1.10.2.js"></script>
  <script src="//code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
  <link rel="stylesheet" href="/resources/demos/style.css">



    <script>
        $(function () {
            $("#TxtFrom").datepicker();
        });
        $(function () {
            $("#TxtTo").datepicker();
        });
    </script>

</head>
<body>

<b><center>Main Report</center></b>
<a href="../Office">Return to Office</a>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
        <br />

        <table>
            <tr>
                <td>
                    Casino
                </td>
                <td>
                    <asp:DropDownList ID="DropDownCasino" runat="server">
                        <asp:ListItem Value="1">L&#39;Auberge</asp:ListItem>
                        <asp:ListItem Value="2">Golden Nugget</asp:ListItem>
                        <asp:ListItem Value="3">Coushatta</asp:ListItem>
                        <asp:ListItem Value="4">Delta Down</asp:ListItem>
                        <asp:ListItem Value="5">Isle of Capri</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    From
                </td>
                <td>
                    <asp:TextBox ID="TxtFrom" runat="server"></asp:TextBox>
                </td>
                <td>
                    To
                </td>
                <td>
                    <asp:TextBox ID="TxtTo" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Show" />
                </td>
            </tr>
        </table>
        <br />
        <br
    </div>
        <rsweb:ReportViewer ID="appReportViewer" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="1091px" Height="1000px">
            <LocalReport ReportPath="Main.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="" Name="CasinoReportDataset" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MbuiSQLConnectionString2 %>" ProviderName="<%$ ConnectionStrings:MbuiSQLConnectionString2.ProviderName %>" SelectCommand="GetCasinoReport" SelectCommandType="StoredProcedure"></asp:SqlDataSource>--%>
    </form>
</body>
</html>
