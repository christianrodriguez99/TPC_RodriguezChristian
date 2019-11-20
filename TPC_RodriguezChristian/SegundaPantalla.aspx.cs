using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPC_RodriguezChristian
{
    public partial class SegundaPantalla : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {
            Response.Redirect("PantallaCrearPublicacion");
        }
        protected void btnListar_Click(object sender, EventArgs e)
        {
            Response.Redirect("PantallaListarProductos");
        }
        protected void btnPerfil_Click(object sender, EventArgs e)
        {
        }

    }
}