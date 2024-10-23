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
            // Instancia de la clase de conexión
            ConectarBD.conexion conectarBD = new ConectarBD.conexion(); // Instanciar aquí

            // Recopilar los datos de los campos de texto
            string nombreUsuario = txbNombreUsuario.Text; // Cambiado a nombreUsuario
            string correoElectronico = txbCorreoElectronico.Text;
            string contraseña = txbContraseña.Text;

            // Validación básica
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(correoElectronico) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Crear la consulta SQL para insertar el nuevo usuario
            string query = "INSERT INTO Usuarios (NombreUsuario, CorreoElectronico, Contraseña, Nivel) VALUES (@NombreUsuario, @CorreoElectronico, @Contraseña, @Nivel)"; // Cambiado a NombreUsuario

            try
            {
                // Abrir la conexión a la base de datos
                conectarBD.AbrirConexion();

                // Usar OleDbCommand para ejecutar la consulta
                using (OleDbCommand command = new OleDbCommand(query, conectarBD.AbrirConexion()))
                {
                    // Asignar los parámetros
                    command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario); // Cambiado a NombreUsuario
                    command.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);
                    command.Parameters.AddWithValue("@Nivel", "Usuario"); // Agregar el nivel como "Usuario"

                    // Ejecutar la consulta
                    int rowsAffected = command.ExecuteNonQuery();

                    // Verificar si se insertó el usuario correctamente
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Usuario registrado exitosamente.");
                        // Aquí puedes limpiar los campos si es necesario
                        txbNombreUsuario.Clear();
                        txbCorreoElectronico.Clear();
                        txbContraseña.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el usuario. Intente nuevamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión a la base de datos
                conectarBD.CerrarConexion();
            }

            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.Show();

        }




        private void btnRegresarAlLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.Show();

        }
    }
}
