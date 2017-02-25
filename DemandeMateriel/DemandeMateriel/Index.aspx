<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="DemandeMateriel.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            text-decoration: underline;
            font-size: medium;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            width: 25%;
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style5 {
            height: 26px;
            width: 516px;
        }
        .auto-style6 {
            width: 516px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
            <p class="auto-style1">
                <strong>Demande de matériel</strong></p>
            <div class="auto-style2">
                <table align="center" class="auto-style3">
                    <tr>
                        <td class="auto-style5">
                            <asp:TextBox ID="TextBoxLogin" runat="server" Width="150px" placeholder="Login"></asp:TextBox>
                        </td>
                        <td class="auto-style4">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorLogin" runat="server" ControlToValidate="TextBoxLogin" ErrorMessage="*Champ Obligatoire" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">
                            <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password" Width="150px" placeholder="Mot de Passe"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" ControlToValidate="TextBoxPassword" ErrorMessage="*Champ Obligatoire" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                </table>
                <br />
                <asp:Button ID="ButtonValidation" runat="server" OnClick="ButtonValidation_Click" Text="Valider" />
                <br />
            </div>
        </div>
    </form>
</body>
</html>
