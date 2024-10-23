using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace TP_2___0._0._1.Logic
{
    internal class ConectarBD
    {
        public class conexion
        {
            // Conexión a la base de datos utilizando DataDirectory para mayor flexibilidad
            private OleDbConnection CN = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\BD_TP_grupal_parte_2.accdb");

            // Método para abrir la conexión
            public OleDbConnection AbrirConexion()
            {
                if (CN.State == ConnectionState.Closed)
                {
                    CN.Open();
                }
                return CN;
            }

            // Método para cerrar la conexión
            public OleDbConnection CerrarConexion()
            {
                if (CN.State == ConnectionState.Open)
                {
                    CN.Close();
                }
                return CN;
            }

            // Método para ejecutar una consulta con parámetros y devolver un resultado
            public int EjecutarConsulta(string query, OleDbParameter[] parametros)
            {
                int resultado = 0;

                try
                {
                    using (OleDbCommand command = new OleDbCommand(query, AbrirConexion()))
                    {
                        // Asignar parámetros a la consulta
                        if (parametros != null)
                        {
                            command.Parameters.AddRange(parametros);
                        }

                        // Ejecutar la consulta y obtener el resultado (por ejemplo, un COUNT(*))
                        resultado = (int)command.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                }
                finally
                {
                    CerrarConexion();
                }

                return resultado;
            }
        }
    }
}

