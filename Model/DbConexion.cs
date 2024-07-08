using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace SystemLibrary.Model
{
    internal class DbConexion
    {
        private string connectionString;

        public DbConexion() 
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString;
        }

        public string GetConnectionString()
        {
            return connectionString;
        }
        public void Conectar()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("La conexión a la base de datos fue exitosa.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!! No se pudo conectar a la base de datos: " + ex.Message);
                }
            }
        }

        public bool ProbConexion()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!! No se pudo conectar a la base de datos: " + ex.Message);
                    return false;
                }
            }
        }

    }
}
