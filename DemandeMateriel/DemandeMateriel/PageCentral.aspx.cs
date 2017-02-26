using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemandeMateriel
{
    public partial class PageCentral : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Test si une session existe ou non afin de permettre l'accès au site réservé.
            if(Session["Nom_Prenom"] == null)
            {
                Response.Redirect("index.aspx");
            }
        }
    }
}