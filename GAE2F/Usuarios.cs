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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            this.Hide();
            Home.Show();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gAE2FDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.gAE2FDataSet.Usuarios);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = "Data Source=JONATHAN;Initial catalog=GAE2F;Integrated Security=True";
            {
                conn.Open();

                string ID_Usuario = textBox1.Text;
                string Usuario = textBox2.Text;
                string Contraseña = textBox3.Text;
                string Nombre = textBox5.Text;
                string Apellido1 = textBox6.Text;
                string Apellido2 = textBox7.Text;
                string Correo = textBox8.Text;
                string Telefono = textBox9.Text;
                string ID_Rol = textBox10.Text;
                
                string cadena1 = "update Usuarios set Usuario='" + Usuario + "',Contraseña='"+Contraseña+ "',Nombre='" + Nombre + "',Apellido1='" + Apellido1 + "',Apellido2='" + Apellido2+ "',Correo='" + Correo + "',Telefono='" + Telefono + "' where ID_Usuario=" + ID_Usuario;
           
                SqlCommand comando1 = new SqlCommand(cadena1, conn);
              
                int cant;
                cant = comando1.ExecuteNonQuery();
                if (cant == 1)
                {

                    MessageBox.Show("Se modificaron los datos del Usuario");
                    textBox2.Text = "";

                }
                else
                    MessageBox.Show("No existe un Usuario con el ID ingresado");


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                SqlConnection conn = new System.Data.SqlClient.SqlConnection();
                conn.ConnectionString = "Data Source=JONATHAN;Initial catalog=GAE2F;Integrated Security=True";
                conn.Open();
                DataTable dt = new DataTable();
                string query = "SELECT * FROM Usuarios";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID_Usuario", Convert.ToInt32(textBox1.Text));

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = Convert.ToString(dr["Usuario"].ToString());
                    textBox3.Text = Convert.ToString(dr["Contraseña"].ToString());
                    textBox4.Text = Convert.ToString(dr["Contraseña"].ToString());
                    textBox5.Text = Convert.ToString(dr["Nombre"].ToString());
                    textBox6.Text = Convert.ToString(dr["Apellido1"].ToString());
                    textBox7.Text = Convert.ToString(dr["Apellido2"].ToString());
                    textBox8.Text = Convert.ToString(dr["Correo"].ToString());
                    textBox9.Text = Convert.ToString(dr["Telefono"].ToString());
                    textBox10.Text = Convert.ToString(dr["ID_Rol"].ToString());
                   

                }



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = "Data Source=JONATHAN;Initial catalog=GAE2F;Integrated Security=True";
            {
                SqlCommand Eliminar = new SqlCommand("delete from Usuarios where ID_Usuario=" + textBox1.Text.Trim(), conn);
                SqlCommand Eliminar2 = new SqlCommand("delete from Usuarios where Usuario=" + textBox2.Text.Trim(), conn);
                SqlCommand Eliminar3 = new SqlCommand("delete from Usuarios where Contraseña=" + textBox3.Text.Trim(), conn);
                SqlCommand Eliminar4 = new SqlCommand("delete from Usuarios where Nombre=" + textBox5.Text.Trim(), conn);
                SqlCommand Eliminar5 = new SqlCommand("delete from Usuarios where Apellido1=" + textBox6.Text.Trim(), conn);
                SqlCommand Eliminar6 = new SqlCommand("delete from Usuarios where Apellido2=" + textBox7.Text.Trim(), conn);
                SqlCommand Eliminar7 = new SqlCommand("delete from Usuarios where Correo=" + textBox8.Text.Trim(), conn);
                SqlCommand Eliminar8 = new SqlCommand("delete from Usuarios where Telefono=" + textBox9.Text.Trim(), conn);
                SqlCommand Eliminar9= new SqlCommand("delete from Usuarios where ID_Rol=" + textBox10.Text.Trim(), conn);
              
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = "Data Source=JONATHAN;Initial catalog=GAE2F;Integrated Security=True";


            string sql = @"Insert into Usuarios(ID_Usuario, Usuario, Contraseña, Nombre, Apellido1, Apellido2, Telefono, Correo, ID_Rol)values(@ID_Usuario,@Usuario, @Contraseña,@Nombre, @Apellido1, @Apellido2, @Telefono, @Correo, @ID_Rol)";

            SqlCommand cmd = new SqlCommand(sql, conn);


            cmd.Parameters.Add("@ID_Usuario", SqlDbType.Int).Value = textBox1.Text.Trim();
            cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 30).Value = textBox2.Text.Trim();
            cmd.Parameters.Add("@Contraseña", SqlDbType.VarChar,30).Value = textBox3.Text.Trim();
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 30).Value = textBox5.Text.Trim();
            cmd.Parameters.Add("@Apellido1", SqlDbType.VarChar, 30).Value = textBox6.Text.Trim();
            cmd.Parameters.Add("@Apellido2", SqlDbType.VarChar, 30).Value = textBox7.Text.Trim();
            cmd.Parameters.Add("@Telefono", SqlDbType.Int).Value = textBox8.Text.Trim();
            cmd.Parameters.Add("@Correo", SqlDbType.VarChar, 30).Value = textBox9.Text.Trim();
            cmd.Parameters.Add("@ID_Rol", SqlDbType.Int).Value = textBox10.Text.Trim();
          
            

            try
            {
                if (textBox3.Text.Equals(textBox4.Text))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro exitoso");
                }
                else
                {
                    MessageBox.Show("La contraseña y la confirmacion no coinciden");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = "Data Source=JONATHAN;Initial catalog=GAE2F;Integrated Security=True";
            {

                DataTable dt = new DataTable();
                string query = "SELECT * FROM Usuarios";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
