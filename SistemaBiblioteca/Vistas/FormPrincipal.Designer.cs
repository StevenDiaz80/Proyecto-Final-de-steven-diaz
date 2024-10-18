//namespace SistemaBiblioteca.Vistas
//{
//    partial class FormPrincipal
//    {
//        private System.ComponentModel.IContainer components = null;

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        private void InitializeComponent()
//        {
//            lblTitulo = new Label();
//            btnAgregarLibro = new Button();
//            btnVerEditarLibros = new Button();
//            btnBuscarLibros = new Button();
//            btnAgregarUsuario = new Button();
//            btnVerEditarUsuarios = new Button();
//            btnReservar = new Button();
//            btnVerEditarReservas = new Button();
//            SuspendLayout();
//            // 
//            // lblTitulo
//            // 
//            lblTitulo.AutoSize = true;
//            lblTitulo.Font = new Font("Arial", 16F, FontStyle.Bold);
//            lblTitulo.Location = new Point(12, 9);
//            lblTitulo.Name = "lblTitulo";
//            lblTitulo.Size = new Size(300, 32);
//            lblTitulo.TabIndex = 0;
//            lblTitulo.Text = "Sistema de Biblioteca";
//            // 
//            // btnAgregarLibro
//            // 
//            btnAgregarLibro.Location = new Point(40, 66);
//            btnAgregarLibro.Name = "btnAgregarLibro";
//            btnAgregarLibro.Size = new Size(132, 53);
//            btnAgregarLibro.TabIndex = 1;
//            btnAgregarLibro.Text = "Agregar Libro";
//            btnAgregarLibro.Click += btnAgregarLibro_Click;
//            // 
//            // btnVerEditarLibros
//            // 
//            btnVerEditarLibros.Image = Properties.Resources.icono_ver_editar_libro;
//            btnVerEditarLibros.Location = new Point(178, 66);
//            btnVerEditarLibros.Name = "btnVerEditarLibros";
//            btnVerEditarLibros.Size = new Size(52, 53);
//            btnVerEditarLibros.TabIndex = 2;
//            btnVerEditarLibros.Click += btnVerEditarLibros_Click;
//            // 
//            // btnBuscarLibros
//            // 
//            btnBuscarLibros.Location = new Point(134, 255);
//            btnBuscarLibros.Name = "btnBuscarLibros";
//            btnBuscarLibros.Size = new Size(178, 36);
//            btnBuscarLibros.TabIndex = 3;
//            btnBuscarLibros.Text = "Busqueda avanzada";
//            btnBuscarLibros.Click += btnBuscarLibros_Click;
//            // 
//            // btnAgregarUsuario
//            // 
//            btnAgregarUsuario.Location = new Point(40, 125);
//            btnAgregarUsuario.Name = "btnAgregarUsuario";
//            btnAgregarUsuario.Size = new Size(132, 56);
//            btnAgregarUsuario.TabIndex = 4;
//            btnAgregarUsuario.Text = "Agregar Usuario";
//            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
//            // 
//            // btnVerEditarUsuarios
//            // 
//            btnVerEditarUsuarios.Image = Properties.Resources.icono_ver_editar_usuario;
//            btnVerEditarUsuarios.Location = new Point(175, 125);
//            btnVerEditarUsuarios.Name = "btnVerEditarUsuarios";
//            btnVerEditarUsuarios.Size = new Size(55, 56);
//            btnVerEditarUsuarios.TabIndex = 5;
//            btnVerEditarUsuarios.Click += btnVerEditarUsuarios_Click;
//            // 
//            // btnReservar
//            // 
//            btnReservar.Location = new Point(40, 187);
//            btnReservar.Name = "btnReservar";
//            btnReservar.Size = new Size(132, 46);
//            btnReservar.TabIndex = 6;
//            btnReservar.Text = "Reservar Libro";
//            btnReservar.Click += btnReservar_Click;
//            // 
//            // btnVerEditarReservas
//            // 
//            btnVerEditarReservas.Image = Properties.Resources.icono_ver_editar_reserva;
//            btnVerEditarReservas.Location = new Point(175, 187);
//            btnVerEditarReservas.Name = "btnVerEditarReservas";
//            btnVerEditarReservas.Size = new Size(55, 46);
//            btnVerEditarReservas.TabIndex = 7;
//            btnVerEditarReservas.Click += btnVerEditarReservas_Click;
//            // 
//            // FormPrincipal
//            // 
//            ClientSize = new Size(317, 303);
//            Controls.Add(lblTitulo);
//            Controls.Add(btnAgregarLibro);
//            Controls.Add(btnVerEditarLibros);
//            Controls.Add(btnBuscarLibros);
//            Controls.Add(btnAgregarUsuario);
//            Controls.Add(btnVerEditarUsuarios);
//            Controls.Add(btnReservar);
//            Controls.Add(btnVerEditarReservas);
//            Name = "FormPrincipal";
//            Text = "Sistema de Biblioteca";
//            ResumeLayout(false);
//            PerformLayout();
//        }

