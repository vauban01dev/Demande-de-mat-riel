using DemandeMateriel.DAO;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemandeMateriel
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        

        protected void ButtonValidation_Click(object sender, EventArgs e)
        {
            //DirectoryEntry connexion = LDAPUtils.ConnexionLDAP("192.168.0.20","vdrevet","Mas1873");
            bool estvalide = LDAPUtils.ValidationLogin(TextBoxLogin.Text.ToString(), TextBoxPassword.Text.ToString());
            Response.Write(estvalide);

            if(estvalide == true)
            {
                
            }
            else
            {
                Response.Write("Erreur Login ou Mot de passe Incorrect");
            }
        }
    }
}