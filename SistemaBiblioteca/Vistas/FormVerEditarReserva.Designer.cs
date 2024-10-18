namespace SistemaBiblioteca.Vistas
{
    partial class FormVerEditarReserva
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtLibroID;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;

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
            dgvReservas = new DataGridView();
            btnEditar = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            txtLibroID = new TextBox();
            dtpFechaReserva = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            SuspendLayout();
            // 
            // dgvReservas
            // 
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.Location = new Point(12, 12);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.RowHeadersWidth = 51;
            dgvReservas.Size = new Size(400, 200);
            dgvReservas.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(12, 220);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 40);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(93, 220);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 40);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(174, 220);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 40);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtLibroID
            // 
            txtLibroID.Location = new Point(12, 266);
            txtLibroID.Name = "txtLibroID";
            txtLibroID.Size = new Size(100, 27);
            txtLibroID.TabIndex = 4;
            // 
            // dtpFechaReserva
            // 
            dtpFechaReserva.Location = new Point(118, 266);
            dtpFechaReserva.Name = "dtpFechaReserva";
            dtpFechaReserva.Size = new Size(200, 27);
            dtpFechaReserva.TabIndex = 5;
            // 
            // FormVerEditarReserva
            // 
            ClientSize = new Size(425, 319);
            Controls.Add(dtpFechaReserva);
            Controls.Add(txtLibroID);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(dgvReservas);
            Name = "FormVerEditarReserva";
            Text = "Ver y Editar Reservas";
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
