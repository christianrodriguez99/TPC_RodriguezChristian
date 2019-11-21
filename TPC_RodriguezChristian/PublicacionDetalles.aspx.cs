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
        public Publicacion publicacion = new Publicacion();
        public Usuario usuario = new Usuario();
        public UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        public Producto producto = new Producto();
        public Venta venta = new Venta();
        public VentaNegocio ventaNegocio = new VentaNegocio();
        public Compra compra = new Compra();
        public AccesoDatos accesoDAtos = new AccesoDatos();
        List<Publicacion> listaPublicacion;
        protected void Page_Load(object sender, EventArgs e)
        {
            PublicacionNegocio publicacionNegocio = new PublicacionNegocio();
            
            try
            {
                 if(Session["Userid"] == null)
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
            
           
            var publiSeleccionado = Convert.ToInt32(Request.QueryString["id"]);
            publicacion = listaPublicacion.Find(J => J.id == publiSeleccionado);
            int valido = 1;
            venta.comprador = new Usuario();
            venta.vendedor = new Usuario();
            venta.publicacion = new Publicacion();
            string username = Session["Userid"].ToString();
            venta.comprador.id = usuarioNegocio.obteneridPorSession(username);
            venta.publicacion.id = Convert.ToInt32(publiSeleccionado);
            venta.fecha = DateTime.Now;
            venta.vendedor.id = usuarioNegocio.obteneridVendedor(Convert.ToInt32(publiSeleccionado));


            //cantidad
            int valor = -1;
            decimal preciofinal;
            int cantidad;

            if(venta.vendedor.id==venta.comprador.id)
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
                venta.cantidad = Convert.ToInt32(txtCantidad.Text);
            }

            if (Convert.ToInt32(txtCantidad.Text) > publicacion.stock)
            {
                lblErrorCantidadStock.Visible = true;
            }
            if (valido == 1)
            {
                
                preciofinal = cantidad * publicacion.precio;
                Label1.Visible = true;
                lblPrecioFinal.Text = preciofinal.ToString("F");
                lblPrecioFinal.Visible = true;
                btnComprar.Visible = true;
            }



        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {

        }
    }
}