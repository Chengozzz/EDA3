using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDA3_ControlEscolar
{
    internal class persona
    {
 
        private string nombre { get; set; }
        private string apellido_p { get; set; }
        private string apellido_m { get; set; }

        public persona( string nombre, string apellido_p, string apellido_m)
        {
            this.nombre = nombre;
            this.apellido_p = apellido_p;
            this.apellido_m = apellido_m;
        }
        public string Nombre { get { return nombre; } }
        public string Apellido_p { get {  return apellido_p; } }
        public string Apellido_m { get { return apellido_m;  } }
    }
}
