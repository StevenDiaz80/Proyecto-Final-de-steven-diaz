//Representa una reserva de libro en el sistema.
//Contiene propiedades para almacenar la información de cada reserva.
using System;

namespace SistemaBiblioteca.Modelos
{
    public class Reserva
    {
        public int ReservaID { get; set; } // ID de la reserva
        public int UsuarioID { get; set; } // ID del Usuario que reserva
        public int LibroID { get; set; } // ID del libro reservado
        public string ISBN { get; set; } // ISBN del libro reservado
        public DateTime FechaReserva { get; set; } // Fecha de reserva
        public DateTime? FechaDevolucion { get; set; } // Fecha en la que se debe devolver el libro
    }
}
