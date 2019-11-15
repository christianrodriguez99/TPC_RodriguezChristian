using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Venta
    {
        public int id { get; set; }
        public int cantidad { get; set; }
        public DateTime fecha { get; set; }
        public Producto producto { get; set; }
    }
}
