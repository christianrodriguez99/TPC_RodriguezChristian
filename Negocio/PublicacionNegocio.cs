using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio
{
    public class PublicacionNegocio
    {
        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("delete from Publicaciones where id =" + id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int obtenerstockActual(int idPublicacion)
        {


            AccesoDatos datos = new AccesoDatos();
            try
            {
                int resultado;

                datos.setearQuery("select stock from Publicaciones where id = @id");
                datos.agregarParametro("@id", idPublicacion);
                datos.ejecutarLector();
                datos.lector.Read();
                resultado = datos.lector.GetInt32(0);



                return resultado;

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

            public void agregar(Publicacion Publicacion)
            {
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearQuery("insert into Publicaciones (titulo,descripcion,urlimagen,stock,precio,estado,idMarca,idCategoria,idUsuario)values(@titulo,@descripcion,@urlImagen,@stock,@precio,@estado,@idMarca,@idCategoria,@idUsuario)");
                datos.agregarParametro("@titulo", Publicacion.titulo);
                datos.agregarParametro("@descripcion", Publicacion.descripcion);
                datos.agregarParametro("@urlImagen", Publicacion.urlImagen);
                datos.agregarParametro("@stock", Publicacion.stock);
                datos.agregarParametro("@precio", Publicacion.precio);
                datos.agregarParametro("@estado", Publicacion.estado);
                datos.agregarParametro("@idmarca", Publicacion.marca.id);
                datos.agregarParametro("@idcategoria", Publicacion.categoria.id);
                datos.agregarParametro("@idusuario", Publicacion.usuario.id);
                datos.ejecutarAccion();

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

    

        public void modificarStock(int id, int stock)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Update Publicaciones set stock=@stock Where id=@Id");
                datos.agregarParametro("@stock", stock);
                datos.agregarParametro("@Id", id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificar(Publicacion Publicacion)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Update Publicaciones set nombre=@Nombre Where id=@Id");
                datos.agregarParametro("@Nombre", Publicacion.titulo);
                datos.agregarParametro("@Id", Publicacion.id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Publicacion> listar()
        {
            List<Publicacion> lista = new List<Publicacion>();
            Publicacion aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("SELECT * FROM Publicaciones");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Publicacion();
                    aux.id = datos.lector.GetInt32(0);
                    aux.titulo = datos.lector.GetString(1);
                    aux.descripcion = datos.lector.GetString(2);
                    aux.urlImagen = datos.lector.GetString(3);
                    aux.stock = datos.lector.GetInt32(4);
                    aux.precio = datos.lector.GetDecimal(5);
                    aux.estado = datos.lector.GetBoolean(10);
                    
                  
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

        public List<Publicacion> listarPorNombre(string nombre)
        {
            List<Publicacion> lista = new List<Publicacion>();
            Publicacion aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("SELECT p.titulo,p.descripcion,p.urlimagen,p.stock,p.precio FROM Publicaciones as p  inner join Usuarios as u on p.idUsuario = u.id where u.nombreDeUsuario=@nombreDeUsuario");
                datos.agregarParametro("@nombreDeUsuario", nombre);
                datos.ejecutarLector();
                while(datos.lector.Read())
                {
                    aux = new Publicacion();
                    aux.titulo = datos.lector.GetString(0);
                    aux.descripcion = datos.lector.GetString(1);
                    aux.urlImagen = datos.lector.GetString(2);
                    aux.stock = datos.lector.GetInt32(3);
                    aux.precio = datos.lector.GetDecimal(4);



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
