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
    

    public partial class PantallaComprasPendientes : System.Web.UI.Page
    {

        PublicacionNegocio publicacionNegocio = new PublicacionNegocio();
        CompraPendiente compraPendiente = new CompraPendiente();
        Venta venta = new Venta();
        Compra compra = new Compra();
        VentaNegocio ventaNegocio = new VentaNegocio();
        CompraNegocio compraNegocio = new CompraNegocio();
        public List<CompraPendiente> listaCompraPendiente { get; set; }
        CompraPendienteNegocio compraPendienteNegocio = new CompraPendienteNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
    
            if (!Page.IsPostBack)
            { 
            rptOutter.DataSource = compraPendienteNegocio.listar();
            rptOutter.DataBind();
        }

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            var compraSeleccionado = ((Button)sender).CommandArgument;
            if (((Button)sender).CommandName == "idCompraPendienteAceptada")
            {
                string[] commandArgs = ((Button)sender).CommandArgument.ToString().Split(new char[] { ';' });
                int id = Convert.ToInt32(commandArgs[0]);
                int publicacionid = Convert.ToInt32(commandArgs[1]);
                int cantidad = Convert.ToInt32(commandArgs[2]);
                DateTime fecha = Convert.ToDateTime(commandArgs[3]);
                int vendedorid = Convert.ToInt32(commandArgs[4]);
                int compradorid = Convert.ToInt32(commandArgs[5]);
                decimal preciototal = Convert.ToDecimal(commandArgs[6]);
                string titulo = commandArgs[7];

                venta.cantidad = cantidad;
                venta.comprador = new Usuario();
                venta.vendedor = new Usuario();
                venta.publicacion = new Publicacion();
                venta.comprador.id = compradorid;
                venta.fecha = fecha;
                venta.publicacion.id = publicacionid;
                venta.publicacion.titulo = titulo;
                venta.vendedor.id = vendedorid;

                compra.comprador = new Usuario();
                compra.vendedor = new Usuario();
                compra.publicacion = new Publicacion();
                compra.cantidad = cantidad;
                compra.comprador.id = compradorid;
                compra.fecha = fecha;
                compra.publicacion.id = publicacionid;
                compra.publicacion.titulo = titulo;
                compra.vendedor.id = vendedorid;

                compraNegocio.agregar(compra);
                ventaNegocio.agregar(venta);



                compraPendienteNegocio.eliminar(id);

                Response.Redirect(Request.RawUrl);

            }
        }

        protected void btnRechazar_Click(object sender, EventArgs e)
        {
            var compraSeleccionado = ((Button)sender).CommandArgument;
                if (((Button)sender).CommandName == "idCompraPendienteRechazada")
                {
                    string[] commandArgs = ((Button)sender).CommandArgument.ToString().Split(new char[] { ';' });
                    int id = Convert.ToInt32(commandArgs[0]);
                    int publicacionid = Convert.ToInt32(commandArgs[1]);
                    int cantidad = Convert.ToInt32(commandArgs[2]);
                    publicacionNegocio.modificarStock(publicacionid, publicacionNegocio.obtenerstockActual(publicacionid)+cantidad);
                compraPendienteNegocio.eliminar(id);
                Response.Redirect(Request.RawUrl);
            }
             
            
        }

    
    }
}