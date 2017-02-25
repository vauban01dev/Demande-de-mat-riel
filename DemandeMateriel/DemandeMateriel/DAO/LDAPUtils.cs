using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Web;

namespace DemandeMateriel.DAO
{
    public class LDAPUtils
    {
        /*
         * Fonction Connexion à un Annuaire LDAP.
         * Paramètre :
         *  ServeurLDAP : Adresse IP du serveur LDAP
         *  Users : login d'un compte utilisateur du domaine
         *  Password : mot de passe du compte associé
         */
        public static DirectoryEntry ConnexionLDAP(String ServeurLDAP,String User,String Password)
        {
            //instanciation d'un objet null DirectoryEntry
            DirectoryEntry connexionldap = null;
            //tentative de connexion au domaine
            try
            {
                connexionldap = new DirectoryEntry("LDAP://"+ServeurLDAP, User, Password);
                

            }
            //affichage d'erreur en cas d'impossibilité de connexion
            catch (Exception e)
            {

                System.Diagnostics.Debug.WriteLine(e);
            }
            //retourne une connexion au LDAP
            return connexionldap;
        }
            
            


        public static bool ValidationLogin(String User, String Password)
        {
            //Variable boolean
            bool estvalide = false;
            //Validation des login/mot de passe saisie par l'utilisateur
            using (PrincipalContext contexte = new PrincipalContext(ContextType.Domain, "Entreprise.lan"))
            {
                estvalide = contexte.ValidateCredentials(User, Password);
            }
            
            //retourne la valeur
            return estvalide;

            

        }

    }
}