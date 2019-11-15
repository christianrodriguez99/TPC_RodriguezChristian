using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("delete from Categorias where id =" + id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregar(Categoria categoria)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearQuery("insert into Categorias (nombre,estado)values(@nombre,@estado)");
                datos.agregarParametro("@nombre", categoria.nombre);
                datos.agregarParametro("@estado", categoria.estado);
                datos.ejecutarAccion();

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificar(Categoria categoria)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Update Categorias set nombre=@Nombre Where id=@Id");
                datos.agregarParametro("@Nombre", categoria.nombre);
                datos.agregarParametro("@Id", categoria.id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            Categoria aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("SELECT c.id,c.NOMBRE FROM Categorias AS c where c.estado = 1");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Categoria();
                    aux.id = datos.lector.GetInt32(0);
                    aux.nombre = datos.lector.GetString(1);

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
