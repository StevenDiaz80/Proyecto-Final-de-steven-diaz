namespace SistemaBiblioteca.Vistas
{
    partial class FormConsultasReportes
    {
        private System.Windows.Forms.ComboBox comboBoxConsulta;
        private System.Windows.Forms.TextBox textBoxGenero;
        private System.Windows.Forms.Button btnEjecutarConsulta;
        private System.Windows.Forms.DataGridView dataGridViewResultados;

        private void InitializeComponent()
        {
            this.comboBoxConsulta = new System.Windows.Forms.ComboBox();
            this.textBoxGenero = new System.Windows.Forms.TextBox();
            this.btnEjecutarConsulta = new System.Windows.Forms.Button();
            this.dataGridViewResultados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).BeginInit();
            this.SuspendLayout();

            // comboBoxConsulta
            this.comboBoxConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConsulta.Items.AddRange(new object[] {
                "Libros Disponibles",
                "Libros por Género",
                "Libros Más Reservados",
                "Usuarios Más Activos"});
            this.comboBoxConsulta.Location = new System.Drawing.Point(12, 12);
            this.comboBoxConsulta.Name = "comboBoxConsulta";
            this.comboBoxConsulta.Size = new System.Drawing.Size(200, 21);
            this.comboBoxConsulta.TabIndex = 0;

            // textBoxGenero
            this.textBoxGenero.Location = new System.Drawing.Point(12, 39);
            this.textBoxGenero.Name = "textBoxGenero";
            this.textBoxGenero.Size = new System.Drawing.Size(200, 20);
            this.textBoxGenero.TabIndex = 1;

            // btnEjecutarConsulta
            this.btnEjecutarConsulta.Location = new System.Drawing.Point(12, 65);
            this.btnEjecutarConsulta.Name = "btnEjecutarConsulta";
            this.btnEjecutarConsulta.Size = new System.Drawing.Size(200, 23);
            this.btnEjecutarConsulta.TabIndex = 2;
            this.btnEjecutarConsulta.Text = "Ejecutar Consulta";
            this.btnEjecutarConsulta.UseVisualStyleBackColor = true;
            this.btnEjecutarConsulta.Click += new System.EventHandler(this.btnEjecutarConsulta_Click);

            // dataGridViewResultados
            this.dataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultados.Location = new System.Drawing.Point(12, 94);
            this.dataGridViewResultados.Name = "dataGridViewResultados";
            this.dataGridViewResultados.Size = new System.Drawing.Size(400, 200);
            this.dataGridViewResultados.TabIndex = 3;

            // FormConsultasReportes
            this.ClientSize = new System.Drawing.Size(424, 306);
            this.Controls.Add(this.dataGridViewResultados);
            this.Controls.Add(this.btnEjecutarConsulta);
            this.Controls.Add(this.textBoxGenero);
            this.Controls.Add(this.comboBoxConsulta);
            this.Name = "FormConsultasReportes";
            this.Text = "Consultas y Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
