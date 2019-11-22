using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;
namespace Negocio
{
    public class CompraNegocio
    {
        public void agregar(Compra compra)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearQuery("insert into Compras (cantidad,idUsuarioVendedor,idUsuarioComprador,idPublicacion,fecha,preciototal) values (@cantidad,@idUsuarioVendedor,@idUsuarioComprador,@idPublicacion,@fecha,@precioTotal)");
                datos.agregarParametro("@idUsuarioComprador", compra.comprador.id);
                datos.agregarParametro("@idUsuarioVendedor", compra.vendedor.id);
                datos.agregarParametro("@cantidad", compra.cantidad);
                datos.agregarParametro("@fecha", compra.fecha);
                datos.agregarParametro("@idPublicacion", compra.publicacion.id);
                datos.agregarParametro("@precioTotal", compra.publicacion.id);
                datos.ejecutarAccion();

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
