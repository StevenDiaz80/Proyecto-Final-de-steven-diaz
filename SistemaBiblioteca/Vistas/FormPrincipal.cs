////Este es el formulario principal de la aplicación.
//Proporciona navegación a las diferentes secciones del sistema (agregar libros, agregar usuarios, consultar reservas, etc.).
using SistemaBiblioteca.Controladores; // Asegúrate de tener la referencia a los controladores
using SistemaBiblioteca.Modelos; // Asegúrate de tener la referencia a los modelos
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SistemaBiblioteca.Properties;

namespace SistemaBiblioteca.Vistas
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void btnAbrirConsultas_Click(object sender, EventArgs e)
        {
            FormConsultasReportes formConsultas = new FormConsultasReportes();
            formConsultas.Show();
        }

        private void btnBuscarLibros_Click(object sender, EventArgs e)
        {
            FormBusquedaAvanzada formBusqueda = new FormBusquedaAvanzada();
            formBusqueda.ShowDialog(); // Muestra el formulario como un diálogo modal
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            FormAgregarLibro formAgregarLibro = new FormAgregarLibro();
            formAgregarLibro.Show();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            FormAgregarUsuario formAgregarUsuario = new FormAgregarUsuario();
            formAgregarUsuario.Show();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            FormReserva formReserva = new FormReserva();
            formReserva.Show();
        }

        private void btnVerEditarLibros_Click(object sender, EventArgs e)
        {
            FormVerEditarLibro formVerEditarLibro = new FormVerEditarLibro();
            formVerEditarLibro.Show();
        }

        private void btnVerEditarUsuarios_Click(object sender, EventArgs e)
        {
            FormVerEditarUsuarios formVerEditarUsuarios = new FormVerEditarUsuarios();
            formVerEditarUsuarios.Show();
        }

        private void btnVerEditarReservas_Click(object sender, EventArgs e)
        {
            FormVerEditarReserva formVerEditarReserva = new FormVerEditarReserva();
            formVerEditarReserva.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // Aquí puedes cargar datos adicionales si es necesario
        }
    }
}
