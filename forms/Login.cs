using System;
using System.Data.OleDb;
using System.Windows.Forms;
using TP_2___0._0._1.forms;
using TP_2___0._0._1.Logic;

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
            //  frmRecupero recupero = new frmRecupero();
            //this.Hide();
            // recupero.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegistrar registrar = new frmRegistrar();
            this.Hide();
            registrar.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Instanciar la clase de conexión
            ConectarBD.conexion conectarBD = new ConectarBD.conexion();

            // Consulta SQL para validar el usuario y obtener el nivel
            string query = "SELECT Nivel FROM Usuarios WHERE NombreUsuario = @username AND Contraseña = @password";

            // Crear los parámetros
            OleDbParameter[] parametros = new OleDbParameter[]
            {
        new OleDbParameter("@username", txtUsuario.Text),
        new OleDbParameter("@password", txtConstraseña.Text)
            };

            try
            {
                // Abrir la conexión
                conectarBD.AbrirConexion();

                using (OleDbCommand command = new OleDbCommand(query, conectarBD.AbrirConexion()))
                {
                    // Asignar los parámetros a la consulta
                    command.Parameters.AddRange(parametros);

                    // Ejecutar la consulta y obtener el nivel del usuario
                    object resultado = command.ExecuteScalar();

                    if (resultado != null)
                    {
                        string nivel = resultado.ToString();

                        if (nivel == "Administrador")
                        {
                            // Si el nivel es ADMINISTRADOR, abre el formulario InicioAdministrador
                            frmInicioAdministrador frmInicioAdmin = new frmInicioAdministrador();
                            this.Hide();
                            frmInicioAdmin.Show();
                        }
                        else if (nivel == "Usuario")
                        {
                            // Si el nivel es USUARIO, abre el formulario InicioUsuarios
                            frmInicioUsuarios frminiciousuarios = new frmInicioUsuarios();
                            this.Hide();
                            frminiciousuarios.Show();
                        }
                        else
                        {
                            // Si el nivel es desconocido, lo cual dudo mucho que suseda
                            MessageBox.Show("Nivel de usuario no reconocido");
                        }
                    }
                    else
                    {
                        // Si no hay coincidencias, usuario o contraseña incorrectos
                        MessageBox.Show("Los datos ingresados son incorrectos");
                        txtUsuario.Clear();
                        txtConstraseña.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                conectarBD.CerrarConexion();
            }
        }








        //Conectar con base y dirigir a INICIO USUARIO ⤵

        /* private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Instanciar la clase de conexión
            ConectarBD.conexion conectarBD = new ConectarBD.conexion();

            // Consulta SQL para validar el usuario
            string query = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @username AND Contraseña = @password";

            // Crear los parámetros
            OleDbParameter[] parametros = new OleDbParameter[]
            {
            new OleDbParameter("@username", txtUsuario.Text),
            new OleDbParameter("@password", txtConstraseña.Text)
            };

            // Se ejecuta la consulta y se obtienen los resultados
            int count = conectarBD.EjecutarConsulta(query, parametros);

            // Validar si el usuario y la contraseña son correctos
            if (count > 0)
            {
                // Si hay coincidencias, el inicio de sesión es correcto
                frmInicioUsuarios frminiciousuarios = new frmInicioUsuarios();
                this.Hide();
                frminiciousuarios.Show();
            }
            else
            {
                // Si no hay coincidencias se mostrara un mensaje de error
                MessageBox.Show("Los datos ingresados son incorrectos");
                txtUsuario.Clear();
                txtConstraseña.Clear();
            }
        } */



    }

}
