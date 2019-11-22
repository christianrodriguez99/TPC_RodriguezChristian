using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Publicacion
    {
        

        public int id { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public string urlImagen { get; set; }
        public int stock { get; set; }
        public decimal precio { get; set; }
        public Producto producto { get; set; }
        public bool estado { get; set; }
        public Usuario usuario { get; set; }
        public Categoria categoria { get; set; }
        public Marca marca { get; set; }
        public string estadoProducto { get; set; }
    }
}
