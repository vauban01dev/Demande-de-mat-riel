<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageCentral.aspx.cs" Inherits="DemandeMateriel.PageCentral" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" ShowStartingNode="false" />
        <div class="auto-style1">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Menu ID="Menu" runat="server" DataSourceID="SiteMapDataSource1" Orientation="Horizontal">
            <LevelMenuItemStyles>
                <asp:MenuItemStyle CssClass="main_menu" />
                <asp:MenuItemStyle CssClass="level_menu" />
            </LevelMenuItemStyles>
        </asp:Menu>
        </div>
    </div>
    </form>
</body>
</html>
