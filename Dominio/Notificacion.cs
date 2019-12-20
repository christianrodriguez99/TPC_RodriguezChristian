using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Notificacion
    {
        public int id { get; set; }
        public Usuario usuario { get; set; }
        public string descripcion { get; set; }
    }
}
