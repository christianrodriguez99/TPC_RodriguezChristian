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
        PublicacionNegocio publicacionNegocio = new PublicacionNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string usuario = Session["nombreDeUsuario"].ToString();
                rptOutter.DataSource = usuarioNegocio.listarPorNombre(usuario);
                rptOutter.DataBind();
            }
            
        }


        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            var idSeleccionado = ((Button)sender).CommandArgument;
            if (((Button)sender).CommandName == "idEliminar")
            {
                int id = Convert.ToInt32(((Button)sender).CommandArgument);
                usuarioNegocio.eliminar(id);
                publicacionNegocio.eliminarxId(id);
                Session["nombreDeUsuario"] = null;
                Response.Redirect("Login.aspx");
               
            }
        }

        protected void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
           
        }
    }
}