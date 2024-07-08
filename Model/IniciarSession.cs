using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemLibrary.Model;
using System.Data.SqlClient;
using SystemLibrary.Vista;

namespace SystemLibrary.Model
{
    internal class IniciarSession
    {
      private  DbConexion conexion = new DbConexion();
        

        public  IniciarSession() 
        { 
        }

        // Función para validar el rol del usuario
        public string ObtenerMensajeRol(int idRol)
        {
            switch (idRol)
            {
                case 1:
                    return "Bienvenido usuario Superadmin";
                case 2:
                    return "Bienvenido usuario Admin";
                case 3:
                    return "Bienvenido usuario Normal";
                default:
                    return "Rol de usuario no reconocido";
            }
        }

        public bool Login(string Correo, string Clave)
        {
            if (!conexion.ProbConexion())
            {
                return false; // solo si no se pudo establecer la conexión
            }
            if (string.IsNullOrEmpty(Correo) || string.IsNullOrEmpty(Clave))
            {
                MessageBox.Show("Por favor, ingrese las credenciales");
                return false;
            }
            using (SqlConnection connection = new SqlConnection(conexion.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT IdRol FROM USUARIO WHERE Correo=@Correo AND Clave = @Clave";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Correo", Correo);
                    command.Parameters.AddWithValue("@Clave", Clave);

                    int idRol = Convert.ToInt32(command.ExecuteScalar());

                    // Obtener el mensaje del rol del usuario logueado
                    string mensajeRol = ObtenerMensajeRol(idRol);
                    MessageBox.Show(mensajeRol);

                    connection.Close();
                    return idRol > 0;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error en la consulta SQL: " + ex.Message);
                    throw new Exception("Error occurred while logging in: " + ex.Message);
                    return false;
                }
            }
        }

    }
}
