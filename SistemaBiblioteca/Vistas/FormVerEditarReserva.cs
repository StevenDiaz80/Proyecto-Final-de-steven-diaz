//Formularios para visualizar y editar reservas y usuarios respectivamente.
//Permiten realizar modificaciones en la información existente.
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaBiblioteca.Controladores;
using SistemaBiblioteca.Modelos;

namespace SistemaBiblioteca.Vistas
{
    public partial class FormVerEditarReserva : Form
    {
        private ReservaController reservaController;

        public FormVerEditarReserva()
        {
            InitializeComponent();
            reservaController = new ReservaController();
            CargarReservas();
        }

        private void CargarReservas()
        {
            List<Reserva> reservas = reservaController.ObtenerReservas();
            dgvReservas.DataSource = reservas;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count > 0)
            {
                int reservaID = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells["ReservaID"].Value);
                Reserva reservaSeleccionada = reservaController.ObtenerReservaPorID(reservaID);
                txtLibroID.Text = reservaSeleccionada.LibroID.ToString();
                dtpFechaReserva.Value = reservaSeleccionada.FechaReserva;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una reserva para editar.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count > 0)
            {
                int reservaID = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells["ReservaID"].Value);
                Reserva reservaActualizada = new Reserva
                {
                    ReservaID = reservaID,
                    LibroID = Convert.ToInt32(txtLibroID.Text),
                    FechaReserva = dtpFechaReserva.Value
                };
                reservaController.ActualizarReserva(reservaActualizada);
                CargarReservas();
                MessageBox.Show("Reserva actualizada con éxito.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una reserva para actualizar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count > 0)
            {
                int reservaID = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells["ReservaID"].Value);
                reservaController.EliminarReserva(reservaID);
                CargarReservas();
                MessageBox.Show("Reserva eliminada con éxito.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una reserva para eliminar.");
            }
        }
    }
}
