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
    public partial class PantallaNotificiacion : System.Web.UI.Page
    {
        NotificacionNegocio notificacionNegocio = new NotificacionNegocio();
        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string usuario = Session["nombreDeUsuario"].ToString();
                rptOutter.DataSource = notificacionNegocio.listar(usuario);
                rptOutter.DataBind();
                if (rptOutter.Items.Count == 0)
                {
                    Label1.Visible = true;

                }
                bool validarAdmin = usuarioNegocio.obteneradministradorPorSession(usuario);
                if (validarAdmin == true)
                {
                    btnAdministrador.Visible = true;
                }
            }

            }

       

        protected void btnAdministrador_Click(object sender, EventArgs e)
        {
            Response.Redirect("PantallaAdministrador.aspx");
        }
    }
}