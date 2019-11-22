using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;

namespace Negocio
{
    public class CompraPendienteNegocio
    {
        public void agregar(CompraPendiente compraPendiente)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearQuery("insert into ComprasPendientes (cantidad,idUsuarioVendedor,idUsuarioComprador,idPublicacion,fecha,precioTotal) values (@cantidad,@idUsuarioVendedor,@idUsuarioComprador,@idPublicacion,@fecha,@precioTotal)");
                datos.agregarParametro("@idUsuarioComprador", compraPendiente.comprador.id);
                datos.agregarParametro("@idUsuarioVendedor", compraPendiente.vendedor.id);
                datos.agregarParametro("@cantidad", compraPendiente.cantidad);
                datos.agregarParametro("@fecha", compraPendiente.fecha);
                datos.agregarParametro("@idPublicacion", compraPendiente.publicacion.id);
                datos.agregarParametro("@precioTotal", compraPendiente.precioTotal);
                datos.ejecutarAccion();

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CompraPendiente> listar()
        {
            List<CompraPendiente> lista = new List<CompraPendiente>();
            CompraPendiente aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("select cp.id,cp.cantidad,cp.fecha,cp.preciototal,p.id,p.titulo,uc.nombreDeUsuario,uc.id,uv.id from ComprasPendientes as cp inner join Publicaciones as p on cp.idPublicacion = p.id inner join Usuarios as uc on cp.idUsuarioComprador = uc.id inner join Usuarios as uv on cp.idUsuarioVendedor = uv.id where p.estado = 1");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new CompraPendiente();
                    aux.id = datos.lector.GetInt32(0);
                    aux.cantidad = datos.lector.GetInt32(1);
                    aux.fecha = datos.lector.GetDateTime(2);
                    aux.precioTotal = datos.lector.GetDecimal(3);
                    aux.publicacion = new Publicacion();
                    aux.publicacion.id = datos.lector.GetInt32(4);
                    aux.publicacion.titulo = datos.lector.GetString(5);
                    aux.comprador = new Usuario();
                    aux.vendedor = new Usuario();
                    aux.comprador.nombreDeUsuario = datos.lector.GetString(6);
                    aux.comprador.id = datos.lector.GetInt32(7);
                    aux.vendedor.id = datos.lector.GetInt32(8);




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


        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("delete from ComprasPendientes where id =" + id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

     

    }
}
