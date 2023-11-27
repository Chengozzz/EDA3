using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDA3_ControlEscolar
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formularioPersona = new Form1();
            formularioPersona.Show();
            Program.frmMenu.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formularioAlumnos = new frmAlumnos();
            formularioAlumnos.Show();
            Program.frmMenu.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formularioCalificaiones = new frmCalificaciones();
            formularioCalificaiones.Show();
            Program.frmMenu.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frmProfesor = new frmProfesor();
            frmProfesor.Show();
            Program.frmMenu.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formularioGrupo = new frmGrupo();
            formularioGrupo.Show();
            Program.frmMenu.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formularioMateria = new frmMateria();
            formularioMateria.Show();
            Program.frmMenu.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form formularioCarrera = new frmCarrera();
            formularioCarrera.Show();
            Program.frmMenu.Hide();
        }
    }
}
