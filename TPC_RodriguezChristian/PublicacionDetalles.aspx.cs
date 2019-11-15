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
    public partial class PublicacionDetalles : System.Web.UI.Page
    {
        public Publicacion publicacion { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            PublicacionNegocio publicacionNegocio = new PublicacionNegocio();
            List<Publicacion> listaPublicacion;
            try
            {
                listaPublicacion = publicacionNegocio.listar();
                //
                // int numeroPokemon = Convert.ToInt32(Session["NumeroPokemon" + Session.SessionID]);
                var publiSeleccionado = Convert.ToInt32(Request.QueryString["id"]);
                publicacion = listaPublicacion.Find(J => J.id == publiSeleccionado);


            }
            catch (Exception ex)
            {
                Session["Error" + Session.SessionID] = ex;
                Response.Redirect("Error.aspx");
            }

        }
    }
}