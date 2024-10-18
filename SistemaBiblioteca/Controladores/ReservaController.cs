//Controlador para manejar operaciones relacionadas con las reservas de libros.
//Incluye métodos para obtener reservas, agregar, editar y eliminar reservas.
using System;
using System.Collections.Generic;
using SistemaBiblioteca.Modelos;
using Microsoft.Data.SqlClient;


namespace SistemaBiblioteca.Controladores
{
    public class ReservaController
    {
        private readonly DBConnection db;

        public ReservaController()
        {
            db = new DBConnection();
        }

        public List<Reserva> ObtenerReservas()//Obtiene una lista de todas las reservas.
        {
            List<Reserva> reservas = new List<Reserva>();

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Reservas";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Reserva reserva = new Reserva
                            {
                                ReservaID = Convert.ToInt32(reader["ReservaID"]),
                                UsuarioID = Convert.ToInt32(reader["UsuarioID"]),
                                ISBN = reader["ISBN"].ToString(), // Asegúrate de que esta columna existe
                                FechaReserva = Convert.ToDateTime(reader["FechaReserva"]),
                                FechaDevolucion = reader["FechaDevolucion"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["FechaDevolucion"])
                            };
                            reservas.Add(reserva);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener reservas: {ex.Message}");
            }

            return reservas;
        }


        public void AgregarReserva(Reserva reserva) //Agrega una nueva reserva a la base de datos.
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Reservas (UsuarioID, ISBN, FechaReserva, FechaDevolucion, LibroID) " + // Agrega LibroID aquí
                               "VALUES (@UsuarioID, @ISBN, @FechaReserva, @FechaDevolucion, @LibroID)"; // Y aquí
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UsuarioID", reserva.UsuarioID);
                    cmd.Parameters.AddWithValue("@ISBN", reserva.ISBN);
                    cmd.Parameters.AddWithValue("@FechaReserva", reserva.FechaReserva);
                    cmd.Parameters.AddWithValue("@FechaDevolucion", (object)reserva.FechaDevolucion ?? DBNull.Value); // Asegúrate de manejar nulos
                    cmd.Parameters.AddWithValue("@LibroID", reserva.LibroID); // Asegúrate de agregar este parámetro

                    cmd.ExecuteNonQuery();
                }
            }
        }
        //Metodo para obtener ReservaPorID
        public Reserva ObtenerReservaPorID(int id)
        {
            Reserva reserva = null;

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Reservas WHERE ReservaID = @ReservaID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ReservaID", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        reserva = new Reserva
                        {
                            ReservaID = Convert.ToInt32(reader["ReservaID"]),
                            UsuarioID = Convert.ToInt32(reader["UsuarioID"]),
                            LibroID = Convert.ToInt32(reader["LibroID"]),
                            FechaReserva = Convert.ToDateTime(reader["FechaReserva"]),
                            FechaDevolucion = reader["FechaDevolucion"] == DBNull.Value
                                ? (DateTime?)null
                                : Convert.ToDateTime(reader["FechaDevolucion"])
                        };
                    }
                }
            }
            return reserva;
        }

        
        public void EliminarReserva(int id) // Elimina una reserva específica.
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Reservas WHERE ReservaID = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para actualizar una reserva
        public void ActualizarReserva(Reserva reserva)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Reservas SET UsuarioID = @UsuarioID, LibroID = @LibroID, FechaReserva = @FechaReserva, FechaDevolucion = @FechaDevolucion WHERE ReservaID = @ReservaID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UsuarioID", reserva.UsuarioID);
                    cmd.Parameters.AddWithValue("@LibroID", reserva.LibroID);
                    cmd.Parameters.AddWithValue("@FechaReserva", reserva.FechaReserva);
                    cmd.Parameters.AddWithValue("@FechaDevolucion", (object)reserva.FechaDevolucion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@ReservaID", reserva.ReservaID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditarReserva(Reserva reserva)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "UPDATE Reservas SET FechaReserva = @FechaReserva, FechaDevolucion = @FechaDevolucion, UsuarioID = @UsuarioID " +
                               "WHERE ReservaID = @ReservaID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ReservaID", reserva.ReservaID);
                    cmd.Parameters.AddWithValue("@FechaReserva", reserva.FechaReserva);
                    cmd.Parameters.AddWithValue("@FechaDevolucion", reserva.FechaDevolucion);
                    cmd.Parameters.AddWithValue("@UsuarioID", reserva.UsuarioID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void ReservarLibro(int libroID, int usuarioID, DateTime fechaReserva, DateTime FechaDevolucion)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "INSERT INTO Reservas (LibroID, UsuarioID, FechaReserva, FechaDevolucion) " +
                               "VALUES (@LibroID, @UsuarioID, @FechaReserva, @FechaDevolucion)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LibroID", libroID);
                    cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                    cmd.Parameters.AddWithValue("@FechaReserva", fechaReserva);
                    cmd.Parameters.AddWithValue("@FechaDevolucion", FechaDevolucion); // Asegúrate de que este parámetro se agrega

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Libro> ObtenerLibrosMasReservados()//Obtiene una lista de los libros que han sido más reservados.
        {
            List<Libro> librosMasReservados = new List<Libro>();

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT l.LibroID, l.Titulo, l.Autor, COUNT(r.ReservaID) AS VecesReservado
                             FROM Reservas r
                             INNER JOIN Libros l ON r.LibroID = l.LibroID
                             GROUP BY l.LibroID, l.Titulo, l.Autor
                             ORDER BY VecesReservado DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Libro libro = new Libro
                            {
                                LibroID = Convert.ToInt32(reader["LibroID"]),
                                Titulo = reader["Titulo"].ToString(),
                                Autor = reader["Autor"].ToString(),
                            };
                            librosMasReservados.Add(libro);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener libros más reservados: {ex.Message}");
            }

            return librosMasReservados;
        }








    }
}





