using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TP_2___0._0._1
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Cadena de conexión a la base de datos de Access
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ematp\source\repos\6Alejo9\TP-2---0.0.1\BD_TP_grupal_parte_2.accdb";

            // Crear la consulta SQL para validar el usuario y la contraseña
            string queryDGV = "SELECT COUNT(*) FROM Usuarios";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(queryDGV, connectionString);
                 
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
