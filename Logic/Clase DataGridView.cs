using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_2___0._0._1;
using System.Windows.Forms;

namespace TP_2___0._0._1.Logic
{ }
    public class DataGridViewHelper
    {
        private OleDbConnection conexion;

        public DataGridViewHelper(string connectionString)
        {
            conexion = new OleDbConnection(connectionString);
        }

        public void LlenarDataGridView(DataGridView dataGridView, string consultaSQL)
        {
            try
            {
                OleDbDataAdapter adaptador = new OleDbDataAdapter(consultaSQL, conexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        public void AgregarUsuario(string nombre, string correo, string contraseña, string nivel)
        {
            try
            {
                string query = "INSERT INTO Usuarios (NombreUsuario, CorreoElectronico, Contraseña, Nivel) VALUES (?, ?, ?, ?)";
                OleDbCommand command = new OleDbCommand(query, conexion);
                command.Parameters.AddWithValue("?", nombre);
                command.Parameters.AddWithValue("?", correo);
                command.Parameters.AddWithValue("?", contraseña);
                command.Parameters.AddWithValue("?", nivel);

                conexion.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Usuario agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar usuario: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void ModificarUsuario(string nombre, string correo, string contraseña, string nivel)
        {
            try
            {
                string query = "UPDATE Usuarios SET CorreoElectronico = ?, Contraseña = ?, Nivel = ? WHERE NombreUsuario = ?";
                OleDbCommand command = new OleDbCommand(query, conexion);
                command.Parameters.AddWithValue("?", correo);
                command.Parameters.AddWithValue("?", contraseña);
                command.Parameters.AddWithValue("?", nivel);
                command.Parameters.AddWithValue("?", nombre);

                conexion.Open();
                int filasActualizadas = command.ExecuteNonQuery();
                if (filasActualizadas > 0)
                    MessageBox.Show("Usuario modificado correctamente.");
                else
                    MessageBox.Show("Usuario no encontrado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar usuario: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void EliminarUsuario(string nombre)
        {
            try
            {
                string query = "DELETE FROM Usuarios WHERE NombreUsuario = ?";
                OleDbCommand command = new OleDbCommand(query, conexion);
                command.Parameters.AddWithValue("?", nombre);

                conexion.Open();
                int filasEliminadas = command.ExecuteNonQuery();
                if (filasEliminadas > 0)
                    MessageBox.Show("Usuario eliminado correctamente.");
                else
                    MessageBox.Show("Usuario no encontrado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }


