// Representa un usuario en el sistema.
// Contiene propiedades para almacenar la información relevante de cada usuario.
using System;

namespace SistemaBiblioteca.Modelos
{
    public class Usuario
    {
        public int UsuarioID { get; set; } // ID del Usuario
        public string Nombre { get; set; } // Nombre del Usuario
        public string Apellido { get; set; } // Apellido del Usuario
        public string Email { get; set; } // Correo Electrónico del Usuario
        public string Telefono { get; set; } // Teléfono del Usuario
    }
}
