using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("delete from Marcas where id =" + id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregar(Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearQuery("insert into Marcas (nombre,estado)values(@nombre,@estado)");
                datos.agregarParametro("@nombre", marca.nombre);
                datos.agregarParametro("@estado", marca.estado);
                datos.ejecutarAccion();

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificar(Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Update Marcas set nombre=@Nombre Where id=@Id");
                datos.agregarParametro("@Nombre", marca.nombre);
                datos.agregarParametro("@Id", marca.id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            Marca aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("SELECT m.id,m.NOMBRE FROM marcas AS m where m.estado = 1");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Marca();
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
