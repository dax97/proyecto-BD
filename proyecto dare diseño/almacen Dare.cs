using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;

namespace proyecto_dare_diseño
{
    public partial class almacen_Dare : Form
    {
        public almacen_Dare()
        {
            InitializeComponent();
        }

        private void buscar_Click(object sender, EventArgs e)
        {


            if (searchdata.Text == "")
            {
                MessageBox.Show("favor de escribir un dato");
            }
            else
            {
                panel.DataSource = ProductoFUN.consulta(searchdata.Text, searchdata.Text);
                if (panel.DisplayedRowCount(true).Equals(0))
                {
                    MessageBox.Show("no se ha encontrado ningún producto");
                }

            }
        }

        private void alta_Click(object sender, EventArgs e)
        {
            alta alta = new alta();
            alta.ShowDialog();
        }

        private void baja_Click(object sender, EventArgs e)
        {
            if (panel.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("¿Está seguro de eliminar este producto?", "seguro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string x = "";
                    x = Convert.ToString(panel.CurrentRow.Cells[0].Value);
                    string y = "";
                    y = Convert.ToString(panel.CurrentRow.Cells[1].Value);
                    ProductoFUN.baja(x, y);
                    panel.DataSource = ProductoFUN.consulta(searchdata.Text, searchdata.Text);
                    MessageBox.Show("producto eliminado");
                }
                else

                    MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("seleccione linea");
            }
        }

        private void generarPDF_Click(object sender, EventArgs e)
        {

            Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"C:";
            saveFileDialog.Title = "Guardar Reporte";
            saveFileDialog.DefaultExt = "pdf";
            saveFileDialog.Filter = "pdf Files (*.pdf)|*pdf| All Files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            string nombrearchivo = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                nombrearchivo = saveFileDialog.FileName;
            }

            if (nombrearchivo.Trim() != "")
            {
                almacen_Dare x = new almacen_Dare();
                FileStream archivo = new FileStream(nombrearchivo, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, archivo);
                doc.Open();
                string remitente = "Dare Automatizacion y Control.";
                string fecha = "Fecha:" + DateTime.Now.ToString();

                Chunk chunk = new Chunk("Cotizacion de Producto", FontFactory.GetFont("Arial", 20, iTextSharp.text.Font.BOLD));
                doc.Add(new Paragraph(chunk));
                doc.Add(new Paragraph("           "));
                doc.Add(new Paragraph("           "));
                doc.Add(new Paragraph("-------------------------------------------"));
                doc.Add(new Paragraph("Jaina 19, Col. Letran Valle, Del. Bennito Juárez, Ciudad de México"));
                doc.Add(new Paragraph(remitente));
                doc.Add(new Paragraph(fecha));
                doc.Add(new Paragraph("-------------------------------------------"));
                doc.Add(new Paragraph("           "));
                doc.Add(new Paragraph("           "));
                doc.Add(new Paragraph("           "));
                GenerarDocumento(doc);
                doc.AddCreationDate();
                doc.Close();
                Process.Start(nombrearchivo);

            }

        }

        public void GenerarDocumento(Document documento)
        {
            
            PdfPTable database = new PdfPTable(6);
            database.DefaultCell.Padding = 3;
           
            database.WidthPercentage = 100;
            database.DefaultCell.BorderWidth = 2;

            foreach (DataGridViewColumn column in panel.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));

                database.AddCell(cell);
            }


            if (panel.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow row in panel.SelectedRows)//se cambia solo a rows para imprimir todo el data grid
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        try
                        {
                            database.AddCell(new Phrase(cell.Value.ToString()));
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("error");
                        }
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in panel.Rows)//se cambia solo a rows para imprimir todo el data grid
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        try
                        {
                            database.AddCell(new Phrase(cell.Value.ToString()));
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("error");
                        }
                    }
                }
            }

            documento.Add(database);
        }

        private void searchdata_TextChanged(object sender, EventArgs e)
        {

        }

        private void almacen_Dare_Load(object sender, EventArgs e)
        {


        }

        private void almacen_Dare_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void panel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
