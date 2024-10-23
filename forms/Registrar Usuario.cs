using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_2___0._0._1.forms
{
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }
        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void txbNombreYApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbCorreoElectronico_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombreYApellido_Click(object sender, EventArgs e)
        {

        }

        private void lblCorreoElectronico_Click(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptarRegistro_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresarAlLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.Show();

        }
    }
}
