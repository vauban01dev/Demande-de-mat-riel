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
            //Connexion au serveur LDAP
            DirectoryEntry connexion = LDAPUtils.ConnexionLDAP("192.168.0.20","vdrevet","Mas1873");
            //Chargement du context 
            PrincipalContext contexte = new PrincipalContext(ContextType.Domain, "192.168.0.20");
            //Verification des logins et mot de passe saisie par l'utilisateur dans l'active directory
            bool estvalide = LDAPUtils.ValidationLogin(contexte,TextBoxLogin.Text.ToString(), TextBoxPassword.Text.ToString());
            

            if(estvalide == true)
            {
                //Récuperation de toutes les propriétés associé à cette utilisateur
                DirectoryEntry utilisateur = LDAPUtils.RecuperationUtilisateur(connexion, TextBoxLogin.Text.ToString());
                //Affectation de la propriété LDAP avec session
                Session["Nom_Prenom"] = utilisateur.Properties["Name"].Value.ToString();
                Response.Redirect("PageCentral.aspx");
                
            }
            else
            {
                Response.Write("Erreur Login ou Mot de passe Incorrect");
            }
        }
    }
}