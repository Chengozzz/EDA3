using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDA3_ControlEscolar
{
    internal class profesor
    {
        private string nomina;

        public profesor(string nomina)
        {
            this.nomina = nomina;
        }
        public string Nomina {get { return nomina; }}
    }
}
