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
    public partial class PantallaListarVentas : System.Web.UI.Page
    {
        public List<Venta> listaVenta { get; set; }
        VentaNegocio VentaNegocio = new VentaNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
          
            string usuario = Session["nombreDeUsuario"].ToString();
            rptOutter.DataSource = VentaNegocio.listarPorNombre(usuario);
            rptOutter.DataBind();
            if (rptOutter.Items.Count == 0)
            {
                Label1.Visible = true;

            }

        }
    }
}