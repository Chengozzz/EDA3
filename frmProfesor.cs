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
    public partial class frmProfesor : Form
    {
        public frmProfesor()
        {
            InitializeComponent();
        }
        SqlConnection conexionDB = new SqlConnection("Data Source=CHENGOPC\\SQLEXPRESS;Initial Catalog=\"EDA 3\";Integrated Security=True");

        private void frmProfesor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'eDA_3DataSet.personas' Puede moverla o quitarla según sea necesario.
            this.personasTableAdapter.Fill(this.eDA_3DataSet.personas);
            // TODO: esta línea de código carga datos en la tabla 'eDA_3DataSet.profesores' Puede moverla o quitarla según sea necesario.
            this.profesoresTableAdapter.Fill(this.eDA_3DataSet.profesores);

        }
        private void PopulateData()
        {
            this.profesoresTableAdapter.Fill(this.eDA_3DataSet.profesores);

        }
        private void frmProfesor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frmMenu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            profesor profesorNuevo = new profesor(txtNomina.Text);

            conexionDB.Open();
            SqlCommand agregar = new SqlCommand("insert into profesores(nomina, id_persona) values(@nomina, @id_persona)", conexionDB );
            agregar.Parameters.AddWithValue("@nomina", profesorNuevo.Nomina);
            agregar.Parameters.AddWithValue("@id_persona", comboBox1.SelectedValue);
            agregar.ExecuteNonQuery();
            MessageBox.Show("Se agrego correctamente", "Objeto Añadido");
            PopulateData();
            conexionDB.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexionDB.Open();
            SqlCommand borrar = new SqlCommand("delete from profesores where id_profesores=@id_profesores", conexionDB);
            borrar.Parameters.AddWithValue("@id_profesores", txt_profesore.Text);
            borrar.ExecuteNonQuery();
            MessageBox.Show("person Deleted Successfully!");
            PopulateData();
            conexionDB.Close();
        }

        private void profesorDataViewGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = profesorDataViewGrid.Rows[e.RowIndex];

                string valorCeldaId = row.Cells[0].Value.ToString();
                string valorCelda1 = row.Cells[1].Value.ToString();
                string valorCelda2 = row.Cells[2].Value.ToString();

                txt_profesore.Text = valorCeldaId;
                txtNomina.Text = valorCelda1;
                comboBox1.Text = valorCelda2;
            }
            else
            {
                throw new Exception();
            }
        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            profesor profesorNuevo = new profesor(txtNomina.Text);
            
            conexionDB.Open();
            SqlCommand actualizar = new SqlCommand("UPDATE profesores SET nomina = @nomina " +
                "WHERE id_profesores = @id_profesores", conexionDB);
            actualizar.Parameters.AddWithValue("@id_profesores", int.Parse(txt_profesore.Text));
            actualizar.Parameters.AddWithValue("@nomina", txtNomina.Text);
            actualizar.ExecuteNonQuery();
            MessageBox.Show("Se actulizó correctamente", "Objeto Actulizado");
            PopulateData();
            conexionDB.Close();
        }
    }
}
