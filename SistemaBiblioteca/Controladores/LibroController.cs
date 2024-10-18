using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using SistemaBiblioteca.Modelos;
using System.Data;

namespace SistemaBiblioteca.Controladores
{
    public class LibroController
    {
        private readonly DBConnection db;

        public LibroController()
        {
            db = new DBConnection();
        }

        public List<Libro> ObtenerLibros()
        {
            List<Libro> libros = new List<Libro>();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Libros";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Libro libro = new Libro
                        {
                            LibroID = Convert.ToInt32(reader["LibroID"]),
                            ISBN = reader["ISBN"] != DBNull.Value ? reader["ISBN"].ToString() : "Sin ISBN",
                            Titulo = reader["Titulo"].ToString(),
                            Autor = reader["Autor"].ToString(),
                            Editorial = reader["Editorial"].ToString(),
                            Anio = Convert.ToInt32(reader["Anio"]),
                            Genero = reader["Genero"].ToString(),
                            NumeroCopias = Convert.ToInt32(reader["NumeroCopias"])
                        };
                        libros.Add(libro);
                    }
                }
            }

            return libros;
        }

        public void AgregarLibro(Libro libro)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Libros (ISBN, Titulo, Autor, Editorial, Anio, Genero, NumeroCopias) " +
                               "VALUES (@ISBN, @Titulo, @Autor, @Editorial, @Anio, @Genero, @NumeroCopias)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ISBN", libro.ISBN);
                    cmd.Parameters.AddWithValue("@Titulo", libro.Titulo);
                    cmd.Parameters.AddWithValue("@Autor", libro.Autor);
                    cmd.Parameters.AddWithValue("@Editorial", libro.Editorial);
                    cmd.Parameters.AddWithValue("@Anio", libro.Anio);
                    cmd.Parameters.AddWithValue("@Genero", libro.Genero);
                    cmd.Parameters.AddWithValue("@NumeroCopias", libro.NumeroCopias);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditarLibro(Libro libro)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Libros SET ISBN = @ISBN, Titulo = @Titulo, Autor = @Autor, " +
                               "Editorial = @Editorial, Anio = @Anio, Genero = @Genero, NumeroCopias = @NumeroCopias " +
                               "WHERE LibroID = @LibroID"; // Corrección aquí
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@LibroID", libro.LibroID);
                    command.Parameters.AddWithValue("@ISBN", libro.ISBN);
                    command.Parameters.AddWithValue("@Titulo", libro.Titulo);
                    command.Parameters.AddWithValue("@Autor", libro.Autor);
                    command.Parameters.AddWithValue("@Editorial", libro.Editorial);
                    command.Parameters.AddWithValue("@Anio", libro.Anio);
                    command.Parameters.AddWithValue("@Genero", libro.Genero);
                    command.Parameters.AddWithValue("@NumeroCopias", libro.NumeroCopias);

                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para buscar libros
        public DataTable BuscarLibros(string titulo, string autor, string isbn, string genero)
        {
            DataTable dtLibros = new DataTable();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Libros WHERE 1=1";

                // Añadir condiciones a la consulta según los parámetros no nulos
                if (!string.IsNullOrWhiteSpace(titulo))
                    query += " AND Titulo LIKE @Titulo";
                if (!string.IsNullOrWhiteSpace(autor))
                    query += " AND Autor LIKE @Autor";
                if (!string.IsNullOrWhiteSpace(isbn))
                    query += " AND ISBN = @ISBN";
                if (!string.IsNullOrWhiteSpace(genero))
                    query += " AND Genero = @Genero";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrWhiteSpace(titulo))
                        command.Parameters.AddWithValue("@Titulo", "%" + titulo + "%");
                    if (!string.IsNullOrWhiteSpace(autor))
                        command.Parameters.AddWithValue("@Autor", "%" + autor + "%");
                    if (!string.IsNullOrWhiteSpace(isbn))
                        command.Parameters.AddWithValue("@ISBN", isbn);
                    if (!string.IsNullOrWhiteSpace(genero))
                        command.Parameters.AddWithValue("@Genero", genero);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dtLibros); // Llenar DataTable con los resultados
                    }
                }
            }

            return dtLibros; // Retorna el DataTable con los resultados
        }

        // Método para verificar si hay reservas activas para un libro
        public bool TieneReservasActivas(int libroID)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Reservas WHERE LibroID = @LibroID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LibroID", libroID);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; // Retorna true si hay reservas activas
                }
            }
        }

        public void EliminarLibro(int libroID)
        {
            // Verificar si el libro tiene reservas activas
            if (TieneReservasActivas(libroID))
            {
                throw new InvalidOperationException("No se puede eliminar el libro porque tiene reservas activas.");
            }

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Libros WHERE LibroID = @LibroID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LibroID", libroID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Libro> ObtenerLibrosDisponibles()
        {
            List<Libro> librosDisponibles = new List<Libro>();
            using (SqlConnection conn = new SqlConnection("your_connection_string"))
            {
                string query = "SELECT * FROM Libros WHERE NumeroCopias > 0";  // Asumiendo que Número de copias mayor a 0 es "disponible"
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Libro libro = new Libro
                    {
                        LibroID = (int)reader["LibrosID"],
                        Titulo = reader["Titulo"].ToString(),
                        Autor = reader["Autor"].ToString(),
                        NumeroCopias = (int)reader["NumeroCopias"]
                    };
                    librosDisponibles.Add(libro);
                }
            }
            return librosDisponibles;
        }

        public static List<Libro> ObtenerLibrosPorGenero(string genero)
        {
            List<Libro> librosPorGenero = new List<Libro>();
            using (SqlConnection conn = new SqlConnection("your_connection_string"))
            {
                string query = "SELECT * FROM Libros WHERE Genero = @Genero";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Genero", genero);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Libro libro = new Libro
                    {
                        LibroID = (int)reader["LibrosID"],
                        Titulo = reader["Titulo"].ToString(),
                        Autor = reader["Autor"].ToString(),
                        Genero = reader["Genero"].ToString()
                    };
                    librosPorGenero.Add(libro);
                }
            }
            return librosPorGenero;
        }
    }
}
    



