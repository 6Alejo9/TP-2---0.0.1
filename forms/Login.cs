using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_2___0._0._1.forms;

namespace TP_2___0._0._1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRecupero_Click(object sender, EventArgs e)
        {
            frmRecupero recupero = new frmRecupero();
            this.Hide();
            recupero.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\ruta\a\tu\base_de_datos.accdb";
        }
    }
}
