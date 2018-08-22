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

            


           
             }
      
        
        private void Usuariotx_TextChanged(object sender, EventArgs e)
        {
           
    }

        }
    }

