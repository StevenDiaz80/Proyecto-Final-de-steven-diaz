//Representa un libro en el sistema.
//Contiene propiedades para almacenar la información relevante sobre cada libro.
using System;

namespace SistemaBiblioteca.Modelos
{
    public class Libro
    {
        public int LibroID { get; set; }
        public string ISBN { get; set; } // ISBN del libro
        public string Titulo { get; set; } // Título del libro
        public string Autor { get; set; } // Autor del libro
        public string Editorial { get; set; } // Editorial del libro
        public int Anio { get; set; } // Año de publicación
        public string Genero { get; set; } // Género del libro
        public int NumeroCopias { get; set; } // Número de copias disponibles
    }
}
