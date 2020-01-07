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
    public partial class PantallaListarProductos : System.Web.UI.Page
    {
        public List<Publicacion> listaPublicacion { get; set; }
        public List<Marca> listaMarcas { get; set; }
        public List<Categoria> listaCategorias { get; set; }
        MarcaNegocio marcaNegocio = new MarcaNegocio();
        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        PublicacionNegocio publicacionNegocio = new PublicacionNegocio();
        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();



        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["nombreDeUsuario"] == null)
                Response.Redirect("Login.aspx");
            string username = Session["nombreDeUsuario"].ToString();

           

            if (!IsPostBack)
            {
                rptOutter.DataSource = publicacionNegocio.listar();
                rptOutter.DataBind();
                if (rptOutter.Items.Count == 0)
                {
                    Label1.Visible = true;

                }
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

                if (((string)Session["busqueda"] != null))
                {
                    List<Publicacion> listaFiltrada;
                    listaPublicacion = publicacionNegocio.listar();
                    //TextBox busqueda = (TextBox)this.Master.FindControl("txtBusquedaxNombre");
                    string txtBusqueda = (string)Session["busqueda"];
                    try
                    {

                        listaFiltrada = listaPublicacion.FindAll(k => k.titulo.ToLower().Contains(txtBusqueda.ToLower()));
                        Session["listaFiltrada"] = listaFiltrada;
                        rptOutter.DataSource = listaFiltrada;
                        rptOutter.DataBind();
                        
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }

         

        }

        //protected void txtBusquedaxNombre_TextChanged(object sender, EventArgs e)
        //{

        //    List<Publicacion> listaFiltrada;
        //    listaPublicacion = publicacionNegocio.listar();
        //    txtBusquedaxNombre = ((TextBox)(sender));
        //    try
        //    {
        //        if (txtBusquedaxNombre.Text == "")
        //        {
        //            listaFiltrada = listaPublicacion;
        //        }
        //        else
        //        {
        //            listaFiltrada = listaPublicacion.FindAll(k => k.titulo.ToLower().Contains(txtBusquedaxNombre.Text.ToLower()));
        //        }
        //        rptOutter.DataSource = listaFiltrada;
        //        rptOutter.DataBind();

        //    }
        //    catch (Exception ex)
        //    {

        //    }

          
        //}

        protected void cboMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
              
                



            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void cboCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}