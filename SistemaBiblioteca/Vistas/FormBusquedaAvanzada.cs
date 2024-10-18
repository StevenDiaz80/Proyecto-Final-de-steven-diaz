
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


namespace SistemaBiblioteca.Vistas
{
    public partial class FormBusquedaAvanzada : Form
    {
        private LibroController libroController;

        public FormBusquedaAvanzada()
        {
            InitializeComponent();
            libroController = new LibroController(); // Inicializa tu controlador de libros
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            string isbn = txtISBN.Text;
            string genero = cmbGenero.SelectedItem?.ToString(); // Asegúrate de tener este ComboBox

            DataTable resultados = libroController.BuscarLibros(titulo, autor, isbn, genero);
            dataGridViewResultados.DataSource = resultados; // Asigna el resultado a un DataGridView
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarACSV(dataGridViewResultados.DataSource as DataTable);
        }

        private void ExportarACSV(DataTable dataTable)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();

                    // Agregar encabezados
                    IEnumerable<string> columnNames = dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
                    sb.AppendLine(string.Join(",", columnNames));

                    // Agregar filas
                    foreach (DataRow row in dataTable.Rows)
                    {
                        IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                        sb.AppendLine(string.Join(",", fields));
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString());
                    MessageBox.Show("Exportación a CSV completada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
