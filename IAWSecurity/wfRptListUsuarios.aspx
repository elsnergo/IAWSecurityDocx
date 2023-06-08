<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfRptListUsuarios.aspx.cs" Inherits="IAWSecurity.wfRptListUsuarios" %>
<!DOCTYPE html>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--<rsweb:ReportViewer ID="rptListUsuario2" runat="server" Width="100%" Height="100%"></rsweb:ReportViewer>--%>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <rsweb:ReportViewer ID="rptListUsuario2" runat="server" BackColor="" ClientIDMode="AutoID"
                HighlightBackgroundColor="" InternalBorderColor="204, 204, 204" InternalBorderStyle="Solid" InternalBorderWidth="1px"
                ToolBarItemBorderWidth="1px" ToolBarItemHoverBackColor="" ToolBarItemPressedBorderColor="51, 102, 153" ToolBarItemPressedBorderStyle="Solid" 
                ToolBarItemPressedBorderWidth="1px" ToolBarItemPressedHoverBackColor="153, 187, 226"></rsweb:ReportViewer>
           
        </div>
    </form>
</body>
</html>
