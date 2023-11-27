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

namespace EDA3_ControlEscolar
{
    public partial class frmMateria : Form
    {
        public frmMateria()
        {
            InitializeComponent();
        }
        SqlConnection conexionDB = new SqlConnection("Data Source=CHENGOPC\\SQLEXPRESS;Initial Catalog=\"EDA 3\";Integrated Security=True");

        private void frmMateria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'eDA_3DataSet.materias' Puede moverla o quitarla según sea necesario.
            this.materiasTableAdapter.Fill(this.eDA_3DataSet.materias);

        }
        public void PopulateData()
        {
            this.materiasTableAdapter.Fill(this.eDA_3DataSet.materias);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            materia materiaNueva = new materia(txtNombre.Text);

            conexionDB.Open();

            SqlCommand agregar = new SqlCommand("insert into materias(nombre) values(@nombre)", conexionDB);
            //agregar.Parameters.AddWithValue("@id_persona", textBox1.Text);
            agregar.Parameters.AddWithValue("@nombre", materiaNueva.Nombre);
            
            agregar.ExecuteNonQuery();
            MessageBox.Show("Se agrego correctamente", "Objeto agregado");
            PopulateData();
            limpiezatxt();
            conexionDB.Close();

        }

        private void frmMateria_FormClosed(object sender, FormClosedEventArgs e)
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
            txtID.Text = null
        ; txtNombre.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexionDB.Open();
            SqlCommand borrar = new SqlCommand("delete from materias where id_materia=@id_materia", conexionDB);
            borrar.Parameters.AddWithValue("@id_materia", txtID.Text);
            borrar.ExecuteNonQuery();
            MessageBox.Show("subjet Deleted Successfully!");
            PopulateData();
            limpiezatxt();
            conexionDB.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            materia materiaNueva = new materia(txtNombre.Text);

            conexionDB.Open();

            SqlCommand actualizar = new SqlCommand("update materias set nombre= @nombre WHERE id_materia = @id_materia ", conexionDB);
            //agregar.Parameters.AddWithValue("@id_persona", textBox1.Text);
            actualizar.Parameters.AddWithValue("@id_materia", txtID.Text);
            actualizar.Parameters.AddWithValue("@nombre", materiaNueva.Nombre);

            actualizar.ExecuteNonQuery();
            MessageBox.Show("Se agrego correctamente", "Objeto agregado");
            PopulateData();
            limpiezatxt();
            conexionDB.Close();//termoinar
        }
    }
}
