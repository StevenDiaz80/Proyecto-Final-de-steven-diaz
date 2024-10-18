//DBconnection.cs
//Esta clase gestiona la conexión a la base de datos. Contiene métodos para abrir y cerrar conexiones, así como un método para probar la conexión.
using Microsoft.Data.SqlClient;


namespace SistemaBiblioteca.Controladores
{
    public class DBConnection
    {
        private SqlConnection sqlConnection;
        private string connectionString;

        public DBConnection()
        {
            //cadena de conexión a SQL Server
            connectionString = "Server=localhost;Database=SistemaBiblioteca;Trusted_Connection=True;TrustServerCertificate=True;";

            sqlConnection = new SqlConnection(connectionString);
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString); 
        }

        public void OpenConnection() // Abre la conexión a la base de datos.
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
                Console.WriteLine("Conexión abierta.");
            }
        }

        public void CloseConnection()//Cierra la conexión.
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
                Console.WriteLine("Conexión cerrada correctamente.");
            }
        }

        
        public void TestConnection()//Prueba la conexión y muestra un mensaje de éxito o error.
        {
            try
            {
                OpenConnection();
                Console.WriteLine("Conexión exitosa.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}