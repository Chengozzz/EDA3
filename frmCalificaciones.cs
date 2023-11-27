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
    public partial class frmCalificaciones : Form
    {
        public frmCalificaciones()
        {
            InitializeComponent();
        }
        SqlConnection conexionDB = new SqlConnection("Data Source=CHENGOPC\\SQLEXPRESS;Initial Catalog=\"EDA 3\";Integrated Security=True");

        private void frmCalificaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'eDA_3DataSet.materias' Puede moverla o quitarla según sea necesario.
            this.materiasTableAdapter.Fill(this.eDA_3DataSet.materias);
            // TODO: esta línea de código carga datos en la tabla 'eDA_3DataSet.alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.eDA_3DataSet.alumnos);
            PopulateData();
          
        }

        private void frmCalificaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frmMenu.Show();
        }
        private void PopulateData()
        {
            // TODO: esta línea de código carga datos en la tabla 'eDA_3DataSet.calificaciones' Puede moverla o quitarla según sea necesario.
            this.calificacionesTableAdapter.Fill(this.eDA_3DataSet.calificaciones);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            conexionDB.Open();
            SqlCommand agregar = new SqlCommand("insert into calificaciones( calificacion, id_alumno, id_materia) values(@calificacion,@id_alumno,@id_materia)", conexionDB);
            //agregar.Parameters.AddWithValue("@id_persona", textBox1.Text);
            agregar.Parameters.AddWithValue("@calificacion", txt_calificacion.Text);
            agregar.Parameters.AddWithValue("@id_alumno", cmbAlumno.SelectedValue);
            agregar.Parameters.AddWithValue("@id_materia", comboBoxMateria.SelectedValue);
            agregar.ExecuteNonQuery();
            MessageBox.Show("Se agrego correctamente");
            PopulateData();
            conexionDB.Close();
        }

        private void CalificacionDataViewGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CalificacionDataViewGrid.Rows[e.RowIndex];

                string valorCeldaId = row.Cells[0].Value.ToString();
                string valorCelda1 = row.Cells[1].Value.ToString();
                string valorCelda2 = row.Cells[2].Value.ToString();
                string valorCelda3 = row.Cells[3].Value.ToString();

                txt_calificacionID.Text = valorCeldaId;
                txt_calificacion.Text = valorCelda1;
                cmbAlumno.Text = valorCelda2;
                comboBoxMateria.Text = valorCelda3;
            }
            else
            {
                throw new Exception();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexionDB.Open();
            SqlCommand borrar = new SqlCommand("delete from calificaciones where id_calificacion =@id_calificacion", conexionDB);
            borrar.Parameters.AddWithValue("@id_calificacion", txt_calificacionID.Text);
            borrar.ExecuteNonQuery();
            MessageBox.Show("calificacion Deleted Successfully!");
            PopulateData();
            conexionDB.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Calificacion calificacionNueva = new Calificacion(int.Parse(txt_calificacion.Text));
                conexionDB.Open();
            SqlCommand actualizar = new SqlCommand("UPDATE calificaciones SET calificacion = @calificacion , id_alumno = @id_alumno, id_materia = @id_materia WHERE id_alumno= @id_alumno", conexionDB);
            actualizar.Parameters.AddWithValue("@id_calificacion", txt_calificacionID.Text);
            actualizar.Parameters.AddWithValue("@calificacion", int.Parse(txt_calificacion.Text));
            actualizar.Parameters.AddWithValue("@id_alumno", cmbAlumno.SelectedValue );
            actualizar.Parameters.AddWithValue("@id_materia", comboBoxMateria.SelectedValue);
            actualizar.ExecuteNonQuery();
            MessageBox.Show("Se actulizó correctamente", "Objeto Actulizado");
            PopulateData();
            conexionDB.Close();
        }
    }
}
