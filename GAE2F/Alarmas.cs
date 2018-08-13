using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace GAE2F
{
    public partial class Alarmas : Form
    {
        public Alarmas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            this.Hide();
            Home.Show();
        }

        private void Alarmas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gAE2FDataSet.Alarmas' Puede moverla o quitarla según sea necesario.
            this.alarmasTableAdapter.Fill(this.gAE2FDataSet.Alarmas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = "Data Source=JONATHAN;Initial catalog=GAE2F;Integrated Security=True";


            string sql = @"Insert into Alarmas(ID_Alarma, Descripcion, Criticidad)values(@ID_Alarma,@Descripcion,@Criticidad)";

            SqlCommand cmd = new SqlCommand(sql, conn);


            cmd.Parameters.Add("@ID_Alarma", SqlDbType.Int).Value = textBox1.Text.Trim();
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 30).Value = textBox2.Text.Trim();
            cmd.Parameters.Add("@Criticidad", SqlDbType.VarChar, 30).Value = textBox3.Text.Trim();
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro exitoso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = "Data Source=JONATHAN;Initial catalog=GAE2F;Integrated Security=True";
            {
                DataTable dt = new DataTable();
                string query = "SELECT * FROM Alarmas";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = "Data Source=JONATHAN;Initial catalog=GAE2F;Integrated Security=True";
            {
                SqlCommand Eliminar = new SqlCommand("delete from Alarmas where ID_Alarma=" + textBox1.Text.Trim(), conn);
                SqlCommand Eliminar2 = new SqlCommand("delete from Alarmas where Descripcion=" + textBox2.Text.Trim(), conn);
                SqlCommand Eliminar3 = new SqlCommand("delete from Alarmas where Criticidad=" + textBox3.Text.Trim(), conn);
                conn.Open();
                if (Eliminar.ExecuteNonQuery() == 1)
                {

                    MessageBox.Show("Se ha eliminado el registro");

                }
                else
                {

                    MessageBox.Show("No se encontro el registro a eliminar");

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = "Data Source=JONATHAN;Initial catalog=GAE2F;Integrated Security=True";
            {
                conn.Open();
                string ID_Alarma = textBox1.Text;
                string Descripcion = textBox2.Text;
                string Criticidad = textBox3.Text;
                string cadena = "update Alarmas set Descripcion='" + Descripcion + "',Criticidad='"+Criticidad+"' where ID_Alarma=" + ID_Alarma;
                SqlCommand comando = new SqlCommand(cadena, conn);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {

                    MessageBox.Show("Se modificaron los datos de la alarma");
                    textBox2.Text = "";
                    textBox3.Text = "";

                }
                else
                    MessageBox.Show("No existe una alarma con el ID ingresado");


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}

