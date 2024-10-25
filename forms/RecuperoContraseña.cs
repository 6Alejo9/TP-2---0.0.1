using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_2___0._0._1.Logic;

namespace TP_2___0._0._1.forms
{
    public partial class RecuperoContraseña : Form
    {
        public RecuperoContraseña()
        {
            InitializeComponent();
        }

        private void lblCorreoEelctronico_Click(object sender, EventArgs e)
        {

        }

        // Evento del botón de recuperación de contraseña
        private void btnValidarCorreoElectronico_Click(object sender, EventArgs e)
        {
            string correoIngresado = txbCorreoElectronico.Text.Trim();

            if (string.IsNullOrEmpty(correoIngresado))
            {
                MessageBox.Show("Por favor, ingrese su correo electrónico.");
                return;
            }

            // Instancia de la clase interna conexión
            ConectarBD.conexion conexion = new ConectarBD.conexion();
            string consulta = "SELECT Contraseña FROM Usuarios WHERE Correo = @correo";

            try
            {
                using (OleDbCommand cmd = new OleDbCommand(consulta, conexion.AbrirConexion()))
                {
                    cmd.Parameters.AddWithValue("@correo", correoIngresado);

                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        string contraseña = resultado.ToString();
                        MessageBox.Show("Su contraseña es: " + contraseña, "Recuperación de Contraseña");
                    }
                    else
                    {
                        MessageBox.Show("El correo ingresado no está registrado.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar recuperar la contraseña: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            frmLogin Login = new frmLogin();
            this.Hide();
            Login.Show();

        }

    }
}
