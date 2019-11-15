using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Categoria categoria { get; set; }
        public Marca marca { get; set; }
      
    }
}
