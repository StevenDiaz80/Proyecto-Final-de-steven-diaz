//Formulario para agregar nuevos libros a la base de datos.
//Incluye campos para ingresar información como título, autor, ISBN, etc.
using System;
using System.Windows.Forms;
using SistemaBiblioteca.Controladores;
using SistemaBiblioteca.Modelos;

namespace SistemaBiblioteca.Vistas
{
    public partial class FormAgregarLibro : Form
    {
        private LibroController libroController;
        private Libro libroActual;
        public FormAgregarLibro()
        {
            InitializeComponent();
            libroController = new LibroController(); // Instancia del controlador
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(txtTitulo.Text) || string.IsNullOrEmpty(txtAutor.Text) ||
                string.IsNullOrEmpty(txtEditorial.Text) || string.IsNullOrEmpty(txtAnio.Text) ||
                string.IsNullOrEmpty(txtISBN.Text) || string.IsNullOrEmpty(txtGenero.Text) ||
                string.IsNullOrEmpty(txtNumeroCopias.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear una nueva instancia de Libro con los datos del formulario
            Libro nuevoLibro = new Libro
            {
                ISBN = txtISBN.Text,
                Titulo = txtTitulo.Text,
                Autor = txtAutor.Text,
                Editorial = txtEditorial.Text,
                Anio = int.Parse(txtAnio.Text),
                Genero = txtGenero.Text,
                NumeroCopias = int.Parse(txtNumeroCopias.Text)
            };

            // Llamar al controlador para agregar el libro a la base de datos
            libroController.AgregarLibro(nuevoLibro);

            // Confirmar al usuario que el libro se ha agregado
            MessageBox.Show("Libro agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar los campos del formulario
            txtTitulo.Clear();
            txtAutor.Clear();
            txtEditorial.Clear();
            txtAnio.Clear();
            txtISBN.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            txtEditorial.Clear();
            txtAnio.Clear();
            txtGenero.Clear();
            txtNumeroCopias.Clear();
        }
        // Método para cargar los datos de un libro
        public void CargarLibro(Libro libro)
        {
            //txtTitulo.Text = libro.Titulo;
            //txtAutor.Text = libro.Autor;
            //txtAnio.Text = libro.Anio.ToString();
            //txtEditorial.Text = libro.Editorial;
            libroActual = libro; // Guardar la referencia del libro actual
            txtISBN.Text = libro.ISBN;
            txtTitulo.Text = libro.Titulo;
            txtAutor.Text = libro.Autor;
            txtEditorial.Text = libro.Editorial;
            txtAnio.Text = libro.Anio.ToString();
            txtGenero.Text = libro.Genero;
            txtNumeroCopias.Text = libro.NumeroCopias.ToString();
        }
       

        private void FormAgregarLibro_Load(object sender, EventArgs e)
        {

        }

        // Agregar un método para guardar cambios si el libro ya existe
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (libroActual != null)
            {
                // Actualizar el libro existente
                libroActual.ISBN = txtISBN.Text;
                libroActual.Titulo = txtTitulo.Text;
                libroActual.Autor = txtAutor.Text;
                libroActual.Editorial = txtEditorial.Text;
                libroActual.Anio = int.Parse(txtAnio.Text);
                libroActual.Genero = txtGenero.Text;
                libroActual.NumeroCopias = int.Parse(txtNumeroCopias.Text);

                libroController.EditarLibro(libroActual);

                MessageBox.Show("Libro editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
