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
          if(!IsPostBack)
            {
                Session["nombreDeUsuario"] = null;
            }

        }
        protected void btnCrear_Click(object sender, EventArgs e)
        {
            Response.Redirect("PantallaCrearUsuario.aspx");
        }
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombreDeUsuario.Text != "" && txtClave.Text != "")
            {


                bool ok = usuarioNegocio.verificarlogin(txtNombreDeUsuario.Text, txtClave.Text);
                if (ok == true)
                {

                    Session["nombreDeUsuario"] = txtNombreDeUsuario.Text;
                    Response.Redirect("PantallaListarPublicaciones.aspx");
                }
                else
                {
                    lblIncorrecto.Visible = true;
                }
            }

        }
    }
}
    