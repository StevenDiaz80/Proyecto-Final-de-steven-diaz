//namespace SistemaBiblioteca.Vistas
//{
//    partial class FormAgregarLibro
//    {
//        private System.ComponentModel.IContainer components = null;
//        private System.Windows.Forms.Button btnAgregar;
//        private System.Windows.Forms.TextBox txtTitulo;
//        private System.Windows.Forms.TextBox txtAutor;
//        private System.Windows.Forms.TextBox txtEditorial;
//        private System.Windows.Forms.TextBox txtAnio;
//        private System.Windows.Forms.Label lblTitulo;
//        private System.Windows.Forms.Label lblAutor;
//        private System.Windows.Forms.Label lblEditorial;
//        private System.Windows.Forms.Label lblAnio;
//        private System.Windows.Forms.TextBox txtISBN;
//        private System.Windows.Forms.TextBox txtGenero;
//        private System.Windows.Forms.TextBox txtNumeroCopias;

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
//            btnAgregar = new Button();
//            txtTitulo = new TextBox();
//            txtAutor = new TextBox();
//            txtEditorial = new TextBox();
//            txtAnio = new TextBox();
//            lblTitulo = new Label();
//            lblAutor = new Label();
//            lblEditorial = new Label();
//            lblAnio = new Label();
//            this.txtISBN = new System.Windows.Forms.TextBox();
//            this.txtGenero = new System.Windows.Forms.TextBox();
//            this.txtNumeroCopias = new System.Windows.Forms.TextBox();
//            SuspendLayout();
//            // 
//            // btnAgregar
//            // 
//            btnAgregar.Location = new Point(150, 180);
//            btnAgregar.Name = "btnAgregar";
//            btnAgregar.Size = new Size(100, 30);
//            btnAgregar.TabIndex = 0;
//            btnAgregar.Text = "Agregar";
//            btnAgregar.UseVisualStyleBackColor = true;
//            btnAgregar.Click += btnAgregar_Click;
//            // 
//            // txtTitulo
//            // 
//            txtTitulo.Location = new Point(120, 30);
//            txtTitulo.Name = "txtTitulo";
//            txtTitulo.Size = new Size(200, 27);
//            txtTitulo.TabIndex = 1;
//            // 
//            // txtAutor
//            // 
//            txtAutor.Location = new Point(120, 70);
//            txtAutor.Name = "txtAutor";
//            txtAutor.Size = new Size(200, 27);
//            txtAutor.TabIndex = 2;
//            // 
//            // txtEditorial
//            // 
//            txtEditorial.Location = new Point(120, 110);
//            txtEditorial.Name = "txtEditorial";
//            txtEditorial.Size = new Size(200, 27);
//            txtEditorial.TabIndex = 3;
//            // 
//            // txtAnio
//            // 
//            txtAnio.Location = new Point(120, 150);
//            txtAnio.Name = "txtAnio";
//            txtAnio.Size = new Size(200, 27);
//            txtAnio.TabIndex = 4;
//            // 
//            // lblTitulo
//            // 
//            lblTitulo.AutoSize = true;
//            lblTitulo.Location = new Point(30, 30);
//            lblTitulo.Name = "lblTitulo";
//            lblTitulo.Size = new Size(47, 20);
//            lblTitulo.TabIndex = 5;
//            lblTitulo.Text = "Título";
//            // 
//            // lblAutor
//            // 
//            lblAutor.AutoSize = true;
//            lblAutor.Location = new Point(30, 70);
//            lblAutor.Name = "lblAutor";
//            lblAutor.Size = new Size(46, 20);
//            lblAutor.TabIndex = 6;
//            lblAutor.Text = "Autor";
//            // 
//            // lblEditorial
//            // 
//            lblEditorial.AutoSize = true;
//            lblEditorial.Location = new Point(30, 110);
//            lblEditorial.Name = "lblEditorial";
//            lblEditorial.Size = new Size(65, 20);
//            lblEditorial.TabIndex = 7;
//            lblEditorial.Text = "Editorial";
//            // 
//            // lblAnio
//            // 
//            lblAnio.AutoSize = true;
//            lblAnio.Location = new Point(30, 150);
//            lblAnio.Name = "lblAnio";
//            lblAnio.Size = new Size(36, 20);
//            lblAnio.TabIndex = 8;
//            lblAnio.Text = "Año";

//            // 
//            // txtISBN
//            // 
//            this.txtISBN.Location = new System.Drawing.Point(12, 25); // Ajusta la ubicación
//            this.txtISBN.Name = "txtISBN";
//            this.txtISBN.Size = new System.Drawing.Size(200, 20);
//            this.txtISBN.TabIndex = 0;

