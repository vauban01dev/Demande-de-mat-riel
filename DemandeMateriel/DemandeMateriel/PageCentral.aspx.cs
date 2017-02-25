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
            if(Session["Nom_Prenom"] == null)
            {
                Response.Redirect("index.aspx");
            }
        }
    }
}