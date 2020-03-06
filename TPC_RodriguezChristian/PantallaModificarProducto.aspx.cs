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
    public partial class PantallaModificarProducto : System.Web.UI.Page
    {
        public Publicacion publicacion = new Publicacion();
        public MarcaPendiente marcaPendiente = new MarcaPendiente();
        public MarcaPendienteNegocio marcaPendienteNegocio = new MarcaPendienteNegocio();
        public CategoriaPendiente categoriaPendiente = new CategoriaPendiente();
        public CategoriaPendienteNegocio categoriaPendienteNegocio = new CategoriaPendienteNegocio();
        public List<Marca> listaMarcas;
        public List<Categoria> listaCategorias;
        public Marca marca = new Marca();
        AccesoDatos datos = new AccesoDatos();
        MarcaNegocio marcaNegocio = new MarcaNegocio();
        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        PublicacionNegocio publicacionNegocio = new PublicacionNegocio();
        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        List<Publicacion> listaPublicacion;
        protected void Page_Load(object sender, EventArgs e)
        {


            try
            {
                if (!IsPostBack)
                {
                    if (Session["nombreDeUsuario"] == null)
                        Response.Redirect("Login.aspx");

                    listaMarcas = marcaNegocio.listar();
                    cboMarcas.DataSource = listaMarcas;
                    cboMarcas.DataTextField = "nombre";
                    cboMarcas.DataValueField = "id";
                    cboMarcas.DataBind();

                    listaCategorias = categoriaNegocio.listar();
                    cboCategorias.DataSource = listaCategorias;
                    cboCategorias.DataTextField = "nombre";
                    cboCategorias.DataValueField = "id";
                    cboCategorias.DataBind();

                    cboEstados.Items.Add("Nuevo");
                    cboEstados.Items.Add("Usado");

                    
                    //
                    // int numeroPokemon = Convert.ToInt32(Session["NumeroPokemon" + Session.SessionID]);
                   

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {


            }

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            listaPublicacion = publicacionNegocio.listar();
            var publiSeleccionado = Convert.ToInt32(Request.QueryString["id"]);
            publicacion = listaPublicacion.Find(J => J.id == publiSeleccionado);
            int valido = 1;
            string nombreDeUsuario = Session["nombreDeUsuario"].ToString();
            publicacion.titulo = txtTitulo.Text;
            publicacion.marca = new Marca();
            publicacion.marca.id = Convert.ToInt32(cboMarcas.SelectedItem.Value);
            publicacion.categoria = new Categoria();
            publicacion.categoria.id = Convert.ToInt32(cboCategorias.SelectedItem.Value);
            publicacion.usuario = new Usuario();
            publicacion.usuario.id = usuarioNegocio.obteneridPorSession(nombreDeUsuario);
            publicacion.descripcion = txtDescripcion.Text;
            if (txtImagen.Text == "")
            {
                txtImagen.Text = "https://www.generationsforpeace.org/wp-content/uploads/2018/03/empty.jpg";
            }
            publicacion.urlImagen = txtImagen.Text;
            publicacion.estado = true;



            //Precio

            Decimal value = -1;

            if (decimal.TryParse(txtPrecio.Text, out value))
            {
                value = 1;
                lblErrorPrecio.Visible = false;
            }
            else
            {
                valido = 0;
                lblErrorPrecio.Visible = true;
            }


            if (value == 1)
            {
                publicacion.precio = Convert.ToDecimal(txtPrecio.Text);
            }


            //Stock

            int valor = -1;

            if (int.TryParse(txtStock.Text, out valor))
            {
                valor = 1;
                lblErrorStock.Visible = false;
            }
            else
            {
                valido = 0;
                lblErrorStock.Visible = true;
            }


            if (valor == 1)
            {
                publicacion.stock = Convert.ToInt32(txtStock.Text);
            }

            //Estado

            if (cboEstados.SelectedValue == "Nuevo")
            {
                publicacion.estadoProducto = "Nuevo";
            }
            else
            {
                publicacion.estadoProducto = "Usado";
            }


            if (valido == 1)
            {
                lblExitoPublicacion.Visible = true;
                publicacionNegocio.modificar(publicacion,publiSeleccionado);
            }

        }

       
    }
}