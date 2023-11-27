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
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }
        SqlConnection conexionDB = new SqlConnection("Data Source=CHENGOPC\\SQLEXPRESS;Initial Catalog=\"EDA 3\";Integrated Security=True");

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'eDA_3DataSet.carreras' Puede moverla o quitarla según sea necesario.
            this.carrerasTableAdapter.Fill(this.eDA_3DataSet.carreras);
            // TODO: esta línea de código carga datos en la tabla 'eDA_3DataSet.personas' Puede moverla o quitarla según sea necesario.
            this.personasTableAdapter.Fill(this.eDA_3DataSet.personas);
            // TODO: esta línea de código carga datos en la tabla 'eDA_3DataSet.personas' Puede moverla o quitarla según sea necesario.
            this.personasTableAdapter.Fill(this.eDA_3DataSet.personas);
            // TODO: esta línea de código carga datos en la tabla 'eDA_3DataSet.alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.eDA_3DataSet.alumnos);

        }
        private void PopulateData()
        {
            this.alumnosTableAdapter.Fill(this.eDA_3DataSet.alumnos);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void limpiezatxt()
        {
            comboBoxPersona.Text = null;
            comboBoxPersona.Text = null;
            comboID.Text = null;
            txtMatricula.Text = null;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            alumno alumnoNuevo = new alumno( txtMatricula.Text);
            try
            {

                conexionDB.Open();
                SqlCommand agregar = new SqlCommand("insert into alumnos(id_persona,matricula, id_carrera) values(@id_persona,@matricula,@id_carrera)", conexionDB);
                //agregar.Parameters.AddWithValue("@id_persona", textBox1.Text);
                agregar.Parameters.AddWithValue("@id_persona", comboBoxPersona.SelectedValue);
                agregar.Parameters.AddWithValue("@matricula", alumnoNuevo.Matricula);
                agregar.Parameters.AddWithValue("@id_carrera", comboBoxCarrera.SelectedValue);
                agregar.ExecuteNonQuery();
                MessageBox.Show("Se agrego correctamente", "Objeto agregado");
                PopulateData();
                limpiezatxt();
                conexionDB.Close();

            }
            catch (Exception ex )
            {
                MessageBox.Show( "Eror al agregar" + ex.Message);
            }    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BotonDataViewGrid_Click(object sender, EventArgs e)

        {
            PopulateData();
        }

        private void frmAlumnos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frmMenu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int idAEliminar = Convert.ToInt32(AlumnosDataViewGrid.SelectedRows[0].Cells["id_alumno"].Value);
            try
            {
                if (comboID.Text != null)
                {
                    conexionDB.Open();
                    SqlCommand borrar = new SqlCommand("delete from alumnos where id_alumno=@id_alumno", conexionDB);
                    borrar.Parameters.AddWithValue("@id_alumno", comboID.Text);
                    borrar.ExecuteNonQuery();
                    MessageBox.Show("alumn Deleted Successfully!");
                    PopulateData();
                    limpiezatxt();
                    conexionDB.Close();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show( "Error al borrar"+ ex.Message);
            }

            // programar este boton y el cell click en el data view grid
        }

        private void AlumnosDataViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AlumnosDataViewGrid_CellClick(object sender, DataGridViewCellEventArgs e)//rellenao 
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = AlumnosDataViewGrid.Rows[e.RowIndex];

                string valorCeldaId = row.Cells[0].Value.ToString();
                string valorCelda1 = row.Cells[1].Value.ToString();
                string valorCelda2 = row.Cells[2].Value.ToString();
                string valorCelda3 = row.Cells[3].Value.ToString();

                comboID.Text = valorCeldaId;
                comboBoxPersona.Text = valorCelda1;
                txtMatricula.Text = valorCelda2;
                comboBoxCarrera.Text = valorCelda3;
            }
            else
            {
                throw new Exception();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnACtulizar_Click(object sender, EventArgs e)
        {
            alumno alumnoNuevo = new alumno(txtMatricula.Text);
            conexionDB.Open();
            SqlCommand actualizar = new SqlCommand("UPDATE alumnos SET id_persona = @id_persona  ,matricula = @matricula, id_carrera = @id_carrera WHERE id_alumno= @id_alumno", conexionDB);
            actualizar.Parameters.AddWithValue("@id_alumno", comboID.SelectedValue);
            actualizar.Parameters.AddWithValue("@id_persona", comboBoxPersona.SelectedValue);
            actualizar.Parameters.AddWithValue("@matricula", alumnoNuevo.Matricula);
            actualizar.Parameters.AddWithValue("@id_carrera", comboBoxCarrera.SelectedValue);
            actualizar.ExecuteNonQuery();
            MessageBox.Show("Se actulizó correctamente", "Objeto Actulizado");
            PopulateData();
            conexionDB.Close();
        }
    }
}
