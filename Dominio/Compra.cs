using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Compra
    {
        public int id { get; set; }
        public int cantidad { get; set; }
        public DateTime fecha { get; set; }
        public Usuario vendedor { get; set; }
        public Usuario comprador { get; set; }
        public Publicacion publicacion { get; set; }
        public decimal precioTotal { get; set; }
    }
}
