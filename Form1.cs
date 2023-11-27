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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace EDA3_ControlEscolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            try
            {

                InitializeComponent();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio el error:" + e.Message + "Error inesperado");
            }
        }
        SqlConnection conexionDB = new SqlConnection("Data Source=CHENGOPC\\SQLEXPRESS;Initial Catalog=\"EDA 3\";Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
        

        }
        private void PopulateData()
        {
            this.personasTableAdapter.Fill(this.eDA_3DataSet.personas);

        }

        private void button1_Click(object sender, EventArgs e) // btom añadir
        {
            persona personaNueva = new persona(textBox2.Text, textBox3.Text, textBox4.Text);
            conexionDB.Open();
            SqlCommand agregar = new SqlCommand("insert into personas(nombre,apellido_p, apellido_m) values(@nombre,@apellido_p,@apellido_m)", conexionDB);
            agregar.Parameters.AddWithValue("@nombre", personaNueva.Nombre);
            agregar.Parameters.AddWithValue("@apellido_p", personaNueva.Apellido_p);
            agregar.Parameters.AddWithValue("@apellido_m", personaNueva.Apellido_m);
            agregar.ExecuteNonQuery();
            MessageBox.Show("Se agrego correctamente", "Objeto Añadido");
            PopulateData();
            conexionDB.Close();


/*SqlCommand agregar = new SqlCommand("insert into personas(nombre,apellido_p, apellido_m) values(@nombre,@apellido_p,@apellido_m)", conexionDB);
    //agregar.Parameters.AddWithValue("@id_persona", textBox1.Text);

    agregar.Parameters.AddWithValue("@nombre", textBox2.Text);
    agregar.Parameters.AddWithValue("@apellido_p", textBox3.Text);
agregar.Parameters.AddWithValue("@apellido_m", textBox4.Text);
    agregar.ExecuteNonQuery();
MessageBox.Show("Se agrego correctamente");*/

            /*
            string consulta = "insert into alumnos ([id_persona],[matricula],[id_carrera])" + "values ('" + textBox1.Text + "', '"+textBox2.Text+"'" +
                ",'"+textBox3.Text+"')";
           SqlCommand agregar = new SqlCommand(  consulta, conexionDB );*/
        }

       


        private void button2_Click(object sender, EventArgs e)// Boton borra
        {

            conexionDB.Open();  
                SqlCommand borrar = new SqlCommand("delete from personas where id_persona=@id_persona", conexionDB);
                borrar.Parameters.AddWithValue("@id_persona", textBox1.Text);
                borrar.ExecuteNonQuery();
                MessageBox.Show("person Deleted Successfully!");
                PopulateData();
            conexionDB.Close ();
        }

        private void button3_Click(object sender, EventArgs e)//llenao de tabla 
        {
            PopulateData();
        }

        private void PersonasDataView_CellClick(object sender, DataGridViewCellEventArgs e)//rellenao de textbox selecionaod la tabla
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = PersonasDataView.Rows[e.RowIndex];

                string valorCeldaId = row.Cells[0].Value.ToString();
                string valorCelda1 = row.Cells[1].Value.ToString();
                string valorCelda2 = row.Cells[2].Value.ToString();
                string valorCelda3 = row.Cells[3].Value.ToString();

                textBox1.Text = valorCeldaId;
                textBox2.Text = valorCelda1;
                textBox3.Text = valorCelda2;
                textBox4.Text = valorCelda3;
            }
            else
            {
                throw new Exception();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frmMenu.Show();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            persona personaNueva = new persona(textBox2.Text, textBox3.Text, textBox4.Text);
            conexionDB.Open();
            //SqlCommand actualizar = new SqlCommand("update carreras SET nombre_carrera = @nuevo_nombre, descripcion = @nuevo_descripcion WHERE id_carrera = @id_carrera", connectDB);
            SqlCommand actualizar = new SqlCommand("UPDATE personas SET nombre = @nombre, apellido_p = @apellido_p, apellido_m = @apellido_m WHERE id_persona = @id_persona", conexionDB);
            actualizar.Parameters.AddWithValue("@id_persona", int.Parse(textBox1.Text));
            actualizar.Parameters.AddWithValue("@nombre", personaNueva.Nombre);
            actualizar.Parameters.AddWithValue("@apellido_p", personaNueva.Apellido_p);
            actualizar.Parameters.AddWithValue("@apellido_m", personaNueva.Apellido_m);
            actualizar.ExecuteNonQuery();
            MessageBox.Show("Se actulizó correctamente", "Objeto Actulizado");
            PopulateData();
            conexionDB.Close();
        }
    }
}
    