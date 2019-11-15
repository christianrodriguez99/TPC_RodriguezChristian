using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;
using System.Data.SqlClient;

namespace TPC_RodriguezChristian
{
    public partial class PantallaCargarProducto : System.Web.UI.Page
    {
        public Publicacion publicacion = new Publicacion();
        public List<Marca> listaMarcas;
        public List<Categoria> listaCategorias;
        public Marca marca = new Marca();
        AccesoDatos datos = new AccesoDatos();
        MarcaNegocio marcaNegocio = new MarcaNegocio();
        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        PublicacionNegocio publicacionNegocio = new PublicacionNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {


            try
            {
                if (!IsPostBack)
                {

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
            publicacion.titulo = txtTitulo.Text;
            publicacion.idmarca = Convert.ToInt32(cboMarcas.SelectedItem.Value);
            publicacion.idcategoria = Convert.ToInt32(cboCategorias.SelectedItem.Value);
            publicacion.descripcion = txtDescripcion.Text;
            publicacion.urlImagen = txtImagen.Text;


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
                publicacion.estado = false;
            }
            else
            {
                publicacion.estado = true;
            }
           

            if (valido == 1)
            {
                publicacionNegocio.agregar(publicacion);
            }

        }
            

        }


}
