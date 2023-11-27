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
    public partial class frmGrupo : Form
    {
        public frmGrupo()
        {
            InitializeComponent();
        }
        SqlConnection conexionDB = new SqlConnection("Data Source=CHENGOPC\\SQLEXPRESS;Initial Catalog=\"EDA 3\";Integrated Security=True");

        private void frmGrupo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'eDA_3DataSet.grupos' Puede moverla o quitarla según sea necesario.
            this.gruposTableAdapter.Fill(this.eDA_3DataSet.grupos);

        }
        private void PopulateData()
        {
            this.gruposTableAdapter.Fill(this.eDA_3DataSet.grupos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grupo grupoN = new grupo(txtSemestre.Text, txt_Periodo.Text);
            conexionDB.Open();
            SqlCommand agregar = new SqlCommand("insert into grupos(semestre, periodo) values(@semestre, @periodo)", conexionDB);
            //agregar.Parameters.AddWithValue("@id_persona", textBox1.Text);
            agregar.Parameters.AddWithValue("@semestre", grupoN.Semestre);
            agregar.Parameters.AddWithValue("@periodo", grupoN.Periodo);
            agregar.ExecuteNonQuery();
            MessageBox.Show("Se agrego correctamente", "Objeto agregado");
            PopulateData();
            conexionDB.Close();
        }

        private void frmGrupo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frmMenu.Show();
        }

       

        private void GrupoDataViewGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = GrupoDataViewGrid .Rows[e.RowIndex];

                string valorCeldaId = row.Cells[0].Value.ToString();
                string valorCelda1 = row.Cells[1].Value.ToString();
                string valorCelda2 = row.Cells[2].Value.ToString();

                txt_GrupoID.Text = valorCeldaId;
                txtSemestre.Text = valorCelda1;
                txt_Periodo.Text = valorCelda2;
            }
            else
            {
                throw new Exception();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexionDB.Open();
            SqlCommand borrar = new SqlCommand("delete from grupos where id_grupo=@id_grupo", conexionDB);
            borrar.Parameters.AddWithValue("@id_grupo",txt_GrupoID.Text);
            borrar.ExecuteNonQuery();
            MessageBox.Show("group Deleted Successfully!");
            PopulateData();
            conexionDB.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                grupo grupoN = new grupo(txt_Periodo.Text , txtSemestre.Text);
                conexionDB.Open();
            SqlCommand actualizar = new SqlCommand("UPDATE grupos SET periodo= @periodo, semestre= @semestre WHERE id_grupo= @id_grupo", conexionDB);
            actualizar.Parameters.AddWithValue("@id_grupo", txt_GrupoID.Text);
            actualizar.Parameters.AddWithValue("@periodo", txt_Periodo.Text);
            actualizar.Parameters.AddWithValue("@semestre", txtSemestre.Text );
            actualizar.ExecuteNonQuery();
            MessageBox.Show("Se actulizó correctamente", "Objeto Actulizado");
            PopulateData();
            conexionDB.Close();
        }
    }
}
