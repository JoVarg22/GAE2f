using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAE2F
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void filtrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void administraciònToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verSitiosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios Usuarios = new Usuarios();
            Usuarios.Show();
            
        }

        private void sitiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sitios Sitios = new Sitios();
            Sitios.Show();
        }

        private void alarmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alarmas Alarmas = new Alarmas();
            Alarmas.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filtros Folders = new Filtros();
            this.Hide();
            Folders.Show();
        }

        private void conexionALaBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connectiondata conn = new Connectiondata();
            this.Hide();
            conn.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
        private DateTimePicker timePicker;

        private void InitializeTimePicker()
        {
            timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            timePicker.Location = new Point(10, 10);
            timePicker.Width = 100;
            Controls.Add(timePicker);


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Busquedas Busquedas = new Busquedas();
            Busquedas.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Estadisticas Estadisticas = new Estadisticas();
            Estadisticas.Show();
        }
    }
}
