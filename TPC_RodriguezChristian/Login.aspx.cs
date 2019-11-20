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
    public partial class Login : System.Web.UI.Page
    {
        public Usuario usuario = new Usuario();
        AccesoDatos datos = new AccesoDatos();
        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCrear_Click(object sender, EventArgs e)
        {
            Response.Redirect("PantallaCrearUsuario.aspx");
        }
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            
           

            bool ok = usuarioNegocio.verificarlogin(txtNombreDeUsuario.Text,txtClave.Text);
                if (ok == true)
                {
                    usuarioNegocio.logearUsuario(usuario);
                Response.Redirect("SegundaPantalla.aspx");
                }
                else
                {
                    Session["Error" + Session.SessionID] = "Usuario y/o contraseña incorrecta";
                    Response.Redirect("PantallaError.aspx");
                }

        }
    }
}
    