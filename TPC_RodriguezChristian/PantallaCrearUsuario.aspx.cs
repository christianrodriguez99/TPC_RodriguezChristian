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
    public partial class PantallaCrearUsuario : System.Web.UI.Page
    {
        public Usuario usuario = new Usuario();
        public Usuario aux = new Usuario();
        AccesoDatos datos = new AccesoDatos(); 
        UsuarioNegocio UsuarioNegocio = new UsuarioNegocio();
 

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
    
    
        protected void btnCrear_Click(object sender, EventArgs e)
        {
          

                int valido = 1;
                Session["nombreDeUsuario"] = txtNombreDeUsuario.Text;
                usuario.nombreDeUsuario = txtNombreDeUsuario.Text;
                usuario.clave = txtClave.Text;
                usuario.apellido = txtApellido.Text;
                usuario.nombre = txtNombre.Text;
                usuario.email = txtEmail.Text;




                //Dni

                int value = -1;

                if (int.TryParse(txtDni.Text, out value))
                {
                    value = 1;
                }
                else
                {
                    valido = 0;
                    Session["Error" + Session.SessionID] = "El dni debe contener numeros";
                    Response.Redirect("PantallaError.aspx?dni");


                }


                if (value == 1)
                {
                    usuario.dni = Convert.ToInt32(txtDni.Text);
                }


                //Telefono

                int valor = -1;

                if (int.TryParse(txtTelefono.Text, out valor))
                {
                    valor = 1;
                }
                else
                {
                    valido = 0;
                    Session["Error" + Session.SessionID] = "El telefono debe contener numeros";
                    Response.Redirect("PantallaError.aspx");
                }


                if (valor == 1)
                {
                    usuario.nroTelefono = Convert.ToInt32(txtTelefono.Text);
                }

                if (valido == 1)
                {

                    bool ok = UsuarioNegocio.verificar(usuario);
                    if (ok == false)
                    {
                        UsuarioNegocio.agregar(usuario);
                        Response.Redirect("Login.aspx");
                    }
                    else
                    {
                        Session["Error" + Session.SessionID] = "El nombre de usuario ya esta en uso";
                        Response.Redirect("PantallaError.aspx");
                    }
                }

            }
        


    }
}
