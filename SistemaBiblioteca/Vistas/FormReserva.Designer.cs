namespace SistemaBiblioteca.Vistas
{
    partial class FormReserva
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbLibros;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.DataGridView dgvReservas;

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
            cmbLibros = new ComboBox();
            cmbUsuarios = new ComboBox();
            btnReservar = new Button();
            dgvReservas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            SuspendLayout();
            // 
            // cmbLibros
            // 
            cmbLibros.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLibros.FormattingEnabled = true;
            cmbLibros.Location = new Point(22, 12);
            cmbLibros.Name = "cmbLibros";
            cmbLibros.Size = new Size(360, 28);
            cmbLibros.TabIndex = 0;
            // 
            // cmbUsuarios
            // 
            cmbUsuarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuarios.FormattingEnabled = true;
            cmbUsuarios.Location = new Point(22, 50);
            cmbUsuarios.Name = "cmbUsuarios";
            cmbUsuarios.Size = new Size(360, 28);
            cmbUsuarios.TabIndex = 1;
            // 
            // btnReservar
            // 
            btnReservar.Location = new Point(22, 84);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(74, 32);
            btnReservar.TabIndex = 1;
            btnReservar.Text = "Reservar";
            btnReservar.UseVisualStyleBackColor = true;
            btnReservar.Click += btnReservar_Click;
            // 
            // dgvReservas
            // 
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.Location = new Point(12, 133);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.RowHeadersWidth = 51;
            dgvReservas.Size = new Size(590, 216);
            dgvReservas.TabIndex = 2;
            // 
            // FormReserva
            // 
            ClientSize = new Size(614, 361);
            Controls.Add(dgvReservas);
            Controls.Add(btnReservar);
            Controls.Add(cmbUsuarios);
            Controls.Add(cmbLibros);
            Name = "FormReserva";
            Text = "Reservar Libros";
            Load += FormReserva_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            ResumeLayout(false);
        }
    }
}
