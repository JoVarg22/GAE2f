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

            try
            {
                SqlConnection conn = new System.Data.SqlClient.SqlConnection();
                conn.ConnectionString = "Data Source=JONATHAN;Initial catalog=GAE2F;Integrated Security=True";
                conn.Open();

                SqlCommand comando = new SqlCommand("select Usuario, Contraseña from Usuarios  where Usuario='" + Usuariotx.Text + "'And Contraseña='" + Contraseñatx.Text + "'", conn);
                comando.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(comando);

                da.Fill(ds, "Usuarios");
                DataRow DR;
                DR = ds.Tables["Usuarios"].Rows[0];
                if ((Usuariotx.Text == DR["Usuario"].ToString()) || (Contraseñatx.Text == DR["Contraseña"].ToString()))
                {
                    Home login = new Home();
                    login.Show();
                    this.Hide();



                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!, Su Contraseña y/o usuario son invalidos","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }




           /* Home Login = new Home();
            this.Hide();
            Login.Show();*/
            

            
            
           /* System.Data.SqlClient.SqlConnection con;
            con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = "Data Source=JONATHAN;Initial catalog=GAE2F;Integrated Security=True";

            string Usuario = Usuariotx.Text;
            string Contraseña = Contraseñatx.Text;

            if (Usuario == "" || Contraseña == "")
            {
                MessageBox.Show("Insertar Usuario y Contraseña", "STICS Message");
                this.Usuariotx.Focus();
                return;

            }

            else

            {



                SqlConnection SQLConnection = new SqlConnection();




                String commandString = "SELECT [ID_Usuario], FROM Usuarios WHERE[Usuario]=" + Usuariotx;
                int t = Convert.ToInt32(commandString);
                if (t == 0)
                {

                    MessageBox.Show("Credenciales incorrectas");
                }
                else
                {

                    Home login = new Home();
                    this.Hide();
                    login.Show();
          

                }

                                }
                 //System.Data.SqlClient.SqlConnection con;
                 //con = new System.Data.SqlClient.SqlConnection();

                    //con.ConnectionString = "Data Source = .\\SQLEXPRESS; AttachDbFilename="
                 //logins();
              //  Home home = new Home();
              //   home.Show();*/
             }
        
        private void Usuariotx_TextChanged(object sender, EventArgs e)
        {
            /*
            string Usuario = this.Usuariotx;
            string Contraseña = this.Contraseñatx;
            System.Data.SqlClient.SqlConnection con;
            con = new System.Data.SqlClient.SqlConnection();
            if (Usuario == "" || Contraseña == "")
            {
                MessageBox.Show("Insertar Usuario y Contraseña", "STICS Message");
                this.Usuariotx.Focus();
                return;

            }

            else

            {

                int ID_Usuario = 0;
                string connstring = "Data Source=JONATHAN;Initial catalog=GAE2F;Integrated Security=True";
                using (SqlConnection conexion = new SqlConnection(connstring))
                {

                    con.Open();
                    String commandString = "SELECT ISNULL([ID_Usuario]),0) FROM Usuarios WHERE[Usuario]=@Usuario AND [Contraseña]=@Contraseña";

                    SqlCommand cmd = new SqlCommand(commandString.conexion);
                    cmd.Parameters.AddWithValue("@Usuario", Usuariotx.Text);
                    cmd.Parameters.AddWithValue("@Contraseña", Contraseñatx.Text);

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

        /*public void logins()
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
            */
    }

        }
    }

