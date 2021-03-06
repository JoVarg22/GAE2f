﻿using System;
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
    public partial class Sitios : Form
    {
        public Sitios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            this.Hide();
            Home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = "Data Source=JONATHAN;Initial catalog=GAE2F;Integrated Security=True";
          

                 string sql = @"Insert into Sitio(ID_Sitio, Sitio)values(@ID_Sitio,@Sitio)";

            SqlCommand cmd = new SqlCommand(sql, conn);
           
     
            cmd.Parameters.Add("@ID_Sitio", SqlDbType.Int).Value= textBox1.Text.Trim();
            cmd.Parameters.Add("@Sitio", SqlDbType.VarChar,30).Value = textBox2.Text.Trim();
            
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro exitoso");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void Sitios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gAE2FDataSet.Sitio' Puede moverla o quitarla según sea necesario.
            this.sitioTableAdapter.Fill(this.gAE2FDataSet.Sitio);

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
         
        }

       
        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = "Data Source=JONATHAN;Initial catalog=GAE2F;Integrated Security=True";
            {
                DataTable dt = new DataTable();
                string query = "SELECT * FROM Sitio";
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
                SqlCommand Eliminar = new SqlCommand("delete from Sitio where ID_Sitio=" + textBox1.Text.Trim(),conn);
                SqlCommand Eliminar2 = new SqlCommand("delete from Sitio where Sitio=" + textBox2.Text.Trim(), conn);
                conn.Open();
                if (Eliminar.ExecuteNonQuery() == 1) {

                    MessageBox.Show("Se ha eliminado el registro");

                }
                else
                {

                    MessageBox.Show("No se encontro el registro a eliminar");

                }
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = "Data Source=JONATHAN;Initial catalog=GAE2F;Integrated Security=True";
            {
                conn.Open();
                string ID_Sitio= textBox1.Text;
                string Sitio = textBox2.Text;
                string cadena = "update Sitio set Sitio='" + Sitio + "' where ID_Sitio=" + ID_Sitio;
                SqlCommand comando = new SqlCommand(cadena, conn);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {

                    MessageBox.Show("Se modificaron los datos del sitio");
                    textBox2.Text = "";

                }
                else
                    MessageBox.Show("No existe un sitio con el ID ingresado");


            }
        }
    }
}
