using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NotificacionNegocio
    {
        public void agregar(Notificacion notificicacion)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearQuery("insert into Notificaciones (descripcion,idUsuario)values(@descripcion,@idUsuario)");
                datos.agregarParametro("@descripcion", notificicacion.descripcion);
                datos.agregarParametro("@idUsuario", notificicacion.usuario.id);
                datos.ejecutarAccion();

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Notificacion> listar(string usuario)
        {
            List<Notificacion> lista = new List<Notificacion>();
            Notificacion aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("SELECT n.id,n.descripcion,u.nombreDeUsuario FROM notificaciones AS n inner join Usuarios as u on n.idUsuario=u.id where u.nombreDeUsuario = @nombre");
                datos.agregarParametro("@nombre", usuario);
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Notificacion();
                    aux.descripcion = datos.lector.GetString(1);
                    //aux.usuario = new Usuario();
                    //aux.usuario.id = datos.lector.GetInt32(2);

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
