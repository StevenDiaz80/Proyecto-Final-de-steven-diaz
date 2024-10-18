//Formulario que permite ejecutar consultas sobre la base de datos.
//Los usuarios pueden seleccionar entre diferentes consultas (libros disponibles, libros por género, libros más reservados y usuarios más activos) y ver los resultados en un DataGridView.
using SistemaBiblioteca.Controladores;
using SistemaBiblioteca.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaBiblioteca.Vistas
{
    public partial class FormConsultasReportes : Form
    {
        // Añadir instancias de los controladores
        private readonly UsuarioController usuarioController;
        private readonly ReservaController reservaController;

        public FormConsultasReportes()
        {
            InitializeComponent();
            // Inicializar los controladores
            usuarioController = new UsuarioController();
            reservaController = new ReservaController();
        }

        private void btnEjecutarConsulta_Click(object sender, EventArgs e)
        {
            // Lógica para ejecutar la consulta seleccionada en comboBoxConsulta
            string consultaSeleccionada = comboBoxConsulta.SelectedItem?.ToString();
            if (consultaSeleccionada == null)
            {
                MessageBox.Show("Seleccione una consulta válida.");
                return;
            }

            switch (consultaSeleccionada)
            {
                case "Libros Disponibles":
                    MostrarLibrosDisponibles();
                    break;

                case "Libros por Género":
                    string genero = textBoxGenero.Text.Trim();
                    if (string.IsNullOrEmpty(genero))
                    {
                        MessageBox.Show("Ingrese un género válido.");
                    }
                    else
                    {
                        MostrarLibrosPorGenero(genero);
                    }
                    break;

                case "Libros Más Reservados":
                    MostrarLibrosMasReservados();
                    break;

                case "Usuarios Más Activos":
                    MostrarUsuariosMasActivos();
                    break;

                default:
                    MessageBox.Show("Seleccione una consulta válida.");
                    break;
            }
        }

        // Métodos para cada consulta
        private void MostrarLibrosDisponibles()
        {
            try
            {
                var librosDisponibles = LibroController.ObtenerLibrosDisponibles();
                dataGridViewResultados.DataSource = librosDisponibles;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los libros disponibles: " + ex.Message);
            }
        }

        private void MostrarLibrosPorGenero(string genero)
        {
            try
            {
                var librosPorGenero = LibroController.ObtenerLibrosPorGenero(genero);
                dataGridViewResultados.DataSource = librosPorGenero;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los libros por género: " + ex.Message);
            }
        }

        private void MostrarLibrosMasReservados()
        {
            try
            {
                var librosMasReservados = reservaController.ObtenerLibrosMasReservados(); // Usar la instancia
                dataGridViewResultados.DataSource = librosMasReservados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los libros más reservados: " + ex.Message);
            }
        }

        private void MostrarUsuariosMasActivos()
        {
            try
            {
                var usuariosMasActivos = usuarioController.ObtenerUsuariosMasActivos(); // Usar la instancia
                dataGridViewResultados.DataSource = usuariosMasActivos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los usuarios más activos: " + ex.Message);
            }
        }
    }
}
