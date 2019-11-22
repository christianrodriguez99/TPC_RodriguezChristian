using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPC_RodriguezChristian
{
    public partial class PantallaPerfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMisDatos_Click(object sender, EventArgs e)
        {

        }

        protected void btnMisCompras_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnMisVentas_Click(object sender, EventArgs e)
        {
            Response.Redirect("PantallaListarVentas");
        }

        protected void btnComprasPendientes_Click(object sender, EventArgs e)
        {
            Response.Redirect("PantallaComprasPendientes");
        }

        protected void btnMisProductos_Click(object sender, EventArgs e)
        {
            Response.Redirect("PantallaMisProductos");
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("Login");
        }
    }
}