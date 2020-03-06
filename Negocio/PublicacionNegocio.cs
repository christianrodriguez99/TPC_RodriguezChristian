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
                datos.setearQuery("Update Publicaciones set estado=0 Where id=@Id");
                datos.agregarParametro("@Id", id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarxId(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Update Publicaciones set estado=0 Where idUsuario=@Id");
                datos.agregarParametro("@Id", id);

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

                datos.setearQuery("insert into Publicaciones (titulo,descripcion,urlimagen,stock,precio,estado,idMarca,idCategoria,idUsuario,estadoProducto)values(@titulo,@descripcion,@urlImagen,@stock,@precio,@estado,@idMarca,@idCategoria,@idUsuario,@estadoProducto)");
                datos.agregarParametro("@titulo", Publicacion.titulo);
                datos.agregarParametro("@descripcion", Publicacion.descripcion);
                datos.agregarParametro("@urlImagen", Publicacion.urlImagen);
                datos.agregarParametro("@stock", Publicacion.stock);
                datos.agregarParametro("@precio", Publicacion.precio);
                datos.agregarParametro("@estado", Publicacion.estado);
                datos.agregarParametro("@idmarca", Publicacion.marca.id);
                datos.agregarParametro("@idcategoria", Publicacion.categoria.id);
                datos.agregarParametro("@idusuario", Publicacion.usuario.id);
                datos.agregarParametro("@estadoProducto", Publicacion.estadoProducto);
                datos.ejecutarAccion();

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificar(Publicacion Publicacion, int id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearQuery("update Publicaciones set titulo = @titulo,descripcion =@descripcion,urlimagen=@urlImagen,stock=@stock,precio=@precio,estado=@estado,idMarca=@idMarca,idCategoria=@idCategoria,idUsuario=@idUsuario,estadoProducto=@estadoProducto where id = @id");
                datos.agregarParametro("@titulo", Publicacion.titulo);
                datos.agregarParametro("@descripcion", Publicacion.descripcion);
                datos.agregarParametro("@urlImagen", Publicacion.urlImagen);
                datos.agregarParametro("@stock", Publicacion.stock);
                datos.agregarParametro("@precio", Publicacion.precio);
                datos.agregarParametro("@estado", Publicacion.estado);
                datos.agregarParametro("@idmarca", Publicacion.marca.id);
                datos.agregarParametro("@idcategoria", Publicacion.categoria.id);
                datos.agregarParametro("@idusuario", Publicacion.usuario.id);
                datos.agregarParametro("@estadoProducto", Publicacion.estadoProducto);
                datos.agregarParametro("@Id", id);
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
                datos.setearQuery("SELECT * FROM Publicaciones where estado = 1");
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
                    aux.estadoProducto = datos.lector.GetString(11);
                    
                  
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
                datos.setearQuery("SELECT p.id,p.titulo,p.descripcion,p.urlimagen,p.stock,p.precio FROM Publicaciones as p  inner join Usuarios as u on p.idUsuario = u.id where u.nombreDeUsuario=@nombreDeUsuario and p.estado=1");
                datos.agregarParametro("@nombreDeUsuario", nombre);
                datos.ejecutarLector();
                while(datos.lector.Read())
                {
                    aux = new Publicacion();
                    aux.id = datos.lector.GetInt32(0);
                    aux.titulo = datos.lector.GetString(1);
                    aux.descripcion = datos.lector.GetString(2);
                    aux.urlImagen = datos.lector.GetString(3);
                    aux.stock = datos.lector.GetInt32(4);
                    aux.precio = datos.lector.GetDecimal(5);



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
