using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPC_RodriguezChristian
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Session["busqueda"] = txtBusquedaxNombre.Text;
            Response.Redirect("PantallaListarPublicaciones.aspx");
            
        }


    }
}