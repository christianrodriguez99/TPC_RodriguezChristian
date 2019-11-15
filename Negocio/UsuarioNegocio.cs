using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class UsuarioNegocio
    {
            public void eliminar(int id)
            {
                AccesoDatos datos = new AccesoDatos();
                try
                {
                    datos.setearQuery("delete from Usuarios where id =" + id);
                    datos.ejecutarAccion();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void agregar(Usuario Usuario)
            {
                AccesoDatos datos = new AccesoDatos();

                try
                {

                    datos.setearQuery("insert into Usuarios (titulo,descripcion,urlimagen,stock,precio,estado,idMarca,idCategoria)values(@titulo,@descripcion,@urlImagen,stock,@precio,@estado,@idMarca,@idCategoria)");
                    datos.agregarParametro("@titulo", Usuario.nombreDeUsuario);

                    datos.ejecutarAccion();

                }

                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void modificar(Usuario Usuario)
            {
                AccesoDatos datos = new AccesoDatos();
                try
                {
                    datos.setearQuery("Update Usuarios set nombre=@Nombre Where id=@Id");
                    datos.agregarParametro("@Nombre", Usuario.nombre);
                    datos.agregarParametro("@Id", Usuario.id);

                    datos.ejecutarAccion();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<Usuario> listar()
            {
                List<Usuario> lista = new List<Usuario>();
                Usuario aux;
                AccesoDatos datos = new AccesoDatos();
                try
                {
                    datos.setearQuery("SELECT * FROM Usuarios");
                    datos.ejecutarLector();
                    while (datos.lector.Read())
                    {
                        aux = new Usuario();
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

