
//namespace SistemaBiblioteca.Vistas
//{
//    partial class FormVerEditarLibro
//    {
//        private System.ComponentModel.IContainer components = null;
//        private System.Windows.Forms.DataGridView dgvLibros;
//        private System.Windows.Forms.Button btnAgregar; // Nuevo botón para agregar libros
//        private System.Windows.Forms.Button btnEditar;
//        private System.Windows.Forms.Button btnEliminar;

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
//            dgvLibros = new DataGridView();
//            btnAgregar = new Button();
//            btnEditar = new Button();
//            btnEliminar = new Button();
//            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
//            SuspendLayout();
//            // 
//            // dgvLibros
//            // 
//            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            dgvLibros.Location = new Point(12, 12);
//            dgvLibros.Name = "dgvLibros";
//            dgvLibros.RowHeadersWidth = 51;
//            dgvLibros.Size = new Size(760, 400);
//            dgvLibros.TabIndex = 0;
//            // 
//            // btnAgregar
//            // 
//            btnAgregar.Location = new Point(12, 420);
//            btnAgregar.Name = "btnAgregar";
//            btnAgregar.Size = new Size(75, 39);
//            btnAgregar.TabIndex = 1;
//            btnAgregar.Text = "Agregar";
//            btnAgregar.UseVisualStyleBackColor = true;
//            btnAgregar.Click += btnAgregar_Click;
//            // 
//            // btnEditar
//            // 
//            btnEditar.Location = new Point(179, 418);
//            btnEditar.Name = "btnEditar";
//            btnEditar.Size = new Size(75, 39);
//            btnEditar.TabIndex = 2;
//            btnEditar.Text = "Editar";
//            btnEditar.UseVisualStyleBackColor = true;
//            btnEditar.Click += btnEditar_Click;
//            // 
//            // btnEliminar
//            // 
//            btnEliminar.Location = new Point(93, 420);
//            btnEliminar.Name = "btnEliminar";
//            btnEliminar.Size = new Size(80, 39);
//            btnEliminar.TabIndex = 3;
//            btnEliminar.Text = "Eliminar";
//            btnEliminar.UseVisualStyleBackColor = true;
//            btnEliminar.Click += btnEliminar_Click;
//            // 
//            // FormVerEditarLibro
//            // 
//            ClientSize = new Size(784, 475);
//            Controls.Add(dgvLibros);
//            Controls.Add(btnAgregar);
//            Controls.Add(btnEditar);
//            Controls.Add(btnEliminar);
//            Name = "FormVerEditarLibro";
//            Text = "Ver / Editar Libros";
//            Load += FormVerEditarLibro_Load;
//            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
//            ResumeLayout(false);
//        }
//    }
//}
namespace SistemaBiblioteca.Vistas
{
    partial class FormVerEditarLibro
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;

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
            dgvLibros = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(12, 12);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersWidth = 51;
            dgvLibros.Size = new Size(760, 400);
            dgvLibros.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 420);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 39);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(93, 420);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 39);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(174, 420);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(80, 39);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormVerEditarLibro
            // 
            ClientSize = new Size(778, 470);
            Controls.Add(dgvLibros);
            Controls.Add(btnAgregar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Name = "FormVerEditarLibro";
            Text = "Ver / Editar Libros";
            Load += FormVerEditarLibro_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
        }
    }
}