//        private Label lblTitulo;
//        private Button btnAgregarLibro;
//        private Button btnVerEditarLibros;
//        private Button btnBuscarLibros;
//        private Button btnAgregarUsuario;
//        private Button btnVerEditarUsuarios;
//        private Button btnReservar;
//        private Button btnVerEditarReservas;
//    }
//}
namespace SistemaBiblioteca.Vistas
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            btnAgregarLibro = new Button();
            btnVerEditarLibros = new Button();
            btnBuscarLibros = new Button();
            btnAgregarUsuario = new Button();
            btnVerEditarUsuarios = new Button();
            btnReservar = new Button();
            btnVerEditarReservas = new Button();
            btnAbrirConsultas = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(30, 32);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(300, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema de Biblioteca";
            // 
            // btnAgregarLibro
            // 
            btnAgregarLibro.Location = new Point(67, 83);
            btnAgregarLibro.Name = "btnAgregarLibro";
            btnAgregarLibro.Size = new Size(132, 53);
            btnAgregarLibro.TabIndex = 1;
            btnAgregarLibro.Text = "Agregar Libro";
            btnAgregarLibro.Click += btnAgregarLibro_Click;
            // 
            // btnVerEditarLibros
            // 
            btnVerEditarLibros.Location = new Point(202, 83);
            btnVerEditarLibros.Name = "btnVerEditarLibros";
            btnVerEditarLibros.Size = new Size(86, 53);
            btnVerEditarLibros.TabIndex = 2;
            btnVerEditarLibros.Text = "Ver/EditarLibros";
            btnVerEditarLibros.Click += btnVerEditarLibros_Click;
            // 
            // btnBuscarLibros
            // 
            btnBuscarLibros.Location = new Point(187, 312);
            btnBuscarLibros.Name = "btnBuscarLibros";
            btnBuscarLibros.Size = new Size(178, 36);
            btnBuscarLibros.TabIndex = 3;
            btnBuscarLibros.Text = "Busqueda avanzada";
            btnBuscarLibros.Click += btnBuscarLibros_Click;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(67, 142);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(132, 56);
            btnAgregarUsuario.TabIndex = 4;
            btnAgregarUsuario.Text = "Agregar Usuario";
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // btnVerEditarUsuarios
            // 
            btnVerEditarUsuarios.Location = new Point(202, 142);
            btnVerEditarUsuarios.Name = "btnVerEditarUsuarios";
            btnVerEditarUsuarios.Size = new Size(86, 56);
            btnVerEditarUsuarios.TabIndex = 5;
            btnVerEditarUsuarios.Text = "Ver/EditarUsuarios";
            btnVerEditarUsuarios.Click += btnVerEditarUsuarios_Click;
            // 
            // btnReservar
            // 
            btnReservar.Location = new Point(67, 204);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(132, 62);
            btnReservar.TabIndex = 6;
            btnReservar.Text = "Reservar Libro";
            btnReservar.Click += btnReservar_Click;
            // 
            // btnVerEditarReservas
            // 
            btnVerEditarReservas.Location = new Point(202, 204);
            btnVerEditarReservas.Name = "btnVerEditarReservas";
            btnVerEditarReservas.Size = new Size(86, 62);
            btnVerEditarReservas.TabIndex = 7;
            btnVerEditarReservas.Text = "Ver/EditarReserva";
            btnVerEditarReservas.Click += btnVerEditarReservas_Click;
            // 
            // btnAbrirConsultas
            // 
            btnAbrirConsultas.Location = new Point(12, 312);
            btnAbrirConsultas.Name = "btnAbrirConsultas";
            btnAbrirConsultas.Size = new Size(158, 36);
            btnAbrirConsultas.TabIndex = 8;
            btnAbrirConsultas.Text = "Consultas y Reportes";
            btnAbrirConsultas.Click += btnAbrirConsultas_Click;
            // 
            // FormPrincipal
            // 
            ClientSize = new Size(377, 360);
            Controls.Add(lblTitulo);
            Controls.Add(btnAgregarLibro);
            Controls.Add(btnVerEditarLibros);
            Controls.Add(btnBuscarLibros);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(btnVerEditarUsuarios);
            Controls.Add(btnReservar);
            Controls.Add(btnVerEditarReservas);
            Controls.Add(btnAbrirConsultas);
            Name = "FormPrincipal";
            Text = "Sistema de Biblioteca";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo;
        private Button btnAgregarLibro;
        private Button btnVerEditarLibros;
        private Button btnBuscarLibros;
        private Button btnAgregarUsuario;
        private Button btnVerEditarUsuarios;
        private Button btnReservar;
        private Button btnVerEditarReservas;
        private Button btnAbrirConsultas;
    }
}
