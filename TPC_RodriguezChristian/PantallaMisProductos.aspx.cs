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
            string usuario = Session["nombreDeUsuario"].ToString();

            if (!Page.IsPostBack)
            {
                rptOutter.DataSource = publicacionNegocio.listarPorNombre(usuario);
                rptOutter.DataBind();
                if (rptOutter.Items.Count == 0)
                {
                    Label1.Visible = true;

                }
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            var productoSeleccionado = ((Button)sender).CommandArgument;
            publicacionNegocio.eliminar(Convert.ToInt32(productoSeleccionado));
            Response.Redirect(Request.RawUrl);
        }
    }
}