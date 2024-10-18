//Formulario para visualizar y editar la información de un libro existente.
//Permite actualizar detalles como el título, autor y estado del libro.
using SistemaBiblioteca.Controladores;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaBiblioteca.Modelos;


namespace SistemaBiblioteca.Vistas
{
    public partial class FormVerEditarLibro : Form
    {
        private LibroController libroController;

        public FormVerEditarLibro()
        {
            InitializeComponent();
            libroController = new LibroController();
            CargarLibros();
        }

        // Método para cargar todos los libros en el DataGridView
        private void CargarLibros()
        {
            List<Libro> libros = libroController.ObtenerLibros();
            dgvLibros.DataSource = libros;
        }

        // Evento para agregar un libro
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarLibro formAgregarLibro = new FormAgregarLibro();
            formAgregarLibro.Text = "Agregar Libro";
            if (formAgregarLibro.ShowDialog() == DialogResult.OK)
            {
                CargarLibros(); // Recargar la lista de libros después de agregar
            }
        }

        // Evento para editar un libro
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                Libro libroSeleccionado = (Libro)dgvLibros.SelectedRows[0].DataBoundItem;
                FormAgregarLibro formAgregarLibro = new FormAgregarLibro();
                formAgregarLibro.Text = "Editar Libro";
                formAgregarLibro.CargarLibro(libroSeleccionado); // Cargar el libro en el formulario de agregar/editar
                formAgregarLibro.ShowDialog();
                CargarLibros(); // Recargar la lista de libros después de editar
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un libro para editar.");
            }
        }

        // Evento para eliminar un libro
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                Libro libroSeleccionado = (Libro)dgvLibros.SelectedRows[0].DataBoundItem;

                // Confirmar eliminación
                DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas eliminar el libro '{libroSeleccionado.Titulo}'?",
                                                       "Confirmar Eliminación",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        libroController.EliminarLibro(libroSeleccionado.LibroID); // Llamada al método de eliminación
                        MessageBox.Show($"Libro {libroSeleccionado.Titulo} eliminado.");
                        CargarLibros(); // Recargar la lista de libros después de eliminar
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un libro para eliminar.");
            }
        }

        private void FormVerEditarLibro_Load(object sender, EventArgs e)
        {
            // Aquí puedes cargar datos adicionales si es necesario
        }
    }
}


