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
    public partial class PantallaMisProductos : System.Web.UI.Page
    {
        public List<Publicacion> listaPublicacion { get; set; }
        PublicacionNegocio publicacionNegocio = new PublicacionNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            rptOutter.DataSource = publicacionNegocio.listarPorId(Convert.ToInt32(rptOutter.DataSourceID));
            rptOutter.DataBind();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}