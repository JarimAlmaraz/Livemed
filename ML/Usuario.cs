using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apaterno { get; set; }
        public string  Amaterno { get; set; }
        public ML.Especialidades Especialidades { get; set; }
        public ML.Estados Estados { get; set; }
        public ML.Paises Paises { get; set; }
        public List<object> Usuarios { get; set; }
    }
}
