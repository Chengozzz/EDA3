using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EDA3_ControlEscolar
{
    public partial class frmCarrera : Form
    {
        public frmCarrera()
        {
            InitializeComponent();
        }
        SqlConnection conexionDB = new SqlConnection("Data Source=CHENGOPC\\SQLEXPRESS;Initial Catalog=\"EDA 3\";Integrated Security=True");

        private void frmCarrera_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'eDA_3DataSet.carreras' Puede moverla o quitarla según sea necesario.
            this.carrerasTableAdapter.Fill(this.eDA_3DataSet.carreras);

        }
        private void PopulateData()
        {
            this.carrerasTableAdapter.Fill(this.eDA_3DataSet.carreras);

        }



       
        private void button1_Click(object sender, EventArgs e)
        {
            carrera carreraNueva = new carrera(txtNombre.Text);

            try
            {

                conexionDB.Open();
                SqlCommand agregar = new SqlCommand("insert into carreras(nombre) values(@nombre)", conexionDB);
                //agregar.Parameters.AddWithValue("@id_persona", textBox1.Text);
                agregar.Parameters.AddWithValue("@nombre", carreraNueva.Nombre);
              
                agregar.ExecuteNonQuery();
                MessageBox.Show("Se agrego correctamente", "Objeto agregado");
                PopulateData();
                txtNombre.Text = null;
                conexionDB.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror al agregar" + ex.Message);
            }
        }

        private void frmCarrera_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frmMenu.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string valorCeldaId = row.Cells[0].Value.ToString();
                string valorCelda1 = row.Cells[1].Value.ToString();

                txtID.Text = valorCeldaId;
                txtNombre.Text = valorCelda1;
            }
            else
            {
                throw new Exception();
            }
        }
        private void limpiezatxt()
        {
            txtID.Text = null;
            txtNombre.Text = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != null)
                {
                    conexionDB.Open();
                    SqlCommand borrar = new SqlCommand("delete from carreras where id_carreras=@id_carreras", conexionDB);
                    borrar.Parameters.AddWithValue("@id_carreras", txtID.Text);
                    borrar.ExecuteNonQuery();
                    MessageBox.Show("college career Deleted Successfully!");
                    PopulateData();
                    limpiezatxt();
                    conexionDB.Close();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            carrera carreraNueva = new carrera(txtNombre.Text);
            conexionDB.Open();
            SqlCommand actualizar = new SqlCommand("UPDATE carreras SET nombre = @nombre WHERE id_carreras = @id_carreras", conexionDB);
            actualizar.Parameters.AddWithValue("@id_carreras", txtID.Text);
            actualizar.Parameters.AddWithValue("@nombre", carreraNueva.Nombre );
            actualizar.ExecuteNonQuery();
            MessageBox.Show("Se actulizó correctamente", "Objeto Actulizado");
            PopulateData();
            conexionDB.Close();//No funcioan
        }
    }
}
