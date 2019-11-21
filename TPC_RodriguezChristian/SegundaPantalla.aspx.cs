using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace TPC_RodriguezChristian
{
    public partial class SegundaPantalla : System.Web.UI.Page
    {
        public Usuario usuario = new Usuario();
        AccesoDatos datos = new AccesoDatos();
        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == "")
                Response.Redirect("Login.aspx");

        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {
            Response.Redirect("PantallaCrearPublicacion");
        }
        protected void btnListar_Click(object sender, EventArgs e)
        {
            Response.Redirect("PantallaListarPublicaciones");
        }
        protected void btnPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("PantallaPerfil");
        }
        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("Login.aspx");
        }

    }
}