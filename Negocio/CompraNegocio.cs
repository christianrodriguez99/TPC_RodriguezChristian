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

        public List<Compra> listarPorNombre(string nombre)
        {
            List<Compra> lista = new List<Compra>();
            Compra aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("SELECT c.cantidad,c.fecha,p.id,p.titulo,c.precioTotal,ve.id,co.id,ve.nombreDeUsuario FROM Compras as c  inner join Publicaciones as p on c.idPublicacion=p.id inner join Usuarios as ve on ve.id = c.idUsuarioVendedor inner join Usuarios as co on co.id = c.idUsuarioComprador where co.nombreDeUsuario = @nombreDeUsuario");
                datos.agregarParametro("@nombreDeUsuario", nombre);
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Compra();
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
                    aux.vendedor.nombreDeUsuario = datos.lector.GetString(7);


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
