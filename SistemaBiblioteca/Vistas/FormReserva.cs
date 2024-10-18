//Formulario para gestionar las reservas de libros.
//Permite seleccionar un libro y realizar una reserva para un usuario específico.
using SistemaBiblioteca.Controladores;
using SistemaBiblioteca.Modelos;

namespace SistemaBiblioteca.Vistas
{
    public partial class FormReserva : Form
    {
        private ReservaController reservaController;
        private LibroController libroController;
        private readonly UsuarioController usuarioController;

        public FormReserva()
        {
            InitializeComponent();
            reservaController = new ReservaController();
            libroController = new LibroController();
            usuarioController = new UsuarioController();
        }

        private void FormReserva_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Formulario cargado");
            CargarLibros();    // Cargar libros en el ComboBox al iniciar el formulario
            CargarUsuarios();   // Cargar usuarios en el ComboBox al iniciar el formulario
            CargarReservas();   // Cargar reservas en el DataGridView al iniciar el formulario
        }

        private void CargarLibros()
        {
            List<Libro> libros = libroController.ObtenerLibros();
            cmbLibros.DataSource = libros;
            cmbLibros.DisplayMember = "Titulo"; // Asegúrate de que esta propiedad existe en la clase Libro
            cmbLibros.ValueMember = "LibroID";  // Campo que representa el ID del libro
            //MessageBox.Show($"Libros cargados: {libros.Count}");
        }

        private void CargarUsuarios()
        {
            List<Usuario> usuarios = usuarioController.ObtenerUsuarios(); // Obtiene la lista de usuarios
            cmbUsuarios.DataSource = usuarios; // Asigna la lista al ComboBox
            cmbUsuarios.DisplayMember = "Nombre"; // Campo a mostrar en el ComboBox
            cmbUsuarios.ValueMember = "UsuarioID"; // Campo que representa el ID
            //MessageBox.Show($"Usuarios cargados: {usuarios.Count}");
        }

        private void CargarReservas()
        {
            List<Reserva> reservas = reservaController.ObtenerReservas();
            dgvReservas.DataSource = reservas; // Carga las reservas en el DataGridView
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            Libro libroSeleccionado = (Libro)cmbLibros.SelectedItem;
            Usuario usuarioSeleccionado = (Usuario)cmbUsuarios.SelectedItem;

            if (libroSeleccionado != null && usuarioSeleccionado != null)
            {
                Reserva nuevaReserva = new Reserva
                {
                    LibroID = libroSeleccionado.LibroID,
                    UsuarioID = usuarioSeleccionado.UsuarioID,
                    FechaReserva = DateTime.Now,
                    FechaDevolucion = DateTime.Now.AddDays(7),
                    ISBN = libroSeleccionado.ISBN
                };

                reservaController.AgregarReserva(nuevaReserva);
                CargarReservas();
                MessageBox.Show("Reserva realizada con éxito.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un libro y un usuario.");
            }
        }
    
    }
}
