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
    public partial class SiteMaster : MasterPage
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
                cboMarcas.SelectedIndex = -1;
                cboCategorias.SelectedIndex = -1;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Session["busqueda"] = txtBusquedaxNombre.Text;
            Response.Redirect("PantallaListarPublicaciones.aspx");
            
        }

        protected void cboMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["busquedaMarca"] = cboMarcas.SelectedValue;
            

        }

        protected void cboCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["busquedaCategoria"] = cboMarcas.SelectedValue;
        }
    }
}