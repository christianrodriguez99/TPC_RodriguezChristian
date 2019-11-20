using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPC_RodriguezChristian
{
    public partial class PantallaError : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e, string url)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
           
            if (Request.Url.AbsoluteUri== "https://localhost:44394/PantallaError?dni")
            {
                Response.Redirect("PantallaCrearUsuario.aspx");
            }
            Response.Redirect(Request.UrlReferrer.ToString());
            
        }
    }
}