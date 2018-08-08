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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string Usuario = this.textBox1;
            string Contraseña = this.textBox2;
            System.Data.SqlClient.SqlConnection con;
            con = new System.Data.SqlClient.SqlConnection();
            if (Usuario == "" || Contraseña == "")
            {
                MessageBox.Show("Insertar Usuario y Contraseña", "STICS Message");
                this.textBox1.Focus();
                return;

            }

            else

            {

                int ID_Usuario = 0;
                string connstring = "Data Source =.\\SQLEXPRESS;AttachedDbFilename=C:\\Users\\Jonathan\\Documents\\SQL Server Management Studio\\GAE2F.sql;Integrated Security=True;Connect Timeout=30;User Instance=True";
                using (SqlConnection con = new SqlConnection(connstring))
                {

                    con.Open();
                    String commandString = "SELECT ISNULL([ID_Usuario]),0) FROM Usuarios WHERE[Usuario]=@Usuario AND [Contraseña]=@Contraseña";

                    SqlCommand cmd = new SqlCommand(commandString.con);
                    cmd.Parameters.AddWithValue("@Usuario", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Contraseña", textBox1.Text);

                    ID_Usuario = Convert.ToInt32(cmd.ExecuteScalar());


                }

                if (ID_Usuario == 0)
                {

                    MessageBox.Show("Revise si ingreso los datos de forma correcta", "STICS Message");

                }
                else
                {
                    Home Login = new Home();
                    this.Hide();
                    Login.Show();

                }

            }
            //System.Data.SqlClient.SqlConnection con;
            //con = new System.Data.SqlClient.SqlConnection();
  
               //con.ConnectionString = "Data Source = .\\SQLEXPRESS; AttachDbFilename="
            //logins();
         //  Home home = new Home();
         //   home.Show();
        }

        public void logins()
        {
            try
            {
                string GAE2F = ConfigurationManager.ConnectionStrings["GAE2F"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(GAE2F))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT usuario, Contraseña FROM Usuarios WHERE Usuario='" + textBox1.Text + "' AND pass='" + textBox2.Text + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Login exitoso.");
                        }
                        else
                        {
                            MessageBox.Show("Datos incorrectos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

    }
}
