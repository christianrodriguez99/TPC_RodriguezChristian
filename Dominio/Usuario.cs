using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int id { get; set; }
        public string nombreDeUsuario{ get; set; }
        public string clave { get; set; }
        public int dni { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public int nroTelefono { get; set; }
        public bool estado { get; set; }
        public decimal dinero { get; set; }

    }
}
