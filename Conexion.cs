using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDA3_ControlEscolar
{
    internal class Conexion
    {
        public SqlConnection conexion;
        public void conectar()
        {

            conexion = new SqlConnection();

            conexion.ConnectionString = "Data Source=CHENGOPC\\SQLEXPRESS;Initial Catalog=ControlEscolar;Integrated Security=True";
            try
            {
                conexion.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        public void desconectar()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}
