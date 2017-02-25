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
        public static DirectoryEntry ConnexionLDAP(String ServeurLDAP, String User, String Password)
        {
            //instanciation d'un objet null DirectoryEntry
            DirectoryEntry connexionldap = null;
            //tentative de connexion au domaine
            try
            {
                connexionldap = new DirectoryEntry("LDAP://" + ServeurLDAP, User, Password);


            }
            //affichage d'erreur en cas d'impossibilité de connexion
            catch (Exception e)
            {

                System.Diagnostics.Debug.WriteLine(e);
            }
            //retourne une connexion au LDAP
            return connexionldap;
        }


        /*
         * Fonction Validation des Logins/mot de passe saisie sur la page web via Active Directory
         * contextad : chargement du contexte Active Directory
         * User : login soumis par l'utilisateur
         * Password : Mot de passe soumis par l'utilisateur
         */

        public static bool ValidationLogin(PrincipalContext contextead, String User, String Password)
        {
            //Variable boolean
            bool estvalide = false;
            //Validation des login/mot de passe saisie par l'utilisateur
            estvalide = contextead.ValidateCredentials(User, Password);
            //retourne la valeur
            return estvalide;
        }

        /*
         * Fonction de récuperation d'un utilisateur et de toutes ces propriétés associé en fonction de son identificant windows
         * connexionldap : connexion au serveur ldap créer par la méthode "ConnexionLDAP"
         * User : login d'un utilisateur windows valider par la méthode "ValidationLogin"
         */

        public static DirectoryEntry RecuperationUtilisateur(DirectoryEntry connexionldap, String User)
        {
            //Instanciation d'un objet DirectorySearcher
            DirectorySearcher rechercheur = new DirectorySearcher(connexionldap);
            //Déclaration du filtre de recherche, la recherche ne retournera que les utilisateurs
            rechercheur.Filter = "(&(objectclass=user)(SAMAccountName="+User+"))";
            //Sélectionne uniquement la première entrée retenu lors de la recherche
            DirectoryEntry entree = rechercheur.FindOne().GetDirectoryEntry();
            //retour de l'entrée recherché
            return entree;

        }
    }
}