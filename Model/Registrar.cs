using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibrary.Model
{
    internal class Registrar
    {
        private DbConexion conexion = new DbConexion();

        public Registrar() { }

        public string RegistroUsario(string Documento, String NombreCompleto, String Correo, string Clave, string ComfirClave)
        {
            if (!conexion.ProbConexion())
            {
               // return ; // solo si no se pudo establecer la conexión
            }

            using (SqlConnection connection = new SqlConnection(conexion.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado, FechaRegistro)" +
                        " VALUES (@Documento, @NombreCompleto, @Correo, @Clave, 3, 1, GETDATE())";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Documento", Documento);
                    command.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                    command.Parameters.AddWithValue("@Correo", Correo);
                    command.Parameters.AddWithValue("@Clave", Clave);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // El registro se insertó correctamente
                    }
                    else
                    {
                        // Hubo un problema al insertar el registro
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error en la consulta SQL: " + ex.Message);
                    throw new Exception("Error occurred while registering the user: " + ex.Message);
                }
            }

            return null;
        }
        public bool ValidEmpty(TextBox txtDocumento, TextBox txtNombre, TextBox txtApellido, TextBox txtCorreo, TextBox txtClave, TextBox txtConfirmaClave)
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("El campo 'Documento' es obligatorio.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Los campos 'Nombre' y 'Apellido' son obligatorios.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("El campo 'Correo' es obligatorio.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("El campo 'Clave' es obligatorio.");
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show("Los campos obligatorios no han sido llenados, no se puede proceder con el registro");
                return true;
            }

            // Validar formato de correo electrónico
            if (!IsValidEmail(txtCorreo.Text))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.");
                return false;
            }

            // Validar longitud de contraseña
            if (txtClave.Text.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.");
                return false;
            }

            // Validar que la contraseña y la confirmación de contraseña coincidan
            if (txtClave.Text != txtConfirmaClave.Text)
            {
                MessageBox.Show("La contraseña y la confirmación de contraseña no coinciden.");
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }   
}

