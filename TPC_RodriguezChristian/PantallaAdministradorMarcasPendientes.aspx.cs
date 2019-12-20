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
    public partial class PantallaAdministradorMarcasPendientes : System.Web.UI.Page
    {
        MarcaPendiente marcaPendiente = new MarcaPendiente();
        Marca marca = new Marca();
        MarcaNegocio marcaNegocio = new MarcaNegocio();
        Notificacion notificacion = new Notificacion();
        NotificacionNegocio notificacionNegocio = new NotificacionNegocio();
        public List<MarcaPendiente> listaMarcaPendiente { get; set; }
        MarcaPendienteNegocio marcaPendienteNegocio = new MarcaPendienteNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {

                rptOutter.DataSource = marcaPendienteNegocio.listar();
                rptOutter.DataBind();
                if (rptOutter.Items.Count == 0)
                {
                    Label1.Visible = true;

                }
            }

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            var MarcaSeleccionado = ((Button)sender).CommandArgument;
            if (((Button)sender).CommandName == "idMarcaPendienteAceptada")
            {
                notificacion.usuario = new Usuario();
                string[] commandArgs = ((Button)sender).CommandArgument.ToString().Split(new char[] { ';' });
                string nombre = Convert.ToString(commandArgs[0]);
                int id = Convert.ToInt32(commandArgs[1]);
                int idDeUsuario = Convert.ToInt32(commandArgs[2]);
                notificacion.descripcion = ("La marca solicitada " + nombre + " ha sido aceptada!");
                notificacion.usuario.id = idDeUsuario;
                notificacionNegocio.agregar(notificacion);
                marca.nombre = nombre;
                marca.estado = true;
                marcaNegocio.agregar(marca);
                marcaPendienteNegocio.eliminar(id);
                Response.Redirect(Request.RawUrl);
            }


        }


        protected void btnRechazar_Click(object sender, EventArgs e)
        {
            notificacion.usuario = new Usuario();
            var MarcaSeleccionado = ((Button)sender).CommandArgument;
            if (((Button)sender).CommandName == "idMarcaPendienteRechazada")
            {
                
                string[] commandArgs = ((Button)sender).CommandArgument.ToString().Split(new char[] { ';' });
                string nombre = Convert.ToString(commandArgs[0]);
                int id = Convert.ToInt32(commandArgs[1]);
                int idDeUsuario = Convert.ToInt32(commandArgs[2]);
                notificacion.descripcion = ("La marca solicitada " + nombre + " ha sido rechazada! Lo sentimos");
                notificacion.usuario.id = idDeUsuario;
                notificacionNegocio.agregar(notificacion);

                marcaPendienteNegocio.eliminar(id);
                Response.Redirect(Request.RawUrl);
            }

        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("PantallaAdministrador.aspx");
        }
    }
}