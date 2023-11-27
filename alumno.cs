using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDA3_ControlEscolar
{
    internal class alumno
    {
        private string matricula { set; get; }


        public alumno( string matricula)
        {
            this.matricula = matricula;

        }

        public string Matricula { get { return matricula; } }



    }
}
