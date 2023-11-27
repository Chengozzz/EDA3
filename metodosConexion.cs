using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDA3_ControlEscolar
{
    internal class metodosConexion
    {
        public String GetString(String consulta)
        {
            String resultado = "-1";
            Conexion c = new Conexion();
            SqlCommand comando = new SqlCommand();
            c.conectar();
            try
            {
                comando = new SqlCommand(consulta, c.conexion);
                resultado = comando.ExecuteScalar().ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            c.desconectar();
            return resultado;
        }
        public int Getint(String consulta)
        {
            String band = "-1";
            Conexion c = new Conexion();
            SqlCommand comando = new SqlCommand();
            c.conectar();
            try
            {
                comando = new SqlCommand(consulta, c.conexion);
                band = comando.ExecuteScalar().ToString();

            }
            catch
            {
                band = "-1";
            }
            c.desconectar();
            return Convert.ToInt32(band);
        }
        public DataSet GetTabla(String consulta)
        {
            Conexion c = new Conexion();
            SqlCommand comando;
            SqlDataAdapter adap = new SqlDataAdapter();
            DataSet ds = new DataSet();
            c.conectar();
            try
            {
                comando = new SqlCommand(consulta, c.conexion);
                adap.SelectCommand = comando;
                adap.Fill(ds);
                adap.Dispose();
                comando.Dispose();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            c.desconectar();
            return ds;
        }

        public int InsertarDato(String insert)
        {
            int band = -1;
            Conexion c = new Conexion();
            SqlCommand cmd = new SqlCommand();
            String consulta = insert;
            c.conectar();
            try
            {
                cmd = new SqlCommand(consulta, c.conexion);
                band = cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            c.desconectar();
            return band;
        }
    }
}
