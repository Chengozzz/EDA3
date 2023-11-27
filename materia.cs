using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDA3_ControlEscolar
{
    internal class materia
    {
        private string nombre { get; set; }
        public materia(string nombre)
        {
            this.nombre = nombre;
        }
        public string Nombre { get {  return nombre; } }
    }
}
