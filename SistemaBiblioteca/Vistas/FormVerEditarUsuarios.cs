using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaBiblioteca.Controladores;
using SistemaBiblioteca.Modelos;

namespace SistemaBiblioteca.Vistas
{
    public partial class FormVerEditarUsuarios : Form
    {
        private UsuarioController usuarioController;

        public FormVerEditarUsuarios()
        {
            InitializeComponent();
            usuarioController = new UsuarioController();
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            List<Usuario> usuarios = usuarioController.ObtenerUsuarios();
            dgvUsuarios.DataSource = usuarios;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                Usuario usuarioSeleccionado = (Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem;
                FormAgregarUsuario formAgregarUsuario = new FormAgregarUsuario();
                formAgregarUsuario.Text = "Editar Usuario";
                formAgregarUsuario.CargarUsuario(usuarioSeleccionado);
                formAgregarUsuario.ShowDialog();
                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario para editar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                Usuario usuarioSeleccionado = (Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem;

                // Confirmación antes de eliminar
                DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas eliminar al usuario {usuarioSeleccionado.Nombre}?",
                                                        "Confirmar eliminación",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    usuarioController.EliminarUsuario(usuarioSeleccionado.UsuarioID); // Llama al método de eliminación
                    MessageBox.Show($"Usuario {usuarioSeleccionado.Nombre} eliminado.");
                    CargarUsuarios(); // Refrescar la lista de usuarios
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario para eliminar.");
            }
        }

    }
}
