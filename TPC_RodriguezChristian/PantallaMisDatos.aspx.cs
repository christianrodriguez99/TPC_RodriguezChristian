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
    public partial class PantallaMisDatos : System.Web.UI.Page
    {
        public List<Usuario> listaUsuario { get; set; }
        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            string usuario = Session["nombreDeUsuario"].ToString();
            rptOutter.DataSource = usuarioNegocio.listarPorNombre(usuario);
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