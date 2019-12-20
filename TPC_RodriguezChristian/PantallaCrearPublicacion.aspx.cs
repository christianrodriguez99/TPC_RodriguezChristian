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
    public partial class PantallaCrearPublicacion : System.Web.UI.Page
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

        protected void Page_Load(object sender, EventArgs e)
        {
            

            try
            {
                if (!IsPostBack)
                {
                    if(Session["nombreDeUsuario"] == null)
                    Response.Redirect("Login.aspx");

                    listaMarcas = marcaNegocio.listar();
                    cboMarcas.DataSource = listaMarcas;
                    cboMarcas.DataTextField = "nombre";
                    cboMarcas.DataValueField = "id";                  
                    cboMarcas.DataBind();
                    cboMarcas.Items.Add("Agregar marca");

                    listaCategorias = categoriaNegocio.listar();
                    cboCategorias.DataSource = listaCategorias;
                    cboCategorias.DataTextField = "nombre";
                    cboCategorias.DataValueField = "id";            
                    cboCategorias.DataBind();
                    cboCategorias.Items.Add("Agregar categoria");

                    cboEstados.Items.Add("Nuevo");
                    cboEstados.Items.Add("Usado");


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

        protected void btnCrear_Click(object sender, EventArgs e)
        {
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
            publicacion.urlImagen = txtImagen.Text;
            publicacion.estado = true;
            


            //Precio
      
            Decimal value = -1;

            if (decimal.TryParse(txtPrecio.Text, out value))
            {
                value = 1;
            }
            else
            {
                valido = 0;
                Session["Error" + Session.SessionID] = "El precio debe contener numeros";
                Response.Redirect("PantallaError.aspx");
            }


            if (value==1)
            {
                publicacion.precio = Convert.ToDecimal(txtPrecio.Text);
            }


            //Stock

            int valor = -1;
            
            if (int.TryParse(txtStock.Text, out valor))
            {
                valor = 1;
            }
            else
            {
                valido = 0;
                Session["Error" + Session.SessionID] = "El stock debe contener numeros";
                Response.Redirect("PantallaError.aspx");
            }


            if (valor == 1)
            {
                publicacion.stock = Convert.ToInt32(txtStock.Text);
            }

            //Estado

            if(cboEstados.SelectedValue=="Nuevo")
            {
                publicacion.estadoProducto = "Nuevo";
            }
            else
            {
                publicacion.estadoProducto = "Usado";
            }
           

            if (valido == 1)
            {
                publicacionNegocio.agregar(publicacion);
            }

        }
        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("SegundaPantalla.aspx");
        }

        protected void cboMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboMarcas.Text=="Agregar marca")
            {
                lblAgregarMarca.Visible = true;
                txtNuevaMarca.Visible = true;
                btnAgregarMarca.Visible = true;
                
            }
        }

        protected void cboCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(cboCategorias.Text=="Agregar categoria")
            {
                lblAgregarCategoria.Visible = true;
                txtNuevaCategoria.Visible = true;
                btnAgregarCategoria.Visible = true;
            }

        }

        protected void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            string nombreDeUsuario = Session["nombreDeUsuario"].ToString();
            categoriaPendiente.nombre = txtNuevaCategoria.Text;
            categoriaPendiente.usuario = new Usuario();
            categoriaPendiente.usuario.id = usuarioNegocio.obteneridPorSession(nombreDeUsuario);
            categoriaPendiente.estado = true;
            bool ok = categoriaPendienteNegocio.verificar(txtNuevaCategoria.Text);
            bool ok2 = categoriaPendienteNegocio.verificar2(txtNuevaCategoria.Text);
            if (ok == false && ok2 == false)
            {
                lblAgregarCategoriaError.Visible = false;
                categoriaPendienteNegocio.agregar(categoriaPendiente);
                lblAgregarCategoriaExito.Visible = true;
                lblAgregarCategoria.Visible = false;
                txtNuevaCategoria.Visible = false;
                btnAgregarCategoria.Visible = false;

            }
            else
            {
                lblAgregarCategoriaExito.Visible = false;
                lblAgregarCategoriaError.Visible = true;
            }

        }

        protected void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            string nombreDeUsuario = Session["nombreDeUsuario"].ToString();
            marcaPendiente.nombre = txtNuevaMarca.Text;
            marcaPendiente.usuario = new Usuario();
            marcaPendiente.usuario.id = usuarioNegocio.obteneridPorSession(nombreDeUsuario);
            marcaPendiente.estado = true;
            bool ok = marcaPendienteNegocio.verificar(txtNuevaMarca.Text);
            bool ok2 = marcaPendienteNegocio.verificar2(txtNuevaMarca.Text);
            if (ok == false && ok2 == false)
            {
                lblAgregarMarcaError.Visible = false;
                marcaPendienteNegocio.agregar(marcaPendiente);
                lblAgregarMarcaExito.Visible = true;
                lblAgregarMarca.Visible = false;
                txtNuevaMarca.Visible = false;
                btnAgregarMarca.Visible = false;

            }
            else
            {
                lblAgregarMarcaExito.Visible = false;
                lblAgregarMarcaError.Visible = true;
            }

        }
    }


}
