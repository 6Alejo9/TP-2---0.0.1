using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2___0._0._1.Logic
{
    public class DatabaseConnection
    {
        private string connectionString;

        // Constructor: Define la cadena de conexión al inicializar el objeto
        public DatabaseConnection()
        {
            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Alejo\Desktop\BD_TP_grupal_parte_2.accdb";
        }

        // Método para obtener la conexión a la base de datos
        public OleDbConnection Connect()
        {
            try
            {
                OleDbConnection connection = new OleDbConnection(connectionString);
                connection.Open();
                Console.WriteLine("Conexión exitosa.");
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar con la base de datos: " + ex.Message);
                return null;
            }
        }

        // Método para cerrar la conexión
        public void CloseConnection(OleDbConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Conexión cerrada.");
            }
        }
    }



}

