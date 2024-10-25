using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_2___0._0._1.Logic;

namespace TP_2___0._0._1.forms
{
    public partial class frmInicioAdministrador : Form
    {
        private DataGridViewHelper dgvHelper;  // Declara una instancia de DataGridViewHelper
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\BD_TP_grupal_parte_2.accdb";

        public frmInicioAdministrador()
        {
            InitializeComponent();
            dgvHelper = new DataGridViewHelper(connectionString);  // Inicializa la clase con el string de conexión
        }

        private void frmInicioAdministrador_Load(object sender, EventArgs e)
        {
            // Llama a LlenarDataGridView al cargar el formulario
            dgvHelper.LlenarDataGridView(dataGridView1, "SELECT * FROM Usuarios");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblNobreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCorreoElectronico_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreoElectronico_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNivel_Click(object sender, EventArgs e)
        {

        }

        private void lblBienvenidoAdministrador_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Llama a AgregarUsuario con los valores de los TextBox
            dgvHelper.AgregarUsuario(txtNombreUsuario.Text, txtCorreoElectronico.Text, txtContraseña.Text, txtNivel.Text);
            dgvHelper.LlenarDataGridView(dataGridView1, "SELECT * FROM Usuarios");  // Recarga el DataGridView
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Llama a ModificarUsuario con los valores de los TextBox
            dgvHelper.ModificarUsuario(txtNombreUsuario.Text, txtCorreoElectronico.Text, txtContraseña.Text, txtNivel.Text);
            dgvHelper.LlenarDataGridView(dataGridView1, "SELECT * FROM Usuarios");  // Recarga el DataGridView
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Llama a EliminarUsuario con el valor de NombreUsuario
            dgvHelper.EliminarUsuario(txtNombreUsuario.Text);
            dgvHelper.LlenarDataGridView(dataGridView1, "SELECT * FROM Usuarios");  // Recarga el DataGridView
        }

        private void btnVolverAlLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.Show();
        }
    }
}