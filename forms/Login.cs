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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegistrar registrar = new frmRegistrar();
            this.Hide();
            registrar.Show();
        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Cadena de conexión a la base de datos de Access
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ematp\source\repos\6Alejo9\TP-2---0.0.1\BD_TP_grupal_parte_2.accdb";

            // Crear la consulta SQL para validar el usuario y la contraseña
            string query = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @username AND Contraseña = @password";

            // Usar 'using' para asegurarnos de que la conexión se cierre correctamente
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    // Abrir la conexión con la base de datos
                    connection.Open();

                    // Crear un comando para ejecutar la consulta
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Asignar los valores de los TextBox a los parámetros de la consulta
                        command.Parameters.AddWithValue("@username", txtUsuario.Text);
                        command.Parameters.AddWithValue("@password", txtConstraseña.Text);

                        // Ejecutar la consulta y obtener el número de coincidencias
                        int count = (int)command.ExecuteScalar();

                        // Validar si el usuario y la contraseña son correctos
                        if (count > 0)
                        {
                            // Si hay coincidencias, el inicio de sesión es correcto
                            frmInicio frminicio = new frmInicio();
                            this.Hide();
                            frminicio.Show();
                        }
                        else
                        {
                            // Si no hay coincidencias, el usuario o la contraseña son incorrectos
                            MessageBox.Show("Los datos ingresados son incorrectos");
                            txtUsuario.Clear();
                            txtConstraseña.Clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar errores de conexión u otros problemas
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
                finally
                {
                    // Asegurarse de que la conexión se cierre
                    connection.Close();
                }
            }

        }


    }

}
