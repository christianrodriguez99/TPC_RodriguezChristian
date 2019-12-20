using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPC_RodriguezChristian
{
    public partial class PantallaAdministrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMarcasPendientes_Click(object sender, EventArgs e)
        {
            Response.Redirect("PantallaAdministradorMarcasPendientes.aspx");
        }

        protected void btnCategoriasPendientes_Click(object sender, EventArgs e)
        {
            Response.Redirect("PantallaAdministradorCategoriasPendientes.aspx");
        }
    }
}