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
    public partial class Filtros : Form
    {
        public Filtros()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            this.Hide();
            Home.Show();
        }
    }
}
