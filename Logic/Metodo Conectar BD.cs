using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2___0._0._1.Logic
{
    public class conexion
    {
        public OleDbConnection CN = OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Sourse = DataDirectory BD_TP_grupal_parte_2");

        private static OleDbConnection OleDbConnection(string v)
        {
            throw new NotImplementedException();
        }

        public OleDbConnection AbrirConexion()
        {
            if (CN.State == ConnectionState.Open)
            {
                CN.Close();
            }
            CN.Open();
            return CN;

        }

        public OleDbConnection CerrarConexion()
        {
            CN.Open();
            return CN;
        }

    }
}
