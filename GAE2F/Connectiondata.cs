using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GAE2F
{
    public partial class Connectiondata : Form
    {
        public Connectiondata()
        {
            InitializeComponent();
        }
        System.Data.SqlClient.SqlConnection conn;
        private void button1_Click(object sender, EventArgs e)
        {
            conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = "Data Source=JONATHAN;Initial catalog=GAE2F;Integrated Security=True";

            try
            {
                conn.Open();
                MessageBox.Show("Se abrio la conexion con el servidor SQL Server y se selecciono la base de datos");
            }
            catch (Exception)
            {
                MessageBox.Show("Conexion fallida");

            };
           /* String connStr = @"Data Source=JONATHAN;Initial catalog=GAE2F;Integrated Security=True";
            conn = new SqlConnection(connStr);
            conn.open();
            MessageBox.Show("Se abrio la conexion con el servidor SQL Server y se selecciono la base de datos");


            /*SqlConnection conexion = new SqlConnection("server=JONATHAN; database=GAE2f; integrated security=true");
            conexion.Open();
            MessageBox.Show("Se abrio la conexion con el servidor SQL Server y se selecciono la base de datos");
            
           
            conexion.Close();
            MessageBox.Show("No se pudo conectar");*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            this.Hide();
            Home.Show();
        }
    }
}
