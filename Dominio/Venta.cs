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
        public Publicacion publicacion { get; set; }
        public Usuario vendedor { get; set; }
        public Usuario comprador { get; set; }
        public DateTime fecha { get; set; }
        
    }
}
