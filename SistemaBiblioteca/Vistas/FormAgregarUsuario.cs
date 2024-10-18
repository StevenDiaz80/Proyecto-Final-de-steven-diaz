// Formulario para agregar nuevos usuarios a la base de datos.
// Incluye campos para nombre, apellido, email y teléfono.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaBiblioteca.Controladores;
using SistemaBiblioteca.Modelos;

namespace SistemaBiblioteca.Vistas
{
    public partial class FormAgregarUsuario : Form
    {
        private UsuarioController usuarioController;

        public FormAgregarUsuario()
        {
            InitializeComponent();
            usuarioController = new UsuarioController();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Email = txtEmail.Text,
                Telefono = txtTelefono.Text
            };

            usuarioController.AgregarUsuario(nuevoUsuario);
            MessageBox.Show("Usuario agregado exitosamente.");
            this.Close();
        }

        // Método para cargar los datos de un usuario
        public void CargarUsuario(Usuario usuario)
        {
            txtNombre.Text = usuario.Nombre;
            txtApellido.Text = usuario.Apellido;
            txtEmail.Text = usuario.Email;
            txtTelefono.Text = usuario.Telefono;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAgregarUsuario_Load(object sender, EventArgs e)
        {
           
        }
    }
}
