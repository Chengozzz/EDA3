using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDA3_ControlEscolar
{
    internal class carrera
    {
        private string nombre;

        public carrera(string nombre) {
            this.nombre = nombre;
            
        }
        public string Nombre { get { return nombre; } }
    }
}
