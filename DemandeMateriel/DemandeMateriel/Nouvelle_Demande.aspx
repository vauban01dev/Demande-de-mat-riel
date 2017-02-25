<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Nouvelle_Demande.aspx.cs" Inherits="DemandeMateriel.Nouvelle_Demande" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            text-decoration: underline;
        }
        .auto-style2 {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <strong>Formulaire de demande de matériel</strong></div>
        <div>
            <br />
            <span class="auto-style2"><strong>Information sur la demande :</strong></span><br />
            Id :
            <asp:Label ID="LabelID" runat="server"></asp:Label>
            <br />
            Demandeur :
            <asp:Label ID="LabelDemandeur" runat="server"></asp:Label>
            <br />
            <br />
            Type de matériel :
            <asp:DropDownList ID="DropDownListTypeMateriel" runat="server">
            </asp:DropDownList>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