//            // 
//            // txtGenero
//            // 
//            this.txtGenero.Location = new System.Drawing.Point(12, 65); // Ajusta la ubicación
//            this.txtGenero.Name = "txtGenero";
//            this.txtGenero.Size = new System.Drawing.Size(200, 20);
//            this.txtGenero.TabIndex = 1;

//            // 
//            // txtNumeroCopias
//            // 
//            this.txtNumeroCopias.Location = new System.Drawing.Point(12, 105); // Ajusta la ubicación
//            this.txtNumeroCopias.Name = "txtNumeroCopias";
//            this.txtNumeroCopias.Size = new System.Drawing.Size(200, 20);
//            this.txtNumeroCopias.TabIndex = 2;

//            // 
//            // FormAgregarLibro
//            // 
//            ClientSize = new Size(400, 250);
//            Controls.Add(lblAnio);
//            Controls.Add(lblEditorial);
//            Controls.Add(lblAutor);
//            Controls.Add(lblTitulo);
//            Controls.Add(txtAnio);
//            Controls.Add(txtEditorial);
//            Controls.Add(txtAutor);
//            Controls.Add(txtTitulo);
//            Controls.Add(btnAgregar);
//            this.Controls.Add(this.txtISBN);
//            this.Controls.Add(this.txtGenero);
//            this.Controls.Add(this.txtNumeroCopias);
//            Name = "FormAgregarLibro";
//            Text = "Agregar Libro";
//            Load += FormAgregarLibro_Load;
//            ResumeLayout(false);
//            PerformLayout();
//        }
//    }
//}
namespace SistemaBiblioteca.Vistas
{
    partial class FormAgregarLibro
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtNumeroCopias;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblNumeroCopias;

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
            btnAgregar = new Button();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtEditorial = new TextBox();
            txtAnio = new TextBox();
            txtISBN = new TextBox();
            txtGenero = new TextBox();
            txtNumeroCopias = new TextBox();
            lblTitulo = new Label();
            lblAutor = new Label();
            lblEditorial = new Label();
            lblAnio = new Label();
            lblISBN = new Label();
            lblGenero = new Label();
            lblNumeroCopias = new Label();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(190, 333);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 30);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(169, 27);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(200, 27);
            txtTitulo.TabIndex = 1;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(169, 67);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(200, 27);
            txtAutor.TabIndex = 2;
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(169, 107);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(200, 27);
            txtEditorial.TabIndex = 3;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(169, 147);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(200, 27);
            txtAnio.TabIndex = 4;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(169, 187);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(200, 27);
            txtISBN.TabIndex = 5;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(169, 227);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(200, 27);
            txtGenero.TabIndex = 6;
            // 
            // txtNumeroCopias
            // 
            txtNumeroCopias.Location = new Point(169, 267);
            txtNumeroCopias.Name = "txtNumeroCopias";
            txtNumeroCopias.Size = new Size(200, 27);
            txtNumeroCopias.TabIndex = 7;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(30, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(47, 20);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Título";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(30, 70);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(46, 20);
            lblAutor.TabIndex = 9;
            lblAutor.Text = "Autor";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Location = new Point(30, 110);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(65, 20);
            lblEditorial.TabIndex = 10;
            lblEditorial.Text = "Editorial";
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(30, 150);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(36, 20);
            lblAnio.TabIndex = 11;
            lblAnio.Text = "Año";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(30, 190);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(41, 20);
            lblISBN.TabIndex = 12;
            lblISBN.Text = "ISBN";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(30, 230);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(57, 20);
            lblGenero.TabIndex = 13;
            lblGenero.Text = "Género";
            // 
            // lblNumeroCopias
            // 
            lblNumeroCopias.AutoSize = true;
            lblNumeroCopias.Location = new Point(30, 270);
            lblNumeroCopias.Name = "lblNumeroCopias";
            lblNumeroCopias.Size = new Size(133, 20);
            lblNumeroCopias.TabIndex = 14;
            lblNumeroCopias.Text = "Número de Copias";
            // 
            // FormAgregarLibro
            // 
            ClientSize = new Size(472, 389);
            Controls.Add(lblNumeroCopias);
            Controls.Add(txtNumeroCopias);
            Controls.Add(lblGenero);
            Controls.Add(txtGenero);
            Controls.Add(lblISBN);
            Controls.Add(txtISBN);
            Controls.Add(lblAnio);
            Controls.Add(txtAnio);
            Controls.Add(lblEditorial);
            Controls.Add(txtEditorial);
            Controls.Add(lblAutor);
            Controls.Add(txtAutor);
            Controls.Add(lblTitulo);
            Controls.Add(txtTitulo);
            Controls.Add(btnAgregar);
            Name = "FormAgregarLibro";
            Text = "Agregar Libro";
            Load += FormAgregarLibro_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

