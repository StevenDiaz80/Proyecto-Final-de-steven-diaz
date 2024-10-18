// Controlador para manejar operaciones relacionadas
// con los usuarios. Incluye métodos para obtener, agregar, eliminar y listar usuarios.
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using SistemaBiblioteca.Modelos;

namespace SistemaBiblioteca.Controladores
{
    public class UsuarioController
    {
        private readonly DBConnection db;

        public UsuarioController()
        {
            db = new DBConnection();
        }

        public List<Usuario> ObtenerUsuarios()//Obtiene una lista de todos los usuarios.
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Usuarios";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Usuario usuario = new Usuario
                        {
                            UsuarioID = Convert.ToInt32(reader["UsuarioID"]),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Email = reader["Email"].ToString(),
                            Telefono = reader["Telefono"].ToString()
                        };
                        usuarios.Add(usuario);
                    }
                }
            }

            return usuarios;
        }

        public void AgregarUsuario(Usuario usuario)//Agrega un nuevo usuario a la base de datos.
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Usuarios (Nombre, Apellido, Email, Telefono) " +
                               "VALUES (@Nombre, @Apellido, @Email, @Telefono)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@Email", usuario.Email);
                    cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarUsuario(int usuarioID)//Elimina un usuario específico.
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Usuarios WHERE UsuarioID = @UsuarioID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Usuario> ObtenerUsuariosMasActivos()//Obtiene una lista de los usuarios más activos en términos de reservas.
        {
            List<Usuario> usuariosMasActivos = new List<Usuario>();

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT u.UsuarioID, u.Nombre, u.Apellido, COUNT(r.ReservaID) AS ReservasHechas
                                     FROM Usuarios u
                                     INNER JOIN Reservas r ON u.UsuarioID = r.UsuarioID
                                     GROUP BY u.UsuarioID, u.Nombre, u.Apellido
                                     ORDER BY ReservasHechas DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Usuario usuario = new Usuario
                            {
                                UsuarioID = Convert.ToInt32(reader["UsuarioID"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                // Opción para mostrar también la cantidad de reservas hechas
                                // ReservasHechas = Convert.ToInt32(reader["ReservasHechas"]) 
                            };
                            usuariosMasActivos.Add(usuario);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener usuarios más activos: {ex.Message}");
            }

            return usuariosMasActivos;
        }


        // Métodos para editar y eliminar usuarios irían aquí
    }
}
