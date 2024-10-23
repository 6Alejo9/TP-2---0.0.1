using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_FINAL_By_Alejo.Clases;

namespace TP_2___0._0._1.Logic
{
    internal class ClaseDataGridView
    {
        public class CargarDatos
        {
            // Instancia de la clase de conexión
            private ConectarBD.conexion conectarBD = new ConectarBD.conexion();

            // Método para obtener los datos de una tabla
            public DataTable ObtenerDatosDeTabla(string nombreTabla)
            {
                DataTable dataTable = new DataTable();

                // Consulta SQL para obtener los datos de la tabla que se pasa como parámetro
                string query = $"SELECT * FROM {nombreTabla}";

                try
                {
                    // Abrir la conexión a la base de datos
                    conectarBD.AbrirConexion();

                    // Usar un OleDbDataAdapter para ejecutar la consulta y llenar el DataTable
                    using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, conectarBD.AbrirConexion()))
                    {
                        // Llenar el DataTable con los datos obtenidos
                        dataAdapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al cargar los datos: " + ex.Message);
                }
                finally
                {
                    // Cerrar la conexión a la base de datos
                    conectarBD.CerrarConexion();
                }

                return dataTable;  // Retornar el DataTable lleno con los datos
            }
        }
    }
}
