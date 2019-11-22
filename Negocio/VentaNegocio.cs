using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;

namespace Negocio
{
    public class VentaNegocio
    {
        public void agregar(Venta venta)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearQuery("insert into Ventas (cantidad,idUsuarioVendedor,idUsuarioComprador,idPublicacion,fecha,precioTotal) values (@cantidad,@idUsuarioVendedor,@idUsuarioComprador,@idPublicacion,@fecha,@precioTotal)");
                datos.agregarParametro("@cantidad", venta.cantidad);
                datos.agregarParametro("@idUsuarioComprador", venta.comprador.id);
                datos.agregarParametro("@idUsuarioVendedor", venta.vendedor.id);           
                datos.agregarParametro("@idPublicacion", venta.publicacion.id);
                datos.agregarParametro("@fecha", venta.fecha);
                datos.agregarParametro("@precioTotal",venta.precioTotal);
                datos.ejecutarAccion();

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

     

        public List<Venta> listar()
        {
            List<Venta> lista = new List<Venta>();
            Venta aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("SELECT * FROM Ventas where id=@id");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Venta();
                    aux.id = datos.lector.GetInt32(0);
                    aux.cantidad = datos.lector.GetInt32(1);
                    aux.fecha = datos.lector.GetDateTime(6);
                    aux.comprador.id = datos.lector.GetInt32(3);
                    aux.publicacion.id = datos.lector.GetInt32(4);


                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
                datos = null;
            }

        }
    }
}

