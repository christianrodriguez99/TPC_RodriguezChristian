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
    public partial class PantallaListarCompras : System.Web.UI.Page
    {
        public List<Compra> listaCompra { get; set; }
        CompraNegocio compraNegocio = new CompraNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            string usuario = Session["nombreDeUsuario"].ToString();
            rptOutter.DataSource = compraNegocio.listarPorNombre(usuario);
            rptOutter.DataBind();
        }
    }
}