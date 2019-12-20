using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using MercadoPago;
using MercadoPago.Resources;
using MercadoPago.DataStructures.Payment;
using MercadoPago.Common;



namespace TPC_RodriguezChristian
{
    public partial class PublicacionDetalles : System.Web.UI.Page
    {
        public Publicacion publicacion = new Publicacion();
        public PublicacionNegocio publicacionNegocio = new PublicacionNegocio();
        public Usuario usuario = new Usuario();
        public UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        public Venta venta = new Venta();
        public VentaNegocio ventaNegocio = new VentaNegocio();
        public Compra compra = new Compra();
        public AccesoDatos accesoDAtos = new AccesoDatos();
        public CompraPendiente compraPendiente = new CompraPendiente();
        public CompraPendienteNegocio compraPendienteNegocio = new CompraPendienteNegocio();
        List<Publicacion> listaPublicacion;
        protected void Page_Load(object sender, EventArgs e)
        {
            PublicacionNegocio publicacionNegocio = new PublicacionNegocio();
            
            try
            {
                 if(Session["nombreDeUsuario"] == null)
                    Response.Redirect("Login.aspx");
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

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
          
            lblErrorCantidadNumeros.Visible = false;
            lblErrorCantidadStock.Visible = false;
            lblErrorCompra.Visible = false;
           
            var publiSeleccionado = Convert.ToInt32(Request.QueryString["id"]);
            publicacion = listaPublicacion.Find(J => J.id == publiSeleccionado);
            int valido = 1;

            compraPendiente.comprador = new Usuario();
            compraPendiente.vendedor = new Usuario();
            compraPendiente.publicacion = new Publicacion();
            string username = Session["nombreDeUsuario"].ToString();
            compraPendiente.comprador.id = usuarioNegocio.obteneridPorSession(username);
            compraPendiente.publicacion.id = Convert.ToInt32(publiSeleccionado);
            compraPendiente.fecha = DateTime.Now;
            compraPendiente.vendedor.id = usuarioNegocio.obteneridVendedor(Convert.ToInt32(publiSeleccionado));
            


            //cantidad
            int valor = -1;
            decimal preciofinal;
            int cantidad;

            if(compraPendiente.vendedor.id== compraPendiente.comprador.id)
            {
                valido = 0;
                lblErrorCompra.Visible = true;
            }
            
            if (int.TryParse(txtCantidad.Text, out valor))
            {
                valor = 1;
                
                
            }
            else
            {
                valido = 0;
                lblErrorCantidadNumeros.Visible = true;
            }

            cantidad = Convert.ToInt32(txtCantidad.Text);

            if (valor == 1)
            {
                compraPendiente.cantidad = Convert.ToInt32(txtCantidad.Text);
            }

            if (Convert.ToInt32(txtCantidad.Text) > publicacion.stock)
            {
                lblErrorCantidadStock.Visible = true;
            }

            compraPendiente.cantidad = cantidad;

            //venta.comprador = new Usuario();
            //venta.vendedor = new Usuario();
            //venta.publicacion = new Publicacion();
            //string username = Session["Userid"].ToString();
            //venta.comprador.id = usuarioNegocio.obteneridPorSession(username);
            //venta.publicacion.id = Convert.ToInt32(publiSeleccionado);
            //venta.fecha = DateTime.Now;
            //venta.vendedor.id = usuarioNegocio.obteneridVendedor(Convert.ToInt32(publiSeleccionado));
            if (valido == 1)
            {
                
                preciofinal = cantidad * publicacion.precio;
                compraPendiente.precioTotal = preciofinal;
                
                Label1.Visible = true;
                lblPrecioFinal.Text = preciofinal.ToString("F") + " por " + cantidad + " unidades";
                lblPrecioFinal.Visible = true;
                if(btnSiguiente.Text=="Finalizar compra")
                {
                    publicacionNegocio.modificarStock(compraPendiente.publicacion.id, publicacion.stock - compraPendiente.cantidad);
                    
                    compraPendienteNegocio.agregar(compraPendiente);
                    btnSiguiente.Visible = false;
                    lblCantidad.Visible = false;
                    Label1.Text = "Compra exitosa, pendiente de pago";
                }
                btnSiguiente.Text = "Finalizar compra";
                txtCantidad.Visible = false;

                
            }



        }

      
    }
}