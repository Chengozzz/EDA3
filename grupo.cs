using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDA3_ControlEscolar
{
    internal class grupo
    {
        private string periodo { get; set; }
        private string semestre {  get; set; }

        public grupo(string periodo, string semestre)
        {
            this.periodo = periodo;
            this.semestre = semestre;
        }
        public string Periodo { get { return this.periodo; } }
        public string Semestre { get {  return this.semestre; } }
    }
}
