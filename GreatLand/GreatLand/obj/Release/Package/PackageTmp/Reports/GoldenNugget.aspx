<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoldenNugget.aspx.cs" Inherits="GreatLand.Reports.GoldenNugget" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Golden Nugget Report</title>
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
    <b><center>Golden Nugget Report</center></b>
<a href="../Office">Return to Office</a>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>

                      <br />

        <table>
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
        <rsweb:ReportViewer ID="appReportViewer" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="1091px" Height="1000px">
            <LocalReport ReportPath="Casino.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="" Name="CasinoReportDataset" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <br />
    </form>
</body>
</html>
