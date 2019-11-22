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



        public List<Venta> listarPorNombre(string nombre)
        {
            List<Venta> lista = new List<Venta>();
            Venta aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("SELECT v.cantidad,v.fecha,p.id,p.titulo,v.precioTotal,ve.id,c.id FROM Ventas as v  inner join Publicaciones as p on v.idPublicacion=p.id inner join Usuarios as ve on ve.id = v.idUsuarioVendedor inner join Usuarios as c on c.id = v.idUsuarioComprador where c.nombreDeUsuario = @nombreDeUsuario");
                datos.agregarParametro("@nombreDeUsuario", nombre);
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Venta();
                    aux.cantidad = datos.lector.GetInt32(0);
                    aux.fecha = datos.lector.GetDateTime(1);
                    aux.publicacion = new Publicacion();
                    aux.publicacion.id = datos.lector.GetInt32(2);
                    aux.publicacion.titulo = datos.lector.GetString(3);
                    aux.precioTotal = datos.lector.GetDecimal(4);
                    aux.vendedor = new Usuario();
                    aux.comprador = new Usuario();
                    aux.vendedor.id = datos.lector.GetInt32(5);
                    aux.comprador.id = datos.lector.GetInt32(6);

                 
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


