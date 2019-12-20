using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcaPendienteNegocio
    {
        public void agregar(MarcaPendiente MarcaPendiente)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearQuery("insert into MarcasPendientes (nombre,idUsuario,estado) values (@nombre,@idUsuario,@estado)");
                datos.agregarParametro("@nombre", MarcaPendiente.nombre);
                datos.agregarParametro("@idUsuario", MarcaPendiente.usuario.id);
                datos.agregarParametro("@estado", MarcaPendiente.estado);
                datos.ejecutarAccion();

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MarcaPendiente> listar()
        {
            List<MarcaPendiente> lista = new List<MarcaPendiente>();
            MarcaPendiente aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("select mp.id,mp.nombre,mp.estado,u.nombreDeUsuario,u.id from MarcasPendientes as mp inner join Usuarios as u on mp.idUsuario = u.id");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new MarcaPendiente();
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


        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("delete from MarcasPendientes where id =" + id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool verificar(string nombre)
        {
           
                AccesoDatos datos = new AccesoDatos();

                try
                {

                    datos.setearQuery("select Count(nombre) from MarcasPendientes where nombre = @nombre");
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

                datos.setearQuery("select Count(nombre) from Marcas where nombre = @nombre");
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
    }
}
