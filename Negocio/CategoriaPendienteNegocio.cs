using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriaPendienteNegocio
    {
        public void agregar(CategoriaPendiente categoriaPendiente)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearQuery("insert into CategoriasPendientes (nombre,idUsuario,estado) values (@nombre,@idUsuario,@estado)");
                datos.agregarParametro("@nombre", categoriaPendiente.nombre);
                datos.agregarParametro("@idUsuario", categoriaPendiente.usuario.id);
                datos.agregarParametro("@estado", categoriaPendiente.estado);
                datos.ejecutarAccion();

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CategoriaPendiente> listar()
        {
            List<CategoriaPendiente> lista = new List<CategoriaPendiente>();
            CategoriaPendiente aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("select cp.id,cp.nombre,cp.estado,u.nombreDeUsuario, u.id from CategoriasPendientes as cp inner join Usuarios as u on cp.idUsuario = u.id");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new CategoriaPendiente();
                    aux.id = datos.lector.GetInt32(0);
                    aux.nombre = datos.lector.GetString(1);
                    aux.usuario = new Usuario();
                    aux.estado = datos.lector.GetBoolean(2);
                    aux.usuario.nombreDeUsuario = datos.lector.GetString(3);
                    aux.usuario.id = datos.lector.GetInt32(4);


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

        public bool verificar(string nombre)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearQuery("select Count(nombre) from CategoriasPendientes where nombre = @nombre");
                datos.agregarParametro("@nombre", nombre);
                datos.conexion.Open();
                Int32 count = Convert.ToInt32(datos.comando.ExecuteScalar());
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool verificar2(string nombre)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearQuery("select Count(nombre) from Categorias where nombre = @nombre");
                datos.agregarParametro("@nombre", nombre);
                datos.conexion.Open();
                Int32 count = Convert.ToInt32(datos.comando.ExecuteScalar());
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("delete from CategoriasPendientes where id =" + id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
